using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lists_4___Kaartgokker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<List<string>> _cardDeck = new List<List<string>>()
        {
            new List<string> {"Rood", "Harten 1" },
            new List<string> {"Rood", "Harten 2" },
            new List<string> {"Rood", "Harten 3" },
            new List<string> {"Rood", "Harten 4" },
            new List<string> {"Rood", "Harten 5" },
            new List<string> {"Rood", "Harten 6" },
            new List<string> {"Rood", "Harten 7" },
            new List<string> {"Rood", "Harten 8" },
            new List<string> {"Rood", "Harten 9" },
            new List<string> {"Rood", "Harten 10" },
            new List<string> {"Rood", "Harten boer" },
            new List<string> {"Rood", "Harten dame" },
            new List<string> {"Rood", "Harten heer" },
            new List<string> {"Rood", "Ruiten 1" },
            new List<string> {"Rood", "Ruiten 2" },
            new List<string> {"Rood", "Ruiten 3" },
            new List<string> {"Rood", "Ruiten 4" },
            new List<string> {"Rood", "Ruiten 5" },
            new List<string> {"Rood", "Ruiten 6" },
            new List<string> {"Rood", "Ruiten 7" },
            new List<string> {"Rood", "Ruiten 8" },
            new List<string> {"Rood", "Ruiten 9" },
            new List<string> {"Rood", "Ruiten 10" },
            new List<string> {"Rood", "Ruiten boer" },
            new List<string> {"Rood", "Ruiten dame" },
            new List<string> {"Rood", "Ruiten heer" },
            new List<string> {"Zwart", "Schuppen 1" },
            new List<string> {"Zwart", "Schuppen 2" },
            new List<string> {"Zwart", "Schuppen 3" },
            new List<string> {"Zwart", "Schuppen 4" },
            new List<string> {"Zwart", "Schuppen 5" },
            new List<string> {"Zwart", "Schuppen 6" },
            new List<string> {"Zwart", "Schuppen 7" },
            new List<string> {"Zwart", "Schuppen 8" },
            new List<string> {"Zwart", "Schuppen 9" },
            new List<string> {"Zwart", "Schuppen 10" },
            new List<string> {"Zwart", "Schuppen boer" },
            new List<string> {"Zwart", "Schuppen dame" },
            new List<string> {"Zwart", "Schuppen heer" },
            new List<string> {"Zwart", "Klaveren 1" },
            new List<string> {"Zwart", "Klaveren 2" },
            new List<string> {"Zwart", "Klaveren 3" },
            new List<string> {"Zwart", "Klaveren 4" },
            new List<string> {"Zwart", "Klaveren 5" },
            new List<string> {"Zwart", "Klaveren 6" },
            new List<string> {"Zwart", "Klaveren 7" },
            new List<string> {"Zwart", "Klaveren 8" },
            new List<string> {"Zwart", "Klaveren 9" },
            new List<string> {"Zwart", "Klaveren 10" },
            new List<string> {"Zwart", "Klaveren boer" },
            new List<string> {"Zwart", "Klaveren dame" },
            new List<string> {"Zwart", "Klaveren heer" }
        };

        int _total = 1000;
        int _gamble = 0;

        public MainWindow()
        {
            InitializeComponent();
            FilllComboBox();
            ShowTotal();
        }

        private void FilllComboBox()
        {
            ComboBoxItem hearts = new ComboBoxItem();
            hearts.Name = "Rood";
            hearts.Content = "Harten";
            colorComboBox.Items.Add(hearts);

            ComboBoxItem diamonds = new ComboBoxItem();
            diamonds.Name = "Rood";
            diamonds.Content = "Ruiten";
            colorComboBox.Items.Add(diamonds);

            ComboBoxItem clubs = new ComboBoxItem();
            clubs.Name = "Zwart";
            clubs.Content = "Klaveren";
            colorComboBox.Items.Add(clubs);

            ComboBoxItem spades = new ComboBoxItem();
            spades.Name = "Zwart";
            spades.Content = "Schuppen";
            colorComboBox.Items.Add(spades);
        }

        private void ShowTotal()
        {
            //colorComboBox.SelectedIndex = -1;
            //gambleTextBox.Clear();
            totalLabel.Content = _total;
        }

        private bool CheckGamble()
        {
            if (colorComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("U moet een kleur kiezen!");
                return false;
            }
            if (!int.TryParse(gambleTextBox.Text, out _gamble))
            {
                MessageBox.Show("Inzet moet een getal zijn!");
                return false;
            }
            if (_gamble > _total)
            {
                MessageBox.Show("Inzet mag niet hoger zijn dan uw totaal!");
                return false;
            }
            return true;
        }

        private void pullCardButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckGamble())
            {
                //Kaart random kiezen
                Random rand = new Random();
                //int idx = rand.Next(0, 53);
                int idx = rand.Next(0, _cardDeck.Count);

                var card = _cardDeck[idx];
                string cardColor = card[0];
                string cardName = card[1];

                int difference;
                bool hasWon = ((ComboBoxItem)colorComboBox.SelectedItem).Name == cardColor;
                if (hasWon)
                {
                    //Gewonnen
                    difference = 2 * _gamble;
                }
                else
                {
                    //Verloren
                    difference = -_gamble;
                }
                _total += difference;
                pulledCardsListBox.Items.Add($"{cardName}: {(hasWon ? "+" : "-")}{Math.Abs(difference)}");

                //if (((ComboBoxItem)CmbKleur.SelectedItem).Name == kleur)
                //{
                //    //Gewonnen
                //    totaal += 2 * inzet;
                //    LstGetrokkenKaarten.Items.Add($"{kaartNaam}: +{2 * inzet}");
                //}
                //else
                //{
                //    //Verloren
                //    totaal -= inzet;
                //    LstGetrokkenKaarten.Items.Add($"{kaartNaam}: -{inzet}");
                //}

                ShowTotal();
                _cardDeck.RemoveAt(idx);
                //_cardDeck.RemoveAt(card);
            }
        }
    }
}
