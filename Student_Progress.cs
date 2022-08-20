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
    public partial class Student_Progress : Form
    {
        SQLConnecction layout = new SQLConnecction();
        Studentform st = new Studentform();
        DataTable Declinedst = new DataTable();
        DataTable studentRoom = new DataTable();
        public Student_Progress()
        {
            InitializeComponent();
            Tables();
            Pg_Name.Visible = false;
            Pg_Reason.Visible = false;
            Pg_States.Visible = false;
            Pg_UnitType.Visible = false;
        }

        private void Pg_Back_Click(object sender, EventArgs e)
        {
            
            st.Show();
            this.Close();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Pg_next_Click(object sender, EventArgs e)
        {
            Checking();
            
        }
        private void Tables()
        {

            layout.SQL_layout("Select * From Declined_Students");
            layout.adapt.Fill(Declinedst);

            layout.SQL_layout("select * from Student_Rooms");
            layout.adapt.Fill(studentRoom);
           
        }
        private void Checking()
        {
            
            int count = 0;
            int count2 = 0;
            for (int i = 0; i<Declinedst.Rows.Count;i++)
            {
                if (Declinedst.Rows[i][0].ToString() == Pg_IDInput.Text)
                {
                    Pg_Name.Visible = true;
                    Pg_Reason.Visible = true;
                    Pg_States.Visible = true;
                    Pg_UnitType.Visible = true;
                    Pg_Name.Text = Declinedst.Rows[i][1].ToString();
                    Pg_States.Text = "Declined";
                    Pg_Reason.Text = ($"{Declinedst.Rows[i][3].ToString()}.\nReaply using the Application Form and change the Unit Type.");
                    Pg_UnitType.Text = Declinedst.Rows[i][2].ToString();


                }
                else { count++; }
            }

            for (int i = 0 ; i < studentRoom.Rows.Count;i++)
            {
                if (studentRoom.Rows[i][1].ToString() == Pg_IDInput.Text)
                {
                    Pg_Name.Visible = true;
                    Pg_Reason.Visible = true;
                    Pg_States.Visible = true;
                    Pg_UnitType.Visible = true;
                    Pg_Name.Text = studentRoom.Rows[i][2].ToString();
                    Pg_States.Text = "Accepted";
                    label5.Text = "Note";
                    Pg_Reason.Text = "The Room you have choosen have been accepted";
                    Pg_UnitType.Text = studentRoom.Rows[i][0].ToString();
                }
                else { count2++; }
            }



            if (count == Declinedst.Rows.Count && count2 == studentRoom.Rows.Count)
            {
                MessageBox.Show("Your request is still under progress","Checking",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void PG_Reapply_Click(object sender, EventArgs e)
        {
            st.Show();
            this.Close();
             
        }
    }
}
