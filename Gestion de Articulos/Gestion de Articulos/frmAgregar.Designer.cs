namespace Gestion_de_Articulos
{
    partial class frm_Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Agregar));
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cbo_Marca = new System.Windows.Forms.ComboBox();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbx_Precio = new System.Windows.Forms.TextBox();
            this.tbx_Descripcion = new System.Windows.Forms.TextBox();
            this.tbx_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.tbx_Codigo = new System.Windows.Forms.TextBox();
            this.cbo_Categoria = new System.Windows.Forms.ComboBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Url = new System.Windows.Forms.Label();
            this.tbx_url = new System.Windows.Forms.TextBox();
            this.pbx_nuevo_art = new System.Windows.Forms.PictureBox();
            this.lbl_Ex_Precio = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Ex_Descripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_nuevo_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(380, 546);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(138, 54);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cbo_Marca
            // 
            this.cbo_Marca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_Marca.BackColor = System.Drawing.Color.AliceBlue;
            this.cbo_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbo_Marca.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbo_Marca.FormattingEnabled = true;
            this.cbo_Marca.Location = new System.Drawing.Point(279, 172);
            this.cbo_Marca.Name = "cbo_Marca";
            this.cbo_Marca.Size = new System.Drawing.Size(271, 37);
            this.cbo_Marca.TabIndex = 3;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(dominio.Articulo);
            // 
            // tbx_Precio
            // 
            this.tbx_Precio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_Precio.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Precio.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Precio.Location = new System.Drawing.Point(279, 126);
            this.tbx_Precio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_Precio.Multiline = true;
            this.tbx_Precio.Name = "tbx_Precio";
            this.tbx_Precio.Size = new System.Drawing.Size(271, 36);
            this.tbx_Precio.TabIndex = 2;
            // 
            // tbx_Descripcion
            // 
            this.tbx_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_Descripcion.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Descripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Descripcion.Location = new System.Drawing.Point(94, 389);
            this.tbx_Descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_Descripcion.Multiline = true;
            this.tbx_Descripcion.Name = "tbx_Descripcion";
            this.tbx_Descripcion.Size = new System.Drawing.Size(454, 129);
            this.tbx_Descripcion.TabIndex = 6;
            // 
            // tbx_Nombre
            // 
            this.tbx_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_Nombre.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Nombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Nombre.Location = new System.Drawing.Point(279, 78);
            this.tbx_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_Nombre.Multiline = true;
            this.tbx_Nombre.Name = "tbx_Nombre";
            this.tbx_Nombre.Size = new System.Drawing.Size(271, 36);
            this.tbx_Nombre.TabIndex = 1;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Guardar.Location = new System.Drawing.Point(94, 546);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(138, 54);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // tbx_Codigo
            // 
            this.tbx_Codigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_Codigo.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Codigo.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Codigo.Location = new System.Drawing.Point(279, 31);
            this.tbx_Codigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_Codigo.Multiline = true;
            this.tbx_Codigo.Name = "tbx_Codigo";
            this.tbx_Codigo.Size = new System.Drawing.Size(271, 36);
            this.tbx_Codigo.TabIndex = 0;
            // 
            // cbo_Categoria
            // 
            this.cbo_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_Categoria.BackColor = System.Drawing.Color.AliceBlue;
            this.cbo_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbo_Categoria.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbo_Categoria.FormattingEnabled = true;
            this.cbo_Categoria.Location = new System.Drawing.Point(279, 222);
            this.cbo_Categoria.Name = "cbo_Categoria";
            this.cbo_Categoria.Size = new System.Drawing.Size(271, 37);
            this.cbo_Categoria.TabIndex = 4;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Precio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Precio.Location = new System.Drawing.Point(158, 128);
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
            this.lbl_Categoria.Location = new System.Drawing.Point(116, 228);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(156, 32);
            this.lbl_Categoria.TabIndex = 57;
            this.lbl_Categoria.Text = "Categoría:";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Marca.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Marca.Location = new System.Drawing.Point(162, 178);
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
            this.lbl_Descripcion.Location = new System.Drawing.Point(81, 326);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(183, 32);
            this.lbl_Descripcion.TabIndex = 55;
            this.lbl_Descripcion.Text = "Descripción:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Nombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Nombre.Location = new System.Drawing.Point(135, 80);
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
            this.lbl_Codigo.Location = new System.Drawing.Point(147, 32);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(120, 32);
            this.lbl_Codigo.TabIndex = 53;
            this.lbl_Codigo.Text = "Código:";
            // 
            // lbl_Url
            // 
            this.lbl_Url.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Url.AutoSize = true;
            this.lbl_Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Url.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Url.Location = new System.Drawing.Point(20, 274);
            this.lbl_Url.Name = "lbl_Url";
            this.lbl_Url.Size = new System.Drawing.Size(245, 32);
            this.lbl_Url.TabIndex = 59;
            this.lbl_Url.Text = "Url de la imagen:";
            // 
            // tbx_url
            // 
            this.tbx_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_url.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_url.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_url.Location = new System.Drawing.Point(278, 272);
            this.tbx_url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_url.Multiline = true;
            this.tbx_url.Name = "tbx_url";
            this.tbx_url.Size = new System.Drawing.Size(271, 36);
            this.tbx_url.TabIndex = 5;
            this.tbx_url.Leave += new System.EventHandler(this.tbx_url_Leave);
            // 
            // pbx_nuevo_art
            // 
            this.pbx_nuevo_art.Location = new System.Drawing.Point(588, 31);
            this.pbx_nuevo_art.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbx_nuevo_art.Name = "pbx_nuevo_art";
            this.pbx_nuevo_art.Size = new System.Drawing.Size(459, 506);
            this.pbx_nuevo_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_nuevo_art.TabIndex = 61;
            this.pbx_nuevo_art.TabStop = false;
            // 
            // lbl_Ex_Precio
            // 
            this.lbl_Ex_Precio.AutoSize = true;
            this.lbl_Ex_Precio.Location = new System.Drawing.Point(159, 158);
            this.lbl_Ex_Precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ex_Precio.Name = "lbl_Ex_Precio";
            this.lbl_Ex_Precio.Size = new System.Drawing.Size(0, 20);
            this.lbl_Ex_Precio.TabIndex = 62;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_Ex_Descripcion
            // 
            this.lbl_Ex_Descripcion.AutoSize = true;
            this.lbl_Ex_Descripcion.Location = new System.Drawing.Point(90, 363);
            this.lbl_Ex_Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ex_Descripcion.Name = "lbl_Ex_Descripcion";
            this.lbl_Ex_Descripcion.Size = new System.Drawing.Size(0, 20);
            this.lbl_Ex_Descripcion.TabIndex = 63;
            // 
            // frm_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 618);
            this.Controls.Add(this.lbl_Ex_Descripcion);
            this.Controls.Add(this.lbl_Ex_Precio);
            this.Controls.Add(this.pbx_nuevo_art);
            this.Controls.Add(this.tbx_url);
            this.Controls.Add(this.lbl_Url);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.cbo_Marca);
            this.Controls.Add(this.tbx_Precio);
            this.Controls.Add(this.tbx_Descripcion);
            this.Controls.Add(this.tbx_Nombre);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.tbx_Codigo);
            this.Controls.Add(this.cbo_Categoria);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Codigo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Agregar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Artículo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_nuevo_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.ComboBox cbo_Marca;
        private System.Windows.Forms.TextBox tbx_Precio;
        private System.Windows.Forms.TextBox tbx_Descripcion;
        private System.Windows.Forms.TextBox tbx_Nombre;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox tbx_Codigo;
        public System.Windows.Forms.ComboBox cbo_Categoria;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private System.Windows.Forms.Label lbl_Url;
        private System.Windows.Forms.TextBox tbx_url;
        private System.Windows.Forms.PictureBox pbx_nuevo_art;
        private System.Windows.Forms.Label lbl_Ex_Precio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_Ex_Descripcion;
    }
}

