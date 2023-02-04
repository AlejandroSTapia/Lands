using GalaSoft.MvvmLight.Command;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lands.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Atribbs
        //Crearemos una propiedad privada por cada atributo que se refresque
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion


        #region Properties

        //Propiedad de email 
        //se define del tipo quesera la propiedad
        public string Email
        {
            get; set;
        }

        //Propiedad password
        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        //Propiedad de activityIndicator
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        //Propiedad de switch
        public bool IsRemembered
        {
            get; set;
        }

        //Propiedad de booton
        public bool IsEnabled {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        #endregion

        #region Commands
        //Propiedad de Button Login de tipo Icommand
        public ICommand LoginCommand
        {
            // propiedad solo lectura
            get
            {
                //
                //como parametro nombre de metodo
                return new RelayCommand(Login);
            }
            //set;
        }

        private async void Login()
        {
            //validar que el usuario haya ingresado email y pass
            if (string.IsNullOrEmpty(this.Email))
            {
                //pintamos el alert
                await Application.Current.MainPage.DisplayAlert("Error", "Debe ingresar un correo", "Aceptar");
                return;

            }

            if (string.IsNullOrEmpty(this.Password))
            {
                //pintamos el alert
                await Application.Current.MainPage.DisplayAlert("Error", "Debe ingresar contraseña", "Aceptar");
                return;

            }

            this.IsRunning = true;
            this.IsEnabled = false;

            //navegar a otra pagina
            if (this.Email != "neil.tapia11@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert("Error", "Correo o contraseña incorrecta", "Aceptar");
                this.Password = string.Empty; //para que vacie el campo
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;

            //Si el usuario llego hasta aqui, antes de navegar a otra pagina, le decimos que esya bien
            await Application.Current.MainPage.DisplayAlert(
                "Ok", "Todo correcto", "Aceptar");
            return;
            {

            }
        }


        #endregion





        #region Construntors
        public LoginViewModel()
        {
            //valor por default de switch
            this.IsRemembered = true;
            //valor por default de button
            this.IsEnabled = true;
        }
        #endregion
    }
}
