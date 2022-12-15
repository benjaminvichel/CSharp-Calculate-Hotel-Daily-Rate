
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonCalcularDiarias = new System.Windows.Forms.Button();
            this.IMGpousadaBetania = new System.Windows.Forms.PictureBox();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textValorDiariaCustom = new System.Windows.Forms.TextBox();
            this.diária = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textValorTotalCustom = new System.Windows.Forms.TextBox();
            this.textSolteiroCustom = new System.Windows.Forms.TextBox();
            this.textCrianca07A10 = new System.Windows.Forms.TextBox();
            this.textCrianca03A06 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textValorDiariaCasal = new System.Windows.Forms.TextBox();
            this.textValorDiariaSolteiro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textValorDiariaTriplo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textValorDiariaQuadruplo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textValorDiariaQuintuplo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textValorTotalQuintuplo = new System.Windows.Forms.TextBox();
            this.textValorTotalQuadruplo = new System.Windows.Forms.TextBox();
            this.textValorTotalSolteiro = new System.Windows.Forms.TextBox();
            this.textValorTotalTriplo = new System.Windows.Forms.TextBox();
            this.textValorTotalCasal = new System.Windows.Forms.TextBox();
            this.textNumeroDiarias = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IMGpousadaBetania)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 37);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(322, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(285, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // buttonCalcularDiarias
            // 
            this.buttonCalcularDiarias.Location = new System.Drawing.Point(241, 58);
            this.buttonCalcularDiarias.Name = "buttonCalcularDiarias";
            this.buttonCalcularDiarias.Size = new System.Drawing.Size(130, 37);
            this.buttonCalcularDiarias.TabIndex = 2;
            this.buttonCalcularDiarias.Text = "Calcular Diárias";
            this.buttonCalcularDiarias.UseVisualStyleBackColor = true;
            this.buttonCalcularDiarias.Click += new System.EventHandler(this.buttonCalcularDiarias_Click);
            // 
            // IMGpousadaBetania
            // 
            this.IMGpousadaBetania.BackColor = System.Drawing.Color.Transparent;
            this.IMGpousadaBetania.Image = ((System.Drawing.Image)(resources.GetObject("IMGpousadaBetania.Image")));
            this.IMGpousadaBetania.Location = new System.Drawing.Point(245, 118);
            this.IMGpousadaBetania.Name = "IMGpousadaBetania";
            this.IMGpousadaBetania.Size = new System.Drawing.Size(256, 198);
            this.IMGpousadaBetania.TabIndex = 3;
            this.IMGpousadaBetania.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textValorDiariaCustom);
            this.groupBox1.Controls.Add(this.diária);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textValorTotalCustom);
            this.groupBox1.Controls.Add(this.textSolteiroCustom);
            this.groupBox1.Controls.Add(this.textCrianca07A10);
            this.groupBox1.Controls.Add(this.textCrianca03A06);
            this.groupBox1.Location = new System.Drawing.Point(356, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 146);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quarto Customizado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Quantidade";
            // 
            // textValorDiariaCustom
            // 
            this.textValorDiariaCustom.Location = new System.Drawing.Point(222, 77);
            this.textValorDiariaCustom.Name = "textValorDiariaCustom";
            this.textValorDiariaCustom.Size = new System.Drawing.Size(66, 20);
            this.textValorDiariaCustom.TabIndex = 28;
            // 
            // diária
            // 
            this.diária.AutoSize = true;
            this.diária.Location = new System.Drawing.Point(236, 52);
            this.diária.Name = "diária";
            this.diária.Size = new System.Drawing.Size(34, 13);
            this.diária.TabIndex = 27;
            this.diária.Text = "Diária";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Valor Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Solteiro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Criança 07 a 10 anos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Criança 03 a 06 anos";
            // 
            // textValorTotalCustom
            // 
            this.textValorTotalCustom.Location = new System.Drawing.Point(311, 77);
            this.textValorTotalCustom.Name = "textValorTotalCustom";
            this.textValorTotalCustom.Size = new System.Drawing.Size(66, 20);
            this.textValorTotalCustom.TabIndex = 22;
            // 
            // textSolteiroCustom
            // 
            this.textSolteiroCustom.Location = new System.Drawing.Point(118, 112);
            this.textSolteiroCustom.Name = "textSolteiroCustom";
            this.textSolteiroCustom.Size = new System.Drawing.Size(79, 20);
            this.textSolteiroCustom.TabIndex = 21;
            // 
            // textCrianca07A10
            // 
            this.textCrianca07A10.Location = new System.Drawing.Point(118, 77);
            this.textCrianca07A10.Name = "textCrianca07A10";
            this.textCrianca07A10.Size = new System.Drawing.Size(79, 20);
            this.textCrianca07A10.TabIndex = 20;
            // 
            // textCrianca03A06
            // 
            this.textCrianca03A06.Location = new System.Drawing.Point(118, 45);
            this.textCrianca03A06.Name = "textCrianca03A06";
            this.textCrianca03A06.Size = new System.Drawing.Size(79, 20);
            this.textCrianca03A06.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textValorDiariaCasal);
            this.groupBox2.Controls.Add(this.textValorDiariaSolteiro);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textValorDiariaTriplo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textValorDiariaQuadruplo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textValorDiariaQuintuplo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textValorTotalQuintuplo);
            this.groupBox2.Controls.Add(this.textValorTotalQuadruplo);
            this.groupBox2.Controls.Add(this.textValorTotalSolteiro);
            this.groupBox2.Controls.Add(this.textValorTotalTriplo);
            this.groupBox2.Controls.Add(this.textValorTotalCasal);
            this.groupBox2.Location = new System.Drawing.Point(3, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 177);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(217, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Total";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(127, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Diária";
            // 
            // textValorDiariaCasal
            // 
            this.textValorDiariaCasal.Location = new System.Drawing.Point(103, 43);
            this.textValorDiariaCasal.Name = "textValorDiariaCasal";
            this.textValorDiariaCasal.Size = new System.Drawing.Size(84, 20);
            this.textValorDiariaCasal.TabIndex = 25;
            // 
            // textValorDiariaSolteiro
            // 
            this.textValorDiariaSolteiro.Location = new System.Drawing.Point(103, 67);
            this.textValorDiariaSolteiro.Name = "textValorDiariaSolteiro";
            this.textValorDiariaSolteiro.Size = new System.Drawing.Size(84, 20);
            this.textValorDiariaSolteiro.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Quintuplo";
            // 
            // textValorDiariaTriplo
            // 
            this.textValorDiariaTriplo.Location = new System.Drawing.Point(103, 91);
            this.textValorDiariaTriplo.Name = "textValorDiariaTriplo";
            this.textValorDiariaTriplo.Size = new System.Drawing.Size(84, 20);
            this.textValorDiariaTriplo.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Quadruplo";
            // 
            // textValorDiariaQuadruplo
            // 
            this.textValorDiariaQuadruplo.Location = new System.Drawing.Point(103, 117);
            this.textValorDiariaQuadruplo.Name = "textValorDiariaQuadruplo";
            this.textValorDiariaQuadruplo.Size = new System.Drawing.Size(84, 20);
            this.textValorDiariaQuadruplo.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Triplo";
            // 
            // textValorDiariaQuintuplo
            // 
            this.textValorDiariaQuintuplo.Location = new System.Drawing.Point(103, 143);
            this.textValorDiariaQuintuplo.Name = "textValorDiariaQuintuplo";
            this.textValorDiariaQuintuplo.Size = new System.Drawing.Size(84, 20);
            this.textValorDiariaQuintuplo.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Solteiro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Casal";
            // 
            // textValorTotalQuintuplo
            // 
            this.textValorTotalQuintuplo.Location = new System.Drawing.Point(193, 144);
            this.textValorTotalQuintuplo.Name = "textValorTotalQuintuplo";
            this.textValorTotalQuintuplo.Size = new System.Drawing.Size(84, 20);
            this.textValorTotalQuintuplo.TabIndex = 18;
            // 
            // textValorTotalQuadruplo
            // 
            this.textValorTotalQuadruplo.Location = new System.Drawing.Point(193, 118);
            this.textValorTotalQuadruplo.Name = "textValorTotalQuadruplo";
            this.textValorTotalQuadruplo.Size = new System.Drawing.Size(84, 20);
            this.textValorTotalQuadruplo.TabIndex = 17;
            // 
            // textValorTotalSolteiro
            // 
            this.textValorTotalSolteiro.Location = new System.Drawing.Point(193, 67);
            this.textValorTotalSolteiro.Name = "textValorTotalSolteiro";
            this.textValorTotalSolteiro.Size = new System.Drawing.Size(84, 20);
            this.textValorTotalSolteiro.TabIndex = 16;
            // 
            // textValorTotalTriplo
            // 
            this.textValorTotalTriplo.Location = new System.Drawing.Point(193, 92);
            this.textValorTotalTriplo.Name = "textValorTotalTriplo";
            this.textValorTotalTriplo.Size = new System.Drawing.Size(84, 20);
            this.textValorTotalTriplo.TabIndex = 15;
            // 
            // textValorTotalCasal
            // 
            this.textValorTotalCasal.Location = new System.Drawing.Point(193, 43);
            this.textValorTotalCasal.Name = "textValorTotalCasal";
            this.textValorTotalCasal.Size = new System.Drawing.Size(84, 20);
            this.textValorTotalCasal.TabIndex = 14;
            // 
            // textNumeroDiarias
            // 
            this.textNumeroDiarias.Location = new System.Drawing.Point(34, 34);
            this.textNumeroDiarias.Name = "textNumeroDiarias";
            this.textNumeroDiarias.Size = new System.Drawing.Size(39, 20);
            this.textNumeroDiarias.TabIndex = 26;
            this.textNumeroDiarias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textNumeroDiarias);
            this.groupBox3.Location = new System.Drawing.Point(54, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 74);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Número de Diárias";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(709, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.buttonCalcularDiarias);
            this.groupBox4.Location = new System.Drawing.Point(71, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(632, 100);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busca Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "até";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 518);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IMGpousadaBetania);
            this.Name = "Form1";
            this.Text = "Pousada Betania Gramado";
        
            ((System.ComponentModel.ISupportInitialize)(this.IMGpousadaBetania)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonCalcularDiarias;
        private System.Windows.Forms.PictureBox IMGpousadaBetania;
        private global::MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textValorTotalCustom;
        private System.Windows.Forms.TextBox textSolteiroCustom;
        private System.Windows.Forms.TextBox textCrianca07A10;
        private System.Windows.Forms.TextBox textCrianca03A06;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textValorTotalQuintuplo;
        private System.Windows.Forms.TextBox textValorTotalQuadruplo;
        private System.Windows.Forms.TextBox textValorTotalSolteiro;
        private System.Windows.Forms.TextBox textValorTotalTriplo;
        private System.Windows.Forms.TextBox textValorTotalCasal;
        private System.Windows.Forms.TextBox textNumeroDiarias;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textValorDiariaCasal;
        private System.Windows.Forms.TextBox textValorDiariaSolteiro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textValorDiariaTriplo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textValorDiariaQuadruplo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textValorDiariaQuintuplo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textValorDiariaCustom;
        private System.Windows.Forms.Label diária;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
    }
}

