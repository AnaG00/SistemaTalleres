namespace SISTEMATALLERES
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.label2 = new System.Windows.Forms.Label();
            this.cartas = new System.Windows.Forms.Label();
            this.CBAnio = new System.Windows.Forms.ComboBox();
            this.CBMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBLGENERAL = new System.Windows.Forms.DataGridView();
            this.button18 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TBLGENERAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(261, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 42);
            this.label2.TabIndex = 367;
            this.label2.Text = "REPORTES";
            // 
            // cartas
            // 
            this.cartas.AutoSize = true;
            this.cartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cartas.ForeColor = System.Drawing.Color.Black;
            this.cartas.Location = new System.Drawing.Point(173, 166);
            this.cartas.Name = "cartas";
            this.cartas.Size = new System.Drawing.Size(118, 20);
            this.cartas.TabIndex = 366;
            this.cartas.Text = "Total de cartas:";
            // 
            // CBAnio
            // 
            this.CBAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CBAnio.ForeColor = System.Drawing.Color.Maroon;
            this.CBAnio.FormattingEnabled = true;
            this.CBAnio.Items.AddRange(new object[] {
            "Todas"});
            this.CBAnio.Location = new System.Drawing.Point(326, 133);
            this.CBAnio.Name = "CBAnio";
            this.CBAnio.Size = new System.Drawing.Size(189, 24);
            this.CBAnio.TabIndex = 1;
            // 
            // CBMes
            // 
            this.CBMes.DisplayMember = "PkDisciplina";
            this.CBMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CBMes.ForeColor = System.Drawing.Color.Maroon;
            this.CBMes.FormattingEnabled = true;
            this.CBMes.Location = new System.Drawing.Point(326, 104);
            this.CBMes.Name = "CBMes";
            this.CBMes.Size = new System.Drawing.Size(189, 24);
            this.CBMes.TabIndex = 0;
            this.CBMes.ValueMember = "PkDisciplina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(282, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 359;
            this.label4.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(282, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 358;
            this.label5.Text = "Mes";
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
            this.TBLGENERAL.Location = new System.Drawing.Point(174, 190);
            this.TBLGENERAL.Name = "TBLGENERAL";
            this.TBLGENERAL.RowHeadersVisible = false;
            this.TBLGENERAL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TBLGENERAL.Size = new System.Drawing.Size(1168, 318);
            this.TBLGENERAL.TabIndex = 355;
            this.TBLGENERAL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TBLGENERAL_CellClick);
            //this.TBLGENERAL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TBLGENERAL_CellContentClick);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button18.Location = new System.Drawing.Point(566, 127);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(138, 30);
            this.button18.TabIndex = 2;
            this.button18.Text = "Mostrar alumnos";
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
            this.pictureBox1.TabIndex = 368;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 369;
            this.label1.Text = "Cartas entregadas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1164, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cartas);
            this.Controls.Add(this.CBAnio);
            this.Controls.Add(this.CBMes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBLGENERAL);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Reportes";
            this.Text = "-+";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBLGENERAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cartas;
        private System.Windows.Forms.ComboBox CBAnio;
        private System.Windows.Forms.ComboBox CBMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView TBLGENERAL;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}