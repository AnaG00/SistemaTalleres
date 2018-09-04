using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Nucleo.Vista;
using System.Diagnostics;
using Nucleo.Modelo;
using Nucleo.Presentador;

namespace SISTEMATALLERES
{
    public partial class Liberacion : Form, IAlumno, ITalleres
    {
        WAlumno wAlumno;
        WTalleres wTalleres;
        string logo1, logo2, logo3;
        string matricula = "", nombre="", carrera="";
        #region DATASET: TABLACARTA, OBTENERLOGOS, LISTARALUMNO, DISCIPLINA
        public DataSet ListarTaller
        {
            set
            {
                TBLINDIVIDUAL.DataSource = value;
                TBLINDIVIDUAL.DataMember = "Datos";
                TBLINDIVIDUAL.AutoResizeColumns();
                TBLINDIVIDUAL.AutoResizeRows();
                TBLINDIVIDUAL.Columns["ACTIVIDAD"].Visible = true;
                TBLINDIVIDUAL.Columns["DOCENTE"].Visible = true;
                TBLINDIVIDUAL.Columns["PERIODO"].Visible = true;
                TBLINDIVIDUAL.Columns["SELLO"].Visible = true;
            }
        }        
        public DataSet ObtenerUnDato
        {
            set
            {
                logo1 = value.Tables[0].Rows[0]["LInstitucional"].ToString();
                logo2 = value.Tables[0].Rows[0]["LSecretaria"].ToString();
                logo3 = value.Tables[0].Rows[0]["LEstado"].ToString();
            }
        }     
        public DataSet ListarAlumno
        {
            set
            {
                TBLGENERAL.DataSource = value;
                TBLGENERAL.DataMember = "Datos";
                TBLGENERAL.AutoResizeColumns();
                TBLGENERAL.AutoResizeRows();
                TBLGENERAL.Columns["Matricula"].Visible = true;
                TBLGENERAL.Columns["Nombre"].Visible = true;
                TBLGENERAL.Columns["Carrera"].Visible = true;
                // TBLGENERAL.Columns["Fecha de entrega"].Visible = true;
            }
        }
        public DataSet Carreras
        {
            set
            {

                CBCarrera.DataSource = value.Tables[0];
                CBCarrera.DisplayMember = "NombreCarrera";
                CBCarrera.ValueMember = "PkCarrera";
            }
        }
        public DataSet Disciplina { set => throw new NotImplementedException(); }
        public DataSet ListarProfesor
        {
            set
            {
                TBLINDIVIDUAL.DataSource = value;
                TBLINDIVIDUAL.DataMember = "Datos";
                TBLINDIVIDUAL.AutoResizeColumns();
                TBLINDIVIDUAL.AutoResizeRows();
                TBLINDIVIDUAL.Columns["ACTIVIDAD"].Visible = true;
                TBLINDIVIDUAL.Columns["DOCENTE"].Visible = true;
                TBLINDIVIDUAL.Columns["PERIODO"].Visible = true;
                TBLINDIVIDUAL.Columns["SELLO"].Visible = true;
            }
        }
        public DataSet Periodo { set => throw new NotImplementedException(); }
        public CAlumno Alumno => throw new NotImplementedException();
        public DataSet Anios { set => throw new NotImplementedException(); }
        public DataSet Promedio { set => throw new NotImplementedException(); }
        public CTalleres Taller => throw new NotImplementedException();
        public CProfesor Profesor => throw new NotImplementedException();
        public DataSet Alumnos { set => throw new NotImplementedException(); }
        #endregion

