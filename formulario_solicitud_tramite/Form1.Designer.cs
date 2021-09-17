
namespace formulario_solicitud_tramite
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnguardar = new System.Windows.Forms.Button();
            this.tbprimapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbsegunapellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtipodoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbnumdoc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbplaca = new System.Windows.Forms.TextBox();
            this.cbtipovehi = new System.Windows.Forms.ComboBox();
            this.tbcapacidadvehi = new System.Windows.Forms.TextBox();
            this.cbcombusvehi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbcoloresvehi = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbmarcavehiculo = new System.Windows.Forms.TextBox();
            this.btnmenuguar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(357, 359);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(126, 63);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbprimapellido
            // 
            this.tbprimapellido.Location = new System.Drawing.Point(3, 131);
            this.tbprimapellido.Name = "tbprimapellido";
            this.tbprimapellido.Size = new System.Drawing.Size(126, 22);
            this.tbprimapellido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primer apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Propietario";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbnumdoc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbtipodoc);
            this.panel1.Controls.Add(this.tbnombres);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbsegunapellido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbprimapellido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 311);
            this.panel1.TabIndex = 6;
            // 
            // tbsegunapellido
            // 
            this.tbsegunapellido.Location = new System.Drawing.Point(135, 131);
            this.tbsegunapellido.Name = "tbsegunapellido";
            this.tbsegunapellido.Size = new System.Drawing.Size(117, 22);
            this.tbsegunapellido.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Segundo apellido";
            // 
            // tbnombres
            // 
            this.tbnombres.Location = new System.Drawing.Point(261, 131);
            this.tbnombres.Name = "tbnombres";
            this.tbnombres.Size = new System.Drawing.Size(117, 22);
            this.tbnombres.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombres";
            // 
            // cbtipodoc
            // 
            this.cbtipodoc.FormattingEnabled = true;
            this.cbtipodoc.Items.AddRange(new object[] {
            "C.C",
            "NIT",
            "N.N",
            "Pasaporte",
            "C. Extranjera",
            "T.Identidad",
            "Nuip",
            "C.Diplomatico"});
            this.cbtipodoc.Location = new System.Drawing.Point(16, 232);
            this.cbtipodoc.Name = "cbtipodoc";
            this.cbtipodoc.Size = new System.Drawing.Size(121, 24);
            this.cbtipodoc.TabIndex = 10;
            this.cbtipodoc.TextUpdate += new System.EventHandler(this.cbtipodoc_TextUpdate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "No. Documento";
            // 
            // tbnumdoc
            // 
            this.tbnumdoc.Location = new System.Drawing.Point(207, 232);
            this.tbnumdoc.Name = "tbnumdoc";
            this.tbnumdoc.Size = new System.Drawing.Size(133, 22);
            this.tbnumdoc.TabIndex = 13;
            this.tbnumdoc.TextChanged += new System.EventHandler(this.tbnumdoc_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbmarcavehiculo);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cbcoloresvehi);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbcombusvehi);
            this.panel2.Controls.Add(this.tbcapacidadvehi);
            this.panel2.Controls.Add(this.cbtipovehi);
            this.panel2.Controls.Add(this.tbplaca);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(430, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 311);
            this.panel2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Carro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Placa";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(15, 386);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 22);
            this.dtpfecha.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fecha";
            // 
            // tbplaca
            // 
            this.tbplaca.Location = new System.Drawing.Point(33, 106);
            this.tbplaca.Name = "tbplaca";
            this.tbplaca.Size = new System.Drawing.Size(121, 22);
            this.tbplaca.TabIndex = 2;
            // 
            // cbtipovehi
            // 
            this.cbtipovehi.FormattingEnabled = true;
            this.cbtipovehi.Items.AddRange(new object[] {
            "Automovil",
            "Bus",
            "Buseta",
            "Camion",
            "Camioneta",
            "Campero",
            "Microbus",
            "Tractocamion",
            "Motocicleta",
            "Motocarro",
            "Mototriciclo",
            "Cuatrimoto",
            "Volqueta",
            "Otro"});
            this.cbtipovehi.Location = new System.Drawing.Point(205, 104);
            this.cbtipovehi.Name = "cbtipovehi";
            this.cbtipovehi.Size = new System.Drawing.Size(121, 24);
            this.cbtipovehi.TabIndex = 5;
            // 
            // tbcapacidadvehi
            // 
            this.tbcapacidadvehi.Location = new System.Drawing.Point(226, 268);
            this.tbcapacidadvehi.Name = "tbcapacidadvehi";
            this.tbcapacidadvehi.Size = new System.Drawing.Size(56, 22);
            this.tbcapacidadvehi.TabIndex = 6;
            this.tbcapacidadvehi.TextChanged += new System.EventHandler(this.tbcapacidadvehi_TextChanged);
            // 
            // cbcombusvehi
            // 
            this.cbcombusvehi.FormattingEnabled = true;
            this.cbcombusvehi.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "Gas",
            "Mixto",
            "Electronico",
            "Hidrogeno",
            "Etanol",
            "Biodiesel"});
            this.cbcombusvehi.Location = new System.Drawing.Point(205, 186);
            this.cbcombusvehi.Name = "cbcombusvehi";
            this.cbcombusvehi.Size = new System.Drawing.Size(121, 24);
            this.cbcombusvehi.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tipo de Vehiculo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Marca";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(223, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Combustible";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Colores";
            // 
            // cbcoloresvehi
            // 
            this.cbcoloresvehi.FormattingEnabled = true;
            this.cbcoloresvehi.Items.AddRange(new object[] {
            "Rojo",
            "Amarillo",
            "Blanco",
            "Azul",
            "Negro",
            "Rosa",
            "Morado",
            "Naranja",
            "Gris"});
            this.cbcoloresvehi.Location = new System.Drawing.Point(33, 268);
            this.cbcoloresvehi.Name = "cbcoloresvehi";
            this.cbcoloresvehi.Size = new System.Drawing.Size(121, 24);
            this.cbcoloresvehi.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(223, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Capacidad";
            // 
            // tbmarcavehiculo
            // 
            this.tbmarcavehiculo.Location = new System.Drawing.Point(33, 193);
            this.tbmarcavehiculo.Name = "tbmarcavehiculo";
            this.tbmarcavehiculo.Size = new System.Drawing.Size(121, 22);
            this.tbmarcavehiculo.TabIndex = 10;
            // 
            // btnmenuguar
            // 
            this.btnmenuguar.Location = new System.Drawing.Point(713, 428);
            this.btnmenuguar.Name = "btnmenuguar";
            this.btnmenuguar.Size = new System.Drawing.Size(85, 40);
            this.btnmenuguar.TabIndex = 10;
            this.btnmenuguar.Text = "Menu";
            this.btnmenuguar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(828, 480);
            this.Controls.Add(this.btnmenuguar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnguardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox tbprimapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbtipodoc;
        private System.Windows.Forms.TextBox tbnombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbsegunapellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnumdoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbcombusvehi;
        private System.Windows.Forms.TextBox tbcapacidadvehi;
        private System.Windows.Forms.ComboBox cbtipovehi;
        private System.Windows.Forms.TextBox tbplaca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbcoloresvehi;
        private System.Windows.Forms.TextBox tbmarcavehiculo;
        private System.Windows.Forms.Button btnmenuguar;
    }
}

