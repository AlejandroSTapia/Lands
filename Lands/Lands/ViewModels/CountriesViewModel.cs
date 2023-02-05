using Lands.Models;
using Lands.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Lands.ViewModels
{
    public class CountriesViewModel : BaseViewModel
    {

        #region Services
        //referencia del servicio
        private ApiService apiService;
        #endregion

        #region Attributes
        // private List<Country> Countries;
        //ya que se va a refrescar la lista debe ser asi ya que se pintara en una listview
        private ObservableCollection<Country> countries;
        #endregion

        #region Properties
        public ObservableCollection<Country> Countries
        {
            get { return this.countries; }
            set { SetValue(ref this.countries, value); }
        }
        #endregion

        #region Constructors
        public CountriesViewModel()
        {
            //instanciamos el servicio de apiservice
             this.apiService = new ApiService();
            this.LoadCountries();
        }

        #endregion

        #region Methods
        private async void LoadCountries()
        {

            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                                   "Error", connection.Message, "Aceptar");
                //back cuando no haya conexion a internet
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }

            var response = await this.apiService.GetList<Country>(
                "https://restcountries.com", "/v2", "/all");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",response.Message,"Aceptar");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }
            //Lista convert a Observable COlecction
            var list = (List<Country>)response.Result;
            //creamos el observable con relacion a la list
            this.Countries = new ObservableCollection<Country>(list);
        }
        #endregion
    }
}
