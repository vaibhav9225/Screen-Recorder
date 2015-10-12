namespace Screen_Recorder
{
    partial class Form1
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
            this.Button10 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.INT1000 = new System.Windows.Forms.Button();
            this.INT500 = new System.Windows.Forms.Button();
            this.INT250 = new System.Windows.Forms.Button();
            this.INT100 = new System.Windows.Forms.Button();
            this.INT50 = new System.Windows.Forms.Button();
            this.INT10 = new System.Windows.Forms.Button();
            this.FileType = new System.Windows.Forms.TextBox();
            this.FileNUM = new System.Windows.Forms.TextBox();
            this.FileDIR = new System.Windows.Forms.TextBox();
            this.STP = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.REC = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button10
            // 
            this.Button10.Location = new System.Drawing.Point(190, 227);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(75, 23);
            this.Button10.TabIndex = 29;
            this.Button10.Text = "Video Off";
            this.Button10.UseVisualStyleBackColor = true;
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(21, 228);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(75, 23);
            this.Button9.TabIndex = 28;
            this.Button9.Text = "Video On";
            this.Button9.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(21, 178);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(244, 44);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "FPS";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(102, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(42, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "01 FPS";
            // 
            // INT1000
            // 
            this.INT1000.Location = new System.Drawing.Point(190, 149);
            this.INT1000.Name = "INT1000";
            this.INT1000.Size = new System.Drawing.Size(75, 23);
            this.INT1000.TabIndex = 26;
            this.INT1000.Text = "1000";
            this.INT1000.UseVisualStyleBackColor = true;
            // 
            // INT500
            // 
            this.INT500.Location = new System.Drawing.Point(102, 149);
            this.INT500.Name = "INT500";
            this.INT500.Size = new System.Drawing.Size(75, 23);
            this.INT500.TabIndex = 25;
            this.INT500.Text = "500";
            this.INT500.UseVisualStyleBackColor = true;
            // 
            // INT250
            // 
            this.INT250.Location = new System.Drawing.Point(21, 149);
            this.INT250.Name = "INT250";
            this.INT250.Size = new System.Drawing.Size(75, 23);
            this.INT250.TabIndex = 24;
            this.INT250.Text = "250";
            this.INT250.UseVisualStyleBackColor = true;
            // 
            // INT100
            // 
            this.INT100.Location = new System.Drawing.Point(190, 120);
            this.INT100.Name = "INT100";
            this.INT100.Size = new System.Drawing.Size(75, 23);
            this.INT100.TabIndex = 23;
            this.INT100.Text = "100";
            this.INT100.UseVisualStyleBackColor = true;
            // 
            // INT50
            // 
            this.INT50.Location = new System.Drawing.Point(102, 120);
            this.INT50.Name = "INT50";
            this.INT50.Size = new System.Drawing.Size(75, 23);
            this.INT50.TabIndex = 22;
            this.INT50.Text = "50";
            this.INT50.UseVisualStyleBackColor = true;
            // 
            // INT10
            // 
            this.INT10.Location = new System.Drawing.Point(21, 120);
            this.INT10.Name = "INT10";
            this.INT10.Size = new System.Drawing.Size(75, 23);
            this.INT10.TabIndex = 21;
            this.INT10.Text = "10";
            this.INT10.UseVisualStyleBackColor = true;
            // 
            // FileType
            // 
            this.FileType.Location = new System.Drawing.Point(20, 94);
            this.FileType.Name = "FileType";
            this.FileType.Size = new System.Drawing.Size(244, 20);
            this.FileType.TabIndex = 20;
            this.FileType.Text = ".JPG";
            // 
            // FileNUM
            // 
            this.FileNUM.Location = new System.Drawing.Point(20, 68);
            this.FileNUM.Name = "FileNUM";
            this.FileNUM.Size = new System.Drawing.Size(244, 20);
            this.FileNUM.TabIndex = 19;
            this.FileNUM.Text = "0";
            // 
            // FileDIR
            // 
            this.FileDIR.Location = new System.Drawing.Point(21, 42);
            this.FileDIR.Name = "FileDIR";
            this.FileDIR.Size = new System.Drawing.Size(244, 20);
            this.FileDIR.TabIndex = 18;
            this.FileDIR.Text = "C:\\ScreenREC\\";
            // 
            // STP
            // 
            this.STP.Location = new System.Drawing.Point(190, 12);
            this.STP.Name = "STP";
            this.STP.Size = new System.Drawing.Size(75, 23);
            this.STP.TabIndex = 17;
            this.STP.Text = "Stop";
            this.STP.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(102, 13);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(87, 17);
            this.CheckBox1.TabIndex = 16;
            this.CheckBox1.Text = "Input/Output";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // REC
            // 
            this.REC.Location = new System.Drawing.Point(20, 12);
            this.REC.Name = "REC";
            this.REC.Size = new System.Drawing.Size(75, 23);
            this.REC.TabIndex = 15;
            this.REC.Text = "Record";
            this.REC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.INT1000);
            this.Controls.Add(this.INT500);
            this.Controls.Add(this.INT250);
            this.Controls.Add(this.INT100);
            this.Controls.Add(this.INT50);
            this.Controls.Add(this.INT10);
            this.Controls.Add(this.FileType);
            this.Controls.Add(this.FileNUM);
            this.Controls.Add(this.FileDIR);
            this.Controls.Add(this.STP);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.REC);
            this.Name = "Form1";
            this.Text = "Screen Recorder";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button10;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button INT1000;
        internal System.Windows.Forms.Button INT500;
        internal System.Windows.Forms.Button INT250;
        internal System.Windows.Forms.Button INT100;
        internal System.Windows.Forms.Button INT50;
        internal System.Windows.Forms.Button INT10;
        internal System.Windows.Forms.TextBox FileType;
        internal System.Windows.Forms.TextBox FileNUM;
        internal System.Windows.Forms.TextBox FileDIR;
        internal System.Windows.Forms.Button STP;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Button REC;
    }
}

