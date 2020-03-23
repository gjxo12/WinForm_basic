namespace WindowsFormsApp2_class
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.QACustomer = new System.Windows.Forms.Button();
            this.Datapanel1 = new System.Windows.Forms.Panel();
            this.cchk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cdescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.caddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cfullname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tdescription = new System.Windows.Forms.TextBox();
            this.Taddress = new System.Windows.Forms.TextBox();
            this.TDate = new System.Windows.Forms.TextBox();
            this.Tlastname = new System.Windows.Forms.TextBox();
            this.Tfirstname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datapanal = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cpat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Datapanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.datapanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QACustomer
            // 
            this.QACustomer.Location = new System.Drawing.Point(347, 580);
            this.QACustomer.Name = "QACustomer";
            this.QACustomer.Size = new System.Drawing.Size(187, 77);
            this.QACustomer.TabIndex = 0;
            this.QACustomer.Text = "입양자생성";
            this.QACustomer.UseVisualStyleBackColor = true;
            this.QACustomer.Click += new System.EventHandler(this.QACustomer_Click);
            // 
            // Datapanel1
            // 
            this.Datapanel1.Controls.Add(this.cpat);
            this.Datapanel1.Controls.Add(this.label12);
            this.Datapanel1.Controls.Add(this.cchk);
            this.Datapanel1.Controls.Add(this.label2);
            this.Datapanel1.Controls.Add(this.cdescription);
            this.Datapanel1.Controls.Add(this.label6);
            this.Datapanel1.Controls.Add(this.caddress);
            this.Datapanel1.Controls.Add(this.label4);
            this.Datapanel1.Controls.Add(this.cage);
            this.Datapanel1.Controls.Add(this.label5);
            this.Datapanel1.Controls.Add(this.cfullname);
            this.Datapanel1.Controls.Add(this.label3);
            this.Datapanel1.Location = new System.Drawing.Point(745, 45);
            this.Datapanel1.Name = "Datapanel1";
            this.Datapanel1.Size = new System.Drawing.Size(478, 589);
            this.Datapanel1.TabIndex = 1;
            // 
            // cchk
            // 
            this.cchk.AutoSize = true;
            this.cchk.Location = new System.Drawing.Point(161, 182);
            this.cchk.Name = "cchk";
            this.cchk.Size = new System.Drawing.Size(69, 24);
            this.cchk.TabIndex = 11;
            this.cchk.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "입양가능";
            // 
            // cdescription
            // 
            this.cdescription.AutoSize = true;
            this.cdescription.Location = new System.Drawing.Point(161, 287);
            this.cdescription.Name = "cdescription";
            this.cdescription.Size = new System.Drawing.Size(69, 24);
            this.cdescription.TabIndex = 9;
            this.cdescription.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "설명";
            // 
            // caddress
            // 
            this.caddress.AutoSize = true;
            this.caddress.Location = new System.Drawing.Point(161, 229);
            this.caddress.Name = "caddress";
            this.caddress.Size = new System.Drawing.Size(69, 24);
            this.caddress.TabIndex = 7;
            this.caddress.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "주소";
            // 
            // cage
            // 
            this.cage.AutoSize = true;
            this.cage.Location = new System.Drawing.Point(161, 124);
            this.cage.Name = "cage";
            this.cage.Size = new System.Drawing.Size(69, 24);
            this.cage.TabIndex = 5;
            this.cage.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "나이";
            // 
            // cfullname
            // 
            this.cfullname.AutoSize = true;
            this.cfullname.Location = new System.Drawing.Point(161, 62);
            this.cfullname.Name = "cfullname";
            this.cfullname.Size = new System.Drawing.Size(69, 24);
            this.cfullname.TabIndex = 3;
            this.cfullname.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tdescription);
            this.panel1.Controls.Add(this.Taddress);
            this.panel1.Controls.Add(this.TDate);
            this.panel1.Controls.Add(this.Tlastname);
            this.panel1.Controls.Add(this.Tfirstname);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.QACustomer);
            this.panel1.Location = new System.Drawing.Point(147, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 670);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // Tdescription
            // 
            this.Tdescription.Location = new System.Drawing.Point(142, 316);
            this.Tdescription.Multiline = true;
            this.Tdescription.Name = "Tdescription";
            this.Tdescription.Size = new System.Drawing.Size(347, 244);
            this.Tdescription.TabIndex = 21;
            // 
            // Taddress
            // 
            this.Taddress.Location = new System.Drawing.Point(142, 256);
            this.Taddress.Multiline = true;
            this.Taddress.Name = "Taddress";
            this.Taddress.Size = new System.Drawing.Size(125, 38);
            this.Taddress.TabIndex = 20;
            // 
            // TDate
            // 
            this.TDate.Location = new System.Drawing.Point(142, 189);
            this.TDate.Multiline = true;
            this.TDate.Name = "TDate";
            this.TDate.Size = new System.Drawing.Size(125, 38);
            this.TDate.TabIndex = 19;
            // 
            // Tlastname
            // 
            this.Tlastname.Location = new System.Drawing.Point(142, 124);
            this.Tlastname.Multiline = true;
            this.Tlastname.Name = "Tlastname";
            this.Tlastname.Size = new System.Drawing.Size(125, 38);
            this.Tlastname.TabIndex = 18;
            // 
            // Tfirstname
            // 
            this.Tfirstname.Location = new System.Drawing.Point(142, 59);
            this.Tfirstname.Multiline = true;
            this.Tfirstname.Name = "Tfirstname";
            this.Tfirstname.Size = new System.Drawing.Size(125, 38);
            this.Tfirstname.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "성";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "설명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "주소";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "생일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "이름";
            // 
            // datapanal
            // 
            this.datapanal.Controls.Add(this.dataGridView);
            this.datapanal.Location = new System.Drawing.Point(52, 156);
            this.datapanal.Name = "datapanal";
            this.datapanal.Size = new System.Drawing.Size(418, 573);
            this.datapanal.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 37;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(418, 573);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이름";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "나이";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "입양가능";
            this.Column3.Name = "Column3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1235, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 36);
            this.toolStripMenuItem1.Text = "새입양자";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cpat
            // 
            this.cpat.AutoSize = true;
            this.cpat.Location = new System.Drawing.Point(161, 337);
            this.cpat.Name = "cpat";
            this.cpat.Size = new System.Drawing.Size(69, 24);
            this.cpat.TabIndex = 13;
            this.cpat.Text = "label2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "펫";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 771);
            this.Controls.Add(this.datapanal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Datapanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Datapanel1.ResumeLayout(false);
            this.Datapanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.datapanal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QACustomer;
        private System.Windows.Forms.Panel Datapanel1;
        private System.Windows.Forms.Label caddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cfullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cdescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cchk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tlastname;
        private System.Windows.Forms.TextBox Tfirstname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tdescription;
        private System.Windows.Forms.TextBox Taddress;
        private System.Windows.Forms.TextBox TDate;
        private System.Windows.Forms.Panel datapanal;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label cpat;
        private System.Windows.Forms.Label label12;
    }
}

