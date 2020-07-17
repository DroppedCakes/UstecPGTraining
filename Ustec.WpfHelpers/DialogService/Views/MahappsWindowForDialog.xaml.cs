using MahApps.Metro.Controls;
using Prism.Services.Dialogs;

namespace Ustec.WpfHelpers.DialogService.Views
{
    /// <summary>
    /// Interaction logic for MahappsWindowForDialog.xaml
    /// </summary>
    public partial class MahappsWindowForDialog : MetroWindow, IDialogWindow
    {
        public MahappsWindowForDialog()
        {
            InitializeComponent();
        }

        public IDialogResult Result { get; set; }
    }
}