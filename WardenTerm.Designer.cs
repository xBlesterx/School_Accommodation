
namespace AdminstraterSchoolAccomedation
{
    partial class WardenTerm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WardenTerm));
            this.AccomedationForm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.DeclineRequest = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.StudentIDs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.TextBox();
            this.RoomType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DBTermainte = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DueDate = new System.Windows.Forms.TextBox();
            this.page = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBTermainte)).BeginInit();
            this.page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AccomedationForm
            // 
            this.AccomedationForm.AutoSize = true;
            this.AccomedationForm.BackColor = System.Drawing.Color.Transparent;
            this.AccomedationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccomedationForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccomedationForm.Location = new System.Drawing.Point(2, 61);
            this.AccomedationForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccomedationForm.Name = "AccomedationForm";
            this.AccomedationForm.Size = new System.Drawing.Size(206, 62);
            this.AccomedationForm.TabIndex = 2;
            this.AccomedationForm.Text = "Accomedation \r\nForm";
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
            this.panel1.Size = new System.Drawing.Size(203, 798);
            this.panel1.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label13.Location = new System.Drawing.Point(7, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 50);
            this.label13.TabIndex = 37;
            this.label13.Text = "Resean for \r\nTermination:";
            // 
            // DeclineRequest
            // 
            this.DeclineRequest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DeclineRequest.Enabled = false;
            this.DeclineRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeclineRequest.ForeColor = System.Drawing.Color.Black;
            this.DeclineRequest.Location = new System.Drawing.Point(191, 316);
            this.DeclineRequest.Multiline = true;
            this.DeclineRequest.Name = "DeclineRequest";
            this.DeclineRequest.Size = new System.Drawing.Size(437, 180);
            this.DeclineRequest.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label12.Location = new System.Drawing.Point(163, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(371, 32);
            this.label12.TabIndex = 34;
            this.label12.Text = "Selct the student from the Student Request Database\r\nto reveal the information.";
            // 
            // StudentIDs
            // 
            this.StudentIDs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StudentIDs.Enabled = false;
            this.StudentIDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.StudentIDs.Location = new System.Drawing.Point(191, 121);
            this.StudentIDs.Name = "StudentIDs";
            this.StudentIDs.Size = new System.Drawing.Size(326, 31);
            this.StudentIDs.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label6.Location = new System.Drawing.Point(3, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Terminate Requests";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(633, 465);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(156, 50);
            this.btn_Close.TabIndex = 21;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept.ForeColor = System.Drawing.Color.White;
            this.Accept.Location = new System.Drawing.Point(633, 411);
            this.Accept.Margin = new System.Windows.Forms.Padding(2);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(156, 50);
            this.Accept.TabIndex = 19;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "Termination Requests";
            // 
            // StartDate
            // 
            this.StartDate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StartDate.Enabled = false;
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.StartDate.Location = new System.Drawing.Point(191, 222);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(326, 31);
            this.StartDate.TabIndex = 8;
            // 
            // RoomType
            // 
            this.RoomType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RoomType.Enabled = false;
            this.RoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.RoomType.Location = new System.Drawing.Point(191, 170);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(326, 31);
            this.RoomType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(8, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label3.Location = new System.Drawing.Point(8, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(8, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(8, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // DBTermainte
            // 
            this.DBTermainte.AllowUserToAddRows = false;
            this.DBTermainte.AllowUserToDeleteRows = false;
            this.DBTermainte.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DBTermainte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBTermainte.Location = new System.Drawing.Point(3, 527);
            this.DBTermainte.Name = "DBTermainte";
            this.DBTermainte.ReadOnly = true;
            this.DBTermainte.RowTemplate.ReadOnly = true;
            this.DBTermainte.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DBTermainte.Size = new System.Drawing.Size(790, 268);
            this.DBTermainte.TabIndex = 1;
            this.DBTermainte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBTermainte_CellContentClick);
            // 
            // DueDate
            // 
            this.DueDate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DueDate.Enabled = false;
            this.DueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.DueDate.Location = new System.Drawing.Point(191, 273);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(326, 31);
            this.DueDate.TabIndex = 9;
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.SystemColors.ControlLight;
            this.page.Controls.Add(this.label13);
            this.page.Controls.Add(this.DeclineRequest);
            this.page.Controls.Add(this.label12);
            this.page.Controls.Add(this.StudentIDs);
            this.page.Controls.Add(this.label6);
            this.page.Controls.Add(this.btn_Close);
            this.page.Controls.Add(this.Accept);
            this.page.Controls.Add(this.label5);
            this.page.Controls.Add(this.DueDate);
            this.page.Controls.Add(this.StartDate);
            this.page.Controls.Add(this.RoomType);
            this.page.Controls.Add(this.label4);
            this.page.Controls.Add(this.label3);
            this.page.Controls.Add(this.label2);
            this.page.Controls.Add(this.label1);
            this.page.Controls.Add(this.DBTermainte);
            this.page.Dock = System.Windows.Forms.DockStyle.Right;
            this.page.Location = new System.Drawing.Point(203, 0);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(796, 798);
            this.page.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-277, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 806);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WardenTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 798);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WardenTerm";
            this.Text = "WardenTerm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBTermainte)).EndInit();
            this.page.ResumeLayout(false);
            this.page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AccomedationForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DeclineRequest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox StudentIDs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StartDate;
        private System.Windows.Forms.TextBox RoomType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DBTermainte;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox DueDate;
        private System.Windows.Forms.Panel page;
    }
}