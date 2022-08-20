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
    public partial class Warden : Form
    {
        DataTable roomdt = new DataTable();
        SQLConnecction connect = new SQLConnecction();
        string studentName;
        SqlConnection CON = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\alexl\\OneDrive\\Desktop\\IOOP SHIT\\AdminstraterSchoolAccomedation\\AdminstraterSchoolAccomedation\\Data.mdf\";Integrated Security=True");
        public Warden()
        {

            InitializeComponent();
            studentINFOrmation();
            roomINFOrmation();
            CON.Open();
        }

        private void Warden_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        


        private void studentINFOrmation()
        {
            SqlDataAdapter adapt;
            SqlDataAdapter adapter;
            DataSet ds = new DataSet();
            DataTable studentdt = new DataTable();
            adapt = new SqlDataAdapter("select * from Student_INFO", CON);
            adapter = new SqlDataAdapter("select Student_ID from Student_INFO", CON);
            adapt.Fill(studentdt);
            adapter.Fill(ds, "Student_INFO");
            AccommodationRooms.DataSource = studentdt;
        }
        private void roomINFOrmation()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from Room_INFO", CON);
            adapter.Fill(roomdt);
            RoomsINFO.DataSource = roomdt;
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void AccommodationRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            DataGridViewRow row = this.AccommodationRooms.Rows[e.RowIndex];
            if (row != null)
            {
                studentName = row.Cells["Student_Name"].Value.ToString();
                StudentIDs.Text = row.Cells["Student_ID"].Value.ToString();
                RoomType.Text = row.Cells["Unit_Type"].Value.ToString();
                StartDate.Text = row.Cells["Start_Date"].Value.ToString();
                DueDate.Text = row.Cells["Due_Date"].Value.ToString();
            }
          

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(RoomID.Text))
            {
                Accept.Enabled = false;
            }
            else { Accept.Enabled = true; }
            if (String.IsNullOrWhiteSpace(DeclineRequest.Text))
            {
                Decline.Enabled = false;
            }
            else { Decline.Enabled = true; }
            
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            DataTable dr = new DataTable(); ;
            connect.SQL_layout("Select BlockType from Room_INFO where RoomID = '"+RoomID.Text+"'");
            connect.adapt.Fill(dr);
            int count = 0;
            for (int x = 0; x< roomdt.Rows.Count; x++)
            {
                if (RoomID.Text == roomdt.Rows[x][0].ToString())
                {
                    connect.SQL_Command("INSERT into Student_Rooms(Room_ID, Block_Type, Student_ID, Student_Name, Start_Date, End_Date, Room_Status) values ('" + RoomID.Text + "','"+dr.Rows[0][0].ToString()+"','" + StudentIDs.Text + "','" + studentName + "','" + StartDate.Text + "'," +
                    "'" + DueDate.Text + "','Occupied')");

                    connect.SQL_Command("UPDATE Room_INFO SET RoomStates = 'Not Available' WHERE RoomID ='" + RoomID.Text + "'");

                    connect.SQL_Command("Delete Student_INFO WHERE Student_ID = '" + StudentIDs.Text + "'");
                    MessageBox.Show($"Your request for student {studentName} has been accepted");
                    
                    RoomID.Text = "";
                }
                else { count++; }
            }
            if (count == roomdt.Rows.Count)
            {
                MessageBox.Show("Incorrect RoomID, Please recheck the RoomID");
                RoomID.Text = "";
            }
            studentINFOrmation();
            roomINFOrmation();
        }

        private void Decline_Click(object sender, EventArgs e)
        {
            connect.SQL_Command("Delete Student_INFO WHERE Student_ID = '" + StudentIDs.Text + "'");

            connect.SQL_Command("insert into Declined_Students(Student_ID,Student_Name,Unit_Type,Reason) values ('" + StudentIDs.Text + "','" + studentName + "','" + RoomType.Text + "','" + DeclineRequest.Text + "')");

            studentINFOrmation();
            roomINFOrmation();
            MessageBox.Show($"Student {studentName} has been Decline");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WardenTerm WT = new WardenTerm();
            WT.Show();
            this.Close();
        }

        private void FeedBack_Click(object sender, EventArgs e)
        {
            WardenFeed feed = new WardenFeed();
            feed.Show();
            this.Close();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            WardenReport wr = new WardenReport();
            wr.Show();
            this.Close();
        }
    }
}

/*
        private void button1_Click(object sender, EventArgs e)
        {
            
            string command = "UPDATE Room_INFO SET RoomStates = @States WHERE RoomID = @ID";
            connection.Open();
            SqlCommand command1 = new SqlCommand(command,connection);
            command1.Parameters.AddWithValue("@States" , comboBox1.Text);
            command1.Parameters.AddWithValue("@ID", IDKLOL.Text);
            int i = command1.ExecuteNonQuery();
            connection.Close();
            DisplayData();
        }
        private void DisplayData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Room_INFO", connection);
            adapt.Fill(dt);
            AccommodationRooms.DataSource = dt;
            connection.Close();
        }
        */