﻿namespace TeteHardware
{
    partial class formViews
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblParent = new System.Windows.Forms.Label();
            this.comboParent = new System.Windows.Forms.ComboBox();
            this.comboChild = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridTable = new System.Windows.Forms.DataGridView();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.monCalFrom = new System.Windows.Forms.MonthCalendar();
            this.monCalTo = new System.Windows.Forms.MonthCalendar();
            this.datagridTableChild = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTableChild)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblParent.Location = new System.Drawing.Point(30, 73);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(90, 19);
            this.lblParent.TabIndex = 0;
            this.lblParent.Text = "Parent Table";
            // 
            // comboParent
            // 
            this.comboParent.FormattingEnabled = true;
            this.comboParent.Location = new System.Drawing.Point(37, 99);
            this.comboParent.Name = "comboParent";
            this.comboParent.Size = new System.Drawing.Size(228, 27);
            this.comboParent.TabIndex = 1;
            this.comboParent.SelectedIndexChanged += new System.EventHandler(this.comboParent_SelectedIndexChanged);
            // 
            // comboChild
            // 
            this.comboChild.FormattingEnabled = true;
            this.comboChild.Location = new System.Drawing.Point(284, 99);
            this.comboChild.Name = "comboChild";
            this.comboChild.Size = new System.Drawing.Size(235, 27);
            this.comboChild.TabIndex = 3;
            this.comboChild.SelectedIndexChanged += new System.EventHandler(this.comboChild_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(277, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Child Table";
            // 
            // datagridTable
            // 
            this.datagridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTable.Location = new System.Drawing.Point(34, 129);
            this.datagridTable.Name = "datagridTable";
            this.datagridTable.ReadOnly = true;
            this.datagridTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTable.Size = new System.Drawing.Size(485, 388);
            this.datagridTable.TabIndex = 4;
            this.datagridTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridTable_CellClick);
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDateTo.Location = new System.Drawing.Point(277, 6);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(63, 19);
            this.lblDateTo.TabIndex = 7;
            this.lblDateTo.Text = "Date To:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDateFrom.Location = new System.Drawing.Point(30, 6);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(79, 19);
            this.lblDateFrom.TabIndex = 5;
            this.lblDateFrom.Text = "Date From:";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(38, 31);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(199, 25);
            this.txtDateFrom.TabIndex = 8;
            this.txtDateFrom.Enter += new System.EventHandler(this.txtDateFrom_Enter);
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(284, 31);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(199, 25);
            this.txtDateTo.TabIndex = 9;
            this.txtDateTo.Enter += new System.EventHandler(this.txtDateTo_Enter);
            // 
            // monCalFrom
            // 
            this.monCalFrom.Location = new System.Drawing.Point(542, 454);
            this.monCalFrom.Name = "monCalFrom";
            this.monCalFrom.TabIndex = 10;
            this.monCalFrom.Visible = false;
            this.monCalFrom.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monCalFrom_DateSelected);
            // 
            // monCalTo
            // 
            this.monCalTo.Location = new System.Drawing.Point(771, 454);
            this.monCalTo.Name = "monCalTo";
            this.monCalTo.TabIndex = 11;
            this.monCalTo.Visible = false;
            this.monCalTo.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monCalTo_DateSelected);
            // 
            // datagridTableChild
            // 
            this.datagridTableChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTableChild.Location = new System.Drawing.Point(542, 46);
            this.datagridTableChild.Name = "datagridTableChild";
            this.datagridTableChild.ReadOnly = true;
            this.datagridTableChild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTableChild.Size = new System.Drawing.Size(743, 471);
            this.datagridTableChild.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(538, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Details :";
            // 
            // formViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1297, 532);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridTableChild);
            this.Controls.Add(this.monCalTo);
            this.Controls.Add(this.monCalFrom);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.datagridTable);
            this.Controls.Add(this.comboChild);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboParent);
            this.Controls.Add(this.lblParent);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formViews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formViews_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formViews_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formViews_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formViews_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.datagridTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTableChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.ComboBox comboParent;
        private System.Windows.Forms.ComboBox comboChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridTable;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.MonthCalendar monCalFrom;
        private System.Windows.Forms.MonthCalendar monCalTo;
        private System.Windows.Forms.DataGridView datagridTableChild;
        private System.Windows.Forms.Label label2;
    }
}