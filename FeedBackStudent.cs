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
    public partial class FeedBackStudent : Form
    {
        SQLConnecction connect = new SQLConnecction();
        DataTable stRoom = new DataTable();
        DataTable feed = new DataTable();
        public FeedBackStudent()
        {
            InitializeComponent();
            table();
            timer1.Start();

        }

        private void Pg_next_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < stRoom.Rows.Count; i++)
            {
                if (stRoom.Rows[i][2].ToString() == Pg_IDInput.Text)
                {
                    Pg_UnitType.Visible = true;
                    Pg_Reason.Visible = true;
                    Pg_UnitType.Text = stRoom.Rows[i][0].ToString();
                }
                else { count++; }
            }
            if ( count == stRoom.Rows.Count)
            {
                MessageBox.Show("The Student TP# is not in the accommedation.Please try again","Information",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void table()
        {
            connect.SQL_layout("select * from Student_Rooms");
            connect.adapt.Fill(stRoom);

            connect.SQL_layout("select * from FeedBack");
            connect.adapt.Fill(feed);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            connect.SQL_Command("insert into FeedBack(Student_ID, Room_ID, Feedback, Request_Status, Warden_Statement) values('" + Pg_IDInput.Text + "'" +
                ",'" + Pg_UnitType.Text + "','" + Pg_Reason.Text + "','New Request','NULL')");
            MessageBox.Show("Your request has been conformed.","",MessageBoxButtons.OK);
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Pg_Reason.Text == "")
            {
                Submit.Enabled = false;
            }
            else { Submit.Enabled = true; }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void btnNewFeed_Click(object sender, EventArgs e)
        {
            pnNewFeed.Visible = true;
            Submit.Visible = true;
            pnCheckFeed.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnNewFeed.Visible = false;
            Submit.Visible = false;
            pnCheckFeed.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < feed.Rows.Count; i++)
            {
                if (feed.Rows[i][0].ToString() == txtIDInput.Text)
                {
                    txtRoomID.Visible = true;
                    txtFeedback.Visible = true;
                    txtStatus.Visible = true;
                    txtComment.Visible = true;
                    txtRoomID.Text = feed.Rows[i][1].ToString();
                    txtFeedback.Text = feed.Rows[i][2].ToString();
                    txtStatus.Text = feed.Rows[i][3].ToString();
                    txtComment.Text = feed.Rows[i][4].ToString();
                }
                else { count++; }
            }
            if (count == stRoom.Rows.Count)
            {
                MessageBox.Show("The Student TP# is not in the accommedation.Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
