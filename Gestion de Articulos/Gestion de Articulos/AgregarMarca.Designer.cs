namespace Gestion_de_Articulos
{
    partial class AgregarMarca
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(84, 50);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(186, 20);
            this.txtid.TabIndex = 0;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(84, 102);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(186, 20);
            this.txbDescripcion.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Agregar.Location = new System.Drawing.Point(80, 175);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(92, 35);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(178, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripcion:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(56, 53);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 13);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "Id:";
            // 
            // AgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 239);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txtid);
            this.Name = "AgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMarca";
            this.Load += new System.EventHandler(this.AgregarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
    }
}