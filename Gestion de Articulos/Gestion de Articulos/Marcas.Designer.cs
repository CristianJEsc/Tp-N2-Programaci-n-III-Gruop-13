namespace Gestion_de_Articulos
{
    partial class Marcas
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
            this.dgv_Marcas = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Marcas
            // 
            this.dgv_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Marcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Marcas.Location = new System.Drawing.Point(36, 49);
            this.dgv_Marcas.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Marcas.MultiSelect = false;
            this.dgv_Marcas.Name = "dgv_Marcas";
            this.dgv_Marcas.RowHeadersWidth = 62;
            this.dgv_Marcas.RowTemplate.Height = 28;
            this.dgv_Marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Marcas.Size = new System.Drawing.Size(420, 282);
            this.dgv_Marcas.TabIndex = 11;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Agregar.Location = new System.Drawing.Point(36, 347);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(92, 35);
            this.btn_Agregar.TabIndex = 12;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(200, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(364, 347);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 35);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 381);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv_Marcas);
            this.Name = "Marcas";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Marcas;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminar;
    }
}