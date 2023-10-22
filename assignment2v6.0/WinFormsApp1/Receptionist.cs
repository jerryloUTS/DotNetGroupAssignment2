using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Receptionist : Form
    {
        LoginForm loginform;
        public Receptionist(LoginForm loginform, string username)
        {
            InitializeComponent();
            this.loginform = loginform;
        }
    }
}
