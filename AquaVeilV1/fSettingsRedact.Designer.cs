
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lbSettingsTitle = new System.Windows.Forms.Label();
            this.scSubMain = new System.Windows.Forms.SplitContainer();
            this.scWidth = new System.Windows.Forms.SplitContainer();
            this.lbWidthTitle = new System.Windows.Forms.Label();
            this.lbHeightTitle = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.scHeight = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.tbHeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSubMain)).BeginInit();
            this.scSubMain.Panel1.SuspendLayout();
            this.scSubMain.Panel2.SuspendLayout();
            this.scSubMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scWidth)).BeginInit();
            this.scWidth.Panel1.SuspendLayout();
            this.scWidth.Panel2.SuspendLayout();
            this.scWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scHeight)).BeginInit();
            this.scHeight.Panel1.SuspendLayout();
            this.scHeight.Panel2.SuspendLayout();
            this.scHeight.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.lbSettingsTitle);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scSubMain);
            this.scMain.Size = new System.Drawing.Size(368, 117);
            this.scMain.SplitterDistance = 28;
            this.scMain.SplitterWidth = 1;
            this.scMain.TabIndex = 1;
            // 
            // lbSettingsTitle
            // 
            this.lbSettingsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSettingsTitle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSettingsTitle.Location = new System.Drawing.Point(0, 0);
            this.lbSettingsTitle.Name = "lbSettingsTitle";
            this.lbSettingsTitle.Size = new System.Drawing.Size(366, 26);
            this.lbSettingsTitle.TabIndex = 0;
            this.lbSettingsTitle.Text = "Настройки";
            this.lbSettingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scSubMain
            // 
            this.scSubMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scSubMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSubMain.Location = new System.Drawing.Point(0, 0);
            this.scSubMain.Name = "scSubMain";
            this.scSubMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSubMain.Panel1
            // 
            this.scSubMain.Panel1.Controls.Add(this.scWidth);
            // 
            // scSubMain.Panel2
            // 
            this.scSubMain.Panel2.Controls.Add(this.scHeight);
            this.scSubMain.Size = new System.Drawing.Size(368, 88);
            this.scSubMain.SplitterDistance = 25;
            this.scSubMain.SplitterWidth = 1;
            this.scSubMain.TabIndex = 0;
            // 
            // scWidth
            // 
            this.scWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scWidth.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scWidth.Location = new System.Drawing.Point(0, 0);
            this.scWidth.Name = "scWidth";
            // 
            // scWidth.Panel1
            // 
            this.scWidth.Panel1.Controls.Add(this.lbWidthTitle);
            // 
            // scWidth.Panel2
            // 
            this.scWidth.Panel2.Controls.Add(this.lbHeightTitle);
            this.scWidth.Panel2.Controls.Add(this.tbWidth);
            this.scWidth.Size = new System.Drawing.Size(366, 23);
            this.scWidth.SplitterDistance = 79;
            this.scWidth.TabIndex = 0;
            // 
            // lbWidthTitle
            // 
            this.lbWidthTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWidthTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWidthTitle.Location = new System.Drawing.Point(0, 0);
            this.lbWidthTitle.Name = "lbWidthTitle";
            this.lbWidthTitle.Size = new System.Drawing.Size(79, 23);
            this.lbWidthTitle.TabIndex = 4;
            this.lbWidthTitle.Text = "Длинна";
            // 
            // lbHeightTitle
            // 
            this.lbHeightTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHeightTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeightTitle.Location = new System.Drawing.Point(53, 41);
            this.lbHeightTitle.Name = "lbHeightTitle";
            this.lbHeightTitle.Size = new System.Drawing.Size(100, 23);
            this.lbHeightTitle.TabIndex = 6;
            this.lbHeightTitle.Text = "Высота";
            // 
            // tbWidth
            // 
            this.tbWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWidth.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWidth.Location = new System.Drawing.Point(0, 0);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(283, 26);
            this.tbWidth.TabIndex = 5;
            this.tbWidth.Text = "10";
            // 
            // scHeight
            // 
            this.scHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scHeight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scHeight.Location = new System.Drawing.Point(0, 0);
            this.scHeight.Name = "scHeight";
            // 
            // scHeight.Panel1
            // 
            this.scHeight.Panel1.Controls.Add(this.label1);
            // 
            // scHeight.Panel2
            // 
            this.scHeight.Panel2.Controls.Add(this.btConfirm);
            this.scHeight.Panel2.Controls.Add(this.tbHeight);
            this.scHeight.Size = new System.Drawing.Size(366, 60);
            this.scHeight.SplitterDistance = 79;
            this.scHeight.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Высота";
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(173, 32);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(107, 23);
            this.btConfirm.TabIndex = 8;
            this.btConfirm.Text = "Подтвердить";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbHeight
            // 
            this.tbHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbHeight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHeight.Location = new System.Drawing.Point(0, 0);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(283, 26);
            this.tbHeight.TabIndex = 7;
            this.tbHeight.Text = "10";
            // 
            // fSettingsRedact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 117);
            this.Controls.Add(this.scMain);
            this.Name = "fSettingsRedact";
            this.Text = "Настройки Проекта";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scSubMain.Panel1.ResumeLayout(false);
            this.scSubMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSubMain)).EndInit();
            this.scSubMain.ResumeLayout(false);
            this.scWidth.Panel1.ResumeLayout(false);
            this.scWidth.Panel2.ResumeLayout(false);
            this.scWidth.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scWidth)).EndInit();
            this.scWidth.ResumeLayout(false);
            this.scHeight.Panel1.ResumeLayout(false);
            this.scHeight.Panel2.ResumeLayout(false);
            this.scHeight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scHeight)).EndInit();
            this.scHeight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Label lbSettingsTitle;
        private System.Windows.Forms.SplitContainer scSubMain;
        private System.Windows.Forms.SplitContainer scWidth;
        private System.Windows.Forms.SplitContainer scHeight;
        private System.Windows.Forms.Label lbWidthTitle;
        private System.Windows.Forms.Label lbHeightTitle;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Button btConfirm;
    }
}