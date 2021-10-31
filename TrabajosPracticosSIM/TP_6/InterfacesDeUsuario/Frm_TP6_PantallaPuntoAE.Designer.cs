
namespace TrabajosPracticosSIM.TP_6.InterfacesDeUsuario
{
    partial class Frm_TP6_PantallaPuntoAE
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
            this.pnl_Config = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_punto_b_x_t = new System.Windows.Forms.Button();
            this.btn_punto_c = new System.Windows.Forms.Button();
            this.btn_punto_d = new System.Windows.Forms.Button();
            this.btn_punto_e = new System.Windows.Forms.Button();
            this.btn_euler = new System.Windows.Forms.Button();
            this.btn_rk = new System.Windows.Forms.Button();
            this.pnl_botones = new System.Windows.Forms.Panel();
            this.pnl_euler = new System.Windows.Forms.Panel();
            this.dgvEuler = new System.Windows.Forms.DataGridView();
            this.pnl_rk = new System.Windows.Forms.Panel();
            this.dgvRK = new System.Windows.Forms.DataGridView();
            this.pnl_graficos = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_2pico_e_t = new System.Windows.Forms.TextBox();
            this.tb_2pico_e_x1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_2pico_rk_x1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_2pico_rk_t = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_a_e = new System.Windows.Forms.Label();
            this.lb_a_rk = new System.Windows.Forms.Label();
            this.btn_punto_b_dx_t = new System.Windows.Forms.Button();
            this.btn_punto_b_ddx_t = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.PictureBox();
            this.pnl_Config.SuspendLayout();
            this.pnl_botones.SuspendLayout();
            this.pnl_euler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).BeginInit();
            this.pnl_rk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).BeginInit();
            this.pnl_graficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Config
            // 
            this.pnl_Config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Config.Controls.Add(this.label2);
            this.pnl_Config.Controls.Add(this.btn_config);
            this.pnl_Config.Controls.Add(this.label1);
            this.pnl_Config.Location = new System.Drawing.Point(12, 610);
            this.pnl_Config.Name = "pnl_Config";
            this.pnl_Config.Size = new System.Drawing.Size(306, 121);
            this.pnl_Config.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parámetros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configurar";
            // 
            // btn_punto_b_x_t
            // 
            this.btn_punto_b_x_t.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punto_b_x_t.Location = new System.Drawing.Point(40, 39);
            this.btn_punto_b_x_t.Name = "btn_punto_b_x_t";
            this.btn_punto_b_x_t.Size = new System.Drawing.Size(137, 87);
            this.btn_punto_b_x_t.TabIndex = 12;
            this.btn_punto_b_x_t.Text = "Gráfico de x en función de t";
            this.btn_punto_b_x_t.UseVisualStyleBackColor = true;
            this.btn_punto_b_x_t.Click += new System.EventHandler(this.btn_punto_b_x_t_Click);
            // 
            // btn_punto_c
            // 
            this.btn_punto_c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punto_c.Location = new System.Drawing.Point(748, 39);
            this.btn_punto_c.Name = "btn_punto_c";
            this.btn_punto_c.Size = new System.Drawing.Size(137, 87);
            this.btn_punto_c.TabIndex = 13;
            this.btn_punto_c.Text = "Gráfico de x\" en función de  x";
            this.btn_punto_c.UseVisualStyleBackColor = true;
            this.btn_punto_c.Click += new System.EventHandler(this.btn_punto_c_Click);
            // 
            // btn_punto_d
            // 
            this.btn_punto_d.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punto_d.Location = new System.Drawing.Point(961, 39);
            this.btn_punto_d.Name = "btn_punto_d";
            this.btn_punto_d.Size = new System.Drawing.Size(137, 87);
            this.btn_punto_d.TabIndex = 14;
            this.btn_punto_d.Text = "Gráfico de x\' en función de x";
            this.btn_punto_d.UseVisualStyleBackColor = true;
            this.btn_punto_d.Click += new System.EventHandler(this.btn_punto_d_Click);
            // 
            // btn_punto_e
            // 
            this.btn_punto_e.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punto_e.Location = new System.Drawing.Point(1180, 39);
            this.btn_punto_e.Name = "btn_punto_e";
            this.btn_punto_e.Size = new System.Drawing.Size(135, 87);
            this.btn_punto_e.TabIndex = 15;
            this.btn_punto_e.Text = "Gráfico de x\" en función de  x\'";
            this.btn_punto_e.UseVisualStyleBackColor = true;
            this.btn_punto_e.Click += new System.EventHandler(this.btn_punto_e_Click);
            // 
            // btn_euler
            // 
            this.btn_euler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_euler.Location = new System.Drawing.Point(119, 3);
            this.btn_euler.Name = "btn_euler";
            this.btn_euler.Size = new System.Drawing.Size(258, 52);
            this.btn_euler.TabIndex = 16;
            this.btn_euler.Text = "Calcular por Método Euler";
            this.btn_euler.UseVisualStyleBackColor = true;
            this.btn_euler.Click += new System.EventHandler(this.btn_euler_Click);
            // 
            // btn_rk
            // 
            this.btn_rk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rk.Location = new System.Drawing.Point(806, 3);
            this.btn_rk.Name = "btn_rk";
            this.btn_rk.Size = new System.Drawing.Size(292, 52);
            this.btn_rk.TabIndex = 17;
            this.btn_rk.Text = "Calcular por Método RK4";
            this.btn_rk.UseVisualStyleBackColor = true;
            this.btn_rk.Click += new System.EventHandler(this.btn_rk_Click);
            // 
            // pnl_botones
            // 
            this.pnl_botones.Controls.Add(this.btn_euler);
            this.pnl_botones.Controls.Add(this.btn_rk);
            this.pnl_botones.Location = new System.Drawing.Point(12, 12);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(1367, 62);
            this.pnl_botones.TabIndex = 18;
            // 
            // pnl_euler
            // 
            this.pnl_euler.Controls.Add(this.lb_a_e);
            this.pnl_euler.Controls.Add(this.tb_2pico_e_x1);
            this.pnl_euler.Controls.Add(this.label4);
            this.pnl_euler.Controls.Add(this.tb_2pico_e_t);
            this.pnl_euler.Controls.Add(this.label3);
            this.pnl_euler.Controls.Add(this.dgvEuler);
            this.pnl_euler.Location = new System.Drawing.Point(12, 73);
            this.pnl_euler.Name = "pnl_euler";
            this.pnl_euler.Size = new System.Drawing.Size(493, 372);
            this.pnl_euler.TabIndex = 19;
            // 
            // dgvEuler
            // 
            this.dgvEuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEuler.Location = new System.Drawing.Point(3, 56);
            this.dgvEuler.Name = "dgvEuler";
            this.dgvEuler.RowHeadersWidth = 51;
            this.dgvEuler.RowTemplate.Height = 24;
            this.dgvEuler.Size = new System.Drawing.Size(474, 265);
            this.dgvEuler.TabIndex = 0;
            // 
            // pnl_rk
            // 
            this.pnl_rk.Controls.Add(this.lb_a_rk);
            this.pnl_rk.Controls.Add(this.tb_2pico_rk_x1);
            this.pnl_rk.Controls.Add(this.dgvRK);
            this.pnl_rk.Controls.Add(this.label5);
            this.pnl_rk.Controls.Add(this.tb_2pico_rk_t);
            this.pnl_rk.Controls.Add(this.label6);
            this.pnl_rk.Location = new System.Drawing.Point(511, 73);
            this.pnl_rk.Name = "pnl_rk";
            this.pnl_rk.Size = new System.Drawing.Size(868, 372);
            this.pnl_rk.TabIndex = 20;
            // 
            // dgvRK
            // 
            this.dgvRK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRK.Location = new System.Drawing.Point(3, 56);
            this.dgvRK.Name = "dgvRK";
            this.dgvRK.RowHeadersWidth = 51;
            this.dgvRK.RowTemplate.Height = 24;
            this.dgvRK.Size = new System.Drawing.Size(842, 265);
            this.dgvRK.TabIndex = 1;
            // 
            // pnl_graficos
            // 
            this.pnl_graficos.Controls.Add(this.btn_punto_b_ddx_t);
            this.pnl_graficos.Controls.Add(this.btn_punto_b_dx_t);
            this.pnl_graficos.Controls.Add(this.btn_punto_b_x_t);
            this.pnl_graficos.Controls.Add(this.btn_punto_e);
            this.pnl_graficos.Controls.Add(this.btn_punto_c);
            this.pnl_graficos.Controls.Add(this.btn_punto_d);
            this.pnl_graficos.Location = new System.Drawing.Point(12, 451);
            this.pnl_graficos.Name = "pnl_graficos";
            this.pnl_graficos.Size = new System.Drawing.Size(1367, 153);
            this.pnl_graficos.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor 2do Pico en t";
            // 
            // tb_2pico_e_t
            // 
            this.tb_2pico_e_t.Location = new System.Drawing.Point(141, 341);
            this.tb_2pico_e_t.Name = "tb_2pico_e_t";
            this.tb_2pico_e_t.Size = new System.Drawing.Size(86, 26);
            this.tb_2pico_e_t.TabIndex = 2;
            this.tb_2pico_e_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_2pico_e_x1
            // 
            this.tb_2pico_e_x1.Location = new System.Drawing.Point(382, 341);
            this.tb_2pico_e_x1.Name = "tb_2pico_e_x1";
            this.tb_2pico_e_x1.Size = new System.Drawing.Size(86, 26);
            this.tb_2pico_e_x1.TabIndex = 4;
            this.tb_2pico_e_x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor 2do Pico en x1";
            // 
            // tb_2pico_rk_x1
            // 
            this.tb_2pico_rk_x1.Location = new System.Drawing.Point(630, 336);
            this.tb_2pico_rk_x1.Name = "tb_2pico_rk_x1";
            this.tb_2pico_rk_x1.Size = new System.Drawing.Size(100, 26);
            this.tb_2pico_rk_x1.TabIndex = 24;
            this.tb_2pico_rk_x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Valor 2do Pico en x1";
            // 
            // tb_2pico_rk_t
            // 
            this.tb_2pico_rk_t.Location = new System.Drawing.Point(286, 336);
            this.tb_2pico_rk_t.Name = "tb_2pico_rk_t";
            this.tb_2pico_rk_t.Size = new System.Drawing.Size(100, 26);
            this.tb_2pico_rk_t.TabIndex = 22;
            this.tb_2pico_rk_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Valor 2do Pico en t";
            // 
            // lb_a_e
            // 
            this.lb_a_e.AutoSize = true;
            this.lb_a_e.Location = new System.Drawing.Point(23, 16);
            this.lb_a_e.Name = "lb_a_e";
            this.lb_a_e.Size = new System.Drawing.Size(0, 18);
            this.lb_a_e.TabIndex = 5;
            // 
            // lb_a_rk
            // 
            this.lb_a_rk.AutoSize = true;
            this.lb_a_rk.Location = new System.Drawing.Point(37, 16);
            this.lb_a_rk.Name = "lb_a_rk";
            this.lb_a_rk.Size = new System.Drawing.Size(0, 18);
            this.lb_a_rk.TabIndex = 6;
            // 
            // btn_punto_b_dx_t
            // 
            this.btn_punto_b_dx_t.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punto_b_dx_t.Location = new System.Drawing.Point(261, 39);
            this.btn_punto_b_dx_t.Name = "btn_punto_b_dx_t";
            this.btn_punto_b_dx_t.Size = new System.Drawing.Size(137, 87);
            this.btn_punto_b_dx_t.TabIndex = 21;
            this.btn_punto_b_dx_t.Text = "Gráfico de x\' en función de t";
            this.btn_punto_b_dx_t.UseVisualStyleBackColor = true;
            this.btn_punto_b_dx_t.Click += new System.EventHandler(this.btn_punto_b_dx_t_Click);
            // 
            // btn_punto_b_ddx_t
            // 
            this.btn_punto_b_ddx_t.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punto_b_ddx_t.Location = new System.Drawing.Point(487, 39);
            this.btn_punto_b_ddx_t.Name = "btn_punto_b_ddx_t";
            this.btn_punto_b_ddx_t.Size = new System.Drawing.Size(137, 87);
            this.btn_punto_b_ddx_t.TabIndex = 22;
            this.btn_punto_b_ddx_t.Text = "Gráfico de x\" en función de t";
            this.btn_punto_b_ddx_t.UseVisualStyleBackColor = true;
            this.btn_punto_b_ddx_t.Click += new System.EventHandler(this.btn_punto_b_ddx_t_Click);
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_config.Image = global::TrabajosPracticosSIM.Properties.Resources.ConfigImage2;
            this.btn_config.Location = new System.Drawing.Point(196, 18);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(76, 73);
            this.btn_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_config.TabIndex = 1;
            this.btn_config.TabStop = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // Frm_TP6_PantallaPuntoAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 771);
            this.Controls.Add(this.pnl_graficos);
            this.Controls.Add(this.pnl_rk);
            this.Controls.Add(this.pnl_euler);
            this.Controls.Add(this.pnl_botones);
            this.Controls.Add(this.pnl_Config);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_TP6_PantallaPuntoAE";
            this.Text = "Frm_TP6_PantallaPuntoAE";
            this.pnl_Config.ResumeLayout(false);
            this.pnl_Config.PerformLayout();
            this.pnl_botones.ResumeLayout(false);
            this.pnl_euler.ResumeLayout(false);
            this.pnl_euler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).EndInit();
            this.pnl_rk.ResumeLayout(false);
            this.pnl_rk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).EndInit();
            this.pnl_graficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Config;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_config;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_punto_b_x_t;
        private System.Windows.Forms.Button btn_punto_c;
        private System.Windows.Forms.Button btn_punto_d;
        private System.Windows.Forms.Button btn_punto_e;
        private System.Windows.Forms.Button btn_euler;
        private System.Windows.Forms.Button btn_rk;
        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.Panel pnl_euler;
        private System.Windows.Forms.DataGridView dgvEuler;
        private System.Windows.Forms.Panel pnl_rk;
        private System.Windows.Forms.DataGridView dgvRK;
        private System.Windows.Forms.Panel pnl_graficos;
        private System.Windows.Forms.TextBox tb_2pico_e_x1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_2pico_e_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_2pico_rk_x1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_2pico_rk_t;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_a_e;
        private System.Windows.Forms.Label lb_a_rk;
        private System.Windows.Forms.Button btn_punto_b_ddx_t;
        private System.Windows.Forms.Button btn_punto_b_dx_t;
    }
}