namespace Arca_de_Noe
{
    partial class Entrada
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lbldata = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.dgvFila = new System.Windows.Forms.DataGridView();
            this.pet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSendoChamado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRecente1 = new System.Windows.Forms.Label();
            this.lblRecente2 = new System.Windows.Forms.Label();
            this.AbrirChamada = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSala_b = new System.Windows.Forms.Label();
            this.lblSala_a = new System.Windows.Forms.Label();
            this.lblCli_b = new System.Windows.Forms.Label();
            this.lblCli_a = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPainelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharPainelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quemSomosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adquirirMais30DiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inf = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFila)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.lbldata);
            this.panel1.Controls.Add(this.txbCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbPet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 27);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(983, 98);
            this.panel1.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdicionar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdicionar.Location = new System.Drawing.Point(762, 48);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(30);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(214, 37);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // lbldata
            // 
            this.lbldata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.Color.Blue;
            this.lbldata.Location = new System.Drawing.Point(877, 11);
            this.lbldata.Margin = new System.Windows.Forms.Padding(0);
            this.lbldata.Name = "lbldata";
            this.lbldata.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lbldata.Size = new System.Drawing.Size(99, 20);
            this.lbldata.TabIndex = 17;
            this.lbldata.Text = "00/00/00";
            // 
            // txbCliente
            // 
            this.txbCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCliente.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.txbCliente.Location = new System.Drawing.Point(387, 48);
            this.txbCliente.Margin = new System.Windows.Forms.Padding(30);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(352, 37);
            this.txbCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(386, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Cliente";
            // 
            // txbPet
            // 
            this.txbPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.txbPet.Location = new System.Drawing.Point(7, 48);
            this.txbPet.Margin = new System.Windows.Forms.Padding(30);
            this.txbPet.Name = "txbPet";
            this.txbPet.Size = new System.Drawing.Size(351, 37);
            this.txbPet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Pet";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnProximo);
            this.panel2.Controls.Add(this.dgvFila);
            this.panel2.Location = new System.Drawing.Point(15, 163);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(405, 477);
            this.panel2.TabIndex = 1;
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProximo.Enabled = false;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnProximo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnProximo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProximo.Location = new System.Drawing.Point(164, 433);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(214, 37);
            this.btnProximo.TabIndex = 5;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Clic);
            // 
            // dgvFila
            // 
            this.dgvFila.AllowUserToAddRows = false;
            this.dgvFila.AllowUserToDeleteRows = false;
            this.dgvFila.AllowUserToResizeColumns = false;
            this.dgvFila.AllowUserToResizeRows = false;
            this.dgvFila.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFila.BackgroundColor = System.Drawing.Color.White;
            this.dgvFila.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pet,
            this.cli});
            this.dgvFila.GridColor = System.Drawing.Color.White;
            this.dgvFila.Location = new System.Drawing.Point(23, 23);
            this.dgvFila.MultiSelect = false;
            this.dgvFila.Name = "dgvFila";
            this.dgvFila.ReadOnly = true;
            this.dgvFila.RowHeadersWidth = 61;
            this.dgvFila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFila.ShowCellToolTips = false;
            this.dgvFila.ShowEditingIcon = false;
            this.dgvFila.ShowRowErrors = false;
            this.dgvFila.Size = new System.Drawing.Size(355, 384);
            this.dgvFila.TabIndex = 0;
            // 
            // pet
            // 
            this.pet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pet.HeaderText = "Nome do Pet";
            this.pet.Name = "pet";
            this.pet.ReadOnly = true;
            // 
            // cli
            // 
            this.cli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli.HeaderText = "Nome do Cliente";
            this.cli.Name = "cli";
            this.cli.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(17, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chamado agora:";
            // 
            // lblSendoChamado
            // 
            this.lblSendoChamado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSendoChamado.AutoSize = true;
            this.lblSendoChamado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSendoChamado.ForeColor = System.Drawing.Color.Blue;
            this.lblSendoChamado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSendoChamado.Location = new System.Drawing.Point(178, 21);
            this.lblSendoChamado.Name = "lblSendoChamado";
            this.lblSendoChamado.Size = new System.Drawing.Size(0, 26);
            this.lblSendoChamado.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(26, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Anterior";
            // 
            // lblRecente1
            // 
            this.lblRecente1.AutoSize = true;
            this.lblRecente1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRecente1.ForeColor = System.Drawing.Color.Red;
            this.lblRecente1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRecente1.Location = new System.Drawing.Point(25, 158);
            this.lblRecente1.Name = "lblRecente1";
            this.lblRecente1.Size = new System.Drawing.Size(0, 23);
            this.lblRecente1.TabIndex = 5;
            // 
            // lblRecente2
            // 
            this.lblRecente2.AutoSize = true;
            this.lblRecente2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRecente2.ForeColor = System.Drawing.Color.Red;
            this.lblRecente2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRecente2.Location = new System.Drawing.Point(25, 196);
            this.lblRecente2.Name = "lblRecente2";
            this.lblRecente2.Size = new System.Drawing.Size(0, 23);
            this.lblRecente2.TabIndex = 6;
            // 
            // AbrirChamada
            // 
            this.AbrirChamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AbrirChamada.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AbrirChamada.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.AbrirChamada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AbrirChamada.Location = new System.Drawing.Point(296, 433);
            this.AbrirChamada.Name = "AbrirChamada";
            this.AbrirChamada.Size = new System.Drawing.Size(214, 37);
            this.AbrirChamada.TabIndex = 8;
            this.AbrirChamada.Text = "Abrir Painel";
            this.AbrirChamada.UseVisualStyleBackColor = true;
            this.AbrirChamada.Click += new System.EventHandler(this.AbrirChamada_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(178, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(322, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sala";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblSala_b);
            this.panel3.Controls.Add(this.lblSala_a);
            this.panel3.Controls.Add(this.lblCli_b);
            this.panel3.Controls.Add(this.lblCli_a);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.AbrirChamada);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblSendoChamado);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblRecente2);
            this.panel3.Controls.Add(this.lblRecente1);
            this.panel3.Location = new System.Drawing.Point(499, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 477);
            this.panel3.TabIndex = 11;
            // 
            // lblSala_b
            // 
            this.lblSala_b.AutoSize = true;
            this.lblSala_b.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSala_b.ForeColor = System.Drawing.Color.Red;
            this.lblSala_b.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSala_b.Location = new System.Drawing.Point(322, 196);
            this.lblSala_b.Name = "lblSala_b";
            this.lblSala_b.Size = new System.Drawing.Size(0, 23);
            this.lblSala_b.TabIndex = 14;
            // 
            // lblSala_a
            // 
            this.lblSala_a.AutoSize = true;
            this.lblSala_a.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSala_a.ForeColor = System.Drawing.Color.Red;
            this.lblSala_a.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSala_a.Location = new System.Drawing.Point(322, 158);
            this.lblSala_a.Name = "lblSala_a";
            this.lblSala_a.Size = new System.Drawing.Size(0, 23);
            this.lblSala_a.TabIndex = 13;
            // 
            // lblCli_b
            // 
            this.lblCli_b.AutoSize = true;
            this.lblCli_b.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCli_b.ForeColor = System.Drawing.Color.Red;
            this.lblCli_b.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCli_b.Location = new System.Drawing.Point(178, 196);
            this.lblCli_b.Name = "lblCli_b";
            this.lblCli_b.Size = new System.Drawing.Size(0, 23);
            this.lblCli_b.TabIndex = 12;
            // 
            // lblCli_a
            // 
            this.lblCli_a.AutoSize = true;
            this.lblCli_a.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCli_a.ForeColor = System.Drawing.Color.Red;
            this.lblCli_a.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCli_a.Location = new System.Drawing.Point(178, 158);
            this.lblCli_a.Name = "lblCli_a";
            this.lblCli_a.Size = new System.Drawing.Size(0, 23);
            this.lblCli_a.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Arca_de_Noe.Properties.Resources.logo;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(21, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 153);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirPainelToolStripMenuItem,
            this.fecharPainelToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // abrirPainelToolStripMenuItem
            // 
            this.abrirPainelToolStripMenuItem.Name = "abrirPainelToolStripMenuItem";
            this.abrirPainelToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.abrirPainelToolStripMenuItem.Text = "Abrir Painel de Chamada";
            this.abrirPainelToolStripMenuItem.Click += new System.EventHandler(this.abrirPainelToolStripMenuItem_Click);
            // 
            // fecharPainelToolStripMenuItem
            // 
            this.fecharPainelToolStripMenuItem.Name = "fecharPainelToolStripMenuItem";
            this.fecharPainelToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.fecharPainelToolStripMenuItem.Text = "Fechar Painel de Chamada";
            this.fecharPainelToolStripMenuItem.Click += new System.EventHandler(this.fecharPainelToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quemSomosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // quemSomosToolStripMenuItem
            // 
            this.quemSomosToolStripMenuItem.Name = "quemSomosToolStripMenuItem";
            this.quemSomosToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.quemSomosToolStripMenuItem.Text = "Quem Somos";
            this.quemSomosToolStripMenuItem.Click += new System.EventHandler(this.quemSomosToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.registroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adquirirMais30DiasToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // adquirirMais30DiasToolStripMenuItem
            // 
            this.adquirirMais30DiasToolStripMenuItem.Name = "adquirirMais30DiasToolStripMenuItem";
            this.adquirirMais30DiasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.adquirirMais30DiasToolStripMenuItem.Text = "Validar Chave de Uso";
            this.adquirirMais30DiasToolStripMenuItem.Click += new System.EventHandler(this.adquirirMais30DiasToolStripMenuItem_Click);
            // 
            // inf
            // 
            this.inf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inf.AutoSize = true;
            this.inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inf.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.inf.Location = new System.Drawing.Point(886, 643);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(130, 20);
            this.inf.TabIndex = 15;
            this.inf.Text = "By CG-Multimidia";
            this.inf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRegistro.Location = new System.Drawing.Point(180, 643);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(18, 20);
            this.lblRegistro.TabIndex = 16;
            this.lblRegistro.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(15, 643);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Número de Registro: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(14, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fila de Espera";
            // 
            // Entrada
            // 
            this.AcceptButton = this.btnAdicionar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1016, 665);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.inf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Entrada";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Fila";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFila)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbPet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.DataGridView dgvFila;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSendoChamado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRecente1;
        private System.Windows.Forms.Label lblRecente2;
        private System.Windows.Forms.Button AbrirChamada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSala_b;
        private System.Windows.Forms.Label lblSala_a;
        private System.Windows.Forms.Label lblCli_b;
        private System.Windows.Forms.Label lblCli_a;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPainelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharPainelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quemSomosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label inf;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adquirirMais30DiasToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli;
        private System.Windows.Forms.Label lbldata;
    }
}

