using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anima_Combat
{
    public partial class AddCharacter : Form
    {
        public AddCharacter()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form main;
            main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
