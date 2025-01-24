using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GanaKana
{
    public class PlayPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string? title;
        public string? Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        private string? subtitle;
        public string? Subtitle
        {
            get { return subtitle; }
            set
            {
                subtitle = value;
                OnPropertyChanged();
            }
        }

        private string? backgroundColor;
        public string? BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                OnPropertyChanged();
            }
        }

        private string? symbol;
        public string? Symbol
        {
            get { return symbol; }
            set
            {
                symbol = value;
                OnPropertyChanged();
            }
        }

        private string? symbolVisibility;
        public string? SymbolVisibility
        {
            get { return symbolVisibility; }
            set
            {
                symbolVisibility = value;
                OnPropertyChanged();
            }
        }
    }
}
