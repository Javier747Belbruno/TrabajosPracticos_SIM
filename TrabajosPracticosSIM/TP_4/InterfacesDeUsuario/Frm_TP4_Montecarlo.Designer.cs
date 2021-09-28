
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_simular
            // 
            this.btn_simular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simular.Location = new System.Drawing.Point(22, 292);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(176, 105);
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
            this.btn_config.Location = new System.Drawing.Point(252, 111);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(63, 52);
            this.btn_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_config.TabIndex = 1;
            this.btn_config.TabStop = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configurar Actividades";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Frm_TP4_Montecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 591);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_simular);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_TP4_Montecarlo";
            this.Text = "Frm_TP4_Montecarlo";
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.PictureBox btn_config;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}