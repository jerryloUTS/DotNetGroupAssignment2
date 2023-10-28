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
            reserveButton = new Button();
            reserveTime = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            reserveDate = new DateTimePicker();
            numGuests = new NumericUpDown();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGuests).BeginInit();
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
            groupBox1.Controls.Add(reserveButton);
            groupBox1.Controls.Add(reserveTime);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(reserveDate);
            groupBox1.Controls.Add(numGuests);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(291, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 395);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dining Reservation";
            // 
            // reserveButton
            // 
            reserveButton.Location = new Point(187, 335);
            reserveButton.Name = "reserveButton";
            reserveButton.Size = new Size(94, 33);
            reserveButton.TabIndex = 10;
            reserveButton.Text = "Reserve";
            reserveButton.UseVisualStyleBackColor = true;
            reserveButton.Click += reserveButton_Click;
            // 
            // reserveTime
            // 
            reserveTime.Format = DateTimePickerFormat.Time;
            reserveTime.Location = new Point(264, 156);
            reserveTime.Name = "reserveTime";
            reserveTime.ShowUpDown = true;
            reserveTime.Size = new Size(146, 30);
            reserveTime.TabIndex = 9;
            reserveTime.Value = new DateTime(2023, 10, 29, 0, 3, 37, 0);
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
            // reserveDate
            // 
            reserveDate.Format = DateTimePickerFormat.Short;
            reserveDate.Location = new Point(264, 119);
            reserveDate.Name = "reserveDate";
            reserveDate.Size = new Size(146, 30);
            reserveDate.TabIndex = 4;
            // 
            // numGuests
            // 
            numGuests.Location = new Point(264, 41);
            numGuests.Name = "numGuests";
            numGuests.Size = new Size(105, 30);
            numGuests.TabIndex = 2;
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
            Text = "Book Dining";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGuests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private DateTimePicker reserveTime;
        private Label label5;
        private Label label3;
        private DateTimePicker reserveDate;
        private NumericUpDown numGuests;
        private Label label1;
        private Button reserveButton;
    }
}