using LFSAPanel.Core.System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace LFSAPanel.ViewModels
{
    public class AccauntInfoPageViewModel : BindableObject
    {
        private Thread _thread;
        private ServerInfoManager _info;

        public AccauntInfoPageViewModel()
        {
            _info = ServerInfoManager.GetInstance();
        }

        private string _accauntId = "";
        public string AccauntId 
        { 
            get => _accauntId;
            set
            {
                _accauntId = value;
                OnPropertyChanged();
            }
        }

        private string _isAndmin = "";
        public string IsAndmin
        {
            get => _isAndmin;
            set
            {
                _isAndmin = value;
                OnPropertyChanged();
            }
        }

        private string _username = "";
        public string UserName { get => _username; set { _username = value; OnPropertyChanged(); } }

        private string _email = "";
        public string Email { get => _email; set { _email = value; OnPropertyChanged(); } }

        private string _firstName = "";
        public string FirstName { get => _firstName; set { _firstName = value; OnPropertyChanged(); } }

        private string _lastName = "";
        public string LastName { get => _lastName; set { _lastName = value; OnPropertyChanged(); } }

        public void OnAppear()
        {
            _thread = new Thread(new ThreadStart(Do));
            _thread.Start();
        }

        public void OnDisappear()
        {
            _thread.Abort();
        }

        private void Do()
        {
            _info.UpdateAccauntDetails();
            AccauntId = _info.GetAccauntDetails().Attributes.Id.ToString();
            IsAndmin = _info.GetAccauntDetails().Attributes.Admin.ToString();
            UserName = _info.GetAccauntDetails().Attributes.Username;
            Email = _info.GetAccauntDetails().Attributes.Email;
            FirstName = _info.GetAccauntDetails().Attributes.FirstName;
            LastName = _info.GetAccauntDetails().Attributes.LastName;
        }
    }
}
