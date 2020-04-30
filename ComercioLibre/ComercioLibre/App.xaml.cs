using Prism;
using Prism.Ioc;
using ComercioLibre.ViewModels;
using ComercioLibre.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ComercioLibre.Data;
using ComercioLibre.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ComercioLibre
{
    public partial class App
    {
        private static ComercioLibreDataBase database;
        public static ComercioLibreDataBase DataBase
        {
            get
            {

                if (database == null)
                {
                    database =
                        new ComercioLibreDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("ComercioLibre.db3"));
                }
                return database;

            }
        }
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjAwMTI0QDMxMzcyZTM0MmUzMEc3S2swOEpuODU1M1llTHJtYzRYaVl3Q1RFYUgvSnBtSzlyU0Jrd0RhUWs9");
            InitializeComponent();
            App.DataBase.ComprobarVersion();
            //await NavigationService.NavigateAsync("/ComercioLibreMasterDetailPage/NavigationPage/HomePage");
            await NavigationService.NavigateAsync("/NavigationPage/UsuarioPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<PaginaPrincipalPage, PaginaPrincipalPageViewModel>();
            containerRegistry.RegisterForNavigation<ComercioLibreMasterDetailPage, ComercioLibreMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<UsuarioPage, UsuarioPageViewModel>();
        }
    }
}
