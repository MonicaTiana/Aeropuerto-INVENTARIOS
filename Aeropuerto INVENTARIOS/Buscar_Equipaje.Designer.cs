namespace Aeropuerto_INVENTARIOS
{
    partial class Buscar_Equipaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar_Equipaje));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOINVENTARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeropuerto_Inventarios1DataSet = new Aeropuerto_INVENTARIOS.Aeropuerto_Inventarios1DataSet();
            this.btv_volver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_departamento = new System.Windows.Forms.ComboBox();
            this.combo_area = new System.Windows.Forms.ComboBox();
            this.combo_nombre = new System.Windows.Forms.ComboBox();
            this.equipajeTableAdapter = new Aeropuerto_INVENTARIOS.Aeropuerto_Inventarios1DataSetTableAdapters.EquipajeTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuerto_Inventarios1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcodigoDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.pRECIODataGridViewTextBoxColumn,
            this.aREADataGridViewTextBoxColumn,
            this.dEPARTAMENTODataGridViewTextBoxColumn,
            this.mARCADataGridViewTextBoxColumn,
            this.mODELODataGridViewTextBoxColumn,
            this.tIPOINVENTARIODataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.equipajeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 255);
            this.dataGridView1.TabIndex = 39;
            // 
            // idcodigoDataGridViewTextBoxColumn
            // 
            this.idcodigoDataGridViewTextBoxColumn.DataPropertyName = "id_codigo";
            this.idcodigoDataGridViewTextBoxColumn.HeaderText = "id_codigo";
            this.idcodigoDataGridViewTextBoxColumn.Name = "idcodigoDataGridViewTextBoxColumn";
            this.idcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            // 
            // pRECIODataGridViewTextBoxColumn
            // 
            this.pRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.Name = "pRECIODataGridViewTextBoxColumn";
            // 
            // aREADataGridViewTextBoxColumn
            // 
            this.aREADataGridViewTextBoxColumn.DataPropertyName = "AREA";
            this.aREADataGridViewTextBoxColumn.HeaderText = "AREA";
            this.aREADataGridViewTextBoxColumn.Name = "aREADataGridViewTextBoxColumn";
            // 
            // dEPARTAMENTODataGridViewTextBoxColumn
            // 
            this.dEPARTAMENTODataGridViewTextBoxColumn.DataPropertyName = "DEPARTAMENTO";
            this.dEPARTAMENTODataGridViewTextBoxColumn.HeaderText = "DEPARTAMENTO";
            this.dEPARTAMENTODataGridViewTextBoxColumn.Name = "dEPARTAMENTODataGridViewTextBoxColumn";
            // 
            // mARCADataGridViewTextBoxColumn
            // 
            this.mARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA";
            this.mARCADataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.mARCADataGridViewTextBoxColumn.Name = "mARCADataGridViewTextBoxColumn";
            // 
            // mODELODataGridViewTextBoxColumn
            // 
            this.mODELODataGridViewTextBoxColumn.DataPropertyName = "MODELO";
            this.mODELODataGridViewTextBoxColumn.HeaderText = "MODELO";
            this.mODELODataGridViewTextBoxColumn.Name = "mODELODataGridViewTextBoxColumn";
            // 
            // tIPOINVENTARIODataGridViewTextBoxColumn
            // 
            this.tIPOINVENTARIODataGridViewTextBoxColumn.DataPropertyName = "TIPO_INVENTARIO";
            this.tIPOINVENTARIODataGridViewTextBoxColumn.HeaderText = "TIPO_INVENTARIO";
            this.tIPOINVENTARIODataGridViewTextBoxColumn.Name = "tIPOINVENTARIODataGridViewTextBoxColumn";
            // 
            // tIPODataGridViewTextBoxColumn
            // 
            this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            // 
            // equipajeBindingSource
            // 
            this.equipajeBindingSource.DataMember = "Equipaje";
            this.equipajeBindingSource.DataSource = this.aeropuerto_Inventarios1DataSet;
            // 
            // aeropuerto_Inventarios1DataSet
            // 
            this.aeropuerto_Inventarios1DataSet.DataSetName = "Aeropuerto_Inventarios1DataSet";
            this.aeropuerto_Inventarios1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btv_volver
            // 
            this.btv_volver.BackColor = System.Drawing.Color.Transparent;
            this.btv_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btv_volver.Location = new System.Drawing.Point(598, 66);
            this.btv_volver.Name = "btv_volver";
            this.btv_volver.Size = new System.Drawing.Size(98, 33);
            this.btv_volver.TabIndex = 38;
            this.btv_volver.Text = "Volver";
            this.btv_volver.UseVisualStyleBackColor = false;
            this.btv_volver.Click += new System.EventHandler(this.btv_volver_Click);
            this.btv_volver.MouseLeave += new System.EventHandler(this.btv_volver_MouseLeave);
            this.btv_volver.MouseHover += new System.EventHandler(this.btv_volver_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre";
            // 
            // combo_departamento
            // 
            this.combo_departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_departamento.FormattingEnabled = true;
            this.combo_departamento.Location = new System.Drawing.Point(375, 73);
            this.combo_departamento.Name = "combo_departamento";
            this.combo_departamento.Size = new System.Drawing.Size(130, 21);
            this.combo_departamento.TabIndex = 34;
            this.combo_departamento.SelectedIndexChanged += new System.EventHandler(this.combo_departamento_SelectedIndexChanged);
            // 
            // combo_area
            // 
            this.combo_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_area.FormattingEnabled = true;
            this.combo_area.Location = new System.Drawing.Point(198, 73);
            this.combo_area.Name = "combo_area";
            this.combo_area.Size = new System.Drawing.Size(132, 21);
            this.combo_area.TabIndex = 33;
            this.combo_area.SelectedIndexChanged += new System.EventHandler(this.combo_area_SelectedIndexChanged);
            // 
            // combo_nombre
            // 
            this.combo_nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_nombre.FormattingEnabled = true;
            this.combo_nombre.Location = new System.Drawing.Point(18, 73);
            this.combo_nombre.Name = "combo_nombre";
            this.combo_nombre.Size = new System.Drawing.Size(133, 21);
            this.combo_nombre.TabIndex = 32;
            this.combo_nombre.SelectedIndexChanged += new System.EventHandler(this.combo_nombre_SelectedIndexChanged);
            // 
            // equipajeTableAdapter
            // 
            this.equipajeTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 31);
            this.panel1.TabIndex = 82;
            // 
            // Buscar_Equipaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btv_volver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_departamento);
            this.Controls.Add(this.combo_area);
            this.Controls.Add(this.combo_nombre);
            this.Name = "Buscar_Equipaje";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar_Equipaje";
            this.Load += new System.EventHandler(this.Buscar_Equipaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuerto_Inventarios1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btv_volver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_departamento;
        private System.Windows.Forms.ComboBox combo_area;
        private System.Windows.Forms.ComboBox combo_nombre;
        private Aeropuerto_Inventarios1DataSet aeropuerto_Inventarios1DataSet;
        private System.Windows.Forms.BindingSource equipajeBindingSource;
        private Aeropuerto_Inventarios1DataSetTableAdapters.EquipajeTableAdapter equipajeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOINVENTARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}