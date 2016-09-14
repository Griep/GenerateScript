namespace GenerateScript
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textboxTO = new System.Windows.Forms.TextBox();
            this.labelTO = new System.Windows.Forms.Label();
            this.textBoxLIVE = new System.Windows.Forms.TextBox();
            this.textBoxDEV = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelDEV = new System.Windows.Forms.Label();
            this.textBoxSTG = new System.Windows.Forms.TextBox();
            this.labelSTG = new System.Windows.Forms.Label();
            this.labelLIVE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(219, 257);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate!";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxTO
            // 
            this.textboxTO.Location = new System.Drawing.Point(63, 96);
            this.textboxTO.Multiline = true;
            this.textboxTO.Name = "textboxTO";
            this.textboxTO.Size = new System.Drawing.Size(100, 20);
            this.textboxTO.TabIndex = 1;
            this.textboxTO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelTO
            // 
            this.labelTO.AutoSize = true;
            this.labelTO.Location = new System.Drawing.Point(60, 80);
            this.labelTO.Name = "labelTO";
            this.labelTO.Size = new System.Drawing.Size(57, 13);
            this.labelTO.TabIndex = 2;
            this.labelTO.Text = "TaskOrder";
            // 
            // textBoxLIVE
            // 
            this.textBoxLIVE.Location = new System.Drawing.Point(63, 200);
            this.textBoxLIVE.Multiline = true;
            this.textBoxLIVE.Name = "textBoxLIVE";
            this.textBoxLIVE.Size = new System.Drawing.Size(100, 20);
            this.textBoxLIVE.TabIndex = 3;
            // 
            // textBoxDEV
            // 
            this.textBoxDEV.Location = new System.Drawing.Point(63, 148);
            this.textBoxDEV.Multiline = true;
            this.textBoxDEV.Name = "textBoxDEV";
            this.textBoxDEV.Size = new System.Drawing.Size(100, 20);
            this.textBoxDEV.TabIndex = 4;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(60, 132);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(43, 13);
            this.labelServer.TabIndex = 5;
            this.labelServer.Text = "Servers";
            // 
            // labelDEV
            // 
            this.labelDEV.AutoSize = true;
            this.labelDEV.Location = new System.Drawing.Point(169, 151);
            this.labelDEV.Name = "labelDEV";
            this.labelDEV.Size = new System.Drawing.Size(29, 13);
            this.labelDEV.TabIndex = 6;
            this.labelDEV.Text = "DEV";
            this.labelDEV.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxSTG
            // 
            this.textBoxSTG.Location = new System.Drawing.Point(63, 174);
            this.textBoxSTG.Multiline = true;
            this.textBoxSTG.Name = "textBoxSTG";
            this.textBoxSTG.Size = new System.Drawing.Size(100, 20);
            this.textBoxSTG.TabIndex = 7;
            // 
            // labelSTG
            // 
            this.labelSTG.AutoSize = true;
            this.labelSTG.Location = new System.Drawing.Point(169, 177);
            this.labelSTG.Name = "labelSTG";
            this.labelSTG.Size = new System.Drawing.Size(29, 13);
            this.labelSTG.TabIndex = 8;
            this.labelSTG.Text = "STG";
            this.labelSTG.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelLIVE
            // 
            this.labelLIVE.AutoSize = true;
            this.labelLIVE.Location = new System.Drawing.Point(169, 203);
            this.labelLIVE.Name = "labelLIVE";
            this.labelLIVE.Size = new System.Drawing.Size(30, 13);
            this.labelLIVE.TabIndex = 9;
            this.labelLIVE.Text = "LIVE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 342);
            this.Controls.Add(this.labelLIVE);
            this.Controls.Add(this.labelSTG);
            this.Controls.Add(this.textBoxSTG);
            this.Controls.Add(this.labelDEV);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.textBoxDEV);
            this.Controls.Add(this.textBoxLIVE);
            this.Controls.Add(this.labelTO);
            this.Controls.Add(this.textboxTO);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "SQL Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox textboxTO;
        private System.Windows.Forms.TextBox textBoxDEV;
        private System.Windows.Forms.TextBox textBoxSTG;
        private System.Windows.Forms.TextBox textBoxLIVE;

        private System.Windows.Forms.Label labelTO;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelDEV;
        private System.Windows.Forms.Label labelSTG;
        private System.Windows.Forms.Label labelLIVE;

        private System.Windows.Forms.Button buttonGenerate;
    }
}

