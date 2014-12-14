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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newChar_Click(object sender, EventArgs e)
        {
            Form characterForm;
            characterForm = new AddCharacter();
            characterForm.Show();
            this.Hide();
        }

        private void combat_Click(object sender, EventArgs e)
        {
            Form formOfCombat;
            formOfCombat = new combatForm();
            formOfCombat.Show();
            this.Hide();
        }
    }
}
