
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.ssBottomMenu = new System.Windows.Forms.StatusStrip();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.mmItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mmItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mmItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.bmLBItemSettingsInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.scRedactor = new System.Windows.Forms.SplitContainer();
            this.lvFrameList = new System.Windows.Forms.ListView();
            this.glTitle = new System.Windows.Forms.Label();
            this.tsRedactFrameTools = new System.Windows.Forms.ToolStrip();
            this.tsLBColorFrame = new System.Windows.Forms.ToolStripLabel();
            this.tslColorExPen = new System.Windows.Forms.ToolStripLabel();
            this.tslColorPen = new System.Windows.Forms.ToolStripLabel();
            this.tslColorExBack = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFrameRedact = new System.Windows.Forms.PictureBox();
            this.cdColorChange = new System.Windows.Forms.ColorDialog();
            this.flMnuTool = new System.Windows.Forms.ToolStrip();
            this.tsBTNewFrame = new System.Windows.Forms.ToolStripButton();
            this.ssBottomMenu.SuspendLayout();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRedactor)).BeginInit();
            this.scRedactor.Panel1.SuspendLayout();
            this.scRedactor.Panel2.SuspendLayout();
            this.scRedactor.SuspendLayout();
            this.tsRedactFrameTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrameRedact)).BeginInit();
            this.flMnuTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssBottomMenu
            // 
            this.ssBottomMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmLBItemSettingsInfo});
            this.ssBottomMenu.Location = new System.Drawing.Point(0, 660);
            this.ssBottomMenu.Name = "ssBottomMenu";
            this.ssBottomMenu.Size = new System.Drawing.Size(1215, 22);
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
            this.msMainMenu.Size = new System.Drawing.Size(1215, 24);
            this.msMainMenu.TabIndex = 1;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // mmItemFile
            // 
            this.mmItemFile.Name = "mmItemFile";
            this.mmItemFile.Size = new System.Drawing.Size(48, 20);
            this.mmItemFile.Text = "Файл";
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
            this.изменитьToolStripMenuItem,
            this.toolStripMenuItem1});
            this.mmItemSettings.Name = "mmItemSettings";
            this.mmItemSettings.Size = new System.Drawing.Size(79, 20);
            this.mmItemSettings.Text = "Настройки";
            // 
            // scMain
            // 
            this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.Location = new System.Drawing.Point(0, 24);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scRedactor);
            this.scMain.Size = new System.Drawing.Size(1215, 636);
            this.scMain.SplitterDistance = 448;
            this.scMain.SplitterWidth = 1;
            this.scMain.TabIndex = 2;
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // bmLBItemSettingsInfo
            // 
            this.bmLBItemSettingsInfo.Name = "bmLBItemSettingsInfo";
            this.bmLBItemSettingsInfo.Size = new System.Drawing.Size(67, 17);
            this.bmLBItemSettingsInfo.Text = "Настройки";
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
            this.scRedactor.Panel1.Controls.Add(this.flMnuTool);
            this.scRedactor.Panel1.Controls.Add(this.glTitle);
            this.scRedactor.Panel1.Controls.Add(this.lvFrameList);
            // 
            // scRedactor.Panel2
            // 
            this.scRedactor.Panel2.Controls.Add(this.pbFrameRedact);
            this.scRedactor.Panel2.Controls.Add(this.label1);
            this.scRedactor.Panel2.Controls.Add(this.tsRedactFrameTools);
            this.scRedactor.Size = new System.Drawing.Size(1215, 448);
            this.scRedactor.SplitterDistance = 405;
            this.scRedactor.SplitterWidth = 1;
            this.scRedactor.TabIndex = 0;
            // 
            // lvFrameList
            // 
            this.lvFrameList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFrameList.HideSelection = false;
            this.lvFrameList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvFrameList.Location = new System.Drawing.Point(0, 0);
            this.lvFrameList.Name = "lvFrameList";
            this.lvFrameList.Size = new System.Drawing.Size(403, 446);
            this.lvFrameList.TabIndex = 0;
            this.lvFrameList.UseCompatibleStateImageBehavior = false;
            // 
            // glTitle
            // 
            this.glTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.glTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.glTitle.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.glTitle.Location = new System.Drawing.Point(0, 0);
            this.glTitle.Name = "glTitle";
            this.glTitle.Size = new System.Drawing.Size(403, 53);
            this.glTitle.TabIndex = 1;
            this.glTitle.Text = "Сохранённые кадры";
            this.glTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsRedactFrameTools
            // 
            this.tsRedactFrameTools.BackColor = System.Drawing.Color.DarkGray;
            this.tsRedactFrameTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsRedactFrameTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLBColorFrame,
            this.tslColorExBack,
            this.tslColorPen,
            this.tslColorExPen});
            this.tsRedactFrameTools.Location = new System.Drawing.Point(0, 421);
            this.tsRedactFrameTools.Name = "tsRedactFrameTools";
            this.tsRedactFrameTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsRedactFrameTools.Size = new System.Drawing.Size(807, 25);
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
            this.tslColorPen.Size = new System.Drawing.Size(68, 22);
            this.tslColorPen.Text = "Цвет Кадра";
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
            this.label1.Size = new System.Drawing.Size(807, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Редактирование кадра";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFrameRedact
            // 
            this.pbFrameRedact.BackColor = System.Drawing.Color.White;
            this.pbFrameRedact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFrameRedact.Location = new System.Drawing.Point(0, 53);
            this.pbFrameRedact.Name = "pbFrameRedact";
            this.pbFrameRedact.Size = new System.Drawing.Size(807, 368);
            this.pbFrameRedact.TabIndex = 3;
            this.pbFrameRedact.TabStop = false;
            // 
            // flMnuTool
            // 
            this.flMnuTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flMnuTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBTNewFrame});
            this.flMnuTool.Location = new System.Drawing.Point(0, 421);
            this.flMnuTool.Name = "flMnuTool";
            this.flMnuTool.Size = new System.Drawing.Size(403, 25);
            this.flMnuTool.TabIndex = 2;
            this.flMnuTool.Text = "toolStrip1";
            // 
            // tsBTNewFrame
            // 
            this.tsBTNewFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBTNewFrame.Image = ((System.Drawing.Image)(resources.GetObject("tsBTNewFrame.Image")));
            this.tsBTNewFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBTNewFrame.Name = "tsBTNewFrame";
            this.tsBTNewFrame.Size = new System.Drawing.Size(23, 22);
            this.tsBTNewFrame.Text = " ";
            this.tsBTNewFrame.Click += new System.EventHandler(this.tsBTNewFrame_Click);
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 682);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.ssBottomMenu);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frMain";
            this.Text = "Качели";
            this.Load += new System.EventHandler(this.frMain_Load);
            this.ssBottomMenu.ResumeLayout(false);
            this.ssBottomMenu.PerformLayout();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scRedactor.Panel1.ResumeLayout(false);
            this.scRedactor.Panel1.PerformLayout();
            this.scRedactor.Panel2.ResumeLayout(false);
            this.scRedactor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRedactor)).EndInit();
            this.scRedactor.ResumeLayout(false);
            this.tsRedactFrameTools.ResumeLayout(false);
            this.tsRedactFrameTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrameRedact)).EndInit();
            this.flMnuTool.ResumeLayout(false);
            this.flMnuTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssBottomMenu;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmItemFile;
        private System.Windows.Forms.ToolStripMenuItem mmItemHelp;
        private System.Windows.Forms.ToolStripMenuItem mmItemSettings;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ToolStripStatusLabel bmLBItemSettingsInfo;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.SplitContainer scRedactor;
        private System.Windows.Forms.ListView lvFrameList;
        private System.Windows.Forms.Label glTitle;
        private System.Windows.Forms.ToolStrip tsRedactFrameTools;
        private System.Windows.Forms.ToolStripLabel tsLBColorFrame;
        private System.Windows.Forms.ToolStripLabel tslColorExPen;
        private System.Windows.Forms.ToolStripLabel tslColorExBack;
        private System.Windows.Forms.ToolStripLabel tslColorPen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFrameRedact;
        private System.Windows.Forms.ToolStrip flMnuTool;
        private System.Windows.Forms.ColorDialog cdColorChange;
        private System.Windows.Forms.ToolStripButton tsBTNewFrame;
    }
}

