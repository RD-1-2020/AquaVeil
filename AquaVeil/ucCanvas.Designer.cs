﻿
namespace AquaVeil
{
    partial class ucCanvas
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCanvas));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lb_clear = new System.Windows.Forms.ToolStripLabel();
            this.lb_savefr = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this._main = new System.Windows.Forms.PictureBox();
            this.SB_frame = new System.Windows.Forms.HScrollBar();
            this.pb_cadr_list = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.FileSave = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cadr_list)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(857, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.lb_clear,
            this.lb_savefr,
            this.FileSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(857, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lb_clear
            // 
            this.lb_clear.Name = "lb_clear";
            this.lb_clear.Size = new System.Drawing.Size(59, 22);
            this.lb_clear.Text = "Очистить";
            this.lb_clear.Click += new System.EventHandler(this.lb_clear_Click);
            // 
            // lb_savefr
            // 
            this.lb_savefr.Name = "lb_savefr";
            this.lb_savefr.Size = new System.Drawing.Size(94, 22);
            this.lb_savefr.Text = "Сохранить кадр";
            this.lb_savefr.Click += new System.EventHandler(this.lb_savefr_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
            this.splitContainer1.Panel1.Controls.Add(this._main);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitContainer1.Panel2.Controls.Add(this.SB_frame);
            this.splitContainer1.Panel2.Controls.Add(this.pb_cadr_list);
            this.splitContainer1.Size = new System.Drawing.Size(857, 451);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 2;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(695, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(162, 377);
            this.propertyGrid1.TabIndex = 1;
            // 
            // _main
            // 
            this._main.BackColor = System.Drawing.Color.Silver;
            this._main.Dock = System.Windows.Forms.DockStyle.Fill;
            this._main.Location = new System.Drawing.Point(0, 0);
            this._main.Name = "_main";
            this._main.Size = new System.Drawing.Size(857, 377);
            this._main.TabIndex = 0;
            this._main.TabStop = false;
            this._main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // SB_frame
            // 
            this.SB_frame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SB_frame.LargeChange = 50;
            this.SB_frame.Location = new System.Drawing.Point(0, 55);
            this.SB_frame.Maximum = 1000;
            this.SB_frame.Name = "SB_frame";
            this.SB_frame.Size = new System.Drawing.Size(857, 15);
            this.SB_frame.TabIndex = 2;
            this.SB_frame.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SB_frame_Scroll);
            // 
            // pb_cadr_list
            // 
            this.pb_cadr_list.BackColor = System.Drawing.Color.Silver;
            this.pb_cadr_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_cadr_list.Location = new System.Drawing.Point(0, 0);
            this.pb_cadr_list.Name = "pb_cadr_list";
            this.pb_cadr_list.Size = new System.Drawing.Size(857, 70);
            this.pb_cadr_list.TabIndex = 0;
            this.pb_cadr_list.TabStop = false;
            this.pb_cadr_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_cadr_list_MouseClick);
            // 
            // FileSave
            // 
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(103, 22);
            this.FileSave.Text = "Сохранить кадры";
            this.FileSave.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // ucCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ucCanvas";
            this.Size = new System.Drawing.Size(857, 498);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cadr_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox _main;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.PictureBox pb_cadr_list;
        private System.Windows.Forms.ToolStripLabel lb_clear;
        public System.Windows.Forms.ToolStripLabel lb_savefr;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.HScrollBar SB_frame;
        private System.Windows.Forms.ToolStripLabel FileSave;
    }
}
