using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;


namespace GanaKana
{

    public sealed partial class SettingsPage : Page
    {
        public SettingsPageViewModel ViewModel { get; set; } = new SettingsPageViewModel();
        public SettingsPage()
        {
            InitializeComponent();
        }
    }
}
