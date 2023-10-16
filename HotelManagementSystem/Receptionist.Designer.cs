namespace HotelManagementSystem
{
    partial class Receptionist
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
            btnAddCustomer = new Button();
            lblReceptionistName = new Label();
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(74, 257);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(183, 55);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // lblReceptionistName
            // 
            lblReceptionistName.AutoSize = true;
            lblReceptionistName.Location = new Point(88, 50);
            lblReceptionistName.Name = "lblReceptionistName";
            lblReceptionistName.Size = new Size(49, 20);
            lblReceptionistName.TabIndex = 1;
            lblReceptionistName.Text = "Hello ";
            // 
            // Receptionist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblReceptionistName);
            Controls.Add(btnAddCustomer);
            Name = "Receptionist";
            Text = "Receptionist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCustomer;
        private Label lblReceptionistName;
    }
}