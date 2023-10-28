namespace assignment2
{
    partial class BookRoomForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            dtpCheckOutTime = new DateTimePicker();
            dtpCheckInTime = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dtpCheckOutDate = new DateTimePicker();
            dtpCheckInDate = new DateTimePicker();
            numDpDependents = new NumericUpDown();
            numDpGuests = new NumericUpDown();
            label2 = new Label();
            lblBookingInfo = new Label();
            btnBook = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDpDependents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDpGuests).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 48);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Numbers of Guests";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpCheckOutTime);
            groupBox1.Controls.Add(dtpCheckInTime);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpCheckOutDate);
            groupBox1.Controls.Add(dtpCheckInDate);
            groupBox1.Controls.Add(numDpDependents);
            groupBox1.Controls.Add(numDpGuests);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 299);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Booking Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 219);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 11;
            label6.Text = "Check Out Time";
            // 
            // dtpCheckOutTime
            // 
            dtpCheckOutTime.Format = DateTimePickerFormat.Time;
            dtpCheckOutTime.Location = new Point(264, 219);
            dtpCheckOutTime.Name = "dtpCheckOutTime";
            dtpCheckOutTime.ShowUpDown = true;
            dtpCheckOutTime.Size = new Size(146, 27);
            dtpCheckOutTime.TabIndex = 10;
            // 
            // dtpCheckInTime
            // 
            dtpCheckInTime.Format = DateTimePickerFormat.Time;
            dtpCheckInTime.Location = new Point(264, 156);
            dtpCheckInTime.Name = "dtpCheckInTime";
            dtpCheckInTime.ShowUpDown = true;
            dtpCheckInTime.Size = new Size(146, 27);
            dtpCheckInTime.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 156);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 8;
            label5.Text = "Check In Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 186);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 7;
            label4.Text = "Check Out Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 119);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 6;
            label3.Text = "Check In Date";
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Format = DateTimePickerFormat.Short;
            dtpCheckOutDate.Location = new Point(264, 186);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(146, 27);
            dtpCheckOutDate.TabIndex = 5;
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Format = DateTimePickerFormat.Short;
            dtpCheckInDate.Location = new Point(264, 119);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(146, 27);
            dtpCheckInDate.TabIndex = 4;
            // 
            // numDpDependents
            // 
            numDpDependents.Location = new Point(264, 81);
            numDpDependents.Name = "numDpDependents";
            numDpDependents.Size = new Size(105, 27);
            numDpDependents.TabIndex = 3;
            numDpDependents.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numDpGuests
            // 
            numDpGuests.Location = new Point(264, 41);
            numDpGuests.Name = "numDpGuests";
            numDpGuests.Size = new Size(105, 27);
            numDpGuests.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 83);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 1;
            label2.Text = "Numbers of Dependents";
            // 
            // lblBookingInfo
            // 
            lblBookingInfo.AutoSize = true;
            lblBookingInfo.Location = new Point(30, 24);
            lblBookingInfo.Name = "lblBookingInfo";
            lblBookingInfo.Size = new Size(50, 20);
            lblBookingInfo.TabIndex = 2;
            lblBookingInfo.Text = "label3";
            lblBookingInfo.Click += lblBookingInfo_Click;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(371, 463);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(94, 29);
            btnBook.TabIndex = 3;
            btnBook.Text = "Book ";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(250, 463);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // BookRoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 536);
            Controls.Add(btnCancel);
            Controls.Add(btnBook);
            Controls.Add(lblBookingInfo);
            Controls.Add(groupBox1);
            Name = "BookRoomForm";
            Text = "BookRoomForm";
            Load += BookRoomForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDpDependents).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDpGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private NumericUpDown numDpDependents;
        private NumericUpDown numDpGuests;
        private Label label2;
        private Label lblBookingInfo;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpCheckOutDate;
        private DateTimePicker dtpCheckInDate;
        private Button btnBook;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpCheckOutTime;
        private DateTimePicker dtpCheckInTime;
        private Button btnCancel;
    }
}