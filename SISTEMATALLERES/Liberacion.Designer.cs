namespace SISTEMATALLERES
{
    partial class Liberacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liberacion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button18 = new System.Windows.Forms.Button();
            this.TBLGENERAL = new System.Windows.Forms.DataGridView();
            this.TBLINDIVIDUAL = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBCarrera = new System.Windows.Forms.ComboBox();
            this.cartas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarCarta = new System.Windows.Forms.Button();
            this.TNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLGENERAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLINDIVIDUAL)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 352;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button18.Location = new System.Drawing.Point(653, 78);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(168, 30);
            this.button18.TabIndex = 323;
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
            this.TBLGENERAL.Location = new System.Drawing.Point(195, 117);
            this.TBLGENERAL.Name = "TBLGENERAL";
            this.TBLGENERAL.RowHeadersVisible = false;
            this.TBLGENERAL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TBLGENERAL.Size = new System.Drawing.Size(640, 398);
            this.TBLGENERAL.TabIndex = 324;
            this.TBLGENERAL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TBLGENERAL_CellClick);
            this.TBLGENERAL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TBLGENERAL_CellContentClick);
            // 
            // TBLINDIVIDUAL
            // 
            this.TBLINDIVIDUAL.AllowUserToAddRows = false;
            this.TBLINDIVIDUAL.AllowUserToDeleteRows = false;
            this.TBLINDIVIDUAL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TBLINDIVIDUAL.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TBLINDIVIDUAL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBLINDIVIDUAL.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.TBLINDIVIDUAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TBLINDIVIDUAL.EnableHeadersVisualStyles = false;
            this.TBLINDIVIDUAL.Location = new System.Drawing.Point(851, 196);
            this.TBLINDIVIDUAL.Name = "TBLINDIVIDUAL";
            this.TBLINDIVIDUAL.ReadOnly = true;
            this.TBLINDIVIDUAL.RowHeadersVisible = false;
            this.TBLINDIVIDUAL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TBLINDIVIDUAL.Size = new System.Drawing.Size(477, 264);
            this.TBLINDIVIDUAL.TabIndex = 344;
            this.TBLINDIVIDUAL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TBLINDIVIDUAL_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(852, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 345;
            this.label1.Text = "Talleres cursados de:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(203, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 347;
            this.label6.Text = "Seleccione carrera:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CBCarrera
            // 
            this.CBCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CBCarrera.ForeColor = System.Drawing.Color.Maroon;
            this.CBCarrera.FormattingEnabled = true;
            this.CBCarrera.Items.AddRange(new object[] {
            "Todas"});
            this.CBCarrera.Location = new System.Drawing.Point(354, 78);
            this.CBCarrera.Name = "CBCarrera";
            this.CBCarrera.Size = new System.Drawing.Size(281, 28);
            this.CBCarrera.TabIndex = 349;
            this.CBCarrera.SelectedIndexChanged += new System.EventHandler(this.CBCarrera_SelectedIndexChanged);
            // 
            // cartas
            // 
            this.cartas.AutoSize = true;
            this.cartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cartas.ForeColor = System.Drawing.Color.Black;
            this.cartas.Location = new System.Drawing.Point(191, 526);
            this.cartas.Name = "cartas";
            this.cartas.Size = new System.Drawing.Size(118, 20);
            this.cartas.TabIndex = 350;
            this.cartas.Text = "Total de cartas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(188, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 42);
            this.label2.TabIndex = 351;
            this.label2.Text = "LIBERACIÓN DE CLUBES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGenerarCarta
            // 
            this.btnGenerarCarta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerarCarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCarta.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCarta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarCarta.Location = new System.Drawing.Point(981, 480);
            this.btnGenerarCarta.Name = "btnGenerarCarta";
            this.btnGenerarCarta.Size = new System.Drawing.Size(347, 35);
            this.btnGenerarCarta.TabIndex = 353;
            this.btnGenerarCarta.Text = "Generar carta individual";
            this.btnGenerarCarta.UseVisualStyleBackColor = false;
            this.btnGenerarCarta.Click += new System.EventHandler(this.button1_Click);
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.Control;
            this.TNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.ForeColor = System.Drawing.Color.Maroon;
            this.TNombre.Location = new System.Drawing.Point(1016, 164);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(317, 22);
            this.TNombre.TabIndex = 356;
            this.TNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Liberacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 598);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.btnGenerarCarta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cartas);
            this.Controls.Add(this.CBCarrera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBLINDIVIDUAL);
            this.Controls.Add(this.TBLGENERAL);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Liberacion";
            this.Text = "Liberacion";
            this.Load += new System.EventHandler(this.Liberacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLGENERAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLINDIVIDUAL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.DataGridView TBLGENERAL;
        private System.Windows.Forms.DataGridView TBLINDIVIDUAL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBCarrera;
        private System.Windows.Forms.Label cartas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerarCarta;
        private System.Windows.Forms.TextBox TNombre;
    }
}