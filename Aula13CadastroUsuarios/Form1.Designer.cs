namespace Aula13CadastroUsuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.txtCidade);
            this.panel1.Controls.Add(this.txtRua);
            this.panel1.Controls.Add(this.txtIdade);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblCidade);
            this.panel1.Controls.Add(this.lblRua);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(37, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 392);
            this.panel1.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(106, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Digite o seu nome:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(16, 88);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(103, 15);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Digite a sua idade:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(16, 168);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(91, 15);
            this.lblRua.TabIndex = 2;
            this.lblRua.Text = "Digite a sua rua:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(16, 249);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(109, 15);
            this.lblCidade.TabIndex = 3;
            this.lblCidade.Text = "Digite a sua cidade:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(16, 106);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(235, 23);
            this.txtIdade.TabIndex = 4;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(16, 186);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(235, 23);
            this.txtRua.TabIndex = 5;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(16, 267);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(235, 23);
            this.txtCidade.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(88, 326);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 36);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(366, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(263, 392);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnSalvar;
        private TextBox txtCidade;
        private TextBox txtRua;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Label lblCidade;
        private Label lblRua;
        private Label lblIdade;
        private Label lblNome;
        private ListView listView1;
    }
}