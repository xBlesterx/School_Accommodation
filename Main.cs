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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void student_Click(object sender, EventArgs e)
        {
            Studentform student1 = new Studentform();
            student1.Show();
        }

        private void Warden_Click(object sender, EventArgs e)
        {
            Warden warden1 = new Warden();
            warden1.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FeedBackStudent fdStudent = new FeedBackStudent();
            fdStudent.Show();
        }
    }
}
