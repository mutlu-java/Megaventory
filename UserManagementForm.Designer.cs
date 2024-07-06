namespace Megaventory
{
    partial class UserManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            usernametextBox = new TextBox();
            passwordtextBox = new TextBox();
            fullnametextBox = new TextBox();
            dataGridView1 = new DataGridView();
            addButton = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            telephonetextBox = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // usernametextBox
            // 
            usernametextBox.Font = new Font("Arial Nova", 14.25F);
            usernametextBox.Location = new Point(119, 73);
            usernametextBox.Name = "usernametextBox";
            usernametextBox.PlaceholderText = "Username";
            usernametextBox.Size = new Size(158, 30);
            usernametextBox.TabIndex = 0;
            // 
            // passwordtextBox
            // 
            passwordtextBox.Font = new Font("Arial Nova", 14.25F);
            passwordtextBox.Location = new Point(119, 186);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.PlaceholderText = "Password";
            passwordtextBox.Size = new Size(158, 30);
            passwordtextBox.TabIndex = 1;
            // 
            // fullnametextBox
            // 
            fullnametextBox.Font = new Font("Arial Nova", 14.25F);
            fullnametextBox.Location = new Point(119, 130);
            fullnametextBox.Name = "fullnametextBox";
            fullnametextBox.PlaceholderText = "Full Name";
            fullnametextBox.Size = new Size(158, 30);
            fullnametextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(408, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(569, 444);
            dataGridView1.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Location = new Point(70, 307);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 33);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(232, 307);
            button2.Name = "button2";
            button2.Size = new Size(75, 33);
            button2.TabIndex = 6;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(151, 307);
            button3.Name = "button3";
            button3.Size = new Size(75, 33);
            button3.TabIndex = 7;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(151, 361);
            button4.Name = "button4";
            button4.Size = new Size(75, 33);
            button4.TabIndex = 8;
            button4.Text = "Menu";
            button4.UseVisualStyleBackColor = true;
            // 
            // telephonetextBox
            // 
            telephonetextBox.Font = new Font("Arial Nova", 14.25F);
            telephonetextBox.Location = new Point(119, 243);
            telephonetextBox.Name = "telephonetextBox";
            telephonetextBox.PlaceholderText = "Telephone";
            telephonetextBox.Size = new Size(158, 30);
            telephonetextBox.TabIndex = 9;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, 37);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1022, 665);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(usernametextBox);
            tabPage1.Controls.Add(addButton);
            tabPage1.Controls.Add(telephonetextBox);
            tabPage1.Controls.Add(passwordtextBox);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(fullnametextBox);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1014, 632);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1014, 632);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1014, 632);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 702);
            Controls.Add(tabControl1);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox usernametextBox;
        private TextBox passwordtextBox;
        private TextBox fullnametextBox;
        private DataGridView dataGridView1;
        private Button addButton;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox telephonetextBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}