using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TrabajosPracticosSIM.TP_1;

namespace TrabajosPracticosSIM.TP_4.InterfacesDeUsuario
{
    public partial class Frm_TP4_PuntoD : Form
    {


        public Frm_TP4_PuntoD()
        {
            InitializeComponent();
            grafico.MouseWheel += grafico_MouseWheel;
            grafico.ChartAreas[0].AxisX.Title = "Nro Simulación";
            grafico.ChartAreas[0].AxisY.Title = "Promedio Tiempo de Ensamble";
            PedirDatosGrafico();
        }

        private void PedirDatosGrafico()
        {
            ControladorTP4.GetInstance().OpcionPedirDatosGrafico(this);
        }

        public void LlenarGrafico(ArrayList ejeXGrafico, ArrayList ejeYGrafico)
        {

            grafico.Series[0].Points.Clear();
            var CA = grafico.ChartAreas.FirstOrDefault();

            CA.AxisX.ScaleView.Zoomable = true;
            CA.AxisY.ScaleView.Zoomable = true;

            CA.AxisX.IsMarginVisible = true;
            


            CA.AxisX.MajorTickMark.Enabled = false;
            CA.AxisY.MajorTickMark.Enabled = false;
            CA.AxisX.MinorTickMark.Enabled = false;
            CA.AxisY.MinorTickMark.Enabled = false;

            CA.AxisX.CustomLabels.Clear();
            CA.AxisX.IsLabelAutoFit = true;
            grafico.Series[0].IsValueShownAsLabel = false;
            if (ejeXGrafico.Count <= 20)
            {
                CA.AxisX.IsLabelAutoFit = false;
                grafico.Series[0].IsValueShownAsLabel = true;
                foreach (var item in ejeXGrafico)
                {
                    double itemX = Convert.ToDouble(item);
                    var label = new CustomLabel(itemX - 1, itemX + 1, itemX.ToString(), 0, LabelMarkStyle.LineSideMark);
                    CA.AxisX.CustomLabels.Add(label);
                }
            }
            

            grafico.Series[0].Points.DataBindXY(ejeXGrafico, ejeYGrafico);
        }
        private class ZoomFrame
        {
            public double XStart { get; set; }
            public double XFinish { get; set; }
            public double YStart { get; set; }
            public double YFinish { get; set; }
        }

        private readonly Stack<ZoomFrame> _zoomFrames = new Stack<ZoomFrame>();
        private void grafico_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0)
                {
                    if (0 < _zoomFrames.Count)
                    {
                        var frame = _zoomFrames.Pop();
                        if (_zoomFrames.Count == 0)
                        {
                            xAxis.ScaleView.ZoomReset();
                            yAxis.ScaleView.ZoomReset();
                        }
                        else
                        {
                            xAxis.ScaleView.Zoom(frame.XStart, frame.XFinish);
                            yAxis.ScaleView.Zoom(frame.YStart, frame.YFinish);
                        }
                    }
                }
                else if (e.Delta > 0)
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    _zoomFrames.Push(new ZoomFrame { XStart = xMin, XFinish = xMax, YStart = yMin, YFinish = yMax });

                    var posXStart = Utiles.RedondearDecimales(xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4, 2);
                    var posXFinish = Utiles.RedondearDecimales(xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4, 2);
                    var posYStart = Utiles.RedondearDecimales(yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4, 2);
                    var posYFinish = Utiles.RedondearDecimales(yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4 , 2);

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }
    }
}
