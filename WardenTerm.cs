using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminstraterSchoolAccomedation
{
    public partial class WardenTerm : Form
    {
        SQLConnecction connect = new SQLConnecction();        
        public WardenTerm()
        {
            InitializeComponent();
            tables();
        }

        private void DBTermainte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = this.DBTermainte.Rows[e.RowIndex];
            StudentIDs.Text = rows.Cells["Student_ID"].Value.ToString();
            RoomType.Text = rows.Cells["Unit_Type"].Value.ToString();
            StartDate.Text = rows.Cells["Start_Date"].Value.ToString();
            DueDate.Text = rows.Cells["Due_Date"].Value.ToString();
            DeclineRequest.Text = rows.Cells["Request"].Value.ToString();
        }
        private void tables()
        {
            connect.SQL_layout("select * from Termination");
            DataTable dt = new DataTable();
            connect.adapt.Fill(dt);
            DBTermainte.DataSource = dt ;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            connect.SQL_Command("delete Termination where Student_ID = '" + StudentIDs.Text + "'");
            connect.SQL_Command("update Student_Rooms set Room_Status = 'Vacant' where Student_ID = '" + StudentIDs.Text + "'");
            connect.SQL_Command("update Room_INFO set RoomStates = 'Available' where RoomID = '" + RoomType.Text + "'");
            MessageBox.Show("Your request has been conformed.", "Conformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tables();
        }
    }
}
