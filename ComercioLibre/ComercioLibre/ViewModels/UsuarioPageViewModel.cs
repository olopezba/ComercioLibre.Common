using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComercioLibre.ViewModels
{
    public class UsuarioPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private bool _isEnabled;
        public UsuarioPageViewModel(INavigationService navigationService):base(navigationService)
        {
            _navigationService = navigationService;
            Title = "DATOS USUARIO";
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }

    }
}
