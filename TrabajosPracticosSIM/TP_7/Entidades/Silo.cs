using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_7.Entidades
{
    public class Silo
    {
        Random r = new Random();
        public string Nombre { get; set; } = "-";
        public string Fin_Descarga_Propio { get; set; } = "-";
        public string Fin_Lleno_Silo_Propio { get; set; } = "-";
        public string Fin_Suministro_Propio { get; set; } = "-";
        public string Fin_Suministro_Propio_2 { get; set; } = "-";
        public string Fin_Suministro_Propio_3 { get; set; } = "-";
        public string Fin_Suministro_Propio_4 { get; set; } = "-";
        public double Capacidad_actual { get; set; } = 0;
        public double Capacidad_actual_anterior { get; set; } = 0;
        public string Estado { get; set; } = Estados.Disponible;
        public string Estado_Anterior { get; set; } = "-";
        public int? Nro_Camion { get; set; } = null;
        public int? Nro_Camion_Anterior { get; set; } = null;
        public double? Capacidad_Camion_Inicial { get; set; } = null;
        public double? Tasa_de_Descarga { get; set; } = null;
        public double? Capacidad_Camion_Final { get; set; } = null;
        public IDistribucion Distr { get; set; }
        public Queue<double> Random { get; set; } = new Queue<double>();
        public double? Tiempo_Fin_Llenado_Silo { get; set; } = null;
        public double? Prox_Fin_Llenado_Silo { get; set; } = null;
        public double? Tiempo_Fin_Descarga { get; set; } = null;
        public double? Prox_Fin_Descarga { get; set; } = null;
        public double? Prox_Fin_Suministro { get; set; } = null;

        public void CalcularRandom()
        {
        }

        public void CalcularCapacidadActual(double reloj,double reloj_anterior,string evento)
        {
            Capacidad_actual_anterior = Capacidad_actual;
            if (Tasa_de_Descarga.HasValue)
            {
                Capacidad_actual = Math.Round(Capacidad_actual, 2)
                                     + Math.Round(((reloj - reloj_anterior)* (double)Tasa_de_Descarga), 2);
            }
            else
            {
                if(evento == EventosFabrica.Hora && Estado == Estados.Suministrando)
                {
                    Capacidad_actual = Capacidad_actual - 0.5;
                }
            }
        }

        public void CalcularEstado(string evento, string silo_designado, string tubo_aspirador, int? nro_primer_camion_en_salir, int cantidad_cola_anterior, string silo_para_suministro)
        {
            Estado_Anterior = Estado;
            switch (evento)
            {
                case EventosFabrica.Llegada:
                    if (silo_designado == Nombre)
                    {
                        Estado = Estados.Ocupado;
                    }
                    else
                    {
                        if (Estado == Estados.Suministrando && Capacidad_actual != 0)
                        {
                            Estado = Estados.Suministrando;
                        }
                    }
                    break;

                case var v when v == Fin_Descarga_Propio:
                    if (Capacidad_actual >= 20)
                    {
                        Estado = Estados.Lleno;
                    }
                    else 
                    { 
                        if(cantidad_cola_anterior > 0)
                        {
                            Estado = Estados.Ocupado;
                        }
                        else
                        {
                            Estado = Estados.Disponible;
                        }
                    }
                    break;
                case var v when v == Fin_Lleno_Silo_Propio:
                    if (Capacidad_actual >= 20)
                    {
                        Estado = Estados.Lleno;
                    }
                    else
                    {
                        Estado = Estados.Disponible;
                    }
                    break;
                case EventosFabrica.Hora:
                    if (Capacidad_actual_anterior != 0 && Estado == Estados.Suministrando)
                    {
                        Estado = Estados.Suministrando;
                    }
                    break;
                case EventosFabrica.Preparacion_Lista:
                    if(tubo_aspirador==Nombre && nro_primer_camion_en_salir.HasValue)
                    {
                        Estado = Estados.Ocupado;
                    }
                    break;
                case var v when v == Fin_Suministro_Propio:
                    if (silo_para_suministro == Nombre)
                    {
                        Estado = Estados.Suministrando;
                    }
                    else
                    {
                        Estado = Estados.Disponible;
                    }
                    break;
                case var v when v == Fin_Suministro_Propio_2:
                    if (silo_para_suministro == Nombre)
                    {
                        Estado = Estados.Suministrando;
                    }
                    break;
                case var v when v == Fin_Suministro_Propio_3:
                    if (silo_para_suministro == Nombre)
                    {
                        Estado = Estados.Suministrando;
                    }
                    break;
                case var v when v == Fin_Suministro_Propio_4:
                    if (silo_para_suministro == Nombre)
                    {
                        Estado = Estados.Suministrando;
                    }
                    break;
                default:
                    Estado = Estado;
                    break;
            }

        }

        public void CalcularNroCamion(string evento, int? nro_camion, string silo_designado, string tubo_aspirador, int? nro_primer_camion_en_salir, int cantidad_cola_anterior)
        {
            Nro_Camion_Anterior = Nro_Camion;
            if (evento == EventosFabrica.Llegada && silo_designado == Nombre)
            {
                Nro_Camion = nro_camion;
            }
            else
            {
                if (evento == EventosFabrica.Preparacion_Lista
                      && tubo_aspirador == Nombre && cantidad_cola_anterior > 0)
                {
                    Nro_Camion = nro_primer_camion_en_salir;
                }
                else
                {
                    if (Estado == Estados.Ocupado)
                    {
                        if (evento == Fin_Descarga_Propio && cantidad_cola_anterior > 0)
                        {
                            Nro_Camion = nro_primer_camion_en_salir;
                        }
                        else
                        {
                            Nro_Camion = Nro_Camion;
                        }
                    }
                    else
                    {
                        Nro_Camion = null;
                    }
                }
            }
        }

        public void CalcularCapacidadCamionInicial(string evento, string silo_designado, double? tn_actuales_camion, string tubo_aspirador, double? tn_primer_camion_en_salir, int cantidad_cola_anterior)
        {
            if (evento == EventosFabrica.Llegada && silo_designado == Nombre)
            {
                Capacidad_Camion_Inicial = tn_actuales_camion;
            }
            else
            {
                if (evento == EventosFabrica.Preparacion_Lista
                      && tubo_aspirador == Nombre && cantidad_cola_anterior > 0)
                {
                    Capacidad_Camion_Inicial = tn_primer_camion_en_salir;
                }
                else
                {
                    if (Estado == Estados.Ocupado)
                    {
                        if (evento == Fin_Descarga_Propio && cantidad_cola_anterior > 0)
                        {
                            Capacidad_Camion_Inicial = tn_primer_camion_en_salir;
                        }
                        else
                        {
                            Capacidad_Camion_Inicial = Capacidad_Camion_Inicial;
                        }
                    }
                    else
                    {
                        Capacidad_Camion_Inicial = null;
                    }
                }
            }

        }

        public void CalcularTasaDeDescarga()
        {
            if(Estado == Estados.Ocupado)
            {
                if(Nro_Camion_Anterior != Nro_Camion)
                {
                    double r1 = r.NextDouble();
                    Random.Enqueue(r1);
                    if (Distr.GetType().Name == "Normal")
                    {
                        double r2 = r.NextDouble();
                        Random.Enqueue(r2);
                    }
                    Tasa_de_Descarga = Math.Round(Distr.DevolverUnaVariableAleatoria(Random),2);
                }
                else
                {
                    Tasa_de_Descarga = Tasa_de_Descarga;
                }
            }
            else
            {
                Tasa_de_Descarga = null;
            }
        }

        public void CalcularTiempoFinLlenadoSilo()
        {
            if((20-Capacidad_actual)<Capacidad_Camion_Inicial &&
                     Nro_Camion_Anterior != Nro_Camion &&
                         Nro_Camion.HasValue)
            {
                Tiempo_Fin_Llenado_Silo = (20 - Capacidad_actual) / Tasa_de_Descarga;
            }
            else
            {
                Tiempo_Fin_Llenado_Silo = null;
            }
        }

        public void CalcularProxFinLlenadoSilo(double reloj, string evento)
        {
            if(evento == Fin_Lleno_Silo_Propio)
            {
                Prox_Fin_Llenado_Silo = null;
            }
            else
            {
                if (Tiempo_Fin_Llenado_Silo.HasValue)
                {
                    Prox_Fin_Llenado_Silo = Tiempo_Fin_Llenado_Silo + reloj;
                }
            }
        }

        public void CalcularTiempoFinDescarga()
        {
            if ((20 - Capacidad_actual) >= Capacidad_Camion_Inicial &&
                     Nro_Camion_Anterior != Nro_Camion &&
                         Nro_Camion.HasValue)
            {
                Tiempo_Fin_Descarga = Capacidad_Camion_Inicial / Tasa_de_Descarga;
            }
            else
            {
                Tiempo_Fin_Descarga = null;
            }
        }

        public void CalcularProxFinDescarga(double reloj)
        {
            if (Tiempo_Fin_Descarga.HasValue)
            {
                Prox_Fin_Descarga = Tiempo_Fin_Descarga + reloj;
            }
            else
            {
                if(Nro_Camion_Anterior!= Nro_Camion)
                {
                    Prox_Fin_Descarga = null;
                }
            }
            
        }

        public void CalcularCapacidadCamionFinal()
        {
            if (Tiempo_Fin_Descarga.HasValue)
            {
                Capacidad_Camion_Final = 0;
            }
            else
            {
                if (Tiempo_Fin_Llenado_Silo.HasValue)
                {
                    Capacidad_Camion_Final = Capacidad_Camion_Inicial - (20 - Capacidad_actual);
                }
                else
                {
                    if(Prox_Fin_Descarga.HasValue || Prox_Fin_Llenado_Silo.HasValue)
                    {
                        Capacidad_Camion_Final = Capacidad_Camion_Final;
                    }
                    else
                    {
                        Capacidad_Camion_Final = null;
                    }
                }
            }
        }

        public void CalcularTiempoFinSuministro(double reloj)
        {
            if (Estado == Estados.Suministrando && Math.Round(Capacidad_actual, 2) == 0)
            {
                Prox_Fin_Suministro = reloj;
            }
            else
            {
                Prox_Fin_Suministro = null;
            }
        }
    }
}
