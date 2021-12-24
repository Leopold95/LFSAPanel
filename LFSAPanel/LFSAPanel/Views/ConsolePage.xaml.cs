using LFSAPanel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LFSAPanel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsolePage : ContentPage
    {
        ConsolePageViewModel _consolePagevm;
        public ConsolePage()
        {
            InitializeComponent();
            _consolePagevm = new ConsolePageViewModel();
            BindingContext = _consolePagevm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _consolePagevm.OnAppear();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _consolePagevm.OnDisappear();
        }
    }
}