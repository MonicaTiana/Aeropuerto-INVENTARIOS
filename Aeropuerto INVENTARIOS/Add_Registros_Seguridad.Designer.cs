namespace Aeropuerto_INVENTARIOS
{
    partial class Add_Registros_Seguridad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Registros_Seguridad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.Num_serie = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxtipo = new System.Windows.Forms.ComboBox();
            this.comboBoxtipoinv = new System.Windows.Forms.ComboBox();
            this.comboBoxdepa = new System.Windows.Forms.ComboBox();
            this.comboBoxarea = new System.Windows.Forms.ComboBox();
            this.Precio = new System.Windows.Forms.Label();
            this.lbCan = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbnserie = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.btn_borrar);
            this.panel1.Controls.Add(this.Num_serie);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_regresar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxtipo);
            this.panel1.Controls.Add(this.comboBoxtipoinv);
            this.panel1.Controls.Add(this.comboBoxdepa);
            this.panel1.Controls.Add(this.comboBoxarea);
            this.panel1.Controls.Add(this.Precio);
            this.panel1.Controls.Add(this.lbCan);
            this.panel1.Controls.Add(this.lbnombre);
            this.panel1.Controls.Add(this.lbnserie);
            this.panel1.Controls.Add(this.txtmodelo);
            this.panel1.Controls.Add(this.txtmarca);
            this.panel1.Controls.Add(this.txtprecio);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Location = new System.Drawing.Point(72, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 404);
            this.panel1.TabIndex = 49;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(383, 54);
            this.txt_fecha.Mask = "00/00/0000 00:00";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(123, 20);
            this.txt_fecha.TabIndex = 126;
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Fecha:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(611, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 123;
            this.button1.Text = "Eliminar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.White;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(611, 133);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 32);
            this.btn_modificar.TabIndex = 122;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.White;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(611, 213);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 34);
            this.btn_buscar.TabIndex = 121;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Location = new System.Drawing.Point(611, 326);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 27);
            this.btn_borrar.TabIndex = 65;
            this.btn_borrar.Text = "Limpiar";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // Num_serie
            // 
            this.Num_serie.AutoSize = true;
            this.Num_serie.Location = new System.Drawing.Point(112, 21);
            this.Num_serie.Name = "Num_serie";
            this.Num_serie.Size = new System.Drawing.Size(0, 13);
            this.Num_serie.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Tipo:";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Location = new System.Drawing.Point(611, 368);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 32);
            this.btn_regresar.TabIndex = 46;
            this.btn_regresar.Text = "Menu";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Tipo de inventario:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(611, 93);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 30);
            this.btn_agregar.TabIndex = 45;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Departamento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Area:";
            // 
            // comboBoxtipo
            // 
            this.comboBoxtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtipo.FormattingEnabled = true;
            this.comboBoxtipo.Location = new System.Drawing.Point(114, 368);
            this.comboBoxtipo.Name = "comboBoxtipo";
            this.comboBoxtipo.Size = new System.Drawing.Size(151, 21);
            this.comboBoxtipo.TabIndex = 57;
            // 
            // comboBoxtipoinv
            // 
            this.comboBoxtipoinv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtipoinv.FormattingEnabled = true;
            this.comboBoxtipoinv.Location = new System.Drawing.Point(114, 332);
            this.comboBoxtipoinv.Name = "comboBoxtipoinv";
            this.comboBoxtipoinv.Size = new System.Drawing.Size(151, 21);
            this.comboBoxtipoinv.TabIndex = 56;
            // 
            // comboBoxdepa
            // 
            this.comboBoxdepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxdepa.FormattingEnabled = true;
            this.comboBoxdepa.Location = new System.Drawing.Point(114, 213);
            this.comboBoxdepa.Name = "comboBoxdepa";
            this.comboBoxdepa.Size = new System.Drawing.Size(151, 21);
            this.comboBoxdepa.TabIndex = 55;
            // 
            // comboBoxarea
            // 
            this.comboBoxarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxarea.FormattingEnabled = true;
            this.comboBoxarea.Location = new System.Drawing.Point(114, 174);
            this.comboBoxarea.Name = "comboBoxarea";
            this.comboBoxarea.Size = new System.Drawing.Size(151, 21);
            this.comboBoxarea.TabIndex = 54;
            this.comboBoxarea.SelectedIndexChanged += new System.EventHandler(this.comboBoxarea_SelectedIndexChanged);
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(27, 137);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(46, 13);
            this.Precio.TabIndex = 53;
            this.Precio.Text = "Precio $";
            // 
            // lbCan
            // 
            this.lbCan.AutoSize = true;
            this.lbCan.Location = new System.Drawing.Point(29, 97);
            this.lbCan.Name = "lbCan";
            this.lbCan.Size = new System.Drawing.Size(55, 13);
            this.lbCan.TabIndex = 52;
            this.lbCan.Text = "Cantidad: ";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(27, 57);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(47, 13);
            this.lbnombre.TabIndex = 51;
            this.lbnombre.Text = "Nombre:";
            // 
            // lbnserie
            // 
            this.lbnserie.AutoSize = true;
            this.lbnserie.Location = new System.Drawing.Point(27, 21);
            this.lbnserie.Name = "lbnserie";
            this.lbnserie.Size = new System.Drawing.Size(46, 13);
            this.lbnserie.TabIndex = 50;
            this.lbnserie.Text = "Codigo: ";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(114, 296);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(151, 20);
            this.txtmodelo.TabIndex = 49;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(114, 258);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(151, 20);
            this.txtmarca.TabIndex = 48;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(114, 130);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(151, 20);
            this.txtprecio.TabIndex = 47;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(114, 90);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(151, 20);
            this.txtcantidad.TabIndex = 46;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(114, 50);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(151, 20);
            this.txtnombre.TabIndex = 45;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(753, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 31);
            this.panel2.TabIndex = 117;
            // 
            // Add_Registros_Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Registros_Seguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Registros_Seguridad";
            this.Load += new System.EventHandler(this.Add_Registros_Seguridad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Label Num_serie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxtipo;
        private System.Windows.Forms.ComboBox comboBoxtipoinv;
        private System.Windows.Forms.ComboBox comboBoxdepa;
        private System.Windows.Forms.ComboBox comboBoxarea;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label lbCan;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbnserie;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_fecha;
    }
}