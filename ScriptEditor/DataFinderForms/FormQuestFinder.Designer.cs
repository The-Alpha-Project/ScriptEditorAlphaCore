﻿namespace ScriptEditor
{
    partial class FormQuestFinder
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
            this.columnMinLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuestLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMinLevel,
            this.columnQuestLevel,
            this.columnTitle});
            // 
            // columnMinLevel
            // 
            this.columnMinLevel.Text = "Minimum Level";
            this.columnMinLevel.Width = 90;
            // 
            // columnQuestLevel
            // 
            this.columnQuestLevel.Text = "Quest Level";
            this.columnQuestLevel.Width = 90;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.Width = 415;
            // 
            // FormQuestFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 393);
            this.Name = "FormQuestFinder";
            this.Text = "Quest Finder";
            this.Shown += new System.EventHandler(this.FormQuestFinder_Shown);
            this.ResizeEnd += new System.EventHandler(this.FormQuestFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnMinLevel;
        private System.Windows.Forms.ColumnHeader columnQuestLevel;
        private System.Windows.Forms.ColumnHeader columnTitle;
    }
}
