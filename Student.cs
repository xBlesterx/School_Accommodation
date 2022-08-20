using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminstraterSchoolAccomedation
{
    class Student
    {
        SQLConnecction con = new SQLConnecction();
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string UnitType { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }

        public Student(string SID,string SN,string SG,string SE, string SCN,string SUT,string SCID, string SCOD)
        {
            this.StudentID = SID;
            this.Name = SN;
            this.Gender = SG;
            this.Email = SE;
            this.ContactNumber = SCN;
            this.UnitType = SUT;
            this.CheckInDate = SCID;
            this.CheckOutDate = SCOD;
        }

    }
}
