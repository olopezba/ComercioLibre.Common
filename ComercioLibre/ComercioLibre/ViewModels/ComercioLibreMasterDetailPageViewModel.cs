using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ComercioLibre.Models;
using ComercioLibre.Data.Entities;

namespace ComercioLibre.ViewModels
{
    public class ComercioLibreMasterDetailPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public ObservableCollection<MenuItemViewModel> Menus { get; set; }

        public ComercioLibreMasterDetailPageViewModel (INavigationService navigationService):base(navigationService)
        {
            _navigationService = navigationService;
            LoadMenus();
        }

        private void LoadMenus()
        {
            List<Categoria> lista = App.DataBase.GetAllCategoria();
            List<Menu> menus = new List<Menu>();
            foreach (Categoria item in lista)
            {

                menus.Add(new Menu
                {
                    PageName = "HomePage",
                    Title = item.NombreCategoria
                });
            }

            //List<Menu> menus = new List<Menu>
            //{
            //    new Menu
            //    {
            //        Icon = "ic_airport_shuttle",
            //        PageName = "HomePage",
            //        Title = "New trip"
            //    }
            //    //new Menu
            //    //{
            //    //    Icon = "ic_account_circle",
            //    //    PageName = "DatosPage",
            //    //    Title = "Datos"
            //    //},
            //    //new Menu
            //    //{
            //    //    Icon = "ic_people",
            //    //    PageName = "MapaPage",
            //    //    Title = "Mapa"
            //    //},
            //    //new Menu
            //    //{
            //    //    Icon = "ic_account_circle",
            //    //    PageName = "PosicionesPage",
            //    //    Title = "Posiciones"
            //    //}
            //};

            Menus = new ObservableCollection<MenuItemViewModel>(
                menus.Select(m => new MenuItemViewModel(_navigationService)
                {
                    Icon = m.Icon,
                    PageName = m.PageName,
                    Title = m.Title
                }).ToList());
        }
    }
}
