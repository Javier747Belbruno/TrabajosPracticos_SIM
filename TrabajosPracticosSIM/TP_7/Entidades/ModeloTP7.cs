using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_7.Entidades
{
    public class ModeloTP7
    {
        public LlegadasCamiones Llegadas { get; set; } = new LlegadasCamiones();
        public Silo S1 { get; set; } = new Silo();
        public Silo S2 { get; set; } = new Silo();
        public Silo S3 { get; set; } = new Silo();
        public Silo S4 { get; set; } = new Silo();

        
        #region Iniciales

        public double reloj { get; set; } = 0;
        public double reloj_anterior { get; set; } = 0;
        public string evento { get; set; } = EventosFabrica.Inicio;
        public int? nro_camion { get; set; } = null;
        public string silo_designado { get; set; } = "-";
        public double? tn_actuales_camion { get; set; } = null;

        #endregion
        #region Secundarias

        public string tubo_aspirador { get; set; } = "-";
        public string tubo_aspirador_anterior { get; set; } = "-";
        public int? nro_primer_camion_en_salir { get; set; } = null;
        public double? tn_primer_camion_en_salir { get; set; } = null;
        public Queue<int> cola_camiones { get; set; } = new Queue<int>();
        public Queue<double> cola_tn { get; set; } = new Queue<double>();
        public double? tiempo_cambio { get; set; } = 0.00;
        public string silo_para_suministro { get; set; } = Estados.S2;

        public List<Silo> ListaSilos { get; set; } = new List<Silo>();
        #endregion

        public ModeloTP7()
        {
            IniciarModelo();
        }

        private void IniciarModelo()
        {
            IniciarLlegadas();
            IniciarS1();
            IniciarS2();
            IniciarS3();
            IniciarS4();
            IniciarListaSilos();

        }
        private void IniciarLlegadas()
        {
            Llegadas.Distr = new Uniforme(5,9);
        }
        private void IniciarS1()
        {
            S1.Distr = new Uniforme(5, 6);
        }
        private void IniciarS2()
        {
            S2.Distr = new Uniforme(5, 6);
            S2.Estado = Estados.Suministrando;
            S2.Capacidad_actual = 20;
        }
        private void IniciarS3()
        {
            S3.Distr = new Uniforme(5, 6);
        }
        private void IniciarS4()
        {
            S4.Distr = new Uniforme(5, 6);
        }
        private void IniciarListaSilos()
        {
            ListaSilos.Add(S1);
            ListaSilos.Add(S2);
            ListaSilos.Add(S3);
            ListaSilos.Add(S4);
        }

        public void ResetearValores()
        {
            Llegadas = new LlegadasCamiones();
            S1 = new Silo();
            S2 = new Silo();
            S3 = new Silo();
            S4 = new Silo();
            reloj = 0;
            reloj_anterior = 0;
            evento = EventosFabrica.Inicio;
            nro_camion = null;
            silo_designado = "-";
            tn_actuales_camion = null;
            tubo_aspirador = "-";
            nro_primer_camion_en_salir = null;
            tn_primer_camion_en_salir = null;
            cola_camiones = new Queue<int>();
            cola_tn = new Queue<double>();
            tiempo_cambio = 0.00;
            silo_para_suministro = Estados.S2;
            IniciarModelo();
        }

        public void CalcularLlegada()
        {
            Llegadas.CalcularProxNroCamion(nro_camion);
            Llegadas.CalcularRandom(evento);
            Llegadas.CalcularTiempo();
            Llegadas.CalcularProxTiempo(reloj);
            Llegadas.CalcularCapacidadCamion();
        }

        public void CalcularReloj()
        {
            reloj_anterior = reloj;
            double hora = Math.Truncate(reloj) + 1;
            double prox = ProxTiempoMinimo();
            if (hora < prox)
                reloj = hora;
            else
                reloj = prox; 
        }

        public void CalcularNroCamion()
        {
            nro_camion = DeterminarNumeroCamion(evento);
        }

        private int? DeterminarNumeroCamion(string evento)
        {
            switch (evento)
            {
                case EventosFabrica.Llegada:
                    return Llegadas.Prox_Nro_Camion;
                case EventosFabrica.Hora:
                    return null;
                case EventosFabrica.Preparacion_Lista:
                    if (nro_primer_camion_en_salir.HasValue)
                        return nro_primer_camion_en_salir;
                    else
                        return null;
                case EventosFabrica.Fin_Descarga_S1:
                    return S1.Nro_Camion;
                case EventosFabrica.Silo_Lleno_S1:
                    return S1.Nro_Camion;
                case EventosFabrica.Fin_Descarga_S2:
                    return S2.Nro_Camion;
                case EventosFabrica.Silo_Lleno_S2:
                    return S2.Nro_Camion;
                case EventosFabrica.Fin_Descarga_S3:
                    return S3.Nro_Camion;
                case EventosFabrica.Silo_Lleno_S3:
                    return S3.Nro_Camion;
                case EventosFabrica.Fin_Descarga_S4:
                    return S4.Nro_Camion;
                case EventosFabrica.Silo_Lleno_S4:
                    return S4.Nro_Camion;
                default:
                    return nro_camion;
            }
        }

        public  void CalcularSiloDesignado()
        {
            if(evento==EventosFabrica.Llegada && (cola_camiones.Count > 0 || tubo_aspirador == "-"))
            {
                silo_designado = Estados.Espera;
            }
            else
            {
                if(evento == EventosFabrica.Hora || evento == EventosFabrica.Fin_Suministro_S1  
                    || evento == EventosFabrica.Fin_Suministro_S2 || evento == EventosFabrica.Fin_Suministro_S3 
                    || evento == EventosFabrica.Fin_Suministro_S4)
                {
                    silo_designado = "-";
                }
                else
                {
                    silo_designado = tubo_aspirador;
                }
            }
        }
        private double ProxTiempoMinimo()
        {
            List<double> proximos_tiempos = new List<double>();
            double? t1 = Llegadas.Tiempo_Prox;
            double? t2 = S1.Prox_Fin_Llenado_Silo;
            double? t3 = S1.Prox_Fin_Descarga;
            double? t4 = S1.Prox_Fin_Suministro;
            double? t5 = S2.Prox_Fin_Llenado_Silo;
            double? t6 = S2.Prox_Fin_Descarga;
            double? t7 = S2.Prox_Fin_Suministro;
            double? t8 = S3.Prox_Fin_Llenado_Silo;
            double? t9 = S3.Prox_Fin_Descarga;
            double? t10 = S3.Prox_Fin_Suministro;
            double? t11 = S4.Prox_Fin_Llenado_Silo;
            double? t12 = S4.Prox_Fin_Descarga;
            double? t13 = S4.Prox_Fin_Suministro;
            double? t14 = tiempo_cambio;

            if (t1.HasValue)
                proximos_tiempos.Add((double)t1);
            if (t2.HasValue)
                proximos_tiempos.Add((double)t2);
            if (t3.HasValue)
                proximos_tiempos.Add((double)t3);
            if (t4.HasValue)
                proximos_tiempos.Add((double)t4);
            if (t5.HasValue)
                proximos_tiempos.Add((double)t5);
            if (t6.HasValue)
                proximos_tiempos.Add((double)t6);
            if (t7.HasValue)
                proximos_tiempos.Add((double)t7);
            if (t8.HasValue)
                proximos_tiempos.Add((double)t8);
            if (t9.HasValue)
                proximos_tiempos.Add((double)t9);
            if (t10.HasValue)
                proximos_tiempos.Add((double)t10);
            if (t11.HasValue)
                proximos_tiempos.Add((double)t11);
            if (t12.HasValue)
                proximos_tiempos.Add((double)t12);
            if (t13.HasValue)
                proximos_tiempos.Add((double)t13);
            if (t14.HasValue)
                proximos_tiempos.Add((double)t14);
            proximos_tiempos.Sort();

            return proximos_tiempos.First();
        }

        public void CalcularEvento()
        {
            evento = DeterminarEvento(reloj);
        }
        private string DeterminarEvento(double reloj)
        {
            if (reloj == Math.Truncate(reloj) + 1)
                return EventosFabrica.Hora;
            if (reloj == Llegadas.Tiempo_Prox)
                return EventosFabrica.Llegada;
            if (reloj == S1.Prox_Fin_Llenado_Silo)
                return EventosFabrica.Silo_Lleno_S1;
            if (reloj == S1.Prox_Fin_Descarga)
                return EventosFabrica.Fin_Descarga_S1;
            if (reloj == S1.Prox_Fin_Suministro)
                return EventosFabrica.Fin_Suministro_S1;
            if (reloj == S2.Prox_Fin_Llenado_Silo)
                return EventosFabrica.Silo_Lleno_S2;
            if (reloj == S2.Prox_Fin_Descarga)
                return EventosFabrica.Fin_Descarga_S2;
            if (reloj == S2.Prox_Fin_Suministro)
                return EventosFabrica.Fin_Suministro_S2;
            if (reloj == S3.Prox_Fin_Llenado_Silo)
                return EventosFabrica.Silo_Lleno_S3;
            if (reloj == S3.Prox_Fin_Descarga)
                return EventosFabrica.Fin_Descarga_S3;
            if (reloj == S3.Prox_Fin_Suministro)
                return EventosFabrica.Fin_Suministro_S3;
            if (reloj == S4.Prox_Fin_Llenado_Silo)
                return EventosFabrica.Silo_Lleno_S4;
            if (reloj == S4.Prox_Fin_Descarga)
                return EventosFabrica.Fin_Descarga_S4;
            if (reloj == S4.Prox_Fin_Suministro)
                return EventosFabrica.Fin_Suministro_S4;
            if (reloj == tiempo_cambio)
                return EventosFabrica.Preparacion_Lista;
            return "x";
        }

        public void CalcularTnCamionActual()
        {
            tn_actuales_camion = DeterminarTnCamionActual(evento);
        }
        public double? DeterminarTnCamionActual(string evento)
        {
            switch (evento)
            {
                case EventosFabrica.Llegada:
                    return Llegadas.Capacidad_Camion;

                case EventosFabrica.Preparacion_Lista:
                    if (nro_camion.HasValue)
                    {
                        if (tn_primer_camion_en_salir.HasValue)
                        {
                            return tn_primer_camion_en_salir;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return tn_actuales_camion;
                    };

                case EventosFabrica.Fin_Descarga_S1:
                    return S1.Capacidad_Camion_Final;
                case EventosFabrica.Silo_Lleno_S1:
                    return S1.Capacidad_Camion_Final;
                case EventosFabrica.Fin_Descarga_S2:
                    return S2.Capacidad_Camion_Final;
                case EventosFabrica.Silo_Lleno_S2:
                    return S2.Capacidad_Camion_Final;
                case EventosFabrica.Fin_Descarga_S3:
                    return S3.Capacidad_Camion_Final;
                case EventosFabrica.Silo_Lleno_S3:
                    return S3.Capacidad_Camion_Final;
                case EventosFabrica.Fin_Descarga_S4:
                    return S4.Capacidad_Camion_Final;
                case EventosFabrica.Silo_Lleno_S4:
                    return S4.Capacidad_Camion_Final;
                default:
                    return null;
            }
        }

        public void CalcularTuboAspirador()
        {
            tubo_aspirador_anterior = tubo_aspirador;
            tubo_aspirador = DeterminarTuboAspirador(evento);
        }

        public string DeterminarTuboAspirador(string evento)
        {
            switch (evento)
            {

                case EventosFabrica.Preparacion_Lista:
                    if (S1.Estado == Estados.Disponible && S1.Capacidad_actual < 20)
                    {
                        return Estados.S1;
                    }
                    else
                    {
                        if (S2.Estado == Estados.Disponible && S2.Capacidad_actual < 20)
                        {
                            return Estados.S2;
                        }
                        else
                        {
                            if (S3.Estado == Estados.Disponible && S3.Capacidad_actual < 20)
                            {
                                return Estados.S3;
                            }
                            else
                            {
                                if (S4.Estado == Estados.Disponible && S4.Capacidad_actual < 20)
                                {
                                    return Estados.S4;
                                }
                                else
                                {
                                    return Estados.Espera;
                                }
                            }
                        }
                    }
                case EventosFabrica.Silo_Lleno_S1:
                    return "-";
                case EventosFabrica.Silo_Lleno_S2:
                    return "-";
                case EventosFabrica.Silo_Lleno_S3:
                    return "-";
                case EventosFabrica.Silo_Lleno_S4:
                    return "-";
                case EventosFabrica.Fin_Suministro_S1:
                    return "-";
                case EventosFabrica.Fin_Suministro_S2:
                    return "-";
                case EventosFabrica.Fin_Suministro_S3:
                    return "-";
                case EventosFabrica.Fin_Suministro_S4:
                    return "-";
                default:
                    return tubo_aspirador;
            }
        }

        public void DeterminarPrimeroColaCamion()
        {
            if (cola_camiones.Count > 0)
            {
                nro_primer_camion_en_salir = cola_camiones.Peek();
            }
            else
            {
                nro_primer_camion_en_salir = null;
            }
        }
        public void DeterminarPrimeroColaTn()
        {
            if (cola_tn.Count > 0)
            {
                tn_primer_camion_en_salir = cola_tn.Peek();
            }
            else
            {
                tn_primer_camion_en_salir = null;
            }
        }

        public void CalcularColaCamion()
        {
            if( ( (evento == EventosFabrica.Preparacion_Lista && !(tubo_aspirador==Estados.Espera) ) 
                || evento == EventosFabrica.Fin_Descarga_S1 || evento == EventosFabrica.Fin_Descarga_S2
                || evento == EventosFabrica.Fin_Descarga_S3 || evento == EventosFabrica.Fin_Descarga_S4) 
                && (cola_camiones.Count>0))
            {
                cola_camiones.Dequeue();
            }
            else
            {
                if(evento == EventosFabrica.Silo_Lleno_S1 || evento == EventosFabrica.Silo_Lleno_S2 
                    || evento == EventosFabrica.Silo_Lleno_S3 || evento == EventosFabrica.Silo_Lleno_S4 
                    || silo_designado == Estados.Espera)
                {
                    cola_camiones.Enqueue((int)nro_camion);
                }
            }
        }
        public void CalcularColaTn()
        {
            if (((evento == EventosFabrica.Preparacion_Lista && !(tubo_aspirador == Estados.Espera))
                || evento == EventosFabrica.Fin_Descarga_S1 || evento == EventosFabrica.Fin_Descarga_S2
                || evento == EventosFabrica.Fin_Descarga_S3 || evento == EventosFabrica.Fin_Descarga_S4)
                && (cola_tn.Count > 0))
            {
                cola_tn.Dequeue();
            }
            else
            {
                if (evento == EventosFabrica.Silo_Lleno_S1 || evento == EventosFabrica.Silo_Lleno_S2
                    || evento == EventosFabrica.Silo_Lleno_S3 || evento == EventosFabrica.Silo_Lleno_S4
                    || silo_designado == Estados.Espera)
                {
                    cola_tn.Enqueue((double)tn_actuales_camion);
                }
            }
        }

        public void CalcularTiempoCambio()
        {
            if (evento == EventosFabrica.Preparacion_Lista)
            {
                tiempo_cambio = null;
            }
            else
            {
                if(tubo_aspirador_anterior != tubo_aspirador)
                {
                    tiempo_cambio = Math.Round(reloj + (1 / 6),2);
                }
            }
        }

        public void CalcularSiloParaSuministrar()
        {
            if (evento == EventosFabrica.Fin_Suministro_S1 ||
                evento == EventosFabrica.Fin_Suministro_S2 ||
                evento == EventosFabrica.Fin_Suministro_S3 ||
                evento == EventosFabrica.Fin_Suministro_S4)
            {
                if(S1.Estado == Estados.Lleno)
                {
                    silo_para_suministro = Estados.S1;
                }
                else
                {
                    if (S2.Estado == Estados.Lleno)
                    {
                        silo_para_suministro = Estados.S2;
                    }
                    else
                    {
                        if (S3.Estado == Estados.Lleno)
                        {
                            silo_para_suministro = Estados.S3;
                        }
                        else
                        {
                            if (S1.Estado == Estados.Lleno)
                            {
                                silo_para_suministro = Estados.S4;
                            }
                            else
                            {
                                silo_para_suministro = "x";//Daria Error;
                            }
                        }
                    }
                }
            }
            else
            {
                silo_para_suministro = "-";
            }
        }

        public void CalcularSilos()
        {
            foreach (Silo s in ListaSilos)
            {
                /*s.CalcularCola(evento);
                s.CalcularEstado(evento);
                s.CalcularNroPedidoEnAtencion(evento, nro_pedido);*/
                s.CalcularRandom();
                /*s.CalcularTiempo();
                s.CalcularTiempoProx(reloj);*/
            }

        }

        public void AgregarFila(int i, ref DataTable dtGeneral)
        {
            string llegadasTiempo = Stringficar(Llegadas.Tiempo);
            string llegadasProxTiempo = Stringficar(Llegadas.Tiempo_Prox);

            string TiempoCambio = Stringficar(tiempo_cambio);

            string s1Capacidad_Camion_Inicial = Stringficar(S1.Capacidad_Camion_Inicial);
            string s1Tasa_de_Descarga = Stringficar(S1.Tasa_de_Descarga);
            string s1Tiempo_Fin_Llenado_Silo = Stringficar(S1.Tiempo_Fin_Llenado_Silo);
            string s1Prox_Fin_Llenado_Silo = Stringficar(S1.Prox_Fin_Llenado_Silo);
            string s1Tiempo_Fin_Descarga = Stringficar(S1.Tiempo_Fin_Descarga);
            string s1Prox_Fin_Descarga = Stringficar(S1.Prox_Fin_Descarga);
            string s1Capacidad_Camion_Final = Stringficar(S1.Capacidad_Camion_Final);
            string s1Prox_Fin_Suministro = Stringficar(S1.Prox_Fin_Suministro);

            string s2Capacidad_Camion_Inicial = Stringficar(S2.Capacidad_Camion_Inicial);
            string s2Tasa_de_Descarga = Stringficar(S2.Tasa_de_Descarga);
            string s2Tiempo_Fin_Llenado_Silo = Stringficar(S2.Tiempo_Fin_Llenado_Silo);
            string s2Prox_Fin_Llenado_Silo = Stringficar(S2.Prox_Fin_Llenado_Silo);
            string s2Tiempo_Fin_Descarga = Stringficar(S2.Tiempo_Fin_Descarga);
            string s2Prox_Fin_Descarga = Stringficar(S2.Prox_Fin_Descarga);
            string s2Capacidad_Camion_Final = Stringficar(S2.Capacidad_Camion_Final);
            string s2Prox_Fin_Suministro = Stringficar(S2.Prox_Fin_Suministro);

            string s3Capacidad_Camion_Inicial = Stringficar(S3.Capacidad_Camion_Inicial);
            string s3Tasa_de_Descarga = Stringficar(S3.Tasa_de_Descarga);
            string s3Tiempo_Fin_Llenado_Silo = Stringficar(S3.Tiempo_Fin_Llenado_Silo);
            string s3Prox_Fin_Llenado_Silo = Stringficar(S3.Prox_Fin_Llenado_Silo);
            string s3Tiempo_Fin_Descarga = Stringficar(S3.Tiempo_Fin_Descarga);
            string s3Prox_Fin_Descarga = Stringficar(S3.Prox_Fin_Descarga);
            string s3Capacidad_Camion_Final = Stringficar(S3.Capacidad_Camion_Final);
            string s3Prox_Fin_Suministro = Stringficar(S3.Prox_Fin_Suministro);

            string s4Capacidad_Camion_Inicial = Stringficar(S4.Capacidad_Camion_Inicial);
            string s4Tasa_de_Descarga = Stringficar(S4.Tasa_de_Descarga);
            string s4Tiempo_Fin_Llenado_Silo = Stringficar(S4.Tiempo_Fin_Llenado_Silo);
            string s4Prox_Fin_Llenado_Silo = Stringficar(S4.Prox_Fin_Llenado_Silo);
            string s4Tiempo_Fin_Descarga = Stringficar(S4.Tiempo_Fin_Descarga);
            string s4Prox_Fin_Descarga = Stringficar(S4.Prox_Fin_Descarga);
            string s4Capacidad_Camion_Final = Stringficar(S4.Capacidad_Camion_Final);
            string s4Prox_Fin_Suministro = Stringficar(S4.Prox_Fin_Suministro);

            dtGeneral.Rows.Add(i, reloj.ToString("0.00"), evento, nro_camion,
                                silo_designado,tn_actuales_camion,
                                Llegadas.Prox_Nro_Camion, llegadasTiempo, llegadasProxTiempo,
                                Llegadas.Capacidad_Camion,
                                tubo_aspirador,
                                nro_primer_camion_en_salir,
                                tn_primer_camion_en_salir,
                                cola_camiones.Count,
                                TiempoCambio,
                                silo_para_suministro,
                                S1.Capacidad_actual,
                                S1.Estado,
                                S1.Nro_Camion,
                                s1Capacidad_Camion_Inicial,
                                s1Tasa_de_Descarga,
                                s1Tiempo_Fin_Llenado_Silo,
                                s1Prox_Fin_Llenado_Silo,
                                s1Tiempo_Fin_Descarga,
                                s1Prox_Fin_Descarga,
                                s1Capacidad_Camion_Final,
                                s1Prox_Fin_Suministro,
                                S2.Capacidad_actual,
                                S2.Estado,
                                S2.Nro_Camion,
                                s2Capacidad_Camion_Inicial,
                                s2Tasa_de_Descarga,
                                s2Tiempo_Fin_Llenado_Silo,
                                s2Prox_Fin_Llenado_Silo,
                                s2Tiempo_Fin_Descarga,
                                s2Prox_Fin_Descarga,
                                s2Capacidad_Camion_Final,
                                s2Prox_Fin_Suministro,
                                S3.Capacidad_actual,
                                S3.Estado,
                                S3.Nro_Camion,
                                s3Capacidad_Camion_Inicial,
                                s3Tasa_de_Descarga,
                                s3Tiempo_Fin_Llenado_Silo,
                                s3Prox_Fin_Llenado_Silo,
                                s3Tiempo_Fin_Descarga,
                                s3Prox_Fin_Descarga,
                                s3Capacidad_Camion_Final,
                                s3Prox_Fin_Suministro,
                                S4.Capacidad_actual,
                                S4.Estado,
                                S4.Nro_Camion,
                                s4Capacidad_Camion_Inicial,
                                s4Tasa_de_Descarga,
                                s4Tiempo_Fin_Llenado_Silo,
                                s4Prox_Fin_Llenado_Silo,
                                s4Tiempo_Fin_Descarga,
                                s4Prox_Fin_Descarga,
                                s4Capacidad_Camion_Final,
                                s4Prox_Fin_Suministro);
        }



        private string Stringficar(double? nroconmuchosdecimales)
        {
            if (nroconmuchosdecimales.HasValue)
                return nroconmuchosdecimales.Value.ToString("0.00");
            return "";
        }

        

    }
}
