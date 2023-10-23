namespace assignment2
{
    partial class LoginForm
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
            LoginTitle = new Label();
            Login = new Button();
            NewUser = new Button();
            PassTxtbox = new TextBox();
            passwordLbl = new Label();
            UsernameLbl = new Label();
            userTxtBx = new TextBox();
            Exit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // LoginTitle
            // 
            LoginTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginTitle.AutoSize = true;
            LoginTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginTitle.Location = new Point(232, 89);
            LoginTitle.Margin = new Padding(4, 0, 4, 0);
            LoginTitle.Name = "LoginTitle";
            LoginTitle.Size = new Size(201, 39);
            LoginTitle.TabIndex = 8;
            LoginTitle.Text = "Hotel Login";
            LoginTitle.Click += label1_Click;
            // 
            // Login
            // 
            Login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Login.Location = new Point(437, 294);
            Login.Margin = new Padding(4, 5, 4, 5);
            Login.Name = "Login";
            Login.Size = new Size(100, 35);
            Login.TabIndex = 14;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += LoginBtn_Click;
            // 
            // NewUser
            // 
            NewUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewUser.Location = new Point(329, 294);
            NewUser.Margin = new Padding(4, 5, 4, 5);
            NewUser.Name = "NewUser";
            NewUser.Size = new Size(100, 35);
            NewUser.TabIndex = 13;
            NewUser.Text = "New User";
            NewUser.UseVisualStyleBackColor = true;
            NewUser.Click += NewUserBtn_Click;
            // 
            // PassTxtbox
            // 
            PassTxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PassTxtbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassTxtbox.Location = new Point(239, 246);
            PassTxtbox.Margin = new Padding(4, 5, 4, 5);
            PassTxtbox.Name = "PassTxtbox";
            PassTxtbox.PasswordChar = '*';
            PassTxtbox.Size = new Size(309, 30);
            PassTxtbox.TabIndex = 12;
            PassTxtbox.TextChanged += PassTxtbox_TextChanged;
            // 
            // passwordLbl
            // 
            passwordLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLbl.Location = new Point(67, 244);
            passwordLbl.Margin = new Padding(4, 0, 4, 0);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(149, 31);
            passwordLbl.TabIndex = 11;
            passwordLbl.Text = "Password: ";
            passwordLbl.Click += passwordLbl_Click;
            // 
            // UsernameLbl
            // 
            UsernameLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameLbl.AutoSize = true;
            UsernameLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLbl.Location = new Point(67, 182);
            UsernameLbl.Margin = new Padding(4, 0, 4, 0);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(154, 31);
            UsernameLbl.TabIndex = 10;
            UsernameLbl.Text = "Username: ";
            UsernameLbl.Click += UsernameLbl_Click;
            // 
            // userTxtBx
            // 
            userTxtBx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userTxtBx.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userTxtBx.Location = new Point(239, 185);
            userTxtBx.Margin = new Padding(4, 5, 4, 5);
            userTxtBx.Name = "userTxtBx";
            userTxtBx.Size = new Size(309, 30);
            userTxtBx.TabIndex = 9;
            userTxtBx.TextChanged += userTxtBx_TextChanged;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Exit.Location = new Point(600, 448);
            Exit.Margin = new Padding(3, 4, 3, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(101, 35);
            Exit.TabIndex = 17;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(61, 413);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 498);
            Controls.Add(button1);
            Controls.Add(Exit);
            Controls.Add(Login);
            Controls.Add(NewUser);
            Controls.Add(PassTxtbox);
            Controls.Add(passwordLbl);
            Controls.Add(UsernameLbl);
            Controls.Add(userTxtBx);
            Controls.Add(LoginTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginTitle;
        private Button Login;
        private Button NewUser;
        private TextBox PassTxtbox;
        private Label passwordLbl;
        private Label UsernameLbl;
        private TextBox userTxtBx;
        private Button Exit;
        private Button button1;
    }
}

