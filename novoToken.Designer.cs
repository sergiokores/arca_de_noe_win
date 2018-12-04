
namespace Arca_de_Noe
{
    partial class novoToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(novoToken));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonAceito = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de série";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.ForeColor = System.Drawing.Color.Blue;
            this.lblSerie.Location = new System.Drawing.Point(15, 26);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(51, 25);
            this.lblSerie.TabIndex = 1;
            this.lblSerie.Text = "000";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(15, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(605, 180);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TERMOS DE USO DESTA CHAVE";
            // 
            // btnSim
            // 
            this.btnSim.Enabled = false;
            this.btnSim.Location = new System.Drawing.Point(545, 52);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(75, 23);
            this.btnSim.TabIndex = 4;
            this.btnSim.Text = "Ativar";
            this.btnSim.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(457, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Digite a Chave de Uso Fornecida a Você";
            // 
            // radioButtonAceito
            // 
            this.radioButtonAceito.AutoSize = true;
            this.radioButtonAceito.Location = new System.Drawing.Point(534, 269);
            this.radioButtonAceito.Name = "radioButtonAceito";
            this.radioButtonAceito.Size = new System.Drawing.Size(55, 17);
            this.radioButtonAceito.TabIndex = 6;
            this.radioButtonAceito.TabStop = true;
            this.radioButtonAceito.Text = "Aceito";
            this.radioButtonAceito.UseVisualStyleBackColor = true;
            this.radioButtonAceito.CheckedChanged += new System.EventHandler(this.radioButtonAceito_CheckedChanged);
            // 
            // novoToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 302);
            this.Controls.Add(this.radioButtonAceito);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "novoToken";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.novoToken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonAceito;
    }
}