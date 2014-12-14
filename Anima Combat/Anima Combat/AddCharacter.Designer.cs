namespace Anima_Combat
{
    partial class AddCharacter
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
            this.textName = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.agiStat = new System.Windows.Forms.NumericUpDown();
            this.conStat = new System.Windows.Forms.NumericUpDown();
            this.dexStat = new System.Windows.Forms.NumericUpDown();
            this.agility = new System.Windows.Forms.Label();
            this.constitution = new System.Windows.Forms.Label();
            this.dexterity = new System.Windows.Forms.Label();
            this.strStat = new System.Windows.Forms.NumericUpDown();
            this.intStat = new System.Windows.Forms.NumericUpDown();
            this.perStat = new System.Windows.Forms.NumericUpDown();
            this.powStat = new System.Windows.Forms.NumericUpDown();
            this.wpStat = new System.Windows.Forms.NumericUpDown();
            this.Strength = new System.Windows.Forms.Label();
            this.intelligence = new System.Windows.Forms.Label();
            this.perception = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.Label();
            this.willpower = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.class1 = new System.Windows.Forms.ComboBox();
            this.class1Level = new System.Windows.Forms.NumericUpDown();
            this.class2 = new System.Windows.Forms.ComboBox();
            this.class2Level = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.agiStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wpStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1Level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2Level)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(53, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(155, 20);
            this.textName.TabIndex = 0;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(405, 608);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(486, 608);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Main Menu";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // agiStat
            // 
            this.agiStat.Location = new System.Drawing.Point(13, 39);
            this.agiStat.Name = "agiStat";
            this.agiStat.Size = new System.Drawing.Size(33, 20);
            this.agiStat.TabIndex = 3;
            this.agiStat.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // conStat
            // 
            this.conStat.Location = new System.Drawing.Point(13, 65);
            this.conStat.Name = "conStat";
            this.conStat.Size = new System.Drawing.Size(33, 20);
            this.conStat.TabIndex = 4;
            this.conStat.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dexStat
            // 
            this.dexStat.Location = new System.Drawing.Point(12, 92);
            this.dexStat.Name = "dexStat";
            this.dexStat.Size = new System.Drawing.Size(34, 20);
            this.dexStat.TabIndex = 5;
            this.dexStat.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // agility
            // 
            this.agility.AutoSize = true;
            this.agility.Location = new System.Drawing.Point(53, 45);
            this.agility.Name = "agility";
            this.agility.Size = new System.Drawing.Size(34, 13);
            this.agility.TabIndex = 6;
            this.agility.Text = "Agility";
            // 
            // constitution
            // 
            this.constitution.AutoSize = true;
            this.constitution.Location = new System.Drawing.Point(52, 72);
            this.constitution.Name = "constitution";
            this.constitution.Size = new System.Drawing.Size(62, 13);
            this.constitution.TabIndex = 7;
            this.constitution.Text = "Constitution";
            // 
            // dexterity
            // 
            this.dexterity.AutoSize = true;
            this.dexterity.Location = new System.Drawing.Point(52, 99);
            this.dexterity.Name = "dexterity";
            this.dexterity.Size = new System.Drawing.Size(48, 13);
            this.dexterity.TabIndex = 8;
            this.dexterity.Text = "Dexterity";
            // 
            // strStat
            // 
            this.strStat.Location = new System.Drawing.Point(12, 119);
            this.strStat.Name = "strStat";
            this.strStat.Size = new System.Drawing.Size(34, 20);
            this.strStat.TabIndex = 9;
            this.strStat.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // intStat
            // 
            this.intStat.Location = new System.Drawing.Point(12, 146);
            this.intStat.Name = "intStat";
            this.intStat.Size = new System.Drawing.Size(34, 20);
            this.intStat.TabIndex = 10;
            this.intStat.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // perStat
            // 
            this.perStat.Location = new System.Drawing.Point(13, 173);
            this.perStat.Name = "perStat";
            this.perStat.Size = new System.Drawing.Size(33, 20);
            this.perStat.TabIndex = 11;
            this.perStat.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // powStat
            // 
            this.powStat.Location = new System.Drawing.Point(12, 200);
            this.powStat.Name = "powStat";
            this.powStat.Size = new System.Drawing.Size(34, 20);
            this.powStat.TabIndex = 12;
            this.powStat.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // wpStat
            // 
            this.wpStat.Location = new System.Drawing.Point(13, 227);
            this.wpStat.Name = "wpStat";
            this.wpStat.Size = new System.Drawing.Size(33, 20);
            this.wpStat.TabIndex = 13;
            this.wpStat.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Strength
            // 
            this.Strength.AutoSize = true;
            this.Strength.Location = new System.Drawing.Point(53, 125);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(47, 13);
            this.Strength.TabIndex = 14;
            this.Strength.Text = "Strength";
            // 
            // intelligence
            // 
            this.intelligence.AutoSize = true;
            this.intelligence.Location = new System.Drawing.Point(53, 152);
            this.intelligence.Name = "intelligence";
            this.intelligence.Size = new System.Drawing.Size(61, 13);
            this.intelligence.TabIndex = 15;
            this.intelligence.Text = "Intelligence";
            // 
            // perception
            // 
            this.perception.AutoSize = true;
            this.perception.Location = new System.Drawing.Point(53, 179);
            this.perception.Name = "perception";
            this.perception.Size = new System.Drawing.Size(58, 13);
            this.perception.TabIndex = 16;
            this.perception.Text = "Perception";
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.Location = new System.Drawing.Point(53, 206);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(37, 13);
            this.power.TabIndex = 17;
            this.power.Text = "Power";
            // 
            // willpower
            // 
            this.willpower.AutoSize = true;
            this.willpower.Location = new System.Drawing.Point(53, 233);
            this.willpower.Name = "willpower";
            this.willpower.Size = new System.Drawing.Size(53, 13);
            this.willpower.TabIndex = 18;
            this.willpower.Text = "Willpower";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name";
            // 
            // class1
            // 
            this.class1.FormattingEnabled = true;
            this.class1.Location = new System.Drawing.Point(214, 11);
            this.class1.MaxDropDownItems = 20;
            this.class1.Name = "class1";
            this.class1.Size = new System.Drawing.Size(121, 21);
            this.class1.TabIndex = 20;
            this.class1.Text = "Main Class";
            // 
            // class1Level
            // 
            this.class1Level.Location = new System.Drawing.Point(341, 11);
            this.class1Level.Name = "class1Level";
            this.class1Level.Size = new System.Drawing.Size(33, 20);
            this.class1Level.TabIndex = 21;
            // 
            // class2
            // 
            this.class2.FormattingEnabled = true;
            this.class2.Location = new System.Drawing.Point(214, 39);
            this.class2.Name = "class2";
            this.class2.Size = new System.Drawing.Size(121, 21);
            this.class2.TabIndex = 22;
            this.class2.Text = "Multi Class 1";
            // 
            // class2Level
            // 
            this.class2Level.Location = new System.Drawing.Point(341, 39);
            this.class2Level.Name = "class2Level";
            this.class2Level.Size = new System.Drawing.Size(33, 20);
            this.class2Level.TabIndex = 23;
            // 
            // AddCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 643);
            this.Controls.Add(this.class2Level);
            this.Controls.Add(this.class2);
            this.Controls.Add(this.class1Level);
            this.Controls.Add(this.class1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.willpower);
            this.Controls.Add(this.power);
            this.Controls.Add(this.perception);
            this.Controls.Add(this.intelligence);
            this.Controls.Add(this.Strength);
            this.Controls.Add(this.wpStat);
            this.Controls.Add(this.powStat);
            this.Controls.Add(this.perStat);
            this.Controls.Add(this.intStat);
            this.Controls.Add(this.strStat);
            this.Controls.Add(this.dexterity);
            this.Controls.Add(this.constitution);
            this.Controls.Add(this.agility);
            this.Controls.Add(this.dexStat);
            this.Controls.Add(this.conStat);
            this.Controls.Add(this.agiStat);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textName);
            this.Name = "AddCharacter";
            this.Text = "AddCharacter";
            ((System.ComponentModel.ISupportInitialize)(this.agiStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wpStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1Level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2Level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.NumericUpDown agiStat;
        private System.Windows.Forms.NumericUpDown conStat;
        private System.Windows.Forms.NumericUpDown dexStat;
        private System.Windows.Forms.Label agility;
        private System.Windows.Forms.Label constitution;
        private System.Windows.Forms.Label dexterity;
        private System.Windows.Forms.NumericUpDown strStat;
        private System.Windows.Forms.NumericUpDown intStat;
        private System.Windows.Forms.NumericUpDown perStat;
        private System.Windows.Forms.NumericUpDown powStat;
        private System.Windows.Forms.NumericUpDown wpStat;
        private System.Windows.Forms.Label Strength;
        private System.Windows.Forms.Label intelligence;
        private System.Windows.Forms.Label perception;
        private System.Windows.Forms.Label power;
        private System.Windows.Forms.Label willpower;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox class1;
        private System.Windows.Forms.NumericUpDown class1Level;
        private System.Windows.Forms.ComboBox class2;
        private System.Windows.Forms.NumericUpDown class2Level;
    }
}