namespace Gestion_de_Articulos
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.pb_Agregar_Imagen = new System.Windows.Forms.PictureBox();
            this.cbx_Marca = new System.Windows.Forms.ComboBox();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbx_Precio = new System.Windows.Forms.TextBox();
            this.tbx_Descripcion = new System.Windows.Forms.TextBox();
            this.tbx_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dgv_Articulos = new System.Windows.Forms.DataGridView();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.tbx_Codigo = new System.Windows.Forms.TextBox();
            this.cbx_Categoria = new System.Windows.Forms.ComboBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Agregar_Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Agregar.Location = new System.Drawing.Point(1112, 396);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(138, 54);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pb_Agregar_Imagen
            // 
            this.pb_Agregar_Imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Agregar_Imagen.Image = ((System.Drawing.Image)(resources.GetObject("pb_Agregar_Imagen.Image")));
            this.pb_Agregar_Imagen.InitialImage = null;
            this.pb_Agregar_Imagen.Location = new System.Drawing.Point(106, 38);
            this.pb_Agregar_Imagen.Name = "pb_Agregar_Imagen";
            this.pb_Agregar_Imagen.Size = new System.Drawing.Size(290, 290);
            this.pb_Agregar_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Agregar_Imagen.TabIndex = 59;
            this.pb_Agregar_Imagen.TabStop = false;
            // 
            // cbx_Marca
            // 
            this.cbx_Marca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Marca.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbx_Marca.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbx_Marca.FormattingEnabled = true;
            this.cbx_Marca.Location = new System.Drawing.Point(185, 494);
            this.cbx_Marca.Name = "cbx_Marca";
            this.cbx_Marca.Size = new System.Drawing.Size(236, 37);
            this.cbx_Marca.TabIndex = 3;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(Gestion_de_Articulos.Articulo);
            // 
            // tbx_Precio
            // 
            this.tbx_Precio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Precio.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Precio.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Precio.Location = new System.Drawing.Point(184, 449);
            this.tbx_Precio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_Precio.Multiline = true;
            this.tbx_Precio.Name = "tbx_Precio";
            this.tbx_Precio.Size = new System.Drawing.Size(236, 37);
            this.tbx_Precio.TabIndex = 2;
            // 
            // tbx_Descripcion
            // 
            this.tbx_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Descripcion.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Descripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Descripcion.Location = new System.Drawing.Point(526, 396);
            this.tbx_Descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_Descripcion.Multiline = true;
            this.tbx_Descripcion.Name = "tbx_Descripcion";
            this.tbx_Descripcion.Size = new System.Drawing.Size(565, 186);
            this.tbx_Descripcion.TabIndex = 5;
            // 
            // tbx_Nombre
            // 
            this.tbx_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Nombre.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Nombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Nombre.Location = new System.Drawing.Point(184, 404);
            this.tbx_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_Nombre.Multiline = true;
            this.tbx_Nombre.Name = "tbx_Nombre";
            this.tbx_Nombre.Size = new System.Drawing.Size(236, 37);
            this.tbx_Nombre.TabIndex = 1;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(1112, 524);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(138, 54);
            this.btn_Eliminar.TabIndex = 8;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // dgv_Articulos
            // 
            this.dgv_Articulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulos.Location = new System.Drawing.Point(512, 38);
            this.dgv_Articulos.Name = "dgv_Articulos";
            this.dgv_Articulos.RowHeadersWidth = 62;
            this.dgv_Articulos.RowTemplate.Height = 28;
            this.dgv_Articulos.Size = new System.Drawing.Size(738, 290);
            this.dgv_Articulos.TabIndex = 9;
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Editar.Location = new System.Drawing.Point(1112, 460);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(138, 54);
            this.btn_Editar.TabIndex = 7;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // tbx_Codigo
            // 
            this.tbx_Codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Codigo.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Codigo.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Codigo.Location = new System.Drawing.Point(185, 359);
            this.tbx_Codigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_Codigo.Multiline = true;
            this.tbx_Codigo.Name = "tbx_Codigo";
            this.tbx_Codigo.Size = new System.Drawing.Size(236, 37);
            this.tbx_Codigo.TabIndex = 0;
            // 
            // cbx_Categoria
            // 
            this.cbx_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Categoria.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbx_Categoria.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbx_Categoria.FormattingEnabled = true;
            this.cbx_Categoria.Location = new System.Drawing.Point(184, 545);
            this.cbx_Categoria.Name = "cbx_Categoria";
            this.cbx_Categoria.Size = new System.Drawing.Size(237, 37);
            this.cbx_Categoria.TabIndex = 4;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Precio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Precio.Location = new System.Drawing.Point(63, 449);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(110, 32);
            this.lbl_Precio.TabIndex = 58;
            this.lbl_Precio.Text = "Precio:";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Categoria.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Categoria.Location = new System.Drawing.Point(17, 547);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(156, 32);
            this.lbl_Categoria.TabIndex = 57;
            this.lbl_Categoria.Text = "Categoria:";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Marca.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Marca.Location = new System.Drawing.Point(67, 494);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(106, 32);
            this.lbl_Marca.TabIndex = 56;
            this.lbl_Marca.Text = "Marca:";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Descripcion.Location = new System.Drawing.Point(520, 359);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(183, 32);
            this.lbl_Descripcion.TabIndex = 55;
            this.lbl_Descripcion.Text = "Descripcion:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Nombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Nombre.Location = new System.Drawing.Point(44, 404);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(129, 32);
            this.lbl_Nombre.TabIndex = 54;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Codigo.Location = new System.Drawing.Point(53, 359);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(120, 32);
            this.lbl_Codigo.TabIndex = 53;
            this.lbl_Codigo.Text = "Codigo:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 618);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.pb_Agregar_Imagen);
            this.Controls.Add(this.cbx_Marca);
            this.Controls.Add(this.tbx_Precio);
            this.Controls.Add(this.tbx_Descripcion);
            this.Controls.Add(this.tbx_Nombre);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dgv_Articulos);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.tbx_Codigo);
            this.Controls.Add(this.cbx_Categoria);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Codigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Articulo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Agregar_Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.PictureBox pb_Agregar_Imagen;
        public System.Windows.Forms.ComboBox cbx_Marca;
        private System.Windows.Forms.TextBox tbx_Precio;
        private System.Windows.Forms.TextBox tbx_Descripcion;
        private System.Windows.Forms.TextBox tbx_Nombre;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dgv_Articulos;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.TextBox tbx_Codigo;
        public System.Windows.Forms.ComboBox cbx_Categoria;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.BindingSource articuloBindingSource;
    }
}

