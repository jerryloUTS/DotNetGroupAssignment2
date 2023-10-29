namespace assignment2
{
    partial class AllBookings
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
            dgvAllBookings = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAllBookings).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(267, 385);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvAllBookings
            // 
            dgvAllBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllBookings.Location = new Point(50, 36);
            dgvAllBookings.Name = "dgvAllBookings";
            dgvAllBookings.RowHeadersWidth = 51;
            dgvAllBookings.RowTemplate.Height = 29;
            dgvAllBookings.Size = new Size(635, 317);
            dgvAllBookings.TabIndex = 1;
            dgvAllBookings.CellContentClick += dgvAllBookings_CellContentClick;
            // 
            // AllBookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 500);
            Controls.Add(dgvAllBookings);
            Controls.Add(button1);
            Name = "AllBookings";
            Text = "View All Bookings";
            Load += AllBookings_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvAllBookings;
    }
}