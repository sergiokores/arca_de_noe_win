namespace Arca_de_Noe
{
    partial class Ativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ativa));
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblcontrato = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtToken
            // 
            this.txtToken.Enabled = false;
            this.txtToken.HideSelection = false;
            this.txtToken.Location = new System.Drawing.Point(6, 19);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(582, 20);
            this.txtToken.TabIndex = 0;
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(531, 414);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(75, 23);
            this.btnAtivar.TabIndex = 2;
            this.btnAtivar.Text = "Cancelar";
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 54);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(594, 243);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(547, 303);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Aceitar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero de Série:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.ForeColor = System.Drawing.Color.Blue;
            this.lblSerie.Location = new System.Drawing.Point(106, 42);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(49, 20);
            this.lblSerie.TabIndex = 6;
            this.lblSerie.Text = "0000";
            // 
            // lblcontrato
            // 
            this.lblcontrato.AutoSize = true;
            this.lblcontrato.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontrato.ForeColor = System.Drawing.Color.Red;
            this.lblcontrato.Location = new System.Drawing.Point(8, 28);
            this.lblcontrato.Name = "lblcontrato";
            this.lblcontrato.Size = new System.Drawing.Size(159, 23);
            this.lblcontrato.TabIndex = 7;
            this.lblcontrato.Text = "Leia Este Contrato:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtToken);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSerie);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 72);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chave de Uso";
            // 
            // Ativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblcontrato);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnAtivar);
            this.Name = "Ativa";
            this.Text = "Ativa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblcontrato;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}