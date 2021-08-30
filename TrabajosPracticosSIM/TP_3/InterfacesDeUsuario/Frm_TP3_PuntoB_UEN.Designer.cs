
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.Inclination = 10;
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.PointDepth = 50;
            chartArea3.Area3DStyle.PointGapDepth = 10;
            chartArea3.Area3DStyle.Rotation = 7;
            chartArea3.Area3DStyle.WallWidth = 3;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(22, 6);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.MidnightBlue;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(958, 329);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart_freq";
            // 
            // pnl_Grafico
            // 
            this.pnl_Grafico.Controls.Add(this.dgv_frecuencias);
            this.pnl_Grafico.Controls.Add(this.chart1);
            this.pnl_Grafico.Controls.Add(this.tb_significancia_alfa);
            this.pnl_Grafico.Controls.Add(this.label17);
            this.pnl_Grafico.Location = new System.Drawing.Point(415, 38);
            this.pnl_Grafico.Name = "pnl_Grafico";
            this.pnl_Grafico.Size = new System.Drawing.Size(980, 638);
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
            this.dgv_frecuencias.Location = new System.Drawing.Point(112, 341);
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
            this.tb_significancia_alfa.Location = new System.Drawing.Point(808, 403);
            this.tb_significancia_alfa.Name = "tb_significancia_alfa";
            this.tb_significancia_alfa.Size = new System.Drawing.Size(146, 22);
            this.tb_significancia_alfa.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(804, 362);
            this.label17.Name = "label17";

            this.label17.Size = new System.Drawing.Size(126, 21);

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
            this.Controls.Add(this.pnl_Grafico);
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
        private System.Windows.Forms.DataGridView dgv_frecuencias;
        private System.Windows.Forms.TextBox tb_significancia_alfa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lim_inf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lim_sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEFO2FE;
        private System.Windows.Forms.Button Btn_Prueba_De_Frecuencia;
        private System.Windows.Forms.DataGridView dgv_var_aleatorias;
    }
}