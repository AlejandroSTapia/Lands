
using System.Windows.Input;

namespace Lands.ViewModels
{
    public class LoginViewModel
    {
        #region Properties

        //Propiedad de email 
        //se define del tipo quesera la propiedad
        public string Email {
            get; set;
        }

        //Propiedad password
        public string Password {
            get; set; 
        }

        //Propiedad de activityIndicator
        public bool IsRunning {
            get; set; 
        }

        //Propiedad de switch
        public bool IsRemembered {
            get; set; 
        }


        #region Commands

        #endregion
        //Propiedad de Button Login de tipo Icommand
        public ICommand LoginCommand { 
            get; set; 
        }

        #endregion


        #region Construntors
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }
        #endregion
    }
}
