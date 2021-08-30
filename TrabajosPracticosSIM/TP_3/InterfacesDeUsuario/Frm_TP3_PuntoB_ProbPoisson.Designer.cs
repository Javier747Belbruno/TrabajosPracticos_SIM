
namespace TrabajosPracticosSIM.TP_3.InterfacesDeUsuario
{
    partial class Frm_TP3_PuntoB_ProbPoisson
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
            this.dgv_probabilidades = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_probabilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_probabilidades
            // 
            this.dgv_probabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_probabilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_probabilidades.Location = new System.Drawing.Point(12, 9);
            this.dgv_probabilidades.Name = "dgv_probabilidades";
            this.dgv_probabilidades.RowHeadersWidth = 51;
            this.dgv_probabilidades.RowTemplate.Height = 24;
            this.dgv_probabilidades.Size = new System.Drawing.Size(575, 385);
            this.dgv_probabilidades.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "i";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Probabilidad";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prob. Acumulada";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Frm_TP3_PuntoB_ProbPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 406);
            this.Controls.Add(this.dgv_probabilidades);
            this.Name = "Frm_TP3_PuntoB_ProbPoisson";
            this.Text = "Probabilidades de Poisson";
            this.Load += new System.EventHandler(this.Frm_TP3_PuntoB_ProbPoisson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_probabilidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_probabilidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}