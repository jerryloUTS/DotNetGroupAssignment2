namespace HotelManagementSystem
{
    partial class AddCustomerForm
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
            btnSubmit = new Button();
            groupBox1 = new GroupBox();
            txtPhone = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtLname = new TextBox();
            label2 = new Label();
            txtFname = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label7 = new Label();
            cmbCountry = new ComboBox();
            txtAddressL2 = new TextBox();
            label6 = new Label();
            txtAdrressL1 = new TextBox();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtPostCode = new TextBox();
            label10 = new Label();
            cmbCity = new ComboBox();
            cmbState = new ComboBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(278, 398);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFname);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 228);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details.";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(171, 173);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(191, 27);
            txtPhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 173);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 6;
            label4.Text = "Phone Number";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 27);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 123);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 4;
            label3.Text = "Email Address:";
            // 
            // txtLname
            // 
            txtLname.Location = new Point(171, 79);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(191, 27);
            txtLname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 79);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Last Name: *";
            label2.Click += label2_Click;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(171, 40);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(191, 27);
            txtFname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 47);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name: *";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(0, 20);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 345);
            panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbState);
            groupBox2.Controls.Add(cmbCity);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtPostCode);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmbCountry);
            groupBox2.Controls.Add(txtAddressL2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtAdrressL1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(18, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 332);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Address Details";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 115);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 5;
            label7.Text = "Country";
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(159, 115);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(183, 28);
            cmbCountry.TabIndex = 4;
            // 
            // txtAddressL2
            // 
            txtAddressL2.Location = new Point(160, 70);
            txtAddressL2.Name = "txtAddressL2";
            txtAddressL2.Size = new Size(182, 27);
            txtAddressL2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 73);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 2;
            label6.Text = "Address Line 2: *";
            label6.Click += label6_Click;
            // 
            // txtAdrressL1
            // 
            txtAdrressL1.Location = new Point(160, 32);
            txtAdrressL1.Name = "txtAdrressL1";
            txtAdrressL1.Size = new Size(182, 27);
            txtAdrressL1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 35);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 0;
            label5.Text = "Address Line 1: *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 156);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 6;
            label8.Text = "City";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 219);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 7;
            label9.Text = "State";
            // 
            // txtPostCode
            // 
            txtPostCode.Location = new Point(159, 261);
            txtPostCode.Name = "txtPostCode";
            txtPostCode.Size = new Size(183, 27);
            txtPostCode.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 261);
            label10.Name = "label10";
            label10.Size = new Size(117, 20);
            label10.TabIndex = 9;
            label10.Text = "Postal/ZIP Code:";
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(159, 167);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(183, 28);
            cmbCity.TabIndex = 10;
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(160, 216);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(183, 28);
            cmbState.TabIndex = 11;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(panel1);
            Controls.Add(btnSubmit);
            Name = "AddCustomerForm";
            Text = "AddCustomerForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubmit;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtFname;
        private TextBox txtLname;
        private Panel panel1;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private TextBox txtAdrressL1;
        private TextBox txtAddressL2;
        private ComboBox cmbCountry;
        private Label label7;
        private Label label10;
        private TextBox txtPostCode;
        private Label label9;
        private Label label8;
        private ComboBox cmbState;
        private ComboBox cmbCity;
    }
}