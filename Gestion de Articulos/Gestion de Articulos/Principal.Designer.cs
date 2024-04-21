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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Detalle = new System.Windows.Forms.Button();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btn_Agregar.Location = new System.Drawing.Point(178, 380);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(92, 35);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pb_Imagen
            // 
            this.pb_Imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Imagen.InitialImage = null;
            this.pb_Imagen.Location = new System.Drawing.Point(619, 47);
            this.pb_Imagen.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Imagen.Name = "pb_Imagen";
            this.pb_Imagen.Size = new System.Drawing.Size(323, 314);
            this.pb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagen.TabIndex = 59;
            this.pb_Imagen.TabStop = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(483, 380);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(92, 35);
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
            this.dgv_Articulos.Location = new System.Drawing.Point(26, 47);
            this.dgv_Articulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Articulos.Name = "dgv_Articulos";
            this.dgv_Articulos.RowHeadersWidth = 62;
            this.dgv_Articulos.RowTemplate.Height = 28;
            this.dgv_Articulos.Size = new System.Drawing.Size(549, 314);
            this.dgv_Articulos.TabIndex = 9;
            this.dgv_Articulos.SelectionChanged += new System.EventHandler(this.dgv_Articulos_SelectionChanged);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Editar.Location = new System.Drawing.Point(333, 380);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(92, 35);
            this.btn_Editar.TabIndex = 7;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // tb_Buscador
            // 
            this.tb_Buscador.Location = new System.Drawing.Point(96, 12);
            this.tb_Buscador.Name = "tb_Buscador";
            this.tb_Buscador.Size = new System.Drawing.Size(479, 20);
            this.tb_Buscador.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Buscar:";
            // 
            // btn_Detalle
            // 
            this.btn_Detalle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Detalle.Location = new System.Drawing.Point(26, 380);
            this.btn_Detalle.Name = "btn_Detalle";
            this.btn_Detalle.Size = new System.Drawing.Size(92, 35);
            this.btn_Detalle.TabIndex = 62;
            this.btn_Detalle.Text = "Detalle";
            this.btn_Detalle.UseVisualStyleBackColor = false;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(Gestion_de_Articulos.Articulo);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 429);
            this.Controls.Add(this.btn_Detalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Buscador);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.pb_Imagen);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dgv_Articulos);
            this.Controls.Add(this.btn_Editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Detalle;
    }
}

