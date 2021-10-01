
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
            this.btn_config = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSimulacion = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Config = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            this.pnl_Config.SuspendLayout();
            this.pnl_Actividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_simular
            // 
            this.btn_simular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simular.Location = new System.Drawing.Point(12, 455);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(257, 90);
            this.btn_simular.TabIndex = 0;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_config.Image = global::TrabajosPracticosSIM.Properties.Resources.ConfigImage2;
            this.btn_config.Location = new System.Drawing.Point(115, 27);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(66, 55);
            this.btn_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_config.TabIndex = 1;
            this.btn_config.TabStop = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
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
            this.label2.Location = new System.Drawing.Point(34, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Actividades";
            // 
            // pnl_Config
            // 
            this.pnl_Config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Config.Controls.Add(this.label2);
            this.pnl_Config.Controls.Add(this.btn_config);
            this.pnl_Config.Controls.Add(this.label1);
            this.pnl_Config.Location = new System.Drawing.Point(12, 551);
            this.pnl_Config.Name = "pnl_Config";
            this.pnl_Config.Size = new System.Drawing.Size(257, 119);
            this.pnl_Config.TabIndex = 5;
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
            this.label8.Location = new System.Drawing.Point(6, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
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
            this.tb_hasta.Size = new System.Drawing.Size(145, 26);
            this.tb_hasta.TabIndex = 15;
            this.tb_hasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_desde
            // 
            this.tb_desde.Location = new System.Drawing.Point(86, 103);
            this.tb_desde.Name = "tb_desde";
            this.tb_desde.Size = new System.Drawing.Size(145, 26);
            this.tb_desde.TabIndex = 14;
            this.tb_desde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Desde";
            // 
            // tb_cant_sim
            // 
            this.tb_cant_sim.Location = new System.Drawing.Point(86, 44);
            this.tb_cant_sim.Name = "tb_cant_sim";
            this.tb_cant_sim.Size = new System.Drawing.Size(145, 26);
            this.tb_cant_sim.TabIndex = 11;
            this.tb_cant_sim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "a Simular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese los Parámetros de la Simulación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Promedio Ensamble";
            // 
            // tb_prom_ensamble
            // 
            this.tb_prom_ensamble.Location = new System.Drawing.Point(324, 566);
            this.tb_prom_ensamble.Name = "tb_prom_ensamble";
            this.tb_prom_ensamble.Size = new System.Drawing.Size(145, 26);
            this.tb_prom_ensamble.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 631);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Evolución del tiempo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(337, 649);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Promedio Ensamble";
            // 
            // btn_Grafico
            // 
            this.btn_Grafico.Location = new System.Drawing.Point(334, 670);
            this.btn_Grafico.Name = "btn_Grafico";
            this.btn_Grafico.Size = new System.Drawing.Size(135, 43);
            this.btn_Grafico.TabIndex = 12;
            this.btn_Grafico.Text = "Graficar";
            this.btn_Grafico.UseVisualStyleBackColor = true;
            this.btn_Grafico.Click += new System.EventHandler(this.btn_Grafico_Click);
            // 
            // Frm_TP4_Montecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 735);
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).EndInit();
            this.pnl_Config.ResumeLayout(false);
            this.pnl_Config.PerformLayout();
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
    }
}