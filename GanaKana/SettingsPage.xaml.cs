using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using Windows.ApplicationModel;


namespace GanaKana
{

    public sealed partial class SettingsPage : Page
    {
        public SettingsPageViewModel ViewModel { get; set; } = new SettingsPageViewModel();
        public SettingsPage()
        {
            InitializeComponent();

            var version = Package.Current.Id.Version;

            string versionString = $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";

            VersionTextBlock.Text = versionString;
        }
    }
}
