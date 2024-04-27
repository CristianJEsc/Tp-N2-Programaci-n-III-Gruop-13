namespace Gestion_de_Articulos
{
    partial class frm_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.pb_Imagen = new System.Windows.Forms.PictureBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dgv_Articulos = new System.Windows.Forms.DataGridView();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.tb_Buscador = new System.Windows.Forms.TextBox();
            this.btn_Detalle = new System.Windows.Forms.Button();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_Campo = new System.Windows.Forms.ComboBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.cbo_Criterio = new System.Windows.Forms.ComboBox();
            this.lbl_Criterio = new System.Windows.Forms.Label();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.tbx_Filtro = new System.Windows.Forms.TextBox();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Agregar.Location = new System.Drawing.Point(178, 366);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(92, 35);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pb_Imagen
            // 
            this.pb_Imagen.InitialImage = null;
            this.pb_Imagen.Location = new System.Drawing.Point(577, 47);
            this.pb_Imagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_Imagen.Name = "pb_Imagen";
            this.pb_Imagen.Size = new System.Drawing.Size(297, 314);
            this.pb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagen.TabIndex = 59;
            this.pb_Imagen.TabStop = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(483, 366);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(92, 35);
            this.btn_Eliminar.TabIndex = 8;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // dgv_Articulos
            // 
            this.dgv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Articulos.Location = new System.Drawing.Point(26, 47);
            this.dgv_Articulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Articulos.MultiSelect = false;
            this.dgv_Articulos.Name = "dgv_Articulos";
            this.dgv_Articulos.RowHeadersWidth = 62;
            this.dgv_Articulos.RowTemplate.Height = 28;
            this.dgv_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Articulos.Size = new System.Drawing.Size(547, 314);
            this.dgv_Articulos.TabIndex = 9;
            this.dgv_Articulos.SelectionChanged += new System.EventHandler(this.dgv_Articulos_SelectionChanged);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Editar.Location = new System.Drawing.Point(333, 366);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(92, 35);
            this.btn_Editar.TabIndex = 7;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // tb_Buscador
            // 
            this.tb_Buscador.BackColor = System.Drawing.Color.AliceBlue;
            this.tb_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Buscador.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_Buscador.Location = new System.Drawing.Point(113, 10);
            this.tb_Buscador.Name = "tb_Buscador";
            this.tb_Buscador.Size = new System.Drawing.Size(462, 26);
            this.tb_Buscador.TabIndex = 60;
            this.tb_Buscador.TextChanged += new System.EventHandler(this.tb_Buscador_TextChanged);
            // 
            // btn_Detalle
            // 
            this.btn_Detalle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Detalle.Location = new System.Drawing.Point(26, 366);
            this.btn_Detalle.Name = "btn_Detalle";
            this.btn_Detalle.Size = new System.Drawing.Size(92, 35);
            this.btn_Detalle.TabIndex = 62;
            this.btn_Detalle.Text = "Detalle";
            this.btn_Detalle.UseVisualStyleBackColor = false;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(dominio.Articulo);
            // 
            // cbo_Campo
            // 
            this.cbo_Campo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_Campo.BackColor = System.Drawing.Color.AliceBlue;
            this.cbo_Campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Campo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbo_Campo.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbo_Campo.FormattingEnabled = true;
            this.cbo_Campo.Location = new System.Drawing.Point(97, 413);
            this.cbo_Campo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_Campo.Name = "cbo_Campo";
            this.cbo_Campo.Size = new System.Drawing.Size(182, 28);
            this.cbo_Campo.TabIndex = 64;
            this.cbo_Campo.SelectedIndexChanged += new System.EventHandler(this.cbo_Campo_SelectedIndexChanged);
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Marca.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Marca.Location = new System.Drawing.Point(22, 413);
            this.lbl_Marca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(82, 24);
            this.lbl_Marca.TabIndex = 65;
            this.lbl_Marca.Text = "Campo:";
            // 
            // cbo_Criterio
            // 
            this.cbo_Criterio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_Criterio.BackColor = System.Drawing.Color.AliceBlue;
            this.cbo_Criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Criterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbo_Criterio.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbo_Criterio.FormattingEnabled = true;
            this.cbo_Criterio.Location = new System.Drawing.Point(359, 413);
            this.cbo_Criterio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_Criterio.Name = "cbo_Criterio";
            this.cbo_Criterio.Size = new System.Drawing.Size(182, 28);
            this.cbo_Criterio.TabIndex = 66;
            // 
            // lbl_Criterio
            // 
            this.lbl_Criterio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Criterio.AutoSize = true;
            this.lbl_Criterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Criterio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Criterio.Location = new System.Drawing.Point(281, 417);
            this.lbl_Criterio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Criterio.Name = "lbl_Criterio";
            this.lbl_Criterio.Size = new System.Drawing.Size(83, 24);
            this.lbl_Criterio.TabIndex = 67;
            this.lbl_Criterio.Text = "Criterio:";
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Buscar.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Buscar.Location = new System.Drawing.Point(8, 12);
            this.lbl_Buscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(104, 24);
            this.lbl_Buscar.TabIndex = 68;
            this.lbl_Buscar.Text = "Buscador:";
            // 
            // tbx_Filtro
            // 
            this.tbx_Filtro.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Filtro.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Filtro.Location = new System.Drawing.Point(610, 408);
            this.tbx_Filtro.Multiline = true;
            this.tbx_Filtro.Name = "tbx_Filtro";
            this.tbx_Filtro.Size = new System.Drawing.Size(182, 31);
            this.tbx_Filtro.TabIndex = 69;
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filtro.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Filtro.Location = new System.Drawing.Point(543, 413);
            this.lbl_Filtro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(63, 24);
            this.lbl_Filtro.TabIndex = 70;
            this.lbl_Filtro.Text = "Filtro:";
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filtrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Filtrar.Location = new System.Drawing.Point(796, 408);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(92, 35);
            this.btn_Filtrar.TabIndex = 71;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = false;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 456);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.tbx_Filtro);
            this.Controls.Add(this.lbl_Filtro);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.cbo_Criterio);
            this.Controls.Add(this.lbl_Criterio);
            this.Controls.Add(this.cbo_Campo);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.btn_Detalle);
            this.Controls.Add(this.tb_Buscador);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.pb_Imagen);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dgv_Articulos);
            this.Controls.Add(this.btn_Editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATÁLOGO";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.PictureBox pb_Imagen;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dgv_Articulos;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private System.Windows.Forms.TextBox tb_Buscador;
        private System.Windows.Forms.Button btn_Detalle;
        public System.Windows.Forms.ComboBox cbo_Campo;
        private System.Windows.Forms.Label lbl_Marca;
        public System.Windows.Forms.ComboBox cbo_Criterio;
        private System.Windows.Forms.Label lbl_Criterio;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.TextBox tbx_Filtro;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.Button btn_Filtrar;
    }
}

