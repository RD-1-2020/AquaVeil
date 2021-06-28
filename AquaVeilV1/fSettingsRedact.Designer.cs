
namespace AquaVeilV1
{
    partial class fSettingsRedact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettingsRedact));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.pgSettings = new System.Windows.Forms.PropertyGrid();
            this.tsButtonList = new System.Windows.Forms.ToolStrip();
            this.tssiFrame = new System.Windows.Forms.ToolStripButton();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssiSwingSetting = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tsButtonList.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tsButtonList);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pgSettings);
            this.scMain.Size = new System.Drawing.Size(825, 437);
            this.scMain.SplitterDistance = 143;
            this.scMain.TabIndex = 0;
            // 
            // pgSettings
            // 
            this.pgSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgSettings.Location = new System.Drawing.Point(0, 0);
            this.pgSettings.Name = "pgSettings";
            this.pgSettings.Size = new System.Drawing.Size(678, 437);
            this.pgSettings.TabIndex = 0;
            this.pgSettings.ToolbarVisible = false;
            // 
            // tsButtonList
            // 
            this.tsButtonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsButtonList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssiFrame,
            this.tssiSwingSetting});
            this.tsButtonList.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsButtonList.Location = new System.Drawing.Point(0, 0);
            this.tsButtonList.Name = "tsButtonList";
            this.tsButtonList.Size = new System.Drawing.Size(143, 437);
            this.tsButtonList.TabIndex = 0;
            this.tsButtonList.Text = "toolStrip1";
            // 
            // tssiFrame
            // 
            this.tssiFrame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tssiFrame.Image = ((System.Drawing.Image)(resources.GetObject("tssiFrame.Image")));
            this.tssiFrame.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssiFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssiFrame.Name = "tssiFrame";
            this.tssiFrame.Size = new System.Drawing.Size(141, 82);
            this.tssiFrame.Text = "Настройки Поля";
            this.tssiFrame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tssiFrame.ToolTipText = "Настройки Поля";
            this.tssiFrame.Click += new System.EventHandler(this.tssiFrame_Click);
            // 
            // ssMain
            // 
            this.ssMain.Location = new System.Drawing.Point(0, 437);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(825, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tssiSwingSetting
            // 
            this.tssiSwingSetting.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tssiSwingSetting.Image = ((System.Drawing.Image)(resources.GetObject("tssiSwingSetting.Image")));
            this.tssiSwingSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssiSwingSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssiSwingSetting.Name = "tssiSwingSetting";
            this.tssiSwingSetting.Size = new System.Drawing.Size(139, 82);
            this.tssiSwingSetting.Text = "Подстройка качелей";
            this.tssiSwingSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tssiSwingSetting.ToolTipText = "Подстройка качелей";
            this.tssiSwingSetting.Click += new System.EventHandler(this.tssiSwingSetting_Click);
            // 
            // fSettingsRedact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 459);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.ssMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSettingsRedact";
            this.Text = "Настройки Проекта";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tsButtonList.ResumeLayout(false);
            this.tsButtonList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ToolStrip tsButtonList;
        private System.Windows.Forms.ToolStripButton tssiFrame;
        private System.Windows.Forms.PropertyGrid pgSettings;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripButton tssiSwingSetting;
    }
}