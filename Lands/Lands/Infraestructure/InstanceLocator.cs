//instanciamos las viewmodels


namespace Lands.Infraestructure
{
    using Lands.ViewModels;
    internal class InstanceLocator
    {
        //Primero crearemos una propiedad Mian de la tipo mainvoewmodel dentro de la clase InstanceLocator
        //SI escribimos prop y doble tab nos genra el bloque de cod pero lo sustituimos asi:
        public MainViewModel Main
        {
            //public int MyProperty {
            get; set; 
        }
        //luego creamos el constructor a la clase con ctor doble tab
        public InstanceLocator()
        {
            //La propiedad Main es igual a MainViewModel
            //Esto es un patron de diseño que llama al patron Locator o carretera despejada
            this.Main = new MainViewModel();
            //Esto nos sirve para que podamos ligar la pagina Login al MainViewModel
        }

    }
}
