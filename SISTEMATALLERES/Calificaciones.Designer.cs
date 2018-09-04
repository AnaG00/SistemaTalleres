namespace SISTEMATALLERES
{
    partial class Calificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calificaciones));
            this.label2 = new System.Windows.Forms.Label();
            this.CBProfesor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.TBLGENERAL = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CBDisciplina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBAnio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBPeriodo = new System.Windows.Forms.ComboBox();
            this.CBAnio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TBLGENERAL)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(411, 42);
            this.label2.TabIndex = 272;
            this.label2.Text = "CAPTURA DE CALIFICACIONES";
            // 
            // CBProfesor
            // 
            this.CBProfesor.DisplayMember = "PkDisciplina";
            this.CBProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBProfesor.ForeColor = System.Drawing.Color.Maroon;
            this.CBProfesor.FormattingEnabled = true;
            this.CBProfesor.Location = new System.Drawing.Point(369, 111);
            this.CBProfesor.Name = "CBProfesor";
            this.CBProfesor.Size = new System.Drawing.Size(279, 28);
            this.CBProfesor.TabIndex = 1;
            this.CBProfesor.ValueMember = "PkDisciplina";
            this.CBProfesor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.CBProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBProfesor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(282, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 299;
            this.label3.Text = "Disciplina:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Futura Bk BT", 15.75F);
            this.button18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button18.Location = new System.Drawing.Point(1048, 108);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(220, 35);
            this.button18.TabIndex = 4;
            this.button18.Text = "Mostrar alumnos";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // TBLGENERAL
            // 
            this.TBLGENERAL.AllowUserToAddRows = false;
            this.TBLGENERAL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TBLGENERAL.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TBLGENERAL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBLGENERAL.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.TBLGENERAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TBLGENERAL.EnableHeadersVisualStyles = false;
            this.TBLGENERAL.Location = new System.Drawing.Point(229, 202);
            this.TBLGENERAL.Name = "TBLGENERAL";
            this.TBLGENERAL.RowHeadersVisible = false;
            this.TBLGENERAL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TBLGENERAL.Size = new System.Drawing.Size(1039, 285);
            this.TBLGENERAL.TabIndex = 307;
            this.TBLGENERAL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TBLGENERAL_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Futura Bk BT", 15.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1048, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBDisciplina
            // 
            this.CBDisciplina.DisplayMember = "PkDisciplina";
            this.CBDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDisciplina.ForeColor = System.Drawing.Color.Maroon;
            this.CBDisciplina.FormattingEnabled = true;
            this.CBDisciplina.Location = new System.Drawing.Point(369, 153);
            this.CBDisciplina.Name = "CBDisciplina";
            this.CBDisciplina.Size = new System.Drawing.Size(279, 28);
            this.CBDisciplina.TabIndex = 2;
            this.CBDisciplina.ValueMember = "PkDisciplina";
            this.CBDisciplina.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(282, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 309;
            this.label1.Text = "Profesor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(680, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 318;
            this.label6.Text = "Año:";
            // 
            // LBAnio
            // 
            this.LBAnio.BackColor = System.Drawing.Color.White;
            this.LBAnio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAnio.Location = new System.Drawing.Point(726, 159);
            this.LBAnio.Name = "LBAnio";
            this.LBAnio.Size = new System.Drawing.Size(137, 19);
            this.LBAnio.TabIndex = 319;
            this.LBAnio.TextChanged += new System.EventHandler(this.LBAnio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(680, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 316;
            this.label4.Text = "Periodo:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 322;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 25);
            this.label5.TabIndex = 323;
            this.label5.Text = "Seleccionar primero el profesor";
            // 
            // CBPeriodo
            // 
            this.CBPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CBPeriodo.FormattingEnabled = true;
            this.CBPeriodo.Location = new System.Drawing.Point(753, 108);
            this.CBPeriodo.Name = "CBPeriodo";
            this.CBPeriodo.Size = new System.Drawing.Size(212, 28);
            this.CBPeriodo.TabIndex = 3;
            this.CBPeriodo.SelectedIndexChanged += new System.EventHandler(this.CBPeriodo_SelectedIndexChanged);
            // 
            // CBAnio
            // 
            this.CBAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CBAnio.ForeColor = System.Drawing.Color.Maroon;
            this.CBAnio.FormattingEnabled = true;
            this.CBAnio.Location = new System.Drawing.Point(853, 156);
            this.CBAnio.Name = "CBAnio";
            this.CBAnio.Size = new System.Drawing.Size(112, 24);
            this.CBAnio.TabIndex = 324;
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 606);
            this.Controls.Add(this.CBAnio);
            this.Controls.Add(this.CBPeriodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBAnio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBDisciplina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBLGENERAL);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.CBProfesor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Calificaciones";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.Calificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBLGENERAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBProfesor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.DataGridView TBLGENERAL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox LBAnio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBPeriodo;
        private System.Windows.Forms.ComboBox CBAnio;
    }
}