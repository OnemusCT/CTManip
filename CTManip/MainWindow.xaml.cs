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
        private bool isBaseRngMode = false;
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

        private void ToggleBaseRNG(object sender, RoutedEventArgs e)
        {
            isBaseRngMode = BaseRngMenuItem.IsChecked;          
            PopulateManipButtons();
        }

        private void PopulateManipButtons()
        {
            ManipButtonsPanel.Children.Clear();

            if (isBaseRngMode)
            {
                // Create BaseRNG input interface
                var label = new Label
                {
                    Content = "Enter BaseRNG value (01-FF):",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(0, 10, 0, 5)
                };

                var textBox = new TextBox
                {
                    Name = "BaseRngTextBox",
                    Width = 50,
                    Height = 25,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    TextAlignment = TextAlignment.Center,
                    MaxLength = 2,
                    CharacterCasing = CharacterCasing.Upper,
                    Margin = new Thickness(0, 5, 0, 10)
                };
                textBox.KeyDown += BaseRngTextBox_KeyDown;

                var executeButton = new Button
                {
                    Content = "Execute",
                    Width = 50,
                    Height = 30,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(0, 10, 0, 10)
                };
                executeButton.Click += ExecuteBaseRngManip;

                var instructionLabel = new Label
                {
                    Content = "Valid range: 01 to FF",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    FontSize = 10,
                    Foreground = System.Windows.Media.Brushes.Gray,
                    Margin = new Thickness(0, 0, 0, 10)
                };
                var unixLabel = new Label
                {
                    Content = "Enter a Unix timestamp:",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(0, 10, 0, 5)
                };
                var unixTextBox = new TextBox
                {
                    Name = "UnixTimeTextBox",
                    Width = 100,
                    Height = 25,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    TextAlignment = TextAlignment.Center,
                    MaxLength = 10,
                    Margin = new Thickness(0, 5, 0, 10)
                };
                unixTextBox.KeyDown += UnixTimeTextBox_KeyDown;
                var unixExecuteButton = new Button
                {
                    Content = "Execute",
                    Width = 50,
                    Height = 30,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(0, 10, 0, 10)
                };
                unixExecuteButton.Click += ExecuteUnixManip;

                ManipButtonsPanel.Children.Add(label);
                ManipButtonsPanel.Children.Add(textBox);
                ManipButtonsPanel.Children.Add(executeButton);
                ManipButtonsPanel.Children.Add(instructionLabel);
                ManipButtonsPanel.Children.Add(unixLabel);
                ManipButtonsPanel.Children.Add(unixTextBox);
                ManipButtonsPanel.Children.Add(unixExecuteButton);

            }
            else
            {
                var normalManips = new[]
                {
                    "New Game", "Nagas", "Masamune", "Nizbel", "Flea", "Magus",
                    "Black Tyranno", "Woe Rubble", "Golem Twins", "Ghosts",
                    "Rust Rubbles", "Rust Tyranno", "Son of Sun", "Yakra XIII",
                    "Black Omen", "Lavos Shell", "Lavos Core"
                };

                foreach (var manip in normalManips)
                {
                    var button = new Button
                    {
                        Width = 150,
                        Content = manip,
                        Margin = new Thickness(0, 5, 0, 0)
                    };
                    button.Click += StartManip;
                    ManipButtonsPanel.Children.Add(button);
                }
            }
        }

        private void BaseRngTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ExecuteBaseRngManip(sender, new RoutedEventArgs());
            }
        }

        private void UnixTimeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ExecuteUnixManip(sender, new RoutedEventArgs());
            }
        }

        private void ExecuteUnixManip(object sender, RoutedEventArgs e)
        {
            TextBox textBox = null;
            foreach (var child in ManipButtonsPanel.Children)
            {
                if (child is TextBox tb)
                {
                    if(tb.Name.Equals("UnixTimeTextBox"))
                    {
                        textBox = tb;
                        break;
                    }
                }
            }

            if (textBox == null)
            {
                MessageBox.Show("Error: Could not find input field.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            } 

            long input = long.Parse(textBox.Text.Trim());
            //MessageBox.Show("" + input, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            ManipController.ExecuteManipFromUnixTime(input);
            
        }

        private void ExecuteBaseRngManip(object sender, RoutedEventArgs e)
        {
            // Find the text box in the current panel
            TextBox textBox = null;
            foreach (var child in ManipButtonsPanel.Children)
            {
                if (child is TextBox tb)
                {
                    textBox = tb;
                    break;
                }
            }

            if (textBox == null)
            {
                MessageBox.Show("Error: Could not find input field.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string input = textBox.Text.Trim().ToUpper();
            
            // Validate input
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a value.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                textBox.Focus();
                return;
            }

            // Ensure input is exactly 2 characters for hex values 01-FF
            if (input.Length == 1)
            {
                input = "0" + input;
                textBox.Text = input;
            }

            // Validate hex format and range
            if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-9A-F]{2}$"))
            {
                MessageBox.Show("Please enter a valid hexadecimal value (01-FF).", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                textBox.SelectAll();
                textBox.Focus();
                return;
            }

            // Convert hex to decimal to check range
            if (int.TryParse(input, System.Globalization.NumberStyles.HexNumber, null, out int value))
            {
                if (value < 1 || value > 255)
                {
                    MessageBox.Show("Value must be between 01 and FF (1-255).", "Invalid Range", MessageBoxButton.OK, MessageBoxImage.Warning);
                    textBox.SelectAll();
                    textBox.Focus();
                    return;
                }

                // Execute the BaseRNG manip
                string enumName = $"BaseRNG_{input}";
                if (Enum.TryParse<ManipList.ManipNames>(enumName, out var baseRngManip))
                {
                    ManipController.ExecuteManip(baseRngManip);
                }
                else
                {
                    MessageBox.Show($"BaseRNG manip {input} not found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid hexadecimal value.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                textBox.SelectAll();
                textBox.Focus();
            }
        }

        // offset UI and handlers removed
    }
}

