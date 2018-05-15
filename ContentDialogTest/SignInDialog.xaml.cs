using System;
using Windows.UI.Xaml.Controls;

namespace SkyUK_UWP.Services.OverlayService.Dialogs.SignIn
{
    public sealed partial class SignInDialog : ContentDialog
    {
        public bool IsCancelled = false;

        public SignInDialog()
        {
            InitializeComponent();
        }
    }
}
