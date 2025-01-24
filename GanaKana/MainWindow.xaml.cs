using Microsoft.UI.Input;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;
using System.Diagnostics;
using Windows.Foundation;
using Windows.Graphics;


namespace GanaKana
{
    public sealed partial class MainWindow : WinUIEx.WindowEx
    {
        private bool isLoaded;

        public MainWindow()
        {
            InitializeComponent();

            isLoaded = false;

            ExtendsContentIntoTitleBar = true;
            SetTitleBar(TitleBar);
            AppWindow.TitleBar.PreferredHeightOption = TitleBarHeightOption.Tall;

            NavigationView.SelectedItem = PlayItem;
            ContentFrame.Navigate(typeof(PlayPage));
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            isLoaded = true;
        }

        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            SetNonClientRegion();
        }

        private void MainWindow_SizeChanged(object sender, WindowSizeChangedEventArgs args)
        {
            if (isLoaded) SetNonClientRegion();
        }

        private void SetNonClientRegion()
        {
            double scaleAdjustment = TitleBar.XamlRoot.RasterizationScale;

            GeneralTransform transform = PlayItem.TransformToVisual(null);
            Rect bounds = transform.TransformBounds(new Rect(0, 0, PlayItem.ActualWidth, PlayItem.ActualHeight));
            RectInt32 playItemRect = GetRect(bounds, scaleAdjustment);

            transform = LearnItem.TransformToVisual(null);
            bounds = transform.TransformBounds(new Rect(0, 0, LearnItem.ActualWidth, LearnItem.ActualHeight));
            RectInt32 learnItemRect = GetRect(bounds, scaleAdjustment);

            var settingsItem = NavigationView.SettingsItem as NavigationViewItem;
            if (settingsItem == null)
            {
                Trace.WriteLine("ERROR: SettingsItem doesn't exist.");
                Environment.Exit(1);
            }

            transform = settingsItem.TransformToVisual(null);
            bounds = transform.TransformBounds(new Rect(0, 0, settingsItem.ActualWidth, settingsItem.ActualHeight));
            RectInt32 settingsItemRect = GetRect(bounds, scaleAdjustment);

            var rectArray = new RectInt32[] { playItemRect, learnItemRect, settingsItemRect };

            InputNonClientPointerSource.GetForWindowId(AppWindow.Id).SetRegionRects(NonClientRegionKind.Passthrough, rectArray);
        }

        private static RectInt32 GetRect(Rect bounds, double scale)
        {
            return new RectInt32(
                _X: (int)Math.Round(bounds.X * scale),
                _Y: (int)Math.Round(bounds.Y * scale),
                _Width: (int)Math.Round(bounds.Width * scale),
                _Height: (int)Math.Round(bounds.Height * scale)
            );
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
                ContentFrame.Navigate(typeof(SettingsPage));

            var selectedTag = (string)((NavigationViewItem)args.SelectedItem).Tag;

            if (selectedTag == "PlayPage")
                ContentFrame.Navigate(typeof(PlayPage));
            else if (selectedTag == "LearnPage")
                ContentFrame.Navigate(typeof(LearnPage));
        }


    }
}
