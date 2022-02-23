using System;

namespace BussinessLayer
{
    public class Calculadora
    {
        public double Calculando(int prestamo, int tasa, double cuota)
        {
            double calculando = 0;
            double residuoTasaInteres;
            double totalaPagar;


            switch (prestamo)                
            {

                #region PRESTAMO PERSONAL
                case (int)Seleccionar.Prestamo_Personal:
                    residuoTasaInteres = cuota * 0.22;
                    totalaPagar = cuota + residuoTasaInteres;
                    switch (tasa)
                    {
                        case (int)CantidadDeMeses.Mes12:
                            calculando = totalaPagar / 12;
                            break;
                        case (int)CantidadDeMeses.Mes18:
                            calculando = totalaPagar / 18;
                            break;
                        case (int)CantidadDeMeses.Mes24:
                            calculando = totalaPagar / 24;
                            break;
                        case (int)CantidadDeMeses.Mes30:
                            calculando = totalaPagar / 30;
                            break;
                        case (int)CantidadDeMeses.Mes36:
                            calculando = totalaPagar / 36;
                            break;
                        case (int)CantidadDeMeses.Mes42:
                            calculando = totalaPagar / 42;
                            break;
                        case (int)CantidadDeMeses.Mes48:
                            calculando = totalaPagar / 48;
                            break;
                        case (int)CantidadDeMeses.Mes54:
                            calculando = totalaPagar / 54;
                            break;
                        case (int)CantidadDeMeses.Mes60:
                            calculando = totalaPagar / 60;
                            break;
                        case (int)CantidadDeMeses.Mes66:
                            calculando = totalaPagar / 66;
                            break;
                        case (int)CantidadDeMeses.Mes72:
                            calculando = totalaPagar / 72;
                            break;
                        case (int)CantidadDeMeses.Mes78:
                            calculando = totalaPagar / 78;
                            break;
                        case (int)CantidadDeMeses.Mes84:
                            calculando = totalaPagar / 84;
                            break;
                        case (int)CantidadDeMeses.Mes90:
                            calculando = totalaPagar / 90;
                            break;
                        case (int)CantidadDeMeses.Mes102:
                            calculando = totalaPagar / 102;
                            break;
                        case (int)CantidadDeMeses.Mes108:
                            calculando = totalaPagar / 108;
                            break;
                        case (int)CantidadDeMeses.Mes114:
                            calculando = totalaPagar / 114;
                            break;
                        case (int)CantidadDeMeses.Mes120:
                            calculando = totalaPagar / 120;
                            break;
                    }
                    break;
#endregion

                #region PRESTAMO AUTOMOVIL
                case (int)Seleccionar.Prestamo_Automovil:
                    residuoTasaInteres = cuota * 0.12;
                    totalaPagar = cuota + residuoTasaInteres;
                    switch (tasa)
                    {
                        case (int)CantidadDeMeses.Mes12:
                            calculando = totalaPagar / 12;
                            break;
                        case (int)CantidadDeMeses.Mes18:
                            calculando = totalaPagar / 18;
                            break;
                        case (int)CantidadDeMeses.Mes24:
                            calculando = totalaPagar / 24;
                            break;
                        case (int)CantidadDeMeses.Mes30:
                            calculando = totalaPagar / 30;
                            break;
                        case (int)CantidadDeMeses.Mes36:
                            calculando = totalaPagar / 36;
                            break;
                        case (int)CantidadDeMeses.Mes42:
                            calculando = totalaPagar / 42;
                            break;
                        case (int)CantidadDeMeses.Mes48:
                            calculando = totalaPagar / 48;
                            break;
                        case (int)CantidadDeMeses.Mes54:
                            calculando = totalaPagar / 54;
                            break;
                        case (int)CantidadDeMeses.Mes60:
                            calculando = totalaPagar / 60;
                            break;
                        case (int)CantidadDeMeses.Mes66:
                            calculando = totalaPagar / 66;
                            break;
                        case (int)CantidadDeMeses.Mes72:
                            calculando = totalaPagar / 72;
                            break;
                        case (int)CantidadDeMeses.Mes78:
                            calculando = totalaPagar / 78;
                            break;
                        case (int)CantidadDeMeses.Mes84:
                            calculando = totalaPagar / 84;
                            break;
                        case (int)CantidadDeMeses.Mes90:
                            calculando = totalaPagar / 90;
                            break;
                        case (int)CantidadDeMeses.Mes102:
                            calculando = totalaPagar / 102;
                            break;
                        case (int)CantidadDeMeses.Mes108:
                            calculando = totalaPagar / 108;
                            break;
                        case (int)CantidadDeMeses.Mes114:
                            calculando = totalaPagar / 114;
                            break;
                        case (int)CantidadDeMeses.Mes120:
                            calculando = totalaPagar / 120;
                            break;
                    }
                    break;
                #endregion

                #region PRESTAMO HIPOTECARIO
                case (int)Seleccionar.Prestamo_Hipotecario:
                    residuoTasaInteres = cuota * 0.08;
                    totalaPagar = cuota + residuoTasaInteres;
                    switch (tasa)
                    {
                        case (int)CantidadDeMeses.Mes12:
                            calculando = totalaPagar / 12;
                            break;
                        case (int)CantidadDeMeses.Mes18:
                            calculando = totalaPagar / 18;
                            break;
                        case (int)CantidadDeMeses.Mes24:
                            calculando = totalaPagar / 24;
                            break;
                        case (int)CantidadDeMeses.Mes30:
                            calculando = totalaPagar / 30;
                            break;
                        case (int)CantidadDeMeses.Mes36:
                            calculando = totalaPagar / 36;
                            break;
                        case (int)CantidadDeMeses.Mes42:
                            calculando = totalaPagar / 42;
                            break;
                        case (int)CantidadDeMeses.Mes48:
                            calculando = totalaPagar / 48;
                            break;
                        case (int)CantidadDeMeses.Mes54:
                            calculando = totalaPagar / 54;
                            break;
                        case (int)CantidadDeMeses.Mes60:
                            calculando = totalaPagar / 60;
                            break;
                        case (int)CantidadDeMeses.Mes66:
                            calculando = totalaPagar / 66;
                            break;
                        case (int)CantidadDeMeses.Mes72:
                            calculando = totalaPagar / 72;
                            break;
                        case (int)CantidadDeMeses.Mes78:
                            calculando = totalaPagar / 78;
                            break;
                        case (int)CantidadDeMeses.Mes84:
                            calculando = totalaPagar / 84;
                            break;
                        case (int)CantidadDeMeses.Mes90:
                            calculando = totalaPagar / 90;
                            break;
                        case (int)CantidadDeMeses.Mes102:
                            calculando = totalaPagar / 102;
                            break;
                        case (int)CantidadDeMeses.Mes108:
                            calculando = totalaPagar / 108;
                            break;
                        case (int)CantidadDeMeses.Mes114:
                            calculando = totalaPagar / 114;
                            break;
                        case (int)CantidadDeMeses.Mes120:
                            calculando = totalaPagar / 120;
                            break;
                    }
                    break;
                    #endregion

            }


            return calculando;
        }
    }
}
