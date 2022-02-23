
namespace AppPrestamos
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCalculadoraDePrestamos = new System.Windows.Forms.Label();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.CBXMesesAPagar = new System.Windows.Forms.ComboBox();
            this.lblSeleccioneModoPrestamo = new System.Windows.Forms.Label();
            this.lblCantidadDeMeses = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblLine3 = new System.Windows.Forms.Label();
            this.lblLine4 = new System.Windows.Forms.Label();
            this.TxtTasaDeInteres = new System.Windows.Forms.TextBox();
            this.lblTasaDeInteres = new System.Windows.Forms.Label();
            this.LblCuota = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.CBXSeleccionPrestamo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCalculadoraDePrestamos
            // 
            this.lblCalculadoraDePrestamos.AutoSize = true;
            this.lblCalculadoraDePrestamos.Font = new System.Drawing.Font("Courier New", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalculadoraDePrestamos.ForeColor = System.Drawing.Color.Cyan;
            this.lblCalculadoraDePrestamos.Location = new System.Drawing.Point(-13, 3);
            this.lblCalculadoraDePrestamos.Name = "lblCalculadoraDePrestamos";
            this.lblCalculadoraDePrestamos.Size = new System.Drawing.Size(701, 29);
            this.lblCalculadoraDePrestamos.TabIndex = 0;
            this.lblCalculadoraDePrestamos.Text = "--- Calculadora de Prestamos Personales ---";
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIngresar.ForeColor = System.Drawing.Color.Cyan;
            this.lblIngresar.Location = new System.Drawing.Point(125, 57);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(178, 18);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = "Ingrese el Monto:";
            // 
            // TxtMonto
            // 
            this.TxtMonto.BackColor = System.Drawing.Color.Black;
            this.TxtMonto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtMonto.ForeColor = System.Drawing.Color.White;
            this.TxtMonto.Location = new System.Drawing.Point(309, 57);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(152, 21);
            this.TxtMonto.TabIndex = 2;
            // 
            // CBXMesesAPagar
            // 
            this.CBXMesesAPagar.BackColor = System.Drawing.Color.Black;
            this.CBXMesesAPagar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBXMesesAPagar.ForeColor = System.Drawing.Color.White;
            this.CBXMesesAPagar.FormattingEnabled = true;
            this.CBXMesesAPagar.Location = new System.Drawing.Point(309, 144);
            this.CBXMesesAPagar.Name = "CBXMesesAPagar";
            this.CBXMesesAPagar.Size = new System.Drawing.Size(152, 23);
            this.CBXMesesAPagar.TabIndex = 6;
            // 
            // lblSeleccioneModoPrestamo
            // 
            this.lblSeleccioneModoPrestamo.AutoSize = true;
            this.lblSeleccioneModoPrestamo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccioneModoPrestamo.ForeColor = System.Drawing.Color.Cyan;
            this.lblSeleccioneModoPrestamo.Location = new System.Drawing.Point(125, 103);
            this.lblSeleccioneModoPrestamo.Name = "lblSeleccioneModoPrestamo";
            this.lblSeleccioneModoPrestamo.Size = new System.Drawing.Size(178, 18);
            this.lblSeleccioneModoPrestamo.TabIndex = 4;
            this.lblSeleccioneModoPrestamo.Text = "Tipo de Prestamo:";
            // 
            // lblCantidadDeMeses
            // 
            this.lblCantidadDeMeses.AutoSize = true;
            this.lblCantidadDeMeses.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadDeMeses.ForeColor = System.Drawing.Color.Cyan;
            this.lblCantidadDeMeses.Location = new System.Drawing.Point(125, 146);
            this.lblCantidadDeMeses.Name = "lblCantidadDeMeses";
            this.lblCantidadDeMeses.Size = new System.Drawing.Size(178, 18);
            this.lblCantidadDeMeses.TabIndex = 5;
            this.lblCantidadDeMeses.Text = "Meses Para Pagar:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Black;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.Color.Cyan;
            this.btnCalcular.Location = new System.Drawing.Point(125, 188);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(336, 33);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccion.ForeColor = System.Drawing.Color.Cyan;
            this.lblSeleccion.Location = new System.Drawing.Point(7, 123);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(118, 18);
            this.lblSeleccion.TabIndex = 8;
            this.lblSeleccion.Text = "Seleccionar";
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLine1.Location = new System.Drawing.Point(62, 142);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(62, 15);
            this.lblLine1.TabIndex = 9;
            this.lblLine1.Text = "___________";
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.BackColor = System.Drawing.Color.Transparent;
            this.lblLine2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLine2.Location = new System.Drawing.Point(62, 99);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(62, 15);
            this.lblLine2.TabIndex = 10;
            this.lblLine2.Text = "___________";
            // 
            // lblLine3
            // 
            this.lblLine3.AutoSize = true;
            this.lblLine3.BackColor = System.Drawing.Color.Transparent;
            this.lblLine3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLine3.Location = new System.Drawing.Point(61, 140);
            this.lblLine3.Name = "lblLine3";
            this.lblLine3.Size = new System.Drawing.Size(10, 15);
            this.lblLine3.TabIndex = 11;
            this.lblLine3.Text = "|";
            // 
            // lblLine4
            // 
            this.lblLine4.AutoSize = true;
            this.lblLine4.BackColor = System.Drawing.Color.Transparent;
            this.lblLine4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLine4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLine4.Location = new System.Drawing.Point(61, 113);
            this.lblLine4.Name = "lblLine4";
            this.lblLine4.Size = new System.Drawing.Size(10, 15);
            this.lblLine4.TabIndex = 12;
            this.lblLine4.Text = "|";
            // 
            // TxtTasaDeInteres
            // 
            this.TxtTasaDeInteres.BackColor = System.Drawing.Color.Black;
            this.TxtTasaDeInteres.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTasaDeInteres.ForeColor = System.Drawing.Color.White;
            this.TxtTasaDeInteres.Location = new System.Drawing.Point(497, 79);
            this.TxtTasaDeInteres.Name = "TxtTasaDeInteres";
            this.TxtTasaDeInteres.ReadOnly = true;
            this.TxtTasaDeInteres.Size = new System.Drawing.Size(152, 21);
            this.TxtTasaDeInteres.TabIndex = 13;
            // 
            // lblTasaDeInteres
            // 
            this.lblTasaDeInteres.AutoSize = true;
            this.lblTasaDeInteres.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTasaDeInteres.ForeColor = System.Drawing.Color.LightCyan;
            this.lblTasaDeInteres.Location = new System.Drawing.Point(495, 58);
            this.lblTasaDeInteres.Name = "lblTasaDeInteres";
            this.lblTasaDeInteres.Size = new System.Drawing.Size(158, 18);
            this.lblTasaDeInteres.TabIndex = 14;
            this.lblTasaDeInteres.Text = "Tasa De Interes";
            // 
            // LblCuota
            // 
            this.LblCuota.AutoSize = true;
            this.LblCuota.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCuota.ForeColor = System.Drawing.Color.LightCyan;
            this.LblCuota.Location = new System.Drawing.Point(504, 123);
            this.LblCuota.Name = "LblCuota";
            this.LblCuota.Size = new System.Drawing.Size(138, 18);
            this.LblCuota.TabIndex = 15;
            this.LblCuota.Text = "Cuota Mensual";
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.Color.Black;
            this.TxtResultado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultado.ForeColor = System.Drawing.Color.White;
            this.TxtResultado.Location = new System.Drawing.Point(497, 144);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(152, 21);
            this.TxtResultado.TabIndex = 16;
            // 
            // CBXSeleccionPrestamo
            // 
            this.CBXSeleccionPrestamo.BackColor = System.Drawing.Color.Black;
            this.CBXSeleccionPrestamo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBXSeleccionPrestamo.ForeColor = System.Drawing.Color.White;
            this.CBXSeleccionPrestamo.FormattingEnabled = true;
            this.CBXSeleccionPrestamo.Location = new System.Drawing.Point(309, 101);
            this.CBXSeleccionPrestamo.Name = "CBXSeleccionPrestamo";
            this.CBXSeleccionPrestamo.Size = new System.Drawing.Size(152, 23);
            this.CBXSeleccionPrestamo.TabIndex = 17;
            this.CBXSeleccionPrestamo.SelectedIndexChanged += new System.EventHandler(this.CBXSeleccionPrestamo_SelectedIndexChanged);
            this.CBXSeleccionPrestamo.DropDownClosed += new System.EventHandler(this.CBXSeleccionPrestamo_DropDownClosed);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(674, 244);
            this.Controls.Add(this.CBXSeleccionPrestamo);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.LblCuota);
            this.Controls.Add(this.lblTasaDeInteres);
            this.Controls.Add(this.TxtTasaDeInteres);
            this.Controls.Add(this.lblLine4);
            this.Controls.Add(this.lblLine3);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCantidadDeMeses);
            this.Controls.Add(this.lblSeleccioneModoPrestamo);
            this.Controls.Add(this.CBXMesesAPagar);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.lblCalculadoraDePrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmCalculadora";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora De Prestamos";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculadoraDePrestamos;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.ComboBox CBXMesesAPagar;
        private System.Windows.Forms.Label lblSeleccioneModoPrestamo;
        private System.Windows.Forms.Label lblCantidadDeMeses;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblLine3;
        private System.Windows.Forms.Label lblLine4;
        private System.Windows.Forms.TextBox TxtTasaDeInteres;
        private System.Windows.Forms.Label lblTasaDeInteres;
        private System.Windows.Forms.Label LblCuota;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.ComboBox CBXSeleccionPrestamo;
    }
}

