
namespace AdminstraterSchoolAccomedation
{
    partial class Studentform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studentform));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UnitType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.CheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckINDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.AccomedationForm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.NumberInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDInput = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Termination = new System.Windows.Forms.Button();
            this.Pg_Progress = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // UnitType
            // 
            this.UnitType.BackColor = System.Drawing.SystemColors.Info;
            this.UnitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitType.FormattingEnabled = true;
            this.UnitType.Location = new System.Drawing.Point(217, 345);
            this.UnitType.Margin = new System.Windows.Forms.Padding(2);
            this.UnitType.Name = "UnitType";
            this.UnitType.Size = new System.Drawing.Size(226, 33);
            this.UnitType.TabIndex = 21;
            this.toolTip1.SetToolTip(this.UnitType, "For more information about the rooms please check our website.\r\n");
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label8.Location = new System.Drawing.Point(43, 342);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 33);
            this.label8.TabIndex = 20;
            this.label8.Text = "Unit Type:";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(428, 513);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(103, 37);
            this.btn_Close.TabIndex = 19;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(321, 513);
            this.Submit.Margin = new System.Windows.Forms.Padding(2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(103, 37);
            this.Submit.TabIndex = 18;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click_1);
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutDate.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.CheckOutDate.Enabled = false;
            this.CheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutDate.Location = new System.Drawing.Point(217, 442);
            this.CheckOutDate.Margin = new System.Windows.Forms.Padding(2);
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Size = new System.Drawing.Size(226, 23);
            this.CheckOutDate.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label7.Location = new System.Drawing.Point(43, 433);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 33);
            this.label7.TabIndex = 16;
            this.label7.Text = "CheckOut:";
            // 
            // CheckINDate
            // 
            this.CheckINDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckINDate.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.CheckINDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckINDate.Location = new System.Drawing.Point(217, 398);
            this.CheckINDate.Margin = new System.Windows.Forms.Padding(2);
            this.CheckINDate.Name = "CheckINDate";
            this.CheckINDate.Size = new System.Drawing.Size(228, 23);
            this.CheckINDate.TabIndex = 15;
            this.CheckINDate.ValueChanged += new System.EventHandler(this.CheckINDate_ValueChanged_1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label6.Location = new System.Drawing.Point(43, 389);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "CheckIN:";
            // 
            // AccomedationForm
            // 
            this.AccomedationForm.AutoSize = true;
            this.AccomedationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccomedationForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccomedationForm.Location = new System.Drawing.Point(11, 427);
            this.AccomedationForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccomedationForm.Name = "AccomedationForm";
            this.AccomedationForm.Size = new System.Drawing.Size(273, 31);
            this.AccomedationForm.TabIndex = 2;
            this.AccomedationForm.Text = "Accomedation Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.AccomedationForm);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 561);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-169, -41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 466);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GenderBox
            // 
            this.GenderBox.BackColor = System.Drawing.SystemColors.Info;
            this.GenderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Location = new System.Drawing.Point(217, 203);
            this.GenderBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(226, 33);
            this.GenderBox.TabIndex = 13;
            // 
            // NumberInput
            // 
            this.NumberInput.BackColor = System.Drawing.SystemColors.Info;
            this.NumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberInput.Location = new System.Drawing.Point(217, 297);
            this.NumberInput.Margin = new System.Windows.Forms.Padding(2);
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.Size = new System.Drawing.Size(228, 30);
            this.NumberInput.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label5.Location = new System.Drawing.Point(38, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contact #:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(43, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender:";
            // 
            // EmailInput
            // 
            this.EmailInput.BackColor = System.Drawing.SystemColors.Info;
            this.EmailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.Location = new System.Drawing.Point(217, 249);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(228, 30);
            this.EmailInput.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label3.Location = new System.Drawing.Point(43, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // NameInput
            // 
            this.NameInput.BackColor = System.Drawing.SystemColors.Info;
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(217, 157);
            this.NameInput.Margin = new System.Windows.Forms.Padding(2);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(228, 30);
            this.NameInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(43, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // IDInput
            // 
            this.IDInput.BackColor = System.Drawing.SystemColors.Info;
            this.IDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDInput.Location = new System.Drawing.Point(217, 114);
            this.IDInput.Margin = new System.Windows.Forms.Padding(2);
            this.IDInput.Name = "IDInput";
            this.IDInput.Size = new System.Drawing.Size(228, 30);
            this.IDInput.TabIndex = 4;
            // 
            // Name1
            // 
            this.Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.Name1.Location = new System.Drawing.Point(43, 111);
            this.Name1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(169, 33);
            this.Name1.TabIndex = 3;
            this.Name1.Text = "StudentID:";
            // 
            // SignUp
            // 
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.SignUp.Location = new System.Drawing.Point(6, 9);
            this.SignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(437, 62);
            this.SignUp.TabIndex = 2;
            this.SignUp.Text = "Accommedation Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.Termination);
            this.panel2.Controls.Add(this.Pg_Progress);
            this.panel2.Controls.Add(this.UnitType);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Controls.Add(this.Submit);
            this.panel2.Controls.Add(this.CheckOutDate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CheckINDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.GenderBox);
            this.panel2.Controls.Add(this.NumberInput);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.EmailInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.NameInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.IDInput);
            this.panel2.Controls.Add(this.Name1);
            this.panel2.Controls.Add(this.SignUp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(288, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 561);
            this.panel2.TabIndex = 3;
            // 
            // Termination
            // 
            this.Termination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.Termination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Termination.ForeColor = System.Drawing.Color.White;
            this.Termination.Location = new System.Drawing.Point(75, 513);
            this.Termination.Margin = new System.Windows.Forms.Padding(2);
            this.Termination.Name = "Termination";
            this.Termination.Size = new System.Drawing.Size(119, 37);
            this.Termination.TabIndex = 23;
            this.Termination.Text = "Termination";
            this.Termination.UseVisualStyleBackColor = false;
            this.Termination.Click += new System.EventHandler(this.Termination_Click);
            // 
            // Pg_Progress
            // 
            this.Pg_Progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.Pg_Progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pg_Progress.ForeColor = System.Drawing.Color.White;
            this.Pg_Progress.Location = new System.Drawing.Point(198, 513);
            this.Pg_Progress.Margin = new System.Windows.Forms.Padding(2);
            this.Pg_Progress.Name = "Pg_Progress";
            this.Pg_Progress.Size = new System.Drawing.Size(119, 37);
            this.Pg_Progress.TabIndex = 22;
            this.Pg_Progress.Text = "Progress Report";
            this.Pg_Progress.UseVisualStyleBackColor = false;
            this.Pg_Progress.Click += new System.EventHandler(this.Pg_Progress_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox UnitType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.DateTimePicker CheckOutDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker CheckINDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AccomedationForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.TextBox NumberInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDInput;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Pg_Progress;
        private System.Windows.Forms.Button Termination;
    }
}