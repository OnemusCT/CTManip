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
        public static short timeOffset = 0;

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

        // Check for valid positive and negative integers
        private static bool IsNumeric(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            // Allow a single hyphen for negative offsets
            if (text == "-")
            {
                return true;
            }
            if (text[0] == '-' && text.Length > 1)
            {
                return int.TryParse(text.Substring(1), out _);
            }
            return int.TryParse(text, out _);
        }
        
        // Check input is valid before registering or parsing it
        private void Offset_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Parse for valid input
            TextBox textBox = e.Source as TextBox;
            e.Handled = !IsNumeric(textBox.Text + e.Text);
            
            // Assign offset if input is valid
            if (short.TryParse(textBox.Text + e.Text, out short result))
            {
                timeOffset = result;
            }
        }

        private void Offset_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Invalidate spaces
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
            // Prevent pasting non-numeric values
            if (e.Key == Key.V && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                string clipboardText = Clipboard.GetText();
                e.Handled = !IsNumeric(clipboardText);
            }
        }
    }
}

