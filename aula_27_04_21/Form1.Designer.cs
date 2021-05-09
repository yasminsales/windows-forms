
namespace aula_27_04_21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.text_cnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_rua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_salvar = new System.Windows.Forms.Button();
            this.text_codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_cep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ";
            // 
            // text_cnpj
            // 
            this.text_cnpj.Location = new System.Drawing.Point(126, 168);
            this.text_cnpj.Name = "text_cnpj";
            this.text_cnpj.Size = new System.Drawing.Size(150, 31);
            this.text_cnpj.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(127, 217);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(150, 31);
            this.text_nome.TabIndex = 3;
            // 
            // text_rua
            // 
            this.text_rua.Location = new System.Drawing.Point(126, 265);
            this.text_rua.Name = "text_rua";
            this.text_rua.Size = new System.Drawing.Size(150, 31);
            this.text_rua.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rua";
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(354, 110);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(112, 34);
            this.button_salvar.TabIndex = 6;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.Button_salvar_Click);
            // 
            // text_codigo
            // 
            this.text_codigo.Location = new System.Drawing.Point(127, 112);
            this.text_codigo.Name = "text_codigo";
            this.text_codigo.Size = new System.Drawing.Size(150, 31);
            this.text_codigo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo";
            // 
            // text_cep
            // 
            this.text_cep.Location = new System.Drawing.Point(126, 319);
            this.text_cep.Name = "text_cep";
            this.text_cep.Size = new System.Drawing.Size(150, 31);
            this.text_cep.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "CEP";
            // 
            // button_atualizar
            // 
            this.button_atualizar.Location = new System.Drawing.Point(354, 180);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(112, 34);
            this.button_atualizar.TabIndex = 7;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.Button_atualizar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(354, 244);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(112, 34);
            this.button_deletar.TabIndex = 8;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(584, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(360, 225);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.text_cep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.text_rua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_cnpj);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_cnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_rua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.TextBox text_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_cep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

