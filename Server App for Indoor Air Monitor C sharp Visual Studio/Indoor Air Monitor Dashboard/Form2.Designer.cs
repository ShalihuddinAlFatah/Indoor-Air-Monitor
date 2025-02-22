namespace Visual_CS_UDP_2
{
    partial class Form2
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
            this.buttonCLOSE = new System.Windows.Forms.Button();
            this.buttonMIN = new System.Windows.Forms.Button();
            this.buttonLOCATE = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.buttonScanSerial = new System.Windows.Forms.Button();
            this.comboBoxSerialList = new System.Windows.Forms.ComboBox();
            this.buttonPairSerial = new System.Windows.Forms.Button();
            this.labelERR = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCLOSE
            // 
            this.buttonCLOSE.BackColor = System.Drawing.Color.Black;
            this.buttonCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCLOSE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCLOSE.ForeColor = System.Drawing.Color.Red;
            this.buttonCLOSE.Location = new System.Drawing.Point(10, 91);
            this.buttonCLOSE.Name = "buttonCLOSE";
            this.buttonCLOSE.Size = new System.Drawing.Size(29, 29);
            this.buttonCLOSE.TabIndex = 5;
            this.buttonCLOSE.Text = "X";
            this.buttonCLOSE.UseVisualStyleBackColor = false;
            this.buttonCLOSE.Click += new System.EventHandler(this.buttonCLOSE_Click);
            // 
            // buttonMIN
            // 
            this.buttonMIN.BackColor = System.Drawing.Color.Black;
            this.buttonMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMIN.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMIN.ForeColor = System.Drawing.Color.Red;
            this.buttonMIN.Location = new System.Drawing.Point(10, 56);
            this.buttonMIN.Name = "buttonMIN";
            this.buttonMIN.Size = new System.Drawing.Size(29, 29);
            this.buttonMIN.TabIndex = 4;
            this.buttonMIN.Text = "M";
            this.buttonMIN.UseVisualStyleBackColor = false;
            this.buttonMIN.Click += new System.EventHandler(this.buttonMIN_Click);
            // 
            // buttonLOCATE
            // 
            this.buttonLOCATE.BackColor = System.Drawing.Color.Black;
            this.buttonLOCATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLOCATE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLOCATE.ForeColor = System.Drawing.Color.Red;
            this.buttonLOCATE.Location = new System.Drawing.Point(10, 21);
            this.buttonLOCATE.Name = "buttonLOCATE";
            this.buttonLOCATE.Size = new System.Drawing.Size(29, 29);
            this.buttonLOCATE.TabIndex = 3;
            this.buttonLOCATE.Text = "L";
            this.buttonLOCATE.UseVisualStyleBackColor = false;
            this.buttonLOCATE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLOCATE_MouseDown);
            this.buttonLOCATE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonLOCATE_MouseMove);
            this.buttonLOCATE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonLOCATE_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.txtIpAddress);
            this.groupBox3.Controls.Add(this.buttonScanSerial);
            this.groupBox3.Controls.Add(this.comboBoxSerialList);
            this.groupBox3.Controls.Add(this.buttonPairSerial);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(45, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 129);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pairing";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.BackColor = System.Drawing.Color.Red;
            this.txtIpAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIpAddress.Location = new System.Drawing.Point(6, 25);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(121, 22);
            this.txtIpAddress.TabIndex = 13;
            // 
            // buttonScanSerial
            // 
            this.buttonScanSerial.BackColor = System.Drawing.Color.Black;
            this.buttonScanSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonScanSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScanSerial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScanSerial.ForeColor = System.Drawing.Color.Red;
            this.buttonScanSerial.Location = new System.Drawing.Point(21, 90);
            this.buttonScanSerial.Name = "buttonScanSerial";
            this.buttonScanSerial.Size = new System.Drawing.Size(50, 29);
            this.buttonScanSerial.TabIndex = 8;
            this.buttonScanSerial.Text = "Scan";
            this.buttonScanSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonScanSerial.UseVisualStyleBackColor = false;
            this.buttonScanSerial.Click += new System.EventHandler(this.buttonScanSerial_Click);
            // 
            // comboBoxSerialList
            // 
            this.comboBoxSerialList.BackColor = System.Drawing.Color.Red;
            this.comboBoxSerialList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSerialList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSerialList.FormattingEnabled = true;
            this.comboBoxSerialList.Location = new System.Drawing.Point(6, 57);
            this.comboBoxSerialList.Name = "comboBoxSerialList";
            this.comboBoxSerialList.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSerialList.TabIndex = 6;
            // 
            // buttonPairSerial
            // 
            this.buttonPairSerial.BackColor = System.Drawing.Color.Black;
            this.buttonPairSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPairSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPairSerial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPairSerial.ForeColor = System.Drawing.Color.Red;
            this.buttonPairSerial.Location = new System.Drawing.Point(77, 90);
            this.buttonPairSerial.Name = "buttonPairSerial";
            this.buttonPairSerial.Size = new System.Drawing.Size(50, 29);
            this.buttonPairSerial.TabIndex = 7;
            this.buttonPairSerial.Text = "Pair";
            this.buttonPairSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPairSerial.UseVisualStyleBackColor = false;
            this.buttonPairSerial.Click += new System.EventHandler(this.buttonPairSerial_Click);
            // 
            // labelERR
            // 
            this.labelERR.AutoSize = true;
            this.labelERR.ForeColor = System.Drawing.Color.White;
            this.labelERR.Location = new System.Drawing.Point(7, 140);
            this.labelERR.Name = "labelERR";
            this.labelERR.Size = new System.Drawing.Size(10, 13);
            this.labelERR.TabIndex = 9;
            this.labelERR.Text = ".";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(193, 162);
            this.Controls.Add(this.labelERR);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonCLOSE);
            this.Controls.Add(this.buttonMIN);
            this.Controls.Add(this.buttonLOCATE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCLOSE;
        private System.Windows.Forms.Button buttonMIN;
        private System.Windows.Forms.Button buttonLOCATE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Button buttonScanSerial;
        private System.Windows.Forms.ComboBox comboBoxSerialList;
        private System.Windows.Forms.Button buttonPairSerial;
        private System.Windows.Forms.Label labelERR;
    }
}