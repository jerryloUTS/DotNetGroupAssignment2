namespace assignment2
{
    partial class AllCustomers
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            label7 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            OpenBtn = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(342, 758);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 38);
            button1.TabIndex = 63;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 164);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 62;
            label1.Text = "All Customers";
            label1.Click += label1_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(350, 112);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(196, 31);
            label7.TabIndex = 60;
            label7.Text = "All Customers";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // OpenBtn
            // 
            OpenBtn.Location = new Point(434, 758);
            OpenBtn.Margin = new Padding(3, 4, 3, 4);
            OpenBtn.Name = "OpenBtn";
            OpenBtn.Size = new Size(86, 38);
            OpenBtn.TabIndex = 65;
            OpenBtn.Text = "Open";
            OpenBtn.UseVisualStyleBackColor = true;
            OpenBtn.Click += OpenBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(100, 188);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(700, 562);
            richTextBox1.TabIndex = 67;
            richTextBox1.Text = "";
            // 
            // AllCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 879);
            Controls.Add(richTextBox1);
            Controls.Add(OpenBtn);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label7);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AllCustomers";
            Text = "View All Customers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label7;
        private ContextMenuStrip contextMenuStrip1;
        private Button OpenBtn;
        private RichTextBox richTextBox1;
    }
}