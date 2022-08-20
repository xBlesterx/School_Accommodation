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
    public partial class WardenFeed : Form
    {
        SQLConnecction connect = new SQLConnecction();
        DataTable TBfeed = new DataTable();
        
        
        public WardenFeed()
        {
            InitializeComponent();
            table();
            timer1.Start();
            
        }

        private void table()
        {

            connect.SQL_layout("select * from FeedBack");
            connect.adapt.Fill(TBfeed);
            DBFeedBack.DataSource = TBfeed;

        }

        private void DBFeedBack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DBFeedBack.Rows[e.RowIndex];
            txtStudentIDs.Text = row.Cells["Student_ID"].Value.ToString();
            txtRoomType.Text = row.Cells["Room_ID"].Value.ToString();
            txtRequestStatus.Text = row.Cells["Request_Status"].Value.ToString();
            txtFeedback.Text = row.Cells["Feedback"].Value.ToString();
            txtStatement.Text = row.Cells["Warden_Statement"].Value.ToString();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtRequestStatus.Text == "New Request")
            {
                connect.SQL_Command("update FeedBack set Request_Status = 'Request in Process' , Warden_Statement = '" + txtStatement.Text + "'" +
                    " where Student_ID = '" + txtStudentIDs.Text + "'");
            }
            else if(txtRequestStatus.Text == "Request in Process")
            {
                connect.SQL_Command("update FeedBack set Request_Status = 'Request Completed' , Warden_Statement = '" + txtStatement.Text + "'" +
                    " where Student_ID = '" + txtStudentIDs.Text + "'");  
            }
            connect.SQL_Command("Delete From FeedBack Where Request_Status = 'Request_Completed' ");
            MessageBox.Show($"Your update for student {txtStudentIDs.Text} is conformed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            table();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtStatement.Text == "NULL" || txtStatement.Text == "")
            {
                btnDone.Enabled = false;
            }
            else { btnDone.Enabled = true; }
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Warden wr = new Warden();
            wr.Show();
            this.Close();
        }
    }
}
