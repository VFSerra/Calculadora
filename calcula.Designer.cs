namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblresul = new System.Windows.Forms.Label();
            this.txtresul = new System.Windows.Forms.TextBox();
            this.btnsubtracao = new System.Windows.Forms.Button();
            this.btndivisao = new System.Windows.Forms.Button();
            this.btncls = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(45, 38);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(89, 13);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Digite um numero";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(170, 38);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 1;
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(45, 74);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(89, 13);
            this.lblnum2.TabIndex = 2;
            this.lblnum2.Text = "Digite um número";
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(170, 74);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(101, 339);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(101, 67);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "soma";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblresul
            // 
            this.lblresul.AutoSize = true;
            this.lblresul.Location = new System.Drawing.Point(45, 112);
            this.lblresul.Name = "lblresul";
            this.lblresul.Size = new System.Drawing.Size(55, 13);
            this.lblresul.TabIndex = 5;
            this.lblresul.Text = "Resultado";
            // 
            // txtresul
            // 
            this.txtresul.Location = new System.Drawing.Point(170, 112);
            this.txtresul.Name = "txtresul";
            this.txtresul.Size = new System.Drawing.Size(100, 20);
            this.txtresul.TabIndex = 6;
            // 
            // btnsubtracao
            // 
            this.btnsubtracao.Location = new System.Drawing.Point(259, 335);
            this.btnsubtracao.Name = "btnsubtracao";
            this.btnsubtracao.Size = new System.Drawing.Size(97, 67);
            this.btnsubtracao.TabIndex = 7;
            this.btnsubtracao.Text = "subtração";
            this.btnsubtracao.UseVisualStyleBackColor = true;
            this.btnsubtracao.Click += new System.EventHandler(this.btnsubtracao_Click);
            // 
            // btndivisao
            // 
            this.btndivisao.Location = new System.Drawing.Point(415, 335);
            this.btndivisao.Name = "btndivisao";
            this.btndivisao.Size = new System.Drawing.Size(91, 67);
            this.btndivisao.TabIndex = 8;
            this.btndivisao.Text = "divisao";
            this.btndivisao.UseVisualStyleBackColor = true;
            this.btndivisao.Click += new System.EventHandler(this.btndivisao_Click);
            // 
            // btncls
            // 
            this.btncls.Location = new System.Drawing.Point(24, 185);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(75, 23);
            this.btncls.TabIndex = 9;
            this.btncls.Text = "limpar";
            this.btncls.UseVisualStyleBackColor = true;
            // 
            // btnraiz
            // 
            this.btnraiz.Location = new System.Drawing.Point(550, 339);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(115, 63);
            this.btnraiz.TabIndex = 10;
            this.btnraiz.Text = "Raiz";
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.btnraiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btncls);
            this.Controls.Add(this.btndivisao);
            this.Controls.Add(this.btnsubtracao);
            this.Controls.Add(this.txtresul);
            this.Controls.Add(this.lblresul);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblresul;
        private System.Windows.Forms.TextBox txtresul;
        private System.Windows.Forms.Button btnsubtracao;
        private System.Windows.Forms.Button btndivisao;
        private System.Windows.Forms.Button btncls;
        private System.Windows.Forms.Button btnraiz;
    }
}

