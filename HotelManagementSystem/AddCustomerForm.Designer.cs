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
            button1 = new Button();
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
            txtAddressL2 = new TextBox();
            label6 = new Label();
            txtAdrressL1 = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(278, 398);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            groupBox2.Controls.Add(txtAddressL2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtAdrressL1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(18, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 167);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Address Details";
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
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
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

        private Button button1;
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
    }
}