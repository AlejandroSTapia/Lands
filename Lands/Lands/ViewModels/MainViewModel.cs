namespace Lands.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        //Obj Login
        public LoginViewModel Login { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            //Instanciamos
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
