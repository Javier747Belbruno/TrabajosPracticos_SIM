
using System.Windows.Input;

namespace TrabajosPracticosSIM.TP_1.InterfacesDeUsuario
{
    partial class Frm_PantallaPruebaDeFrecuencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cantNros = new System.Windows.Forms.TextBox();
            this.tb_cantInterv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Gen_Leng = new System.Windows.Forms.Button();
            this.btn_met_mixto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Cong_mixto = new System.Windows.Forms.Panel();
            this.tb_m = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_genMixto = new System.Windows.Forms.Button();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_semilla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_Grafico = new System.Windows.Forms.Panel();
            this.tb_significancia_alfa = new System.Windows.Forms.TextBox();
            this.tb_gdl = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
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
            this.pnl_Cong_mixto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnl_Grafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frecuencias)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cant. de Nros a Generar";
            // 
            // tb_cantNros
            // 
            this.tb_cantNros.Location = new System.Drawing.Point(221, 100);
            this.tb_cantNros.Name = "tb_cantNros";
            this.tb_cantNros.Size = new System.Drawing.Size(146, 26);
            this.tb_cantNros.TabIndex = 2;
            // 
            // tb_cantInterv
            // 
            this.tb_cantInterv.Location = new System.Drawing.Point(221, 141);
            this.tb_cantInterv.Name = "tb_cantInterv";
            this.tb_cantInterv.Size = new System.Drawing.Size(146, 26);
            this.tb_cantInterv.TabIndex = 4;
            this.tb_cantInterv.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cant. de Subintervalos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Gen_Leng
            // 
            this.btn_Gen_Leng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gen_Leng.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gen_Leng.Location = new System.Drawing.Point(53, 207);
            this.btn_Gen_Leng.Name = "btn_Gen_Leng";
            this.btn_Gen_Leng.Size = new System.Drawing.Size(145, 114);
            this.btn_Gen_Leng.TabIndex = 5;
            this.btn_Gen_Leng.Text = "Método provisto por el lenguaje ";
            this.btn_Gen_Leng.UseVisualStyleBackColor = true;
            this.btn_Gen_Leng.Click += new System.EventHandler(this.btn_Gen_Leng_Click);
            // 
            // btn_met_mixto
            // 
            this.btn_met_mixto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_met_mixto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_met_mixto.Location = new System.Drawing.Point(221, 207);
            this.btn_met_mixto.Name = "btn_met_mixto";
            this.btn_met_mixto.Size = new System.Drawing.Size(139, 114);
            this.btn_met_mixto.TabIndex = 6;
            this.btn_met_mixto.Text = "Método Congruencial Mixto";
            this.btn_met_mixto.UseVisualStyleBackColor = true;
            this.btn_met_mixto.Click += new System.EventHandler(this.btn_met_mixto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generación de Números Aleatorios";
            // 
            // pnl_Cong_mixto
            // 
            this.pnl_Cong_mixto.Controls.Add(this.tb_m);
            this.pnl_Cong_mixto.Controls.Add(this.label11);
            this.pnl_Cong_mixto.Controls.Add(this.btn_genMixto);
            this.pnl_Cong_mixto.Controls.Add(this.tb_c);
            this.pnl_Cong_mixto.Controls.Add(this.label7);
            this.pnl_Cong_mixto.Controls.Add(this.tb_a);
            this.pnl_Cong_mixto.Controls.Add(this.label6);
            this.pnl_Cong_mixto.Controls.Add(this.tb_semilla);
            this.pnl_Cong_mixto.Controls.Add(this.label5);
            this.pnl_Cong_mixto.Controls.Add(this.label4);
            this.pnl_Cong_mixto.Location = new System.Drawing.Point(53, 355);
            this.pnl_Cong_mixto.Name = "pnl_Cong_mixto";
            this.pnl_Cong_mixto.Size = new System.Drawing.Size(306, 276);
            this.pnl_Cong_mixto.TabIndex = 8;
            // 
            // tb_m
            // 
            this.tb_m.Location = new System.Drawing.Point(147, 147);
            this.tb_m.Name = "tb_m";
            this.tb_m.Size = new System.Drawing.Size(100, 26);
            this.tb_m.TabIndex = 9;
            this.tb_m.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F);
            this.label11.Location = new System.Drawing.Point(96, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "m";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btn_genMixto
            // 
            this.btn_genMixto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_genMixto.Font = new System.Drawing.Font("Calibri", 9F);
            this.btn_genMixto.Location = new System.Drawing.Point(77, 191);
            this.btn_genMixto.Name = "btn_genMixto";
            this.btn_genMixto.Size = new System.Drawing.Size(133, 48);
            this.btn_genMixto.TabIndex = 7;
            this.btn_genMixto.Text = "Generar";
            this.btn_genMixto.UseVisualStyleBackColor = true;
            this.btn_genMixto.Click += new System.EventHandler(this.btn_genMixto_Click);
            // 
            // tb_c
            // 
            this.tb_c.Location = new System.Drawing.Point(147, 116);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(100, 26);
            this.tb_c.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F);
            this.label7.Location = new System.Drawing.Point(96, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "c";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(147, 84);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(100, 26);
            this.tb_a.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F);
            this.label6.Location = new System.Drawing.Point(96, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "a";
            // 
            // tb_semilla
            // 
            this.tb_semilla.Location = new System.Drawing.Point(147, 53);
            this.tb_semilla.Name = "tb_semilla";
            this.tb_semilla.Size = new System.Drawing.Size(100, 26);
            this.tb_semilla.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "semilla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingrese los parámetros";
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
            legend1.Name = "Legend1";
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
            this.chart1.Size = new System.Drawing.Size(958, 332);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart_freq";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // pnl_Grafico
            // 
            this.pnl_Grafico.Controls.Add(this.tb_significancia_alfa);
            this.pnl_Grafico.Controls.Add(this.tb_gdl);
            this.pnl_Grafico.Controls.Add(this.label17);
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
            // tb_significancia_alfa
            // 
            this.tb_significancia_alfa.Location = new System.Drawing.Point(848, 362);
            this.tb_significancia_alfa.Name = "tb_significancia_alfa";
            this.tb_significancia_alfa.Size = new System.Drawing.Size(121, 26);
            this.tb_significancia_alfa.TabIndex = 22;
            // 
            // tb_gdl
            // 
            this.tb_gdl.Location = new System.Drawing.Point(708, 362);
            this.tb_gdl.Name = "tb_gdl";
            this.tb_gdl.Size = new System.Drawing.Size(121, 26);
            this.tb_gdl.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(857, 341);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 18);
            this.label17.TabIndex = 20;
            this.label17.Text = "Significancia Alfa";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(705, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 18);
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
            this.label15.Size = new System.Drawing.Size(157, 18);
            this.label15.TabIndex = 17;
            this.label15.Text = "Prueba de Chi-Cuadrada";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(845, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 18);
            this.label14.TabIndex = 16;
            this.label14.Text = "Distr. Chi-Cuadrado";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(845, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "Valor Tabulado de";
            // 
            // tb_valor_tabulado
            // 
            this.tb_valor_tabulado.Location = new System.Drawing.Point(848, 439);
            this.tb_valor_tabulado.Name = "tb_valor_tabulado";
            this.tb_valor_tabulado.Size = new System.Drawing.Size(115, 26);
            this.tb_valor_tabulado.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(708, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "Calculado (Xo^2)";
            // 
            // tb_xo_cuadrado
            // 
            this.tb_xo_cuadrado.Location = new System.Drawing.Point(711, 439);
            this.tb_xo_cuadrado.Name = "tb_xo_cuadrado";
            this.tb_xo_cuadrado.Size = new System.Drawing.Size(102, 26);
            this.tb_xo_cuadrado.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(708, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 18);
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
            // Frm_PantallaPruebaDeFrecuencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1402, 761);
            this.Controls.Add(this.pnl_Grafico);
            this.Controls.Add(this.pnl_Cong_mixto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_met_mixto);
            this.Controls.Add(this.btn_Gen_Leng);
            this.Controls.Add(this.tb_cantInterv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cantNros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cerrar);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.Name = "Frm_PantallaPruebaDeFrecuencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaPruebaDeFrecuencia";
            this.pnl_Cong_mixto.ResumeLayout(false);
            this.pnl_Cong_mixto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnl_Grafico.ResumeLayout(false);
            this.pnl_Grafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frecuencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cantNros;
        private System.Windows.Forms.TextBox tb_cantInterv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Gen_Leng;
        private System.Windows.Forms.Button btn_met_mixto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_Cong_mixto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_genMixto;
        private System.Windows.Forms.TextBox tb_c;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_semilla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel pnl_Grafico;
        private System.Windows.Forms.TextBox tb_m;
        private System.Windows.Forms.Label label11;
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
    }
}