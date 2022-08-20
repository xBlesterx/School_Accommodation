using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminstraterSchoolAccomedation
{
    public partial class WardenReport : Form
    {
        SQLConnecction con = new SQLConnecction();
        public WardenReport()
        {
            InitializeComponent();
            table();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FTblocktype.Text) || !String.IsNullOrEmpty(FTroomstatus.Text))
            {
                DataTable dt = new DataTable();
                con.SQL_layout("Select * from Student_Rooms where Room_Status = '" + FTroomstatus.Text + "' or Block_Type = '" + FTblocktype.Text + "'");
                con.adapt.Fill(dt);
                DBReport.DataSource = dt;
            }
            else { table(); }
        }
        private void table()
        {
            DataTable dt = new DataTable();
            con.SQL_layout("Select * from Student_Rooms");
            con.adapt.Fill(dt);
            DBReport.DataSource = dt;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Warden wr = new Warden();
            this.Close();
            wr.Show();
        }
    }
}
