namespace assignment2
{
    partial class NewCustomerForm
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
            SubmitBtn = new Button();
            CancelBtn = new Button();
            label7 = new Label();
            dobPicker = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            phoneTxtBox = new TextBox();
            label3 = new Label();
            emailTxtBox = new TextBox();
            label2 = new Label();
            passReenterTxtBox = new TextBox();
            label1 = new Label();
            passTxtBox = new TextBox();
            userTxtBox = new TextBox();
            usernameLbl = new Label();
            label6 = new Label();
            fNameTxtBox = new TextBox();
            label8 = new Label();
            surnameTxtBox = new TextBox();
            groupBox1 = new GroupBox();
            stateComboBox = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            cityTxtBox = new TextBox();
            label9 = new Label();
            addressTxtBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitBtn
            // 
            SubmitBtn.DialogResult = DialogResult.OK;
            SubmitBtn.Location = new Point(443, 656);
            SubmitBtn.Margin = new Padding(4, 5, 4, 5);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(100, 35);
            SubmitBtn.TabIndex = 31;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(234, 656);
            CancelBtn.Margin = new Padding(4, 5, 4, 5);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(100, 35);
            CancelBtn.TabIndex = 30;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(228, 22);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(142, 31);
            label7.TabIndex = 32;
            label7.Text = "New User";
            // 
            // dobPicker
            // 
            dobPicker.CustomFormat = "dd-MM-yyyy";
            dobPicker.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dobPicker.Format = DateTimePickerFormat.Custom;
            dobPicker.Location = new Point(234, 594);
            dobPicker.Margin = new Padding(4, 5, 4, 5);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(309, 26);
            dobPicker.TabIndex = 29;
            dobPicker.ValueChanged += dobPicker_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(57, 596);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 28;
            label5.Text = "Date of Birth:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(57, 298);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 27;
            label4.Text = "Last Name:";
            // 
            // phoneTxtBox
            // 
            phoneTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTxtBox.Location = new Point(234, 394);
            phoneTxtBox.Margin = new Padding(4, 5, 4, 5);
            phoneTxtBox.Name = "phoneTxtBox";
            phoneTxtBox.Size = new Size(309, 26);
            phoneTxtBox.TabIndex = 25;
            phoneTxtBox.TextChanged += phoneTxtBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(57, 248);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 25;
            label3.Text = "First Name:";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            emailTxtBox.Location = new Point(234, 344);
            emailTxtBox.Margin = new Padding(4, 5, 4, 5);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(309, 26);
            emailTxtBox.TabIndex = 24;
            emailTxtBox.TextChanged += emailTxtBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 198);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 23;
            label2.Text = "Re-enter Password:";
            // 
            // passReenterTxtBox
            // 
            passReenterTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passReenterTxtBox.Location = new Point(234, 194);
            passReenterTxtBox.Margin = new Padding(4, 5, 4, 5);
            passReenterTxtBox.Name = "passReenterTxtBox";
            passReenterTxtBox.PasswordChar = '*';
            passReenterTxtBox.Size = new Size(309, 26);
            passReenterTxtBox.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 148);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 21;
            label1.Text = "Password:";
            // 
            // passTxtBox
            // 
            passTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passTxtBox.Location = new Point(234, 144);
            passTxtBox.Margin = new Padding(4, 5, 4, 5);
            passTxtBox.Name = "passTxtBox";
            passTxtBox.PasswordChar = '*';
            passTxtBox.Size = new Size(309, 26);
            passTxtBox.TabIndex = 20;
            passTxtBox.TextChanged += passTxtBox_TextChanged;
            // 
            // userTxtBox
            // 
            userTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            userTxtBox.Location = new Point(234, 94);
            userTxtBox.Margin = new Padding(4, 5, 4, 5);
            userTxtBox.Name = "userTxtBox";
            userTxtBox.Size = new Size(309, 26);
            userTxtBox.TabIndex = 19;
            userTxtBox.TextChanged += userTxtBx_TextChanged;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLbl.Location = new Point(57, 98);
            usernameLbl.Margin = new Padding(4, 0, 4, 0);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(91, 20);
            usernameLbl.TabIndex = 18;
            usernameLbl.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(57, 351);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 36;
            label6.Text = "E-Mail:";
            label6.Click += label6_Click;
            // 
            // fNameTxtBox
            // 
            fNameTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fNameTxtBox.Location = new Point(234, 244);
            fNameTxtBox.Margin = new Padding(4, 5, 4, 5);
            fNameTxtBox.Name = "fNameTxtBox";
            fNameTxtBox.Size = new Size(309, 26);
            fNameTxtBox.TabIndex = 22;
            fNameTxtBox.TextChanged += fNameTxtBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(57, 398);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 38;
            label8.Text = "Phone Number:";
            // 
            // surnameTxtBox
            // 
            surnameTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            surnameTxtBox.Location = new Point(234, 294);
            surnameTxtBox.Margin = new Padding(4, 5, 4, 5);
            surnameTxtBox.Name = "surnameTxtBox";
            surnameTxtBox.Size = new Size(309, 26);
            surnameTxtBox.TabIndex = 23;
            surnameTxtBox.TextChanged += surnameTxtBox_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(userTxtBox);
            groupBox1.Controls.Add(stateComboBox);
            groupBox1.Controls.Add(usernameLbl);
            groupBox1.Controls.Add(SubmitBtn);
            groupBox1.Controls.Add(CancelBtn);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cityTxtBox);
            groupBox1.Controls.Add(dobPicker);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(addressTxtBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(surnameTxtBox);
            groupBox1.Controls.Add(passTxtBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(phoneTxtBox);
            groupBox1.Controls.Add(fNameTxtBox);
            groupBox1.Controls.Add(passReenterTxtBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(emailTxtBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(150, 94);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(650, 750);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add User";
            // 
            // stateComboBox
            // 
            stateComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Items.AddRange(new object[] { "New South Wales", "Queensland", "Victoria", "Northern Territory", "South Australia", "Tasmania", "Western Australia" });
            stateComboBox.Location = new Point(234, 544);
            stateComboBox.Margin = new Padding(3, 4, 3, 4);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(309, 26);
            stateComboBox.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(57, 544);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 44;
            label11.Text = "State:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(57, 498);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 42;
            label10.Text = "City:";
            // 
            // cityTxtBox
            // 
            cityTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cityTxtBox.Location = new Point(234, 494);
            cityTxtBox.Margin = new Padding(4, 5, 4, 5);
            cityTxtBox.Name = "cityTxtBox";
            cityTxtBox.Size = new Size(309, 26);
            cityTxtBox.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(57, 448);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 40;
            label9.Text = "Address:";
            // 
            // addressTxtBox
            // 
            addressTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addressTxtBox.Location = new Point(234, 444);
            addressTxtBox.Margin = new Padding(4, 5, 4, 5);
            addressTxtBox.Name = "addressTxtBox";
            addressTxtBox.Size = new Size(309, 26);
            addressTxtBox.TabIndex = 26;
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(932, 941);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewCustomerForm";
            Text = "Add New User";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button SubmitBtn;
        private Button CancelBtn;
        private Label label7;
        private DateTimePicker dobPicker;
        private Label label5;
        private Label label4;
        private TextBox phoneTxtBox;
        private Label label3;
        private TextBox emailTxtBox;
        private Label label2;
        private TextBox passReenterTxtBox;
        private Label label1;
        private TextBox passTxtBox;
        private TextBox userTxtBox;
        private Label usernameLbl;
        private Label label6;
        private TextBox fNameTxtBox;
        private Label label8;
        private TextBox surnameTxtBox;
        private GroupBox groupBox1;
        private Label label11;
        private Label label10;
        private TextBox cityTxtBox;
        private Label label9;
        private TextBox addressTxtBox;
        private ComboBox stateComboBox;
    }
}