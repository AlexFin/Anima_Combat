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
            TextBox textbox = new TextBox();
            textbox.Location = new System.Drawing.Point(3, 25 * namePanel.Controls.Count);
            textbox.Size = new System.Drawing.Size(110, 20);
            textbox.Name = "textbox_" + (namePanel.Controls.Count + 1 );
            // textbox.Text = textbox.Name; // Checks name of textbox
            namePanel.Controls.Add(textbox);

            Label label = new Label();
            label.Location = new Point(3, 25 * rolledInitiativePanel.Controls.Count);
            label.Name = "rolledInitiative_" + (rolledInitiativePanel.Controls.Count + 1);
            label.Text = "0";
            rolledInitiativePanel.Controls.Add(label);

            NumericUpDown initiativeUpDown = new NumericUpDown();
            initiativeUpDown.Location = new Point(3, 25 * initiativePanel.Controls.Count);
            initiativeUpDown.Size = new Size(50, 20);
            initiativeUpDown.Name = "initiativeUpDown_" + (initiativePanel.Controls.Count + 1);
            initiativeUpDown.Maximum = 10000;
            // textbox.Text = initiativeUpDown.Name; // Checks name of numeric up down
            initiativePanel.Controls.Add(initiativeUpDown);

            NumericUpDown naturaUpDown = new NumericUpDown();
            naturaUpDown.Location = new Point(3, 25 * naturaPanel.Controls.Count);
            naturaUpDown.Size = new Size(35, 20);
            naturaUpDown.Name = "naturaUpDown_" + (naturaPanel.Controls.Count + 1);
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
                initiativeData[x, 1] = initUpDown.Text;
                x++;
            }

            x = 0;

            foreach (Control charName in namePanel.Controls)
            {
                TextBox name = (TextBox)charName;
                initiativeData[x, 0] = name.Text;
                x++;
            }

            x = 0;

            foreach (Control natmod in naturaPanel.Controls)
            {
                NumericUpDown natura = (NumericUpDown)natmod;
                initiativeData[x, 2] = natura.Text;
                x++;
            }

            for (x = 0; x < namePanel.Controls.Count; x++)
            {
                initData.Add(new InitiativeStruct(initiativeData[x, 0], Convert.ToInt32(initiativeData[x, 1]), Convert.ToInt32(initiativeData[x, 2])));
            }
        }

        public struct InitiativeStruct
        {
            string charName;
            int baseInitiative;
            int naturaModifier;
            int rolledInitiative;

            public InitiativeStruct(string assignName, int baseInit, int naturaMod, int rolledInit = 0 )
            {
                charName = assignName;
                baseInitiative = baseInit;
                naturaModifier = naturaMod;
                rolledInitiative = rolledInit;
            }
        }
    }
}
