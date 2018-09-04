using Nucleo.Vista;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Nucleo.Modelo;
using Nucleo.Presentador;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace SISTEMATALLERES
{
    public partial class Reportes : Form, IAlumno, ITalleres
    {
        WAlumno wAlumno;
        WTalleres wTalleres;
        string anio, mesS;
        public Reportes()
        {
            InitializeComponent();
            FormatoTabla(TBLGENERAL);
            wTalleres = new WTalleres(this);
            wAlumno = new WAlumno(this);
        }
        private void Reportes_Load(object sender, EventArgs e)
        {
            wAlumno.ListarAnio();
            wAlumno.ListarMeses();
        }
        #region DATASET: MES(ALMUNOS), LISTARALUMNO, AÑOS, DISCIPLINA
        public DataSet Alumnos
        {
            set
            {
                CBMes.DataSource = value.Tables[0];
                CBMes.DisplayMember = "Mes";
                CBMes.ValueMember = "ID";
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
        public DataSet Disciplina
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
            }
        }        
        public DataSet ListarTaller { set => throw new NotImplementedException(); }
        public DataSet Carreras { set => throw new NotImplementedException(); }
        public DataSet Periodo { set => throw new NotImplementedException(); }
        public DataSet ListarProfesor { set => throw new NotImplementedException(); }
        public DataSet ObtenerUnDato { set => throw new NotImplementedException(); }
        public DataSet Promedio { set => throw new NotImplementedException(); }
        public CAlumno Alumno => throw new NotImplementedException();
        public CTalleres Taller => throw new NotImplementedException();
        public CProfesor Profesor => throw new NotImplementedException();
        #endregion

        #region BOTONES, MÉTODOS
        private void button18_Click(object sender, EventArgs e)
        {            
            wAlumno.MesLiberadas(CBMes.SelectedValue.ToString(), CBAnio.SelectedValue.ToString());
            cartas.Text = "Total de cartas: " + TBLGENERAL.RowCount;
            mesS = CBMes.Text.ToString();
            anio = CBAnio.SelectedValue.ToString();
        }
        private void TBLGENERAL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            wTalleres.TalleresAlumno(7, TBLGENERAL.CurrentRow.Cells[0].Value.ToString());          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mensaje("ad1", "Listo", "Generardo PDF");
                PDF();
            }
            catch (Exception)
            {
            }
        }

        public void PDF()
        {
            Document doc = new Document(PageSize.LETTER);
            string name = "Cartasgeneradas" + anio +" "+ mesS;
            string folder = @"C:\\CARTAS_DE_LIBERACIÓN ";
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

            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("logoUPT.png");

            img.ScaleToFit(125f, 60F);
            img.SetAbsolutePosition(70, 700);
            doc.Add(img);

            Paragraph UPT = new Paragraph("UNIVERSIDAD POLITÉCNICA DE TULANCINGO", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD));
            UPT.Alignment = Element.ALIGN_CENTER;

            Chunk mes = new Chunk("MES",FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL));

            Paragraph A = new Paragraph("ACTIVIDADES CULTURALES Y DEPORTIVAS", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD));
            A.Alignment = Element.ALIGN_CENTER;
            Paragraph Fecha = new Paragraph("TULANCINGO DE BRAVO HGO, " + DateTime.Now.Date.ToString());
            Fecha.Alignment = Element.ALIGN_CENTER;
            Paragraph Texto = new Paragraph("Cartas generadas en :  "+mesS +" "+anio, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL));
            Texto.Alignment = Element.ALIGN_CENTER;

            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph("                       "));
            doc.Add(UPT);
            doc.Add(A);
            doc.Add(new Paragraph("                       "));
            doc.Add(Fecha);
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph(Texto));
            doc.Add(new Paragraph("                       "));
            GenerarDocumento(doc);
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph("                       "));
            doc.AddCreationDate();
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph("                       "));
            doc.Add(new Paragraph("                       "));
            doc.Close();
            Process.Start(pathname);
        }
        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(TBLGENERAL.ColumnCount);

            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(TBLGENERAL);
            datatable.SetWidths(headerwidths);
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < TBLGENERAL.ColumnCount; i++)
            {
                PdfPCell cellF = new PdfPCell(new Phrase(TBLGENERAL.Columns[i].HeaderText));
                cellF.BackgroundColor = BaseColor.LIGHT_GRAY;
                datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                datatable.AddCell(cellF);
            }
            for (i = 0; i < TBLGENERAL.Rows.Count; i++)
            {
                for (j = 0; j < TBLGENERAL.Columns.Count; j++)
                {
                    if (TBLGENERAL[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(TBLGENERAL[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
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
        public void FormatoTabla(DataGridView Table)
        {//Da formato a las tabla de la aplicación
            Table.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10);
            Table.DefaultCellStyle.ForeColor = Color.Brown;
            Table.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 13);
            Table.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Table.ColumnHeadersDefaultCellStyle.BackColor = Color.Brown;
        }
        #endregion

        public void Mensaje(string imagen, string titulo, string texto)
        {
            Mensaje a = new Mensaje(imagen, titulo, texto);
            a.Show();
        }
    }
}
