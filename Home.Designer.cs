namespace QR_Reader
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCamera = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dsadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsadsaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vituarlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitor = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao diện lấy mã barcode & QR Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Camera";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(100, 148);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(100, 199);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(201, 437);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(492, 20);
            this.txtResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã đọc được";
            // 
            // cbbCamera
            // 
            this.cbbCamera.FormattingEnabled = true;
            this.cbbCamera.Location = new System.Drawing.Point(235, 112);
            this.cbbCamera.Name = "cbbCamera";
            this.cbbCamera.Size = new System.Drawing.Size(384, 21);
            this.cbbCamera.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsadsToolStripMenuItem,
            this.dsadsaToolStripMenuItem1,
            this.vituarlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dsadsToolStripMenuItem
            // 
            this.dsadsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsadsToolStripMenuItem.Name = "dsadsToolStripMenuItem";
            this.dsadsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.dsadsToolStripMenuItem.Text = "Home";
            // 
            // dsadsaToolStripMenuItem1
            // 
            this.dsadsaToolStripMenuItem1.Name = "dsadsaToolStripMenuItem1";
            this.dsadsaToolStripMenuItem1.Size = new System.Drawing.Size(109, 20);
            this.dsadsaToolStripMenuItem1.Text = "QR Management";
            this.dsadsaToolStripMenuItem1.Click += new System.EventHandler(this.dsadsaToolStripMenuItem1_Click);
            // 
            // vituarlToolStripMenuItem
            // 
            this.vituarlToolStripMenuItem.Name = "vituarlToolStripMenuItem";
            this.vituarlToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.vituarlToolStripMenuItem.Text = "Simulation";
            this.vituarlToolStripMenuItem.Click += new System.EventHandler(this.vituarlToolStripMenuItem_Click);
            // 
            // monitor
            // 
            this.monitor.Location = new System.Drawing.Point(235, 148);
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(384, 275);
            this.monitor.TabIndex = 3;
            this.monitor.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 516);
            this.Controls.Add(this.cbbCamera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.monitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox monitor;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCamera;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dsadsaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dsadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vituarlToolStripMenuItem;
    }
}

