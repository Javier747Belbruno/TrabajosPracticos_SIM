
using System.Windows.Input;

namespace TrabajosPracticosSIM.TP_3.InterfacesDeUsuario
{
    partial class Frm_TP3_PuntoB
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.tb_cantInterv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_Grafico = new System.Windows.Forms.Panel();
            this.dgv_frecuencias = new System.Windows.Forms.DataGridView();
            this.Lim_inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lim_sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEFO2FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_significancia_alfa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Btn_Prueba_De_Frecuencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_parametros = new System.Windows.Forms.Label();
            this.lbl_distr_seleccionada = new System.Windows.Forms.Label();
            this.lbl_cant_var_aleatorias = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Chi_Cuadrado = new System.Windows.Forms.Button();
            this.pnl_x2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Probabilidades = new System.Windows.Forms.Button();
            this.dgv_distribucion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnl_Grafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frecuencias)).BeginInit();
            this.pnl_x2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_distribucion)).BeginInit();
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
            this.tb_cantInterv.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cantInterv.Location = new System.Drawing.Point(234, 377);
            this.tb_cantInterv.Name = "tb_cantInterv";
            this.tb_cantInterv.Size = new System.Drawing.Size(146, 28);
            this.tb_cantInterv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cant. de Intervalos";
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 10;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.PointDepth = 50;
            chartArea1.Area3DStyle.PointGapDepth = 10;
            chartArea1.Area3DStyle.Rotation = 7;
            chartArea1.Area3DStyle.WallWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5.84146F;
            legend1.Position.Width = 20.88608F;
            legend1.Position.X = 76.11392F;
            legend1.Position.Y = 8F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.MidnightBlue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(949, 329);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart_freq";
            // 
            // pnl_Grafico
            // 
            this.pnl_Grafico.Controls.Add(this.dgv_frecuencias);
            this.pnl_Grafico.Controls.Add(this.chart1);
            this.pnl_Grafico.Location = new System.Drawing.Point(428, 38);
            this.pnl_Grafico.Name = "pnl_Grafico";
            this.pnl_Grafico.Size = new System.Drawing.Size(967, 638);
            this.pnl_Grafico.TabIndex = 13;
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
            this.dgv_frecuencias.Location = new System.Drawing.Point(102, 338);
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
            this.tb_significancia_alfa.Location = new System.Drawing.Point(208, 25);
            this.tb_significancia_alfa.Name = "tb_significancia_alfa";
            this.tb_significancia_alfa.Size = new System.Drawing.Size(146, 26);
            this.tb_significancia_alfa.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(56, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 21);
            this.label17.TabIndex = 20;
            this.label17.Text = "Significancia Alfa";
            // 
            // Btn_Prueba_De_Frecuencia
            // 
            this.Btn_Prueba_De_Frecuencia.Location = new System.Drawing.Point(124, 428);
            this.Btn_Prueba_De_Frecuencia.Name = "Btn_Prueba_De_Frecuencia";
            this.Btn_Prueba_De_Frecuencia.Size = new System.Drawing.Size(194, 54);
            this.Btn_Prueba_De_Frecuencia.TabIndex = 23;
            this.Btn_Prueba_De_Frecuencia.Text = "Prueba de Frecuencia";
            this.Btn_Prueba_De_Frecuencia.UseVisualStyleBackColor = true;
            this.Btn_Prueba_De_Frecuencia.Click += new System.EventHandler(this.Btn_Prueba_De_Frecuencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Distribución Seleccionada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Parametros";
            // 
            // lbl_parametros
            // 
            this.lbl_parametros.AutoSize = true;
            this.lbl_parametros.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parametros.Location = new System.Drawing.Point(191, 46);
            this.lbl_parametros.Name = "lbl_parametros";
            this.lbl_parametros.Size = new System.Drawing.Size(117, 21);
            this.lbl_parametros.TabIndex = 28;
            this.lbl_parametros.Text = "lbl_parametros";
            // 
            // lbl_distr_seleccionada
            // 
            this.lbl_distr_seleccionada.AutoSize = true;
            this.lbl_distr_seleccionada.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_distr_seleccionada.Location = new System.Drawing.Point(191, 14);
            this.lbl_distr_seleccionada.Name = "lbl_distr_seleccionada";
            this.lbl_distr_seleccionada.Size = new System.Drawing.Size(165, 21);
            this.lbl_distr_seleccionada.TabIndex = 29;
            this.lbl_distr_seleccionada.Text = "lbl_distr_seleccionada";
            // 
            // lbl_cant_var_aleatorias
            // 
            this.lbl_cant_var_aleatorias.AutoSize = true;
            this.lbl_cant_var_aleatorias.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant_var_aleatorias.Location = new System.Drawing.Point(191, 77);
            this.lbl_cant_var_aleatorias.Name = "lbl_cant_var_aleatorias";
            this.lbl_cant_var_aleatorias.Size = new System.Drawing.Size(172, 21);
            this.lbl_cant_var_aleatorias.TabIndex = 31;
            this.lbl_cant_var_aleatorias.Text = "lbl_cant_var_aleatorias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cant. de var. Aleat.";
            // 
            // Btn_Chi_Cuadrado
            // 
            this.Btn_Chi_Cuadrado.Location = new System.Drawing.Point(98, 66);
            this.Btn_Chi_Cuadrado.Name = "Btn_Chi_Cuadrado";
            this.Btn_Chi_Cuadrado.Size = new System.Drawing.Size(194, 54);
            this.Btn_Chi_Cuadrado.TabIndex = 32;
            this.Btn_Chi_Cuadrado.Text = "Prueba de X^2";
            this.Btn_Chi_Cuadrado.UseVisualStyleBackColor = true;
            this.Btn_Chi_Cuadrado.Click += new System.EventHandler(this.Btn_Chi_Cuadrado_Click);
            // 
            // pnl_x2
            // 
            this.pnl_x2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_x2.Controls.Add(this.tb_significancia_alfa);
            this.pnl_x2.Controls.Add(this.Btn_Chi_Cuadrado);
            this.pnl_x2.Controls.Add(this.label17);
            this.pnl_x2.Location = new System.Drawing.Point(9, 534);
            this.pnl_x2.Name = "pnl_x2";
            this.pnl_x2.Size = new System.Drawing.Size(413, 158);
            this.pnl_x2.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btn_Probabilidades);
            this.panel2.Controls.Add(this.dgv_distribucion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_cant_var_aleatorias);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_cantInterv);
            this.panel2.Controls.Add(this.lbl_distr_seleccionada);
            this.panel2.Controls.Add(this.Btn_Prueba_De_Frecuencia);
            this.panel2.Controls.Add(this.lbl_parametros);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 490);
            this.panel2.TabIndex = 34;
            // 
            // Btn_Probabilidades
            // 
            this.Btn_Probabilidades.Location = new System.Drawing.Point(296, 35);
            this.Btn_Probabilidades.Name = "Btn_Probabilidades";
            this.Btn_Probabilidades.Size = new System.Drawing.Size(109, 45);
            this.Btn_Probabilidades.TabIndex = 33;
            this.Btn_Probabilidades.Text = "Ver Probabilidades";
            this.Btn_Probabilidades.UseVisualStyleBackColor = true;
            this.Btn_Probabilidades.Click += new System.EventHandler(this.Btn_Probabilidades_Click);
            // 
            // dgv_distribucion
            // 
            this.dgv_distribucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_distribucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_distribucion.Location = new System.Drawing.Point(3, 112);
            this.dgv_distribucion.Name = "dgv_distribucion";
            this.dgv_distribucion.RowHeadersWidth = 51;
            this.dgv_distribucion.RowTemplate.Height = 24;
            this.dgv_distribucion.Size = new System.Drawing.Size(402, 242);
            this.dgv_distribucion.TabIndex = 32;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Posición";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Random";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Var Aleatoria";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Frm_TP3_PuntoB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1402, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_x2);
            this.Controls.Add(this.pnl_Grafico);
            this.Controls.Add(this.btn_Cerrar);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.Name = "Frm_TP3_PuntoB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto B";
            this.Load += new System.EventHandler(this.Frm_TP3_PuntoB_UEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnl_Grafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frecuencias)).EndInit();
            this.pnl_x2.ResumeLayout(false);
            this.pnl_x2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_distribucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.TextBox tb_cantInterv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel pnl_Grafico;
        private System.Windows.Forms.DataGridView dgv_frecuencias;
        private System.Windows.Forms.TextBox tb_significancia_alfa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lim_inf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lim_sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEFO2FE;
        private System.Windows.Forms.Button Btn_Prueba_De_Frecuencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_parametros;
        private System.Windows.Forms.Label lbl_distr_seleccionada;
        private System.Windows.Forms.Label lbl_cant_var_aleatorias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Chi_Cuadrado;
        private System.Windows.Forms.Panel pnl_x2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_distribucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button Btn_Probabilidades;
    }
}