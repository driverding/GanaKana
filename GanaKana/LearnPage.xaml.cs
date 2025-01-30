using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using Windows.Storage;

namespace GanaKana
{
    public sealed partial class LearnPage : Page
    {
        public bool HiraganaEnabled { get; }
        public bool KatakanaEnabled { get; }
        public bool YouonEnabled { get; }
        public bool HiraganaYouonEnabled { get; }
        public bool KatakanaYouonEnabled { get; }
        public bool HistoryEnabled { get; }
        public bool SpecialEnabled { get; }
        
        ObservableCollection<CharData> HiraganaSource { get; }
        ObservableCollection<CharData> KatakanaSource { get; }
        ObservableCollection<CharData> HiraganaCombSource { get; } 
        ObservableCollection<CharData> KatakanaCombSource { get; }

        public LearnPage()
        {
            InitializeComponent();
            var localSettings = ApplicationData.Current.LocalSettings;
            HiraganaEnabled = (bool)localSettings.Values["HiraganaEnabled"];
            KatakanaEnabled = (bool)localSettings.Values["KatakanaEnabled"];
            YouonEnabled = (bool)localSettings.Values["YouonEnabled"];
            SpecialEnabled = (bool)localSettings.Values["SpecialEnabled"];

            HiraganaYouonEnabled = HiraganaEnabled && YouonEnabled;
            KatakanaYouonEnabled = KatakanaEnabled && YouonEnabled;

            HiraganaSource = RenderItemsSource(Data.hiraganaDict);
            KatakanaSource = RenderItemsSource(Data.katakanaDict);
            HiraganaCombSource = RenderItemsSource(Data.hiraganaCombDict);
            KatakanaCombSource = RenderItemsSource(Data.katakanaCombDict);
        }
        private void Page_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            HiraganaGridView.ItemsSource = HiraganaSource;
            KatakanaGridView.ItemsSource = KatakanaSource;
            HiraganaYouonGridView.ItemsSource = HiraganaCombSource;
            KatakanaYouonGridView.ItemsSource = KatakanaCombSource;
        }

        private ObservableCollection<CharData> RenderItemsSource((string, string, Data.Type)[] data)
        {
            ObservableCollection<CharData> result = [];

            foreach (var pair in data)
            {
                if (pair.Item3 == Data.Type.Special && !SpecialEnabled)
                {
                    result.Add(new CharData { GanaKana = "", Romaji = "" });
                }
                else
                {
                    result.Add(new CharData { GanaKana = pair.Item1, Romaji = pair.Item2 });
                }
            }

            return result;
        }


    }
}
