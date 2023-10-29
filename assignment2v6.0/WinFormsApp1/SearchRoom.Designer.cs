namespace assignment2
{
    partial class SearchRoom
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
            roomSearch = new TextBox();
            label7 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(399, 866);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 69;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // roomSearch
            // 
            roomSearch.Location = new Point(153, 229);
            roomSearch.Margin = new Padding(3, 4, 3, 4);
            roomSearch.Name = "roomSearch";
            roomSearch.Size = new Size(524, 27);
            roomSearch.TabIndex = 67;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(340, 111);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(190, 31);
            label7.TabIndex = 66;
            label7.Text = "Search Room";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 230);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 65;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(103, 264);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(687, 594);
            richTextBox1.TabIndex = 70;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(683, 229);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
            button2.TabIndex = 71;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SearchRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 1058);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(roomSearch);
            Controls.Add(label7);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SearchRoom";
            Text = "SearchRoom";
            Load += SearchRoom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox roomSearch;
        private Label label7;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button button2;
    }
}