using System.Windows.Input;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;

namespace MVVM_2_Converters.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                IsVerifyTrue = this;
                OnPropertyChanged(() => Login);
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                IsVerifyTrue = this;
                OnPropertyChanged(() => Password);
            }
        }

        private MainWindowViewModel _isVerifyTrue;

        public MainWindowViewModel IsVerifyTrue
        {
            get { return this; }
            set
            {
                _isVerifyTrue = value;
                OnPropertyChanged(() => IsVerifyTrue);
            }
        }

    }
}
