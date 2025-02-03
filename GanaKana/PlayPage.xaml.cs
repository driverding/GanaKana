using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Windows.ApplicationModel.Resources;
using Windows.Storage;


namespace GanaKana
{
    public sealed partial class PlayPage : Page
    {
        private readonly ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

        public PlayPageViewModel ViewModel { get; set; } 

        private enum State
        {
            Questioned,
            Graded
        }

        private State state = State.Graded;
        private string answer = "";

        public PlayPage()
        {
            InitializeComponent();

            ResourceLoader resourceLoader = ResourceLoader.GetForViewIndependentUse();

            ViewModel = new PlayPageViewModel
            {
                Title = resourceLoader.GetString("PlayPage_GetReady"),
                Subtitle = resourceLoader.GetString("PlayPage_PressEnterToStart"),
                BackgroundColor = "LightBlue",
                Symbol = "Accept",
                SymbolVisibility = "Collapsed"
            };
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TextBox.Focus(FocusState.Programmatic);
        }

        private void TextBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                Progress();
            }
        }

        private void Progress()
        {
            if (state == State.Graded)
            {
                // var localSettings = ApplicationData.Current.LocalSettings;
                bool HiraganaEnabled = (bool)localSettings.Values["HiraganaEnabled"];
                bool KatakanaEnabled = (bool)localSettings.Values["KatakanaEnabled"];
                bool YouonEnabled = (bool)localSettings.Values["YouonEnabled"];
                bool SpecialEnabled = (bool)localSettings.Values["SpecialEnabled"];

                var question = Data.PickRandom(HiraganaEnabled, KatakanaEnabled, YouonEnabled, SpecialEnabled);
                ViewModel.Title = question.Item1;
                answer = question.Item2;

                ViewModel.Subtitle = "";
                ViewModel.SymbolVisibility = "Collapsed";
                ViewModel.BackgroundColor = "Transparent";

                TextBox.Text = "";
                state = State.Questioned;
            }
            else
            {
                if (TextBox.Text == answer)
                {
                    ViewModel.Symbol = "Accept";
                    ViewModel.BackgroundColor = "Green";
                }
                else
                {
                    ViewModel.Symbol = "Cancel";
                    ViewModel.BackgroundColor = "Pink";
                }

                ViewModel.Subtitle = answer;
                ViewModel.SymbolVisibility = "Visible";

                state = State.Graded;
            }
        }
    }
}
