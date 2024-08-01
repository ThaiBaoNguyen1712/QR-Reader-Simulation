namespace QR_Reader
{
    partial class Simulator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtReadCode = new System.Windows.Forms.Label();
            this.pnBackgroundBox = new System.Windows.Forms.Panel();
            this.pcCode = new System.Windows.Forms.PictureBox();
            this.cbbDevice = new System.Windows.Forms.ComboBox();
            this.cbbSP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Monitor = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codehistoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.readQRDataSet1 = new QR_Reader.ReadQRDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.codehistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.code_historyTableAdapter1 = new QR_Reader.ReadQRDataSetTableAdapters.Code_historyTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBrand = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnBackgroundBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codehistoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readQRDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codehistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BackgroundImage = global::QR_Reader.Properties.Resources.san_xuat_chip_autonews;
            this.panel1.Controls.Add(this.txtBrand);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.txtReadCode);
            this.panel1.Controls.Add(this.pnBackgroundBox);
            this.panel1.Controls.Add(this.cbbDevice);
            this.panel1.Controls.Add(this.cbbSP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Monitor);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1748, 999);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1416, 111);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Đóng Cam";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1416, 111);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 28);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Mở Cam";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtReadCode
            // 
            this.txtReadCode.AutoSize = true;
            this.txtReadCode.BackColor = System.Drawing.Color.Transparent;
            this.txtReadCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadCode.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtReadCode.Location = new System.Drawing.Point(1412, 377);
            this.txtReadCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtReadCode.Name = "txtReadCode";
            this.txtReadCode.Size = new System.Drawing.Size(0, 22);
            this.txtReadCode.TabIndex = 10;
            // 
            // pnBackgroundBox
            // 
            this.pnBackgroundBox.BackColor = System.Drawing.Color.OldLace;
            this.pnBackgroundBox.BackgroundImage = global::QR_Reader.Properties.Resources.pngtree_3d_cardbox_png_illustration_png_image_9188118_removebg_preview;
            this.pnBackgroundBox.Controls.Add(this.pcCode);
            this.pnBackgroundBox.Location = new System.Drawing.Point(511, 97);
            this.pnBackgroundBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnBackgroundBox.Name = "pnBackgroundBox";
            this.pnBackgroundBox.Size = new System.Drawing.Size(697, 571);
            this.pnBackgroundBox.TabIndex = 9;
            // 
            // pcCode
            // 
            this.pcCode.BackColor = System.Drawing.Color.Transparent;
            this.pcCode.Image = global::QR_Reader.Properties.Resources.OIP__1_;
            this.pcCode.Location = new System.Drawing.Point(255, 299);
            this.pcCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcCode.Name = "pcCode";
            this.pcCode.Size = new System.Drawing.Size(187, 158);
            this.pcCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCode.TabIndex = 1;
            this.pcCode.TabStop = false;
            // 
            // cbbDevice
            // 
            this.cbbDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDevice.FormattingEnabled = true;
            this.cbbDevice.Location = new System.Drawing.Point(1416, 69);
            this.cbbDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDevice.Name = "cbbDevice";
            this.cbbDevice.Size = new System.Drawing.Size(297, 28);
            this.cbbDevice.TabIndex = 8;
            // 
            // cbbSP
            // 
            this.cbbSP.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSP.FormattingEnabled = true;
            this.cbbSP.Location = new System.Drawing.Point(57, 111);
            this.cbbSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbSP.Name = "cbbSP";
            this.cbbSP.Size = new System.Drawing.Size(247, 31);
            this.cbbSP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Violet;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(51, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dây chuyền sản xuất\r\n";
            // 
            // Monitor
            // 
            this.Monitor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Monitor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Monitor.Location = new System.Drawing.Point(1416, 111);
            this.Monitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(297, 286);
            this.Monitor.TabIndex = 5;
            this.Monitor.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.codehistoryBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(895, 695);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 304);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Brand_Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Brand_Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Reader_Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Reader_Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Created_at";
            this.dataGridViewTextBoxColumn5.HeaderText = "Created_at";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Updated_at";
            this.dataGridViewTextBoxColumn6.HeaderText = "Updated_at";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // codehistoryBindingSource1
            // 
            this.codehistoryBindingSource1.DataMember = "Code_history";
            this.codehistoryBindingSource1.DataSource = this.readQRDataSet1;
            // 
            // readQRDataSet1
            // 
            this.readQRDataSet1.DataSetName = "ReadQRDataSet";
            this.readQRDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(497, 818);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 128);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(313, 818);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 128);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dừng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Coral;
            this.btnStart.Location = new System.Drawing.Point(128, 818);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 128);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Bắt đầu ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // codehistoryBindingSource
            // 
            this.codehistoryBindingSource.DataMember = "Code_history";
            // 
            // code_historyTableAdapter1
            // 
            this.code_historyTableAdapter1.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtBrand
            // 
            this.txtBrand.AutoSize = true;
            this.txtBrand.BackColor = System.Drawing.Color.Turquoise;
            this.txtBrand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtBrand.Location = new System.Drawing.Point(1618, 111);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(50, 19);
            this.txtBrand.TabIndex = 13;
            this.txtBrand.Text = "Brand";
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 999);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Simulator";
            this.Text = "Simulator";
            this.Load += new System.EventHandler(this.Simulator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnBackgroundBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codehistoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readQRDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codehistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcCode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox Monitor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReadQRDataSet readQRDataSet;
        private System.Windows.Forms.BindingSource codehistoryBindingSource;
        private ReadQRDataSetTableAdapters.Code_historyTableAdapter code_historyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDevice;
        private ReadQRDataSet readQRDataSet1;
        private System.Windows.Forms.BindingSource codehistoryBindingSource1;
        private ReadQRDataSetTableAdapters.Code_historyTableAdapter code_historyTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnBackgroundBox;
        private System.Windows.Forms.Label txtReadCode;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label txtBrand;
    }
}