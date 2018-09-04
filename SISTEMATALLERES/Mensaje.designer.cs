namespace SISTEMATALLERES
{
    partial class Mensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensaje));
            this.button18 = new System.Windows.Forms.Button();
            this.Icono = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.Texto = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(112, 157);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(128, 31);
            this.button18.TabIndex = 207;
            this.button18.Text = "Entendido";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // Icono
            // 
            this.Icono.BackColor = System.Drawing.Color.White;
            this.Icono.Location = new System.Drawing.Point(148, 47);
            this.Icono.Name = "Icono";
            this.Icono.Size = new System.Drawing.Size(57, 58);
            this.Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icono.TabIndex = 204;
            this.Icono.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.AcceptsReturn = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Window;
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Titulo.Enabled = false;
            this.Titulo.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DarkRed;
            this.Titulo.HideSelection = false;
            this.Titulo.Location = new System.Drawing.Point(18, 16);
            this.Titulo.Multiline = true;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.ShortcutsEnabled = false;
            this.Titulo.Size = new System.Drawing.Size(317, 25);
            this.Titulo.TabIndex = 205;
            this.Titulo.Text = "REGISTRO NO REALIZADO";
            this.Titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Texto
            // 
            this.Texto.BackColor = System.Drawing.SystemColors.Window;
            this.Texto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Texto.Enabled = false;
            this.Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Texto.Location = new System.Drawing.Point(33, 105);
            this.Texto.Multiline = true;
            this.Texto.Name = "Texto";
            this.Texto.ReadOnly = true;
            this.Texto.Size = new System.Drawing.Size(287, 46);
            this.Texto.TabIndex = 206;
            this.Texto.Text = "Todos los campos tiene que estar llenos";
            this.Texto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Texto.TextChanged += new System.EventHandler(this.Texto_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 209;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 203);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.Icono);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificación";
            this.Load += new System.EventHandler(this.Mensaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.PictureBox Icono;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.TextBox Texto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}