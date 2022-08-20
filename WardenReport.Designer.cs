
namespace AdminstraterSchoolAccomedation
{
    partial class WardenReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WardenReport));
            this.DBReport = new System.Windows.Forms.DataGridView();
            this.AccomedationForm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Close = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.page = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FTblocktype = new System.Windows.Forms.ComboBox();
            this.FTroomstatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DBReport
            // 
            this.DBReport.AllowUserToAddRows = false;
            this.DBReport.AllowUserToDeleteRows = false;
            this.DBReport.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DBReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DBReport.Location = new System.Drawing.Point(0, 312);
            this.DBReport.Name = "DBReport";
            this.DBReport.ReadOnly = true;
            this.DBReport.RowHeadersWidth = 45;
            this.DBReport.RowTemplate.ReadOnly = true;
            this.DBReport.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DBReport.Size = new System.Drawing.Size(760, 428);
            this.DBReport.TabIndex = 1;
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
            this.AccomedationForm.Size = new System.Drawing.Size(225, 72);
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
            this.panel1.Size = new System.Drawing.Size(203, 740);
            this.panel1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label12.Location = new System.Drawing.Point(299, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(423, 36);
            this.label12.TabIndex = 34;
            this.label12.Text = "Viewing the accommodation data is available here. For \r\nfilter option please sele" +
    "ct the option available below \r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label6.Location = new System.Drawing.Point(5, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Accommodation Data";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(604, 266);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(156, 50);
            this.btn_Close.TabIndex = 21;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(443, 266);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(156, 50);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(471, 47);
            this.label5.TabIndex = 10;
            this.label5.Text = "Accommodation Report";
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.SystemColors.ControlLight;
            this.page.Controls.Add(this.label3);
            this.page.Controls.Add(this.label2);
            this.page.Controls.Add(this.FTroomstatus);
            this.page.Controls.Add(this.FTblocktype);
            this.page.Controls.Add(this.label1);
            this.page.Controls.Add(this.label12);
            this.page.Controls.Add(this.label6);
            this.page.Controls.Add(this.btn_Close);
            this.page.Controls.Add(this.btnSubmit);
            this.page.Controls.Add(this.label5);
            this.page.Controls.Add(this.DBReport);
            this.page.Dock = System.Windows.Forms.DockStyle.Right;
            this.page.Location = new System.Drawing.Point(203, 0);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(760, 740);
            this.page.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(5, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Filter Option:";
            // 
            // FTblocktype
            // 
            this.FTblocktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTblocktype.FormattingEnabled = true;
            this.FTblocktype.Items.AddRange(new object[] {
            "",
            "A",
            "B"});
            this.FTblocktype.Location = new System.Drawing.Point(226, 185);
            this.FTblocktype.Name = "FTblocktype";
            this.FTblocktype.Size = new System.Drawing.Size(175, 37);
            this.FTblocktype.TabIndex = 36;
            // 
            // FTroomstatus
            // 
            this.FTroomstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTroomstatus.FormattingEnabled = true;
            this.FTroomstatus.Items.AddRange(new object[] {
            "",
            "Occupied ",
            "Vacant"});
            this.FTroomstatus.Location = new System.Drawing.Point(478, 185);
            this.FTroomstatus.Name = "FTroomstatus";
            this.FTroomstatus.Size = new System.Drawing.Size(173, 37);
            this.FTroomstatus.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(222, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Block Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.label3.Location = new System.Drawing.Point(474, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Room Status";
            // 
            // WardenReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WardenReport";
            this.Text = "WardenReport";
            ((System.ComponentModel.ISupportInitialize)(this.DBReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.page.ResumeLayout(false);
            this.page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DBReport;
        private System.Windows.Forms.Label AccomedationForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel page;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FTroomstatus;
        private System.Windows.Forms.ComboBox FTblocktype;
        private System.Windows.Forms.Label label1;
    }
}