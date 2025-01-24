using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GanaKana
{
    public sealed partial class LearnPage : Page
    {
        ObservableCollection<CharData> HiraganaSource { get; } = RenderItemsSource(Data.hiraganaDict);
        ObservableCollection<CharData> KatakanaSource { get; } = RenderItemsSource(Data.katakanaDict);
        ObservableCollection<CharData> HiraganaCombSource { get; } = RenderItemsSource(Data.hiraganaCombDict);
        ObservableCollection<CharData> KatakanaCombSource { get; } = RenderItemsSource(Data.katakanaCombDict);

        public LearnPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            HiraganaGridView.ItemsSource = HiraganaSource;
            KatakanaGridView.ItemsSource = KatakanaSource;
            HiraganaYouonGridView.ItemsSource = HiraganaCombSource;
            KatakanaYouonGridView.ItemsSource = KatakanaCombSource;
        }

        private static ObservableCollection<CharData> RenderItemsSource((string, string)[] data)
        {
            ObservableCollection<CharData> result = [];

            foreach (var pair in data)
            {
                result.Add(new CharData { GanaKana = pair.Item1, Romaji = pair.Item2 });
            }

            return result;
        }


    }
}
