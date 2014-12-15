namespace Anima_Combat
{
    partial class Main
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
            this.Title = new System.Windows.Forms.Label();
            this.newChar = new System.Windows.Forms.Button();
            this.combat = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.updateChar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(51, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(182, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Game Master Assistant V 0.0.1 Alpha";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newChar
            // 
            this.newChar.Location = new System.Drawing.Point(83, 35);
            this.newChar.Name = "newChar";
            this.newChar.Size = new System.Drawing.Size(117, 23);
            this.newChar.TabIndex = 1;
            this.newChar.Text = "Add Character";
            this.newChar.UseVisualStyleBackColor = true;
            this.newChar.Click += new System.EventHandler(this.newChar_Click);
            // 
            // combat
            // 
            this.combat.Location = new System.Drawing.Point(102, 94);
            this.combat.Name = "combat";
            this.combat.Size = new System.Drawing.Size(75, 23);
            this.combat.TabIndex = 2;
            this.combat.Text = "Combat";
            this.combat.UseVisualStyleBackColor = true;
            this.combat.Click += new System.EventHandler(this.combat_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(114, 123);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // updateChar
            // 
            this.updateChar.Location = new System.Drawing.Point(83, 64);
            this.updateChar.Name = "updateChar";
            this.updateChar.Size = new System.Drawing.Size(117, 23);
            this.updateChar.TabIndex = 4;
            this.updateChar.Text = "Update Character";
            this.updateChar.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.updateChar);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.combat);
            this.Controls.Add(this.newChar);
            this.Controls.Add(this.Title);
            this.Name = "Main";
            this.Text = "GameMasterAssistant(Anima)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button newChar;
        private System.Windows.Forms.Button combat;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button updateChar;
    }
}

