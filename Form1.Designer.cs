namespace Calculadora
{
    partial class Form1
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
            lblOperacion = new Label();
            txtPantalla = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            btnDivision = new Button();
            btnMultiplicacion = new Button();
            btnSiete = new Button();
            btnCuatro = new Button();
            btnUno = new Button();
            btnCambiarSigno = new Button();
            btnCero = new Button();
            btnDos = new Button();
            btnCinco = new Button();
            btnOcho = new Button();
            btnNueve = new Button();
            btnResta = new Button();
            btnSeis = new Button();
            btnSuma = new Button();
            btnIgual = new Button();
            btnDecimal = new Button();
            btnTres = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblOperacion
            // 
            lblOperacion.ForeColor = SystemColors.GrayText;
            lblOperacion.Location = new Point(0, 9);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(320, 20);
            lblOperacion.TabIndex = 0;
            lblOperacion.Text = "Listo para calcular";
            lblOperacion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPantalla
            // 
            txtPantalla.Font = new Font("Segoe UI", 15F);
            txtPantalla.Location = new Point(0, 32);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(320, 47);
            txtPantalla.TabIndex = 1;
            txtPantalla.Text = "0";
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnLimpiar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBorrar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnDivision, 2, 0);
            tableLayoutPanel1.Controls.Add(btnMultiplicacion, 3, 0);
            tableLayoutPanel1.Controls.Add(btnSiete, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCuatro, 0, 2);
            tableLayoutPanel1.Controls.Add(btnUno, 0, 3);
            tableLayoutPanel1.Controls.Add(btnCambiarSigno, 0, 4);
            tableLayoutPanel1.Controls.Add(btnCero, 1, 4);
            tableLayoutPanel1.Controls.Add(btnDos, 1, 3);
            tableLayoutPanel1.Controls.Add(btnCinco, 1, 2);
            tableLayoutPanel1.Controls.Add(btnOcho, 1, 1);
            tableLayoutPanel1.Controls.Add(btnNueve, 2, 1);
            tableLayoutPanel1.Controls.Add(btnResta, 3, 1);
            tableLayoutPanel1.Controls.Add(btnSeis, 2, 2);
            tableLayoutPanel1.Controls.Add(btnSuma, 3, 2);
            tableLayoutPanel1.Controls.Add(btnIgual, 3, 3);
            tableLayoutPanel1.Controls.Add(btnDecimal, 2, 4);
            tableLayoutPanel1.Controls.Add(btnTres, 2, 3);
            tableLayoutPanel1.Location = new Point(0, 85);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(320, 350);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gainsboro;
            btnLimpiar.Location = new Point(3, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(74, 64);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "C";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Gainsboro;
            btnBorrar.Location = new Point(83, 3);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(74, 64);
            btnBorrar.TabIndex = 0;
            btnBorrar.Text = "<-";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.FromArgb(255, 214, 153);
            btnDivision.Location = new Point(163, 3);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(74, 64);
            btnDivision.TabIndex = 0;
            btnDivision.Tag = "/";
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += BotonOperador_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.BackColor = Color.FromArgb(255, 214, 153);
            btnMultiplicacion.Location = new Point(243, 3);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(74, 64);
            btnMultiplicacion.TabIndex = 0;
            btnMultiplicacion.Tag = "*";
            btnMultiplicacion.Text = "x";
            btnMultiplicacion.UseVisualStyleBackColor = false;
            btnMultiplicacion.Click += BotonOperador_Click;
            // 
            // btnSiete
            // 
            btnSiete.BackColor = Color.WhiteSmoke;
            btnSiete.Location = new Point(3, 73);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(74, 64);
            btnSiete.TabIndex = 0;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = false;
            btnSiete.Click += BotonDigito_Click;
            // 
            // btnCuatro
            // 
            btnCuatro.BackColor = Color.WhiteSmoke;
            btnCuatro.Location = new Point(3, 143);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(74, 64);
            btnCuatro.TabIndex = 0;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = false;
            btnCuatro.Click += BotonDigito_Click;
            // 
            // btnUno
            // 
            btnUno.BackColor = Color.WhiteSmoke;
            btnUno.Location = new Point(3, 213);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(74, 64);
            btnUno.TabIndex = 0;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += BotonDigito_Click;
            // 
            // btnCambiarSigno
            // 
            btnCambiarSigno.BackColor = Color.WhiteSmoke;
            btnCambiarSigno.Location = new Point(3, 283);
            btnCambiarSigno.Name = "btnCambiarSigno";
            btnCambiarSigno.Size = new Size(74, 64);
            btnCambiarSigno.TabIndex = 0;
            btnCambiarSigno.Text = "+/-";
            btnCambiarSigno.UseVisualStyleBackColor = false;
            btnCambiarSigno.Click += btnCambiarSigno_Click;
            // 
            // btnCero
            // 
            btnCero.BackColor = Color.WhiteSmoke;
            btnCero.Location = new Point(83, 283);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(74, 64);
            btnCero.TabIndex = 0;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = false;
            btnCero.Click += BotonDigito_Click;
            // 
            // btnDos
            // 
            btnDos.BackColor = Color.WhiteSmoke;
            btnDos.Location = new Point(83, 213);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(74, 64);
            btnDos.TabIndex = 0;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += BotonDigito_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.WhiteSmoke;
            btnCinco.Location = new Point(83, 143);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(74, 64);
            btnCinco.TabIndex = 0;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += BotonDigito_Click;
            // 
            // btnOcho
            // 
            btnOcho.BackColor = Color.WhiteSmoke;
            btnOcho.Location = new Point(83, 73);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(74, 64);
            btnOcho.TabIndex = 0;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = false;
            btnOcho.Click += BotonDigito_Click;
            // 
            // btnNueve
            // 
            btnNueve.BackColor = Color.WhiteSmoke;
            btnNueve.Location = new Point(163, 73);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(74, 64);
            btnNueve.TabIndex = 0;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = false;
            btnNueve.Click += BotonDigito_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.FromArgb(255, 214, 153);
            btnResta.Location = new Point(243, 73);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(74, 64);
            btnResta.TabIndex = 0;
            btnResta.Tag = "-";
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += BotonOperador_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.WhiteSmoke;
            btnSeis.Location = new Point(163, 143);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(74, 64);
            btnSeis.TabIndex = 0;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += BotonDigito_Click;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.FromArgb(255, 214, 153);
            btnSuma.Location = new Point(243, 143);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(74, 64);
            btnSuma.TabIndex = 0;
            btnSuma.Tag = "+";
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += BotonOperador_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.FromArgb(140, 182, 255);
            btnIgual.Location = new Point(243, 213);
            btnIgual.Name = "btnIgual";
            tableLayoutPanel1.SetRowSpan(btnIgual, 2);
            btnIgual.Size = new Size(74, 128);
            btnIgual.TabIndex = 0;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.WhiteSmoke;
            btnDecimal.Location = new Point(163, 283);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(74, 64);
            btnDecimal.TabIndex = 0;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += BotonDigito_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.WhiteSmoke;
            btnTres.Location = new Point(163, 213);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(74, 64);
            btnTres.TabIndex = 0;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += BotonDigito_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 444);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtPantalla);
            Controls.Add(lblOperacion);
            Name = "Form1";
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOperacion;
        private TextBox txtPantalla;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLimpiar;
        private Button btnBorrar;
        private Button btnDivision;
        private Button btnMultiplicacion;
        private Button btnSiete;
        private Button btnCuatro;
        private Button btnUno;
        private Button btnCambiarSigno;
        private Button btnCero;
        private Button btnDos;
        private Button btnCinco;
        private Button btnOcho;
        private Button btnNueve;
        private Button btnResta;
        private Button btnSeis;
        private Button btnSuma;
        private Button btnIgual;
        private Button btnDecimal;
        private Button btnTres;
    }
}
