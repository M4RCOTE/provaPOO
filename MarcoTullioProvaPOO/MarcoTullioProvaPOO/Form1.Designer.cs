namespace MarcoTullioProvaPOO
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
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.textBoxDif = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.radioOnibus = new System.Windows.Forms.RadioButton();
            this.radioCaminhao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelDif = new System.Windows.Forms.Label();
            this.Placa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Assentos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Eixos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diaria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(89, 178);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(182, 20);
            this.textBoxAno.TabIndex = 1;
            // 
            // textBoxDif
            // 
            this.textBoxDif.Location = new System.Drawing.Point(89, 228);
            this.textBoxDif.Name = "textBoxDif";
            this.textBoxDif.Size = new System.Drawing.Size(182, 20);
            this.textBoxDif.TabIndex = 2;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(73, 295);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(78, 28);
            this.buttonCadastrar.TabIndex = 3;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCadastrar_MouseClick);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(167, 295);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(81, 28);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            this.buttonLimpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLimpar_MouseClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Placa,
            this.Ano,
            this.Assentos,
            this.Eixos,
            this.Diaria});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(52, 399);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(731, 217);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // radioOnibus
            // 
            this.radioOnibus.AutoSize = true;
            this.radioOnibus.Location = new System.Drawing.Point(60, 38);
            this.radioOnibus.Name = "radioOnibus";
            this.radioOnibus.Size = new System.Drawing.Size(58, 17);
            this.radioOnibus.TabIndex = 6;
            this.radioOnibus.TabStop = true;
            this.radioOnibus.Text = "Ônibus";
            this.radioOnibus.UseVisualStyleBackColor = true;
            this.radioOnibus.CheckedChanged += new System.EventHandler(this.radioOnibus_CheckedChanged);
            this.radioOnibus.Click += new System.EventHandler(this.radioOnibus_Click);
            // 
            // radioCaminhao
            // 
            this.radioCaminhao.AutoSize = true;
            this.radioCaminhao.Location = new System.Drawing.Point(167, 38);
            this.radioCaminhao.Name = "radioCaminhao";
            this.radioCaminhao.Size = new System.Drawing.Size(72, 17);
            this.radioCaminhao.TabIndex = 7;
            this.radioCaminhao.TabStop = true;
            this.radioCaminhao.Text = "Caminhão";
            this.radioCaminhao.UseVisualStyleBackColor = true;
            this.radioCaminhao.CheckedChanged += new System.EventHandler(this.radioCaminhao_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Placa";
            this.label1.Click += new System.EventHandler(this.labelPlaca);
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(57, 181);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(26, 13);
            this.labelAno.TabIndex = 10;
            this.labelAno.Text = "Ano";
            // 
            // labelDif
            // 
            this.labelDif.AutoSize = true;
            this.labelDif.Location = new System.Drawing.Point(12, 231);
            this.labelDif.Name = "labelDif";
            this.labelDif.Size = new System.Drawing.Size(36, 13);
            this.labelDif.TabIndex = 11;
            this.labelDif.Text = "adads";
            this.labelDif.Click += new System.EventHandler(this.label3_Click);
            // 
            // Placa
            // 
            this.Placa.Text = "Placa";
            this.Placa.Width = 180;
            // 
            // Ano
            // 
            this.Ano.Text = "Ano";
            this.Ano.Width = 120;
            // 
            // Assentos
            // 
            this.Assentos.Text = "Assentos";
            this.Assentos.Width = 120;
            // 
            // Eixos
            // 
            this.Eixos.Text = "Eixos";
            this.Eixos.Width = 120;
            // 
            // Diaria
            // 
            this.Diaria.Text = "Diaria";
            this.Diaria.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::MarcoTullioProvaPOO.Properties.Resources.caminhao;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(277, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 358);
            this.panel1.TabIndex = 12;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(89, 127);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(182, 20);
            this.textBoxPlaca.TabIndex = 13;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tipo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 649);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDif);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioCaminhao);
            this.Controls.Add(this.radioOnibus);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBoxDif);
            this.Controls.Add(this.textBoxAno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.TextBox textBoxDif;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton radioOnibus;
        private System.Windows.Forms.RadioButton radioCaminhao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelDif;
        private System.Windows.Forms.ColumnHeader Placa;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Assentos;
        private System.Windows.Forms.ColumnHeader Eixos;
        private System.Windows.Forms.ColumnHeader Diaria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox textBoxPlaca;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

