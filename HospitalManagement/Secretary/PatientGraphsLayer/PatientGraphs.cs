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
        public PatientGraphs()
        {
            InitializeComponent();
        }

        private void PatientGraphs_Load(object sender, EventArgs e)
        {
            string[] cmbItems = {"Grafik Verisini Seçiniz","Doktor'a Göre Hasta Sayısı", "Muayene Bölümüne Göre Hasta Sayısı" };
            dataComboBox.Items.AddRange(cmbItems);
            dataComboBox.SelectedIndex = 0;
        }
        private void BarPlot()
        {
            // generate some fake data
            double[] y = { 1, 2, 3, 9, 1, 15, 3, 7, 2 };
            string[] schools = { "A", "B", "C", "D", "E", "F", "G", "H", "J" };

            //generate pane
            var pane = zedGraphControl1.GraphPane;


            pane.XAxis.Scale.IsVisible = true;
            pane.YAxis.Scale.IsVisible = true;

            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;

            pane.XAxis.Scale.TextLabels = schools;
            pane.XAxis.Type = AxisType.Text;


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

            }
            else if (selectedIndex == 2)
            {

            }
            else
            {
                InfoMessage infoMessage = new InfoMessage("Grafik Verisi Seçmediniz!", "Bilgi");
                infoMessage.ShowDialog();
            }
        }
    }
}
