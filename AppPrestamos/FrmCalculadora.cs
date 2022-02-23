using AppPrestamos.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace AppPrestamos
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }
        #region EVENTOS

        public bool SeCalculo { get; set; } = false;
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            CargandoCbx();
            CargandoTxt();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Validar();
        }
        private void CBXSeleccionPrestamo_DropDownClosed(object sender, EventArgs e)
        {
            CargandoTxt();
        }

        private void CBXSeleccionPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeCalculo)
            {
                Validar();
            }
        }
        private void CBXCBXMesesAPagar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeCalculo)
            {
                Validar();
            }
        }
        #endregion

        #region CARGAS DE COMPONENTES
        private void CargandoCbx()
        {
            #region COMBOBOX PRESTAMO
            ComboBoxPrestamo opcionDefecto = new ComboBoxPrestamo
            {
                Texto = "Seleccione",
                Valor = null

            };
            ComboBoxPrestamo opcionPersonal = new ComboBoxPrestamo
            {
                Texto = "Prestamo Personal",
                Valor = 1

            };
            ComboBoxPrestamo opcionAutomovil = new ComboBoxPrestamo
            {
                Texto = "Prestamo Automovil",
                Valor = 2

            };
            ComboBoxPrestamo opcionHipotecario = new ComboBoxPrestamo
            {
                Texto = "Prestamo Hipotecario",
                Valor = 3

            };
            #endregion

            #region COMBOBOX MESES

            ComboBoxPrestamo opcion12Meses = new ComboBoxPrestamo
            {
                Texto = "12 MESES",
                Valor = 1

            };
            ComboBoxPrestamo opcion18Meses = new ComboBoxPrestamo
            {
                Texto = "18 MESES",
                Valor = 2

            };
            ComboBoxPrestamo opcion24Meses = new ComboBoxPrestamo
            {
                Texto = "24 MESES",
                Valor = 3

            };
            ComboBoxPrestamo opcion30Meses = new ComboBoxPrestamo
            {
                Texto = "30 MESES",
                Valor = 4

            };
            ComboBoxPrestamo opcion36Meses = new ComboBoxPrestamo
            {
                Texto = "36 MESES",
                Valor = 5

            };
            ComboBoxPrestamo opcion42Meses = new ComboBoxPrestamo
            {
                Texto = "42 MESES",
                Valor = 6

            };
            ComboBoxPrestamo opcion48Meses = new ComboBoxPrestamo
            {
                Texto = "48 MESES",
                Valor = 7

            };
            ComboBoxPrestamo opcion54Meses = new ComboBoxPrestamo
            {
                Texto = "54 MESES",
                Valor = 8

            };
            ComboBoxPrestamo opcion60Meses = new ComboBoxPrestamo
            {
                Texto = "60 MESES",
                Valor = 9

            };
            ComboBoxPrestamo opcion66Meses = new ComboBoxPrestamo
            {
                Texto = "66 MESES",
                Valor = 10

            };
            ComboBoxPrestamo opcion72Meses = new ComboBoxPrestamo
            {
                Texto = "72 MESES",
                Valor = 11

            };
            ComboBoxPrestamo opcion78Meses = new ComboBoxPrestamo
            {
                Texto = "78 MESES",
                Valor = 12

            };
            ComboBoxPrestamo opcion84Meses = new ComboBoxPrestamo
            {
                Texto = "84 MESES",
                Valor = 13

            };
            ComboBoxPrestamo opcion90Meses = new ComboBoxPrestamo
            {
                Texto = "90 MESES",
                Valor = 14

            };
            ComboBoxPrestamo opcion96Meses = new ComboBoxPrestamo
            {
                Texto = "96 MESES",
                Valor = 15

            };
            ComboBoxPrestamo opcion102Meses = new ComboBoxPrestamo
            {
                Texto = "102 MESES",
                Valor = 16

            };
            ComboBoxPrestamo opcion108Meses = new ComboBoxPrestamo
            {
                Texto = "114 MESES",
                Valor = 17

            };
            ComboBoxPrestamo opcion114Meses = new ComboBoxPrestamo
            {
                Texto = "114 MESES",
                Valor = 18

            };
            ComboBoxPrestamo opcion120Meses = new ComboBoxPrestamo
            {
                Texto = "120 MESES",
                Valor = 19

            };

            #endregion

            #region ASIGNANDOLE VALOR A LOS COMBOBOX PRESTAMO

            CBXSeleccionPrestamo.Items.Add(opcionDefecto);
            CBXSeleccionPrestamo.Items.Add(opcionPersonal);
            CBXSeleccionPrestamo.Items.Add(opcionAutomovil);
            CBXSeleccionPrestamo.Items.Add(opcionHipotecario);
            CBXSeleccionPrestamo.SelectedItem = opcionDefecto;

            #endregion

            #region ASIGNANDOLE VALOR A LOS COMBOBOX MESES

            CBXMesesAPagar.Items.Add(opcionDefecto);
            CBXMesesAPagar.Items.Add(opcion12Meses);
            CBXMesesAPagar.Items.Add(opcion18Meses);
            CBXMesesAPagar.Items.Add(opcion24Meses);
            CBXMesesAPagar.Items.Add(opcion30Meses);
            CBXMesesAPagar.Items.Add(opcion36Meses);
            CBXMesesAPagar.Items.Add(opcion42Meses);
            CBXMesesAPagar.Items.Add(opcion48Meses);
            CBXMesesAPagar.Items.Add(opcion54Meses);
            CBXMesesAPagar.Items.Add(opcion60Meses);
            CBXMesesAPagar.Items.Add(opcion66Meses);
            CBXMesesAPagar.Items.Add(opcion72Meses);
            CBXMesesAPagar.Items.Add(opcion78Meses);
            CBXMesesAPagar.Items.Add(opcion84Meses);
            CBXMesesAPagar.Items.Add(opcion90Meses);
            CBXMesesAPagar.Items.Add(opcion96Meses);
            CBXMesesAPagar.Items.Add(opcion102Meses);
            CBXMesesAPagar.Items.Add(opcion108Meses);
            CBXMesesAPagar.Items.Add(opcion114Meses);
            CBXMesesAPagar.Items.Add(opcion120Meses);
            CBXMesesAPagar.SelectedItem = opcionDefecto;

            #endregion
        }

        private void CargandoTxt()
        {
            #region ASIGNANDOLE VALOR AL TEXTBOX TASA DE INTERES

            ComboBoxPrestamo seleccion = CBXSeleccionPrestamo.SelectedItem as ComboBoxPrestamo;



            if (seleccion.Valor == null)
            {
                TxtTasaDeInteres.Text = "0%";

            }
            else if ((int)seleccion.Valor == 1)
            {
                TxtTasaDeInteres.Text = "22%";


            } else if ((int)seleccion.Valor == 2)
            {
                TxtTasaDeInteres.Text = "12%";

            }
            else if ((int)seleccion.Valor == 3)
            {
                TxtTasaDeInteres.Text = "8%";
            }


            #endregion

            #region ASIGNANDOLE VALOR AL TEXTBOX RESULTADO
            TxtResultado.Text = " - - - ";
            #endregion
        }
        #endregion

        #region VALIDANDO CAMPOS VACIOS
        private void Validar() 
        {
            #region VALIDANDO LOS CAMPOS
            try
            {
                ComboBoxPrestamo seleccionadoXDefectoPrestamo = CBXSeleccionPrestamo.SelectedItem as ComboBoxPrestamo;
                ComboBoxPrestamo seleccionadoXDefectoMeses = CBXMesesAPagar.SelectedItem as ComboBoxPrestamo;

                if (seleccionadoXDefectoPrestamo.Valor == null)
                {
                    MessageBox.Show("Usted Debe Seleccionar Un Tipo de Prestamo", "Informacion");

                }else if (seleccionadoXDefectoMeses.Valor == null)
                {
                    MessageBox.Show("Usted Debe Seleccionar Una Cantidad de Meses a Pagar", "Informacion");

                }
                else if (String.IsNullOrEmpty(TxtMonto.Text))
                {
                    MessageBox.Show("Usted Debe Facilitarme Un Monto ", "Informacion");

                }else
                {
                    Calculadora calculadora = new Calculadora();
                    int prestamo = (int)seleccionadoXDefectoPrestamo.Valor;
                    int meses = (int)seleccionadoXDefectoMeses.Valor;
                    double monto = Convert.ToDouble(TxtMonto.Text);

                    double resultado = calculadora.Calculando(prestamo, meses, monto);
                    TxtResultado.Text = resultado.ToString();
                    SeCalculo = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usted Debe Facilitarme Un Monto Numerico ", "ERROR");
            }
            #endregion
        }

        #endregion

        
    }


}
