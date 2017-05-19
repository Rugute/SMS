namespace Sms.Accounts
{
    partial class frmPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayments));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentsList = new System.Windows.Forms.ListView();
            this.ColumnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSea = new System.Windows.Forms.ComboBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = global::Sms.Properties.Resources.ies;
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(913, 555);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Exams Results";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentsList);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 487);
            this.groupBox1.TabIndex = 7026;
            this.groupBox1.TabStop = false;
            // 
            // StudentsList
            // 
            this.StudentsList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader28,
            this.ColumnHeader31,
            this.ColumnHeader32,
            this.ColumnHeader33,
            this.ColumnHeader34,
            this.ColumnHeader35,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.StudentsList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsList.FullRowSelect = true;
            this.StudentsList.GridLines = true;
            this.StudentsList.Location = new System.Drawing.Point(6, 138);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(871, 343);
            this.StudentsList.TabIndex = 7019;
            this.StudentsList.UseCompatibleStateImageBehavior = false;
            this.StudentsList.View = System.Windows.Forms.View.Details;
            this.StudentsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StudentsList_MouseClick);
            // 
            // ColumnHeader28
            // 
            this.ColumnHeader28.Text = "No";
            this.ColumnHeader28.Width = 34;
            // 
            // ColumnHeader31
            // 
            this.ColumnHeader31.Text = "ADMNO";
            this.ColumnHeader31.Width = 57;
            // 
            // ColumnHeader32
            // 
            this.ColumnHeader32.Text = "Name";
            this.ColumnHeader32.Width = 210;
            // 
            // ColumnHeader33
            // 
            this.ColumnHeader33.Text = "Gender";
            this.ColumnHeader33.Width = 84;
            // 
            // ColumnHeader34
            // 
            this.ColumnHeader34.Text = "Class/Form";
            this.ColumnHeader34.Width = 82;
            // 
            // ColumnHeader35
            // 
            this.ColumnHeader35.Text = "Stream";
            this.ColumnHeader35.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Term";
            this.columnHeader3.Width = 57;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 93;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "BoardingType";
            this.columnHeader6.Width = 102;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dorm/House";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Expected Year of Completion";
            this.columnHeader8.Width = 64;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSea);
            this.groupBox2.Controls.Add(this.Label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtIdValue);
            this.groupBox2.Location = new System.Drawing.Point(22, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 96);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Specific Search";
            // 
            // txtSea
            // 
            this.txtSea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSea.FormattingEnabled = true;
            this.txtSea.Items.AddRange(new object[] {
            "ADMNO",
            "Name"});
            this.txtSea.Location = new System.Drawing.Point(10, 45);
            this.txtSea.Name = "txtSea";
            this.txtSea.Size = new System.Drawing.Size(151, 21);
            this.txtSea.TabIndex = 6994;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(7, 29);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(88, 13);
            this.Label13.TabIndex = 6993;
            this.Label13.Text = "Search Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Value";
            // 
            // txtIdValue
            // 
            this.txtIdValue.Location = new System.Drawing.Point(261, 45);
            this.txtIdValue.Name = "txtIdValue";
            this.txtIdValue.Size = new System.Drawing.Size(157, 21);
            this.txtIdValue.TabIndex = 0;
            this.txtIdValue.TextChanged += new System.EventHandler(this.txtIdValue_TextChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(869, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 35);
            this.button1.TabIndex = 100;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 558);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPayments";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.ComboBox txtSea;
        internal System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdValue;
        internal System.Windows.Forms.ListView StudentsList;
        internal System.Windows.Forms.ColumnHeader ColumnHeader28;
        internal System.Windows.Forms.ColumnHeader ColumnHeader31;
        internal System.Windows.Forms.ColumnHeader ColumnHeader32;
        internal System.Windows.Forms.ColumnHeader ColumnHeader33;
        internal System.Windows.Forms.ColumnHeader ColumnHeader34;
        internal System.Windows.Forms.ColumnHeader ColumnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}