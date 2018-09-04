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
    public partial class ConsultaAlumno : Form, IAlumno, ITalleres
    {
        WTalleres objWTaller;
        WAlumno objWAlumno;
        string Nombre;
        string apellidos;
        string carrera;
        string logo1, logo2, logo3;
        string matricula = "", cartal;

        #region DATASET: LISTARTALLER, LISTARALUMNO, CARRERAS, PERIODO, AÑOS, ALUMNO, DISCIPLINA
        public DataSet ListarTaller
        {
            set
            {
                TBLINDIVIDUAL.DataSource = value;
                TBLINDIVIDUAL.DataMember = "Datos";
                TBLINDIVIDUAL.AutoResizeColumns();
                TBLINDIVIDUAL.AutoResizeRows();
                TBLINDIVIDUAL.Columns["Taller"].Visible = true;
                TBLINDIVIDUAL.Columns["Profesor"].Visible = true;
                TBLINDIVIDUAL.Columns["Periodo"].Visible = true;
                TBLINDIVIDUAL.Columns["Año"].Visible = true;
                TBLINDIVIDUAL.Columns["Parcial 1"].Visible = true;
                TBLINDIVIDUAL.Columns["Parcial 2"].Visible = true;
                TBLINDIVIDUAL.Columns["Parcial 3"].Visible = true;
                TBLINDIVIDUAL.Columns["Final"].Visible = false;
            }
        }     
        public DataSet ListarAlumno
        {
            set
            {
                Nombre = value.Tables[0].Rows[0]["NombreAlumno"].ToString();
                apellidos = value.Tables[0].Rows[0]["ApellidoAlumno"].ToString();
                carrera = value.Tables[0].Rows[0]["NombreCarrera"].ToString();
                cartal= value.Tables[0].Rows[0]["CartaLiberacion"].ToString();

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
        public DataSet Periodo
        {
            set
            {
                CBPeriodo.DataSource = value.Tables[0];
                CBPeriodo.DisplayMember = "PkPeriodo";
                CBPeriodo.ValueMember = "PkPeriodo";
            }
        }
        public DataSet Anios
        {
            set
            {
                CBAnio.DataSource = value.Tables[0];
                CBAnio.DisplayMember = "Año";
                CBAnio.ValueMember = "Año";
            }
        }
        public DataSet Alumnos
        {
            set
            {
                TBLGENERAL.DataSource = value;
                TBLGENERAL.DataMember = "Datos";
                TBLGENERAL.AutoResizeColumns();
                TBLGENERAL.AutoResizeRows();
                TBLGENERAL.Columns["Matricula"].Visible = true;
                TBLGENERAL.Columns["Nombre"].Visible = true;
                TBLGENERAL.Columns["Profesor"].Visible = true;
                TBLGENERAL.Columns["Carrera"].Visible = true;
            }
        }
        public DataSet Disciplina
        {
            set
            {
                CBDisciplina.DataSource = value.Tables[0];
                CBDisciplina.DisplayMember = "Disciplina";
                CBDisciplina.ValueMember = "PkDisciplina";
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
        public DataSet Promedio { set => throw new NotImplementedException(); }
        public DataSet ListarProfesor
        {
            set
            {
                carta.DataSource = value;
                carta.DataMember = "Datos";
                carta.AutoResizeColumns();
                carta.AutoResizeRows();
                carta.Columns["ACTIVIDAD"].Visible = true;
                carta.Columns["DOCENTE"].Visible = true;
                carta.Columns["PERIODO"].Visible = true;
                carta.Columns["SELLO"].Visible = true;
            }
        }
        public CTalleres Taller => throw new NotImplementedException();
        public CAlumno Alumno => throw new NotImplementedException();
        public CProfesor Profesor => throw new NotImplementedException();
        #endregion

        public ConsultaAlumno()
        {
            InitializeComponent();
            FormatoTabla(TBLGENERAL);
            FormatoTabla(TBLINDIVIDUAL);
            objWTaller = new WTalleres(this);
            objWAlumno = new WAlumno(this);
        }
        private void ConsultaAlumno_Load(object sender, EventArgs e)
        {
            carta.Visible = false;
            Ind.Select();          
            objWAlumno.ListarPeriodo();            
            objWAlumno.ListarAnio();
            objWAlumno.LLenarCarreras();
            objWAlumno.ListarTaller();
            objWTaller.ListarLogos();
        }

        #region BOTONES, MÉTODOS
        private void Ind_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            TXTNombreC.Visible = true;
            TXTApellidos.Visible = true;
            TXTCarrera.Visible = true;
            TBLINDIVIDUAL.Visible = true;
            TBLGENERAL.Visible = false;
            TXTMatricula.Enabled = true;
            Excel.Visible = false;
        }

        private void todos_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            TXTNombreC.Visible = false;
            TXTApellidos.Visible = false;
            TXTCarrera.Visible = false;
            TBLINDIVIDUAL.Visible = false;
            TBLGENERAL.Visible = true;
            TXTMatricula.Enabled = false;
            Excel.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ind.Checked)
                {
                    objWAlumno.ConsultaAlumno(1, TXTMatricula.Text);
                    objWTaller.TalleresAlumno(2, TXTMatricula.Text);
                    objWTaller.TalleresAlumnoC(7, TXTMatricula.Text);
                    TXTNombreC.Text = Nombre;
                    TXTApellidos.Text = apellidos;
                    TXTCarrera.Text = carrera;
                    matricula = TXTMatricula.Text;
                    if (cartal == "1")
                        btnGenerarCarta.Enabled = true;
                    else
                        btnGenerarCarta.Enabled = false;
                }
                else if (todos.Checked)
                {
                    objWAlumno.consultageneral(CBDisciplina.SelectedValue.ToString(), CBAnio.SelectedValue.ToString(), CBPeriodo.SelectedValue.ToString(), CBCarrera.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                Mensaje("ad1", "Ingrese matrícula a buscar", "Seleccione correctamente los campos");
            }
        }
        private void TXTMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
             e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void Excel_Click(object sender, EventArgs e)
        {
            exportaraexcel(TBLGENERAL);
        }
        public void exportaraexcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) //Columnas
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndiceFila = 0;
            foreach (DataGridViewRow row in tabla.Rows) //Filas
            {
                IndiceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
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

        public void Mensaje(string ima, string titulo, string texto)
        {
            Mensaje a = new Mensaje(ima, titulo, texto);
            a.Show();
        }
        #region 
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TXTApellidoP_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = objWAlumno.Liberar(2, Convert.ToInt32(TXTMatricula.Text));
                if (r == true)
                {
                    Mensaje("listo1", "Listo", "Generando carta de liberación");
                    PDF();
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
            if (File.Exists(pathname + ".pdf") == true)
            {
                cont++;
                pathname = pathname + "_copy(" + cont + ")";
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
            Chunk NombreAlumno = new Chunk(Nombre, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD));
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
            PdfPTable datatable = new PdfPTable(carta.ColumnCount);
            datatable.DefaultCell.Padding = 20;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < carta.ColumnCount; i++)
            {
                PdfPCell cellF = new PdfPCell(new Phrase(carta.Columns[i].HeaderText));
                cellF.BackgroundColor = BaseColor.LIGHT_GRAY;
                datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                datatable.AddCell(cellF);
            }

            for (i = 0; i < carta.Rows.Count; i++)
            {
                for (j = 0; j < carta.Columns.Count; j++)
                {
                    if (carta[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(carta[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
            }
            document.Add(datatable);
        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            int i = 0;
            float[] values = new float[dg.ColumnCount];
            for (i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
        
    }
}
