namespace Anima_Combat
{
    partial class combatForm
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
            this.exit = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Button();
            this.addCombatant = new System.Windows.Forms.Button();
            this.namePanel = new System.Windows.Forms.Panel();
            this.initiativePanel = new System.Windows.Forms.Panel();
            this.naturaPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rollinitiative = new System.Windows.Forms.Button();
            this.rolledInitiativePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(847, 604);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(766, 604);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(75, 23);
            this.main.TabIndex = 1;
            this.main.Text = "Menu";
            this.main.UseVisualStyleBackColor = true;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // addCombatant
            // 
            this.addCombatant.Location = new System.Drawing.Point(12, 604);
            this.addCombatant.Name = "addCombatant";
            this.addCombatant.Size = new System.Drawing.Size(92, 23);
            this.addCombatant.TabIndex = 0;
            this.addCombatant.Text = "Add Combatant";
            this.addCombatant.UseVisualStyleBackColor = true;
            this.addCombatant.Click += new System.EventHandler(this.addCombatant_Click);
            // 
            // namePanel
            // 
            this.namePanel.Location = new System.Drawing.Point(12, 26);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(126, 577);
            this.namePanel.TabIndex = 3;
            // 
            // initiativePanel
            // 
            this.initiativePanel.Location = new System.Drawing.Point(195, 26);
            this.initiativePanel.Name = "initiativePanel";
            this.initiativePanel.Size = new System.Drawing.Size(51, 580);
            this.initiativePanel.TabIndex = 4;
            // 
            // naturaPanel
            // 
            this.naturaPanel.Location = new System.Drawing.Point(252, 26);
            this.naturaPanel.Name = "naturaPanel";
            this.naturaPanel.Size = new System.Drawing.Size(46, 580);
            this.naturaPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Character name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Initiative";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Natura";
            // 
            // rollinitiative
            // 
            this.rollinitiative.Location = new System.Drawing.Point(144, 604);
            this.rollinitiative.Name = "rollinitiative";
            this.rollinitiative.Size = new System.Drawing.Size(75, 23);
            this.rollinitiative.TabIndex = 9;
            this.rollinitiative.Text = "Roll Initiative";
            this.rollinitiative.UseVisualStyleBackColor = true;
            this.rollinitiative.Click += new System.EventHandler(this.rollinitiative_Click);
            // 
            // rolledInitiativePanel
            // 
            this.rolledInitiativePanel.Location = new System.Drawing.Point(144, 26);
            this.rolledInitiativePanel.Name = "rolledInitiativePanel";
            this.rolledInitiativePanel.Size = new System.Drawing.Size(45, 577);
            this.rolledInitiativePanel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rolled";
            // 
            // combatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(934, 630);
            this.Controls.Add(this.addCombatant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rolledInitiativePanel);
            this.Controls.Add(this.rollinitiative);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naturaPanel);
            this.Controls.Add(this.initiativePanel);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.main);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "combatForm";
            this.Text = "combatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button main;
        private System.Windows.Forms.Button addCombatant;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Panel initiativePanel;
        private System.Windows.Forms.Panel naturaPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rollinitiative;
        private System.Windows.Forms.Panel rolledInitiativePanel;
        private System.Windows.Forms.Label label4;
    }
}