using LFSAPanel.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LFSAPanel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OptinsPage : ContentPage
    {

        private OptinsPageViewModel _OPVewModel;

        public OptinsPage()
        {
            InitializeComponent();
            _OPVewModel = new OptinsPageViewModel();
            BindingContext = _OPVewModel;
        }
   
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _OPVewModel.OnPageAppear(this, EventArgs.Empty);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _OPVewModel.OnPageDisappear(this, EventArgs.Empty);
        }       

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _OPVewModel.OnNewServerSelected(sender, e);
        }
    }
}