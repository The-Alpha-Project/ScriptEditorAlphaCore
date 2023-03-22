using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class Form1 : Form
    {
        bool dataLoaded = false;

        private bool CheckDBConnection()
        {
            MySqlConnection conn = new MySqlConnection(string.Format(Program.connString, "alpha_world"));            
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to the database server. MySQL error message:\n\n" + ex.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private bool AreSniffsAvailable()
        {
            MySqlConnection conn = new MySqlConnection(string.Format(Program.connString, Program.sniffsDB));
            try
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "show tables";
                MySqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    string txt = reader.GetString(0);
                    if (txt.ToLower() == "creature_spell_timers") return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task<bool> LoadData()
        {
            IProgress<int> progress = new Progress<int>(value => { LoadingBar.PerformStep(); });
            List<LoadingAction> loadingActions = new List<LoadingAction>();
            loadingActions.Add(new LoadingAction(() => GameData.LoadBroadcastTexts(Program.connString, "alpha_world"), "Loading broadcast texts ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadQuests(Program.connString, "alpha_world"), "Loading quests ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadGameObjects(Program.connString, "alpha_world"), "Loading game objects ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadCreatures(Program.connString, "alpha_world"), "Loading creatures ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadSpells(Program.connString, "alpha_dbc"), "Loading spells ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadItems(Program.connString, "alpha_world"), "Loading items ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadCondition(Program.connString, "alpha_world"), "Loading conditions ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadAreas(Program.connString, "alpha_world"), "Loading areas ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadFactions(Program.connString, "alpha_dbc"), "Loading factions ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadFactionTemplates(Program.connString, "alpha_dbc"), "Loading faction templates ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadCreatureSpells(Program.connString, "alpha_world"), "Loading creature spells ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadCreatureMovement(Program.connString, "alpha_world"), "Loading creature movement ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadCreatureMovementSpecial(Program.connString, "alpha_world"), "Loading creature movement special ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadCreatureMovementTemplate(Program.connString, "alpha_world"), "Loading creature movement templates ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadCreatureSpellsSniffs(Program.connString, "sniffs_combined5"), "Loading creature spell sniffs ..."));
            loadingActions.Add(new LoadingAction(() => GameData.LoadCreatureDisplayInfo(Program.connString, "alpha_dbc"), "Loading creature display info ..."));

            LoadingBar.Step = loadingActions.Count;

            await Task.Run(() =>
            {
                foreach(LoadingAction _action in loadingActions) 
                {
                    LoadingStatusText.Text = _action.IndicatorText;
                    _action.Action();
                    progress.Report(1);
                }

                dataLoaded = true;
            });

            return true;
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void picScriptEditor_Click(object sender, EventArgs e)
        {
            if (!dataLoaded) return;
            FormScriptEditor editor = new FormScriptEditor();
            editor.Show();
        }

        private void picEventEditor_Click(object sender, EventArgs e)
        {
            if (!dataLoaded) return;
            FormEventEditor editor = new FormEventEditor();
            editor.Show();
        }

        private void picCastsEditor_Click(object sender, EventArgs e)
        {
            if (!dataLoaded) return;
            FormCastsEditor editor = new FormCastsEditor();
            editor.Show();
        }

        private void picConditionEditor_Click(object sender, EventArgs e)
        {
            if (!dataLoaded) return;
            FormConditionFinder editor = new FormConditionFinder();
            editor.ShowStandalone();
        }

        private async void Form1_Load(object _sender, EventArgs _e)
        {
            if (!CheckDBConnection()) Application.Exit();

            Program.sniffsInstalled = AreSniffsAvailable();

            await LoadData();

            LoadingBar.Visible = false;
            menuStrip1.Visible = true;
            statusStrip1.Visible = false;

            // Assign event handlers to menu items

            // Editors
            tsmiScripts.Click += picScriptEditor_Click;
            tsmiCreatureEvents.Click += picEventEditor_Click;
            tsmiCreatureSpells.Click += picCastsEditor_Click;
            tsmiConditions.Click += picConditionEditor_Click;

            // Finders
            tsmiAreaFinder.Click += (sender, e) =>
            {
                FormAreaFinder finder = new FormAreaFinder();
                finder.ShowDialog();
            };
            tsmiCreatureFinder.Click += (sender, e) =>
            {
                FormCreatureFinder finder = new FormCreatureFinder();
                finder.ShowDialog();
            };
            tsmiEventFinder.Click += (sender, e) =>
            {
                FormEventFinder finder = new FormEventFinder();
                finder.ShowDialog();
            };
            tsmiFactionFinder.Click += (sender, e) =>
            {
                FormFactionFinder finder = new FormFactionFinder();
                finder.ShowDialog();
            };
            tsmiFactionTemplateFinder.Click += (sender, e) =>
            {
                FormFactionTemplateFinder finder = new FormFactionTemplateFinder();
                finder.ShowDialog();
            };
            tsmiGameObjectFinder.Click += (sender, e) =>
            {
                FormGameObjectFinder finder = new FormGameObjectFinder();
                finder.ShowDialog();
            };
            tsmiItemFinder.Click += (sender, e) =>
            {
                FormItemFinder finder = new FormItemFinder();
                finder.ShowDialog();
            };
            tsmiQuestFinder.Click += (sender, e) =>
            {
                FormQuestFinder finder = new FormQuestFinder();
                finder.ShowDialog();
            };
            tsmiSpellFinder.Click += (sender, e) =>
            {
                FormSpellFinder finder = new FormSpellFinder();
                finder.ShowDialog();
            };
            tsmiTaxiFinder.Click += (sender, e) =>
            {
                FormTaxiFinder finder = new FormTaxiFinder();
                finder.ShowDialog();
            };
            tsmiTextFinder.Click += (sender, e) =>
            {
                FormTextFinder finder = new FormTextFinder();
                finder.ShowDialog();
            };

            // Helpers
            tsmiFlagsGameObjectDynUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Game Object Dynamic Flags (UF)", GameData.GameObjectDynFlagsList);
            };
            tsmiFlagsGameObjectUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Game Object Flags (UF)", GameData.GameObjectFlagsList);
            };
            tsmiFlagsGeneric.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Generic Flags", null);
            };
            tsmiFlagsNpcUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "NPC Flags (UF)", GameData.UnitNpcFlagsList);
            };
            tsmiFlagsPlayerUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Player Flags (UF)", GameData.UnitNpcFlagsList);
            };
            tsmiFlagsSpellMechanic.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Spell Mechanic Mask", GameData.SpellMechanicMaskList);
            };
            tsmiFlagsUnitDynamicUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Unit Dynamic Flags (UF)", GameData.UnitDynamicFlagsList);
            };
            tsmiFlagsUnitUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Unit Flags (UF)", GameData.UnitFieldFlagsList);
            };

        }

        private void btnWaypoints_Click(object sender, EventArgs e)
        {
            FormWaypointEditor form = new FormWaypointEditor();
            form.ShowDialog();
        }

        private void btnCreatureEditor_Click(object sender, EventArgs e)
        {
            FormCreatureEditor form = new FormCreatureEditor();
            form.ShowDialog();
        }
    }
}
