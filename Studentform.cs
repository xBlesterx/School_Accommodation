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
    public partial class Studentform : Form
    {
        List<string> variable;
        SQLConnecction con = new SQLConnecction();
        DataTable Declinedst = new DataTable();
        Student submit;
        public Studentform()
        {
            InitializeComponent();
            GenderBox.Items.Add("Male");
            GenderBox.Items.Add("Female");
            UnitType.Items.Add("Super Premium - En - Suite Single");
            UnitType.Items.Add("Super Premium - En - Suite Twin");
            UnitType.Items.Add("Premium - En - Suite Single");
            UnitType.Items.Add("Premium - En - Suite Twin");
            UnitType.Items.Add("Deluxe - En - Suite Single");
            UnitType.Items.Add("Standard - En - Suite Single");
            UnitType.Items.Add("Compact - En - Suit Single");
            CheckOutDate.Enabled = false;
            timer1.Start();
        }

   

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Click_1(object sender, EventArgs e)
        {
            SQLConnecction con = new SQLConnecction();
            submit = new Student(IDInput.Text, NameInput.Text, GenderBox.Text, EmailInput.Text, NumberInput.Text,
            UnitType.Text, CheckINDate.Text, CheckOutDate.Text);
            {
                if (checking() == false)
                {

                    string Command = "insert into Student_INFO(Student_ID, Student_Name, Student_Gender, Student_Email, Contact_Number, Unit_Type, Start_Date, Due_Date, Re_appling) values ('"+submit.StudentID + "','" + submit.Name + "','" + submit.Gender + "','" + submit.Email + "'," +
                        "'" + submit.ContactNumber + "','" + submit.UnitType + "','" + submit.CheckInDate + "','" + submit.CheckOutDate + "','New Application')";
                    con.SQL_Command(Command);
                    MessageBox.Show($"Thank you For your submittion Mr/Mrs {NameInput.Text}\nWe will get back to you as soon as possbile.");
                }
                else
                {
                    string Command = "insert into Student_INFO(Student_ID, Student_Name, Student_Gender, Student_Email, Contact_Number, Unit_Type, Start_Date, Due_Date, Re_appling) values ('" + submit.StudentID + "','" + submit.Name + "','" + submit.Gender + "','" + submit.Email + "'," +
                        "'" + submit.ContactNumber + "','" + submit.UnitType + "','" + submit.CheckInDate + "','" + submit.CheckOutDate + "','Re-Applying')";
                    con.SQL_Command(Command);
                    MessageBox.Show($"Thank you For your submittion Mr/Mrs {NameInput.Text}\nWe will get back to you as soon as possbile.");
                }

            }
            
        }

        private void CheckINDate_ValueChanged_1(object sender, EventArgs e)
        {
            CheckOutDate.Value = CheckINDate.Value.AddDays(40);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            variable = new List<string> {IDInput.Text,NameInput.Text,GenderBox.Text,EmailInput.Text,NumberInput.Text,
            UnitType.Text,CheckINDate.Text,CheckOutDate.Text};
            for (int x = 0; x < variable.Count()-2; x++)
            {
                if (String.IsNullOrEmpty(variable[x]))
                {
                    Submit.Enabled = false;
                }
                else { Submit.Enabled = true; }
            }
        }

        private void Pg_Progress_Click(object sender, EventArgs e)
        {
            Student_Progress st = new Student_Progress();
            st.Show();
            this.Close();
        }
        private bool checking()
        {
            bool idcheck = false;
            
            con.SQL_layout("Select * From Declined_Students");
            con.adapt.Fill(Declinedst);
            
            for (int i = 0; i < Declinedst.Rows.Count; i++) 
            {
                if (Declinedst.Rows[i][0].ToString() == IDInput.Text)
                {
                    idcheck = true;
                    con.SQL_Command("Delete from Declined_Students Where Student_ID = '" + IDInput.Text + "'");
                }
                
            }
            return idcheck;
        }

        private void Termination_Click(object sender, EventArgs e)
        {
            Terminate tm = new Terminate();
            tm.Show();
            this.Close();
        }
    }
}
