using System;
using System.Collections.Generic;
using System.Text;

namespace Cambios.Modelos
{
    public class Resposnse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }

    }
}
