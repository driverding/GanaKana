using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.Storage;

namespace GanaKana
{
    public partial class SettingsPageViewModel : INotifyPropertyChanged
    {
        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool HiraganaEnabled
        { 
            get => (bool)localSettings.Values["HiraganaEnabled"];
            set
            {
                localSettings.Values["HiraganaEnabled"] = value;
                OnPropertyChanged();
            }
        }

        public bool KatakanaEnabled
        {
            get => (bool)localSettings.Values["KatakanaEnabled"];
            set
            {
                localSettings.Values["KatakanaEnabled"] = value;
                OnPropertyChanged();
            }
        }

        public bool YouonEnabled
        {
            get => (bool)localSettings.Values["YouonEnabled"];
            set
            {
                localSettings.Values["YouonEnabled"] = value;
                OnPropertyChanged();
            }
        }
    }
}
