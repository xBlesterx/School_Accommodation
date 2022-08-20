using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdminstraterSchoolAccomedation
{
    public class SQLConnecction
    {
        public SqlDataAdapter adapt;
        //Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\schoolaccommodation.mdf;Integrated Security = True
        public SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\alexl\\OneDrive\\Desktop\\IOOP SHIT\\AdminstraterSchoolAccomedation\\AdminstraterSchoolAccomedation\\Data.mdf\";Integrated Security=True");
        

        public void SQL_layout(string command)
        {
            con.Open();
            adapt = new SqlDataAdapter(command,con);
            con.Close();
        }

        public void SQL_Command(string command)
        {
            con.Open();
            SqlCommand command1 = new SqlCommand(command,con);
            command1.ExecuteNonQuery();
            con.Close();
        }

        /*
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
    }
}
