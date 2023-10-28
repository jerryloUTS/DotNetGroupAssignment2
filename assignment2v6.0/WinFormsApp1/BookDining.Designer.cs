namespace assignment2
{
    partial class BookDining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDining));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dtpCheckInTime = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            dtpCheckInDate = new DateTimePicker();
            numDpGuests = new NumericUpDown();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDpGuests).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(-4, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 476);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpCheckInTime);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpCheckInDate);
            groupBox1.Controls.Add(numDpGuests);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(291, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 403);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dining Reservation";
            // 
            // dtpCheckInTime
            // 
            dtpCheckInTime.Format = DateTimePickerFormat.Time;
            dtpCheckInTime.Location = new Point(264, 156);
            dtpCheckInTime.Name = "dtpCheckInTime";
            dtpCheckInTime.ShowUpDown = true;
            dtpCheckInTime.Size = new Size(146, 30);
            dtpCheckInTime.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 156);
            label5.Name = "label5";
            label5.Size = new Size(123, 23);
            label5.TabIndex = 8;
            label5.Text = "Check In Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 119);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 6;
            label3.Text = "Check In Date";
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Format = DateTimePickerFormat.Short;
            dtpCheckInDate.Location = new Point(264, 119);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(146, 30);
            dtpCheckInDate.TabIndex = 4;
            // 
            // numDpGuests
            // 
            numDpGuests.Location = new Point(264, 41);
            numDpGuests.Name = "numDpGuests";
            numDpGuests.Size = new Size(105, 30);
            numDpGuests.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 48);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 0;
            label1.Text = "Numbers of Guests";
            // 
            // BookDining
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 465);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "BookDining";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDpGuests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private DateTimePicker dtpCheckInTime;
        private Label label5;
        private Label label3;
        private DateTimePicker dtpCheckInDate;
        private NumericUpDown numDpGuests;
        private Label label1;
    }
}