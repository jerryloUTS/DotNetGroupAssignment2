namespace HotelManagementSystem
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
            bookHotelRoomToolStripMenuItem = new ToolStripMenuItem();
            viewAllCustomersToolStripMenuItem = new ToolStripMenuItem();
            foodToolStripMenuItem = new ToolStripMenuItem();
            viewMenuToolStripMenuItem = new ToolStripMenuItem();
            reportIncidentToolStripMenuItem = new ToolStripMenuItem();
            btnBook = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(62, 281);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(143, 29);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += button1_Click;
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
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookHotelRoomToolStripMenuItem, viewAllCustomersToolStripMenuItem, reportIncidentToolStripMenuItem });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(77, 24);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // bookHotelRoomToolStripMenuItem
            // 
            bookHotelRoomToolStripMenuItem.Name = "bookHotelRoomToolStripMenuItem";
            bookHotelRoomToolStripMenuItem.Size = new Size(224, 26);
            bookHotelRoomToolStripMenuItem.Text = "Book Hotel Room";
            // 
            // viewAllCustomersToolStripMenuItem
            // 
            viewAllCustomersToolStripMenuItem.Name = "viewAllCustomersToolStripMenuItem";
            viewAllCustomersToolStripMenuItem.Size = new Size(224, 26);
            viewAllCustomersToolStripMenuItem.Text = "View All Customers";
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
            viewMenuToolStripMenuItem.Size = new Size(224, 26);
            viewMenuToolStripMenuItem.Text = "View Menu";
            // 
            // reportIncidentToolStripMenuItem
            // 
            reportIncidentToolStripMenuItem.Name = "reportIncidentToolStripMenuItem";
            reportIncidentToolStripMenuItem.Size = new Size(224, 26);
            reportIncidentToolStripMenuItem.Text = "Report Incident";
            // 
            // btnBook
            // 
            btnBook.Location = new Point(43, 166);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(131, 29);
            btnBook.TabIndex = 2;
            btnBook.Text = "Book a Room";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(349, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 3;
            // 
            // ReceptionistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnBook);
            Controls.Add(btnAddCustomer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ReceptionistForm";
            Text = "ReceptionistForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCustomer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem bookHotelRoomToolStripMenuItem;
        private ToolStripMenuItem viewAllCustomersToolStripMenuItem;
        private ToolStripMenuItem foodToolStripMenuItem;
        private ToolStripMenuItem viewMenuToolStripMenuItem;
        private ToolStripMenuItem reportIncidentToolStripMenuItem;
        private Button btnBook;
        private DataGridView dataGridView1;
    }
}