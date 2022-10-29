
namespace ROAViewer
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMobs = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgDataFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tctlMain = new System.Windows.Forms.TabControl();
            this.tabWeapons = new System.Windows.Forms.TabPage();
            this.splitItems = new System.Windows.Forms.SplitContainer();
            this.splitWeapons = new System.Windows.Forms.SplitContainer();
            this.cboCurWeapon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWeapons = new System.Windows.Forms.DataGridView();
            this.wType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wHit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDmgType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wProps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitArmor = new System.Windows.Forms.SplitContainer();
            this.cboCurArmor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArmor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvArmor = new System.Windows.Forms.DataGridView();
            this.aType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDmgType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aEffect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRdc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSpells = new System.Windows.Forms.TabPage();
            this.splitSpells = new System.Windows.Forms.SplitContainer();
            this.splitSpell = new System.Windows.Forms.SplitContainer();
            this.txtSpell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSpells = new System.Windows.Forms.DataGridView();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.bBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSpell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEffect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDmgType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.splitIt = new System.Windows.Forms.SplitContainer();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMonsters = new System.Windows.Forms.TabPage();
            this.splitMonsters = new System.Windows.Forms.SplitContainer();
            this.txtMonster = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMonsters = new System.Windows.Forms.DataGridView();
            this.mName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCrit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAttacks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mImmune = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTrait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPlayer = new System.Windows.Forms.TabPage();
            this.splitParty = new System.Windows.Forms.SplitContainer();
            this.btnMoveToMap = new System.Windows.Forms.Button();
            this.lblPartyLoad = new System.Windows.Forms.Label();
            this.nudLight = new System.Windows.Forms.NumericUpDown();
            this.nudStepwatch = new System.Windows.Forms.NumericUpDown();
            this.nudMapIndex = new System.Windows.Forms.NumericUpDown();
            this.nudRations = new System.Windows.Forms.NumericUpDown();
            this.btnShowMap = new System.Windows.Forms.Button();
            this.label64 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.nudMoney = new System.Windows.Forms.NumericUpDown();
            this.nudStealth = new System.Windows.Forms.NumericUpDown();
            this.label65 = new System.Windows.Forms.Label();
            this.nudSense = new System.Windows.Forms.NumericUpDown();
            this.nudYPos = new System.Windows.Forms.NumericUpDown();
            this.nudMapset = new System.Windows.Forms.NumericUpDown();
            this.label58 = new System.Windows.Forms.Label();
            this.btnSavePlayer = new System.Windows.Forms.Button();
            this.label62 = new System.Windows.Forms.Label();
            this.nudLightInt = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.nudXPos = new System.Windows.Forms.NumericUpDown();
            this.label61 = new System.Windows.Forms.Label();
            this.btnReloadPlayer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudBack9 = new System.Windows.Forms.NumericUpDown();
            this.nudBack8 = new System.Windows.Forms.NumericUpDown();
            this.nudBack7 = new System.Windows.Forms.NumericUpDown();
            this.nudBack6 = new System.Windows.Forms.NumericUpDown();
            this.nudBack5 = new System.Windows.Forms.NumericUpDown();
            this.nudBack4 = new System.Windows.Forms.NumericUpDown();
            this.nudBack3 = new System.Windows.Forms.NumericUpDown();
            this.nudBack2 = new System.Windows.Forms.NumericUpDown();
            this.nudBack1 = new System.Windows.Forms.NumericUpDown();
            this.nudBack0 = new System.Windows.Forms.NumericUpDown();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.nudExpSkill = new System.Windows.Forms.NumericUpDown();
            this.nudExpCurrent = new System.Windows.Forms.NumericUpDown();
            this.nudExpNext = new System.Windows.Forms.NumericUpDown();
            this.nudAgility = new System.Windows.Forms.NumericUpDown();
            this.nudHealth = new System.Windows.Forms.NumericUpDown();
            this.nudFatigue = new System.Windows.Forms.NumericUpDown();
            this.nudStamina = new System.Windows.Forms.NumericUpDown();
            this.nudWounds = new System.Windows.Forms.NumericUpDown();
            this.nudMoves = new System.Windows.Forms.NumericUpDown();
            this.nudActions = new System.Windows.Forms.NumericUpDown();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.nudReason = new System.Windows.Forms.NumericUpDown();
            this.nudAYellow = new System.Windows.Forms.NumericUpDown();
            this.nudMelee = new System.Windows.Forms.NumericUpDown();
            this.nudStrength = new System.Windows.Forms.NumericUpDown();
            this.nudIAmmo = new System.Windows.Forms.NumericUpDown();
            this.cboIBackpack9 = new System.Windows.Forms.ComboBox();
            this.cboIBackpack8 = new System.Windows.Forms.ComboBox();
            this.cboIBackpack7 = new System.Windows.Forms.ComboBox();
            this.cboIBackpack6 = new System.Windows.Forms.ComboBox();
            this.cboIBackpack5 = new System.Windows.Forms.ComboBox();
            this.cboIBackpack4 = new System.Windows.Forms.ComboBox();
            this.cboIBackpack3 = new System.Windows.Forms.ComboBox();
            this.cboIBackpack2 = new System.Windows.Forms.ComboBox();
            this.cboIBackpack1 = new System.Windows.Forms.ComboBox();
            this.cboIBackpack0 = new System.Windows.Forms.ComboBox();
            this.cboISpellbook = new System.Windows.Forms.ComboBox();
            this.cboITrinket = new System.Windows.Forms.ComboBox();
            this.cboIArmor = new System.Windows.Forms.ComboBox();
            this.cboIAmmo = new System.Windows.Forms.ComboBox();
            this.cboIRanged = new System.Windows.Forms.ComboBox();
            this.cboIOffhand = new System.Windows.Forms.ComboBox();
            this.cboIMain = new System.Windows.Forms.ComboBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.nudCunning = new System.Windows.Forms.NumericUpDown();
            this.nudDefense = new System.Windows.Forms.NumericUpDown();
            this.label60 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvPlayerStates = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboPlayer = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.nudAIndigo = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.nudAViolet = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.nudABlue = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.nudAOrange = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.nudAGreen = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.nudARed = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.nudGamble = new System.Windows.Forms.NumericUpDown();
            this.label43 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.nudCritical = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.nudLore = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.nudLocks = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.nudTraps = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.nudResist = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.nudRanged = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.nudSorcery = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.tabMaps = new System.Windows.Forms.TabPage();
            this.splitMaps = new System.Windows.Forms.SplitContainer();
            this.lstMaps = new System.Windows.Forms.ListBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lblSaveNotes = new System.Windows.Forms.Label();
            this.lblMapset = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveNotes = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.txtMapName = new System.Windows.Forms.TextBox();
            this.lblMapIndex = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblYPos = new System.Windows.Forms.Label();
            this.lblXPos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.splitEdge = new System.Windows.Forms.SplitContainer();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.lblEdgeMapY = new System.Windows.Forms.Label();
            this.lblEdgeMapX = new System.Windows.Forms.Label();
            this.lblEdgeMap = new System.Windows.Forms.Label();
            this.lblEdgeDir = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoType = new System.Windows.Forms.Label();
            this.pnlInfoNotes = new System.Windows.Forms.Panel();
            this.btnInfoDelete = new System.Windows.Forms.Button();
            this.txtInfoNotes = new System.Windows.Forms.TextBox();
            this.btnInfoClose = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cboInfoType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlInfoMap = new System.Windows.Forms.Panel();
            this.lblInfoMapH = new System.Windows.Forms.Label();
            this.btnInfoMap = new System.Windows.Forms.Button();
            this.lblInfoMapY = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.lblInfoMap = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.lblInfoMapX = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblInfoY = new System.Windows.Forms.Label();
            this.lblInfoX = new System.Windows.Forms.Label();
            this.tabCharsets = new System.Windows.Forms.TabPage();
            this.splitChars = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblCharIndex = new System.Windows.Forms.Label();
            this.lblCSet = new System.Windows.Forms.Label();
            this.lblCIndex = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.lstChars = new System.Windows.Forms.ListBox();
            this.picCharset = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            this.tctlMain.SuspendLayout();
            this.tabWeapons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitItems)).BeginInit();
            this.splitItems.Panel1.SuspendLayout();
            this.splitItems.Panel2.SuspendLayout();
            this.splitItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitWeapons)).BeginInit();
            this.splitWeapons.Panel1.SuspendLayout();
            this.splitWeapons.Panel2.SuspendLayout();
            this.splitWeapons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeapons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitArmor)).BeginInit();
            this.splitArmor.Panel1.SuspendLayout();
            this.splitArmor.Panel2.SuspendLayout();
            this.splitArmor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmor)).BeginInit();
            this.tabSpells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSpells)).BeginInit();
            this.splitSpells.Panel1.SuspendLayout();
            this.splitSpells.Panel2.SuspendLayout();
            this.splitSpells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSpell)).BeginInit();
            this.splitSpell.Panel1.SuspendLayout();
            this.splitSpell.Panel2.SuspendLayout();
            this.splitSpell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tabItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitIt)).BeginInit();
            this.splitIt.Panel1.SuspendLayout();
            this.splitIt.Panel2.SuspendLayout();
            this.splitIt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.tabMonsters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMonsters)).BeginInit();
            this.splitMonsters.Panel1.SuspendLayout();
            this.splitMonsters.Panel2.SuspendLayout();
            this.splitMonsters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonsters)).BeginInit();
            this.tabPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitParty)).BeginInit();
            this.splitParty.Panel1.SuspendLayout();
            this.splitParty.Panel2.SuspendLayout();
            this.splitParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepwatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLightInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFatigue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStamina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMelee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCunning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAIndigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAViolet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudABlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudARed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTraps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRanged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSorcery)).BeginInit();
            this.tabMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMaps)).BeginInit();
            this.splitMaps.Panel1.SuspendLayout();
            this.splitMaps.Panel2.SuspendLayout();
            this.splitMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitEdge)).BeginInit();
            this.splitEdge.Panel1.SuspendLayout();
            this.splitEdge.Panel2.SuspendLayout();
            this.splitEdge.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlInfoNotes.SuspendLayout();
            this.pnlInfoMap.SuspendLayout();
            this.tabCharsets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitChars)).BeginInit();
            this.splitChars.Panel1.SuspendLayout();
            this.splitChars.Panel2.SuspendLayout();
            this.splitChars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharset)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuEdit,
            this.mnuView});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(951, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataFolder,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuDataFolder
            // 
            this.mnuDataFolder.Name = "mnuDataFolder";
            this.mnuDataFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuDataFolder.Size = new System.Drawing.Size(210, 22);
            this.mnuDataFolder.Text = "RoA Data Folder...";
            this.mnuDataFolder.Click += new System.EventHandler(this.mnuDataFolder_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(210, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFind,
            this.mnuOptions});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuFind
            // 
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFind.Size = new System.Drawing.Size(186, 22);
            this.mnuFind.Text = "Find Vendor...";
            this.mnuFind.Click += new System.EventHandler(this.mnuFind_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOptions.Size = new System.Drawing.Size(186, 22);
            this.mnuOptions.Text = "Options...";
            this.mnuOptions.Click += new System.EventHandler(this.mnuOptions_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMobs});
            this.mnuView.Enabled = false;
            this.mnuView.Name = "mnuView";
            this.mnuView.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "View";
            this.mnuView.Visible = false;
            // 
            // mnuMobs
            // 
            this.mnuMobs.Name = "mnuMobs";
            this.mnuMobs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuMobs.Size = new System.Drawing.Size(179, 22);
            this.mnuMobs.Text = "Map Data...";
            this.mnuMobs.Click += new System.EventHandler(this.mnuMobs_Click);
            // 
            // dlgDataFolder
            // 
            this.dlgDataFolder.Description = "Browse for RoA Data Folder";
            // 
            // tctlMain
            // 
            this.tctlMain.Controls.Add(this.tabWeapons);
            this.tctlMain.Controls.Add(this.tabSpells);
            this.tctlMain.Controls.Add(this.tabItems);
            this.tctlMain.Controls.Add(this.tabMonsters);
            this.tctlMain.Controls.Add(this.tabPlayer);
            this.tctlMain.Controls.Add(this.tabMaps);
            this.tctlMain.Controls.Add(this.tabCharsets);
            this.tctlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctlMain.Location = new System.Drawing.Point(0, 24);
            this.tctlMain.Name = "tctlMain";
            this.tctlMain.SelectedIndex = 0;
            this.tctlMain.Size = new System.Drawing.Size(951, 774);
            this.tctlMain.TabIndex = 1;
            // 
            // tabWeapons
            // 
            this.tabWeapons.BackColor = System.Drawing.SystemColors.Control;
            this.tabWeapons.Controls.Add(this.splitItems);
            this.tabWeapons.Location = new System.Drawing.Point(4, 22);
            this.tabWeapons.Name = "tabWeapons";
            this.tabWeapons.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeapons.Size = new System.Drawing.Size(943, 748);
            this.tabWeapons.TabIndex = 0;
            this.tabWeapons.Text = "Weapons/Armor";
            // 
            // splitItems
            // 
            this.splitItems.BackColor = System.Drawing.SystemColors.Control;
            this.splitItems.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitItems.Location = new System.Drawing.Point(3, 3);
            this.splitItems.Name = "splitItems";
            // 
            // splitItems.Panel1
            // 
            this.splitItems.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitItems.Panel1.Controls.Add(this.splitWeapons);
            this.splitItems.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitItems.Panel2
            // 
            this.splitItems.Panel2.Controls.Add(this.splitArmor);
            this.splitItems.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitItems.Size = new System.Drawing.Size(937, 742);
            this.splitItems.SplitterDistance = 422;
            this.splitItems.SplitterWidth = 3;
            this.splitItems.TabIndex = 0;
            // 
            // splitWeapons
            // 
            this.splitWeapons.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitWeapons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitWeapons.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitWeapons.Location = new System.Drawing.Point(0, 0);
            this.splitWeapons.Name = "splitWeapons";
            this.splitWeapons.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitWeapons.Panel1
            // 
            this.splitWeapons.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitWeapons.Panel1.Controls.Add(this.cboCurWeapon);
            this.splitWeapons.Panel1.Controls.Add(this.label3);
            this.splitWeapons.Panel1.Controls.Add(this.txtWeapon);
            this.splitWeapons.Panel1.Controls.Add(this.label1);
            this.splitWeapons.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitWeapons.Panel2
            // 
            this.splitWeapons.Panel2.Controls.Add(this.dgvWeapons);
            this.splitWeapons.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitWeapons.Size = new System.Drawing.Size(422, 742);
            this.splitWeapons.SplitterDistance = 32;
            this.splitWeapons.SplitterWidth = 3;
            this.splitWeapons.TabIndex = 0;
            // 
            // cboCurWeapon
            // 
            this.cboCurWeapon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCurWeapon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCurWeapon.FormattingEnabled = true;
            this.cboCurWeapon.Location = new System.Drawing.Point(241, 6);
            this.cboCurWeapon.Name = "cboCurWeapon";
            this.cboCurWeapon.Size = new System.Drawing.Size(133, 21);
            this.cboCurWeapon.TabIndex = 3;
            this.cboCurWeapon.SelectedIndexChanged += new System.EventHandler(this.cboCurWeapon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current:";
            // 
            // txtWeapon
            // 
            this.txtWeapon.Location = new System.Drawing.Point(55, 6);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(133, 20);
            this.txtWeapon.TabIndex = 1;
            this.txtWeapon.TextChanged += new System.EventHandler(this.txtWeapon_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weapon:";
            // 
            // dgvWeapons
            // 
            this.dgvWeapons.AllowUserToAddRows = false;
            this.dgvWeapons.AllowUserToDeleteRows = false;
            this.dgvWeapons.AllowUserToResizeColumns = false;
            this.dgvWeapons.AllowUserToResizeRows = false;
            this.dgvWeapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeapons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wType,
            this.wName,
            this.wHit,
            this.wAct,
            this.wMin,
            this.wMax,
            this.wDmgType,
            this.wProps,
            this.wValue});
            this.dgvWeapons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWeapons.Location = new System.Drawing.Point(0, 0);
            this.dgvWeapons.MultiSelect = false;
            this.dgvWeapons.Name = "dgvWeapons";
            this.dgvWeapons.ReadOnly = true;
            this.dgvWeapons.RowHeadersVisible = false;
            this.dgvWeapons.RowTemplate.Height = 25;
            this.dgvWeapons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWeapons.ShowEditingIcon = false;
            this.dgvWeapons.Size = new System.Drawing.Size(422, 707);
            this.dgvWeapons.TabIndex = 0;
            // 
            // wType
            // 
            this.wType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wType.DataPropertyName = "TypeName";
            this.wType.Frozen = true;
            this.wType.HeaderText = "Type";
            this.wType.Name = "wType";
            this.wType.ReadOnly = true;
            this.wType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wType.Width = 37;
            // 
            // wName
            // 
            this.wName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wName.DataPropertyName = "Name";
            this.wName.Frozen = true;
            this.wName.HeaderText = "Name";
            this.wName.Name = "wName";
            this.wName.ReadOnly = true;
            this.wName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wName.Width = 41;
            // 
            // wHit
            // 
            this.wHit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wHit.DataPropertyName = "Hit";
            this.wHit.HeaderText = "Hit";
            this.wHit.Name = "wHit";
            this.wHit.ReadOnly = true;
            this.wHit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wHit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wHit.Width = 26;
            // 
            // wAct
            // 
            this.wAct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wAct.DataPropertyName = "Action";
            this.wAct.HeaderText = "Act";
            this.wAct.Name = "wAct";
            this.wAct.ReadOnly = true;
            this.wAct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wAct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wAct.Width = 29;
            // 
            // wMin
            // 
            this.wMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wMin.DataPropertyName = "MinDmg";
            this.wMin.HeaderText = "Min";
            this.wMin.Name = "wMin";
            this.wMin.ReadOnly = true;
            this.wMin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wMin.Width = 30;
            // 
            // wMax
            // 
            this.wMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wMax.DataPropertyName = "MaxDmg";
            this.wMax.HeaderText = "Max";
            this.wMax.Name = "wMax";
            this.wMax.ReadOnly = true;
            this.wMax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wMax.Width = 33;
            // 
            // wDmgType
            // 
            this.wDmgType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wDmgType.DataPropertyName = "DamageType";
            this.wDmgType.HeaderText = "DmgType";
            this.wDmgType.Name = "wDmgType";
            this.wDmgType.ReadOnly = true;
            this.wDmgType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wDmgType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wDmgType.Width = 59;
            // 
            // wProps
            // 
            this.wProps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wProps.DataPropertyName = "Props";
            this.wProps.HeaderText = "Props";
            this.wProps.Name = "wProps";
            this.wProps.ReadOnly = true;
            this.wProps.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wProps.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wProps.Width = 40;
            // 
            // wValue
            // 
            this.wValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wValue.DataPropertyName = "Value";
            this.wValue.HeaderText = "Value";
            this.wValue.Name = "wValue";
            this.wValue.ReadOnly = true;
            this.wValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wValue.Width = 40;
            // 
            // splitArmor
            // 
            this.splitArmor.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitArmor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitArmor.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitArmor.Location = new System.Drawing.Point(0, 0);
            this.splitArmor.Name = "splitArmor";
            this.splitArmor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitArmor.Panel1
            // 
            this.splitArmor.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitArmor.Panel1.Controls.Add(this.cboCurArmor);
            this.splitArmor.Panel1.Controls.Add(this.label4);
            this.splitArmor.Panel1.Controls.Add(this.txtArmor);
            this.splitArmor.Panel1.Controls.Add(this.label2);
            this.splitArmor.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitArmor.Panel2
            // 
            this.splitArmor.Panel2.Controls.Add(this.dgvArmor);
            this.splitArmor.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitArmor.Size = new System.Drawing.Size(512, 742);
            this.splitArmor.SplitterDistance = 32;
            this.splitArmor.SplitterWidth = 3;
            this.splitArmor.TabIndex = 0;
            // 
            // cboCurArmor
            // 
            this.cboCurArmor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCurArmor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCurArmor.FormattingEnabled = true;
            this.cboCurArmor.Location = new System.Drawing.Point(236, 6);
            this.cboCurArmor.Name = "cboCurArmor";
            this.cboCurArmor.Size = new System.Drawing.Size(133, 21);
            this.cboCurArmor.TabIndex = 5;
            this.cboCurArmor.SelectedIndexChanged += new System.EventHandler(this.cboCurArmor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current:";
            // 
            // txtArmor
            // 
            this.txtArmor.Location = new System.Drawing.Point(47, 6);
            this.txtArmor.Name = "txtArmor";
            this.txtArmor.Size = new System.Drawing.Size(133, 20);
            this.txtArmor.TabIndex = 3;
            this.txtArmor.TextChanged += new System.EventHandler(this.txtArmor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Armor:";
            // 
            // dgvArmor
            // 
            this.dgvArmor.AllowUserToAddRows = false;
            this.dgvArmor.AllowUserToDeleteRows = false;
            this.dgvArmor.AllowUserToResizeColumns = false;
            this.dgvArmor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArmor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aType,
            this.aName,
            this.aDmgType,
            this.aEffect,
            this.aDef,
            this.aMov,
            this.aRdc,
            this.aRst,
            this.aValue});
            this.dgvArmor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArmor.Location = new System.Drawing.Point(0, 0);
            this.dgvArmor.MultiSelect = false;
            this.dgvArmor.Name = "dgvArmor";
            this.dgvArmor.RowHeadersVisible = false;
            this.dgvArmor.RowTemplate.Height = 25;
            this.dgvArmor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArmor.Size = new System.Drawing.Size(512, 707);
            this.dgvArmor.TabIndex = 0;
            // 
            // aType
            // 
            this.aType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aType.DataPropertyName = "TypeName";
            this.aType.Frozen = true;
            this.aType.HeaderText = "Type";
            this.aType.Name = "aType";
            this.aType.ReadOnly = true;
            this.aType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aType.Width = 37;
            // 
            // aName
            // 
            this.aName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aName.DataPropertyName = "Name";
            this.aName.Frozen = true;
            this.aName.HeaderText = "Name";
            this.aName.Name = "aName";
            this.aName.ReadOnly = true;
            this.aName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aName.Width = 41;
            // 
            // aDmgType
            // 
            this.aDmgType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aDmgType.DataPropertyName = "DamageType";
            this.aDmgType.HeaderText = "DmgType";
            this.aDmgType.Name = "aDmgType";
            this.aDmgType.ReadOnly = true;
            this.aDmgType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aDmgType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aDmgType.Width = 59;
            // 
            // aEffect
            // 
            this.aEffect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aEffect.DataPropertyName = "Effect";
            this.aEffect.HeaderText = "Effect";
            this.aEffect.Name = "aEffect";
            this.aEffect.ReadOnly = true;
            this.aEffect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aEffect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aEffect.Width = 41;
            // 
            // aDef
            // 
            this.aDef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aDef.DataPropertyName = "Defense";
            this.aDef.HeaderText = "Def";
            this.aDef.Name = "aDef";
            this.aDef.ReadOnly = true;
            this.aDef.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aDef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aDef.Width = 30;
            // 
            // aMov
            // 
            this.aMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aMov.DataPropertyName = "Movement";
            this.aMov.HeaderText = "Mov";
            this.aMov.Name = "aMov";
            this.aMov.ReadOnly = true;
            this.aMov.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aMov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aMov.Width = 34;
            // 
            // aRdc
            // 
            this.aRdc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aRdc.DataPropertyName = "Reduce";
            this.aRdc.HeaderText = "Rdc";
            this.aRdc.Name = "aRdc";
            this.aRdc.ReadOnly = true;
            this.aRdc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aRdc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aRdc.Width = 33;
            // 
            // aRst
            // 
            this.aRst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aRst.DataPropertyName = "Resist";
            this.aRst.HeaderText = "Rst";
            this.aRst.Name = "aRst";
            this.aRst.ReadOnly = true;
            this.aRst.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aRst.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aRst.Width = 29;
            // 
            // aValue
            // 
            this.aValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aValue.DataPropertyName = "Value";
            this.aValue.HeaderText = "Value";
            this.aValue.Name = "aValue";
            this.aValue.ReadOnly = true;
            this.aValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aValue.Width = 40;
            // 
            // tabSpells
            // 
            this.tabSpells.BackColor = System.Drawing.SystemColors.Control;
            this.tabSpells.Controls.Add(this.splitSpells);
            this.tabSpells.Location = new System.Drawing.Point(4, 22);
            this.tabSpells.Name = "tabSpells";
            this.tabSpells.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpells.Size = new System.Drawing.Size(943, 748);
            this.tabSpells.TabIndex = 1;
            this.tabSpells.Text = "Spells";
            // 
            // splitSpells
            // 
            this.splitSpells.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitSpells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSpells.Location = new System.Drawing.Point(3, 3);
            this.splitSpells.Name = "splitSpells";
            // 
            // splitSpells.Panel1
            // 
            this.splitSpells.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitSpells.Panel1.Controls.Add(this.splitSpell);
            // 
            // splitSpells.Panel2
            // 
            this.splitSpells.Panel2.Controls.Add(this.splitContainer1);
            this.splitSpells.Size = new System.Drawing.Size(937, 742);
            this.splitSpells.SplitterDistance = 389;
            this.splitSpells.SplitterWidth = 3;
            this.splitSpells.TabIndex = 0;
            // 
            // splitSpell
            // 
            this.splitSpell.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitSpell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSpell.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitSpell.Location = new System.Drawing.Point(0, 0);
            this.splitSpell.Name = "splitSpell";
            this.splitSpell.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitSpell.Panel1
            // 
            this.splitSpell.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitSpell.Panel1.Controls.Add(this.txtSpell);
            this.splitSpell.Panel1.Controls.Add(this.label5);
            this.splitSpell.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitSpell.Panel2
            // 
            this.splitSpell.Panel2.Controls.Add(this.dgvSpells);
            this.splitSpell.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitSpell.Size = new System.Drawing.Size(389, 742);
            this.splitSpell.SplitterDistance = 32;
            this.splitSpell.SplitterWidth = 3;
            this.splitSpell.TabIndex = 0;
            // 
            // txtSpell
            // 
            this.txtSpell.Location = new System.Drawing.Point(36, 6);
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.Size = new System.Drawing.Size(133, 20);
            this.txtSpell.TabIndex = 3;
            this.txtSpell.TextChanged += new System.EventHandler(this.txtSpell_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Spell:";
            // 
            // dgvSpells
            // 
            this.dgvSpells.AllowUserToAddRows = false;
            this.dgvSpells.AllowUserToDeleteRows = false;
            this.dgvSpells.AllowUserToResizeColumns = false;
            this.dgvSpells.AllowUserToResizeRows = false;
            this.dgvSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sName,
            this.aColor,
            this.aCost,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.dgvSpells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpells.Location = new System.Drawing.Point(0, 0);
            this.dgvSpells.MultiSelect = false;
            this.dgvSpells.Name = "dgvSpells";
            this.dgvSpells.RowHeadersVisible = false;
            this.dgvSpells.RowTemplate.Height = 25;
            this.dgvSpells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpells.Size = new System.Drawing.Size(389, 707);
            this.dgvSpells.TabIndex = 0;
            this.dgvSpells.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSpells_CellPainting);
            // 
            // sName
            // 
            this.sName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sName.DataPropertyName = "Name";
            this.sName.HeaderText = "Name";
            this.sName.Name = "sName";
            this.sName.ReadOnly = true;
            this.sName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sName.Width = 41;
            // 
            // aColor
            // 
            this.aColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aColor.DataPropertyName = "Color";
            this.aColor.HeaderText = "Color";
            this.aColor.Name = "aColor";
            this.aColor.ReadOnly = true;
            this.aColor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aColor.Width = 37;
            // 
            // aCost
            // 
            this.aCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aCost.DataPropertyName = "Cost";
            this.aCost.HeaderText = "Cost";
            this.aCost.Name = "aCost";
            this.aCost.ReadOnly = true;
            this.aCost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aCost.Width = 34;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Effect";
            this.dataGridViewTextBoxColumn2.HeaderText = "Effect";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 41;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DamageType";
            this.dataGridViewTextBoxColumn1.HeaderText = "DmgType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 59;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.txtBook);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvBooks);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(545, 742);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(45, 6);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(133, 20);
            this.txtBook.TabIndex = 5;
            this.txtBook.TextChanged += new System.EventHandler(this.txtBook_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Book:";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToResizeColumns = false;
            this.dgvBooks.AllowUserToResizeRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bBook,
            this.bSpell,
            this.bColor,
            this.bCost,
            this.bEffect,
            this.bDmgType});
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.RowTemplate.Height = 25;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(545, 707);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvBooks_CellPainting);
            // 
            // bBook
            // 
            this.bBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bBook.DataPropertyName = "BookName";
            this.bBook.HeaderText = "Book";
            this.bBook.Name = "bBook";
            this.bBook.ReadOnly = true;
            this.bBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bBook.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bBook.Width = 38;
            // 
            // bSpell
            // 
            this.bSpell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bSpell.DataPropertyName = "SpellName";
            this.bSpell.HeaderText = "Spell";
            this.bSpell.Name = "bSpell";
            this.bSpell.ReadOnly = true;
            this.bSpell.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bSpell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bSpell.Width = 36;
            // 
            // bColor
            // 
            this.bColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bColor.DataPropertyName = "Color";
            this.bColor.HeaderText = "Color";
            this.bColor.Name = "bColor";
            this.bColor.ReadOnly = true;
            this.bColor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bColor.Width = 37;
            // 
            // bCost
            // 
            this.bCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bCost.DataPropertyName = "Cost";
            this.bCost.HeaderText = "Cost";
            this.bCost.Name = "bCost";
            this.bCost.ReadOnly = true;
            this.bCost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bCost.Width = 34;
            // 
            // bEffect
            // 
            this.bEffect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bEffect.DataPropertyName = "Effect";
            this.bEffect.HeaderText = "Effect";
            this.bEffect.Name = "bEffect";
            this.bEffect.ReadOnly = true;
            this.bEffect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bEffect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bEffect.Width = 41;
            // 
            // bDmgType
            // 
            this.bDmgType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bDmgType.DataPropertyName = "DamageType";
            this.bDmgType.HeaderText = "DmgType";
            this.bDmgType.Name = "bDmgType";
            this.bDmgType.ReadOnly = true;
            this.bDmgType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bDmgType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bDmgType.Width = 59;
            // 
            // tabItems
            // 
            this.tabItems.BackColor = System.Drawing.SystemColors.Control;
            this.tabItems.Controls.Add(this.splitIt);
            this.tabItems.Location = new System.Drawing.Point(4, 22);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabItems.Size = new System.Drawing.Size(943, 748);
            this.tabItems.TabIndex = 5;
            this.tabItems.Text = "Items";
            // 
            // splitIt
            // 
            this.splitIt.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitIt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitIt.Location = new System.Drawing.Point(3, 3);
            this.splitIt.Name = "splitIt";
            this.splitIt.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitIt.Panel1
            // 
            this.splitIt.Panel1.Controls.Add(this.txtItem);
            this.splitIt.Panel1.Controls.Add(this.label15);
            // 
            // splitIt.Panel2
            // 
            this.splitIt.Panel2.Controls.Add(this.dgvItems);
            this.splitIt.Size = new System.Drawing.Size(937, 742);
            this.splitIt.SplitterDistance = 35;
            this.splitIt.SplitterWidth = 3;
            this.splitIt.TabIndex = 0;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(36, 6);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(133, 20);
            this.txtItem.TabIndex = 5;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Item:";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.iValue});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 25;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(937, 704);
            this.dgvItems.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 37;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 41;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Effect";
            this.dataGridViewTextBoxColumn8.HeaderText = "Effect";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 41;
            // 
            // iValue
            // 
            this.iValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iValue.DataPropertyName = "Value";
            this.iValue.HeaderText = "Value";
            this.iValue.Name = "iValue";
            this.iValue.ReadOnly = true;
            this.iValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iValue.Width = 40;
            // 
            // tabMonsters
            // 
            this.tabMonsters.BackColor = System.Drawing.SystemColors.Control;
            this.tabMonsters.Controls.Add(this.splitMonsters);
            this.tabMonsters.Location = new System.Drawing.Point(4, 22);
            this.tabMonsters.Name = "tabMonsters";
            this.tabMonsters.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonsters.Size = new System.Drawing.Size(943, 748);
            this.tabMonsters.TabIndex = 2;
            this.tabMonsters.Text = "Monsters";
            // 
            // splitMonsters
            // 
            this.splitMonsters.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitMonsters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMonsters.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMonsters.Location = new System.Drawing.Point(3, 3);
            this.splitMonsters.Name = "splitMonsters";
            this.splitMonsters.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMonsters.Panel1
            // 
            this.splitMonsters.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitMonsters.Panel1.Controls.Add(this.txtMonster);
            this.splitMonsters.Panel1.Controls.Add(this.label6);
            this.splitMonsters.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitMonsters.Panel2
            // 
            this.splitMonsters.Panel2.Controls.Add(this.dgvMonsters);
            this.splitMonsters.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitMonsters.Size = new System.Drawing.Size(937, 742);
            this.splitMonsters.SplitterDistance = 32;
            this.splitMonsters.SplitterWidth = 3;
            this.splitMonsters.TabIndex = 0;
            // 
            // txtMonster
            // 
            this.txtMonster.Location = new System.Drawing.Point(54, 6);
            this.txtMonster.Name = "txtMonster";
            this.txtMonster.Size = new System.Drawing.Size(133, 20);
            this.txtMonster.TabIndex = 5;
            this.txtMonster.TextChanged += new System.EventHandler(this.txtMonster_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Monster:";
            // 
            // dgvMonsters
            // 
            this.dgvMonsters.AllowUserToAddRows = false;
            this.dgvMonsters.AllowUserToDeleteRows = false;
            this.dgvMonsters.AllowUserToResizeColumns = false;
            this.dgvMonsters.AllowUserToResizeRows = false;
            this.dgvMonsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonsters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mName,
            this.mHealth,
            this.mAct,
            this.mMov,
            this.mCrit,
            this.mExp,
            this.mAttacks,
            this.mDefense,
            this.mImmune,
            this.mTrait,
            this.Column3});
            this.dgvMonsters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonsters.Location = new System.Drawing.Point(0, 0);
            this.dgvMonsters.MultiSelect = false;
            this.dgvMonsters.Name = "dgvMonsters";
            this.dgvMonsters.RowHeadersVisible = false;
            this.dgvMonsters.RowTemplate.Height = 25;
            this.dgvMonsters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonsters.Size = new System.Drawing.Size(937, 707);
            this.dgvMonsters.TabIndex = 0;
            // 
            // mName
            // 
            this.mName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mName.DataPropertyName = "Name";
            this.mName.HeaderText = "Name";
            this.mName.Name = "mName";
            this.mName.ReadOnly = true;
            this.mName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mName.Width = 41;
            // 
            // mHealth
            // 
            this.mHealth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mHealth.DataPropertyName = "Health";
            this.mHealth.HeaderText = "Health";
            this.mHealth.Name = "mHealth";
            this.mHealth.ReadOnly = true;
            this.mHealth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mHealth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mHealth.Width = 44;
            // 
            // mAct
            // 
            this.mAct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mAct.DataPropertyName = "Action";
            this.mAct.HeaderText = "Act";
            this.mAct.Name = "mAct";
            this.mAct.ReadOnly = true;
            this.mAct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mAct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mAct.Width = 29;
            // 
            // mMov
            // 
            this.mMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mMov.DataPropertyName = "Move";
            this.mMov.HeaderText = "Mov";
            this.mMov.Name = "mMov";
            this.mMov.ReadOnly = true;
            this.mMov.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mMov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mMov.Width = 34;
            // 
            // mCrit
            // 
            this.mCrit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mCrit.DataPropertyName = "Critical";
            this.mCrit.HeaderText = "Crit";
            this.mCrit.Name = "mCrit";
            this.mCrit.ReadOnly = true;
            this.mCrit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mCrit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mCrit.Width = 28;
            // 
            // mExp
            // 
            this.mExp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mExp.DataPropertyName = "Experience";
            this.mExp.HeaderText = "Exp";
            this.mExp.Name = "mExp";
            this.mExp.ReadOnly = true;
            this.mExp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mExp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mExp.Width = 31;
            // 
            // mAttacks
            // 
            this.mAttacks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mAttacks.DataPropertyName = "Attack";
            this.mAttacks.HeaderText = "Attacks";
            this.mAttacks.Name = "mAttacks";
            this.mAttacks.ReadOnly = true;
            this.mAttacks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mAttacks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mAttacks.Width = 49;
            // 
            // mDefense
            // 
            this.mDefense.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mDefense.DataPropertyName = "Defense";
            this.mDefense.HeaderText = "Defense";
            this.mDefense.Name = "mDefense";
            this.mDefense.ReadOnly = true;
            this.mDefense.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mDefense.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mDefense.Width = 53;
            // 
            // mImmune
            // 
            this.mImmune.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mImmune.DataPropertyName = "Immune";
            this.mImmune.HeaderText = "Immune";
            this.mImmune.Name = "mImmune";
            this.mImmune.ReadOnly = true;
            this.mImmune.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mImmune.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mImmune.Width = 50;
            // 
            // mTrait
            // 
            this.mTrait.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mTrait.DataPropertyName = "Trait";
            this.mTrait.HeaderText = "Trait";
            this.mTrait.Name = "mTrait";
            this.mTrait.ReadOnly = true;
            this.mTrait.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mTrait.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mTrait.Width = 34;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Coins";
            this.Column3.HeaderText = "Coins";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 39;
            // 
            // tabPlayer
            // 
            this.tabPlayer.BackColor = System.Drawing.SystemColors.Control;
            this.tabPlayer.Controls.Add(this.splitParty);
            this.tabPlayer.Location = new System.Drawing.Point(4, 22);
            this.tabPlayer.Name = "tabPlayer";
            this.tabPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayer.Size = new System.Drawing.Size(943, 748);
            this.tabPlayer.TabIndex = 6;
            this.tabPlayer.Text = "Party";
            // 
            // splitParty
            // 
            this.splitParty.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitParty.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitParty.Location = new System.Drawing.Point(3, 3);
            this.splitParty.Name = "splitParty";
            this.splitParty.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitParty.Panel1
            // 
            this.splitParty.Panel1.Controls.Add(this.btnMoveToMap);
            this.splitParty.Panel1.Controls.Add(this.lblPartyLoad);
            this.splitParty.Panel1.Controls.Add(this.nudLight);
            this.splitParty.Panel1.Controls.Add(this.nudStepwatch);
            this.splitParty.Panel1.Controls.Add(this.nudMapIndex);
            this.splitParty.Panel1.Controls.Add(this.nudRations);
            this.splitParty.Panel1.Controls.Add(this.btnShowMap);
            this.splitParty.Panel1.Controls.Add(this.label64);
            this.splitParty.Panel1.Controls.Add(this.label68);
            this.splitParty.Panel1.Controls.Add(this.nudMoney);
            this.splitParty.Panel1.Controls.Add(this.nudStealth);
            this.splitParty.Panel1.Controls.Add(this.label65);
            this.splitParty.Panel1.Controls.Add(this.nudSense);
            this.splitParty.Panel1.Controls.Add(this.nudYPos);
            this.splitParty.Panel1.Controls.Add(this.nudMapset);
            this.splitParty.Panel1.Controls.Add(this.label58);
            this.splitParty.Panel1.Controls.Add(this.btnSavePlayer);
            this.splitParty.Panel1.Controls.Add(this.label62);
            this.splitParty.Panel1.Controls.Add(this.nudLightInt);
            this.splitParty.Panel1.Controls.Add(this.label66);
            this.splitParty.Panel1.Controls.Add(this.label63);
            this.splitParty.Panel1.Controls.Add(this.label55);
            this.splitParty.Panel1.Controls.Add(this.label56);
            this.splitParty.Panel1.Controls.Add(this.label57);
            this.splitParty.Panel1.Controls.Add(this.nudXPos);
            this.splitParty.Panel1.Controls.Add(this.label61);
            this.splitParty.Panel1.Controls.Add(this.btnReloadPlayer);
            this.splitParty.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitParty.Panel2
            // 
            this.splitParty.Panel2.Controls.Add(this.panel1);
            this.splitParty.Size = new System.Drawing.Size(937, 742);
            this.splitParty.SplitterDistance = 60;
            this.splitParty.SplitterWidth = 3;
            this.splitParty.TabIndex = 81;
            // 
            // btnMoveToMap
            // 
            this.btnMoveToMap.Location = new System.Drawing.Point(590, 5);
            this.btnMoveToMap.Name = "btnMoveToMap";
            this.btnMoveToMap.Size = new System.Drawing.Size(80, 23);
            this.btnMoveToMap.TabIndex = 98;
            this.btnMoveToMap.Text = "Move to Map";
            this.btnMoveToMap.UseVisualStyleBackColor = true;
            this.btnMoveToMap.Click += new System.EventHandler(this.btnMoveToMap_Click);
            // 
            // lblPartyLoad
            // 
            this.lblPartyLoad.AutoSize = true;
            this.lblPartyLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyLoad.Location = new System.Drawing.Point(671, 35);
            this.lblPartyLoad.Name = "lblPartyLoad";
            this.lblPartyLoad.Size = new System.Drawing.Size(133, 13);
            this.lblPartyLoad.TabIndex = 97;
            this.lblPartyLoad.Text = "12/12/12 12:12:12PM";
            // 
            // nudLight
            // 
            this.nudLight.Location = new System.Drawing.Point(60, 33);
            this.nudLight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudLight.Name = "nudLight";
            this.nudLight.Size = new System.Drawing.Size(40, 20);
            this.nudLight.TabIndex = 71;
            this.nudLight.ValueChanged += new System.EventHandler(this.nudLight_ValueChanged);
            // 
            // nudStepwatch
            // 
            this.nudStepwatch.Location = new System.Drawing.Point(265, 33);
            this.nudStepwatch.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStepwatch.Name = "nudStepwatch";
            this.nudStepwatch.Size = new System.Drawing.Size(40, 20);
            this.nudStepwatch.TabIndex = 76;
            // 
            // nudMapIndex
            // 
            this.nudMapIndex.Location = new System.Drawing.Point(330, 8);
            this.nudMapIndex.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMapIndex.Name = "nudMapIndex";
            this.nudMapIndex.Size = new System.Drawing.Size(40, 20);
            this.nudMapIndex.TabIndex = 95;
            // 
            // nudRations
            // 
            this.nudRations.Location = new System.Drawing.Point(157, 8);
            this.nudRations.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudRations.Name = "nudRations";
            this.nudRations.Size = new System.Drawing.Size(53, 20);
            this.nudRations.TabIndex = 90;
            // 
            // btnShowMap
            // 
            this.btnShowMap.Location = new System.Drawing.Point(504, 5);
            this.btnShowMap.Name = "btnShowMap";
            this.btnShowMap.Size = new System.Drawing.Size(80, 23);
            this.btnShowMap.TabIndex = 96;
            this.btnShowMap.Text = "Go to Map";
            this.btnShowMap.UseVisualStyleBackColor = true;
            this.btnShowMap.Click += new System.EventHandler(this.btnShowMap_Click);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(111, 10);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(46, 13);
            this.label64.TabIndex = 89;
            this.label64.Text = "Rations:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(307, 10);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(24, 13);
            this.label68.TabIndex = 94;
            this.label68.Text = "Idx:";
            // 
            // nudMoney
            // 
            this.nudMoney.Location = new System.Drawing.Point(47, 8);
            this.nudMoney.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudMoney.Name = "nudMoney";
            this.nudMoney.Size = new System.Drawing.Size(53, 20);
            this.nudMoney.TabIndex = 88;
            // 
            // nudStealth
            // 
            this.nudStealth.Location = new System.Drawing.Point(349, 33);
            this.nudStealth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStealth.Name = "nudStealth";
            this.nudStealth.Size = new System.Drawing.Size(40, 20);
            this.nudStealth.TabIndex = 78;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 10);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(42, 13);
            this.label65.TabIndex = 87;
            this.label65.Text = "Money:";
            // 
            // nudSense
            // 
            this.nudSense.Location = new System.Drawing.Point(430, 33);
            this.nudSense.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSense.Name = "nudSense";
            this.nudSense.Size = new System.Drawing.Size(40, 20);
            this.nudSense.TabIndex = 80;
            // 
            // nudYPos
            // 
            this.nudYPos.Location = new System.Drawing.Point(452, 8);
            this.nudYPos.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudYPos.Name = "nudYPos";
            this.nudYPos.Size = new System.Drawing.Size(40, 20);
            this.nudYPos.TabIndex = 84;
            // 
            // nudMapset
            // 
            this.nudMapset.Location = new System.Drawing.Point(265, 8);
            this.nudMapset.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudMapset.Name = "nudMapset";
            this.nudMapset.Size = new System.Drawing.Size(40, 20);
            this.nudMapset.TabIndex = 93;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(391, 35);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(40, 13);
            this.label58.TabIndex = 79;
            this.label58.Text = "Sense:";
            // 
            // btnSavePlayer
            // 
            this.btnSavePlayer.Location = new System.Drawing.Point(590, 30);
            this.btnSavePlayer.Name = "btnSavePlayer";
            this.btnSavePlayer.Size = new System.Drawing.Size(80, 23);
            this.btnSavePlayer.TabIndex = 70;
            this.btnSavePlayer.Text = "Save";
            this.btnSavePlayer.UseVisualStyleBackColor = true;
            this.btnSavePlayer.Click += new System.EventHandler(this.btnSavePlayer_Click);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(436, 10);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(17, 13);
            this.label62.TabIndex = 83;
            this.label62.Text = "Y:";
            // 
            // nudLightInt
            // 
            this.nudLightInt.Location = new System.Drawing.Point(157, 33);
            this.nudLightInt.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudLightInt.Name = "nudLightInt";
            this.nudLightInt.Size = new System.Drawing.Size(40, 20);
            this.nudLightInt.TabIndex = 86;
            this.nudLightInt.ValueChanged += new System.EventHandler(this.nudLightInt_ValueChanged);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(213, 10);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(53, 13);
            this.label66.TabIndex = 91;
            this.label66.Text = "Map: Set:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(102, 35);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(56, 13);
            this.label63.TabIndex = 85;
            this.label63.Text = "Light Rad:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 35);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(53, 13);
            this.label55.TabIndex = 70;
            this.label55.Text = "Light Dur:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(205, 35);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(61, 13);
            this.label56.TabIndex = 75;
            this.label56.Text = "Stepwatch:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(307, 35);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(43, 13);
            this.label57.TabIndex = 77;
            this.label57.Text = "Stealth:";
            // 
            // nudXPos
            // 
            this.nudXPos.Location = new System.Drawing.Point(392, 8);
            this.nudXPos.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudXPos.Name = "nudXPos";
            this.nudXPos.Size = new System.Drawing.Size(40, 20);
            this.nudXPos.TabIndex = 82;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(376, 10);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(17, 13);
            this.label61.TabIndex = 81;
            this.label61.Text = "X:";
            // 
            // btnReloadPlayer
            // 
            this.btnReloadPlayer.Location = new System.Drawing.Point(504, 30);
            this.btnReloadPlayer.Name = "btnReloadPlayer";
            this.btnReloadPlayer.Size = new System.Drawing.Size(80, 23);
            this.btnReloadPlayer.TabIndex = 71;
            this.btnReloadPlayer.Text = "Reload";
            this.btnReloadPlayer.UseVisualStyleBackColor = true;
            this.btnReloadPlayer.Click += new System.EventHandler(this.btnReloadPlayer_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nudBack9);
            this.panel1.Controls.Add(this.nudBack8);
            this.panel1.Controls.Add(this.nudBack7);
            this.panel1.Controls.Add(this.nudBack6);
            this.panel1.Controls.Add(this.nudBack5);
            this.panel1.Controls.Add(this.nudBack4);
            this.panel1.Controls.Add(this.nudBack3);
            this.panel1.Controls.Add(this.nudBack2);
            this.panel1.Controls.Add(this.nudBack1);
            this.panel1.Controls.Add(this.nudBack0);
            this.panel1.Controls.Add(this.cboClass);
            this.panel1.Controls.Add(this.nudExpSkill);
            this.panel1.Controls.Add(this.nudExpCurrent);
            this.panel1.Controls.Add(this.nudExpNext);
            this.panel1.Controls.Add(this.nudAgility);
            this.panel1.Controls.Add(this.nudHealth);
            this.panel1.Controls.Add(this.nudFatigue);
            this.panel1.Controls.Add(this.nudStamina);
            this.panel1.Controls.Add(this.nudWounds);
            this.panel1.Controls.Add(this.nudMoves);
            this.panel1.Controls.Add(this.nudActions);
            this.panel1.Controls.Add(this.nudLevel);
            this.panel1.Controls.Add(this.nudReason);
            this.panel1.Controls.Add(this.nudAYellow);
            this.panel1.Controls.Add(this.nudMelee);
            this.panel1.Controls.Add(this.nudStrength);
            this.panel1.Controls.Add(this.nudIAmmo);
            this.panel1.Controls.Add(this.cboIBackpack9);
            this.panel1.Controls.Add(this.cboIBackpack8);
            this.panel1.Controls.Add(this.cboIBackpack7);
            this.panel1.Controls.Add(this.cboIBackpack6);
            this.panel1.Controls.Add(this.cboIBackpack5);
            this.panel1.Controls.Add(this.cboIBackpack4);
            this.panel1.Controls.Add(this.cboIBackpack3);
            this.panel1.Controls.Add(this.cboIBackpack2);
            this.panel1.Controls.Add(this.cboIBackpack1);
            this.panel1.Controls.Add(this.cboIBackpack0);
            this.panel1.Controls.Add(this.cboISpellbook);
            this.panel1.Controls.Add(this.cboITrinket);
            this.panel1.Controls.Add(this.cboIArmor);
            this.panel1.Controls.Add(this.cboIAmmo);
            this.panel1.Controls.Add(this.cboIRanged);
            this.panel1.Controls.Add(this.cboIOffhand);
            this.panel1.Controls.Add(this.cboIMain);
            this.panel1.Controls.Add(this.label78);
            this.panel1.Controls.Add(this.label77);
            this.panel1.Controls.Add(this.label76);
            this.panel1.Controls.Add(this.label75);
            this.panel1.Controls.Add(this.label74);
            this.panel1.Controls.Add(this.label73);
            this.panel1.Controls.Add(this.label71);
            this.panel1.Controls.Add(this.label70);
            this.panel1.Controls.Add(this.label67);
            this.panel1.Controls.Add(this.label59);
            this.panel1.Controls.Add(this.nudCunning);
            this.panel1.Controls.Add(this.nudDefense);
            this.panel1.Controls.Add(this.label60);
            this.panel1.Controls.Add(this.txtPlayerName);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.dgvPlayerStates);
            this.panel1.Controls.Add(this.cboPlayer);
            this.panel1.Controls.Add(this.label54);
            this.panel1.Controls.Add(this.label53);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label49);
            this.panel1.Controls.Add(this.nudAIndigo);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.nudAViolet);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label46);
            this.panel1.Controls.Add(this.nudABlue);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label47);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.nudAOrange);
            this.panel1.Controls.Add(this.label48);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.nudAGreen);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Controls.Add(this.nudARed);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label51);
            this.panel1.Controls.Add(this.label52);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.nudGamble);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.nudCritical);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.nudLore);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.nudLocks);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.nudTraps);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.nudResist);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.nudRanged);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.nudSorcery);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 679);
            this.panel1.TabIndex = 74;
            // 
            // nudBack9
            // 
            this.nudBack9.Location = new System.Drawing.Point(617, 457);
            this.nudBack9.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBack9.Name = "nudBack9";
            this.nudBack9.Size = new System.Drawing.Size(40, 20);
            this.nudBack9.TabIndex = 121;
            // 
            // nudBack8
            // 
            this.nudBack8.Location = new System.Drawing.Point(617, 433);
            this.nudBack8.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBack8.Name = "nudBack8";
            this.nudBack8.Size = new System.Drawing.Size(40, 20);
            this.nudBack8.TabIndex = 120;
            // 
            // nudBack7
            // 
            this.nudBack7.Location = new System.Drawing.Point(617, 409);
            this.nudBack7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBack7.Name = "nudBack7";
            this.nudBack7.Size = new System.Drawing.Size(40, 20);
            this.nudBack7.TabIndex = 119;
            // 
            // nudBack6
            // 
            this.nudBack6.Location = new System.Drawing.Point(617, 384);
            this.nudBack6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBack6.Name = "nudBack6";
            this.nudBack6.Size = new System.Drawing.Size(40, 20);
            this.nudBack6.TabIndex = 118;
            // 
            // nudBack5
            // 
            this.nudBack5.Location = new System.Drawing.Point(617, 360);
            this.nudBack5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBack5.Name = "nudBack5";
            this.nudBack5.Size = new System.Drawing.Size(40, 20);
            this.nudBack5.TabIndex = 117;
            // 
            // nudBack4
            // 
            this.nudBack4.Location = new System.Drawing.Point(617, 336);
            this.nudBack4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBack4.Name = "nudBack4";
            this.nudBack4.Size = new System.Drawing.Size(40, 20);
            this.nudBack4.TabIndex = 116;
            // 
            // nudBack3
            // 
            this.nudBack3.Location = new System.Drawing.Point(617, 312);
            this.nudBack3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBack3.Name = "nudBack3";
            this.nudBack3.Size = new System.Drawing.Size(40, 20);
            this.nudBack3.TabIndex = 115;
            // 
            // nudBack2
            // 
            this.nudBack2.Location = new System.Drawing.Point(617, 286);
            this.nudBack2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBack2.Name = "nudBack2";
            this.nudBack2.Size = new System.Drawing.Size(40, 20);
            this.nudBack2.TabIndex = 114;
            // 
            // nudBack1
            // 
            this.nudBack1.Location = new System.Drawing.Point(617, 263);
            this.nudBack1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBack1.Name = "nudBack1";
            this.nudBack1.Size = new System.Drawing.Size(40, 20);
            this.nudBack1.TabIndex = 113;
            // 
            // nudBack0
            // 
            this.nudBack0.Location = new System.Drawing.Point(617, 238);
            this.nudBack0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBack0.Name = "nudBack0";
            this.nudBack0.Size = new System.Drawing.Size(40, 20);
            this.nudBack0.TabIndex = 112;
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(199, 30);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(114, 21);
            this.cboClass.TabIndex = 30;
            // 
            // nudExpSkill
            // 
            this.nudExpSkill.Location = new System.Drawing.Point(351, 119);
            this.nudExpSkill.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudExpSkill.Name = "nudExpSkill";
            this.nudExpSkill.Size = new System.Drawing.Size(35, 20);
            this.nudExpSkill.TabIndex = 26;
            // 
            // nudExpCurrent
            // 
            this.nudExpCurrent.Location = new System.Drawing.Point(351, 74);
            this.nudExpCurrent.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudExpCurrent.Name = "nudExpCurrent";
            this.nudExpCurrent.Size = new System.Drawing.Size(53, 20);
            this.nudExpCurrent.TabIndex = 24;
            // 
            // nudExpNext
            // 
            this.nudExpNext.Location = new System.Drawing.Point(351, 96);
            this.nudExpNext.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudExpNext.Name = "nudExpNext";
            this.nudExpNext.Size = new System.Drawing.Size(53, 20);
            this.nudExpNext.TabIndex = 28;
            // 
            // nudAgility
            // 
            this.nudAgility.Location = new System.Drawing.Point(73, 96);
            this.nudAgility.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAgility.Name = "nudAgility";
            this.nudAgility.Size = new System.Drawing.Size(40, 20);
            this.nudAgility.TabIndex = 10;
            // 
            // nudHealth
            // 
            this.nudHealth.Enabled = false;
            this.nudHealth.Location = new System.Drawing.Point(208, 74);
            this.nudHealth.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudHealth.Name = "nudHealth";
            this.nudHealth.Size = new System.Drawing.Size(44, 20);
            this.nudHealth.TabIndex = 13;
            // 
            // nudFatigue
            // 
            this.nudFatigue.Location = new System.Drawing.Point(208, 141);
            this.nudFatigue.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudFatigue.Name = "nudFatigue";
            this.nudFatigue.Size = new System.Drawing.Size(44, 20);
            this.nudFatigue.TabIndex = 15;
            // 
            // nudStamina
            // 
            this.nudStamina.Enabled = false;
            this.nudStamina.Location = new System.Drawing.Point(208, 119);
            this.nudStamina.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudStamina.Name = "nudStamina";
            this.nudStamina.Size = new System.Drawing.Size(44, 20);
            this.nudStamina.TabIndex = 17;
            // 
            // nudWounds
            // 
            this.nudWounds.Location = new System.Drawing.Point(208, 96);
            this.nudWounds.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudWounds.Name = "nudWounds";
            this.nudWounds.Size = new System.Drawing.Size(44, 20);
            this.nudWounds.TabIndex = 19;
            // 
            // nudMoves
            // 
            this.nudMoves.Location = new System.Drawing.Point(363, 31);
            this.nudMoves.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMoves.Name = "nudMoves";
            this.nudMoves.Size = new System.Drawing.Size(40, 20);
            this.nudMoves.TabIndex = 84;
            // 
            // nudActions
            // 
            this.nudActions.Location = new System.Drawing.Point(363, 6);
            this.nudActions.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudActions.Name = "nudActions";
            this.nudActions.Size = new System.Drawing.Size(40, 20);
            this.nudActions.TabIndex = 82;
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(119, 31);
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(40, 20);
            this.nudLevel.TabIndex = 21;
            // 
            // nudReason
            // 
            this.nudReason.Location = new System.Drawing.Point(73, 141);
            this.nudReason.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudReason.Name = "nudReason";
            this.nudReason.Size = new System.Drawing.Size(40, 20);
            this.nudReason.TabIndex = 6;
            // 
            // nudAYellow
            // 
            this.nudAYellow.Location = new System.Drawing.Point(208, 239);
            this.nudAYellow.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAYellow.Name = "nudAYellow";
            this.nudAYellow.Size = new System.Drawing.Size(40, 20);
            this.nudAYellow.TabIndex = 58;
            // 
            // nudMelee
            // 
            this.nudMelee.Location = new System.Drawing.Point(73, 194);
            this.nudMelee.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMelee.Name = "nudMelee";
            this.nudMelee.Size = new System.Drawing.Size(40, 20);
            this.nudMelee.TabIndex = 33;
            // 
            // nudStrength
            // 
            this.nudStrength.Location = new System.Drawing.Point(73, 74);
            this.nudStrength.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStrength.Name = "nudStrength";
            this.nudStrength.Size = new System.Drawing.Size(40, 20);
            this.nudStrength.TabIndex = 4;
            // 
            // nudIAmmo
            // 
            this.nudIAmmo.Location = new System.Drawing.Point(617, 143);
            this.nudIAmmo.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudIAmmo.Name = "nudIAmmo";
            this.nudIAmmo.Size = new System.Drawing.Size(40, 20);
            this.nudIAmmo.TabIndex = 111;
            // 
            // cboIBackpack9
            // 
            this.cboIBackpack9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIBackpack9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIBackpack9.DisplayMember = "Item1";
            this.cboIBackpack9.FormattingEnabled = true;
            this.cboIBackpack9.Location = new System.Drawing.Point(508, 456);
            this.cboIBackpack9.Name = "cboIBackpack9";
            this.cboIBackpack9.Size = new System.Drawing.Size(104, 21);
            this.cboIBackpack9.TabIndex = 110;
            this.cboIBackpack9.ValueMember = "Item2";
            this.cboIBackpack9.SelectedIndexChanged += new System.EventHandler(this.cboIBackpack9_SelectedIndexChanged);
            // 
            // cboIBackpack8
            // 
            this.cboIBackpack8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIBackpack8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIBackpack8.DisplayMember = "Item1";
            this.cboIBackpack8.FormattingEnabled = true;
            this.cboIBackpack8.Location = new System.Drawing.Point(508, 432);
            this.cboIBackpack8.Name = "cboIBackpack8";
            this.cboIBackpack8.Size = new System.Drawing.Size(104, 21);
            this.cboIBackpack8.TabIndex = 109;
            this.cboIBackpack8.ValueMember = "Item2";
            this.cboIBackpack8.SelectedIndexChanged += new System.EventHandler(this.cboIBackpack8_SelectedIndexChanged);
            // 
            // cboIBackpack7
            // 
            this.cboIBackpack7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIBackpack7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIBackpack7.DisplayMember = "Item1";
            this.cboIBackpack7.FormattingEnabled = true;
            this.cboIBackpack7.Location = new System.Drawing.Point(508, 408);
            this.cboIBackpack7.Name = "cboIBackpack7";
            this.cboIBackpack7.Size = new System.Drawing.Size(104, 21);
            this.cboIBackpack7.TabIndex = 108;
            this.cboIBackpack7.ValueMember = "Item2";
            this.cboIBackpack7.SelectedIndexChanged += new System.EventHandler(this.cboIBackpack7_SelectedIndexChanged);
            // 
            // cboIBackpack6
            // 
            this.cboIBackpack6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIBackpack6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIBackpack6.DisplayMember = "Item1";
            this.cboIBackpack6.FormattingEnabled = true;
            this.cboIBackpack6.Location = new System.Drawing.Point(508, 383);
            this.cboIBackpack6.Name = "cboIBackpack6";
            this.cboIBackpack6.Size = new System.Drawing.Size(104, 21);
            this.cboIBackpack6.TabIndex = 107;
            this.cboIBackpack6.ValueMember = "Item2";
            this.cboIBackpack6.SelectedIndexChanged += new System.EventHandler(this.cboIBackpack6_SelectedIndexChanged);
            // 
            // cboIBackpack5
            // 
            this.cboIBackpack5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIBackpack5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIBackpack5.DisplayMember = "Item1";
            this.cboIBackpack5.FormattingEnabled = true;
            this.cboIBackpack5.Location = new System.Drawing.Point(508, 359);
            this.cboIBackpack5.Name = "cboIBackpack5";
            this.cboIBackpack5.Size = new System.Drawing.Size(104, 21);
            this.cboIBackpack5.TabIndex = 106;
            this.cboIBackpack5.ValueMember = "Item2";
            this.cboIBackpack5.SelectedIndexChanged += new System.EventHandler(this.cboIBackpack5_SelectedIndexChanged);
            // 
            // cboIBackpack4
            // 
            this.cboIBackpack4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIBackpack4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIBackpack4.DisplayMember = "Item1";
            this.cboIBackpack4.FormattingEnabled = true;
            this.cboIBackpack4.Location = new System.Drawing.Point(508, 335);
            this.cboIBackpack4.Name = "cboIBackpack4";
            this.cboIBackpack4.Size = new System.Drawing.Size(104, 21);
            this.cboIBackpack4.TabIndex = 105;
            this.cboIBackpack4.ValueMember = "Item2";
            this.cboIBackpack4.SelectedIndexChanged += new System.EventHandler(this.cboIBackpack4_SelectedIndexChanged);
            // 
            // cboIBackpack3
            // 
            this.cboIBackpack3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIBackpack3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIBackpack3.DisplayMember = "Item1";
            this.cboIBackpack3.FormattingEnabled = true;
            this.cboIBackpack3.Location = new System.Drawing.Point(508, 311);
            this.cboIBackpack3.Name = "cboIBackpack3";
            this.cboIBackpack3.Size = new System.Drawing.Size(104, 21);
            this.cboIBackpack3.TabIndex = 104;
            this.cboIBackpack3.ValueMember = "Item2";
            this.cboIBackpack3.SelectedIndexChanged += new System.EventHandler(this.cboIBackpack3_SelectedIndexChanged);
            // 
            // cboIBackpack2
            // 
            this.cboIBackpack2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIBackpack2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIBackpack2.DisplayMember = "Item1";
            this.cboIBackpack2.FormattingEnabled = true;
            this.cboIBackpack2.Location = new System.Drawing.Point(508, 286);
            this.cboIBackpack2.Name = "cboIBackpack2";
            this.cboIBackpack2.Size = new System.Drawing.Size(104, 21);
            this.cboIBackpack2.TabIndex = 103;
            this.cboIBackpack2.ValueMember = "Item2";
            this.cboIBackpack2.SelectedIndexChanged += new System.EventHandler(this.cboIBackpack2_SelectedIndexChanged);
            // 
            // cboIBackpack1
            // 
            this.cboIBackpack1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIBackpack1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIBackpack1.DisplayMember = "Item1";
            this.cboIBackpack1.FormattingEnabled = true;
            this.cboIBackpack1.Location = new System.Drawing.Point(508, 262);
            this.cboIBackpack1.Name = "cboIBackpack1";
            this.cboIBackpack1.Size = new System.Drawing.Size(104, 21);
            this.cboIBackpack1.TabIndex = 102;
            this.cboIBackpack1.ValueMember = "Item2";
            this.cboIBackpack1.SelectedIndexChanged += new System.EventHandler(this.cboIBackpack1_SelectedIndexChanged);
            // 
            // cboIBackpack0
            // 
            this.cboIBackpack0.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIBackpack0.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIBackpack0.DisplayMember = "Item1";
            this.cboIBackpack0.FormattingEnabled = true;
            this.cboIBackpack0.Location = new System.Drawing.Point(508, 238);
            this.cboIBackpack0.Name = "cboIBackpack0";
            this.cboIBackpack0.Size = new System.Drawing.Size(104, 21);
            this.cboIBackpack0.TabIndex = 101;
            this.cboIBackpack0.ValueMember = "Item2";
            this.cboIBackpack0.SelectedIndexChanged += new System.EventHandler(this.cboIBackpack0_SelectedIndexChanged);
            // 
            // cboISpellbook
            // 
            this.cboISpellbook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboISpellbook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboISpellbook.DisplayMember = "Item1";
            this.cboISpellbook.FormattingEnabled = true;
            this.cboISpellbook.Location = new System.Drawing.Point(508, 214);
            this.cboISpellbook.Name = "cboISpellbook";
            this.cboISpellbook.Size = new System.Drawing.Size(104, 21);
            this.cboISpellbook.TabIndex = 100;
            this.cboISpellbook.ValueMember = "Item2";
            // 
            // cboITrinket
            // 
            this.cboITrinket.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboITrinket.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboITrinket.DisplayMember = "Item1";
            this.cboITrinket.FormattingEnabled = true;
            this.cboITrinket.Location = new System.Drawing.Point(508, 191);
            this.cboITrinket.Name = "cboITrinket";
            this.cboITrinket.Size = new System.Drawing.Size(104, 21);
            this.cboITrinket.TabIndex = 99;
            this.cboITrinket.ValueMember = "Item2";
            // 
            // cboIArmor
            // 
            this.cboIArmor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIArmor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIArmor.DisplayMember = "Item1";
            this.cboIArmor.FormattingEnabled = true;
            this.cboIArmor.Location = new System.Drawing.Point(508, 168);
            this.cboIArmor.Name = "cboIArmor";
            this.cboIArmor.Size = new System.Drawing.Size(104, 21);
            this.cboIArmor.TabIndex = 98;
            this.cboIArmor.ValueMember = "Item2";
            // 
            // cboIAmmo
            // 
            this.cboIAmmo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIAmmo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIAmmo.DisplayMember = "Item1";
            this.cboIAmmo.FormattingEnabled = true;
            this.cboIAmmo.Location = new System.Drawing.Point(508, 144);
            this.cboIAmmo.Name = "cboIAmmo";
            this.cboIAmmo.Size = new System.Drawing.Size(104, 21);
            this.cboIAmmo.TabIndex = 97;
            this.cboIAmmo.ValueMember = "Item2";
            // 
            // cboIRanged
            // 
            this.cboIRanged.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIRanged.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIRanged.DisplayMember = "Item1";
            this.cboIRanged.FormattingEnabled = true;
            this.cboIRanged.Location = new System.Drawing.Point(508, 121);
            this.cboIRanged.Name = "cboIRanged";
            this.cboIRanged.Size = new System.Drawing.Size(104, 21);
            this.cboIRanged.TabIndex = 96;
            this.cboIRanged.ValueMember = "Item2";
            // 
            // cboIOffhand
            // 
            this.cboIOffhand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIOffhand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIOffhand.DisplayMember = "Item1";
            this.cboIOffhand.FormattingEnabled = true;
            this.cboIOffhand.Location = new System.Drawing.Point(508, 97);
            this.cboIOffhand.Name = "cboIOffhand";
            this.cboIOffhand.Size = new System.Drawing.Size(104, 21);
            this.cboIOffhand.TabIndex = 95;
            this.cboIOffhand.ValueMember = "Item2";
            // 
            // cboIMain
            // 
            this.cboIMain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIMain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIMain.DisplayMember = "Item1";
            this.cboIMain.FormattingEnabled = true;
            this.cboIMain.Location = new System.Drawing.Point(508, 74);
            this.cboIMain.Name = "cboIMain";
            this.cboIMain.Size = new System.Drawing.Size(104, 21);
            this.cboIMain.TabIndex = 94;
            this.cboIMain.ValueMember = "Item2";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(450, 240);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(59, 13);
            this.label78.TabIndex = 93;
            this.label78.Text = "Backpack:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(452, 217);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(57, 13);
            this.label77.TabIndex = 92;
            this.label77.Text = "Spellbook:";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(466, 194);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(43, 13);
            this.label76.TabIndex = 91;
            this.label76.Text = "Trinket:";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(472, 170);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(37, 13);
            this.label75.TabIndex = 90;
            this.label75.Text = "Armor:";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(470, 147);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(39, 13);
            this.label74.TabIndex = 89;
            this.label74.Text = "Ammo:";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(461, 123);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(48, 13);
            this.label73.TabIndex = 88;
            this.label73.Text = "Ranged:";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(461, 100);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(48, 13);
            this.label71.TabIndex = 87;
            this.label71.Text = "Offhand:";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(476, 77);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(33, 13);
            this.label70.TabIndex = 86;
            this.label70.Text = "Main:";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label67.Location = new System.Drawing.Point(448, 57);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(62, 15);
            this.label67.TabIndex = 85;
            this.label67.Text = "Inventory";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(327, 33);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(37, 13);
            this.label59.TabIndex = 83;
            this.label59.Text = "Move:";
            // 
            // nudCunning
            // 
            this.nudCunning.Location = new System.Drawing.Point(73, 119);
            this.nudCunning.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudCunning.Name = "nudCunning";
            this.nudCunning.Size = new System.Drawing.Size(40, 20);
            this.nudCunning.TabIndex = 8;
            // 
            // nudDefense
            // 
            this.nudDefense.Location = new System.Drawing.Point(73, 262);
            this.nudDefense.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudDefense.Name = "nudDefense";
            this.nudDefense.Size = new System.Drawing.Size(40, 20);
            this.nudDefense.TabIndex = 35;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(319, 9);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(45, 13);
            this.label60.TabIndex = 81;
            this.label60.Text = "Actions:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(199, 5);
            this.txtPlayerName.MaxLength = 16;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(114, 20);
            this.txtPlayerName.TabIndex = 1;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(162, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(11, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "Attributes";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Strength:";
            // 
            // dgvPlayerStates
            // 
            this.dgvPlayerStates.AllowUserToAddRows = false;
            this.dgvPlayerStates.AllowUserToDeleteRows = false;
            this.dgvPlayerStates.AllowUserToResizeColumns = false;
            this.dgvPlayerStates.AllowUserToResizeRows = false;
            this.dgvPlayerStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerStates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPlayerStates.Location = new System.Drawing.Point(287, 194);
            this.dgvPlayerStates.Name = "dgvPlayerStates";
            this.dgvPlayerStates.RowHeadersVisible = false;
            this.dgvPlayerStates.RowTemplate.Height = 25;
            this.dgvPlayerStates.Size = new System.Drawing.Size(136, 283);
            this.dgvPlayerStates.TabIndex = 69;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Description";
            this.Column1.HeaderText = "Effect";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 41;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Value";
            this.Column2.HeaderText = "Value";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 40;
            // 
            // cboPlayer
            // 
            this.cboPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayer.FormattingEnabled = true;
            this.cboPlayer.Location = new System.Drawing.Point(51, 5);
            this.cboPlayer.Name = "cboPlayer";
            this.cboPlayer.Size = new System.Drawing.Size(108, 21);
            this.cboPlayer.TabIndex = 73;
            this.cboPlayer.SelectedIndexChanged += new System.EventHandler(this.cboPlayer_SelectedIndexChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(13, 8);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(39, 13);
            this.label54.TabIndex = 72;
            this.label54.Text = "Player:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label53.Location = new System.Drawing.Point(287, 176);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(42, 15);
            this.label53.TabIndex = 68;
            this.label53.Text = "States";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Reason:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(169, 241);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(41, 13);
            this.label49.TabIndex = 67;
            this.label49.Text = "Yellow:";
            this.label49.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudAIndigo
            // 
            this.nudAIndigo.Location = new System.Drawing.Point(208, 307);
            this.nudAIndigo.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAIndigo.Name = "nudAIndigo";
            this.nudAIndigo.Size = new System.Drawing.Size(40, 20);
            this.nudAIndigo.TabIndex = 66;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "Cunning:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(171, 309);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(39, 13);
            this.label45.TabIndex = 65;
            this.label45.Text = "Indigo:";
            this.label45.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudAViolet
            // 
            this.nudAViolet.Location = new System.Drawing.Point(208, 329);
            this.nudAViolet.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAViolet.Name = "nudAViolet";
            this.nudAViolet.Size = new System.Drawing.Size(40, 20);
            this.nudAViolet.TabIndex = 64;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(37, 98);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "Agility:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(174, 331);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(36, 13);
            this.label46.TabIndex = 63;
            this.label46.Text = "Violet:";
            // 
            // nudABlue
            // 
            this.nudABlue.Location = new System.Drawing.Point(208, 284);
            this.nudABlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudABlue.Name = "nudABlue";
            this.nudABlue.Size = new System.Drawing.Size(40, 20);
            this.nudABlue.TabIndex = 62;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(155, 57);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 15);
            this.label27.TabIndex = 11;
            this.label27.Text = "Condition";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(179, 286);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(31, 13);
            this.label47.TabIndex = 61;
            this.label47.Text = "Blue:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(168, 75);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 12;
            this.label26.Text = "Health:";
            // 
            // nudAOrange
            // 
            this.nudAOrange.Location = new System.Drawing.Point(208, 217);
            this.nudAOrange.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAOrange.Name = "nudAOrange";
            this.nudAOrange.Size = new System.Drawing.Size(40, 20);
            this.nudAOrange.TabIndex = 60;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(165, 218);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(45, 13);
            this.label48.TabIndex = 59;
            this.label48.Text = "Orange:";
            this.label48.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(165, 143);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 13);
            this.label25.TabIndex = 14;
            this.label25.Text = "Fatigue:";
            // 
            // nudAGreen
            // 
            this.nudAGreen.Location = new System.Drawing.Point(208, 262);
            this.nudAGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAGreen.Name = "nudAGreen";
            this.nudAGreen.Size = new System.Drawing.Size(40, 20);
            this.nudAGreen.TabIndex = 56;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(161, 121);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 16;
            this.label24.Text = "Stamina:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(171, 263);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(39, 13);
            this.label50.TabIndex = 55;
            this.label50.Text = "Green:";
            // 
            // nudARed
            // 
            this.nudARed.Location = new System.Drawing.Point(208, 194);
            this.nudARed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudARed.Name = "nudARed";
            this.nudARed.Size = new System.Drawing.Size(40, 20);
            this.nudARed.TabIndex = 54;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(160, 98);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "Wounds:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(180, 196);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(30, 13);
            this.label51.TabIndex = 53;
            this.label51.Text = "Red:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label52.Location = new System.Drawing.Point(156, 176);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(58, 15);
            this.label52.TabIndex = 52;
            this.label52.Text = "Affinities";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(85, 34);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(36, 13);
            this.label28.TabIndex = 20;
            this.label28.Text = "Level:";
            // 
            // nudGamble
            // 
            this.nudGamble.Location = new System.Drawing.Point(73, 375);
            this.nudGamble.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGamble.Name = "nudGamble";
            this.nudGamble.Size = new System.Drawing.Size(40, 20);
            this.nudGamble.TabIndex = 51;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(29, 377);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(46, 13);
            this.label43.TabIndex = 50;
            this.label43.Text = "Gamble:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label32.Location = new System.Drawing.Point(287, 57);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(69, 15);
            this.label32.TabIndex = 22;
            this.label32.Text = "Experience";
            // 
            // nudCritical
            // 
            this.nudCritical.Location = new System.Drawing.Point(73, 398);
            this.nudCritical.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudCritical.Name = "nudCritical";
            this.nudCritical.Size = new System.Drawing.Size(40, 20);
            this.nudCritical.TabIndex = 49;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(308, 76);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 13);
            this.label31.TabIndex = 23;
            this.label31.Text = "Current:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(34, 400);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(41, 13);
            this.label44.TabIndex = 48;
            this.label44.Text = "Critical:";
            // 
            // nudLore
            // 
            this.nudLore.Location = new System.Drawing.Point(73, 307);
            this.nudLore.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudLore.Name = "nudLore";
            this.nudLore.Size = new System.Drawing.Size(40, 20);
            this.nudLore.TabIndex = 47;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(323, 121);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 13);
            this.label30.TabIndex = 25;
            this.label30.Text = "Skill:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(44, 309);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 13);
            this.label39.TabIndex = 46;
            this.label39.Text = "Lore:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudLocks
            // 
            this.nudLocks.Location = new System.Drawing.Point(73, 329);
            this.nudLocks.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudLocks.Name = "nudLocks";
            this.nudLocks.Size = new System.Drawing.Size(40, 20);
            this.nudLocks.TabIndex = 45;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(320, 98);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 13);
            this.label29.TabIndex = 27;
            this.label29.Text = "Next:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(36, 331);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(39, 13);
            this.label40.TabIndex = 44;
            this.label40.Text = "Locks:";
            // 
            // nudTraps
            // 
            this.nudTraps.Location = new System.Drawing.Point(73, 352);
            this.nudTraps.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTraps.Name = "nudTraps";
            this.nudTraps.Size = new System.Drawing.Size(40, 20);
            this.nudTraps.TabIndex = 43;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(165, 33);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 13);
            this.label33.TabIndex = 29;
            this.label33.Text = "Class:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(38, 354);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(37, 13);
            this.label41.TabIndex = 42;
            this.label41.Text = "Traps:";
            // 
            // nudResist
            // 
            this.nudResist.Location = new System.Drawing.Point(73, 284);
            this.nudResist.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudResist.Name = "nudResist";
            this.nudResist.Size = new System.Drawing.Size(40, 20);
            this.nudResist.TabIndex = 41;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label38.Location = new System.Drawing.Point(11, 176);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 15);
            this.label38.TabIndex = 31;
            this.label38.Text = "Skills";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(36, 286);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(39, 13);
            this.label42.TabIndex = 40;
            this.label42.Text = "Resist:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(36, 194);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(39, 13);
            this.label37.TabIndex = 32;
            this.label37.Text = "Melee:";
            // 
            // nudRanged
            // 
            this.nudRanged.Location = new System.Drawing.Point(73, 217);
            this.nudRanged.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRanged.Name = "nudRanged";
            this.nudRanged.Size = new System.Drawing.Size(40, 20);
            this.nudRanged.TabIndex = 39;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(27, 218);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(48, 13);
            this.label34.TabIndex = 38;
            this.label34.Text = "Ranged:";
            this.label34.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(25, 263);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(50, 13);
            this.label36.TabIndex = 34;
            this.label36.Text = "Defense:";
            // 
            // nudSorcery
            // 
            this.nudSorcery.Location = new System.Drawing.Point(73, 239);
            this.nudSorcery.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSorcery.Name = "nudSorcery";
            this.nudSorcery.Size = new System.Drawing.Size(40, 20);
            this.nudSorcery.TabIndex = 37;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(29, 241);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 13);
            this.label35.TabIndex = 36;
            this.label35.Text = "Sorcery:";
            // 
            // tabMaps
            // 
            this.tabMaps.BackColor = System.Drawing.SystemColors.Control;
            this.tabMaps.Controls.Add(this.splitMaps);
            this.tabMaps.Location = new System.Drawing.Point(4, 22);
            this.tabMaps.Name = "tabMaps";
            this.tabMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaps.Size = new System.Drawing.Size(943, 748);
            this.tabMaps.TabIndex = 4;
            this.tabMaps.Text = "Maps";
            // 
            // splitMaps
            // 
            this.splitMaps.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMaps.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMaps.Location = new System.Drawing.Point(3, 3);
            this.splitMaps.Name = "splitMaps";
            // 
            // splitMaps.Panel1
            // 
            this.splitMaps.Panel1.Controls.Add(this.lstMaps);
            this.splitMaps.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitMaps.Panel2
            // 
            this.splitMaps.Panel2.Controls.Add(this.splitContainer5);
            this.splitMaps.Size = new System.Drawing.Size(937, 742);
            this.splitMaps.SplitterDistance = 161;
            this.splitMaps.SplitterWidth = 3;
            this.splitMaps.TabIndex = 0;
            // 
            // lstMaps
            // 
            this.lstMaps.DisplayMember = "Item1";
            this.lstMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMaps.FormattingEnabled = true;
            this.lstMaps.Location = new System.Drawing.Point(0, 0);
            this.lstMaps.Name = "lstMaps";
            this.lstMaps.Size = new System.Drawing.Size(161, 742);
            this.lstMaps.TabIndex = 1;
            this.lstMaps.SelectedIndexChanged += new System.EventHandler(this.lstMaps_SelectedIndexChanged);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer5.Panel2.Controls.Add(this.splitEdge);
            this.splitContainer5.Size = new System.Drawing.Size(773, 742);
            this.splitContainer5.SplitterDistance = 559;
            this.splitContainer5.SplitterWidth = 3;
            this.splitContainer5.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer4.Panel1.Controls.Add(this.lblSaveNotes);
            this.splitContainer4.Panel1.Controls.Add(this.lblMapset);
            this.splitContainer4.Panel1.Controls.Add(this.label8);
            this.splitContainer4.Panel1.Controls.Add(this.btnSaveNotes);
            this.splitContainer4.Panel1.Controls.Add(this.label69);
            this.splitContainer4.Panel1.Controls.Add(this.txtMapName);
            this.splitContainer4.Panel1.Controls.Add(this.lblMapIndex);
            this.splitContainer4.Panel1.Controls.Add(this.label72);
            this.splitContainer4.Panel1.Controls.Add(this.label12);
            this.splitContainer4.Panel1.Controls.Add(this.lblYPos);
            this.splitContainer4.Panel1.Controls.Add(this.lblXPos);
            this.splitContainer4.Panel1.Controls.Add(this.label9);
            this.splitContainer4.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.AutoScroll = true;
            this.splitContainer4.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer4.Panel2.Controls.Add(this.picMap);
            this.splitContainer4.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer4.Size = new System.Drawing.Size(559, 742);
            this.splitContainer4.SplitterDistance = 32;
            this.splitContainer4.SplitterWidth = 3;
            this.splitContainer4.TabIndex = 0;
            // 
            // lblSaveNotes
            // 
            this.lblSaveNotes.AutoSize = true;
            this.lblSaveNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveNotes.Location = new System.Drawing.Point(479, 7);
            this.lblSaveNotes.Name = "lblSaveNotes";
            this.lblSaveNotes.Size = new System.Drawing.Size(133, 13);
            this.lblSaveNotes.TabIndex = 15;
            this.lblSaveNotes.Text = "12/12/12 12:12:12PM";
            // 
            // lblMapset
            // 
            this.lblMapset.AutoSize = true;
            this.lblMapset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMapset.Location = new System.Drawing.Point(52, 6);
            this.lblMapset.Name = "lblMapset";
            this.lblMapset.Size = new System.Drawing.Size(14, 15);
            this.lblMapset.TabIndex = 8;
            this.lblMapset.Text = "9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Map: Set:";
            // 
            // btnSaveNotes
            // 
            this.btnSaveNotes.Location = new System.Drawing.Point(403, 2);
            this.btnSaveNotes.Name = "btnSaveNotes";
            this.btnSaveNotes.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNotes.TabIndex = 14;
            this.btnSaveNotes.Text = "Save Notes";
            this.btnSaveNotes.UseVisualStyleBackColor = true;
            this.btnSaveNotes.Click += new System.EventHandler(this.btnSaveNotes_Click);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(65, 7);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(24, 13);
            this.label69.TabIndex = 9;
            this.label69.Text = "Idx:";
            // 
            // txtMapName
            // 
            this.txtMapName.Location = new System.Drawing.Point(217, 4);
            this.txtMapName.Name = "txtMapName";
            this.txtMapName.Size = new System.Drawing.Size(178, 20);
            this.txtMapName.TabIndex = 13;
            this.txtMapName.TextChanged += new System.EventHandler(this.txtMapName_TextChanged);
            // 
            // lblMapIndex
            // 
            this.lblMapIndex.AutoSize = true;
            this.lblMapIndex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMapIndex.Location = new System.Drawing.Point(86, 6);
            this.lblMapIndex.Name = "lblMapIndex";
            this.lblMapIndex.Size = new System.Drawing.Size(21, 15);
            this.lblMapIndex.TabIndex = 10;
            this.lblMapIndex.Text = "99";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(179, 7);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(38, 13);
            this.label72.TabIndex = 12;
            this.label72.Text = "Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(143, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Y:";
            // 
            // lblYPos
            // 
            this.lblYPos.AutoSize = true;
            this.lblYPos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblYPos.Location = new System.Drawing.Point(157, 6);
            this.lblYPos.Name = "lblYPos";
            this.lblYPos.Size = new System.Drawing.Size(21, 15);
            this.lblYPos.TabIndex = 5;
            this.lblYPos.Text = "99";
            // 
            // lblXPos
            // 
            this.lblXPos.AutoSize = true;
            this.lblXPos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblXPos.Location = new System.Drawing.Point(123, 6);
            this.lblXPos.Name = "lblXPos";
            this.lblXPos.Size = new System.Drawing.Size(21, 15);
            this.lblXPos.TabIndex = 3;
            this.lblXPos.Text = "99";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "X:";
            // 
            // picMap
            // 
            this.picMap.Location = new System.Drawing.Point(0, 0);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(86, 43);
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            this.picMap.Click += new System.EventHandler(this.picMap_Click);
            this.picMap.MouseLeave += new System.EventHandler(this.picMap_MouseLeave);
            this.picMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseMove);
            // 
            // splitEdge
            // 
            this.splitEdge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitEdge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitEdge.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitEdge.Location = new System.Drawing.Point(0, 0);
            this.splitEdge.Name = "splitEdge";
            this.splitEdge.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitEdge.Panel1
            // 
            this.splitEdge.Panel1.Controls.Add(this.label79);
            this.splitEdge.Panel1.Controls.Add(this.label80);
            this.splitEdge.Panel1.Controls.Add(this.label83);
            this.splitEdge.Panel1.Controls.Add(this.lblEdgeMapY);
            this.splitEdge.Panel1.Controls.Add(this.lblEdgeMapX);
            this.splitEdge.Panel1.Controls.Add(this.lblEdgeMap);
            this.splitEdge.Panel1.Controls.Add(this.lblEdgeDir);
            this.splitEdge.Panel1.Controls.Add(this.label16);
            this.splitEdge.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitEdge.Panel2
            // 
            this.splitEdge.Panel2.Controls.Add(this.pnlInfo);
            this.splitEdge.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitEdge.Size = new System.Drawing.Size(211, 742);
            this.splitEdge.SplitterDistance = 67;
            this.splitEdge.TabIndex = 0;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(16, 25);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(31, 13);
            this.label79.TabIndex = 28;
            this.label79.Text = "Map:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(72, 44);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(17, 13);
            this.label80.TabIndex = 31;
            this.label80.Text = "Y:";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(30, 44);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(17, 13);
            this.label83.TabIndex = 29;
            this.label83.Text = "X:";
            // 
            // lblEdgeMapY
            // 
            this.lblEdgeMapY.AutoSize = true;
            this.lblEdgeMapY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEdgeMapY.Location = new System.Drawing.Point(87, 43);
            this.lblEdgeMapY.Name = "lblEdgeMapY";
            this.lblEdgeMapY.Size = new System.Drawing.Size(21, 15);
            this.lblEdgeMapY.TabIndex = 32;
            this.lblEdgeMapY.Text = "99";
            // 
            // lblEdgeMapX
            // 
            this.lblEdgeMapX.AutoSize = true;
            this.lblEdgeMapX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEdgeMapX.Location = new System.Drawing.Point(45, 43);
            this.lblEdgeMapX.Name = "lblEdgeMapX";
            this.lblEdgeMapX.Size = new System.Drawing.Size(21, 15);
            this.lblEdgeMapX.TabIndex = 30;
            this.lblEdgeMapX.Text = "99";
            // 
            // lblEdgeMap
            // 
            this.lblEdgeMap.AutoEllipsis = true;
            this.lblEdgeMap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEdgeMap.Location = new System.Drawing.Point(45, 24);
            this.lblEdgeMap.Name = "lblEdgeMap";
            this.lblEdgeMap.Size = new System.Drawing.Size(166, 14);
            this.lblEdgeMap.TabIndex = 19;
            this.lblEdgeMap.Text = "edgemap";
            // 
            // lblEdgeDir
            // 
            this.lblEdgeDir.AutoSize = true;
            this.lblEdgeDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEdgeDir.Location = new System.Drawing.Point(45, 6);
            this.lblEdgeDir.Name = "lblEdgeDir";
            this.lblEdgeDir.Size = new System.Drawing.Size(50, 15);
            this.lblEdgeDir.TabIndex = 17;
            this.lblEdgeDir.Text = "edgedir";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Edge:";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.lblInfoType);
            this.pnlInfo.Controls.Add(this.pnlInfoNotes);
            this.pnlInfo.Controls.Add(this.cboInfoType);
            this.pnlInfo.Controls.Add(this.label10);
            this.pnlInfo.Controls.Add(this.pnlInfoMap);
            this.pnlInfo.Controls.Add(this.label11);
            this.pnlInfo.Controls.Add(this.label14);
            this.pnlInfo.Controls.Add(this.lblInfoY);
            this.pnlInfo.Controls.Add(this.lblInfoX);
            this.pnlInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(207, 667);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblInfoType
            // 
            this.lblInfoType.AutoSize = true;
            this.lblInfoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoType.Location = new System.Drawing.Point(46, 8);
            this.lblInfoType.Name = "lblInfoType";
            this.lblInfoType.Size = new System.Drawing.Size(39, 13);
            this.lblInfoType.TabIndex = 28;
            this.lblInfoType.Text = "Type:";
            this.lblInfoType.Visible = false;
            // 
            // pnlInfoNotes
            // 
            this.pnlInfoNotes.Controls.Add(this.btnInfoDelete);
            this.pnlInfoNotes.Controls.Add(this.txtInfoNotes);
            this.pnlInfoNotes.Controls.Add(this.btnInfoClose);
            this.pnlInfoNotes.Controls.Add(this.label13);
            this.pnlInfoNotes.Location = new System.Drawing.Point(3, 91);
            this.pnlInfoNotes.Name = "pnlInfoNotes";
            this.pnlInfoNotes.Size = new System.Drawing.Size(213, 547);
            this.pnlInfoNotes.TabIndex = 26;
            // 
            // btnInfoDelete
            // 
            this.btnInfoDelete.Location = new System.Drawing.Point(141, 493);
            this.btnInfoDelete.Name = "btnInfoDelete";
            this.btnInfoDelete.Size = new System.Drawing.Size(61, 23);
            this.btnInfoDelete.TabIndex = 16;
            this.btnInfoDelete.Text = "Delete";
            this.btnInfoDelete.UseVisualStyleBackColor = true;
            this.btnInfoDelete.Click += new System.EventHandler(this.btnInfoDelete_Click);
            // 
            // txtInfoNotes
            // 
            this.txtInfoNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInfoNotes.BackColor = System.Drawing.SystemColors.Window;
            this.txtInfoNotes.Location = new System.Drawing.Point(1, 21);
            this.txtInfoNotes.Multiline = true;
            this.txtInfoNotes.Name = "txtInfoNotes";
            this.txtInfoNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfoNotes.Size = new System.Drawing.Size(201, 466);
            this.txtInfoNotes.TabIndex = 15;
            this.txtInfoNotes.TextChanged += new System.EventHandler(this.txtInfoNotes_TextChanged);
            // 
            // btnInfoClose
            // 
            this.btnInfoClose.Location = new System.Drawing.Point(1, 493);
            this.btnInfoClose.Name = "btnInfoClose";
            this.btnInfoClose.Size = new System.Drawing.Size(61, 23);
            this.btnInfoClose.TabIndex = 17;
            this.btnInfoClose.Text = "Close";
            this.btnInfoClose.UseVisualStyleBackColor = true;
            this.btnInfoClose.Click += new System.EventHandler(this.btnInfoClose_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(2, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Notes:";
            // 
            // cboInfoType
            // 
            this.cboInfoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInfoType.FormattingEnabled = true;
            this.cboInfoType.Location = new System.Drawing.Point(49, 5);
            this.cboInfoType.Name = "cboInfoType";
            this.cboInfoType.Size = new System.Drawing.Size(121, 21);
            this.cboInfoType.TabIndex = 24;
            this.cboInfoType.SelectedIndexChanged += new System.EventHandler(this.cboInfoType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Type:";
            // 
            // pnlInfoMap
            // 
            this.pnlInfoMap.Controls.Add(this.lblInfoMapH);
            this.pnlInfoMap.Controls.Add(this.btnInfoMap);
            this.pnlInfoMap.Controls.Add(this.lblInfoMapY);
            this.pnlInfoMap.Controls.Add(this.label82);
            this.pnlInfoMap.Controls.Add(this.lblInfoMap);
            this.pnlInfoMap.Controls.Add(this.label81);
            this.pnlInfoMap.Controls.Add(this.lblInfoMapX);
            this.pnlInfoMap.Location = new System.Drawing.Point(3, 45);
            this.pnlInfoMap.Name = "pnlInfoMap";
            this.pnlInfoMap.Size = new System.Drawing.Size(213, 47);
            this.pnlInfoMap.TabIndex = 25;
            // 
            // lblInfoMapH
            // 
            this.lblInfoMapH.AutoSize = true;
            this.lblInfoMapH.Location = new System.Drawing.Point(15, 8);
            this.lblInfoMapH.Name = "lblInfoMapH";
            this.lblInfoMapH.Size = new System.Drawing.Size(31, 13);
            this.lblInfoMapH.TabIndex = 27;
            this.lblInfoMapH.Text = "Map:";
            this.lblInfoMapH.Visible = false;
            // 
            // btnInfoMap
            // 
            this.btnInfoMap.Location = new System.Drawing.Point(3, 3);
            this.btnInfoMap.Name = "btnInfoMap";
            this.btnInfoMap.Size = new System.Drawing.Size(42, 23);
            this.btnInfoMap.TabIndex = 19;
            this.btnInfoMap.Text = "Map:";
            this.btnInfoMap.UseVisualStyleBackColor = true;
            this.btnInfoMap.Click += new System.EventHandler(this.btnInfoMap_Click);
            // 
            // lblInfoMapY
            // 
            this.lblInfoMapY.AutoSize = true;
            this.lblInfoMapY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoMapY.Location = new System.Drawing.Point(85, 28);
            this.lblInfoMapY.Name = "lblInfoMapY";
            this.lblInfoMapY.Size = new System.Drawing.Size(21, 15);
            this.lblInfoMapY.TabIndex = 23;
            this.lblInfoMapY.Text = "99";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(70, 29);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(17, 13);
            this.label82.TabIndex = 22;
            this.label82.Text = "Y:";
            // 
            // lblInfoMap
            // 
            this.lblInfoMap.AutoEllipsis = true;
            this.lblInfoMap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoMap.Location = new System.Drawing.Point(43, 7);
            this.lblInfoMap.Name = "lblInfoMap";
            this.lblInfoMap.Size = new System.Drawing.Size(170, 19);
            this.lblInfoMap.TabIndex = 18;
            this.lblInfoMap.Text = "map";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(28, 29);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(17, 13);
            this.label81.TabIndex = 20;
            this.label81.Text = "X:";
            // 
            // lblInfoMapX
            // 
            this.lblInfoMapX.AutoSize = true;
            this.lblInfoMapX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoMapX.Location = new System.Drawing.Point(43, 28);
            this.lblInfoMapX.Name = "lblInfoMapX";
            this.lblInfoMapX.Size = new System.Drawing.Size(21, 15);
            this.lblInfoMapX.TabIndex = 21;
            this.lblInfoMapX.Text = "99";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Y:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "X:";
            // 
            // lblInfoY
            // 
            this.lblInfoY.AutoSize = true;
            this.lblInfoY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoY.Location = new System.Drawing.Point(89, 28);
            this.lblInfoY.Name = "lblInfoY";
            this.lblInfoY.Size = new System.Drawing.Size(21, 15);
            this.lblInfoY.TabIndex = 11;
            this.lblInfoY.Text = "99";
            // 
            // lblInfoX
            // 
            this.lblInfoX.AutoSize = true;
            this.lblInfoX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoX.Location = new System.Drawing.Point(47, 28);
            this.lblInfoX.Name = "lblInfoX";
            this.lblInfoX.Size = new System.Drawing.Size(21, 15);
            this.lblInfoX.TabIndex = 9;
            this.lblInfoX.Text = "99";
            // 
            // tabCharsets
            // 
            this.tabCharsets.BackColor = System.Drawing.SystemColors.Control;
            this.tabCharsets.Controls.Add(this.splitChars);
            this.tabCharsets.Location = new System.Drawing.Point(4, 22);
            this.tabCharsets.Name = "tabCharsets";
            this.tabCharsets.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharsets.Size = new System.Drawing.Size(943, 748);
            this.tabCharsets.TabIndex = 3;
            this.tabCharsets.Text = "Charsets";
            // 
            // splitChars
            // 
            this.splitChars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitChars.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitChars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitChars.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitChars.Location = new System.Drawing.Point(3, 3);
            this.splitChars.Name = "splitChars";
            // 
            // splitChars.Panel1
            // 
            this.splitChars.Panel1.Controls.Add(this.splitContainer2);
            this.splitChars.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitChars.Panel2
            // 
            this.splitChars.Panel2.AutoScroll = true;
            this.splitChars.Panel2.Controls.Add(this.picCharset);
            this.splitChars.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitChars.Size = new System.Drawing.Size(937, 742);
            this.splitChars.SplitterDistance = 94;
            this.splitChars.SplitterWidth = 3;
            this.splitChars.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblCharIndex);
            this.splitContainer2.Panel1.Controls.Add(this.lblCSet);
            this.splitContainer2.Panel1.Controls.Add(this.lblCIndex);
            this.splitContainer2.Panel1.Controls.Add(this.label84);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lstChars);
            this.splitContainer2.Size = new System.Drawing.Size(94, 742);
            this.splitContainer2.SplitterDistance = 42;
            this.splitContainer2.TabIndex = 2;
            // 
            // lblCharIndex
            // 
            this.lblCharIndex.AutoSize = true;
            this.lblCharIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharIndex.Location = new System.Drawing.Point(45, 21);
            this.lblCharIndex.Name = "lblCharIndex";
            this.lblCharIndex.Size = new System.Drawing.Size(28, 13);
            this.lblCharIndex.TabIndex = 4;
            this.lblCharIndex.Text = "999";
            // 
            // lblCSet
            // 
            this.lblCSet.AutoSize = true;
            this.lblCSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSet.Location = new System.Drawing.Point(45, 3);
            this.lblCSet.Name = "lblCSet";
            this.lblCSet.Size = new System.Drawing.Size(28, 13);
            this.lblCSet.TabIndex = 3;
            this.lblCSet.Text = "999";
            // 
            // lblCIndex
            // 
            this.lblCIndex.AutoSize = true;
            this.lblCIndex.Location = new System.Drawing.Point(13, 21);
            this.lblCIndex.Name = "lblCIndex";
            this.lblCIndex.Size = new System.Drawing.Size(36, 13);
            this.lblCIndex.TabIndex = 2;
            this.lblCIndex.Text = "Index:";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(3, 3);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(46, 13);
            this.label84.TabIndex = 1;
            this.label84.Text = "Charset:";
            // 
            // lstChars
            // 
            this.lstChars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstChars.FormattingEnabled = true;
            this.lstChars.Location = new System.Drawing.Point(0, 0);
            this.lstChars.Name = "lstChars";
            this.lstChars.Size = new System.Drawing.Size(90, 692);
            this.lstChars.TabIndex = 1;
            this.lstChars.SelectedIndexChanged += new System.EventHandler(this.lstChars_SelectedIndexChanged);
            // 
            // picCharset
            // 
            this.picCharset.Location = new System.Drawing.Point(0, 0);
            this.picCharset.Name = "picCharset";
            this.picCharset.Size = new System.Drawing.Size(86, 43);
            this.picCharset.TabIndex = 0;
            this.picCharset.TabStop = false;
            this.picCharset.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCharset_MouseMove);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 798);
            this.Controls.Add(this.tctlMain);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "RoA Companion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tctlMain.ResumeLayout(false);
            this.tabWeapons.ResumeLayout(false);
            this.splitItems.Panel1.ResumeLayout(false);
            this.splitItems.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitItems)).EndInit();
            this.splitItems.ResumeLayout(false);
            this.splitWeapons.Panel1.ResumeLayout(false);
            this.splitWeapons.Panel1.PerformLayout();
            this.splitWeapons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitWeapons)).EndInit();
            this.splitWeapons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeapons)).EndInit();
            this.splitArmor.Panel1.ResumeLayout(false);
            this.splitArmor.Panel1.PerformLayout();
            this.splitArmor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitArmor)).EndInit();
            this.splitArmor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmor)).EndInit();
            this.tabSpells.ResumeLayout(false);
            this.splitSpells.Panel1.ResumeLayout(false);
            this.splitSpells.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSpells)).EndInit();
            this.splitSpells.ResumeLayout(false);
            this.splitSpell.Panel1.ResumeLayout(false);
            this.splitSpell.Panel1.PerformLayout();
            this.splitSpell.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSpell)).EndInit();
            this.splitSpell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpells)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tabItems.ResumeLayout(false);
            this.splitIt.Panel1.ResumeLayout(false);
            this.splitIt.Panel1.PerformLayout();
            this.splitIt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitIt)).EndInit();
            this.splitIt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.tabMonsters.ResumeLayout(false);
            this.splitMonsters.Panel1.ResumeLayout(false);
            this.splitMonsters.Panel1.PerformLayout();
            this.splitMonsters.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMonsters)).EndInit();
            this.splitMonsters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonsters)).EndInit();
            this.tabPlayer.ResumeLayout(false);
            this.splitParty.Panel1.ResumeLayout(false);
            this.splitParty.Panel1.PerformLayout();
            this.splitParty.Panel2.ResumeLayout(false);
            this.splitParty.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitParty)).EndInit();
            this.splitParty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepwatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLightInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBack0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFatigue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStamina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMelee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIAmmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCunning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAIndigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAViolet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudABlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudARed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTraps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRanged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSorcery)).EndInit();
            this.tabMaps.ResumeLayout(false);
            this.splitMaps.Panel1.ResumeLayout(false);
            this.splitMaps.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMaps)).EndInit();
            this.splitMaps.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.splitEdge.Panel1.ResumeLayout(false);
            this.splitEdge.Panel1.PerformLayout();
            this.splitEdge.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitEdge)).EndInit();
            this.splitEdge.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlInfoNotes.ResumeLayout(false);
            this.pnlInfoNotes.PerformLayout();
            this.pnlInfoMap.ResumeLayout(false);
            this.pnlInfoMap.PerformLayout();
            this.tabCharsets.ResumeLayout(false);
            this.splitChars.Panel1.ResumeLayout(false);
            this.splitChars.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitChars)).EndInit();
            this.splitChars.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCharset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDataFolder;
        private System.Windows.Forms.FolderBrowserDialog dlgDataFolder;
        private System.Windows.Forms.TabControl tctlMain;
        private System.Windows.Forms.TabPage tabWeapons;
        private System.Windows.Forms.SplitContainer splitItems;
        private System.Windows.Forms.SplitContainer splitWeapons;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWeapons;
        private System.Windows.Forms.SplitContainer splitArmor;
        private System.Windows.Forms.TextBox txtArmor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabSpells;
        private System.Windows.Forms.ComboBox cboCurWeapon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCurArmor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvArmor;
        private System.Windows.Forms.TabPage tabMonsters;
        private System.Windows.Forms.SplitContainer splitSpells;
        private System.Windows.Forms.TextBox txtSpell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSpells;
        private System.Windows.Forms.SplitContainer splitMonsters;
        private System.Windows.Forms.DataGridView dgvMonsters;
        private System.Windows.Forms.TextBox txtMonster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitSpell;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TabPage tabCharsets;
        private System.Windows.Forms.SplitContainer splitChars;
        private System.Windows.Forms.PictureBox picCharset;
        private System.Windows.Forms.TabPage tabMaps;
        private System.Windows.Forms.SplitContainer splitMaps;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label lblYPos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblXPos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.ListBox lstChars;
        private System.Windows.Forms.ListBox lstMaps;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Label lblInfoMap;
        private System.Windows.Forms.TextBox txtInfoNotes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblInfoY;
        private System.Windows.Forms.Label lblInfoX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.SplitContainer splitIt;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TabPage tabPlayer;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudWounds;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown nudStamina;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown nudFatigue;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown nudHealth;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown nudAgility;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown nudCunning;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nudReason;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nudStrength;
        private System.Windows.Forms.NumericUpDown nudGamble;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown nudCritical;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.NumericUpDown nudLore;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown nudLocks;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.NumericUpDown nudTraps;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown nudResist;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.NumericUpDown nudRanged;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown nudSorcery;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown nudDefense;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown nudMelee;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown nudExpNext;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown nudExpSkill;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown nudExpCurrent;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown nudAIndigo;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown nudAViolet;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.NumericUpDown nudABlue;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown nudAOrange;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown nudAYellow;
        private System.Windows.Forms.NumericUpDown nudAGreen;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.NumericUpDown nudARed;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.DataGridView dgvPlayerStates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnSavePlayer;
        private System.Windows.Forms.Button btnReloadPlayer;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.NumericUpDown nudSense;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.NumericUpDown nudStealth;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.NumericUpDown nudStepwatch;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown nudLight;
        private System.Windows.Forms.ComboBox cboPlayer;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.NumericUpDown nudMoves;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown nudActions;
        private System.Windows.Forms.SplitContainer splitParty;
        private System.Windows.Forms.NumericUpDown nudLightInt;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.NumericUpDown nudYPos;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.NumericUpDown nudXPos;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.NumericUpDown nudRations;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.NumericUpDown nudMoney;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.NumericUpDown nudMapIndex;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.NumericUpDown nudMapset;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label lblMapIndex;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label lblMapset;
        private System.Windows.Forms.Button btnShowMap;
        private System.Windows.Forms.ComboBox cboIBackpack9;
        private System.Windows.Forms.ComboBox cboIBackpack8;
        private System.Windows.Forms.ComboBox cboIBackpack7;
        private System.Windows.Forms.ComboBox cboIBackpack6;
        private System.Windows.Forms.ComboBox cboIBackpack5;
        private System.Windows.Forms.ComboBox cboIBackpack4;
        private System.Windows.Forms.ComboBox cboIBackpack3;
        private System.Windows.Forms.ComboBox cboIBackpack2;
        private System.Windows.Forms.ComboBox cboIBackpack1;
        private System.Windows.Forms.ComboBox cboIBackpack0;
        private System.Windows.Forms.ComboBox cboISpellbook;
        private System.Windows.Forms.ComboBox cboITrinket;
        private System.Windows.Forms.ComboBox cboIArmor;
        private System.Windows.Forms.ComboBox cboIAmmo;
        private System.Windows.Forms.ComboBox cboIRanged;
        private System.Windows.Forms.ComboBox cboIOffhand;
        private System.Windows.Forms.ComboBox cboIMain;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.NumericUpDown nudIAmmo;
        private System.Windows.Forms.Label lblSaveNotes;
        private System.Windows.Forms.Button btnSaveNotes;
        private System.Windows.Forms.TextBox txtMapName;
        private System.Windows.Forms.ComboBox cboInfoType;
        private System.Windows.Forms.Label lblInfoMapY;
        private System.Windows.Forms.Label lblInfoMapX;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Button btnInfoMap;
        private System.Windows.Forms.Panel pnlInfoNotes;
        private System.Windows.Forms.Button btnInfoDelete;
        private System.Windows.Forms.Panel pnlInfoMap;
        private System.Windows.Forms.Label lblPartyLoad;
        private System.Windows.Forms.Button btnInfoClose;
        private System.Windows.Forms.Label lblInfoType;
        private System.Windows.Forms.Label lblInfoMapH;
        private System.Windows.Forms.DataGridViewTextBoxColumn mName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn mMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn mExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAttacks;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn mImmune;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTrait;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSpell;
        private System.Windows.Forms.DataGridViewTextBoxColumn bColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEffect;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDmgType;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn aColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuMobs;
        private System.Windows.Forms.SplitContainer splitEdge;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label lblEdgeMapY;
        private System.Windows.Forms.Label lblEdgeMapX;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label lblEdgeMap;
        private System.Windows.Forms.Label lblEdgeDir;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudBack9;
        private System.Windows.Forms.NumericUpDown nudBack8;
        private System.Windows.Forms.NumericUpDown nudBack7;
        private System.Windows.Forms.NumericUpDown nudBack6;
        private System.Windows.Forms.NumericUpDown nudBack5;
        private System.Windows.Forms.NumericUpDown nudBack4;
        private System.Windows.Forms.NumericUpDown nudBack3;
        private System.Windows.Forms.NumericUpDown nudBack2;
        private System.Windows.Forms.NumericUpDown nudBack1;
        private System.Windows.Forms.NumericUpDown nudBack0;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblCharIndex;
        private System.Windows.Forms.Label lblCSet;
        private System.Windows.Forms.Label lblCIndex;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.DataGridViewTextBoxColumn wType;
        private System.Windows.Forms.DataGridViewTextBoxColumn wName;
        private System.Windows.Forms.DataGridViewTextBoxColumn wHit;
        private System.Windows.Forms.DataGridViewTextBoxColumn wAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn wMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn wMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDmgType;
        private System.Windows.Forms.DataGridViewTextBoxColumn wProps;
        private System.Windows.Forms.DataGridViewTextBoxColumn wValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn aType;
        private System.Windows.Forms.DataGridViewTextBoxColumn aName;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDmgType;
        private System.Windows.Forms.DataGridViewTextBoxColumn aEffect;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDef;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRdc;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRst;
        private System.Windows.Forms.DataGridViewTextBoxColumn aValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn iValue;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.Button btnMoveToMap;
    }
}

