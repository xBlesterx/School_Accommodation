
namespace AdminstraterSchoolAccomedation
{
    partial class WardenFeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WardenFeed));
            this.btnDone = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStudentIDs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccomedationForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRequestStatus = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DBFeedBack = new System.Windows.Forms.DataGridView();
            this.page = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatement = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBFeedBack)).BeginInit();
            this.page.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(311, 466);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(156, 50);
            this.btnDone.TabIndex = 19;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "Feedback Requests";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label13.Location = new System.Drawing.Point(7, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 50);
            this.label13.TabIndex = 37;
            this.label13.Text = "Student \r\nFeedback:\r\n";
            // 
            // txtFeedback
            // 
            this.txtFeedback.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFeedback.Enabled = false;
            this.txtFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.ForeColor = System.Drawing.Color.Black;
            this.txtFeedback.Location = new System.Drawing.Point(191, 281);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(437, 86);
            this.txtFeedback.TabIndex = 36;
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
            // txtStudentIDs
            // 
            this.txtStudentIDs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtStudentIDs.Enabled = false;
            this.txtStudentIDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentIDs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.txtStudentIDs.Location = new System.Drawing.Point(191, 121);
            this.txtStudentIDs.Name = "txtStudentIDs";
            this.txtStudentIDs.Size = new System.Drawing.Size(326, 31);
            this.txtStudentIDs.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label6.Location = new System.Drawing.Point(3, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Feedback Requests";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(472, 466);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(156, 50);
            this.btn_Close.TabIndex = 21;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
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
            this.panel1.Size = new System.Drawing.Size(203, 727);
            this.panel1.TabIndex = 7;
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
            // txtRequestStatus
            // 
            this.txtRequestStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRequestStatus.Enabled = false;
            this.txtRequestStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.txtRequestStatus.Location = new System.Drawing.Point(191, 222);
            this.txtRequestStatus.Name = "txtRequestStatus";
            this.txtRequestStatus.Size = new System.Drawing.Size(326, 31);
            this.txtRequestStatus.TabIndex = 8;
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRoomType.Enabled = false;
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.txtRoomType.Location = new System.Drawing.Point(191, 170);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(326, 31);
            this.txtRoomType.TabIndex = 7;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(8, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Request Status";
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
            // DBFeedBack
            // 
            this.DBFeedBack.AllowUserToAddRows = false;
            this.DBFeedBack.AllowUserToDeleteRows = false;
            this.DBFeedBack.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DBFeedBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBFeedBack.Location = new System.Drawing.Point(3, 527);
            this.DBFeedBack.Name = "DBFeedBack";
            this.DBFeedBack.ReadOnly = true;
            this.DBFeedBack.RowTemplate.ReadOnly = true;
            this.DBFeedBack.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DBFeedBack.Size = new System.Drawing.Size(754, 200);
            this.DBFeedBack.TabIndex = 1;
            this.DBFeedBack.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBFeedBack_CellContentClick);
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.SystemColors.ControlLight;
            this.page.Controls.Add(this.label3);
            this.page.Controls.Add(this.txtStatement);
            this.page.Controls.Add(this.label13);
            this.page.Controls.Add(this.txtFeedback);
            this.page.Controls.Add(this.label12);
            this.page.Controls.Add(this.txtStudentIDs);
            this.page.Controls.Add(this.label6);
            this.page.Controls.Add(this.btn_Close);
            this.page.Controls.Add(this.btnDone);
            this.page.Controls.Add(this.label5);
            this.page.Controls.Add(this.txtRequestStatus);
            this.page.Controls.Add(this.txtRoomType);
            this.page.Controls.Add(this.label4);
            this.page.Controls.Add(this.label2);
            this.page.Controls.Add(this.label1);
            this.page.Controls.Add(this.DBFeedBack);
            this.page.Dock = System.Windows.Forms.DockStyle.Right;
            this.page.Location = new System.Drawing.Point(201, 0);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(760, 727);
            this.page.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label3.Location = new System.Drawing.Point(7, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 75);
            this.label3.TabIndex = 39;
            this.label3.Text = "Warden\r\nStatement:\r\n\r\n";
            // 
            // txtStatement
            // 
            this.txtStatement.BackColor = System.Drawing.SystemColors.Info;
            this.txtStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatement.ForeColor = System.Drawing.Color.Black;
            this.txtStatement.Location = new System.Drawing.Point(191, 373);
            this.txtStatement.Multiline = true;
            this.txtStatement.Name = "txtStatement";
            this.txtStatement.Size = new System.Drawing.Size(437, 86);
            this.txtStatement.TabIndex = 38;
            // 
            // WardenFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 727);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WardenFeed";
            this.Text = "WardenFeed";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBFeedBack)).EndInit();
            this.page.ResumeLayout(false);
            this.page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStudentIDs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AccomedationForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRequestStatus;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DBFeedBack;
        private System.Windows.Forms.Panel page;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatement;
    }
}