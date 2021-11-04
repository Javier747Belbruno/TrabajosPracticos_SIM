using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TrabajosPracticosSIM.TP_1;

namespace TrabajosPracticosSIM.TP_6.InterfacesDeUsuario
{
    public partial class Frm_TP6_GraficoTipo3Series : Form
    {

        public Frm_TP6_GraficoTipo3Series(int tipo_grafico)
        {
            InitializeComponent();
            grafico.MouseWheel += grafico_MouseWheel;
            PedirDatosGrafico(tipo_grafico);
        }

        private void PedirDatosGrafico(int valorgrafico)
        {
            try
            {
                ControladorTP6.GetInstance().OpcionPedirDatosGraficoTipo3Series(this, valorgrafico);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LlenarGrafico(int valorgrafico, ArrayList ejeX, ArrayList ejeY1, ArrayList ejeY2, ArrayList ejeY3)
        {
            switch (valorgrafico)
            {
                case 1:
                    grafico.Titles[0].Text = "Punto B - X'',X',X en función de t (RK)";
                    grafico.ChartAreas[0].AxisX.Title = "t";
                    grafico.ChartAreas[0].AxisY.Title = " X'',X',X";
                    break;
                case 2:
                    grafico.Titles[0].Text = "Punto B - X'',X',X en función de t (Euler)";
                    grafico.ChartAreas[0].AxisX.Title = "t";
                    grafico.ChartAreas[0].AxisY.Title = " X'',X',X";
                    break;
                default:
                    break;
            }

            
            grafico.Series[0].Points.Clear();
            grafico.Series[1].Points.Clear();
            grafico.Series[2].Points.Clear();
            var CA = grafico.ChartAreas.FirstOrDefault();
            CA.AxisX.ScaleView.Zoomable = true;
            CA.AxisY.ScaleView.Zoomable = true;
            CA.AxisX.IsMarginVisible = true;
            

            if(ejeX != null && ejeY1 != null)
            {
                grafico.Series[0].Points.DataBindXY(ejeX, ejeY1);
            }
            if (ejeX != null && ejeY2 != null)
            {
                grafico.Series[1].Points.DataBindXY(ejeX, ejeY2);
            }
            if (ejeX != null && ejeY3 != null)
            {
                grafico.Series[2].Points.DataBindXY(ejeX, ejeY3);
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
