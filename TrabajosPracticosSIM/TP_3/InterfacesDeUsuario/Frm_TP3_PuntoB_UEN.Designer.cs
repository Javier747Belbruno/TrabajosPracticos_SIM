
using System.Windows.Input;

namespace TrabajosPracticosSIM.TP_3.InterfacesDeUsuario
{
    partial class Frm_TP3_PuntoB_UEN
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.tb_cantInterv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_Grafico = new System.Windows.Forms.Panel();
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
            this.dgv_frecuencias = new System.Windows.Forms.DataGridView();
            this.Lim_inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lim_sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEFO2FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_significancia_alfa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Btn_Prueba_De_Frecuencia = new System.Windows.Forms.Button();
            this.dgv_var_aleatorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnl_Grafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frecuencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_var_aleatorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btn_Cerrar.Location = new System.Drawing.Point(1242, 682);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(125, 55);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // tb_cantInterv
            // 
            this.tb_cantInterv.Location = new System.Drawing.Point(221, 77);
            this.tb_cantInterv.Name = "tb_cantInterv";
            this.tb_cantInterv.Size = new System.Drawing.Size(146, 22);
            this.tb_cantInterv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cant. de Intervalos";
            // 
            // chart1
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 10;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.PointDepth = 50;
            chartArea2.Area3DStyle.PointGapDepth = 10;
            chartArea2.Area3DStyle.Rotation = 7;
            chartArea2.Area3DStyle.WallWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(22, 6);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.MidnightBlue;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(958, 332);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart_freq";
            // 
            // pnl_Grafico
            // 
            this.pnl_Grafico.Controls.Add(this.tb_gdl);
            this.pnl_Grafico.Controls.Add(this.label16);
            this.pnl_Grafico.Controls.Add(this.tb_resultado_final);
            this.pnl_Grafico.Controls.Add(this.label15);
            this.pnl_Grafico.Controls.Add(this.label14);
            this.pnl_Grafico.Controls.Add(this.label13);
            this.pnl_Grafico.Controls.Add(this.tb_valor_tabulado);
            this.pnl_Grafico.Controls.Add(this.label12);
            this.pnl_Grafico.Controls.Add(this.tb_xo_cuadrado);
            this.pnl_Grafico.Controls.Add(this.label10);
            this.pnl_Grafico.Controls.Add(this.dgv_frecuencias);
            this.pnl_Grafico.Controls.Add(this.chart1);
            this.pnl_Grafico.Location = new System.Drawing.Point(396, 38);
            this.pnl_Grafico.Name = "pnl_Grafico";
            this.pnl_Grafico.Size = new System.Drawing.Size(999, 638);
            this.pnl_Grafico.TabIndex = 13;
            // 
            // tb_gdl
            // 
            this.tb_gdl.Location = new System.Drawing.Point(708, 362);
            this.tb_gdl.Name = "tb_gdl";
            this.tb_gdl.Size = new System.Drawing.Size(121, 22);
            this.tb_gdl.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(705, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 14);
            this.label16.TabIndex = 19;
            this.label16.Text = "Grados de Libertad";
            // 
            // tb_resultado_final
            // 
            this.tb_resultado_final.Location = new System.Drawing.Point(733, 528);
            this.tb_resultado_final.Multiline = true;
            this.tb_resultado_final.Name = "tb_resultado_final";
            this.tb_resultado_final.Size = new System.Drawing.Size(217, 91);
            this.tb_resultado_final.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(740, 507);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 14);
            this.label15.TabIndex = 17;
            this.label15.Text = "Prueba de Chi-Cuadrada";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(845, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 14);
            this.label14.TabIndex = 16;
            this.label14.Text = "Distr. Chi-Cuadrado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(845, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 14);
            this.label13.TabIndex = 15;
            this.label13.Text = "Valor Tabulado de";
            // 
            // tb_valor_tabulado
            // 
            this.tb_valor_tabulado.Location = new System.Drawing.Point(848, 439);
            this.tb_valor_tabulado.Name = "tb_valor_tabulado";
            this.tb_valor_tabulado.Size = new System.Drawing.Size(115, 22);
            this.tb_valor_tabulado.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(708, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 14);
            this.label12.TabIndex = 13;
            this.label12.Text = "Calculado (Xo^2)";
            // 
            // tb_xo_cuadrado
            // 
            this.tb_xo_cuadrado.Location = new System.Drawing.Point(711, 439);
            this.tb_xo_cuadrado.Name = "tb_xo_cuadrado";
            this.tb_xo_cuadrado.Size = new System.Drawing.Size(102, 22);
            this.tb_xo_cuadrado.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(708, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Valor Chi-Cuadrado";
            // 
            // dgv_frecuencias
            // 
            this.dgv_frecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_frecuencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lim_inf,
            this.Lim_sup,
            this.FE,
            this.FO,
            this.FEFO2FE});
            this.dgv_frecuencias.Location = new System.Drawing.Point(13, 341);
            this.dgv_frecuencias.Name = "dgv_frecuencias";
            this.dgv_frecuencias.RowHeadersWidth = 51;
            this.dgv_frecuencias.RowTemplate.Height = 24;
            this.dgv_frecuencias.Size = new System.Drawing.Size(686, 278);
            this.dgv_frecuencias.TabIndex = 10;
            // 
            // Lim_inf
            // 
            this.Lim_inf.HeaderText = "Lim_inf";
            this.Lim_inf.MinimumWidth = 6;
            this.Lim_inf.Name = "Lim_inf";
            this.Lim_inf.Width = 125;
            // 
            // Lim_sup
            // 
            this.Lim_sup.HeaderText = "Lim_sup";
            this.Lim_sup.MinimumWidth = 6;
            this.Lim_sup.Name = "Lim_sup";
            this.Lim_sup.Width = 125;
            // 
            // FE
            // 
            this.FE.HeaderText = "FE";
            this.FE.MinimumWidth = 6;
            this.FE.Name = "FE";
            this.FE.Width = 125;
            // 
            // FO
            // 
            this.FO.HeaderText = "FO";
            this.FO.MinimumWidth = 6;
            this.FO.Name = "FO";
            this.FO.Width = 125;
            // 
            // FEFO2FE
            // 
            this.FEFO2FE.HeaderText = "(FE-FO)^2/FE";
            this.FEFO2FE.MinimumWidth = 6;
            this.FEFO2FE.Name = "FEFO2FE";
            this.FEFO2FE.Width = 125;
            // 
            // tb_significancia_alfa
            // 
            this.tb_significancia_alfa.Location = new System.Drawing.Point(221, 136);
            this.tb_significancia_alfa.Name = "tb_significancia_alfa";
            this.tb_significancia_alfa.Size = new System.Drawing.Size(146, 22);
            this.tb_significancia_alfa.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(57, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 14);
            this.label17.TabIndex = 20;
            this.label17.Text = "Significancia Alfa";
            // 
            // Btn_Prueba_De_Frecuencia
            // 
            this.Btn_Prueba_De_Frecuencia.Location = new System.Drawing.Point(101, 220);
            this.Btn_Prueba_De_Frecuencia.Name = "Btn_Prueba_De_Frecuencia";
            this.Btn_Prueba_De_Frecuencia.Size = new System.Drawing.Size(210, 78);
            this.Btn_Prueba_De_Frecuencia.TabIndex = 23;
            this.Btn_Prueba_De_Frecuencia.Text = "Prueba de Frecuencia";
            this.Btn_Prueba_De_Frecuencia.UseVisualStyleBackColor = true;
            this.Btn_Prueba_De_Frecuencia.Click += new System.EventHandler(this.Btn_Prueba_De_Frecuencia_Click);
            // 
            // dgv_var_aleatorias
            // 
            this.dgv_var_aleatorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_var_aleatorias.Location = new System.Drawing.Point(29, 337);
            this.dgv_var_aleatorias.Name = "dgv_var_aleatorias";
            this.dgv_var_aleatorias.RowHeadersWidth = 51;
            this.dgv_var_aleatorias.RowTemplate.Height = 24;
            this.dgv_var_aleatorias.Size = new System.Drawing.Size(338, 320);
            this.dgv_var_aleatorias.TabIndex = 24;
            // 
            // Frm_TP3_PuntoB_UEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1402, 761);
            this.Controls.Add(this.dgv_var_aleatorias);
            this.Controls.Add(this.Btn_Prueba_De_Frecuencia);
            this.Controls.Add(this.tb_significancia_alfa);
            this.Controls.Add(this.pnl_Grafico);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb_cantInterv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cerrar);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.Name = "Frm_TP3_PuntoB_UEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaPruebaDeFrecuencia";
            this.Load += new System.EventHandler(this.Frm_TP3_PuntoB_UEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnl_Grafico.ResumeLayout(false);
            this.pnl_Grafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frecuencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_var_aleatorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.TextBox tb_cantInterv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel pnl_Grafico;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_valor_tabulado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_xo_cuadrado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_frecuencias;
        private System.Windows.Forms.TextBox tb_significancia_alfa;
        private System.Windows.Forms.TextBox tb_gdl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_resultado_final;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lim_inf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lim_sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEFO2FE;
        private System.Windows.Forms.Button Btn_Prueba_De_Frecuencia;
        private System.Windows.Forms.DataGridView dgv_var_aleatorias;
    }
}