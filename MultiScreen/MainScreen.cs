using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiScreen
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form1.userName = "Mr. T";

            // f is the form that this control is on - ("this" is the current User Control)
            Form f = this.FindForm();
            f.Controls.Remove(this);

            // Create an instance of the SecondScreen
            SecondScreen ss = new SecondScreen();
            ss.Location = new Point((f.Width - ss.Width) / 2, (f.Height - ss.Height) / 2);

            // Add the User Control to the Form
            f.Controls.Add(ss);

            
        }
    }
}
