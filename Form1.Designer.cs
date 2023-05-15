
namespace HotelManagement
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
            this.userL = new System.Windows.Forms.Label();
            this.passL = new System.Windows.Forms.Label();
            this.userTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.Location = new System.Drawing.Point(60, 59);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(58, 13);
            this.userL.TabIndex = 0;
            this.userL.Text = "Username:";
            // 
            // passL
            // 
            this.passL.AutoSize = true;
            this.passL.Location = new System.Drawing.Point(60, 99);
            this.passL.Name = "passL";
            this.passL.Size = new System.Drawing.Size(56, 13);
            this.passL.TabIndex = 0;
            this.passL.Text = "Password:";
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(140, 59);
            this.userTB.MaxLength = 40;
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(100, 20);
            this.userTB.TabIndex = 1;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(140, 99);
            this.passTB.MaxLength = 40;
            this.passTB.Name = "passTB";
            this.passTB.PasswordChar = '*';
            this.passTB.Size = new System.Drawing.Size(100, 20);
            this.passTB.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Είσοδος";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.passL);
            this.Controls.Add(this.userL);
            this.Name = "Form1";
            this.Text = "Είσοδος";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userL;
        private System.Windows.Forms.Label passL;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button button1;
    }
}

