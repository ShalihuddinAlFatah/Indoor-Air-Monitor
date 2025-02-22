namespace Visual_CS_UDP_2
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
            this.buttonLOCATE = new System.Windows.Forms.Button();
            this.buttonMIN = new System.Windows.Forms.Button();
            this.buttonCLOSE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHUM = new System.Windows.Forms.TextBox();
            this.textBoxTEMP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSMOKE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLPG = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelERR = new System.Windows.Forms.Label();
            this.buttonPairX = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLOCATE
            // 
            this.buttonLOCATE.BackColor = System.Drawing.Color.Black;
            this.buttonLOCATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLOCATE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLOCATE.ForeColor = System.Drawing.Color.Red;
            this.buttonLOCATE.Location = new System.Drawing.Point(12, 12);
            this.buttonLOCATE.Name = "buttonLOCATE";
            this.buttonLOCATE.Size = new System.Drawing.Size(29, 29);
            this.buttonLOCATE.TabIndex = 0;
            this.buttonLOCATE.Text = "L";
            this.buttonLOCATE.UseVisualStyleBackColor = false;
            this.buttonLOCATE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLOCATE_MouseDown);
            this.buttonLOCATE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonLOCATE_MouseMove);
            this.buttonLOCATE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonLOCATE_MouseUp);
            // 
            // buttonMIN
            // 
            this.buttonMIN.BackColor = System.Drawing.Color.Black;
            this.buttonMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMIN.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMIN.ForeColor = System.Drawing.Color.Red;
            this.buttonMIN.Location = new System.Drawing.Point(12, 47);
            this.buttonMIN.Name = "buttonMIN";
            this.buttonMIN.Size = new System.Drawing.Size(29, 29);
            this.buttonMIN.TabIndex = 1;
            this.buttonMIN.Text = "M";
            this.buttonMIN.UseVisualStyleBackColor = false;
            this.buttonMIN.Click += new System.EventHandler(this.buttonMIN_Click);
            // 
            // buttonCLOSE
            // 
            this.buttonCLOSE.BackColor = System.Drawing.Color.Black;
            this.buttonCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCLOSE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCLOSE.ForeColor = System.Drawing.Color.Red;
            this.buttonCLOSE.Location = new System.Drawing.Point(12, 82);
            this.buttonCLOSE.Name = "buttonCLOSE";
            this.buttonCLOSE.Size = new System.Drawing.Size(29, 29);
            this.buttonCLOSE.TabIndex = 2;
            this.buttonCLOSE.Text = "X";
            this.buttonCLOSE.UseVisualStyleBackColor = false;
            this.buttonCLOSE.Click += new System.EventHandler(this.buttonCLOSE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxHUM);
            this.groupBox1.Controls.Add(this.textBoxTEMP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSMOKE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxLPG);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(47, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telemetry Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(220, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(220, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(129, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "PPM";
            // 
            // textBoxHUM
            // 
            this.textBoxHUM.BackColor = System.Drawing.Color.Red;
            this.textBoxHUM.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHUM.Location = new System.Drawing.Point(184, 50);
            this.textBoxHUM.Name = "textBoxHUM";
            this.textBoxHUM.ReadOnly = true;
            this.textBoxHUM.Size = new System.Drawing.Size(30, 21);
            this.textBoxHUM.TabIndex = 9;
            this.textBoxHUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTEMP
            // 
            this.textBoxTEMP.BackColor = System.Drawing.Color.Red;
            this.textBoxTEMP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTEMP.Location = new System.Drawing.Point(184, 20);
            this.textBoxTEMP.Name = "textBoxTEMP";
            this.textBoxTEMP.ReadOnly = true;
            this.textBoxTEMP.Size = new System.Drawing.Size(30, 21);
            this.textBoxTEMP.TabIndex = 8;
            this.textBoxTEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(140, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "HUM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(140, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "TEMP";
            // 
            // textBoxSMOKE
            // 
            this.textBoxSMOKE.BackColor = System.Drawing.Color.Red;
            this.textBoxSMOKE.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSMOKE.Location = new System.Drawing.Point(63, 80);
            this.textBoxSMOKE.Name = "textBoxSMOKE";
            this.textBoxSMOKE.ReadOnly = true;
            this.textBoxSMOKE.Size = new System.Drawing.Size(60, 21);
            this.textBoxSMOKE.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "SMOKE";
            // 
            // textBoxCO
            // 
            this.textBoxCO.BackColor = System.Drawing.Color.Red;
            this.textBoxCO.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCO.Location = new System.Drawing.Point(63, 50);
            this.textBoxCO.Name = "textBoxCO";
            this.textBoxCO.ReadOnly = true;
            this.textBoxCO.Size = new System.Drawing.Size(60, 21);
            this.textBoxCO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "LPG";
            // 
            // textBoxLPG
            // 
            this.textBoxLPG.BackColor = System.Drawing.Color.Red;
            this.textBoxLPG.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLPG.Location = new System.Drawing.Point(63, 20);
            this.textBoxLPG.Name = "textBoxLPG";
            this.textBoxLPG.ReadOnly = true;
            this.textBoxLPG.Size = new System.Drawing.Size(60, 21);
            this.textBoxLPG.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.buttonPairX);
            this.groupBox2.Controls.Add(this.buttonStop);
            this.groupBox2.Controls.Add(this.buttonStart);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(122, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Black;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.Red;
            this.buttonStop.Location = new System.Drawing.Point(65, 21);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(50, 29);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Black;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Red;
            this.buttonStart.Location = new System.Drawing.Point(9, 21);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(50, 29);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelERR
            // 
            this.labelERR.AutoSize = true;
            this.labelERR.ForeColor = System.Drawing.Color.White;
            this.labelERR.Location = new System.Drawing.Point(9, 187);
            this.labelERR.Name = "labelERR";
            this.labelERR.Size = new System.Drawing.Size(10, 15);
            this.labelERR.TabIndex = 5;
            this.labelERR.Text = ".";
            // 
            // buttonPairX
            // 
            this.buttonPairX.BackColor = System.Drawing.Color.Black;
            this.buttonPairX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPairX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPairX.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPairX.ForeColor = System.Drawing.Color.Red;
            this.buttonPairX.Location = new System.Drawing.Point(121, 21);
            this.buttonPairX.Name = "buttonPairX";
            this.buttonPairX.Size = new System.Drawing.Size(50, 29);
            this.buttonPairX.TabIndex = 14;
            this.buttonPairX.Text = "Pair";
            this.buttonPairX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPairX.UseVisualStyleBackColor = false;
            this.buttonPairX.Click += new System.EventHandler(this.buttonPairX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(307, 214);
            this.Controls.Add(this.labelERR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCLOSE);
            this.Controls.Add(this.buttonMIN);
            this.Controls.Add(this.buttonLOCATE);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLOCATE;
        private System.Windows.Forms.Button buttonMIN;
        private System.Windows.Forms.Button buttonCLOSE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHUM;
        private System.Windows.Forms.TextBox textBoxTEMP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSMOKE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLPG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelERR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonPairX;
    }
}

