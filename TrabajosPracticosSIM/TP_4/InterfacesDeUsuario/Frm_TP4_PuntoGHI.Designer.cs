
namespace TrabajosPracticosSIM.TP_4.InterfacesDeUsuario
{
    partial class Frm_TP4_PuntoGHI
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
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(26, 12);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.RowHeadersWidth = 51;
            this.dgv_tabla.RowTemplate.Height = 24;
            this.dgv_tabla.Size = new System.Drawing.Size(1397, 709);
            this.dgv_tabla.TabIndex = 0;
            // 
            // Frm_TP4_PuntoGHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 751);
            this.Controls.Add(this.dgv_tabla);
            this.Name = "Frm_TP4_PuntoGHI";
            this.Text = "Frm_TP4_PuntoGHI";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tabla;
    }
}