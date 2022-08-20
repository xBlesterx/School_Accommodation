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
    public partial class Terminate : Form
    {
        SQLConnecction connect = new SQLConnecction();
        Studentform st = new Studentform();
        DataTable stAccom = new DataTable();
        DataTable Term= new DataTable();
        string start_Date;
        string due_Date;

        public Terminate()
        {
            InitializeComponent();
            Tables();
            
        }

        private void Pg_next_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < stAccom.Rows.Count; i++)
            {
                if (stAccom.Rows[i][2].ToString() == Pg_IDInput.Text)
                {
                    Pg_Name.Visible = true;
                    Pg_Reason.Visible = true;
                    Pg_UnitType.Visible = true;
                    Pg_Name.Text = stAccom.Rows[i][2].ToString();
                    Pg_UnitType.Text = stAccom.Rows[i][0].ToString();
                    start_Date = stAccom.Rows[i][3].ToString();
                    due_Date = stAccom.Rows[i][4].ToString();
                }
            }
        }
        private void Tables()
        {
            connect.SQL_layout("select * from Student_Rooms");
            connect.adapt.Fill(stAccom);

            connect.SQL_layout("select * from Termination");
            connect.adapt.Fill(Term);

        }

        private void Pg_Terminate_Click(object sender, EventArgs e)
        {
            connect.SQL_Command("insert into Termination(Student_ID, Student_Name, Unit_Type, Start_Date, Due_Date, Request) values('" + Pg_IDInput.Text + "', '" + Pg_Name.Text + "'" +
                ",'" + Pg_UnitType.Text + "','" + start_Date + "','" + due_Date + "','" + Pg_Reason.Text + "')");
            MessageBox.Show("Your request has been sent.","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            st.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Pg_Reason.Text == "")
            {
                Pg_Terminate.Enabled = false;
            }
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
    }
}
