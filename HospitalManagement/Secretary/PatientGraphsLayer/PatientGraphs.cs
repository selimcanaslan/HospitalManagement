using BusinessLayer;
using HospitalManagement.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace HospitalManagement.Secretary.PatientGraphsLayer
{
    public partial class PatientGraphs : Form
    {
        private BlSecretary blSecretary;
        public PatientGraphs()
        {
            InitializeComponent();
            blSecretary = new BlSecretary();
        }

        private void PatientGraphs_Load(object sender, EventArgs e)
        {
            string[] cmbItems = { "Grafik Verisini Seçiniz", "Doktor'a Göre Hasta Sayısı", "Muayene Bölümüne Göre Hasta Sayısı" };
            dataComboBox.Items.AddRange(cmbItems);
            dataComboBox.SelectedIndex = 0;
        }
        private void Plot(double[] numericData, string[] textData, string xLabelText, string yLabelText, string titleText)
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            double[] y = numericData;
            string[] names = textData;

            //generate pane
            var pane = zedGraphControl1.GraphPane;


            pane.XAxis.Scale.IsVisible = true;
            pane.YAxis.Scale.IsVisible = true;

            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;

            pane.XAxis.Scale.TextLabels = names;
            pane.XAxis.Type = AxisType.Text;

            pane.XAxis.Title.Text = xLabelText;
            pane.YAxis.Title.Text = yLabelText;
            pane.Title.Text = titleText;


            //var pointsCurve;

            LineItem pointsCurve = pane.AddCurve("", null, y, Color.Black);
            pointsCurve.Line.IsVisible = true;
            pointsCurve.Line.Width = 3.0F;
            //Create your own scale of colors.

            pointsCurve.Symbol.Fill = new Fill(new Color[] { Color.Blue, Color.Green, Color.Red });
            pointsCurve.Symbol.Fill.Type = FillType.Solid;
            pointsCurve.Symbol.Type = SymbolType.Circle;
            pointsCurve.Symbol.Border.IsVisible = true;



            pane.AxisChange();
            zedGraphControl1.Refresh();
            this.Controls.Add(zedGraphControl1);
        }

        private void showGraph_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataComboBox.SelectedIndex;
            if (selectedIndex == 1)
            {
                List<double> countsList = new List<double>();
                List<string> nameList = new List<string>();
                double[] countsArray;
                string[] nameArray;
                DataTable data = blSecretary.FetchPatientCountGroupedByDoctor();
                foreach (DataRow row in data.Rows)
                {
                    countsList.Add(Int16.Parse(row["hasta_sayisi"].ToString()));
                    DataTable nameDt = blSecretary.fetchDoctorByGivenTcNo(row["doctor_tc_no"].ToString());
                    string name = nameDt.Rows[0]["doctor_name"].ToString() + " " + nameDt.Rows[0]["doctor_surname"].ToString();
                    nameList.Add(name);
                }
                countsArray = countsList.ToArray();
                nameArray = nameList.ToArray();
                Plot(countsArray, nameArray, "Doktor Adı", "Hasta Sayısı", "Doktor Başına Hasta Sayısı");
            }
            else if (selectedIndex == 2)
            {
                List<double> countsList = new List<double>();
                List<string> sectionList = new List<string>();
                double[] countsArray;
                string[] sectionArray;
                DataTable data = blSecretary.FetchPatientCountGroupedBySection();
                foreach (DataRow row in data.Rows)
                {
                    countsList.Add(Int16.Parse(row["hasta_sayisi"].ToString()));
                    sectionList.Add(row["section"].ToString());
                }
                countsArray = countsList.ToArray();
                sectionArray = sectionList.ToArray();
                Plot(countsArray, sectionArray, "Bölüm Adı", "Hasta Sayısı", "Bölüm Başına Hasta Sayısı");

            }
            else
            {
                InfoMessage infoMessage = new InfoMessage("Grafik Verisi Seçmediniz!", "Bilgi");
                infoMessage.ShowDialog();
            }
        }
    }
}
