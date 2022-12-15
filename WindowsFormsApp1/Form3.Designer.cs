
namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.load = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelCasal = new System.Windows.Forms.Label();
            this.labelSolteiro = new System.Windows.Forms.Label();
            this.labelTriplo = new System.Windows.Forms.Label();
            this.labelQuadruplo = new System.Windows.Forms.Label();
            this.labelQuintuplo = new System.Windows.Forms.Label();
            this.label03A06Anos = new System.Windows.Forms.Label();
            this.label07A10Anos = new System.Windows.Forms.Label();
            this.txtCasal = new System.Windows.Forms.TextBox();
            this.txtSolteiro = new System.Windows.Forms.TextBox();
            this.txtTriplo = new System.Windows.Forms.TextBox();
            this.txtQuadruplo = new System.Windows.Forms.TextBox();
            this.txtQuintuplo = new System.Windows.Forms.TextBox();
            this.txt03A06Anos = new System.Windows.Forms.TextBox();
            this.txt07A10Anos = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.dateTimePickerInserir = new System.Windows.Forms.DateTimePicker();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(265, 71);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 0;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(30, 45);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 1;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(381, 45);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(328, 123);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(857, 390);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // labelCasal
            // 
            this.labelCasal.AutoSize = true;
            this.labelCasal.Location = new System.Drawing.Point(34, 80);
            this.labelCasal.Name = "labelCasal";
            this.labelCasal.Size = new System.Drawing.Size(32, 13);
            this.labelCasal.TabIndex = 4;
            this.labelCasal.Text = "casal";
            // 
            // labelSolteiro
            // 
            this.labelSolteiro.AutoSize = true;
            this.labelSolteiro.Location = new System.Drawing.Point(34, 108);
            this.labelSolteiro.Name = "labelSolteiro";
            this.labelSolteiro.Size = new System.Drawing.Size(42, 13);
            this.labelSolteiro.TabIndex = 5;
            this.labelSolteiro.Text = "Solteiro";
            // 
            // labelTriplo
            // 
            this.labelTriplo.AutoSize = true;
            this.labelTriplo.Location = new System.Drawing.Point(34, 141);
            this.labelTriplo.Name = "labelTriplo";
            this.labelTriplo.Size = new System.Drawing.Size(33, 13);
            this.labelTriplo.TabIndex = 6;
            this.labelTriplo.Text = "Triplo";
            // 
            // labelQuadruplo
            // 
            this.labelQuadruplo.AutoSize = true;
            this.labelQuadruplo.Location = new System.Drawing.Point(34, 175);
            this.labelQuadruplo.Name = "labelQuadruplo";
            this.labelQuadruplo.Size = new System.Drawing.Size(56, 13);
            this.labelQuadruplo.TabIndex = 7;
            this.labelQuadruplo.Text = "Quadruplo";
            // 
            // labelQuintuplo
            // 
            this.labelQuintuplo.AutoSize = true;
            this.labelQuintuplo.Location = new System.Drawing.Point(34, 203);
            this.labelQuintuplo.Name = "labelQuintuplo";
            this.labelQuintuplo.Size = new System.Drawing.Size(52, 13);
            this.labelQuintuplo.TabIndex = 8;
            this.labelQuintuplo.Text = "Quintuplo";
            // 
            // label03A06Anos
            // 
            this.label03A06Anos.AutoSize = true;
            this.label03A06Anos.Location = new System.Drawing.Point(34, 232);
            this.label03A06Anos.Name = "label03A06Anos";
            this.label03A06Anos.Size = new System.Drawing.Size(62, 13);
            this.label03A06Anos.TabIndex = 9;
            this.label03A06Anos.Text = "03A06Anos";
            // 
            // label07A10Anos
            // 
            this.label07A10Anos.AutoSize = true;
            this.label07A10Anos.Location = new System.Drawing.Point(34, 260);
            this.label07A10Anos.Name = "label07A10Anos";
            this.label07A10Anos.Size = new System.Drawing.Size(62, 13);
            this.label07A10Anos.TabIndex = 10;
            this.label07A10Anos.Text = "07A10Anos";
            // 
            // txtCasal
            // 
            this.txtCasal.Location = new System.Drawing.Point(155, 79);
            this.txtCasal.Name = "txtCasal";
            this.txtCasal.Size = new System.Drawing.Size(100, 20);
            this.txtCasal.TabIndex = 11;
            // 
            // txtSolteiro
            // 
            this.txtSolteiro.Location = new System.Drawing.Point(155, 107);
            this.txtSolteiro.Name = "txtSolteiro";
            this.txtSolteiro.Size = new System.Drawing.Size(100, 20);
            this.txtSolteiro.TabIndex = 12;
            // 
            // txtTriplo
            // 
            this.txtTriplo.Location = new System.Drawing.Point(155, 138);
            this.txtTriplo.Name = "txtTriplo";
            this.txtTriplo.Size = new System.Drawing.Size(100, 20);
            this.txtTriplo.TabIndex = 13;
            // 
            // txtQuadruplo
            // 
            this.txtQuadruplo.Location = new System.Drawing.Point(155, 170);
            this.txtQuadruplo.Name = "txtQuadruplo";
            this.txtQuadruplo.Size = new System.Drawing.Size(100, 20);
            this.txtQuadruplo.TabIndex = 14;
            // 
            // txtQuintuplo
            // 
            this.txtQuintuplo.Location = new System.Drawing.Point(155, 201);
            this.txtQuintuplo.Name = "txtQuintuplo";
            this.txtQuintuplo.Size = new System.Drawing.Size(100, 20);
            this.txtQuintuplo.TabIndex = 15;
            // 
            // txt03A06Anos
            // 
            this.txt03A06Anos.Location = new System.Drawing.Point(155, 232);
            this.txt03A06Anos.Name = "txt03A06Anos";
            this.txt03A06Anos.Size = new System.Drawing.Size(100, 20);
            this.txt03A06Anos.TabIndex = 16;
            // 
            // txt07A10Anos
            // 
            this.txt07A10Anos.Location = new System.Drawing.Point(155, 260);
            this.txt07A10Anos.Name = "txt07A10Anos";
            this.txt07A10Anos.Size = new System.Drawing.Size(100, 20);
            this.txt07A10Anos.TabIndex = 17;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(102, 298);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 18;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(127, 16);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 19;
            this.labelData.Text = "Data";
            // 
            // dateTimePickerInserir
            // 
            this.dateTimePickerInserir.Location = new System.Drawing.Point(37, 38);
            this.dateTimePickerInserir.Name = "dateTimePickerInserir";
            this.dateTimePickerInserir.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerInserir.TabIndex = 21;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(21, 298);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 22;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(183, 298);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletar.TabIndex = 23;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 186);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(289, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "até";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerInserir);
            this.groupBox1.Controls.Add(this.labelData);
            this.groupBox1.Controls.Add(this.txtCasal);
            this.groupBox1.Controls.Add(this.buttonDeletar);
            this.groupBox1.Controls.Add(this.txtSolteiro);
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.buttonInserir);
            this.groupBox1.Controls.Add(this.txtTriplo);
            this.groupBox1.Controls.Add(this.txtQuadruplo);
            this.groupBox1.Controls.Add(this.label07A10Anos);
            this.groupBox1.Controls.Add(this.txt07A10Anos);
            this.groupBox1.Controls.Add(this.label03A06Anos);
            this.groupBox1.Controls.Add(this.txtQuintuplo);
            this.groupBox1.Controls.Add(this.labelQuintuplo);
            this.groupBox1.Controls.Add(this.txt03A06Anos);
            this.groupBox1.Controls.Add(this.labelQuadruplo);
            this.groupBox1.Controls.Add(this.labelCasal);
            this.groupBox1.Controls.Add(this.labelTriplo);
            this.groupBox1.Controls.Add(this.labelSolteiro);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 327);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizar alterações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Controls.Add(this.load);
            this.groupBox2.Location = new System.Drawing.Point(431, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 100);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carregar para tabela";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Text = "Pousada Betania Gramado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelCasal;
        private System.Windows.Forms.Label labelSolteiro;
        private System.Windows.Forms.Label labelTriplo;
        private System.Windows.Forms.Label labelQuadruplo;
        private System.Windows.Forms.Label labelQuintuplo;
        private System.Windows.Forms.Label label03A06Anos;
        private System.Windows.Forms.Label label07A10Anos;
        private System.Windows.Forms.TextBox txtCasal;
        private System.Windows.Forms.TextBox txtSolteiro;
        private System.Windows.Forms.TextBox txtTriplo;
        private System.Windows.Forms.TextBox txtQuadruplo;
        private System.Windows.Forms.TextBox txtQuintuplo;
        private System.Windows.Forms.TextBox txt03A06Anos;
        private System.Windows.Forms.TextBox txt07A10Anos;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelData;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.DateTimePicker dateTimePickerInserir;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}