
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
            this.btn_config = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_punto_b = new System.Windows.Forms.Button();
            this.btn_punto_c = new System.Windows.Forms.Button();
            this.btn_punto_d = new System.Windows.Forms.Button();
            this.btn_punto_e = new System.Windows.Forms.Button();
            this.btn_euler = new System.Windows.Forms.Button();
            this.btn_rk = new System.Windows.Forms.Button();
            this.pnl_botones = new System.Windows.Forms.Panel();
            this.pnl_euler = new System.Windows.Forms.Panel();
            this.pnl_rk = new System.Windows.Forms.Panel();
            this.pnl_graficos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnl_Config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).BeginInit();
            this.pnl_botones.SuspendLayout();
            this.pnl_euler.SuspendLayout();
            this.pnl_rk.SuspendLayout();
            this.pnl_graficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Config
            // 
            this.pnl_Config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Config.Controls.Add(this.label2);
            this.pnl_Config.Controls.Add(this.btn_config);
            this.pnl_Config.Controls.Add(this.label1);
            this.pnl_Config.Location = new System.Drawing.Point(48, 638);
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
            // btn_punto_b
            // 
            this.btn_punto_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punto_b.Location = new System.Drawing.Point(26, 34);
            this.btn_punto_b.Name = "btn_punto_b";
            this.btn_punto_b.Size = new System.Drawing.Size(202, 87);
            this.btn_punto_b.TabIndex = 12;
            this.btn_punto_b.Text = "Graficos de x\", de x\' y de x en función de t";
            this.btn_punto_b.UseVisualStyleBackColor = true;
            // 
            // btn_punto_c
            // 
            this.btn_punto_c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punto_c.Location = new System.Drawing.Point(271, 30);
            this.btn_punto_c.Name = "btn_punto_c";
            this.btn_punto_c.Size = new System.Drawing.Size(222, 87);
            this.btn_punto_c.TabIndex = 13;
            this.btn_punto_c.Text = "Gráfico de x\" en función de  x";
            this.btn_punto_c.UseVisualStyleBackColor = true;
            // 
            // btn_punto_d
            // 
            this.btn_punto_d.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punto_d.Location = new System.Drawing.Point(575, 39);
            this.btn_punto_d.Name = "btn_punto_d";
            this.btn_punto_d.Size = new System.Drawing.Size(202, 87);
            this.btn_punto_d.TabIndex = 14;
            this.btn_punto_d.Text = "Gráfico de x\' en función de x";
            this.btn_punto_d.UseVisualStyleBackColor = true;
            // 
            // btn_punto_e
            // 
            this.btn_punto_e.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punto_e.Location = new System.Drawing.Point(828, 34);
            this.btn_punto_e.Name = "btn_punto_e";
            this.btn_punto_e.Size = new System.Drawing.Size(202, 87);
            this.btn_punto_e.TabIndex = 15;
            this.btn_punto_e.Text = "Gráfico de x\" en función de  x\'";
            this.btn_punto_e.UseVisualStyleBackColor = true;
            // 
            // btn_euler
            // 
            this.btn_euler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_euler.Location = new System.Drawing.Point(150, 22);
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
            this.btn_rk.Location = new System.Drawing.Point(649, 22);
            this.btn_rk.Name = "btn_rk";
            this.btn_rk.Size = new System.Drawing.Size(292, 52);
            this.btn_rk.TabIndex = 17;
            this.btn_rk.Text = "Calcular por Método RK4";
            this.btn_rk.UseVisualStyleBackColor = true;
            // 
            // pnl_botones
            // 
            this.pnl_botones.Controls.Add(this.btn_euler);
            this.pnl_botones.Controls.Add(this.btn_rk);
            this.pnl_botones.Location = new System.Drawing.Point(48, 34);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(1074, 95);
            this.pnl_botones.TabIndex = 18;
            // 
            // pnl_euler
            // 
            this.pnl_euler.Controls.Add(this.dataGridView1);
            this.pnl_euler.Location = new System.Drawing.Point(48, 135);
            this.pnl_euler.Name = "pnl_euler";
            this.pnl_euler.Size = new System.Drawing.Size(533, 338);
            this.pnl_euler.TabIndex = 19;
            // 
            // pnl_rk
            // 
            this.pnl_rk.Controls.Add(this.dataGridView2);
            this.pnl_rk.Location = new System.Drawing.Point(587, 135);
            this.pnl_rk.Name = "pnl_rk";
            this.pnl_rk.Size = new System.Drawing.Size(535, 338);
            this.pnl_rk.TabIndex = 20;
            // 
            // pnl_graficos
            // 
            this.pnl_graficos.Controls.Add(this.btn_punto_b);
            this.pnl_graficos.Controls.Add(this.btn_punto_c);
            this.pnl_graficos.Controls.Add(this.btn_punto_d);
            this.pnl_graficos.Controls.Add(this.btn_punto_e);
            this.pnl_graficos.Location = new System.Drawing.Point(48, 479);
            this.pnl_graficos.Name = "pnl_graficos";
            this.pnl_graficos.Size = new System.Drawing.Size(1061, 153);
            this.pnl_graficos.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(526, 265);
            this.dataGridView2.TabIndex = 1;
            // 
            // Frm_TP6_PantallaPuntoAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 771);
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).EndInit();
            this.pnl_botones.ResumeLayout(false);
            this.pnl_euler.ResumeLayout(false);
            this.pnl_rk.ResumeLayout(false);
            this.pnl_graficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Config;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_config;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_punto_b;
        private System.Windows.Forms.Button btn_punto_c;
        private System.Windows.Forms.Button btn_punto_d;
        private System.Windows.Forms.Button btn_punto_e;
        private System.Windows.Forms.Button btn_euler;
        private System.Windows.Forms.Button btn_rk;
        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.Panel pnl_euler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnl_rk;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel pnl_graficos;
    }
}