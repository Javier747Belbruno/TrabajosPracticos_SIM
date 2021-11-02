using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TrabajosPracticosSIM.TP_1;

namespace TrabajosPracticosSIM.TP_6.InterfacesDeUsuario
{
    public partial class Frm_TP6_GraficoTipoT : Form
    {

        public Frm_TP6_GraficoTipoT(int tipo_grafico)
        {
            InitializeComponent();
            grafico.MouseWheel += grafico_MouseWheel;
            PedirDatosGrafico(tipo_grafico);
        }

        private void PedirDatosGrafico(int valorgrafico)
        {
            try
            {
                ControladorTP6.GetInstance().OpcionPedirDatosGraficoTipoT(this, valorgrafico);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LlenarGrafico(int valorgrafico, ArrayList ejeXEuler, ArrayList ejeYEuler, ArrayList ejeXRK, ArrayList ejeYRK)
        {
            switch (valorgrafico)
            {
                case 1:
                    grafico.Titles[0].Text = "Punto B - X1 en función de t";
                    grafico.ChartAreas[0].AxisX.Title = "Tiempo";
                    grafico.ChartAreas[0].AxisY.Title = "X1";
                    break;
                case 2:
                    grafico.Titles[0].Text = "Punto B - X2 en función de t";
                    grafico.ChartAreas[0].AxisX.Title = "Tiempo";
                    grafico.ChartAreas[0].AxisY.Title = "X2";
                    break;
                case 3:
                    grafico.Titles[0].Text = "Punto B - X'2 en función de t";
                    grafico.ChartAreas[0].AxisX.Title = "Tiempo";
                    grafico.ChartAreas[0].AxisY.Title = "X'2";
                    break;
                case 4:
                    grafico.Titles[0].Text = "Punto C - X'2 en función de X1";
                    grafico.ChartAreas[0].AxisX.Title = "X1";
                    grafico.ChartAreas[0].AxisY.Title = "X'2";
                    break;
                case 5:
                    grafico.Titles[0].Text = "Punto D - X2 en función de X1";
                    grafico.ChartAreas[0].AxisX.Title = "X1";
                    grafico.ChartAreas[0].AxisY.Title = "X2";
                    break;
                case 6:
                    grafico.Titles[0].Text = "Punto E - X'2 en función de X2";
                    grafico.ChartAreas[0].AxisX.Title = "X2";
                    grafico.ChartAreas[0].AxisY.Title = "X'2";
                    break;
                default:
                    break;
            }

            
            grafico.Series[0].Points.Clear();
            grafico.Series[1].Points.Clear();
            var CA = grafico.ChartAreas.FirstOrDefault();
            CA.AxisX.ScaleView.Zoomable = true;
            CA.AxisY.ScaleView.Zoomable = true;
            CA.AxisX.IsMarginVisible = true;
            

            if(ejeXEuler != null && ejeYEuler != null)
            {
                grafico.Series[0].Points.DataBindXY(ejeXEuler, ejeYEuler);
            }
            if (ejeXRK != null && ejeYRK != null)
            {
                grafico.Series[1].Points.DataBindXY(ejeXRK, ejeYRK);
            }


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
                            xAxis.ScaleView.Zoom(Utiles.RedondearDecimales(frame.XStart, 2), Utiles.RedondearDecimales(frame.XFinish, 2));
                            yAxis.ScaleView.Zoom(Utiles.RedondearDecimales(frame.YStart, 2), Utiles.RedondearDecimales(frame.YFinish, 2));
                        }
                    }
                }
                else if (e.Delta > 0)
                {
                    var xMin = Utiles.RedondearDecimales(xAxis.ScaleView.ViewMinimum, 2);
                    var xMax = Utiles.RedondearDecimales(xAxis.ScaleView.ViewMaximum, 2);
                    var yMin = Utiles.RedondearDecimales(yAxis.ScaleView.ViewMinimum, 2);
                    var yMax = Utiles.RedondearDecimales(yAxis.ScaleView.ViewMaximum, 2);

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
