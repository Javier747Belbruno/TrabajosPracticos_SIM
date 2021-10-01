﻿
namespace TrabajosPracticosSIM.TP_4.Entidades
{
    partial class Frm_TP4_Montecarlo
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
            this.btn_simular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSimulacion = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Config = new System.Windows.Forms.Panel();
            this.btn_config = new System.Windows.Forms.PictureBox();
            this.pnl_Actividades = new System.Windows.Forms.Panel();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_hasta = new System.Windows.Forms.TextBox();
            this.tb_desde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_cant_sim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_prom_ensamble = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Grafico = new System.Windows.Forms.Button();
            this.tb_Minimo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Maximo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_Probabilidad45 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_Fecha90A = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_Fecha90B = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            this.pnl_Config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).BeginInit();
            this.pnl_Actividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_simular
            // 
            this.btn_simular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_simular.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(12, 467);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(257, 103);
            this.btn_simular.TabIndex = 0;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configurar";
            // 
            // dgvSimulacion
            // 
            this.dgvSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulacion.Location = new System.Drawing.Point(275, 36);
            this.dgvSimulacion.Name = "dgvSimulacion";
            this.dgvSimulacion.RowHeadersWidth = 51;
            this.dgvSimulacion.RowTemplate.Height = 24;
            this.dgvSimulacion.Size = new System.Drawing.Size(984, 463);
            this.dgvSimulacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Actividades";
            // 
            // pnl_Config
            // 
            this.pnl_Config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Config.Controls.Add(this.label2);
            this.pnl_Config.Controls.Add(this.btn_config);
            this.pnl_Config.Controls.Add(this.label1);
            this.pnl_Config.Location = new System.Drawing.Point(12, 587);
            this.pnl_Config.Name = "pnl_Config";
            this.pnl_Config.Size = new System.Drawing.Size(257, 119);
            this.pnl_Config.TabIndex = 5;
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_config.Image = global::TrabajosPracticosSIM.Properties.Resources.ConfigImage2;
            this.btn_config.Location = new System.Drawing.Point(132, 17);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(89, 76);
            this.btn_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_config.TabIndex = 1;
            this.btn_config.TabStop = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // pnl_Actividades
            // 
            this.pnl_Actividades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Actividades.Controls.Add(this.dgvActividades);
            this.pnl_Actividades.Controls.Add(this.label8);
            this.pnl_Actividades.Location = new System.Drawing.Point(12, 36);
            this.pnl_Actividades.Name = "pnl_Actividades";
            this.pnl_Actividades.Size = new System.Drawing.Size(257, 203);
            this.pnl_Actividades.TabIndex = 6;
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(3, 35);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.RowHeadersWidth = 51;
            this.dgvActividades.RowTemplate.Height = 24;
            this.dgvActividades.Size = new System.Drawing.Size(249, 159);
            this.dgvActividades.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Actividades";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_hasta);
            this.panel1.Controls.Add(this.tb_desde);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_cant_sim);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 204);
            this.panel1.TabIndex = 7;
            // 
            // tb_hasta
            // 
            this.tb_hasta.Location = new System.Drawing.Point(86, 142);
            this.tb_hasta.Name = "tb_hasta";
            this.tb_hasta.Size = new System.Drawing.Size(145, 22);
            this.tb_hasta.TabIndex = 15;
            this.tb_hasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_desde
            // 
            this.tb_desde.Location = new System.Drawing.Point(86, 103);
            this.tb_desde.Name = "tb_desde";
            this.tb_desde.Size = new System.Drawing.Size(145, 22);
            this.tb_desde.TabIndex = 14;
            this.tb_desde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Desde";
            // 
            // tb_cant_sim
            // 
            this.tb_cant_sim.Location = new System.Drawing.Point(86, 44);
            this.tb_cant_sim.Name = "tb_cant_sim";
            this.tb_cant_sim.Size = new System.Drawing.Size(145, 22);
            this.tb_cant_sim.TabIndex = 11;
            this.tb_cant_sim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "a Simular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese los Parámetros de la Sim.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(324, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Promedio Ensamble";
            // 
            // tb_prom_ensamble
            // 
            this.tb_prom_ensamble.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_prom_ensamble.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_prom_ensamble.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prom_ensamble.Location = new System.Drawing.Point(329, 551);
            this.tb_prom_ensamble.Name = "tb_prom_ensamble";
            this.tb_prom_ensamble.ReadOnly = true;
            this.tb_prom_ensamble.Size = new System.Drawing.Size(139, 24);
            this.tb_prom_ensamble.TabIndex = 9;
            this.tb_prom_ensamble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(324, 603);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Evolución del tiempo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(325, 624);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Promedio Ensamble";
            // 
            // btn_Grafico
            // 
            this.btn_Grafico.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Grafico.Location = new System.Drawing.Point(323, 648);
            this.btn_Grafico.Name = "btn_Grafico";
            this.btn_Grafico.Size = new System.Drawing.Size(145, 58);
            this.btn_Grafico.TabIndex = 12;
            this.btn_Grafico.Text = "Graficar";
            this.btn_Grafico.UseVisualStyleBackColor = true;
            this.btn_Grafico.Click += new System.EventHandler(this.btn_Grafico_Click);
            // 
            // tb_Minimo
            // 
            this.tb_Minimo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Minimo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Minimo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Minimo.Location = new System.Drawing.Point(548, 539);
            this.tb_Minimo.Name = "tb_Minimo";
            this.tb_Minimo.ReadOnly = true;
            this.tb_Minimo.Size = new System.Drawing.Size(88, 24);
            this.tb_Minimo.TabIndex = 14;
            this.tb_Minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Minimo.TextChanged += new System.EventHandler(this.tb_Minimo_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(545, 519);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Minimo";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tb_Maximo
            // 
            this.tb_Maximo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Maximo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Maximo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Maximo.Location = new System.Drawing.Point(548, 600);
            this.tb_Maximo.Name = "tb_Maximo";
            this.tb_Maximo.ReadOnly = true;
            this.tb_Maximo.Size = new System.Drawing.Size(92, 24);
            this.tb_Maximo.TabIndex = 16;
            this.tb_Maximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(545, 580);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Maximo";
            // 
            // tb_Probabilidad45
            // 
            this.tb_Probabilidad45.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Probabilidad45.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Probabilidad45.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Probabilidad45.Location = new System.Drawing.Point(673, 539);
            this.tb_Probabilidad45.Name = "tb_Probabilidad45";
            this.tb_Probabilidad45.ReadOnly = true;
            this.tb_Probabilidad45.Size = new System.Drawing.Size(88, 24);
            this.tb_Probabilidad45.TabIndex = 18;
            this.tb_Probabilidad45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Probabilidad45.TextChanged += new System.EventHandler(this.tb_Probabilidad_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(670, 519);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(249, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Probabilidad de que se complete en 45 dias";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // tb_Fecha90A
            // 
            this.tb_Fecha90A.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Fecha90A.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Fecha90A.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fecha90A.Location = new System.Drawing.Point(673, 600);
            this.tb_Fecha90A.Name = "tb_Fecha90A";
            this.tb_Fecha90A.ReadOnly = true;
            this.tb_Fecha90A.Size = new System.Drawing.Size(88, 24);
            this.tb_Fecha90A.TabIndex = 20;
            this.tb_Fecha90A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(670, 580);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Fecha a terminar- 90% de certeza A";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // tb_Fecha90B
            // 
            this.tb_Fecha90B.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Fecha90B.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Fecha90B.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fecha90B.Location = new System.Drawing.Point(947, 539);
            this.tb_Fecha90B.Name = "tb_Fecha90B";
            this.tb_Fecha90B.ReadOnly = true;
            this.tb_Fecha90B.Size = new System.Drawing.Size(88, 24);
            this.tb_Fecha90B.TabIndex = 22;
            this.tb_Fecha90B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(944, 519);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "Fecha a terminar- 90% de certeza B";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1096, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 94);
            this.button1.TabIndex = 23;
            this.button1.Text = "Analisis de Actividad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_TP4_Montecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 735);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Fecha90B);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_Fecha90A);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_Probabilidad45);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_Maximo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_Minimo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Grafico);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_prom_ensamble);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Actividades);
            this.Controls.Add(this.pnl_Config);
            this.Controls.Add(this.dgvSimulacion);
            this.Controls.Add(this.btn_simular);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_TP4_Montecarlo";
            this.Text = "Frm_TP4_Montecarlo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).EndInit();
            this.pnl_Config.ResumeLayout(false);
            this.pnl_Config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).EndInit();
            this.pnl_Actividades.ResumeLayout(false);
            this.pnl_Actividades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.PictureBox btn_config;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSimulacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Config;
        private System.Windows.Forms.Panel pnl_Actividades;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_hasta;
        private System.Windows.Forms.TextBox tb_desde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_cant_sim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_prom_ensamble;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Grafico;
        private System.Windows.Forms.TextBox tb_Minimo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Maximo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_Probabilidad45;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_Fecha90A;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_Fecha90B;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
    }
}