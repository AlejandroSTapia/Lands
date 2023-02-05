using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Models
{
    public class Response
    {
        //SI si puede traer, sera true y en Result devuelve la lista de paises
        //si es false, mostrara message
        public bool IsSuccess
        {
            get;
            set;
        }

        public string Message
        {
            get; set;
        }

        public object Result
        {
            get;
            set;
        }
    }
}
