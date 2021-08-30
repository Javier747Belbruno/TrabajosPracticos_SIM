using MathNet.Numerics.Distributions;
using TrabajosPracticosSIM.TP_1;

namespace TrabajosPracticosSIM.TP_3.Entidades
{
    public class PruebaDeChi
    {
        private double chi_calculado;
        private double alfa;
        private string distr_seleccionada;
        private int cant_intervalos;
        private int grados_de_libertad;
        private double chi_tabulado;
        private string mensaje;


        public PruebaDeChi(string distr_seleccionada,double chi_calculado, double alfa, int cant_intervalos)
        {
            this.distr_seleccionada = distr_seleccionada;
            this.chi_calculado = Utiles.RedondearDecimales(chi_calculado,2);
            this.alfa = alfa;
            this.cant_intervalos = cant_intervalos;
        }
        
        public void calcularPrueba()
        {
            CalcularGradosDeLibertad();
            CalcularChiTabulado();
            CalcularRespuesta();
        }

        private void CalcularGradosDeLibertad()
        {
            switch (distr_seleccionada)
            {
                case "Uniforme":
                    grados_de_libertad =  cant_intervalos - 1;
                    break;
                case "Exponencial":
                    grados_de_libertad = cant_intervalos - 1 - 1;
                    break;
                case "Poisson":
                    grados_de_libertad = cant_intervalos - 1 - 1;
                    break;
                case "Normal":
                    grados_de_libertad = cant_intervalos - 1 - 2;
                    break;
                default:
                    grados_de_libertad = -1;
                    break;
            }

        }

        private void CalcularChiTabulado()
        {
            ChiSquared ch = new ChiSquared(grados_de_libertad);
            chi_tabulado = Utiles.RedondearDecimales(ch.InverseCumulativeDistribution(1 - alfa),2);
        }

        private void CalcularRespuesta()
        {
            if (chi_calculado <= chi_tabulado)
            {
                mensaje =  "Dado que el chi calculado es menor o igual al chi por tabla NO se puede rechazar la hipótesis"
                    + " de que la muestra proviene de la distribución de probabilidad seleccionada";
            }
            else {
                mensaje = "Dado que el chi calculado es mayor al chi por tabla se puede rechazar la hipótesis"
                   + " de que la muestra proviene de la distribución de probabilidad seleccionada";
            }
        }

        public int getGDL()
        {
            return grados_de_libertad;
        }
        public double getChi_tabulado()
        {
            return chi_tabulado;
        }
        public string getMensaje()
        {
            return mensaje;
        }

    }
}
