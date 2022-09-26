
namespace Vendas
{
    partial class FormVenda
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.qntProdutoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.btnBuscarQuantidade = new System.Windows.Forms.Button();
            this.gridVendas = new System.Windows.Forms.DataGridView();
            this.Codigodoproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelproduto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.valorProdutoLab = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.totalCompralb = new System.Windows.Forms.Label();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCupom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(37, 146);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(196, 35);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(37, 249);
            this.txtProduto.Multiline = true;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(196, 35);
            this.txtProduto.TabIndex = 1;
            // 
            // qntProdutoTxt
            // 
            this.qntProdutoTxt.Location = new System.Drawing.Point(37, 403);
            this.qntProdutoTxt.Multiline = true;
            this.qntProdutoTxt.Name = "qntProdutoTxt";
            this.qntProdutoTxt.Size = new System.Drawing.Size(71, 35);
            this.qntProdutoTxt.TabIndex = 2;
            this.qntProdutoTxt.TextChanged += new System.EventHandler(this.qntProdutoTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produto ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Venda";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(253, 153);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(90, 23);
            this.btnBuscarCliente.TabIndex = 12;
            this.btnBuscarCliente.Text = "buscarCliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Location = new System.Drawing.Point(253, 256);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(90, 23);
            this.btnBuscarProduto.TabIndex = 13;
            this.btnBuscarProduto.Text = "buscarProduto";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // btnBuscarQuantidade
            // 
            this.btnBuscarQuantidade.Location = new System.Drawing.Point(125, 408);
            this.btnBuscarQuantidade.Name = "btnBuscarQuantidade";
            this.btnBuscarQuantidade.Size = new System.Drawing.Size(108, 23);
            this.btnBuscarQuantidade.TabIndex = 14;
            this.btnBuscarQuantidade.Text = "Buscar Quantidade";
            this.btnBuscarQuantidade.UseVisualStyleBackColor = true;
            this.btnBuscarQuantidade.Click += new System.EventHandler(this.btnBuscarQuantidade_Click);
            // 
            // gridVendas
            // 
            this.gridVendas.AllowUserToDeleteRows = false;
            this.gridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigodoproduto,
            this.NomeProduto,
            this.ValorProduto,
            this.ValorTotal,
            this.QuantidadeProduto});
            this.gridVendas.Location = new System.Drawing.Point(543, 146);
            this.gridVendas.Name = "gridVendas";
            this.gridVendas.Size = new System.Drawing.Size(306, 366);
            this.gridVendas.TabIndex = 15;
            this.gridVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVendas_CellContentClick);
            // 
            // Codigodoproduto
            // 
            this.Codigodoproduto.HeaderText = "Codigo do produto";
            this.Codigodoproduto.Name = "Codigodoproduto";
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome do produto";
            this.NomeProduto.Name = "NomeProduto";
            // 
            // ValorProduto
            // 
            this.ValorProduto.HeaderText = "Valor do produto";
            this.ValorProduto.Name = "ValorProduto";
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            // 
            // QuantidadeProduto
            // 
            this.QuantidadeProduto.HeaderText = "Quantidade";
            this.QuantidadeProduto.Name = "QuantidadeProduto";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(34, 184);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(99, 16);
            this.labelCliente.TabIndex = 16;
            this.labelCliente.Text = "Nome cliente";
            this.labelCliente.Click += new System.EventHandler(this.labelCliente_Click);
            // 
            // labelproduto
            // 
            this.labelproduto.AutoSize = true;
            this.labelproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproduto.Location = new System.Drawing.Point(34, 296);
            this.labelproduto.Name = "labelproduto";
            this.labelproduto.Size = new System.Drawing.Size(106, 16);
            this.labelproduto.TabIndex = 17;
            this.labelproduto.Text = "Nome produto";
            this.labelproduto.Click += new System.EventHandler(this.labelproduto_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // valorProdutoLab
            // 
            this.valorProdutoLab.AutoSize = true;
            this.valorProdutoLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorProdutoLab.Location = new System.Drawing.Point(34, 324);
            this.valorProdutoLab.Name = "valorProdutoLab";
            this.valorProdutoLab.Size = new System.Drawing.Size(102, 16);
            this.valorProdutoLab.TabIndex = 19;
            this.valorProdutoLab.Text = "Valor produto";
            this.valorProdutoLab.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(34, 441);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(89, 16);
            this.lbTotal.TabIndex = 20;
            this.lbTotal.Text = "Valor Total:";
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(37, 520);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(138, 49);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // totalCompralb
            // 
            this.totalCompralb.AutoSize = true;
            this.totalCompralb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCompralb.Location = new System.Drawing.Point(540, 110);
            this.totalCompralb.Name = "totalCompralb";
            this.totalCompralb.Size = new System.Drawing.Size(161, 16);
            this.totalCompralb.TabIndex = 22;
            this.totalCompralb.Text = "Valor total da compra:";
            this.totalCompralb.Click += new System.EventHandler(this.totalCompralb_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(747, 533);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(102, 23);
            this.btnRemoverProduto.TabIndex = 23;
            this.btnRemoverProduto.Text = "Remover produto";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Enviar para banco de dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCupom
            // 
            this.labelCupom.AutoSize = true;
            this.labelCupom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCupom.Location = new System.Drawing.Point(679, 575);
            this.labelCupom.Name = "labelCupom";
            this.labelCupom.Size = new System.Drawing.Size(56, 16);
            this.labelCupom.TabIndex = 25;
            this.labelCupom.Text = "Cupom";
            this.labelCupom.Click += new System.EventHandler(this.labelCupom_Click);
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 609);
            this.Controls.Add(this.labelCupom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.totalCompralb);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.valorProdutoLab);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelproduto);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.gridVendas);
            this.Controls.Add(this.btnBuscarQuantidade);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qntProdutoTxt);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtCliente);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox qntProdutoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Button btnBuscarQuantidade;
        private System.Windows.Forms.DataGridView gridVendas;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelproduto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label valorProdutoLab;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigodoproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label totalCompralb;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeProduto;
        private System.Windows.Forms.Label labelCupom;
    }
}