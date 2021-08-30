
namespace TrabajosPracticosSIM.TP_3.InterfacesDeUsuario
{
    partial class Frm_TP3_PuntoB_ChiCuadrado
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
            this.tb_gdl = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_resultado_final = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_valor_tabulado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_xo_cuadrado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_significancia_alfa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_gdl
            // 
            this.tb_gdl.Location = new System.Drawing.Point(19, 54);
            this.tb_gdl.Name = "tb_gdl";
            this.tb_gdl.Size = new System.Drawing.Size(105, 26);
            this.tb_gdl.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 18);
            this.label16.TabIndex = 30;
            this.label16.Text = "Grados de Libertad";
            // 
            // tb_resultado_final
            // 
            this.tb_resultado_final.Location = new System.Drawing.Point(12, 216);
            this.tb_resultado_final.Multiline = true;
            this.tb_resultado_final.Name = "tb_resultado_final";
            this.tb_resultado_final.Size = new System.Drawing.Size(269, 146);
            this.tb_resultado_final.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 18);
            this.label15.TabIndex = 28;
            this.label15.Text = "Resultado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(156, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 18);
            this.label14.TabIndex = 27;
            this.label14.Text = "Distr. Chi-Cuadrado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Valor Tabulado de";
            // 
            // tb_valor_tabulado
            // 
            this.tb_valor_tabulado.Location = new System.Drawing.Point(159, 141);
            this.tb_valor_tabulado.Name = "tb_valor_tabulado";
            this.tb_valor_tabulado.Size = new System.Drawing.Size(129, 26);
            this.tb_valor_tabulado.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Calculado (Xo^2)";
            // 
            // tb_xo_cuadrado
            // 
            this.tb_xo_cuadrado.Location = new System.Drawing.Point(22, 141);
            this.tb_xo_cuadrado.Name = "tb_xo_cuadrado";
            this.tb_xo_cuadrado.Size = new System.Drawing.Size(102, 26);
            this.tb_xo_cuadrado.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Valor Chi-Cuadrado";
            // 
            // tb_significancia_alfa
            // 
            this.tb_significancia_alfa.Location = new System.Drawing.Point(159, 54);
            this.tb_significancia_alfa.Name = "tb_significancia_alfa";
            this.tb_significancia_alfa.Size = new System.Drawing.Size(129, 26);
            this.tb_significancia_alfa.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(163, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 18);
            this.label17.TabIndex = 32;
            this.label17.Text = "Significancia Alfa";
            // 
            // Frm_TP3_PuntoB_ChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 394);
            this.Controls.Add(this.tb_significancia_alfa);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb_gdl);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_resultado_final);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_valor_tabulado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_xo_cuadrado);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_TP3_PuntoB_ChiCuadrado";
            this.Text = "Prueba de X^2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_gdl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_resultado_final;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_valor_tabulado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_xo_cuadrado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_significancia_alfa;
        private System.Windows.Forms.Label label17;
    }
}