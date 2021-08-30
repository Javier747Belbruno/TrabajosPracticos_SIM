
namespace TrabajosPracticosSIM.TP_3.InterfacesDeUsuario
{
    partial class Frm_TP3_PuntoA
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
            this.pnl_seleccion_distribucion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_normal = new System.Windows.Forms.Button();
            this.Btn_poisson = new System.Windows.Forms.Button();
            this.Btn_exponencial = new System.Windows.Forms.Button();
            this.Btn_uniforme = new System.Windows.Forms.Button();
            this.pnl_parametros = new System.Windows.Forms.Panel();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Generar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_desviacion_estandar = new System.Windows.Forms.TextBox();
            this.tb_media = new System.Windows.Forms.TextBox();
            this.tb_lambda = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_tabla = new System.Windows.Forms.Panel();
            this.dgv_distribucion = new System.Windows.Forms.DataGridView();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Random = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varAlea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Continuar = new System.Windows.Forms.Button();
            this.pnl_seleccion_distribucion.SuspendLayout();
            this.pnl_parametros.SuspendLayout();
            this.pnl_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_distribucion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_seleccion_distribucion
            // 
            this.pnl_seleccion_distribucion.Controls.Add(this.label1);
            this.pnl_seleccion_distribucion.Controls.Add(this.Btn_normal);
            this.pnl_seleccion_distribucion.Controls.Add(this.Btn_poisson);
            this.pnl_seleccion_distribucion.Controls.Add(this.Btn_exponencial);
            this.pnl_seleccion_distribucion.Controls.Add(this.Btn_uniforme);
            this.pnl_seleccion_distribucion.Location = new System.Drawing.Point(98, 28);
            this.pnl_seleccion_distribucion.Name = "pnl_seleccion_distribucion";
            this.pnl_seleccion_distribucion.Size = new System.Drawing.Size(951, 144);
            this.pnl_seleccion_distribucion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione una de las siguientes distribuciones para generar valores de variables" +
    " aleatorias ";
            // 
            // Btn_normal
            // 
            this.Btn_normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_normal.Location = new System.Drawing.Point(737, 55);
            this.Btn_normal.Name = "Btn_normal";
            this.Btn_normal.Size = new System.Drawing.Size(175, 51);
            this.Btn_normal.TabIndex = 3;
            this.Btn_normal.Text = "Normal";
            this.Btn_normal.UseVisualStyleBackColor = true;
            this.Btn_normal.Click += new System.EventHandler(this.Btn_normal_Click);
            // 
            // Btn_poisson
            // 
            this.Btn_poisson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_poisson.Location = new System.Drawing.Point(499, 55);
            this.Btn_poisson.Name = "Btn_poisson";
            this.Btn_poisson.Size = new System.Drawing.Size(175, 51);
            this.Btn_poisson.TabIndex = 2;
            this.Btn_poisson.Text = "Poisson";
            this.Btn_poisson.UseVisualStyleBackColor = true;
            this.Btn_poisson.Click += new System.EventHandler(this.Btn_poisson_Click);
            // 
            // Btn_exponencial
            // 
            this.Btn_exponencial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_exponencial.Location = new System.Drawing.Point(245, 55);
            this.Btn_exponencial.Name = "Btn_exponencial";
            this.Btn_exponencial.Size = new System.Drawing.Size(175, 51);
            this.Btn_exponencial.TabIndex = 1;
            this.Btn_exponencial.Text = "Exponencial";
            this.Btn_exponencial.UseVisualStyleBackColor = true;
            this.Btn_exponencial.Click += new System.EventHandler(this.Btn_exponencial_Click);
            // 
            // Btn_uniforme
            // 
            this.Btn_uniforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_uniforme.Location = new System.Drawing.Point(24, 55);
            this.Btn_uniforme.Name = "Btn_uniforme";
            this.Btn_uniforme.Size = new System.Drawing.Size(175, 51);
            this.Btn_uniforme.TabIndex = 0;
            this.Btn_uniforme.Text = "Uniforme";
            this.Btn_uniforme.UseVisualStyleBackColor = true;
            this.Btn_uniforme.Click += new System.EventHandler(this.Btn_uniforme_Click);
            // 
            // pnl_parametros
            // 
            this.pnl_parametros.Controls.Add(this.tb_cantidad);
            this.pnl_parametros.Controls.Add(this.label8);
            this.pnl_parametros.Controls.Add(this.Btn_Generar);
            this.pnl_parametros.Controls.Add(this.label7);
            this.pnl_parametros.Controls.Add(this.tb_desviacion_estandar);
            this.pnl_parametros.Controls.Add(this.tb_media);
            this.pnl_parametros.Controls.Add(this.tb_lambda);
            this.pnl_parametros.Controls.Add(this.tb_b);
            this.pnl_parametros.Controls.Add(this.tb_a);
            this.pnl_parametros.Controls.Add(this.label6);
            this.pnl_parametros.Controls.Add(this.label5);
            this.pnl_parametros.Controls.Add(this.label4);
            this.pnl_parametros.Controls.Add(this.label3);
            this.pnl_parametros.Controls.Add(this.label2);
            this.pnl_parametros.Location = new System.Drawing.Point(98, 178);
            this.pnl_parametros.Name = "pnl_parametros";
            this.pnl_parametros.Size = new System.Drawing.Size(951, 178);
            this.pnl_parametros.TabIndex = 1;
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(459, 79);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(152, 26);
            this.tb_cantidad.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cantidad a generar";
            // 
            // Btn_Generar
            // 
            this.Btn_Generar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Generar.Location = new System.Drawing.Point(412, 127);
            this.Btn_Generar.Name = "Btn_Generar";
            this.Btn_Generar.Size = new System.Drawing.Size(163, 48);
            this.Btn_Generar.TabIndex = 11;
            this.Btn_Generar.Text = "Generar";
            this.Btn_Generar.UseVisualStyleBackColor = true;
            this.Btn_Generar.Click += new System.EventHandler(this.Btn_Generar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ingrese el/los parámetro/s";
            // 
            // tb_desviacion_estandar
            // 
            this.tb_desviacion_estandar.Location = new System.Drawing.Point(794, 35);
            this.tb_desviacion_estandar.Name = "tb_desviacion_estandar";
            this.tb_desviacion_estandar.Size = new System.Drawing.Size(100, 26);
            this.tb_desviacion_estandar.TabIndex = 9;
            // 
            // tb_media
            // 
            this.tb_media.Location = new System.Drawing.Point(617, 35);
            this.tb_media.Name = "tb_media";
            this.tb_media.Size = new System.Drawing.Size(100, 26);
            this.tb_media.TabIndex = 8;
            // 
            // tb_lambda
            // 
            this.tb_lambda.Location = new System.Drawing.Point(435, 35);
            this.tb_lambda.Name = "tb_lambda";
            this.tb_lambda.Size = new System.Drawing.Size(100, 26);
            this.tb_lambda.TabIndex = 7;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(253, 35);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(100, 26);
            this.tb_b.TabIndex = 6;
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(80, 38);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(100, 26);
            this.tb_a.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "σ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "µ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "λ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "a";
            // 
            // pnl_tabla
            // 
            this.pnl_tabla.Controls.Add(this.dgv_distribucion);
            this.pnl_tabla.Controls.Add(this.Btn_Continuar);
            this.pnl_tabla.Location = new System.Drawing.Point(98, 362);
            this.pnl_tabla.Name = "pnl_tabla";
            this.pnl_tabla.Size = new System.Drawing.Size(951, 305);
            this.pnl_tabla.TabIndex = 2;
            // 
            // dgv_distribucion
            // 
            this.dgv_distribucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_distribucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pos,
            this.Random,
            this.varAlea});
            this.dgv_distribucion.Location = new System.Drawing.Point(110, 3);
            this.dgv_distribucion.Name = "dgv_distribucion";
            this.dgv_distribucion.RowHeadersWidth = 51;
            this.dgv_distribucion.RowTemplate.Height = 24;
            this.dgv_distribucion.Size = new System.Drawing.Size(435, 299);
            this.dgv_distribucion.TabIndex = 4;
            this.dgv_distribucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_distribucion_CellContentClick);
            // 
            // pos
            // 
            this.pos.HeaderText = "Posición";
            this.pos.MinimumWidth = 6;
            this.pos.Name = "pos";
            this.pos.Width = 125;
            // 
            // Random
            // 
            this.Random.HeaderText = "Random";
            this.Random.MinimumWidth = 6;
            this.Random.Name = "Random";
            this.Random.Width = 125;
            // 
            // varAlea
            // 
            this.varAlea.HeaderText = "Variable Aleatoria";
            this.varAlea.MinimumWidth = 6;
            this.varAlea.Name = "varAlea";
            this.varAlea.Width = 125;
            // 
            // Btn_Continuar
            // 
            this.Btn_Continuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Continuar.Location = new System.Drawing.Point(680, 115);
            this.Btn_Continuar.Name = "Btn_Continuar";
            this.Btn_Continuar.Size = new System.Drawing.Size(175, 65);
            this.Btn_Continuar.TabIndex = 3;
            this.Btn_Continuar.Text = "Continuar";
            this.Btn_Continuar.UseVisualStyleBackColor = true;
            this.Btn_Continuar.Click += new System.EventHandler(this.Btn_Continuar_Click);
            // 
            // Frm_TP3_PuntoA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 679);
            this.Controls.Add(this.pnl_tabla);
            this.Controls.Add(this.pnl_parametros);
            this.Controls.Add(this.pnl_seleccion_distribucion);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_TP3_PuntoA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto A";
            this.Load += new System.EventHandler(this.Frm_TP3_PuntoA_Load);
            this.pnl_seleccion_distribucion.ResumeLayout(false);
            this.pnl_seleccion_distribucion.PerformLayout();
            this.pnl_parametros.ResumeLayout(false);
            this.pnl_parametros.PerformLayout();
            this.pnl_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_distribucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_seleccion_distribucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_normal;
        private System.Windows.Forms.Button Btn_poisson;
        private System.Windows.Forms.Button Btn_exponencial;
        private System.Windows.Forms.Button Btn_uniforme;
        private System.Windows.Forms.Panel pnl_parametros;
        private System.Windows.Forms.Panel pnl_tabla;
        private System.Windows.Forms.Button Btn_Continuar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_desviacion_estandar;
        private System.Windows.Forms.TextBox tb_media;
        private System.Windows.Forms.TextBox tb_lambda;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_distribucion;
        private System.Windows.Forms.Button Btn_Generar;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random;
        private System.Windows.Forms.DataGridViewTextBoxColumn varAlea;
    }
}