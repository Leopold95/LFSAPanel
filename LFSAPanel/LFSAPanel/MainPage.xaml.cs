using LFSAPanel.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LFSAPanel
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(FirstPage), typeof(FirstPage));
        }
    }
}
