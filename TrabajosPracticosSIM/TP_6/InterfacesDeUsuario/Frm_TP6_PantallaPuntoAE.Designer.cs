
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
            this.pnl_Config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Config
            // 
            this.pnl_Config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Config.Controls.Add(this.label2);
            this.pnl_Config.Controls.Add(this.btn_config);
            this.pnl_Config.Controls.Add(this.label1);
            this.pnl_Config.Location = new System.Drawing.Point(21, 552);
            this.pnl_Config.Name = "pnl_Config";
            this.pnl_Config.Size = new System.Drawing.Size(334, 134);
            this.pnl_Config.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 73);
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
            this.btn_config.Location = new System.Drawing.Point(178, 22);
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
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configurar";
            // 
            // Frm_TP6_PantallaPuntoAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 729);
            this.Controls.Add(this.pnl_Config);
            this.Name = "Frm_TP6_PantallaPuntoAE";
            this.Text = "Frm_TP6_PantallaPuntoAE";
            this.pnl_Config.ResumeLayout(false);
            this.pnl_Config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Config;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_config;
        private System.Windows.Forms.Label label1;
    }
}