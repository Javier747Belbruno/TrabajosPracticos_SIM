
namespace TrabajosPracticosSIM.TP_5.InterfacesDeUsuario
{
    partial class Frm_TP5_PantallaSimulacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_hasta = new System.Windows.Forms.TextBox();
            this.tb_desde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_cant_sim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Actividades = new System.Windows.Forms.Panel();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_Config = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_config = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSimulacion = new System.Windows.Forms.DataGridView();
            this.btn_simular = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_Actividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.pnl_Config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(17, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 229);
            this.panel1.TabIndex = 12;
            // 
            // tb_hasta
            // 
            this.tb_hasta.Location = new System.Drawing.Point(86, 160);
            this.tb_hasta.Name = "tb_hasta";
            this.tb_hasta.Size = new System.Drawing.Size(145, 26);
            this.tb_hasta.TabIndex = 15;
            this.tb_hasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_desde
            // 
            this.tb_desde.Location = new System.Drawing.Point(86, 116);
            this.tb_desde.Name = "tb_desde";
            this.tb_desde.Size = new System.Drawing.Size(145, 26);
            this.tb_desde.TabIndex = 14;
            this.tb_desde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Desde";
            // 
            // tb_cant_sim
            // 
            this.tb_cant_sim.Location = new System.Drawing.Point(86, 50);
            this.tb_cant_sim.Name = "tb_cant_sim";
            this.tb_cant_sim.Size = new System.Drawing.Size(145, 26);
            this.tb_cant_sim.TabIndex = 11;
            this.tb_cant_sim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "a Simular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese los Parámetros de la Sim.";
            // 
            // pnl_Actividades
            // 
            this.pnl_Actividades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Actividades.Controls.Add(this.dgvActividades);
            this.pnl_Actividades.Controls.Add(this.label8);
            this.pnl_Actividades.Location = new System.Drawing.Point(17, 29);
            this.pnl_Actividades.Name = "pnl_Actividades";
            this.pnl_Actividades.Size = new System.Drawing.Size(257, 228);
            this.pnl_Actividades.TabIndex = 11;
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(3, 39);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.RowHeadersWidth = 51;
            this.dgvActividades.RowTemplate.Height = 24;
            this.dgvActividades.Size = new System.Drawing.Size(249, 179);
            this.dgvActividades.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Actividades";
            // 
            // pnl_Config
            // 
            this.pnl_Config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Config.Controls.Add(this.label2);
            this.pnl_Config.Controls.Add(this.btn_config);
            this.pnl_Config.Controls.Add(this.label1);
            this.pnl_Config.Location = new System.Drawing.Point(17, 649);
            this.pnl_Config.Name = "pnl_Config";
            this.pnl_Config.Size = new System.Drawing.Size(257, 134);
            this.pnl_Config.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Actividades";
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_config.Image = global::TrabajosPracticosSIM.Properties.Resources.ConfigImage2;
            this.btn_config.Location = new System.Drawing.Point(132, 19);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(89, 85);
            this.btn_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_config.TabIndex = 1;
            this.btn_config.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configurar";
            // 
            // dgvSimulacion
            // 
            this.dgvSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulacion.Location = new System.Drawing.Point(280, 29);
            this.dgvSimulacion.Name = "dgvSimulacion";
            this.dgvSimulacion.RowHeadersWidth = 51;
            this.dgvSimulacion.RowTemplate.Height = 24;
            this.dgvSimulacion.Size = new System.Drawing.Size(1101, 521);
            this.dgvSimulacion.TabIndex = 9;
            // 
            // btn_simular
            // 
            this.btn_simular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_simular.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(17, 514);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(257, 116);
            this.btn_simular.TabIndex = 8;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // Frm_TP5_PantallaSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Actividades);
            this.Controls.Add(this.pnl_Config);
            this.Controls.Add(this.dgvSimulacion);
            this.Controls.Add(this.btn_simular);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_TP5_PantallaSimulacion";
            this.Text = "Frm_TP5_PantallaSimulacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Actividades.ResumeLayout(false);
            this.pnl_Actividades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.pnl_Config.ResumeLayout(false);
            this.pnl_Config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_hasta;
        private System.Windows.Forms.TextBox tb_desde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_cant_sim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_Actividades;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnl_Config;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_config;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSimulacion;
        private System.Windows.Forms.Button btn_simular;
    }
}