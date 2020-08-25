namespace DadoDiceRoll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Dados = new System.Windows.Forms.TabPage();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.gpDados = new System.Windows.Forms.GroupBox();
            this.rdD10 = new System.Windows.Forms.RadioButton();
            this.rdD20 = new System.Windows.Forms.RadioButton();
            this.rdD6 = new System.Windows.Forms.RadioButton();
            this.btnRoll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listRolagem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Dados.SuspendLayout();
            this.gpDados.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Dados);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(389, 351);
            this.tabControl1.TabIndex = 0;
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.txtRoll);
            this.Dados.Controls.Add(this.gpDados);
            this.Dados.Controls.Add(this.btnRoll);
            this.Dados.Controls.Add(this.label2);
            this.Dados.Controls.Add(this.listRolagem);
            this.Dados.Controls.Add(this.label1);
            this.Dados.Location = new System.Drawing.Point(4, 22);
            this.Dados.Name = "Dados";
            this.Dados.Padding = new System.Windows.Forms.Padding(3);
            this.Dados.Size = new System.Drawing.Size(381, 325);
            this.Dados.TabIndex = 0;
            this.Dados.Text = "Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // txtRoll
            // 
            this.txtRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoll.ForeColor = System.Drawing.Color.Black;
            this.txtRoll.Location = new System.Drawing.Point(258, 21);
            this.txtRoll.Multiline = true;
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(115, 100);
            this.txtRoll.TabIndex = 11;
            this.txtRoll.Text = "....";
            // 
            // gpDados
            // 
            this.gpDados.Controls.Add(this.rdD10);
            this.gpDados.Controls.Add(this.rdD20);
            this.gpDados.Controls.Add(this.rdD6);
            this.gpDados.Location = new System.Drawing.Point(0, 36);
            this.gpDados.Name = "gpDados";
            this.gpDados.Size = new System.Drawing.Size(221, 121);
            this.gpDados.TabIndex = 10;
            this.gpDados.TabStop = false;
            this.gpDados.Text = "Tipos de Dados";
            // 
            // rdD10
            // 
            this.rdD10.AutoSize = true;
            this.rdD10.Location = new System.Drawing.Point(7, 43);
            this.rdD10.Name = "rdD10";
            this.rdD10.Size = new System.Drawing.Size(45, 17);
            this.rdD10.TabIndex = 2;
            this.rdD10.Text = "D10";
            this.rdD10.UseVisualStyleBackColor = true;
            // 
            // rdD20
            // 
            this.rdD20.AutoSize = true;
            this.rdD20.Location = new System.Drawing.Point(7, 66);
            this.rdD20.Name = "rdD20";
            this.rdD20.Size = new System.Drawing.Size(45, 17);
            this.rdD20.TabIndex = 1;
            this.rdD20.Text = "D20";
            this.rdD20.UseVisualStyleBackColor = true;
            // 
            // rdD6
            // 
            this.rdD6.AutoSize = true;
            this.rdD6.Checked = true;
            this.rdD6.Location = new System.Drawing.Point(7, 20);
            this.rdD6.Name = "rdD6";
            this.rdD6.Size = new System.Drawing.Size(39, 17);
            this.rdD6.TabIndex = 0;
            this.rdD6.TabStop = true;
            this.rdD6.Text = "D6";
            this.rdD6.UseVisualStyleBackColor = true;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(258, 127);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(115, 48);
            this.btnRoll.TabIndex = 9;
            this.btnRoll.Text = "ROLL!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista de Rolagens:";
            // 
            // listRolagem
            // 
            this.listRolagem.FormattingEnabled = true;
            this.listRolagem.Location = new System.Drawing.Point(-2, 181);
            this.listRolagem.Name = "listRolagem";
            this.listRolagem.Size = new System.Drawing.Size(375, 134);
            this.listRolagem.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha o dado:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(381, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sobre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 312);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Perfil GitHub";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 356);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DadoDiceRoll!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Dados.ResumeLayout(false);
            this.Dados.PerformLayout();
            this.gpDados.ResumeLayout(false);
            this.gpDados.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Dados;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.GroupBox gpDados;
        private System.Windows.Forms.RadioButton rdD10;
        private System.Windows.Forms.RadioButton rdD20;
        private System.Windows.Forms.RadioButton rdD6;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listRolagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

