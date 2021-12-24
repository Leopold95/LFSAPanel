using System;
using System.Collections.ObjectModel;
using System.Threading;
using LFSAPanel.Core.System;
using LFSAPanel.Models.AllServersDetailsList;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LFSAPanel.ViewModels
{
    public class OptinsPageViewModel : BindableObject
    {
        private Thread _thread;
        ServerInfoManager _serversInfoCollectinManager;

        public OptinsPageViewModel()
        {
            _serversInfoCollectinManager = ServerInfoManager.GetInstance();
        }



        public static ObservableCollection<string> Identifiers { get; set; } = new ObservableCollection<string>();

        private string _count = "";
        public string Count { get => _count; set { _count = value; OnPropertyChanged(); } }

        private string _selectedServer = "";
        public string SelectedServer { get => _selectedServer; set { _selectedServer = value; OnPropertyChanged(); } }

        public void OnPageAppear(Page sender, EventArgs e)
        {
            _thread = new Thread(new ThreadStart(Foo));

            _thread.Start();

            Identifiers.Clear();
            Count = "";
            SelectedServer = "";

            void Foo()
            {
                foreach (var item in _serversInfoCollectinManager.GetAllServersDetailsList().Data)
                {
                    Identifiers.Add(item.Attributes.Identifier);
                }

                Count = Identifiers.Count.ToString();
            }
        }
        public void OnPageDisappear(Page sender, EventArgs e)
        {
            if (_thread.IsAlive)
                _thread.Abort();
        }

        public void OnNewServerSelected(object sender, SelectedItemChangedEventArgs e)
        {
            SelectedServer = e.SelectedItem.ToString();

            Preferences.Set("CurrentServer", SelectedServer);
        }
    } 
}
