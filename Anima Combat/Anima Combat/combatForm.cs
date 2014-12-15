using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AnimaCombatLibrary;

namespace Anima_Combat
{
    public partial class combatForm : Form
    {

        public combatForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_Click(object sender, EventArgs e)
        {
            Form main;
            main = new Main();
            main.Show();
            this.Hide();
        }

        private void addCombatant_Click(object sender, EventArgs e)
        {
            if (namePanel.Controls.Count >= 23)
            {
                addCombatant.Hide();
            }
            int itemCount = namePanel.Controls.Count;
            TextBox textbox = new TextBox();
            textbox.Location = new System.Drawing.Point(3, 25 * itemCount);
            textbox.Size = new System.Drawing.Size(110, 20);
            textbox.Name = "textbox_" + (itemCount + 1 );
            // textbox.Text = textbox.Name; // Checks name of textbox
            namePanel.Controls.Add(textbox);

            Label label = new Label();
            label.Location = new Point(3, 25 * itemCount);
            label.Name = "rolledInitiative_" + (itemCount + 1);
            label.Text = "0";
            rolledInitiativePanel.Controls.Add(label);

            NumericUpDown initiativeUpDown = new NumericUpDown();
            initiativeUpDown.Location = new Point(3, 25 * itemCount);
            initiativeUpDown.Size = new Size(50, 20);
            initiativeUpDown.Name = "initiativeUpDown_" + (itemCount + 1);
            initiativeUpDown.Maximum = 10000;
            initiativeUpDown.Minimum = -1000;
            // textbox.Text = initiativeUpDown.Name; // Checks name of numeric up down
            initiativePanel.Controls.Add(initiativeUpDown);

            NumericUpDown naturaUpDown = new NumericUpDown();
            naturaUpDown.Location = new Point(3, 25 * itemCount);
            naturaUpDown.Size = new Size(35, 20);
            naturaUpDown.Name = "naturaUpDown_" + (itemCount + 1);
            naturaUpDown.Maximum = 20;
            // textbox.Text = numericUpDown.Name; // Checks name of numeric up down
            naturaPanel.Controls.Add(naturaUpDown);
        }

        private void rollinitiative_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            int x = 0;

            List<InitiativeStruct> initData = new List<InitiativeStruct>();

            string[,] initiativeData = new string[25, 3];

            foreach (Control init in initiativePanel.Controls)
            {
                NumericUpDown initUpDown = (NumericUpDown)init;
                if (initUpDown.Text == "")
                {
                    MessageBox.Show("Please enter a base initiative for all characters");
                    return;
                }
                initiativeData[x, 1] = initUpDown.Text;
                x++;
            }

            x = 0;

            foreach (Control charName in namePanel.Controls)
            {
                TextBox name = (TextBox)charName;
                if (name.Text == "")
                {
                    MessageBox.Show("Please enter a name for all characters");
                    return;
                }
                initiativeData[x, 0] = name.Text;
                x++;
            }

            x = 0;

            foreach (Control natmod in naturaPanel.Controls)
            {
                NumericUpDown natura = (NumericUpDown)natmod;
                if (natura.Text == "")
                {
                    MessageBox.Show("Please enter a natura for all characters");
                    return;
                }
                initiativeData[x, 2] = natura.Text;
                x++;
            }

            for (x = 0; x < namePanel.Controls.Count; x++)
            {
                initData.Add(new InitiativeStruct(initiativeData[x, 0], Convert.ToInt32(initiativeData[x, 1]), Convert.ToInt32(initiativeData[x, 2])));
            }

            AnimaCombatLibrary.Combat.InitiativeRoll(ref initData);

            x = 0;

            foreach (Control init in initiativePanel.Controls)
            {
                NumericUpDown initUpDown = (NumericUpDown)init;
                initUpDown.Text = Convert.ToString(initData[x].baseInitiative);
                x++;
            }

            x = 0;

            foreach (Control charName in namePanel.Controls)
            {
                TextBox name = (TextBox)charName;
                name.Text = initData[x].charName;
                x++;
            }

            x = 0;

            foreach (Control natmod in naturaPanel.Controls)
            {
                NumericUpDown natura = (NumericUpDown)natmod;
                natura.Text = Convert.ToString(initData[x].naturaModifier);
                x++;
            }

            x = 0;

            foreach (Control natmod in rolledInitiativePanel.Controls)
            {
                Label rolledInit = (Label)natmod;
                rolledInit.Text = Convert.ToString(initData[x].rolledInitiative);
                x++;
            }

        }
    }
}
