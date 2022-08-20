
namespace AdminstraterSchoolAccomedation
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccomedationForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.student = new System.Windows.Forms.Button();
            this.Warden = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(290, 224);
            this.panel1.TabIndex = 3;
            // 
            // AccomedationForm
            // 
            this.AccomedationForm.AutoSize = true;
            this.AccomedationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccomedationForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccomedationForm.Location = new System.Drawing.Point(55, 178);
            this.AccomedationForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccomedationForm.Name = "AccomedationForm";
            this.AccomedationForm.Size = new System.Drawing.Size(151, 31);
            this.AccomedationForm.TabIndex = 2;
            this.AccomedationForm.Text = "Main Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-440, -330);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 494);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // student
            // 
            this.student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.student.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.Color.White;
            this.student.Location = new System.Drawing.Point(294, 0);
            this.student.Margin = new System.Windows.Forms.Padding(2);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(236, 221);
            this.student.TabIndex = 19;
            this.student.Text = "Student ";
            this.student.UseVisualStyleBackColor = false;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // Warden
            // 
            this.Warden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.Warden.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warden.ForeColor = System.Drawing.Color.White;
            this.Warden.Location = new System.Drawing.Point(534, 0);
            this.Warden.Margin = new System.Windows.Forms.Padding(2);
            this.Warden.Name = "Warden";
            this.Warden.Size = new System.Drawing.Size(234, 221);
            this.Warden.TabIndex = 20;
            this.Warden.Text = "Warden";
            this.Warden.UseVisualStyleBackColor = false;
            this.Warden.Click += new System.EventHandler(this.Warden_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1010, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(234, 221);
            this.btn_close.TabIndex = 21;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.Location = new System.Drawing.Point(772, 0);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(234, 221);
            this.btnFeedback.TabIndex = 22;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 224);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.Warden);
            this.Controls.Add(this.student);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AccomedationForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button Warden;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btnFeedback;
    }
}