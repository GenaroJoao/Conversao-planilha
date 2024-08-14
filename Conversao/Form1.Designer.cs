namespace Conversao
{
    partial class Conversao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.progressConvert = new System.Windows.Forms.ProgressBar();
            this.bconveter = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blocaliza = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path ";
            // 
            // progressConvert
            // 
            this.progressConvert.Location = new System.Drawing.Point(37, 170);
            this.progressConvert.Name = "progressConvert";
            this.progressConvert.Size = new System.Drawing.Size(708, 19);
            this.progressConvert.TabIndex = 1;
            // 
            // bconveter
            // 
            this.bconveter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bconveter.Location = new System.Drawing.Point(352, 211);
            this.bconveter.Name = "bconveter";
            this.bconveter.Size = new System.Drawing.Size(102, 45);
            this.bconveter.TabIndex = 2;
            this.bconveter.Text = "Conveter";
            this.bconveter.UseVisualStyleBackColor = true;
            this.bconveter.Click += new System.EventHandler(this.bconveter_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(87, 89);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(610, 20);
            this.tb_path.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Processando: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 5;
            // 
            // blocaliza
            // 
            this.blocaliza.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.blocaliza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocaliza.Location = new System.Drawing.Point(703, 89);
            this.blocaliza.Name = "blocaliza";
            this.blocaliza.Size = new System.Drawing.Size(42, 21);
            this.blocaliza.TabIndex = 6;
            this.blocaliza.Text = "...";
            this.blocaliza.UseVisualStyleBackColor = true;
            this.blocaliza.Click += new System.EventHandler(this.blocaliza_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Conversao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 296);
            this.Controls.Add(this.blocaliza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.bconveter);
            this.Controls.Add(this.progressConvert);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Conversao";
            this.Text = "Conversao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressConvert;
        private System.Windows.Forms.Button bconveter;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button blocaliza;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

