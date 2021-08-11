
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.pnl_Grafico = new System.Windows.Forms.Panel();
            this.pnl_Cong_mixto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnl_Grafico.SuspendLayout();
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 62);
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
            this.chart1.Size = new System.Drawing.Size(917, 451);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart_freq";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Exportar";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(256, 576);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Datos";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exportar.BackgroundImage = global::TrabajosPracticosSIM.Properties.Resources.icons8_ms_excel_48;
            this.btn_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.Location = new System.Drawing.Point(335, 544);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(79, 69);
            this.btn_exportar.TabIndex = 10;
            this.btn_exportar.UseVisualStyleBackColor = false;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // pnl_Grafico
            // 
            this.pnl_Grafico.Controls.Add(this.chart1);
            this.pnl_Grafico.Controls.Add(this.label9);
            this.pnl_Grafico.Controls.Add(this.btn_exportar);
            this.pnl_Grafico.Controls.Add(this.label8);
            this.pnl_Grafico.Location = new System.Drawing.Point(396, 38);
            this.pnl_Grafico.Name = "pnl_Grafico";
            this.pnl_Grafico.Size = new System.Drawing.Size(971, 630);
            this.pnl_Grafico.TabIndex = 13;
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
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnl_Grafico;
        private System.Windows.Forms.TextBox tb_m;
        private System.Windows.Forms.Label label11;
    }
}