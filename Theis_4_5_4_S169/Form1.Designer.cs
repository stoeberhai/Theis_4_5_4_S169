namespace Theis_4_5_4_S169
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CmdAnzeigen1 = new System.Windows.Forms.Button();
            this.BtnAnzeigen2 = new System.Windows.Forms.Button();
            this.BtnAnzeigen3 = new System.Windows.Forms.Button();
            this.LblInput = new System.Windows.Forms.Label();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            this.CmdAnzeigen1.Location = new System.Drawing.Point(217, 19);
            this.CmdAnzeigen1.Name = "CmdAnzeigen1";
            this.CmdAnzeigen1.Size = new System.Drawing.Size(162, 23);
            this.CmdAnzeigen1.TabIndex = 0;
            this.CmdAnzeigen1.Text = "Addiere a, b, c, d";
            this.CmdAnzeigen1.UseVisualStyleBackColor = true;
            this.CmdAnzeigen1.Click += new System.EventHandler(this.CmdAnzeigen1_Click);
            // 
            // BtnAnzeigen2
            // 
            this.BtnAnzeigen2.Location = new System.Drawing.Point(217, 60);
            this.BtnAnzeigen2.Name = "BtnAnzeigen2";
            this.BtnAnzeigen2.Size = new System.Drawing.Size(163, 23);
            this.BtnAnzeigen2.TabIndex = 1;
            this.BtnAnzeigen2.Text = "Addiere a, b, c";
            this.BtnAnzeigen2.UseVisualStyleBackColor = true;
            this.BtnAnzeigen2.Click += new System.EventHandler(this.BtnAnzeigen2_Click);
            // 
            // BtnAnzeigen3
            // 
            this.BtnAnzeigen3.Location = new System.Drawing.Point(216, 102);
            this.BtnAnzeigen3.Name = "BtnAnzeigen3";
            this.BtnAnzeigen3.Size = new System.Drawing.Size(163, 23);
            this.BtnAnzeigen3.TabIndex = 2;
            this.BtnAnzeigen3.Text = "Addiere a, b";
            this.BtnAnzeigen3.UseVisualStyleBackColor = true;
            this.BtnAnzeigen3.Click += new System.EventHandler(this.BtnAnzeigen3_Click);
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.Location = new System.Drawing.Point(25, 23);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(38, 15);
            this.LblInput.TabIndex = 3;
            this.LblInput.Text = "Input:";
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(25, 106);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(48, 15);
            this.LblAnzeige.TabIndex = 4;
            this.LblAnzeige.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 145);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.LblInput);
            this.Controls.Add(this.BtnAnzeigen3);
            this.Controls.Add(this.BtnAnzeigen2);
            this.Controls.Add(this.CmdAnzeigen1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Theis 4.5.4, S.169: optionale Argumente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdAnzeigen1;
        private Button BtnAnzeigen2;
        private Button BtnAnzeigen3;
        private Label LblInput;
        private Label LblAnzeige;
    }
}