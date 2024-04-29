namespace Gestion_de_Articulos
{
    partial class ModificarCategoria
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 43);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(205, 20);
            this.txtID.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(89, 85);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(205, 20);
            this.txbDescripcion.TabIndex = 2;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(64, 43);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 13);
            this.lblid.TabIndex = 7;
            this.lblid.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripcion:";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Modificar.Location = new System.Drawing.Point(89, 129);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(92, 35);
            this.btn_Modificar.TabIndex = 9;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(202, 129);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 35);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 187);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txtID);
            this.Name = "ModificarCategoria";
            this.Text = "ModificarCategoria";
            this.Load += new System.EventHandler(this.ModificarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btnCancelar;
    }
}