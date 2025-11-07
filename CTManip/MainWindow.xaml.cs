using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Input;

namespace CTManip
{
    public partial class MainWindow : Window
    {
        public static string AppVersion
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                var infoAttr = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
                string version = infoAttr?.InformationalVersion ?? assembly.GetName().Version?.ToString() ?? "0.0";
                return $"Version {version}";
            }
        }
        public ManipController ManipController = new ManipController();
        public static string systemDateFormat;
    // offset removed

        public MainWindow()
        {
            InitializeComponent();
            systemDateFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            InitializeTimeService();
        }

        // Verify time service is active to enable /resync
        public void InitializeTimeService()
        {
            string args = "start w32time";
            using (Process startTimeService = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "net.exe",
                    Arguments = args,
                    CreateNoWindow = true,
                    UseShellExecute = true,
                    Verb = "runas",
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            })
            {
                startTimeService.Start();
                startTimeService.WaitForExit();
            }
        }

        private void StartManip(object sender, RoutedEventArgs args)
        {
            Dictionary<string, ManipList.ManipNames> inputToManipMap = new Dictionary<string, ManipList.ManipNames>
            {
                { "New Game", ManipList.ManipNames.NewGame },
                { "Nagas", ManipList.ManipNames.Nagas },
                { "Zombor", ManipList.ManipNames.Zombor },
                { "Masamune", ManipList.ManipNames.Masamune },
                { "Nizbel", ManipList.ManipNames.Nizbel },
                { "Flea", ManipList.ManipNames.Flea },
                { "Magus", ManipList.ManipNames.Magus },
                { "Nizbel 2", ManipList.ManipNames.Nizbel2 },
                { "Black Tyranno", ManipList.ManipNames.BlackTyranno },
                { "Mud Imp", ManipList.ManipNames.MudImp },
                { "Woe Rubble", ManipList.ManipNames.WoeRubble },
                { "Golem Twins", ManipList.ManipNames.GolemTwins },
                { "Ghosts", ManipList.ManipNames.Ghosts },
                { "Rust Rubbles", ManipList.ManipNames.RustRubbles },
                { "Rust Tyranno", ManipList.ManipNames.RustTyranno },
                { "Son of Sun", ManipList.ManipNames.SonOfSun },
                { "Yakra XIII", ManipList.ManipNames.YakraXIII },
                { "Black Omen", ManipList.ManipNames.BlackOmen },
                { "Lavos Shell", ManipList.ManipNames.LavosShell },
                { "Lavos Core", ManipList.ManipNames.LavosCore }
            };
            
            string? buttonText = (args.Source as Button).Content.ToString(); // Text on the button
            
            if (inputToManipMap.ContainsKey(buttonText))
            { 
                ManipController.ExecuteManip(inputToManipMap[buttonText]);
            }
            else
            {
                throw new NotSupportedException(sender + " not a recognised or implemented manip");
            }
        }

        // offset UI and handlers removed
    }
}

