
namespace AquaVeilV1.Forms
{
    partial class fSwingSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSwingSettings));
            this.spMain = new System.Windows.Forms.SplitContainer();
            this.spSettingsField1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPause = new System.Windows.Forms.NumericUpDown();
            this.nudClear = new System.Windows.Forms.NumericUpDown();
            this.nudLatch = new System.Windows.Forms.NumericUpDown();
            this.nudClk = new System.Windows.Forms.NumericUpDown();
            this.nudData = new System.Windows.Forms.NumericUpDown();
            this.spBottom = new System.Windows.Forms.SplitContainer();
            this.btSave = new System.Windows.Forms.Button();
            this.spSubBottom = new System.Windows.Forms.SplitContainer();
            this.btSetDefault = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).BeginInit();
            this.spMain.Panel1.SuspendLayout();
            this.spMain.Panel2.SuspendLayout();
            this.spMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSettingsField1)).BeginInit();
            this.spSettingsField1.Panel1.SuspendLayout();
            this.spSettingsField1.Panel2.SuspendLayout();
            this.spSettingsField1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBottom)).BeginInit();
            this.spBottom.Panel1.SuspendLayout();
            this.spBottom.Panel2.SuspendLayout();
            this.spBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSubBottom)).BeginInit();
            this.spSubBottom.Panel1.SuspendLayout();
            this.spSubBottom.Panel2.SuspendLayout();
            this.spSubBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // spMain
            // 
            this.spMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spMain.IsSplitterFixed = true;
            this.spMain.Location = new System.Drawing.Point(0, 0);
            this.spMain.Name = "spMain";
            this.spMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spMain.Panel1
            // 
            this.spMain.Panel1.Controls.Add(this.spSettingsField1);
            // 
            // spMain.Panel2
            // 
            this.spMain.Panel2.Controls.Add(this.spBottom);
            this.spMain.Size = new System.Drawing.Size(796, 450);
            this.spMain.SplitterDistance = 348;
            this.spMain.SplitterWidth = 1;
            this.spMain.TabIndex = 0;
            // 
            // spSettingsField1
            // 
            this.spSettingsField1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spSettingsField1.Location = new System.Drawing.Point(0, 0);
            this.spSettingsField1.Name = "spSettingsField1";
            // 
            // spSettingsField1.Panel1
            // 
            this.spSettingsField1.Panel1.Controls.Add(this.label5);
            this.spSettingsField1.Panel1.Controls.Add(this.label4);
            this.spSettingsField1.Panel1.Controls.Add(this.label3);
            this.spSettingsField1.Panel1.Controls.Add(this.label2);
            this.spSettingsField1.Panel1.Controls.Add(this.label1);
            // 
            // spSettingsField1.Panel2
            // 
            this.spSettingsField1.Panel2.Controls.Add(this.nudPause);
            this.spSettingsField1.Panel2.Controls.Add(this.nudClear);
            this.spSettingsField1.Panel2.Controls.Add(this.nudLatch);
            this.spSettingsField1.Panel2.Controls.Add(this.nudClk);
            this.spSettingsField1.Panel2.Controls.Add(this.nudData);
            this.spSettingsField1.Size = new System.Drawing.Size(794, 346);
            this.spSettingsField1.SplitterDistance = 137;
            this.spSettingsField1.SplitterWidth = 1;
            this.spSettingsField1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "tic_Pause";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "tic_Clear";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "tic_Latch";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "tic_clk";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "tic_Data";
            // 
            // nudPause
            // 
            this.nudPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudPause.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPause.Location = new System.Drawing.Point(0, 104);
            this.nudPause.Name = "nudPause";
            this.nudPause.Size = new System.Drawing.Size(656, 26);
            this.nudPause.TabIndex = 4;
            // 
            // nudClear
            // 
            this.nudClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudClear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudClear.Location = new System.Drawing.Point(0, 78);
            this.nudClear.Name = "nudClear";
            this.nudClear.Size = new System.Drawing.Size(656, 26);
            this.nudClear.TabIndex = 3;
            // 
            // nudLatch
            // 
            this.nudLatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudLatch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudLatch.Location = new System.Drawing.Point(0, 52);
            this.nudLatch.Name = "nudLatch";
            this.nudLatch.Size = new System.Drawing.Size(656, 26);
            this.nudLatch.TabIndex = 2;
            // 
            // nudClk
            // 
            this.nudClk.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudClk.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudClk.Location = new System.Drawing.Point(0, 26);
            this.nudClk.Name = "nudClk";
            this.nudClk.Size = new System.Drawing.Size(656, 26);
            this.nudClk.TabIndex = 1;
            // 
            // nudData
            // 
            this.nudData.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudData.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudData.Location = new System.Drawing.Point(0, 0);
            this.nudData.Name = "nudData";
            this.nudData.Size = new System.Drawing.Size(656, 26);
            this.nudData.TabIndex = 0;
            // 
            // spBottom
            // 
            this.spBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spBottom.IsSplitterFixed = true;
            this.spBottom.Location = new System.Drawing.Point(0, 0);
            this.spBottom.Name = "spBottom";
            // 
            // spBottom.Panel1
            // 
            this.spBottom.Panel1.Controls.Add(this.btSave);
            // 
            // spBottom.Panel2
            // 
            this.spBottom.Panel2.Controls.Add(this.spSubBottom);
            this.spBottom.Size = new System.Drawing.Size(794, 99);
            this.spBottom.SplitterDistance = 252;
            this.spBottom.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSave.Location = new System.Drawing.Point(0, 0);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(252, 99);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Сохранить и закрыть";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // spSubBottom
            // 
            this.spSubBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spSubBottom.IsSplitterFixed = true;
            this.spSubBottom.Location = new System.Drawing.Point(0, 0);
            this.spSubBottom.Name = "spSubBottom";
            // 
            // spSubBottom.Panel1
            // 
            this.spSubBottom.Panel1.Controls.Add(this.btSetDefault);
            // 
            // spSubBottom.Panel2
            // 
            this.spSubBottom.Panel2.Controls.Add(this.btSend);
            this.spSubBottom.Size = new System.Drawing.Size(538, 99);
            this.spSubBottom.SplitterDistance = 261;
            this.spSubBottom.TabIndex = 0;
            // 
            // btSetDefault
            // 
            this.btSetDefault.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSetDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSetDefault.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSetDefault.Location = new System.Drawing.Point(0, 0);
            this.btSetDefault.Name = "btSetDefault";
            this.btSetDefault.Size = new System.Drawing.Size(261, 99);
            this.btSetDefault.TabIndex = 1;
            this.btSetDefault.Text = "Откатить на стандартные";
            this.btSetDefault.UseVisualStyleBackColor = false;
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSend.Location = new System.Drawing.Point(0, 0);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(273, 99);
            this.btSend.TabIndex = 1;
            this.btSend.Text = "Отправить настройки на качели";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // fSwingSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.spMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSwingSettings";
            this.Text = "Подстройка параметров качелей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fSwingSettings_FormClosed);
            this.Load += new System.EventHandler(this.fSwingSettings_Load);
            this.spMain.Panel1.ResumeLayout(false);
            this.spMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).EndInit();
            this.spMain.ResumeLayout(false);
            this.spSettingsField1.Panel1.ResumeLayout(false);
            this.spSettingsField1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spSettingsField1)).EndInit();
            this.spSettingsField1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudData)).EndInit();
            this.spBottom.Panel1.ResumeLayout(false);
            this.spBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spBottom)).EndInit();
            this.spBottom.ResumeLayout(false);
            this.spSubBottom.Panel1.ResumeLayout(false);
            this.spSubBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spSubBottom)).EndInit();
            this.spSubBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spMain;
        private System.Windows.Forms.SplitContainer spBottom;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.SplitContainer spSubBottom;
        private System.Windows.Forms.Button btSetDefault;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.SplitContainer spSettingsField1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPause;
        private System.Windows.Forms.NumericUpDown nudClear;
        private System.Windows.Forms.NumericUpDown nudLatch;
        private System.Windows.Forms.NumericUpDown nudClk;
        private System.Windows.Forms.NumericUpDown nudData;
    }
}