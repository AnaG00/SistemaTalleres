namespace SISTEMATALLERES
{
    partial class RegistroTaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroTaller));
            this.label2 = new System.Windows.Forms.Label();
            this.TBLTALLERES = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LBNombreP = new System.Windows.Forms.TextBox();
            this.LBDisciplina = new System.Windows.Forms.TextBox();
            this.TXTMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LBPeriodo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LBAnio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LBNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBPeriodo = new System.Windows.Forms.ComboBox();
            this.CBAnio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TBLTALLERES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 26.25F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(255, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 42);
            this.label2.TabIndex = 272;
            this.label2.Text = "REGISTRO DE TALLER";
            // 
            // TBLTALLERES
            // 
            this.TBLTALLERES.AllowUserToAddRows = false;
            this.TBLTALLERES.AllowUserToDeleteRows = false;
            this.TBLTALLERES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TBLTALLERES.BackgroundColor = System.Drawing.Color.White;
            this.TBLTALLERES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBLTALLERES.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.TBLTALLERES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TBLTALLERES.Location = new System.Drawing.Point(385, 249);
            this.TBLTALLERES.Name = "TBLTALLERES";
            this.TBLTALLERES.ReadOnly = true;
            this.TBLTALLERES.RowHeadersVisible = false;
            this.TBLTALLERES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TBLTALLERES.Size = new System.Drawing.Size(238, 282);
            this.TBLTALLERES.TabIndex = 274;
            this.TBLTALLERES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TBLTALLERES_CellClick);
            this.TBLTALLERES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TBLTALLERES_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(647, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 306;
            this.label1.Text = "Nombre de profesor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(647, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 305;
            this.label7.Text = "Disciplina:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LBNombreP
            // 
            this.LBNombreP.BackColor = System.Drawing.Color.PeachPuff;
            this.LBNombreP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBNombreP.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNombreP.Location = new System.Drawing.Point(651, 349);
            this.LBNombreP.Name = "LBNombreP";
            this.LBNombreP.ReadOnly = true;
            this.LBNombreP.Size = new System.Drawing.Size(423, 22);
            this.LBNombreP.TabIndex = 308;
            // 
            // LBDisciplina
            // 
            this.LBDisciplina.BackColor = System.Drawing.Color.PeachPuff;
            this.LBDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBDisciplina.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDisciplina.Location = new System.Drawing.Point(652, 282);
            this.LBDisciplina.Name = "LBDisciplina";
            this.LBDisciplina.ReadOnly = true;
            this.LBDisciplina.Size = new System.Drawing.Size(422, 22);
            this.LBDisciplina.TabIndex = 307;
            // 
            // TXTMatricula
            // 
            this.TXTMatricula.BackColor = System.Drawing.SystemColors.Control;
            this.TXTMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TXTMatricula.ForeColor = System.Drawing.Color.Maroon;
            this.TXTMatricula.Location = new System.Drawing.Point(602, 120);
            this.TXTMatricula.Name = "TXTMatricula";
            this.TXTMatricula.Size = new System.Drawing.Size(166, 22);
            this.TXTMatricula.TabIndex = 0;
            this.TXTMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTMatricula_KeyPress);
            this.TXTMatricula.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTMatricula_KeyUp);
            this.TXTMatricula.Leave += new System.EventHandler(this.TXTMatricula_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(351, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 20);
            this.label3.TabIndex = 309;
            this.label3.Text = "1.- Ingresar matricula del alumno:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Futura Bk BT", 15.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(834, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Asignar taller";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(527, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 312;
            this.label4.Text = "Periodo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LBPeriodo
            // 
            this.LBPeriodo.BackColor = System.Drawing.Color.White;
            this.LBPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBPeriodo.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPeriodo.Location = new System.Drawing.Point(789, 153);
            this.LBPeriodo.Name = "LBPeriodo";
            this.LBPeriodo.ReadOnly = true;
            this.LBPeriodo.Size = new System.Drawing.Size(194, 22);
            this.LBPeriodo.TabIndex = 313;
            this.LBPeriodo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(552, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 314;
            this.label6.Text = "Año:";
            // 
            // LBAnio
            // 
            this.LBAnio.BackColor = System.Drawing.Color.White;
            this.LBAnio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBAnio.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAnio.Location = new System.Drawing.Point(789, 182);
            this.LBAnio.Name = "LBAnio";
            this.LBAnio.ReadOnly = true;
            this.LBAnio.Size = new System.Drawing.Size(194, 22);
            this.LBAnio.TabIndex = 315;
            this.LBAnio.TextChanged += new System.EventHandler(this.LBAnio_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(785, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 317;
            this.label8.Text = "Nombre del alumno:";
            // 
            // LBNombre
            // 
            this.LBNombre.BackColor = System.Drawing.Color.White;
            this.LBNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBNombre.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBNombre.Location = new System.Drawing.Point(941, 123);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.ReadOnly = true;
            this.LBNombre.Size = new System.Drawing.Size(388, 22);
            this.LBNombre.TabIndex = 318;
            this.LBNombre.Text = "**Ingrese matricula **";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 25);
            this.label9.TabIndex = 319;
            this.label9.Text = "Asignar un taller a un alumno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(354, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 20);
            this.label10.TabIndex = 320;
            this.label10.Text = "2.- Seleccione la disciplina a desear";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 353;
            this.pictureBox1.TabStop = false;
            // 
            // CBPeriodo
            // 
            this.CBPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CBPeriodo.ForeColor = System.Drawing.Color.Maroon;
            this.CBPeriodo.FormattingEnabled = true;
            this.CBPeriodo.Location = new System.Drawing.Point(602, 149);
            this.CBPeriodo.Name = "CBPeriodo";
            this.CBPeriodo.Size = new System.Drawing.Size(172, 24);
            this.CBPeriodo.TabIndex = 354;
            // 
            // CBAnio
            // 
            this.CBAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CBAnio.ForeColor = System.Drawing.Color.Maroon;
            this.CBAnio.FormattingEnabled = true;
            this.CBAnio.Location = new System.Drawing.Point(602, 182);
            this.CBAnio.Name = "CBAnio";
            this.CBAnio.Size = new System.Drawing.Size(112, 24);
            this.CBAnio.TabIndex = 355;
            this.CBAnio.SelectedIndexChanged += new System.EventHandler(this.CBAnio_SelectedIndexChanged);
            // 
            // RegistroTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 598);
            this.Controls.Add(this.CBAnio);
            this.Controls.Add(this.CBPeriodo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LBNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBAnio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBPeriodo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXTMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LBNombreP);
            this.Controls.Add(this.LBDisciplina);
            this.Controls.Add(this.TBLTALLERES);
            this.Controls.Add(this.label2);
            this.Name = "RegistroTaller";
            this.Text = "RegistroTaller";
            this.Load += new System.EventHandler(this.RegistroTaller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBLTALLERES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TBLTALLERES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox LBNombreP;
        public System.Windows.Forms.TextBox LBDisciplina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TXTMatricula;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox LBPeriodo;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox LBAnio;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox LBNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBPeriodo;
        private System.Windows.Forms.ComboBox CBAnio;
    }
}