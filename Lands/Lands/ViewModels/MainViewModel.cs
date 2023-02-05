namespace Lands.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        //Obj Login
        public LoginViewModel Login { 
            get; set; 
        }

        //obj de countries sin constructor
        public CountriesViewModel Countries { 
            get; set; 
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            //Cuando inicie la clase sera
            instance = this;

            //Instanciamos
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        //Llamado de MVM desde cualquier clase sin necesidad de instanciar otra MVM(unica MVM en la ejecucion)
        //Propiedad instance
        private static MainViewModel instance;

        //Metodo para instancia de MVM
        public static MainViewModel GetInstance()
        {
            if(instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
