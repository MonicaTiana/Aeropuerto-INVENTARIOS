﻿namespace Aeropuerto_INVENTARIOS
{
    partial class BuscarMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarMantenimiento));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btv_volver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_departamneto = new System.Windows.Forms.ComboBox();
            this.combo_area = new System.Windows.Forms.ComboBox();
            this.combo_nombre = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aeropuerto_Inventarios1DataSet = new Aeropuerto_INVENTARIOS.Aeropuerto_Inventarios1DataSet();
            this.mantenimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimentoTableAdapter = new Aeropuerto_INVENTARIOS.Aeropuerto_Inventarios1DataSetTableAdapters.MantenimentoTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuerto_Inventarios1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.DataSource = this.mantenimentoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 266);
            this.dataGridView1.TabIndex = 47;
            // 
            // btv_volver
            // 
            this.btv_volver.BackColor = System.Drawing.Color.Transparent;
            this.btv_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btv_volver.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btv_volver.Location = new System.Drawing.Point(559, 83);
            this.btv_volver.Name = "btv_volver";
            this.btv_volver.Size = new System.Drawing.Size(90, 33);
            this.btv_volver.TabIndex = 46;
            this.btv_volver.Text = "Volver";
            this.btv_volver.UseVisualStyleBackColor = false;
            this.btv_volver.Click += new System.EventHandler(this.btv_volver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre";
            // 
            // combo_departamneto
            // 
            this.combo_departamneto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_departamneto.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_departamneto.FormattingEnabled = true;
            this.combo_departamneto.Location = new System.Drawing.Point(359, 89);
            this.combo_departamneto.Name = "combo_departamneto";
            this.combo_departamneto.Size = new System.Drawing.Size(132, 23);
            this.combo_departamneto.TabIndex = 42;
            this.combo_departamneto.SelectedIndexChanged += new System.EventHandler(this.combo_departamneto_SelectedIndexChanged);
            // 
            // combo_area
            // 
            this.combo_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_area.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_area.FormattingEnabled = true;
            this.combo_area.Location = new System.Drawing.Point(187, 89);
            this.combo_area.Name = "combo_area";
            this.combo_area.Size = new System.Drawing.Size(132, 23);
            this.combo_area.TabIndex = 41;
            this.combo_area.SelectedIndexChanged += new System.EventHandler(this.combo_area_SelectedIndexChanged);
            // 
            // combo_nombre
            // 
            this.combo_nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_nombre.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_nombre.FormattingEnabled = true;
            this.combo_nombre.Location = new System.Drawing.Point(21, 89);
            this.combo_nombre.Name = "combo_nombre";
            this.combo_nombre.Size = new System.Drawing.Size(132, 23);
            this.combo_nombre.TabIndex = 40;
            this.combo_nombre.SelectedIndexChanged += new System.EventHandler(this.combo_nombre_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 31);
            this.panel1.TabIndex = 84;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // aeropuerto_Inventarios1DataSet
            // 
            this.aeropuerto_Inventarios1DataSet.DataSetName = "Aeropuerto_Inventarios1DataSet";
            this.aeropuerto_Inventarios1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mantenimentoBindingSource
            // 
            this.mantenimentoBindingSource.DataMember = "Mantenimento";
            this.mantenimentoBindingSource.DataSource = this.aeropuerto_Inventarios1DataSet;
            // 
            // mantenimentoTableAdapter
            // 
            this.mantenimentoTableAdapter.ClearBeforeFill = true;
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
            // BuscarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btv_volver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_departamneto);
            this.Controls.Add(this.combo_area);
            this.Controls.Add(this.combo_nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarMantenimiento";
            this.Load += new System.EventHandler(this.BuscarMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuerto_Inventarios1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btv_volver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_departamneto;
        private System.Windows.Forms.ComboBox combo_area;
        private System.Windows.Forms.ComboBox combo_nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Aeropuerto_Inventarios1DataSet aeropuerto_Inventarios1DataSet;
        private System.Windows.Forms.BindingSource mantenimentoBindingSource;
        private Aeropuerto_Inventarios1DataSetTableAdapters.MantenimentoTableAdapter mantenimentoTableAdapter;
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
    }
}