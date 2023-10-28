namespace assignment2
{
    partial class ReceptionistForm
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
            menuStrip1 = new MenuStrip();
            manageToolStripMenuItem = new ToolStripMenuItem();
            viewAllCustomersToolStripMenuItem = new ToolStripMenuItem();
            reportIncidentToolStripMenuItem = new ToolStripMenuItem();
            viewAllBookingsToolStripMenuItem = new ToolStripMenuItem();
            viewIncidentReportsMenuItem = new ToolStripMenuItem();
            viewDinnerReservationsToolStripMenuItem = new ToolStripMenuItem();
            foodToolStripMenuItem = new ToolStripMenuItem();
            viewMenuToolStripMenuItem = new ToolStripMenuItem();
            btnBook = new Button();
            lbCustomers = new ListBox();
            lbRooms = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogOut = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(34, 311);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(143, 29);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageToolStripMenuItem, foodToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewAllCustomersToolStripMenuItem, reportIncidentToolStripMenuItem, viewAllBookingsToolStripMenuItem, viewIncidentReportsMenuItem, viewDinnerReservationsToolStripMenuItem });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(77, 24);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // viewAllCustomersToolStripMenuItem
            // 
            viewAllCustomersToolStripMenuItem.Name = "viewAllCustomersToolStripMenuItem";
            viewAllCustomersToolStripMenuItem.Size = new Size(259, 26);
            viewAllCustomersToolStripMenuItem.Text = "View All Customers";
            // 
            // reportIncidentToolStripMenuItem
            // 
            reportIncidentToolStripMenuItem.Name = "reportIncidentToolStripMenuItem";
            reportIncidentToolStripMenuItem.Size = new Size(259, 26);
            reportIncidentToolStripMenuItem.Text = "Report Incident";
            reportIncidentToolStripMenuItem.Click += reportIncidentToolStripMenuItem_Click;
            // 
            // viewAllBookingsToolStripMenuItem
            // 
            viewAllBookingsToolStripMenuItem.Name = "viewAllBookingsToolStripMenuItem";
            viewAllBookingsToolStripMenuItem.Size = new Size(259, 26);
            viewAllBookingsToolStripMenuItem.Text = "View All Bookings";
            viewAllBookingsToolStripMenuItem.Click += viewAllBookingsToolStripMenuItem_Click;
            // 
            // viewIncidentReportsMenuItem
            // 
            viewIncidentReportsMenuItem.Name = "viewIncidentReportsMenuItem";
            viewIncidentReportsMenuItem.Size = new Size(259, 26);
            viewIncidentReportsMenuItem.Text = "View Incident Reports";
            viewIncidentReportsMenuItem.Click += viewIncidentReportsMenuItem_Click;
            // 
            // viewDinnerReservationsToolStripMenuItem
            // 
            viewDinnerReservationsToolStripMenuItem.Name = "viewDinnerReservationsToolStripMenuItem";
            viewDinnerReservationsToolStripMenuItem.Size = new Size(259, 26);
            viewDinnerReservationsToolStripMenuItem.Text = "View Dinner Reservations";
            viewDinnerReservationsToolStripMenuItem.Click += viewDinnerReservationsToolStripMenuItem_Click;
            // 
            // foodToolStripMenuItem
            // 
            foodToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewMenuToolStripMenuItem });
            foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            foodToolStripMenuItem.Size = new Size(57, 24);
            foodToolStripMenuItem.Text = "Food";
            // 
            // viewMenuToolStripMenuItem
            // 
            viewMenuToolStripMenuItem.Name = "viewMenuToolStripMenuItem";
            viewMenuToolStripMenuItem.Size = new Size(165, 26);
            viewMenuToolStripMenuItem.Text = "View Menu";
            viewMenuToolStripMenuItem.Click += viewMenuToolStripMenuItem_Click;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(526, 391);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(131, 29);
            btnBook.TabIndex = 2;
            btnBook.Text = "Book a Room";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // lbCustomers
            // 
            lbCustomers.FormattingEnabled = true;
            lbCustomers.ItemHeight = 20;
            lbCustomers.Location = new Point(255, 162);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(213, 204);
            lbCustomers.TabIndex = 3;
            lbCustomers.SelectedIndexChanged += lbCustomers_SelectedIndexChanged;
            // 
            // lbRooms
            // 
            lbRooms.FormattingEnabled = true;
            lbRooms.ItemHeight = 20;
            lbRooms.Location = new Point(526, 162);
            lbRooms.Name = "lbRooms";
            lbRooms.Size = new Size(210, 204);
            lbRooms.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 62);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 41);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 6;
            label2.Text = "Select a Customer";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 51);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 7;
            label3.Text = "Select a Room";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(34, 391);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(92, 29);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // ReceptionistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogOut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbRooms);
            Controls.Add(lbCustomers);
            Controls.Add(btnBook);
            Controls.Add(btnAddCustomer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ReceptionistForm";
            Text = "ReceptionistForm";
            Load += ReceptionistForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCustomer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem viewAllCustomersToolStripMenuItem;
        private ToolStripMenuItem foodToolStripMenuItem;
        private ToolStripMenuItem viewMenuToolStripMenuItem;
        private ToolStripMenuItem reportIncidentToolStripMenuItem;
        private Button btnBook;
        private ListBox lbCustomers;
        private ListBox lbRooms;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogOut;
        private ToolStripMenuItem viewAllBookingsToolStripMenuItem;
        private ToolStripMenuItem viewIncidentReportsMenuItem;
        private ToolStripMenuItem viewDinnerReservationsToolStripMenuItem;
    }
}