﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Reflection;

namespace ScriptEditor
{
    static class Program
    {
        // MySQL connection data.
        public static string connString = "Server=localhost;Database=mangos;Port=3306;Uid=root;Pwd=root;";
        public static string mysqlUser = "root";
        public static string mysqlPass = "root";
        public static string mysqlHost = "localhost";
        public static string mysqlPort = "3306";
        public static string mysqlDB = "mangos";

        // Highlight non-default values.
        public static bool highlight = false;

        // Desired culture info.
        public static string locale = "en-US";

        internal sealed class NativeMethods
        {
            [DllImport("kernel32.dll")]
            public static extern bool AllocConsole();

            [DllImport("kernel32.dll")]
            public static extern bool FreeConsole();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadConfig();

            // Open a console window so the user can see loading progress.
            NativeMethods.AllocConsole();
            Console.WriteLine("Please wait while loading the database.\n");

            // Load content from the database.
            Console.WriteLine("Loading texts...");
            GameData.LoadBroadcastTexts(connString, "alpha_world");
            Console.WriteLine("Loading quests...");
            GameData.LoadQuests(connString, "alpha_world");
            Console.WriteLine("Loading gameobjects...");
            GameData.LoadGameObjects(connString, "alpha_world");
            Console.WriteLine("Loading creatures...");
            GameData.LoadCreatures(connString, "alpha_world");
            Console.WriteLine("Loading spells...");
            GameData.LoadSpells(connString, "alpha_dbc");
            Console.WriteLine("Loading items...");
            GameData.LoadItems(connString, "alpha_world");
            Console.WriteLine("Loading conditions...");
            GameData.LoadCondition(connString, "alpha_world");
            Console.WriteLine("Loading areas...");
            GameData.LoadAreas(connString, "alpha_world");
            // Console.WriteLine("Loading sounds...");
            // GameData.LoadSounds(connString, "alpha_dbc");
            Console.WriteLine("Loading factions...");
            GameData.LoadFactions(connString, "alpha_dbc");
            GameData.LoadFactionTemplates(connString, "alpha_dbc");
            // Console.WriteLine("Loading game events...");
            // GameData.LoadGameEvents(connString, "alpha_world");
            Console.WriteLine("Loading creature spells...");
            GameData.LoadCreatureSpells(connString, "alpha_world");

            // Closes the temporary console window.
            NativeMethods.FreeConsole();

            // Apply locale settings.
            SetDefaultCulture(new CultureInfo(locale));

            // Start the main form.
            Application.Run(new Form1());
        }

        private static void LoadConfig()
        {
            if (!System.IO.File.Exists(@"config.ini"))
            {
                MessageBox.Show("Your config file seems to have vanished into the nether! But worry not, i shall use my ultra-safe mind reading device to guess your database connection details. Surely nothing can go wrong, gnomish inventions are renowned for their safety after all!", "No config found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"config.ini");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("User="))
                    mysqlUser = line.Replace("User=", "");
                else if (line.Contains("Pass="))
                    mysqlPass = line.Replace("Pass=", "");
                else if (line.Contains("Host="))
                    mysqlHost = line.Replace("Host=", "");
                else if (line.Contains("Port="))
                    mysqlPort = line.Replace("Port=", "");
                else if (line.Contains("DB="))
                    mysqlDB = line.Replace("DB=", "");
                else if (line.Contains("Locale="))
                    locale = line.Replace("Locale=", "");
                else if (line.Contains("Highlight=true"))
                    highlight = true;
            }

            connString = "Server=" + mysqlHost + ";Database={0};Port=" + mysqlPort + ";Uid=" + mysqlUser + ";Pwd=" + mysqlPass + ";";
        }

        static void SetDefaultCulture(CultureInfo culture)
        {
            Type type = typeof(CultureInfo);

            try
            {
                type.InvokeMember("s_userDefaultCulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });

                type.InvokeMember("s_userDefaultUICulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });
            }
            catch { }

            try
            {
                type.InvokeMember("m_userDefaultCulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });

                type.InvokeMember("m_userDefaultUICulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });
            }
            catch { }
        }
    }
}
