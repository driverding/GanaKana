using Microsoft.UI.Xaml;
using Windows.Storage;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GanaKana
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            initalizeLocalSettings();

            m_window = new MainWindow();
            m_window.Activate();
        }

        private void initalizeLocalSettings()
        {
            var localSettings = ApplicationData.Current.LocalSettings;
            if (!localSettings.Values.ContainsKey("HiraganaEnabled"))
            {
                localSettings.Values["HiraganaEnabled"] = true;
            }
            if (!localSettings.Values.ContainsKey("KatakanaEnabled"))
            {
                localSettings.Values["KatakanaEnabled"] = true;
            }
            if (!localSettings.Values.ContainsKey("YouonEnabled"))
            {
                localSettings.Values["YouonEnabled"] = true;
            }
            if (!localSettings.Values.ContainsKey("SpecialEnabled"))
            {
                localSettings.Values["SpecialEnabled"] = false;
            }
        }

        private Window? m_window;
    }
}
