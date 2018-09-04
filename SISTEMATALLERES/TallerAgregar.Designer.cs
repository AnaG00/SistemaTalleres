namespace SISTEMATALLERES
{
    partial class TallerAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TallerAgregar));
            this.label2 = new System.Windows.Forms.Label();
            this.CBProfesor = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.TXTDisciplina = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidosU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoControlU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpassU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCargoU = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.label2.Size = new System.Drawing.Size(307, 42);
            this.label2.TabIndex = 271;
            this.label2.Text = "CREAR NUEVO TALLER";
            // 
            // CBProfesor
            // 
            this.CBProfesor.BackColor = System.Drawing.SystemColors.Window;
            this.CBProfesor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.CBProfesor.ForeColor = System.Drawing.Color.Maroon;
            this.CBProfesor.FormattingEnabled = true;
            this.CBProfesor.Location = new System.Drawing.Point(271, 268);
            this.CBProfesor.Name = "CBProfesor";
            this.CBProfesor.Size = new System.Drawing.Size(401, 28);
            this.CBProfesor.TabIndex = 1;
            this.CBProfesor.SelectedIndexChanged += new System.EventHandler(this.CBCarrera_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(258, 232);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(142, 20);
            this.label23.TabIndex = 288;
            this.label23.Text = "Profesor asignado:";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(258, 132);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(183, 20);
            this.label24.TabIndex = 290;
            this.label24.Text = "Nombre de la disciplina:  ";
            // 
            // TXTDisciplina
            // 
            this.TXTDisciplina.BackColor = System.Drawing.SystemColors.Control;
            this.TXTDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TXTDisciplina.ForeColor = System.Drawing.Color.Maroon;
            this.TXTDisciplina.Location = new System.Drawing.Point(262, 157);
            this.TXTDisciplina.Name = "TXTDisciplina";
            this.TXTDisciplina.Size = new System.Drawing.Size(410, 22);
            this.TXTDisciplina.TabIndex = 0;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Futura Bk BT", 15.75F);
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(430, 461);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(252, 45);
            this.button18.TabIndex = 2;
            this.button18.Text = "Crear taller";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
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
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Futura Bk BT", 15.75F);
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearUsuario.Location = new System.Drawing.Point(1000, 461);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(252, 45);
            this.btnCrearUsuario.TabIndex = 9;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(828, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 326;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreU
            // 
            this.txtNombreU.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNombreU.ForeColor = System.Drawing.Color.Maroon;
            this.txtNombreU.Location = new System.Drawing.Point(1017, 132);
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(270, 22);
            this.txtNombreU.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 26.25F);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(812, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 42);
            this.label4.TabIndex = 323;
            this.label4.Text = "CREAR NUEVO USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(828, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 329;
            this.label3.Text = "Apellidos:";
            // 
            // txtApellidosU
            // 
            this.txtApellidosU.BackColor = System.Drawing.SystemColors.Control;
            this.txtApellidosU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidosU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtApellidosU.ForeColor = System.Drawing.Color.Maroon;
            this.txtApellidosU.Location = new System.Drawing.Point(1017, 172);
            this.txtApellidosU.Name = "txtApellidosU";
            this.txtApellidosU.Size = new System.Drawing.Size(270, 22);
            this.txtApellidosU.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(828, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 331;
            this.label5.Text = "Número de control:";
            // 
            // txtNoControlU
            // 
            this.txtNoControlU.BackColor = System.Drawing.SystemColors.Control;
            this.txtNoControlU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoControlU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNoControlU.ForeColor = System.Drawing.Color.Maroon;
            this.txtNoControlU.Location = new System.Drawing.Point(1017, 213);
            this.txtNoControlU.Name = "txtNoControlU";
            this.txtNoControlU.Size = new System.Drawing.Size(270, 22);
            this.txtNoControlU.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(828, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 333;
            this.label6.Text = "Contraseña:";
            // 
            // txtpassU
            // 
            this.txtpassU.BackColor = System.Drawing.SystemColors.Control;
            this.txtpassU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtpassU.ForeColor = System.Drawing.Color.Maroon;
            this.txtpassU.Location = new System.Drawing.Point(1017, 253);
            this.txtpassU.Name = "txtpassU";
            this.txtpassU.Size = new System.Drawing.Size(270, 22);
            this.txtpassU.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(828, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 335;
            this.label7.Text = "Cargo:";
            // 
            // cbCargoU
            // 
            this.cbCargoU.BackColor = System.Drawing.SystemColors.Window;
            this.cbCargoU.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.cbCargoU.ForeColor = System.Drawing.Color.Maroon;
            this.cbCargoU.FormattingEnabled = true;
            this.cbCargoU.Items.AddRange(new object[] {
            "Coordinación",
            "Profesor"});
            this.cbCargoU.Location = new System.Drawing.Point(1017, 344);
            this.cbCargoU.Name = "cbCargoU";
            this.cbCargoU.Size = new System.Drawing.Size(270, 28);
            this.cbCargoU.TabIndex = 8;
            this.cbCargoU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCargoU_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(232, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(440, 16);
            this.label8.TabIndex = 337;
            this.label8.Text = "Para asignar un taller a un nuevo profesor, prediamente debe ser creado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(828, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 338;
            this.label9.Text = "Confimar contraseña:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(1017, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TallerAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 598);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCargoU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpassU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNoControlU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidosU);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.TXTDisciplina);
            this.Controls.Add(this.CBProfesor);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label2);
            this.Name = "TallerAgregar";
            this.Text = "TallerAgregar";
            this.Load += new System.EventHandler(this.TallerAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBProfesor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox TXTDisciplina;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidosU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoControlU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpassU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCargoU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}