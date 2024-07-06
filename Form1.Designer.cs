namespace Megaventory
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
            panel1 = new Panel();
            loginbtn = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            passwordtb = new TextBox();
            usernametb = new TextBox();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 620);
            panel1.TabIndex = 0;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Transparent;
            loginbtn.Image = (Image)resources.GetObject("loginbtn.Image");
            loginbtn.Location = new Point(217, 340);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(291, 56);
            loginbtn.TabIndex = 1;
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(286, 67);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 2;
            label1.Text = "Account Log In";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(passwordtb);
            panel2.Controls.Add(usernametb);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(loginbtn);
            panel2.Location = new Point(345, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 620);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(7, 586);
            label3.Name = "label3";
            label3.Size = new Size(325, 15);
            label3.TabIndex = 6;
            label3.Text = "Copyright 2023 - 2024 MutluPortfolio Inc. All rights Reserved";
            // 
            // passwordtb
            // 
            passwordtb.BorderStyle = BorderStyle.FixedSingle;
            passwordtb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            passwordtb.Location = new Point(217, 267);
            passwordtb.Name = "passwordtb";
            passwordtb.PlaceholderText = "Password";
            passwordtb.Size = new Size(291, 39);
            passwordtb.TabIndex = 5;
            // 
            // usernametb
            // 
            usernametb.BorderStyle = BorderStyle.FixedSingle;
            usernametb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            usernametb.Location = new Point(218, 194);
            usernametb.Name = "usernametb";
            usernametb.PlaceholderText = "Username";
            usernametb.Size = new Size(290, 39);
            usernametb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(235, 113);
            label2.Name = "label2";
            label2.Size = new Size(254, 16);
            label2.TabIndex = 3;
            label2.Text = "PLEASE LOGIN TO CONTNUE TO YOUR ACCOUNT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1100, 620);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button loginbtn;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox passwordtb;
        private TextBox usernametb;
        private Label label3;
    }
}
