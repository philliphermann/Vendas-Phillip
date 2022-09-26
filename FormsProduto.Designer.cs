
namespace Vendas
{
    partial class FormsProduto
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
            this.atualizarBNT = new System.Windows.Forms.Button();
            this.procurarProduto = new System.Windows.Forms.Button();
            this.excluirBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.idProdutoBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valorBox = new System.Windows.Forms.TextBox();
            this.descBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.quantBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // atualizarBNT
            // 
            this.atualizarBNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizarBNT.Location = new System.Drawing.Point(135, 292);
            this.atualizarBNT.Margin = new System.Windows.Forms.Padding(4);
            this.atualizarBNT.Name = "atualizarBNT";
            this.atualizarBNT.Size = new System.Drawing.Size(99, 50);
            this.atualizarBNT.TabIndex = 30;
            this.atualizarBNT.Text = "Atualizar Produto";
            this.atualizarBNT.UseVisualStyleBackColor = true;
            this.atualizarBNT.Click += new System.EventHandler(this.atualizarBNT_Click);
            // 
            // procurarProduto
            // 
            this.procurarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procurarProduto.Location = new System.Drawing.Point(460, 90);
            this.procurarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.procurarProduto.Name = "procurarProduto";
            this.procurarProduto.Size = new System.Drawing.Size(99, 40);
            this.procurarProduto.TabIndex = 29;
            this.procurarProduto.Text = "Procurar";
            this.procurarProduto.UseVisualStyleBackColor = true;
            this.procurarProduto.Click += new System.EventHandler(this.procurarProduto_Click);
            // 
            // excluirBtn
            // 
            this.excluirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirBtn.Location = new System.Drawing.Point(26, 292);
            this.excluirBtn.Margin = new System.Windows.Forms.Padding(4);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(99, 50);
            this.excluirBtn.TabIndex = 28;
            this.excluirBtn.Text = "Excluir Produto";
            this.excluirBtn.UseVisualStyleBackColor = true;
            this.excluirBtn.Click += new System.EventHandler(this.excluirBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "ID";
            // 
            // idProdutoBox
            // 
            this.idProdutoBox.Location = new System.Drawing.Point(362, 90);
            this.idProdutoBox.Margin = new System.Windows.Forms.Padding(4);
            this.idProdutoBox.Multiline = true;
            this.idProdutoBox.Name = "idProdutoBox";
            this.idProdutoBox.Size = new System.Drawing.Size(79, 40);
            this.idProdutoBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 36);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cadastro de Produtos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantidade Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Valor Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Descrição Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // valorBox
            // 
            this.valorBox.Location = new System.Drawing.Point(27, 213);
            this.valorBox.Margin = new System.Windows.Forms.Padding(4);
            this.valorBox.Multiline = true;
            this.valorBox.Name = "valorBox";
            this.valorBox.Size = new System.Drawing.Size(99, 40);
            this.valorBox.TabIndex = 18;
            this.valorBox.TextChanged += new System.EventHandler(this.valorBox_TextChanged);
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(26, 90);
            this.descBox.Margin = new System.Windows.Forms.Padding(4);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(319, 78);
            this.descBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(246, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cadastrar Produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantBox
            // 
            this.quantBox.Location = new System.Drawing.Point(246, 213);
            this.quantBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantBox.Multiline = true;
            this.quantBox.Name = "quantBox";
            this.quantBox.Size = new System.Drawing.Size(99, 40);
            this.quantBox.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormsProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 371);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.quantBox);
            this.Controls.Add(this.atualizarBNT);
            this.Controls.Add(this.procurarProduto);
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idProdutoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valorBox);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.button1);
            this.Name = "FormsProduto";
            this.Text = "FormsProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atualizarBNT;
        private System.Windows.Forms.Button procurarProduto;
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idProdutoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valorBox;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox quantBox;
        private System.Windows.Forms.Button button2;
    }
}