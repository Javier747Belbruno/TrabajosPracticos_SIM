
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cantNros = new System.Windows.Forms.TextBox();
            this.tb_cantInterv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Gen_Leng = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Cong_mixto = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_semilla = new System.Windows.Forms.TextBox();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_genMixto = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.pnl_Cong_mixto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(932, 490);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(125, 49);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cant. de Nros a Generar";
            // 
            // tb_cantNros
            // 
            this.tb_cantNros.Location = new System.Drawing.Point(221, 60);
            this.tb_cantNros.Name = "tb_cantNros";
            this.tb_cantNros.Size = new System.Drawing.Size(146, 22);
            this.tb_cantNros.TabIndex = 2;
            // 
            // tb_cantInterv
            // 
            this.tb_cantInterv.Location = new System.Drawing.Point(221, 96);
            this.tb_cantInterv.Name = "tb_cantInterv";
            this.tb_cantInterv.Size = new System.Drawing.Size(146, 22);
            this.tb_cantInterv.TabIndex = 4;
            this.tb_cantInterv.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cant. de Subintervalos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Gen_Leng
            // 
            this.btn_Gen_Leng.Location = new System.Drawing.Point(53, 145);
            this.btn_Gen_Leng.Name = "btn_Gen_Leng";
            this.btn_Gen_Leng.Size = new System.Drawing.Size(145, 101);
            this.btn_Gen_Leng.TabIndex = 5;
            this.btn_Gen_Leng.Text = "Método provisto por el lenguaje ";
            this.btn_Gen_Leng.UseVisualStyleBackColor = true;
            this.btn_Gen_Leng.Click += new System.EventHandler(this.btn_Gen_Leng_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 101);
            this.button2.TabIndex = 6;
            this.button2.Text = "Método Congruencial Mixto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generación de Números Aleatorios";
            // 
            // pnl_Cong_mixto
            // 
            this.pnl_Cong_mixto.Controls.Add(this.btn_genMixto);
            this.pnl_Cong_mixto.Controls.Add(this.tb_c);
            this.pnl_Cong_mixto.Controls.Add(this.label7);
            this.pnl_Cong_mixto.Controls.Add(this.tb_a);
            this.pnl_Cong_mixto.Controls.Add(this.label6);
            this.pnl_Cong_mixto.Controls.Add(this.tb_semilla);
            this.pnl_Cong_mixto.Controls.Add(this.label5);
            this.pnl_Cong_mixto.Controls.Add(this.label4);
            this.pnl_Cong_mixto.Location = new System.Drawing.Point(54, 266);
            this.pnl_Cong_mixto.Name = "pnl_Cong_mixto";
            this.pnl_Cong_mixto.Size = new System.Drawing.Size(306, 195);
            this.pnl_Cong_mixto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingrese los parámetros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "semilla";
            // 
            // tb_semilla
            // 
            this.tb_semilla.Location = new System.Drawing.Point(147, 47);
            this.tb_semilla.Name = "tb_semilla";
            this.tb_semilla.Size = new System.Drawing.Size(100, 22);
            this.tb_semilla.TabIndex = 2;
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(147, 75);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(100, 22);
            this.tb_a.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "a";
            // 
            // tb_c
            // 
            this.tb_c.Location = new System.Drawing.Point(147, 103);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(100, 22);
            this.tb_c.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "c";
            // 
            // btn_genMixto
            // 
            this.btn_genMixto.Location = new System.Drawing.Point(77, 140);
            this.btn_genMixto.Name = "btn_genMixto";
            this.btn_genMixto.Size = new System.Drawing.Size(133, 43);
            this.btn_genMixto.TabIndex = 7;
            this.btn_genMixto.Text = "Generar";
            this.btn_genMixto.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(457, 38);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(636, 423);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Exportar";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Datos";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exportar.BackgroundImage = global::TrabajosPracticosSIM.Properties.Resources.icons8_ms_excel_48;
            this.btn_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exportar.Location = new System.Drawing.Point(561, 485);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(66, 58);
            this.btn_exportar.TabIndex = 10;
            this.btn_exportar.UseVisualStyleBackColor = false;
            // 
            // Frm_PantallaPruebaDeFrecuencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 576);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pnl_Cong_mixto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Gen_Leng);
            this.Controls.Add(this.tb_cantInterv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cantNros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cerrar);
            this.Name = "Frm_PantallaPruebaDeFrecuencia";
            this.Text = "PantallaPruebaDeFrecuencia";
            this.pnl_Cong_mixto.ResumeLayout(false);
            this.pnl_Cong_mixto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Button button2;
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
    }
}