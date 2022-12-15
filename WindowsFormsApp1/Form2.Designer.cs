
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.buttonEntrarSenha = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEntrarSenha
            // 
            this.buttonEntrarSenha.Location = new System.Drawing.Point(61, 90);
            this.buttonEntrarSenha.Name = "buttonEntrarSenha";
            this.buttonEntrarSenha.Size = new System.Drawing.Size(75, 23);
            this.buttonEntrarSenha.TabIndex = 0;
            this.buttonEntrarSenha.Text = "Entrar";
            this.buttonEntrarSenha.UseVisualStyleBackColor = true;
            this.buttonEntrarSenha.Click += new System.EventHandler(this.buttonEntrarSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(41, 64);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(109, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(75, 48);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 162);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.buttonEntrarSenha);
            this.Name = "Form2";
            this.Text = "Pousada Betania Gramado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrarSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label labelSenha;
    }
}