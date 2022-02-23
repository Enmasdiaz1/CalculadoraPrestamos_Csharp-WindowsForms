using System;
using System.Collections.Generic;
using System.Text;

namespace AppPrestamos.Control
{
    public class ComboBoxPrestamo
    {
       public string Texto { get; set; }
       public object Valor { get; set; }
       public override string ToString()
        {
            return Texto;
        }
    }


    

}
