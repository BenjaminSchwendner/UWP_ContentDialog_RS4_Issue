using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using SkyUK_UWP.Services.OverlayService.Dialogs.SignIn;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ContentDialogTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            await (new SignInDialog() { MinHeight = Window.Current.Bounds.Height }).ShowAsync();
        }
    }
}