        public Liberacion()
        {
            InitializeComponent();
            FormatoTabla(TBLINDIVIDUAL);
            FormatoTabla(TBLGENERAL);
            wTalleres = new WTalleres(this);
            wAlumno = new WAlumno(this);
            wTalleres.ListarLogos();
        }
        private void Liberacion_Load(object sender, EventArgs e)
        {
            wAlumno.LLenarCarreras();
        }
        #region BOTONES, MÉTODOS
        private void button18_Click(object sender, EventArgs e)
        {
            wAlumno.LiberadoSinCarta(1, CBCarrera.SelectedValue.ToString());
            cartas.Text = "Total de cartas: " + TBLGENERAL.RowCount;
        }
        private void TBLGENERAL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            wTalleres.TalleresAlumnoC(7, TBLGENERAL.CurrentRow.Cells[0].Value.ToString());
            matricula = TBLGENERAL.CurrentRow.Cells[0].Value.ToString();
            nombre = TBLGENERAL.CurrentRow.Cells[1].Value.ToString();
            carrera = TBLGENERAL.CurrentRow.Cells[2].Value.ToString();
            TNombre.Text = nombre;            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = wAlumno.Liberar(2, Convert.ToInt32(matricula));
                if (r == true)
                {
                    Mensaje("listo1", "Listo", "Generando carta de liberación");
                    PDF();
                    wAlumno.LiberadoSinCarta(1, CBCarrera.SelectedValue.ToString());
                }
                else
                    Mensaje("ad1", "Error", "Vuelva a intentarlo");
            }
            catch (Exception ex)
            {
                Mensaje("ad1", "Error", "Seleccione un alumno");
            }    
        }       
        public void PDF()
        {
            Document doc = new Document(PageSize.LETTER);
            string name = "CartaLiberacion" + matricula;
            string folder = @"C:\\CARTAS_DE_LIBERACIÓN";
            System.IO.Directory.CreateDirectory(folder);
            string pathname = "C:\\CARTAS_DE_LIBERACIÓN\\" + name;
            int cont = 0;
            if (File.Exists(pathname+".pdf")==true)
            {
                cont++;
                pathname = pathname + "_copy("+cont+")";
            }
            pathname = pathname + ".pdf";
            FileStream file = new FileStream(pathname, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite); 
           
            PdfWriter.GetInstance(doc, file);
            doc.Open();

            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(logo1);
            iTextSharp.text.Image img1 = iTextSharp.text.Image.GetInstance(logo2);
            iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(logo3);
            iTextSharp.text.Image img4 = iTextSharp.text.Image.GetInstance("pie.png");           

            img.ScaleToFit(125f, 60F);
            img1.ScaleToFit(200f, 60F);
            img2.ScaleToFit(275f, 60F);
            img.SetAbsolutePosition(70, 700);
            img1.SetAbsolutePosition(240, 700);
            img2.SetAbsolutePosition(500, 700);
            img4.SetAbsolutePosition(-50, 10);
            doc.Add(img);
            doc.Add(img1);
            doc.Add(img2);
            Chunk NombreAlumno = new Chunk(nombre, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD));
            Chunk MatriculaAlumno = new Chunk(matricula, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD));
            Chunk CarreraAlumno = new Chunk(carrera, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD));
            Chunk chunk2 = new Chunk("Por medio de la presente, el Departamento de Cultura y Deporte hace constar que el alumno (a) ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL));
            Chunk chunk21 = new Chunk(" con número de control ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL));
            Chunk chunk22 = new Chunk(" de la carrera: " + CarreraAlumno.ToString() + " curso sus tres clubes extracurriculares como aparece en la tabla.", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL));
            Chunk chunk23 = new Chunk(" curso sus tres clubes extracurriculares como aparece en la tabla.", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL));
            Chunk chunk3 = new Chunk("CARTA DE LIBERACIÓN DE CLUBES", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL));
            
            Paragraph Liberacion = new Paragraph("Libración No. CULTyDEP/", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.NORMAL));
            Liberacion.Alignment = Element.ALIGN_RIGHT;
            Paragraph Fecha = new Paragraph("TULANCINGO DE BRAVO HGO, " + DateTime.Now.Date.ToLongDateString());
            Fecha.Alignment = Element.ALIGN_RIGHT;
            Paragraph cp = new Paragraph("..C.P. ARCHIVO.", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL));
            Paragraph att = new Paragraph("A T E N T A M E N T E,", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL));
            att.Alignment = Element.ALIGN_CENTER;
            Paragraph A = new Paragraph("ACTIVIDADES CULTURALES Y DEPORTIVAS", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL));
            A.Alignment = Element.ALIGN_CENTER;
            Paragraph ing = new Paragraph("ING. ARMANDO AVILA AGUILAR", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL));
            ing.Alignment = Element.ALIGN_CENTER;

            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph("                       "));
            doc.Add(Liberacion);
            doc.Add(Fecha);
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph(chunk3));
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph(chunk2));
            doc.Add(NombreAlumno);
            doc.Add(chunk21);
            doc.Add(MatriculaAlumno);
            doc.Add(chunk22);
            doc.Add(CarreraAlumno);
            doc.Add(chunk23);
            doc.Add(new Paragraph("                       "));
            GenerarDocumento(doc);
            doc.Add(new Paragraph("                       "));
            doc.AddCreationDate();
            doc.Add(new Paragraph("Sin más por el momento agradezco su atención y queda de usted."));
            doc.Add(new Paragraph("                       "));
            doc.Add(att);
            doc.Add(new Paragraph("                       "));
            doc.Add(ing);
            doc.Add(A);
            doc.Add(new Paragraph("                       "));
            doc.Add(cp);
            doc.Add(new Paragraph("                       "));
            doc.Add(img4);
            doc.Close();
            Process.Start(pathname);
        }
        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(TBLINDIVIDUAL.ColumnCount);
            datatable.DefaultCell.Padding = 20;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < TBLINDIVIDUAL.ColumnCount; i++)
            {
                PdfPCell cellF = new PdfPCell(new Phrase(TBLINDIVIDUAL.Columns[i].HeaderText));
                cellF.BackgroundColor = BaseColor.LIGHT_GRAY;
                datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                datatable.AddCell(cellF);
            }

            for (i = 0; i < TBLINDIVIDUAL.Rows.Count; i++)
            {
                for (j = 0; j < TBLINDIVIDUAL.Columns.Count; j++)
                {
                    if (TBLINDIVIDUAL[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(TBLINDIVIDUAL[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
            }
            document.Add(datatable);
        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            int i = 0;
            float[] values = new float[dg.ColumnCount];
            for ( i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
        public void FormatoTabla(DataGridView Table)
        {//Da formato a las tabla de la aplicación
            Table.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10);
            Table.DefaultCellStyle.ForeColor = Color.Brown;
            Table.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 13);
            Table.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Table.ColumnHeadersDefaultCellStyle.BackColor = Color.Brown;
        }
        #endregion

        #region

        private void TBLGENERAL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TBLINDIVIDUAL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AlumnosL_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        #endregion
        public void Mensaje(string ima, string titulo, string texto)
        {
            Mensaje a = new Mensaje(ima, titulo, texto);
            a.Show();
        }
    }
}
