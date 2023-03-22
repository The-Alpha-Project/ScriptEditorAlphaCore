namespace ScriptEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiEditors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScripts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreatureEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreatureSpells = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConditions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFinders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAreaFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreatureFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEventFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFactionFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFactionTemplateFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGameObjectFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuestFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpellFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTaxiFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTextFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlags = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsGeneric = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFlagsGameObjectUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsGameObjectDynUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsUnitUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsUnitDynamicUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsNpcUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsPlayerUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsSpellMechanic = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LoadingBar = new System.Windows.Forms.ToolStripProgressBar();
            this.LoadingStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnWaypoints = new System.Windows.Forms.Button();
            this.btnScriptEditor = new System.Windows.Forms.Button();
            this.btnEventEditor = new System.Windows.Forms.Button();
            this.btnCastsEditor = new System.Windows.Forms.Button();
            this.btnConditionsEditor = new System.Windows.Forms.Button();
            this.btnCreatureEditor = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditors,
            this.tsmiFinders,
            this.tsmiHelpers});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // tsmiEditors
            // 
            this.tsmiEditors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiScripts,
            this.tsmiCreatureEvents,
            this.tsmiCreatureSpells,
            this.tsmiConditions});
            this.tsmiEditors.Name = "tsmiEditors";
            this.tsmiEditors.Size = new System.Drawing.Size(55, 20);
            this.tsmiEditors.Text = "Editors";
            // 
            // tsmiScripts
            // 
            this.tsmiScripts.Name = "tsmiScripts";
            this.tsmiScripts.Size = new System.Drawing.Size(156, 22);
            this.tsmiScripts.Text = "Scripts";
            // 
            // tsmiCreatureEvents
            // 
            this.tsmiCreatureEvents.Name = "tsmiCreatureEvents";
            this.tsmiCreatureEvents.Size = new System.Drawing.Size(156, 22);
            this.tsmiCreatureEvents.Text = "Creature Events";
            // 
            // tsmiCreatureSpells
            // 
            this.tsmiCreatureSpells.Name = "tsmiCreatureSpells";
            this.tsmiCreatureSpells.Size = new System.Drawing.Size(156, 22);
            this.tsmiCreatureSpells.Text = "Creature Spells";
            // 
            // tsmiConditions
            // 
            this.tsmiConditions.Name = "tsmiConditions";
            this.tsmiConditions.Size = new System.Drawing.Size(156, 22);
            this.tsmiConditions.Text = "Conditions";
            // 
            // tsmiFinders
            // 
            this.tsmiFinders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAreaFinder,
            this.tsmiCreatureFinder,
            this.tsmiEventFinder,
            this.tsmiFactionFinder,
            this.tsmiFactionTemplateFinder,
            this.tsmiGameObjectFinder,
            this.tsmiItemFinder,
            this.tsmiQuestFinder,
            this.tsmiSpellFinder,
            this.tsmiTaxiFinder,
            this.tsmiTextFinder});
            this.tsmiFinders.Name = "tsmiFinders";
            this.tsmiFinders.Size = new System.Drawing.Size(57, 20);
            this.tsmiFinders.Text = "Finders";
            // 
            // tsmiAreaFinder
            // 
            this.tsmiAreaFinder.Name = "tsmiAreaFinder";
            this.tsmiAreaFinder.Size = new System.Drawing.Size(164, 22);
            this.tsmiAreaFinder.Text = "Area";
            // 
            // tsmiCreatureFinder
            // 
            this.tsmiCreatureFinder.Name = "tsmiCreatureFinder";
            this.tsmiCreatureFinder.Size = new System.Drawing.Size(164, 22);
            this.tsmiCreatureFinder.Text = "Creature";
            // 
            // tsmiEventFinder
            // 
            this.tsmiEventFinder.Name = "tsmiEventFinder";
            this.tsmiEventFinder.Size = new System.Drawing.Size(164, 22);
            this.tsmiEventFinder.Text = "Event Finder";
            // 
            // tsmiFactionFinder
            // 
            this.tsmiFactionFinder.Name = "tsmiFactionFinder";
            this.tsmiFactionFinder.Size = new System.Drawing.Size(164, 22);
            this.tsmiFactionFinder.Text = "Faction";
            // 
            // tsmiFactionTemplateFinder
            // 
            this.tsmiFactionTemplateFinder.Name = "tsmiFactionTemplateFinder";
            this.tsmiFactionTemplateFinder.Size = new System.Drawing.Size(164, 22);
            this.tsmiFactionTemplateFinder.Text = "Faction Template";
            // 
            // tsmiGameObjectFinder
            // 
            this.tsmiGameObjectFinder.Name = "tsmiGameObjectFinder";
            this.tsmiGameObjectFinder.Size = new System.Drawing.Size(164, 22);
            this.tsmiGameObjectFinder.Text = "Game Object";
            // 
            // tsmiItemFinder
            // 
            this.tsmiItemFinder.Name = "tsmiItemFinder";
            this.tsmiItemFinder.Size = new System.Drawing.Size(164, 22);
            this.tsmiItemFinder.Text = "Item";
            // 
            // tsmiQuestFinder
            // 
            this.tsmiQuestFinder.Name = "tsmiQuestFinder";
            this.tsmiQuestFinder.Size = new System.Drawing.Size(164, 22);
            this.tsmiQuestFinder.Text = "Quest";
            // 
            // tsmiSpellFinder
            // 
            this.tsmiSpellFinder.Name = "tsmiSpellFinder";
            this.tsmiSpellFinder.Size = new System.Drawing.Size(164, 22);
            this.tsmiSpellFinder.Text = "Spell";
            // 
            // tsmiTaxiFinder
            // 
            this.tsmiTaxiFinder.Name = "tsmiTaxiFinder";
            this.tsmiTaxiFinder.Size = new System.Drawing.Size(164, 22);
            this.tsmiTaxiFinder.Text = "Taxi";
            // 
            // tsmiTextFinder
            // 
            this.tsmiTextFinder.Name = "tsmiTextFinder";
            this.tsmiTextFinder.Size = new System.Drawing.Size(164, 22);
            this.tsmiTextFinder.Text = "Broadcast Text";
            // 
            // tsmiHelpers
            // 
            this.tsmiHelpers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFlags});
            this.tsmiHelpers.Name = "tsmiHelpers";
            this.tsmiHelpers.Size = new System.Drawing.Size(59, 20);
            this.tsmiHelpers.Text = "Helpers";
            // 
            // tsmiFlags
            // 
            this.tsmiFlags.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFlagsGeneric,
            this.toolStripSeparator1,
            this.tsmiFlagsGameObjectUF,
            this.tsmiFlagsGameObjectDynUF,
            this.tsmiFlagsUnitUF,
            this.tsmiFlagsUnitDynamicUF,
            this.tsmiFlagsNpcUF,
            this.tsmiFlagsPlayerUF,
            this.tsmiFlagsSpellMechanic});
            this.tsmiFlags.Name = "tsmiFlags";
            this.tsmiFlags.Size = new System.Drawing.Size(101, 22);
            this.tsmiFlags.Text = "Flags";
            // 
            // tsmiFlagsGeneric
            // 
            this.tsmiFlagsGeneric.Name = "tsmiFlagsGeneric";
            this.tsmiFlagsGeneric.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsGeneric.Text = "Generic";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // tsmiFlagsGameObjectUF
            // 
            this.tsmiFlagsGameObjectUF.Name = "tsmiFlagsGameObjectUF";
            this.tsmiFlagsGameObjectUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsGameObjectUF.Text = "Game Object Flags (UF)";
            // 
            // tsmiFlagsGameObjectDynUF
            // 
            this.tsmiFlagsGameObjectDynUF.Name = "tsmiFlagsGameObjectDynUF";
            this.tsmiFlagsGameObjectDynUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsGameObjectDynUF.Text = "Game Object Dynamic (UF)";
            // 
            // tsmiFlagsUnitUF
            // 
            this.tsmiFlagsUnitUF.Name = "tsmiFlagsUnitUF";
            this.tsmiFlagsUnitUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsUnitUF.Text = "Unit (UF)";
            // 
            // tsmiFlagsUnitDynamicUF
            // 
            this.tsmiFlagsUnitDynamicUF.Name = "tsmiFlagsUnitDynamicUF";
            this.tsmiFlagsUnitDynamicUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsUnitDynamicUF.Text = "Unit Dynamic (UF)";
            // 
            // tsmiFlagsNpcUF
            // 
            this.tsmiFlagsNpcUF.Name = "tsmiFlagsNpcUF";
            this.tsmiFlagsNpcUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsNpcUF.Text = "NPC (UF)";
            // 
            // tsmiFlagsPlayerUF
            // 
            this.tsmiFlagsPlayerUF.Name = "tsmiFlagsPlayerUF";
            this.tsmiFlagsPlayerUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsPlayerUF.Text = "Player (UF)";
            // 
            // tsmiFlagsSpellMechanic
            // 
            this.tsmiFlagsSpellMechanic.Name = "tsmiFlagsSpellMechanic";
            this.tsmiFlagsSpellMechanic.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsSpellMechanic.Text = "Spell Mechanic";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadingBar,
            this.LoadingStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 388);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LoadingBar
            // 
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(100, 16);
            this.LoadingBar.Step = 11;
            // 
            // LoadingStatusText
            // 
            this.LoadingStatusText.BackColor = System.Drawing.SystemColors.Control;
            this.LoadingStatusText.Name = "LoadingStatusText";
            this.LoadingStatusText.Size = new System.Drawing.Size(62, 17);
            this.LoadingStatusText.Text = "Loading ...";
            // 
            // btnWaypoints
            // 
            this.btnWaypoints.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWaypoints.Location = new System.Drawing.Point(565, 47);
            this.btnWaypoints.Name = "btnWaypoints";
            this.btnWaypoints.Size = new System.Drawing.Size(129, 75);
            this.btnWaypoints.TabIndex = 4;
            this.btnWaypoints.Text = "Waypoints";
            this.btnWaypoints.UseVisualStyleBackColor = true;
            this.btnWaypoints.Click += new System.EventHandler(this.btnWaypoints_Click);
            // 
            // btnScriptEditor
            // 
            this.btnScriptEditor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnScriptEditor.Location = new System.Drawing.Point(25, 47);
            this.btnScriptEditor.Name = "btnScriptEditor";
            this.btnScriptEditor.Size = new System.Drawing.Size(129, 75);
            this.btnScriptEditor.TabIndex = 0;
            this.btnScriptEditor.Text = "Script Editor";
            this.btnScriptEditor.UseVisualStyleBackColor = true;
            this.btnScriptEditor.Click += new System.EventHandler(this.picScriptEditor_Click);
            // 
            // btnEventEditor
            // 
            this.btnEventEditor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEventEditor.Location = new System.Drawing.Point(160, 47);
            this.btnEventEditor.Name = "btnEventEditor";
            this.btnEventEditor.Size = new System.Drawing.Size(129, 75);
            this.btnEventEditor.TabIndex = 1;
            this.btnEventEditor.Text = "Event Editor";
            this.btnEventEditor.UseVisualStyleBackColor = true;
            this.btnEventEditor.Click += new System.EventHandler(this.picEventEditor_Click);
            // 
            // btnCastsEditor
            // 
            this.btnCastsEditor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCastsEditor.Location = new System.Drawing.Point(295, 47);
            this.btnCastsEditor.Name = "btnCastsEditor";
            this.btnCastsEditor.Size = new System.Drawing.Size(129, 75);
            this.btnCastsEditor.TabIndex = 2;
            this.btnCastsEditor.Text = "Casts Editor";
            this.btnCastsEditor.UseVisualStyleBackColor = true;
            this.btnCastsEditor.Click += new System.EventHandler(this.picCastsEditor_Click);
            // 
            // btnConditionsEditor
            // 
            this.btnConditionsEditor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConditionsEditor.Location = new System.Drawing.Point(430, 47);
            this.btnConditionsEditor.Name = "btnConditionsEditor";
            this.btnConditionsEditor.Size = new System.Drawing.Size(129, 75);
            this.btnConditionsEditor.TabIndex = 3;
            this.btnConditionsEditor.Text = "Conditions Editor";
            this.btnConditionsEditor.UseVisualStyleBackColor = true;
            this.btnConditionsEditor.Click += new System.EventHandler(this.picConditionEditor_Click);
            // 
            // btnCreatureEditor
            // 
            this.btnCreatureEditor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreatureEditor.Location = new System.Drawing.Point(25, 128);
            this.btnCreatureEditor.Name = "btnCreatureEditor";
            this.btnCreatureEditor.Size = new System.Drawing.Size(129, 75);
            this.btnCreatureEditor.TabIndex = 7;
            this.btnCreatureEditor.Text = "Creature Editor";
            this.btnCreatureEditor.UseVisualStyleBackColor = true;
            this.btnCreatureEditor.Click += new System.EventHandler(this.btnCreatureEditor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 410);
            this.Controls.Add(this.btnCreatureEditor);
            this.Controls.Add(this.btnConditionsEditor);
            this.Controls.Add(this.btnCastsEditor);
            this.Controls.Add(this.btnEventEditor);
            this.Controls.Add(this.btnScriptEditor);
            this.Controls.Add(this.btnWaypoints);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AlphaCore Developer Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditors;
        private System.Windows.Forms.ToolStripMenuItem tsmiScripts;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatureEvents;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatureSpells;
        private System.Windows.Forms.ToolStripMenuItem tsmiConditions;
        private System.Windows.Forms.ToolStripMenuItem tsmiFinders;
        private System.Windows.Forms.ToolStripMenuItem tsmiAreaFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatureFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiEventFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiFactionFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiFactionTemplateFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiGameObjectFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuestFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpellFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiTaxiFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiTextFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpers;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlags;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsGeneric;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsGameObjectUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsGameObjectDynUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsUnitUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsUnitDynamicUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsNpcUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsPlayerUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsSpellMechanic;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar LoadingBar;
        private System.Windows.Forms.ToolStripStatusLabel LoadingStatusText;
        private System.Windows.Forms.Button btnWaypoints;
        private System.Windows.Forms.Button btnScriptEditor;
        private System.Windows.Forms.Button btnEventEditor;
        private System.Windows.Forms.Button btnCastsEditor;
        private System.Windows.Forms.Button btnConditionsEditor;
        private System.Windows.Forms.Button btnCreatureEditor;
    }
}