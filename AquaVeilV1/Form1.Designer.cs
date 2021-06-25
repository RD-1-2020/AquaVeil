
namespace AquaVeilV1
{
    partial class frMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.ssBottomMenu = new System.Windows.Forms.StatusStrip();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.mmItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.mmItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mmItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSettingsRedact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cdColorChange = new System.Windows.Forms.ColorDialog();
            this.fbdExplorer = new System.Windows.Forms.FolderBrowserDialog();
            this.tsMainMenu = new System.Windows.Forms.ToolStrip();
            this.scRedactor = new System.Windows.Forms.SplitContainer();
            this.tsRedactFrameTools = new System.Windows.Forms.ToolStrip();
            this.tsLBColorFrame = new System.Windows.Forms.ToolStripLabel();
            this.tslColorExPen = new System.Windows.Forms.ToolStripLabel();
            this.tslColorPen = new System.Windows.Forms.ToolStripLabel();
            this.tslColorExBack = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.scFrame = new System.Windows.Forms.SplitContainer();
            this.pbFrameRedact = new System.Windows.Forms.PictureBox();
            this.scColorPanel = new System.Windows.Forms.SplitContainer();
            this.pbColorPanel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.glTitle = new System.Windows.Forms.Label();
            this.flMenuTool = new System.Windows.Forms.ToolStrip();
            this.tsBTNewFrame = new System.Windows.Forms.ToolStripSplitButton();
            this.miDelSomeFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelOneFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.lvFrameList = new System.Windows.Forms.ListView();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tsiConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsiDisconnect = new System.Windows.Forms.ToolStripButton();
            this.bmLBItemSettingsInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tssiSettingsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ssBottomMenu.SuspendLayout();
            this.msMainMenu.SuspendLayout();
            this.tsMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRedactor)).BeginInit();
            this.scRedactor.Panel1.SuspendLayout();
            this.scRedactor.Panel2.SuspendLayout();
            this.scRedactor.SuspendLayout();
            this.tsRedactFrameTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scFrame)).BeginInit();
            this.scFrame.Panel1.SuspendLayout();
            this.scFrame.Panel2.SuspendLayout();
            this.scFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrameRedact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scColorPanel)).BeginInit();
            this.scColorPanel.Panel1.SuspendLayout();
            this.scColorPanel.Panel2.SuspendLayout();
            this.scColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPanel)).BeginInit();
            this.flMenuTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssBottomMenu
            // 
            this.ssBottomMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmLBItemSettingsInfo,
            this.toolStripButton2,
            this.tssiSettingsLabel});
            this.ssBottomMenu.Location = new System.Drawing.Point(0, 719);
            this.ssBottomMenu.Name = "ssBottomMenu";
            this.ssBottomMenu.Size = new System.Drawing.Size(1147, 22);
            this.ssBottomMenu.TabIndex = 0;
            this.ssBottomMenu.Text = "statusStrip1";
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmItemFile,
            this.mmItemHelp,
            this.mmItemSettings});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(1147, 24);
            this.msMainMenu.TabIndex = 1;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // mmItemFile
            // 
            this.mmItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSaveTo});
            this.mmItemFile.Name = "mmItemFile";
            this.mmItemFile.Size = new System.Drawing.Size(48, 20);
            this.mmItemFile.Text = "Файл";
            // 
            // tsmSaveTo
            // 
            this.tsmSaveTo.Name = "tsmSaveTo";
            this.tsmSaveTo.Size = new System.Drawing.Size(142, 22);
            this.tsmSaveTo.Text = "Сохранить...";
            this.tsmSaveTo.Click += new System.EventHandler(this.tsmSaveTo_Click);
            // 
            // mmItemHelp
            // 
            this.mmItemHelp.Name = "mmItemHelp";
            this.mmItemHelp.Size = new System.Drawing.Size(65, 20);
            this.mmItemHelp.Text = "Справка";
            // 
            // mmItemSettings
            // 
            this.mmItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSettingsRedact,
            this.toolStripMenuItem1});
            this.mmItemSettings.Name = "mmItemSettings";
            this.mmItemSettings.Size = new System.Drawing.Size(79, 20);
            this.mmItemSettings.Text = "Настройки";
            // 
            // tsmSettingsRedact
            // 
            this.tsmSettingsRedact.Name = "tsmSettingsRedact";
            this.tsmSettingsRedact.Size = new System.Drawing.Size(128, 22);
            this.tsmSettingsRedact.Text = "Изменить";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 6);
            // 
            // tsMainMenu
            // 
            this.tsMainMenu.AutoSize = false;
            this.tsMainMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiConnect,
            this.tsiDisconnect,
            this.toolStripButton1});
            this.tsMainMenu.Location = new System.Drawing.Point(0, 24);
            this.tsMainMenu.Name = "tsMainMenu";
            this.tsMainMenu.Size = new System.Drawing.Size(1147, 44);
            this.tsMainMenu.TabIndex = 3;
            this.tsMainMenu.Text = "tsMainMenu";
            // 
            // scRedactor
            // 
            this.scRedactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scRedactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRedactor.Location = new System.Drawing.Point(0, 0);
            this.scRedactor.Name = "scRedactor";
            // 
            // scRedactor.Panel1
            // 
            this.scRedactor.Panel1.Controls.Add(this.lvFrameList);
            this.scRedactor.Panel1.Controls.Add(this.flMenuTool);
            this.scRedactor.Panel1.Controls.Add(this.glTitle);
            // 
            // scRedactor.Panel2
            // 
            this.scRedactor.Panel2.Controls.Add(this.scFrame);
            this.scRedactor.Panel2.Controls.Add(this.tsRedactFrameTools);
            this.scRedactor.Panel2.Controls.Add(this.label1);
            this.scRedactor.Size = new System.Drawing.Size(1147, 495);
            this.scRedactor.SplitterDistance = 382;
            this.scRedactor.SplitterWidth = 1;
            this.scRedactor.TabIndex = 0;
            // 
            // tsRedactFrameTools
            // 
            this.tsRedactFrameTools.BackColor = System.Drawing.Color.DarkGray;
            this.tsRedactFrameTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsRedactFrameTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLBColorFrame,
            this.tslColorExPen,
            this.tslColorPen,
            this.tslColorExBack});
            this.tsRedactFrameTools.Location = new System.Drawing.Point(0, 468);
            this.tsRedactFrameTools.Name = "tsRedactFrameTools";
            this.tsRedactFrameTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsRedactFrameTools.Size = new System.Drawing.Size(762, 25);
            this.tsRedactFrameTools.TabIndex = 0;
            this.tsRedactFrameTools.Text = "toolStrip1";
            // 
            // tsLBColorFrame
            // 
            this.tsLBColorFrame.Name = "tsLBColorFrame";
            this.tsLBColorFrame.Size = new System.Drawing.Size(68, 22);
            this.tsLBColorFrame.Text = "Цвет Кадра";
            // 
            // tslColorExPen
            // 
            this.tslColorExPen.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.tslColorExPen.AutoSize = false;
            this.tslColorExPen.BackColor = System.Drawing.Color.White;
            this.tslColorExPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tslColorExPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslColorExPen.Name = "tslColorExPen";
            this.tslColorExPen.Size = new System.Drawing.Size(22, 22);
            this.tslColorExPen.Text = "     ";
            this.tslColorExPen.Click += new System.EventHandler(this.tslColorExPen_Click);
            // 
            // tslColorPen
            // 
            this.tslColorPen.Name = "tslColorPen";
            this.tslColorPen.Size = new System.Drawing.Size(69, 22);
            this.tslColorPen.Text = "Цвет Ручки";
            // 
            // tslColorExBack
            // 
            this.tslColorExBack.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.tslColorExBack.AutoSize = false;
            this.tslColorExBack.BackColor = System.Drawing.Color.White;
            this.tslColorExBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tslColorExBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslColorExBack.Name = "tslColorExBack";
            this.tslColorExBack.Size = new System.Drawing.Size(22, 22);
            this.tslColorExBack.Text = "     ";
            this.tslColorExBack.Click += new System.EventHandler(this.tslColorExBack_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Редактирование кадра";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scFrame
            // 
            this.scFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scFrame.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scFrame.Location = new System.Drawing.Point(0, 53);
            this.scFrame.Name = "scFrame";
            this.scFrame.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scFrame.Panel1
            // 
            this.scFrame.Panel1.Controls.Add(this.scColorPanel);
            // 
            // scFrame.Panel2
            // 
            this.scFrame.Panel2.AutoScroll = true;
            this.scFrame.Panel2.Controls.Add(this.pbFrameRedact);
            this.scFrame.Size = new System.Drawing.Size(762, 415);
            this.scFrame.SplitterDistance = 54;
            this.scFrame.SplitterWidth = 1;
            this.scFrame.TabIndex = 3;
            // 
            // pbFrameRedact
            // 
            this.pbFrameRedact.BackColor = System.Drawing.Color.White;
            this.pbFrameRedact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFrameRedact.Location = new System.Drawing.Point(0, 0);
            this.pbFrameRedact.Name = "pbFrameRedact";
            this.pbFrameRedact.Size = new System.Drawing.Size(762, 360);
            this.pbFrameRedact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFrameRedact.TabIndex = 4;
            this.pbFrameRedact.TabStop = false;
            this.pbFrameRedact.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbFrameRedact_MouseClick);
            this.pbFrameRedact.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFrameRedact_MouseClick);
            this.pbFrameRedact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFrameRedact_MouseMove);
            // 
            // scColorPanel
            // 
            this.scColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scColorPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scColorPanel.IsSplitterFixed = true;
            this.scColorPanel.Location = new System.Drawing.Point(0, 0);
            this.scColorPanel.Name = "scColorPanel";
            this.scColorPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scColorPanel.Panel1
            // 
            this.scColorPanel.Panel1.Controls.Add(this.label2);
            // 
            // scColorPanel.Panel2
            // 
            this.scColorPanel.Panel2.Controls.Add(this.pbColorPanel);
            this.scColorPanel.Size = new System.Drawing.Size(762, 54);
            this.scColorPanel.SplitterDistance = 25;
            this.scColorPanel.SplitterWidth = 1;
            this.scColorPanel.TabIndex = 1;
            // 
            // pbColorPanel
            // 
            this.pbColorPanel.BackColor = System.Drawing.Color.White;
            this.pbColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbColorPanel.Location = new System.Drawing.Point(0, 0);
            this.pbColorPanel.Name = "pbColorPanel";
            this.pbColorPanel.Size = new System.Drawing.Size(762, 28);
            this.pbColorPanel.TabIndex = 2;
            this.pbColorPanel.TabStop = false;
            this.pbColorPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbColorPanel_MouseClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(762, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Цвет отдельной форсунки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // glTitle
            // 
            this.glTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.glTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.glTitle.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.glTitle.Location = new System.Drawing.Point(0, 0);
            this.glTitle.Name = "glTitle";
            this.glTitle.Size = new System.Drawing.Size(380, 53);
            this.glTitle.TabIndex = 1;
            this.glTitle.Text = "Сохранённые кадры";
            this.glTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flMenuTool
            // 
            this.flMenuTool.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flMenuTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flMenuTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.tsBTNewFrame});
            this.flMenuTool.Location = new System.Drawing.Point(0, 468);
            this.flMenuTool.Name = "flMenuTool";
            this.flMenuTool.Size = new System.Drawing.Size(380, 25);
            this.flMenuTool.TabIndex = 2;
            this.flMenuTool.Text = "toolStrip1";
            // 
            // tsBTNewFrame
            // 
            this.tsBTNewFrame.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBTNewFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBTNewFrame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDelSomeFrame,
            this.miDelOneFrame});
            this.tsBTNewFrame.Image = ((System.Drawing.Image)(resources.GetObject("tsBTNewFrame.Image")));
            this.tsBTNewFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBTNewFrame.Name = "tsBTNewFrame";
            this.tsBTNewFrame.Size = new System.Drawing.Size(32, 22);
            this.tsBTNewFrame.Text = " ";
            this.tsBTNewFrame.ButtonClick += new System.EventHandler(this.tsBTNewFrame_Click);
            // 
            // miDelSomeFrame
            // 
            this.miDelSomeFrame.Name = "miDelSomeFrame";
            this.miDelSomeFrame.Size = new System.Drawing.Size(180, 22);
            this.miDelSomeFrame.Text = "Несколько кадров";
            this.miDelSomeFrame.Click += new System.EventHandler(this.miAddSomeFrames_Click);
            // 
            // miDelOneFrame
            // 
            this.miDelOneFrame.Name = "miDelOneFrame";
            this.miDelOneFrame.Size = new System.Drawing.Size(180, 22);
            this.miDelOneFrame.Text = "Один кадр";
            this.miDelOneFrame.Click += new System.EventHandler(this.tsBTNewFrame_Click);
            // 
            // lvFrameList
            // 
            this.lvFrameList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFrameList.HideSelection = false;
            this.lvFrameList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9});
            this.lvFrameList.Location = new System.Drawing.Point(0, 53);
            this.lvFrameList.Name = "lvFrameList";
            this.lvFrameList.Size = new System.Drawing.Size(380, 415);
            this.lvFrameList.TabIndex = 3;
            this.lvFrameList.UseCompatibleStateImageBehavior = false;
            this.lvFrameList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvFrameList_ItemSelectionChanged);
            // 
            // scMain
            // 
            this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.Location = new System.Drawing.Point(0, 68);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scRedactor);
            this.scMain.Size = new System.Drawing.Size(1147, 651);
            this.scMain.SplitterDistance = 495;
            this.scMain.SplitterWidth = 1;
            this.scMain.TabIndex = 2;
            // 
            // tsiConnect
            // 
            this.tsiConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsiConnect.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsiConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsiConnect.Image")));
            this.tsiConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiConnect.Name = "tsiConnect";
            this.tsiConnect.RightToLeftAutoMirrorImage = true;
            this.tsiConnect.Size = new System.Drawing.Size(83, 41);
            this.tsiConnect.Text = "Подключиться";
            this.tsiConnect.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsiConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsiConnect.ToolTipText = "Подключиться";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 41);
            this.toolStripButton1.Text = "Подключиться";
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "Подключиться";
            // 
            // tsiDisconnect
            // 
            this.tsiDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsiDisconnect.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsiDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("tsiDisconnect.Image")));
            this.tsiDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiDisconnect.Name = "tsiDisconnect";
            this.tsiDisconnect.RightToLeftAutoMirrorImage = true;
            this.tsiDisconnect.Size = new System.Drawing.Size(77, 41);
            this.tsiDisconnect.Text = "Отключиться";
            this.tsiDisconnect.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsiDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsiDisconnect.ToolTipText = "Отключиться";
            // 
            // bmLBItemSettingsInfo
            // 
            this.bmLBItemSettingsInfo.Name = "bmLBItemSettingsInfo";
            this.bmLBItemSettingsInfo.Size = new System.Drawing.Size(67, 17);
            this.bmLBItemSettingsInfo.Text = "Настройки";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton2.Text = "Подключиться";
            this.toolStripButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.ToolTipText = "Подключиться";
            // 
            // tssiSettingsLabel
            // 
            this.tssiSettingsLabel.Name = "tssiSettingsLabel";
            this.tssiSettingsLabel.Size = new System.Drawing.Size(10, 17);
            this.tssiSettingsLabel.Text = " ";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = " ";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.tsBTNewFrame_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Несколько кадров";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Один кадр";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.tsBTNewFrame_Click);
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 741);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.ssBottomMenu);
            this.Controls.Add(this.tsMainMenu);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frMain";
            this.Text = "Качели";
            this.Resize += new System.EventHandler(this.frMain_Resize);
            this.ssBottomMenu.ResumeLayout(false);
            this.ssBottomMenu.PerformLayout();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tsMainMenu.ResumeLayout(false);
            this.tsMainMenu.PerformLayout();
            this.scRedactor.Panel1.ResumeLayout(false);
            this.scRedactor.Panel1.PerformLayout();
            this.scRedactor.Panel2.ResumeLayout(false);
            this.scRedactor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRedactor)).EndInit();
            this.scRedactor.ResumeLayout(false);
            this.tsRedactFrameTools.ResumeLayout(false);
            this.tsRedactFrameTools.PerformLayout();
            this.scFrame.Panel1.ResumeLayout(false);
            this.scFrame.Panel2.ResumeLayout(false);
            this.scFrame.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scFrame)).EndInit();
            this.scFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFrameRedact)).EndInit();
            this.scColorPanel.Panel1.ResumeLayout(false);
            this.scColorPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scColorPanel)).EndInit();
            this.scColorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPanel)).EndInit();
            this.flMenuTool.ResumeLayout(false);
            this.flMenuTool.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssBottomMenu;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmItemFile;
        private System.Windows.Forms.ToolStripMenuItem mmItemHelp;
        private System.Windows.Forms.ToolStripMenuItem mmItemSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmSettingsRedact;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ColorDialog cdColorChange;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveTo;
        private System.Windows.Forms.FolderBrowserDialog fbdExplorer;
        private System.Windows.Forms.ToolStrip tsMainMenu;
        private System.Windows.Forms.ToolStripButton tsiConnect;
        private System.Windows.Forms.SplitContainer scRedactor;
        private System.Windows.Forms.ListView lvFrameList;
        private System.Windows.Forms.ToolStrip flMenuTool;
        private System.Windows.Forms.ToolStripSplitButton tsBTNewFrame;
        private System.Windows.Forms.ToolStripMenuItem miDelSomeFrame;
        private System.Windows.Forms.ToolStripMenuItem miDelOneFrame;
        private System.Windows.Forms.Label glTitle;
        private System.Windows.Forms.SplitContainer scFrame;
        private System.Windows.Forms.SplitContainer scColorPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbColorPanel;
        private System.Windows.Forms.PictureBox pbFrameRedact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsRedactFrameTools;
        private System.Windows.Forms.ToolStripLabel tsLBColorFrame;
        private System.Windows.Forms.ToolStripLabel tslColorExPen;
        private System.Windows.Forms.ToolStripLabel tslColorPen;
        private System.Windows.Forms.ToolStripLabel tslColorExBack;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ToolStripButton tsiDisconnect;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripStatusLabel bmLBItemSettingsInfo;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripStatusLabel tssiSettingsLabel;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

