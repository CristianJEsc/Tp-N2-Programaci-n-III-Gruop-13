namespace Gestion_de_Articulos
{
    partial class frm_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Editar));
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.tbx_Marca = new System.Windows.Forms.ComboBox();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbx_Precio = new System.Windows.Forms.TextBox();
            this.tbx_Descripcion = new System.Windows.Forms.TextBox();
            this.tbx_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.tbx_Codigo = new System.Windows.Forms.TextBox();
            this.tbx_Categoria = new System.Windows.Forms.ComboBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Url = new System.Windows.Forms.Label();
            this.tbx_url = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(253, 355);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(92, 35);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // tbx_Marca
            // 
            this.tbx_Marca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_Marca.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Marca.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Marca.FormattingEnabled = true;
            this.tbx_Marca.Location = new System.Drawing.Point(186, 108);
            this.tbx_Marca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_Marca.Name = "tbx_Marca";
            this.tbx_Marca.Size = new System.Drawing.Size(182, 28);
            this.tbx_Marca.TabIndex = 3;
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
            this.tbx_Precio.Location = new System.Drawing.Point(186, 79);
            this.tbx_Precio.Multiline = true;
            this.tbx_Precio.Name = "tbx_Precio";
            this.tbx_Precio.Size = new System.Drawing.Size(182, 25);
            this.tbx_Precio.TabIndex = 2;
            // 
            // tbx_Descripcion
            // 
            this.tbx_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_Descripcion.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Descripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Descripcion.Location = new System.Drawing.Point(186, 205);
            this.tbx_Descripcion.Multiline = true;
            this.tbx_Descripcion.Name = "tbx_Descripcion";
            this.tbx_Descripcion.Size = new System.Drawing.Size(181, 144);
            this.tbx_Descripcion.TabIndex = 5;
            // 
            // tbx_Nombre
            // 
            this.tbx_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_Nombre.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Nombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Nombre.Location = new System.Drawing.Point(186, 50);
            this.tbx_Nombre.Multiline = true;
            this.tbx_Nombre.Name = "tbx_Nombre";
            this.tbx_Nombre.Size = new System.Drawing.Size(182, 25);
            this.tbx_Nombre.TabIndex = 1;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Guardar.Location = new System.Drawing.Point(63, 355);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(92, 35);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // tbx_Codigo
            // 
            this.tbx_Codigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_Codigo.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Codigo.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Codigo.Location = new System.Drawing.Point(186, 20);
            this.tbx_Codigo.Multiline = true;
            this.tbx_Codigo.Name = "tbx_Codigo";
            this.tbx_Codigo.Size = new System.Drawing.Size(182, 25);
            this.tbx_Codigo.TabIndex = 0;
            // 
            // tbx_Categoria
            // 
            this.tbx_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_Categoria.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Categoria.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbx_Categoria.FormattingEnabled = true;
            this.tbx_Categoria.Location = new System.Drawing.Point(186, 141);
            this.tbx_Categoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_Categoria.Name = "tbx_Categoria";
            this.tbx_Categoria.Size = new System.Drawing.Size(182, 28);
            this.tbx_Categoria.TabIndex = 4;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Precio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Precio.Location = new System.Drawing.Point(110, 79);
            this.lbl_Precio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(76, 24);
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
            this.lbl_Categoria.Location = new System.Drawing.Point(81, 141);
            this.lbl_Categoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(105, 24);
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
            this.lbl_Marca.Location = new System.Drawing.Point(113, 108);
            this.lbl_Marca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(73, 24);
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
            this.lbl_Descripcion.Location = new System.Drawing.Point(59, 202);
            this.lbl_Descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(127, 24);
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
            this.lbl_Nombre.Location = new System.Drawing.Point(95, 52);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(91, 24);
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
            this.lbl_Codigo.Location = new System.Drawing.Point(103, 20);
            this.lbl_Codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(83, 24);
            this.lbl_Codigo.TabIndex = 53;
            this.lbl_Codigo.Text = "Codigo:";
            // 
            // lbl_Url
            // 
            this.lbl_Url.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Url.AutoSize = true;
            this.lbl_Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Url.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Url.Location = new System.Drawing.Point(17, 171);
            this.lbl_Url.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Url.Name = "lbl_Url";
            this.lbl_Url.Size = new System.Drawing.Size(169, 24);
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
            this.tbx_url.Location = new System.Drawing.Point(186, 174);
            this.tbx_url.Multiline = true;
            this.tbx_url.Name = "tbx_url";
            this.tbx_url.Size = new System.Drawing.Size(182, 25);
            this.tbx_url.TabIndex = 60;
            // 
            // frm_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 402);
            this.Controls.Add(this.tbx_url);
            this.Controls.Add(this.lbl_Url);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.tbx_Marca);
            this.Controls.Add(this.tbx_Precio);
            this.Controls.Add(this.tbx_Descripcion);
            this.Controls.Add(this.tbx_Nombre);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.tbx_Codigo);
            this.Controls.Add(this.tbx_Categoria);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Codigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Editar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Artículo";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.ComboBox tbx_Marca;
        private System.Windows.Forms.TextBox tbx_Precio;
        private System.Windows.Forms.TextBox tbx_Descripcion;
        private System.Windows.Forms.TextBox tbx_Nombre;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox tbx_Codigo;
        public System.Windows.Forms.ComboBox tbx_Categoria;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private System.Windows.Forms.Label lbl_Url;
        private System.Windows.Forms.TextBox tbx_url;
    }
}

