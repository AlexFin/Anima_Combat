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
            this.playerCheckBox = new System.Windows.Forms.CheckBox();
            this.statPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.initiativeAmount = new System.Windows.Forms.TextBox();
            this.initiativeLabel = new System.Windows.Forms.Label();
            this.maxFatigueAmount = new System.Windows.Forms.TextBox();
            this.maxLpAmount = new System.Windows.Forms.TextBox();
            this.maxLifeLabel = new System.Windows.Forms.Label();
            this.maxFatigueLabel = new System.Windows.Forms.Label();
            this.naturaLabel = new System.Windows.Forms.Label();
            this.naturaUpDown = new System.Windows.Forms.NumericUpDown();
            this.levelLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.levelUpDown = new System.Windows.Forms.NumericUpDown();
            this.primarySkillsPanel = new System.Windows.Forms.Panel();
            this.dodgeAmount = new System.Windows.Forms.TextBox();
            this.blockAmount = new System.Windows.Forms.TextBox();
            this.attackAmount = new System.Windows.Forms.TextBox();
            this.dodgeLabel = new System.Windows.Forms.Label();
            this.blockLabel = new System.Windows.Forms.Label();
            this.attackLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resistLabel = new System.Windows.Forms.Label();
            this.physicalResistLabel = new System.Windows.Forms.Label();
            this.diseaseResistLabel = new System.Windows.Forms.Label();
            this.poisonResistLabel = new System.Windows.Forms.Label();
            this.magicResistLabel = new System.Windows.Forms.Label();
            this.psyResistLabel = new System.Windows.Forms.Label();
            this.resistTotalLabel = new System.Windows.Forms.Label();
            this.physicalResistAmount = new System.Windows.Forms.TextBox();
            this.diseaseResistAmount = new System.Windows.Forms.TextBox();
            this.poisonResistAmount = new System.Windows.Forms.TextBox();
            this.magicResistAmount = new System.Windows.Forms.TextBox();
            this.psychicResistAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.agiStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wpStat)).BeginInit();
            this.statPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naturaUpDown)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelUpDown)).BeginInit();
            this.primarySkillsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(35, 1);
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
            this.agiStat.Location = new System.Drawing.Point(4, 3);
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
            this.conStat.Location = new System.Drawing.Point(3, 29);
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
            this.dexStat.Location = new System.Drawing.Point(2, 55);
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
            this.agility.Location = new System.Drawing.Point(38, 5);
            this.agility.Name = "agility";
            this.agility.Size = new System.Drawing.Size(34, 13);
            this.agility.TabIndex = 6;
            this.agility.Text = "Agility";
            // 
            // constitution
            // 
            this.constitution.AutoSize = true;
            this.constitution.Location = new System.Drawing.Point(38, 31);
            this.constitution.Name = "constitution";
            this.constitution.Size = new System.Drawing.Size(62, 13);
            this.constitution.TabIndex = 7;
            this.constitution.Text = "Constitution";
            // 
            // dexterity
            // 
            this.dexterity.AutoSize = true;
            this.dexterity.Location = new System.Drawing.Point(38, 57);
            this.dexterity.Name = "dexterity";
            this.dexterity.Size = new System.Drawing.Size(48, 13);
            this.dexterity.TabIndex = 8;
            this.dexterity.Text = "Dexterity";
            // 
            // strStat
            // 
            this.strStat.Location = new System.Drawing.Point(2, 81);
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
            this.intStat.Location = new System.Drawing.Point(2, 107);
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
            this.perStat.Location = new System.Drawing.Point(3, 133);
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
            this.powStat.Location = new System.Drawing.Point(2, 159);
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
            this.wpStat.Location = new System.Drawing.Point(4, 185);
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
            this.Strength.Location = new System.Drawing.Point(38, 83);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(47, 13);
            this.Strength.TabIndex = 14;
            this.Strength.Text = "Strength";
            // 
            // intelligence
            // 
            this.intelligence.AutoSize = true;
            this.intelligence.Location = new System.Drawing.Point(39, 109);
            this.intelligence.Name = "intelligence";
            this.intelligence.Size = new System.Drawing.Size(61, 13);
            this.intelligence.TabIndex = 15;
            this.intelligence.Text = "Intelligence";
            // 
            // perception
            // 
            this.perception.AutoSize = true;
            this.perception.Location = new System.Drawing.Point(38, 135);
            this.perception.Name = "perception";
            this.perception.Size = new System.Drawing.Size(58, 13);
            this.perception.TabIndex = 16;
            this.perception.Text = "Perception";
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.Location = new System.Drawing.Point(38, 161);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(37, 13);
            this.power.TabIndex = 17;
            this.power.Text = "Power";
            // 
            // willpower
            // 
            this.willpower.AutoSize = true;
            this.willpower.Location = new System.Drawing.Point(38, 187);
            this.willpower.Name = "willpower";
            this.willpower.Size = new System.Drawing.Size(53, 13);
            this.willpower.TabIndex = 18;
            this.willpower.Text = "Willpower";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 4);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name";
            // 
            // playerCheckBox
            // 
            this.playerCheckBox.AutoSize = true;
            this.playerCheckBox.Location = new System.Drawing.Point(84, 26);
            this.playerCheckBox.Name = "playerCheckBox";
            this.playerCheckBox.Size = new System.Drawing.Size(61, 17);
            this.playerCheckBox.TabIndex = 24;
            this.playerCheckBox.Text = "Player?";
            this.playerCheckBox.UseVisualStyleBackColor = true;
            // 
            // statPanel
            // 
            this.statPanel.Controls.Add(this.agiStat);
            this.statPanel.Controls.Add(this.conStat);
            this.statPanel.Controls.Add(this.dexStat);
            this.statPanel.Controls.Add(this.strStat);
            this.statPanel.Controls.Add(this.intStat);
            this.statPanel.Controls.Add(this.perStat);
            this.statPanel.Controls.Add(this.powStat);
            this.statPanel.Controls.Add(this.willpower);
            this.statPanel.Controls.Add(this.wpStat);
            this.statPanel.Controls.Add(this.power);
            this.statPanel.Controls.Add(this.agility);
            this.statPanel.Controls.Add(this.perception);
            this.statPanel.Controls.Add(this.constitution);
            this.statPanel.Controls.Add(this.intelligence);
            this.statPanel.Controls.Add(this.dexterity);
            this.statPanel.Controls.Add(this.Strength);
            this.statPanel.Location = new System.Drawing.Point(12, 60);
            this.statPanel.Name = "statPanel";
            this.statPanel.Size = new System.Drawing.Size(103, 214);
            this.statPanel.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.initiativeAmount);
            this.panel2.Controls.Add(this.initiativeLabel);
            this.panel2.Controls.Add(this.maxFatigueAmount);
            this.panel2.Controls.Add(this.maxLpAmount);
            this.panel2.Controls.Add(this.maxLifeLabel);
            this.panel2.Controls.Add(this.maxFatigueLabel);
            this.panel2.Location = new System.Drawing.Point(123, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 75);
            this.panel2.TabIndex = 26;
            // 
            // initiativeAmount
            // 
            this.initiativeAmount.Location = new System.Drawing.Point(86, 50);
            this.initiativeAmount.Name = "initiativeAmount";
            this.initiativeAmount.Size = new System.Drawing.Size(36, 20);
            this.initiativeAmount.TabIndex = 5;
            this.initiativeAmount.Text = "0";
            // 
            // initiativeLabel
            // 
            this.initiativeLabel.AutoSize = true;
            this.initiativeLabel.Location = new System.Drawing.Point(1, 53);
            this.initiativeLabel.Name = "initiativeLabel";
            this.initiativeLabel.Size = new System.Drawing.Size(73, 13);
            this.initiativeLabel.TabIndex = 4;
            this.initiativeLabel.Text = "Total Initiative";
            // 
            // maxFatigueAmount
            // 
            this.maxFatigueAmount.Location = new System.Drawing.Point(86, 28);
            this.maxFatigueAmount.Name = "maxFatigueAmount";
            this.maxFatigueAmount.Size = new System.Drawing.Size(36, 20);
            this.maxFatigueAmount.TabIndex = 3;
            // 
            // maxLpAmount
            // 
            this.maxLpAmount.Location = new System.Drawing.Point(86, 6);
            this.maxLpAmount.Name = "maxLpAmount";
            this.maxLpAmount.Size = new System.Drawing.Size(36, 20);
            this.maxLpAmount.TabIndex = 2;
            // 
            // maxLifeLabel
            // 
            this.maxLifeLabel.AutoSize = true;
            this.maxLifeLabel.Location = new System.Drawing.Point(1, 9);
            this.maxLifeLabel.Name = "maxLifeLabel";
            this.maxLifeLabel.Size = new System.Drawing.Size(79, 13);
            this.maxLifeLabel.TabIndex = 1;
            this.maxLifeLabel.Text = "Max Life Points";
            // 
            // maxFatigueLabel
            // 
            this.maxFatigueLabel.AutoSize = true;
            this.maxFatigueLabel.Location = new System.Drawing.Point(1, 31);
            this.maxFatigueLabel.Name = "maxFatigueLabel";
            this.maxFatigueLabel.Size = new System.Drawing.Size(65, 13);
            this.maxFatigueLabel.TabIndex = 0;
            this.maxFatigueLabel.Text = "Max Fatigue";
            // 
            // naturaLabel
            // 
            this.naturaLabel.AutoSize = true;
            this.naturaLabel.Location = new System.Drawing.Point(151, 27);
            this.naturaLabel.Name = "naturaLabel";
            this.naturaLabel.Size = new System.Drawing.Size(39, 13);
            this.naturaLabel.TabIndex = 2;
            this.naturaLabel.Text = "Natura";
            // 
            // naturaUpDown
            // 
            this.naturaUpDown.Location = new System.Drawing.Point(199, 25);
            this.naturaUpDown.Name = "naturaUpDown";
            this.naturaUpDown.Size = new System.Drawing.Size(35, 20);
            this.naturaUpDown.TabIndex = 27;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(2, 27);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(33, 13);
            this.levelLabel.TabIndex = 28;
            this.levelLabel.Text = "Level";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.levelUpDown);
            this.mainPanel.Controls.Add(this.naturaUpDown);
            this.mainPanel.Controls.Add(this.levelLabel);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Controls.Add(this.naturaLabel);
            this.mainPanel.Controls.Add(this.textName);
            this.mainPanel.Controls.Add(this.playerCheckBox);
            this.mainPanel.Location = new System.Drawing.Point(14, 9);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(237, 45);
            this.mainPanel.TabIndex = 29;
            // 
            // levelUpDown
            // 
            this.levelUpDown.Location = new System.Drawing.Point(41, 25);
            this.levelUpDown.Name = "levelUpDown";
            this.levelUpDown.Size = new System.Drawing.Size(37, 20);
            this.levelUpDown.TabIndex = 29;
            // 
            // primarySkillsPanel
            // 
            this.primarySkillsPanel.Controls.Add(this.dodgeAmount);
            this.primarySkillsPanel.Controls.Add(this.blockAmount);
            this.primarySkillsPanel.Controls.Add(this.attackAmount);
            this.primarySkillsPanel.Controls.Add(this.dodgeLabel);
            this.primarySkillsPanel.Controls.Add(this.blockLabel);
            this.primarySkillsPanel.Controls.Add(this.attackLabel);
            this.primarySkillsPanel.Location = new System.Drawing.Point(123, 141);
            this.primarySkillsPanel.Name = "primarySkillsPanel";
            this.primarySkillsPanel.Size = new System.Drawing.Size(89, 56);
            this.primarySkillsPanel.TabIndex = 30;
            // 
            // dodgeAmount
            // 
            this.dodgeAmount.Location = new System.Drawing.Point(49, 35);
            this.dodgeAmount.Name = "dodgeAmount";
            this.dodgeAmount.Size = new System.Drawing.Size(35, 20);
            this.dodgeAmount.TabIndex = 5;
            this.dodgeAmount.Text = "0";
            // 
            // blockAmount
            // 
            this.blockAmount.Location = new System.Drawing.Point(49, 18);
            this.blockAmount.Name = "blockAmount";
            this.blockAmount.Size = new System.Drawing.Size(35, 20);
            this.blockAmount.TabIndex = 4;
            this.blockAmount.Text = "0";
            // 
            // attackAmount
            // 
            this.attackAmount.Location = new System.Drawing.Point(49, 1);
            this.attackAmount.Name = "attackAmount";
            this.attackAmount.Size = new System.Drawing.Size(35, 20);
            this.attackAmount.TabIndex = 3;
            this.attackAmount.Text = "0";
            // 
            // dodgeLabel
            // 
            this.dodgeLabel.AutoSize = true;
            this.dodgeLabel.Location = new System.Drawing.Point(4, 38);
            this.dodgeLabel.Name = "dodgeLabel";
            this.dodgeLabel.Size = new System.Drawing.Size(39, 13);
            this.dodgeLabel.TabIndex = 2;
            this.dodgeLabel.Text = "Dodge";
            // 
            // blockLabel
            // 
            this.blockLabel.AutoSize = true;
            this.blockLabel.Location = new System.Drawing.Point(4, 21);
            this.blockLabel.Name = "blockLabel";
            this.blockLabel.Size = new System.Drawing.Size(34, 13);
            this.blockLabel.TabIndex = 1;
            this.blockLabel.Text = "Block";
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Location = new System.Drawing.Point(4, 4);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(38, 13);
            this.attackLabel.TabIndex = 0;
            this.attackLabel.Text = "Attack";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.psychicResistAmount);
            this.panel1.Controls.Add(this.magicResistAmount);
            this.panel1.Controls.Add(this.poisonResistAmount);
            this.panel1.Controls.Add(this.diseaseResistAmount);
            this.panel1.Controls.Add(this.physicalResistAmount);
            this.panel1.Controls.Add(this.resistTotalLabel);
            this.panel1.Controls.Add(this.psyResistLabel);
            this.panel1.Controls.Add(this.magicResistLabel);
            this.panel1.Controls.Add(this.poisonResistLabel);
            this.panel1.Controls.Add(this.diseaseResistLabel);
            this.panel1.Controls.Add(this.physicalResistLabel);
            this.panel1.Controls.Add(this.resistLabel);
            this.panel1.Location = new System.Drawing.Point(257, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 129);
            this.panel1.TabIndex = 31;
            // 
            // resistLabel
            // 
            this.resistLabel.AutoSize = true;
            this.resistLabel.Location = new System.Drawing.Point(3, 0);
            this.resistLabel.Name = "resistLabel";
            this.resistLabel.Size = new System.Drawing.Size(60, 13);
            this.resistLabel.TabIndex = 0;
            this.resistLabel.Text = "Resistance";
            // 
            // physicalResistLabel
            // 
            this.physicalResistLabel.AutoSize = true;
            this.physicalResistLabel.Location = new System.Drawing.Point(3, 13);
            this.physicalResistLabel.Name = "physicalResistLabel";
            this.physicalResistLabel.Size = new System.Drawing.Size(46, 13);
            this.physicalResistLabel.TabIndex = 1;
            this.physicalResistLabel.Text = "Physical";
            // 
            // diseaseResistLabel
            // 
            this.diseaseResistLabel.AutoSize = true;
            this.diseaseResistLabel.Location = new System.Drawing.Point(3, 35);
            this.diseaseResistLabel.Name = "diseaseResistLabel";
            this.diseaseResistLabel.Size = new System.Drawing.Size(45, 13);
            this.diseaseResistLabel.TabIndex = 2;
            this.diseaseResistLabel.Text = "Disease";
            // 
            // poisonResistLabel
            // 
            this.poisonResistLabel.AutoSize = true;
            this.poisonResistLabel.Location = new System.Drawing.Point(3, 57);
            this.poisonResistLabel.Name = "poisonResistLabel";
            this.poisonResistLabel.Size = new System.Drawing.Size(39, 13);
            this.poisonResistLabel.TabIndex = 3;
            this.poisonResistLabel.Text = "Poison";
            // 
            // magicResistLabel
            // 
            this.magicResistLabel.AutoSize = true;
            this.magicResistLabel.Location = new System.Drawing.Point(3, 80);
            this.magicResistLabel.Name = "magicResistLabel";
            this.magicResistLabel.Size = new System.Drawing.Size(36, 13);
            this.magicResistLabel.TabIndex = 4;
            this.magicResistLabel.Text = "Magic";
            // 
            // psyResistLabel
            // 
            this.psyResistLabel.AutoSize = true;
            this.psyResistLabel.Location = new System.Drawing.Point(3, 104);
            this.psyResistLabel.Name = "psyResistLabel";
            this.psyResistLabel.Size = new System.Drawing.Size(44, 13);
            this.psyResistLabel.TabIndex = 5;
            this.psyResistLabel.Text = "Psychic";
            // 
            // resistTotalLabel
            // 
            this.resistTotalLabel.AutoSize = true;
            this.resistTotalLabel.Location = new System.Drawing.Point(86, 0);
            this.resistTotalLabel.Name = "resistTotalLabel";
            this.resistTotalLabel.Size = new System.Drawing.Size(31, 13);
            this.resistTotalLabel.TabIndex = 6;
            this.resistTotalLabel.Text = "Total";
            // 
            // physicalResistAmount
            // 
            this.physicalResistAmount.Location = new System.Drawing.Point(79, 13);
            this.physicalResistAmount.Name = "physicalResistAmount";
            this.physicalResistAmount.Size = new System.Drawing.Size(38, 20);
            this.physicalResistAmount.TabIndex = 7;
            // 
            // diseaseResistAmount
            // 
            this.diseaseResistAmount.Location = new System.Drawing.Point(79, 35);
            this.diseaseResistAmount.Name = "diseaseResistAmount";
            this.diseaseResistAmount.Size = new System.Drawing.Size(38, 20);
            this.diseaseResistAmount.TabIndex = 8;
            // 
            // poisonResistAmount
            // 
            this.poisonResistAmount.Location = new System.Drawing.Point(79, 57);
            this.poisonResistAmount.Name = "poisonResistAmount";
            this.poisonResistAmount.Size = new System.Drawing.Size(38, 20);
            this.poisonResistAmount.TabIndex = 9;
            // 
            // magicResistAmount
            // 
            this.magicResistAmount.Location = new System.Drawing.Point(79, 80);
            this.magicResistAmount.Name = "magicResistAmount";
            this.magicResistAmount.Size = new System.Drawing.Size(38, 20);
            this.magicResistAmount.TabIndex = 10;
            // 
            // psychicResistAmount
            // 
            this.psychicResistAmount.Location = new System.Drawing.Point(79, 104);
            this.psychicResistAmount.Name = "psychicResistAmount";
            this.psychicResistAmount.Size = new System.Drawing.Size(38, 20);
            this.psychicResistAmount.TabIndex = 11;
            // 
            // AddCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.primarySkillsPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statPanel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
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
            this.statPanel.ResumeLayout(false);
            this.statPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naturaUpDown)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelUpDown)).EndInit();
            this.primarySkillsPanel.ResumeLayout(false);
            this.primarySkillsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox playerCheckBox;
        private System.Windows.Forms.Panel statPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox initiativeAmount;
        private System.Windows.Forms.Label initiativeLabel;
        private System.Windows.Forms.TextBox maxFatigueAmount;
        private System.Windows.Forms.TextBox maxLpAmount;
        private System.Windows.Forms.Label maxLifeLabel;
        private System.Windows.Forms.Label maxFatigueLabel;
        private System.Windows.Forms.Label naturaLabel;
        private System.Windows.Forms.NumericUpDown naturaUpDown;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.NumericUpDown levelUpDown;
        private System.Windows.Forms.Panel primarySkillsPanel;
        private System.Windows.Forms.TextBox dodgeAmount;
        private System.Windows.Forms.TextBox blockAmount;
        private System.Windows.Forms.TextBox attackAmount;
        private System.Windows.Forms.Label dodgeLabel;
        private System.Windows.Forms.Label blockLabel;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resistTotalLabel;
        private System.Windows.Forms.Label psyResistLabel;
        private System.Windows.Forms.Label magicResistLabel;
        private System.Windows.Forms.Label poisonResistLabel;
        private System.Windows.Forms.Label diseaseResistLabel;
        private System.Windows.Forms.Label physicalResistLabel;
        private System.Windows.Forms.Label resistLabel;
        private System.Windows.Forms.TextBox psychicResistAmount;
        private System.Windows.Forms.TextBox magicResistAmount;
        private System.Windows.Forms.TextBox poisonResistAmount;
        private System.Windows.Forms.TextBox diseaseResistAmount;
        private System.Windows.Forms.TextBox physicalResistAmount;
    }
}