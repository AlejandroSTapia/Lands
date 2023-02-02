//instanciamos las viewmodels


namespace Lands.Infraestructure
{
    using Lands.ViewModels;
    internal class InstanceLocator
    {
        //Propiedad Main
        public MainViewModel Main
        {
            //public int MyProperty {
            get; set; 
        }
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
            //Para ligar la pagina Login al MainViewModel
        }

    }
}
