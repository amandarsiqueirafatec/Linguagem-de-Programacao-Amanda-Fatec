namespace Aula4
{
    partial class Form1
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
            this.btcalcular = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.lbldist = new System.Windows.Forms.Label();
            this.lbltempo = new System.Windows.Forms.Label();
            this.lblvel = new System.Windows.Forms.Label();
            this.txtdist = new System.Windows.Forms.TextBox();
            this.txttempo = new System.Windows.Forms.TextBox();
            this.txtvel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btcalcular
            // 
            this.btcalcular.BackColor = System.Drawing.Color.CadetBlue;
            this.btcalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcalcular.Location = new System.Drawing.Point(21, 281);
            this.btcalcular.Margin = new System.Windows.Forms.Padding(7);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(348, 138);
            this.btcalcular.TabIndex = 0;
            this.btcalcular.Text = "Calcular";
            this.btcalcular.UseVisualStyleBackColor = false;
            this.btcalcular.Click += new System.EventHandler(this.Button1_Click);
            this.btcalcular.MouseLeave += new System.EventHandler(this.Btcalcular_MouseLeave);
            // 
            // btlimpar
            // 
            this.btlimpar.BackColor = System.Drawing.Color.Violet;
            this.btlimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlimpar.Location = new System.Drawing.Point(452, 281);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(346, 138);
            this.btlimpar.TabIndex = 1;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.Btlimpar_Click_1);
            // 
            // lbldist
            // 
            this.lbldist.AutoSize = true;
            this.lbldist.BackColor = System.Drawing.Color.Transparent;
            this.lbldist.ForeColor = System.Drawing.Color.Magenta;
            this.lbldist.Location = new System.Drawing.Point(103, 92);
            this.lbldist.Name = "lbldist";
            this.lbldist.Size = new System.Drawing.Size(117, 29);
            this.lbldist.TabIndex = 2;
            this.lbldist.Text = "Distância:";
            this.lbldist.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbltempo
            // 
            this.lbltempo.AutoSize = true;
            this.lbltempo.BackColor = System.Drawing.Color.Transparent;
            this.lbltempo.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbltempo.Location = new System.Drawing.Point(103, 174);
            this.lbltempo.Name = "lbltempo";
            this.lbltempo.Size = new System.Drawing.Size(97, 29);
            this.lbltempo.TabIndex = 3;
            this.lbltempo.Text = "Tempo:";
            // 
            // lblvel
            // 
            this.lblvel.AutoSize = true;
            this.lblvel.BackColor = System.Drawing.Color.Transparent;
            this.lblvel.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblvel.Location = new System.Drawing.Point(103, 499);
            this.lblvel.Name = "lblvel";
            this.lblvel.Size = new System.Drawing.Size(141, 29);
            this.lblvel.TabIndex = 4;
            this.lblvel.Text = "Velocidade:";
            // 
            // txtdist
            // 
            this.txtdist.Location = new System.Drawing.Point(254, 92);
            this.txtdist.Name = "txtdist";
            this.txtdist.Size = new System.Drawing.Size(482, 35);
            this.txtdist.TabIndex = 5;
            this.txtdist.Text = "0";
            // 
            // txttempo
            // 
            this.txttempo.Location = new System.Drawing.Point(254, 174);
            this.txttempo.Name = "txttempo";
            this.txttempo.Size = new System.Drawing.Size(482, 35);
            this.txttempo.TabIndex = 6;
            this.txttempo.Text = "0";
            // 
            // txtvel
            // 
            this.txtvel.Location = new System.Drawing.Point(254, 499);
            this.txtvel.Name = "txtvel";
            this.txtvel.Size = new System.Drawing.Size(482, 35);
            this.txtvel.TabIndex = 7;
            this.txtvel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::Aula4.Properties.Resources._9abe86eb104a37f7ba9369170d1b0ef5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 646);
            this.Controls.Add(this.txtvel);
            this.Controls.Add(this.txttempo);
            this.Controls.Add(this.txtdist);
            this.Controls.Add(this.lblvel);
            this.Controls.Add(this.lbltempo);
            this.Controls.Add(this.lbldist);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Label lbldist;
        private System.Windows.Forms.Label lbltempo;
        private System.Windows.Forms.Label lblvel;
        private System.Windows.Forms.TextBox txtdist;
        private System.Windows.Forms.TextBox txttempo;
        private System.Windows.Forms.TextBox txtvel;
    }
}

