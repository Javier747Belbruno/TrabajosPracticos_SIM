using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_5.Entidades;
using TrabajosPracticosSIM.TP_5.InterfacesDeUsuario;

namespace TrabajosPracticosSIM.TP_5
{
    public class ControladorTP5 : ApplicationContext
    {
        //Instancia Unica - Patron Singleton
        private static readonly ControladorTP5 _instance = new ControladorTP5();
        //Lista de Vistas / Pantallas que controla el ControladorTP5
        private List<Form> Views = new List<Form>();


        //MODELO
        Modelo modelo = new Modelo();
        //TABLA GENERAL
        DataTable dtGeneral = new DataTable();

        //Constructor Privado.
        private ControladorTP5()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        // Devolver instancia estática única.
        public static ControladorTP5 GetInstance() { return _instance; }

        public void Start()
        {
            IniciarFuncionalidad();
            Application.Run(this);
        }

        public void IniciarFuncionalidad()
        {
            HabilitarPantallaPrincipal();
            InicializarColumnasTablas();
        }

        public void HabilitarPantallaPrincipal()
        {
            CreateView(new Frm_TP5_Principal());
        }
        //Crear una ventana
        public void CreateView(Form frm)
        {
            //Pregunto si ya existe este Tipo de Pantalla, si no existe la creo.
            bool EstaRepetidaLaVista = false;
            foreach (var v in Views)
            {
                if (frm.GetType() == v.GetType())
                    EstaRepetidaLaVista = true;
            }
            if (!EstaRepetidaLaVista)
            {
                Views.Add(frm);
                frm.FormClosed += FormClosed;
                frm.Show();
            }
        }

        public void OpcionIniciarSimulacion(Frm_TP5_PantallaSimulacion form, int cant_sim, int desde, int hasta, int param_punto_11)
        {
            //Dejar Lista Tablas de Datos
            LimpiarTableDatas();
            LimpiarModelo();
            //
            #region CREACION E INICIALIZACION DE VARIABLES
            #region Definiciones

            double reloj = 0;
            double reloj_anterior = 0;
            string evento = Evento.Inicio;
            int? nro_pedido = null;
            #endregion

            
            #region Estadisticas

            int pedidos_realizados = 0;
            int pedidos_realizados_anterior = 0;
            int? nro_pedido_listo = null;
            double? tiempo_ensamble = null;
            //q de queue
            Queue<double> q_tiempos_llegada_pedido = new Queue<double>();
            Queue<double> q_tiempos_act1 = new Queue<double>();
            Queue<double> q_tiempos_act2 = new Queue<double>();
            Queue<double> q_tiempos_act3 = new Queue<double>();
            Queue<double> q_tiempos_act4 = new Queue<double>();
            Queue<double> q_tiempos_act5 = new Queue<double>();
            //e de estadisticas para diferenciarlos de las definiciones
            double? e_t_llegada_pedido = null;
            double? e_t_a1 = null;
            double? e_t_a2 = null;
            double? e_t_a3 = null;
            double? e_t_a4 = null;
            double? e_t_a5 = null;

            //Caminos
            double? camino1 = null;
            double? camino2 = null;
            double? camino3 = null;

            #endregion
            #region Punto 2

            double prom_tiempo_ensamble = 0;

            #endregion
            #region Punto 3

            int p3_pedidos_solicitados = 0;
            double p3_proporcion_PR_PS = 0;

            #endregion
            #region Punto 7

            int p7_pedidos_en_sist = 0;
            double p7_prom_pedidos_en_sist = 0;

            #endregion
            #region Punto 10

            double p10_reloj = 0;
            double p10_reloj_anterior = 0;
            int p10_nro_hora = 0;
            int p10_nro_hora_anterior = 0;
            int p10_contador = 0;
            int p10_contador_anterior = 0;
            double p10_prom_ensambles = 0;

            #endregion
            #region Punto 11

            int? p11_contador_mayor_igual = null;
            double p11_probabilidad = 0;

            #endregion
            #region Punto 13

            string p13_camino_critico = "-";
            double p13_a1 = 0;
            double p13_a2 = 0;
            double p13_a3 = 0;
            double p13_a4 = 0;
            double p13_a5 = 0;

            #endregion

            #endregion
            #region SIMULACION
            for (int i = 1; i <= cant_sim; i++)
            {
                //Primera vuelta
                if (i == 1)
                {
                    modelo.Llegadas.CalcularProxNroPedido(nro_pedido);
                    modelo.Llegadas.CalcularRandom(evento);
                    modelo.Llegadas.CalcularTiempo();
                    modelo.Llegadas.CalcularProxTiempo(reloj);
                    q_tiempos_llegada_pedido.Enqueue((double)modelo.Llegadas.Tiempo_Prox);
                    //Grabar Fila
                    AgregarFila(i, reloj, evento, nro_pedido, pedidos_realizados, nro_pedido_listo, e_t_llegada_pedido, e_t_a1, e_t_a2,
                                e_t_a3, e_t_a4, e_t_a5, camino1, camino2, camino3, tiempo_ensamble, prom_tiempo_ensamble, p3_pedidos_solicitados,
                                p3_proporcion_PR_PS, p7_pedidos_en_sist, p7_prom_pedidos_en_sist, p10_reloj, p10_nro_hora, p10_contador,
                                p10_prom_ensambles, p11_contador_mayor_igual, p11_probabilidad, p13_camino_critico,
                                p13_a1, p13_a2, p13_a3, p13_a4, p13_a5);
                    //Continuar con la segunda vuelta
                    continue;
                }
                reloj_anterior = reloj;
                reloj = ProxTiempoMinimo();

                evento = DeterminarEvento(reloj);

                nro_pedido = DeterminarNumeroPedido(evento);


                modelo.Llegadas.CalcularProxNroPedido(nro_pedido);
                modelo.Llegadas.CalcularRandom(evento);
                modelo.Llegadas.CalcularTiempo();
                modelo.Llegadas.CalcularProxTiempo(reloj);

                foreach (IServidor s in modelo.ListaServidores)
                {
                    s.CalcularCola(evento);
                    s.CalcularEstado(evento);
                    s.CalcularNroPedidoEnAtencion(evento, nro_pedido);
                    s.CalcularRandom();
                    s.CalcularTiempo();
                    s.CalcularTiempoProx(reloj);
                }

                modelo.C6.EncastreFinal(evento);
                
                pedidos_realizados_anterior = pedidos_realizados;
                pedidos_realizados = CalcularAcumuladorEnsamblesRealizados(evento, pedidos_realizados);

                nro_pedido_listo = DeterminarNroPedidoRealizados(pedidos_realizados, pedidos_realizados_anterior, nro_pedido);


                e_t_llegada_pedido = CalcularTiemposLlegadaCliente(q_tiempos_llegada_pedido, pedidos_realizados_anterior,pedidos_realizados); 
                e_t_a1 = CalcularTiemposAct1(q_tiempos_act1, pedidos_realizados_anterior, pedidos_realizados); 
                e_t_a2 = CalcularTiemposAct2(q_tiempos_act2, pedidos_realizados_anterior, pedidos_realizados);
                e_t_a3 = CalcularTiemposAct3(q_tiempos_act3, pedidos_realizados_anterior, pedidos_realizados);
                e_t_a4 = CalcularTiemposAct4(q_tiempos_act4, pedidos_realizados_anterior, pedidos_realizados);
                e_t_a5 = CalcularTiemposAct5(q_tiempos_act5, pedidos_realizados_anterior, pedidos_realizados);

                camino1 = CalcularCamino1(e_t_llegada_pedido, e_t_a5, pedidos_realizados_anterior, pedidos_realizados);
                camino2 = camino1; 
                camino3 = CalcularCamino3(e_t_llegada_pedido, e_t_a3, pedidos_realizados_anterior, pedidos_realizados);
                tiempo_ensamble = CalcularTiempoNetoEnsamble(camino1, camino3, pedidos_realizados_anterior, pedidos_realizados);

                //Punto 2
                prom_tiempo_ensamble = CalcularPromTiempoEnsamble(prom_tiempo_ensamble, tiempo_ensamble, pedidos_realizados);
                //Punto 3
                p3_pedidos_solicitados = (int)(modelo.Llegadas.Prox_Nro_Pedido - 1);
                p3_proporcion_PR_PS = (pedidos_realizados > 0 ? (pedidos_realizados / ((double)p3_pedidos_solicitados))  * 100 : 0);
                //Punto 4
                foreach (ICola c in modelo.ListaColas)
                {
                    c.CalcularMaxCantEnCola();
                }
                //Punto 5
                foreach (ICola c in modelo.ListaColas)
                {
                    c.CalcularTiempoPromedioEnCola(reloj_anterior, reloj, p3_pedidos_solicitados);
                }
                //Punto 6
                foreach (ICola c in modelo.ListaColas)
                {
                    c.CalcularCantPromedioEnCola(reloj);
                }
                
                //Punto 7
                p7_pedidos_en_sist = p3_pedidos_solicitados - pedidos_realizados;
                p7_prom_pedidos_en_sist = ((i-1)* p7_prom_pedidos_en_sist+ p7_pedidos_en_sist) /(double)i;

                //Punto 8
                foreach (IServidor s in modelo.ListaServidores)
                {
                    s.CalcularPorcentajeOcupacionServidor(reloj, reloj_anterior);
                }
                
                //Punto 9a
                modelo.S5.CalcularProporcionBloqueadoOcupado(reloj, reloj_anterior);
                //Punto 9b
                modelo.C6.CalcularProporcionesDeEspera();

                //Punto 10
                p10_reloj = reloj % 60;
                p10_reloj_anterior = reloj_anterior % 60;
                p10_nro_hora_anterior = (int)Math.Truncate(reloj_anterior / 60) + 1;
                p10_nro_hora = (int)Math.Truncate(reloj / 60) + 1;
                p10_contador_anterior = p10_contador;
                p10_contador = CalcularContadorEnsamblesPorHora(p10_reloj, p10_reloj_anterior, pedidos_realizados, pedidos_realizados_anterior, p10_contador);
                p10_prom_ensambles = CalcularPromEnsamblesPorHora(p10_nro_hora, p10_nro_hora_anterior, p10_contador_anterior, p10_prom_ensambles);

                //Punto 11
                p11_contador_mayor_igual = CalcularContadorMayorIgualParametro(p10_nro_hora, p10_nro_hora_anterior, p10_contador_anterior,param_punto_11);
                p11_probabilidad = CalcularProbMayorIgualParametro(p10_nro_hora, p10_nro_hora_anterior, p11_contador_mayor_igual, p11_probabilidad);

                //Punto 13
                /* string p13_camino_critico = "-";
                double p13_a1 = 0;
                double p13_a2 = 0;
                double p13_a3 = 0;
                double p13_a4 = 0;
                double p13_a5 = 0;*/

                p13_camino_critico = DeterminarCaminoCritico(pedidos_realizados, pedidos_realizados_anterior, tiempo_ensamble, camino1, camino3, e_t_a2, e_t_a4);
                p13_a1 = CalcularProporcionCaminoCritico(p13_camino_critico,"C1", pedidos_realizados, p13_a1);
                p13_a2 = CalcularProporcionCaminoCritico(p13_camino_critico, "C2", pedidos_realizados, p13_a2);
                p13_a3 = CalcularProporcionCaminoCritico(p13_camino_critico, "C3", pedidos_realizados, p13_a3);
                p13_a4 = CalcularProporcionCaminoCritico(p13_camino_critico, "C1", pedidos_realizados, p13_a4);
                p13_a5 = CalcularProporcionCaminoCriticoA5(p13_camino_critico, "C1", "C2", pedidos_realizados, p13_a5);

                //Recordar solo las que pide
                if ((i >= 1 && i <= 50) || i % 10000 == 0 || (i >= desde && i <= hasta) || i == cant_sim)
                {
                    AgregarFila(i, reloj, evento, nro_pedido, pedidos_realizados, nro_pedido_listo,e_t_llegada_pedido, e_t_a1, e_t_a2, 
                                e_t_a3, e_t_a4, e_t_a5,camino1, camino2, camino3, tiempo_ensamble, prom_tiempo_ensamble,p3_pedidos_solicitados, 
                                p3_proporcion_PR_PS, p7_pedidos_en_sist, p7_prom_pedidos_en_sist, p10_reloj,p10_nro_hora,p10_contador,
                                p10_prom_ensambles,p11_contador_mayor_igual, p11_probabilidad, p13_camino_critico, 
                                p13_a1, p13_a2, p13_a3, p13_a4, p13_a5);
                }
            }
            #endregion
            form.LlenarPantallaSimulacion(dtGeneral);
        }

        private double CalcularProporcionCaminoCriticoA5(string p13_camino_critico, string caminoPredeterminado1, string caminoPredeterminado2, int pedidos_realizados, double p13_a5)
        {
            if (p13_camino_critico != "-")
            {
                if (p13_camino_critico == caminoPredeterminado1 || p13_camino_critico == caminoPredeterminado2)
                {
                    return ((pedidos_realizados - 1) * p13_a5 + 1) / (double)pedidos_realizados;
                }
                else
                {
                    return ((pedidos_realizados - 1) * p13_a5 + 0) / (double)pedidos_realizados;
                }
            }
            else
            {
                return p13_a5;
            }
        }

        private double CalcularProporcionCaminoCritico(string p13_camino_critico, string caminoPredeterminado, int pedidos_realizados, double p13_a1)
        {
            if (p13_camino_critico != "-")
            {
                if(p13_camino_critico == caminoPredeterminado)
                {
                    return ((pedidos_realizados - 1) * p13_a1 + 1) / (double)pedidos_realizados;
                }
                else
                {
                    return ((pedidos_realizados - 1) * p13_a1 + 0) / (double)pedidos_realizados;
                }
            }
            else
            {
                return p13_a1;
            }
        }

        private void AgregarFila(int i, double reloj, string evento, int? nro_pedido, int pedidos_realizados, int? nro_pedido_listo, 
                                 double? e_t_llegada_pedido, double? e_t_a1, double? e_t_a2, double? e_t_a3, double? e_t_a4, double? e_t_a5, 
                                 double? camino1, double? camino2, double? camino3, double? tiempo_ensamble, double prom_tiempo_ensamble, 
                                 int p3_pedidos_solicitados, double p3_proporcion_PR_PS, int p7_pedidos_en_sist, double p7_prom_pedidos_en_sist, 
                                 double p10_reloj, int p10_nro_hora,
                                 int p10_contador, double p10_prom_ensambles, int? p11_contador_mayor_igual, double p11_probabilidad, 
                                 string p13_camino_critico, double p13_a1, double p13_a2, double p13_a3, double p13_a4, double p13_a5)
        {
            
            string llegadasTiempo = Stringficar(modelo.Llegadas.Tiempo);
            string llegadasProxTiempo = Stringficar(modelo.Llegadas.Tiempo_Prox);

            string S1Tiempo = Stringficar(modelo.S1.Tiempo);
            string S2Tiempo = Stringficar(modelo.S2.Tiempo);
            string S3Tiempo = Stringficar(modelo.S3.Tiempo);
            string S4Tiempo = Stringficar(modelo.S4.Tiempo);
            string S5Tiempo = Stringficar(modelo.S5.Tiempo);


            string S1ProxTiempo = Stringficar(modelo.S1.TiempoProx);
            string S2ProxTiempo = Stringficar(modelo.S2.TiempoProx);
            string S3ProxTiempo = Stringficar(modelo.S3.TiempoProx);
            string S4ProxTiempo = Stringficar(modelo.S4.TiempoProx);
            string S5ProxTiempo = Stringficar(modelo.S5.TiempoProx);

            string e_s_llegada = Stringficar(e_t_llegada_pedido);
            string e_s_a1 = Stringficar(e_t_a1);
            string e_s_a2 = Stringficar(e_t_a2);
            string e_s_a3 = Stringficar(e_t_a3);
            string e_s_a4 = Stringficar(e_t_a4);
            string e_s_a5 = Stringficar(e_t_a5);

            string s_camino_1 = Stringficar(camino1);
            string s_camino_2 = Stringficar(camino2);
            string s_camino_3 = Stringficar(camino3);

            string s_tiempo_ensamble = Stringficar(tiempo_ensamble);

            dtGeneral.Rows.Add(i, reloj.ToString("0.00"), evento, nro_pedido,
                                modelo.Llegadas.Prox_Nro_Pedido, llegadasTiempo, llegadasProxTiempo,
                                modelo.S1.Cola.Cantidad, (modelo.S1.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S1.Nro_Pedido, S1Tiempo, S1ProxTiempo,
                                modelo.S2.Cola.Cantidad, (modelo.S2.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S2.Nro_Pedido, S2Tiempo, S2ProxTiempo,
                                modelo.S3.Cola.Cantidad, (modelo.S3.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S3.Nro_Pedido, S3Tiempo, S3ProxTiempo,
                                modelo.S4.Cola.Cantidad, (modelo.S4.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S4.Nro_Pedido, S4Tiempo, S4ProxTiempo,
                                modelo.S5.Cola.Cola1.Cantidad, modelo.S5.Cola.Cola2.Cantidad, (modelo.S5.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S5.Nro_Pedido, S5Tiempo, S5ProxTiempo,
                                modelo.C6.Cola1.Cantidad, modelo.C6.Cola2.Cantidad,
                                pedidos_realizados, nro_pedido_listo,
                                e_s_llegada, e_s_a1, e_s_a2, e_s_a3, e_s_a4, e_s_a5,
                                s_camino_1, s_camino_2, s_camino_3, s_tiempo_ensamble, 
                                prom_tiempo_ensamble.ToString("0.00"),
                                p3_pedidos_solicitados, p3_proporcion_PR_PS.ToString("0.00"),
                                modelo.S1.Cola.P4_Cantidad_Maxima, modelo.S2.Cola.P4_Cantidad_Maxima,
                                modelo.S3.Cola.P4_Cantidad_Maxima, modelo.S4.Cola.P4_Cantidad_Maxima,
                                modelo.S5.Cola.P4_Cantidad_Maxima, modelo.C6.P4_Cantidad_Maxima,
                                modelo.S1.Cola.P5_Tiempo_Acumulado.ToString("0.00"), modelo.S1.Cola.P5_Tiempo_Promedio.ToString("0.00"),
                                modelo.S2.Cola.P5_Tiempo_Acumulado.ToString("0.00"), modelo.S2.Cola.P5_Tiempo_Promedio.ToString("0.00"),
                                modelo.S3.Cola.P5_Tiempo_Acumulado.ToString("0.00"), modelo.S3.Cola.P5_Tiempo_Promedio.ToString("0.00"),
                                modelo.S4.Cola.P5_Tiempo_Acumulado.ToString("0.00"), modelo.S4.Cola.P5_Tiempo_Promedio.ToString("0.00"),
                                modelo.S5.Cola.P5_Tiempo_Acumulado.ToString("0.00"), modelo.S5.Cola.P5_Tiempo_Promedio.ToString("0.00"),
                                modelo.C6.P5_Tiempo_Acumulado.ToString("0.00"), modelo.C6.P5_Tiempo_Promedio.ToString("0.00"),
                                modelo.S1.Cola.P6_Promedio_Pedidos_en_Cola.ToString("0.00"), modelo.S2.Cola.P6_Promedio_Pedidos_en_Cola.ToString("0.00"),
                                modelo.S3.Cola.P6_Promedio_Pedidos_en_Cola.ToString("0.00"), modelo.S4.Cola.P6_Promedio_Pedidos_en_Cola.ToString("0.00"),
                                modelo.S5.Cola.P6_Promedio_Pedidos_en_Cola.ToString("0.00"), modelo.C6.P6_Promedio_Pedidos_en_Cola.ToString("0.00"),
                                p7_pedidos_en_sist, p7_prom_pedidos_en_sist.ToString("0.00"),
                                modelo.S1.P8_Tiempo_Ocupado_Acumulado.ToString("0.00"), modelo.S1.P8_Porcentaje_Tiempo_Ocupado.ToString("0.00"),
                                modelo.S2.P8_Tiempo_Ocupado_Acumulado.ToString("0.00"), modelo.S2.P8_Porcentaje_Tiempo_Ocupado.ToString("0.00"),
                                modelo.S3.P8_Tiempo_Ocupado_Acumulado.ToString("0.00"), modelo.S3.P8_Porcentaje_Tiempo_Ocupado.ToString("0.00"),
                                modelo.S4.P8_Tiempo_Ocupado_Acumulado.ToString("0.00"), modelo.S4.P8_Porcentaje_Tiempo_Ocupado.ToString("0.00"),
                                modelo.S5.P8_Tiempo_Ocupado_Acumulado.ToString("0.00"), modelo.S5.P8_Porcentaje_Tiempo_Ocupado.ToString("0.00"),
                                modelo.S5.P9_Tiempo_Bloqueado_Acumulado.ToString("0.00"), modelo.S5.P9_Proporcion_Bloqueado_Ocupado.ToString("0.00"),
                                modelo.C6.P9_Proporcion_Espera_Cola_1.ToString("0.00"), modelo.C6.P9_Proporcion_Espera_Cola_2.ToString("0.00"),
                                p10_reloj.ToString("0.00"),p10_nro_hora,p10_contador,p10_prom_ensambles.ToString("0.00"),
                                p11_contador_mayor_igual,p11_probabilidad.ToString("0.00"),p13_camino_critico,
                                (p13_a1*100).ToString("0.00"), (p13_a2 * 100).ToString("0.00"), (p13_a3 * 100).ToString("0.00"),
                                (p13_a4 * 100).ToString("0.00"), (p13_a5 * 100).ToString("0.00"));
        }

        private string Stringficar(double? nroconmuchosdecimales)
        {
            if (nroconmuchosdecimales.HasValue)
                return nroconmuchosdecimales.Value.ToString("0.00");
            return "";
        }

        private string DeterminarCaminoCritico(int pedidos_realizados, int pedidos_realizados_anterior, double? tiempo_ensamble, double? camino1, double? camino3, double? e_t_a2, double? e_t_a4)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                if(tiempo_ensamble == camino3)
                {
                    return "C3";
                }
                if(tiempo_ensamble == camino1)
                {
                    if(e_t_a2 > e_t_a4)
                    {
                        return "C2";
                    }
                    else
                    {
                        return "C1";
                    }
                }
            }
            return "-";

        }

        private double CalcularProbMayorIgualParametro(int p10_nro_hora, int p10_nro_hora_anterior, int? p11_contador_mayor_igual, double p11_probabilidad)
        {
            if (p10_nro_hora != p10_nro_hora_anterior)
            {
                return (double)((((p10_nro_hora_anterior - 1) * p11_probabilidad) + p11_contador_mayor_igual) / (double)p10_nro_hora_anterior);
            }
            else
            {
                return p11_probabilidad;
            }
        }

        private int? CalcularContadorMayorIgualParametro(int p10_nro_hora, int p10_nro_hora_anterior, int p10_contador_anterior, int param_punto_11)
        {
            if (p10_nro_hora != p10_nro_hora_anterior)
            {
                if (p10_contador_anterior >= param_punto_11)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return null; 
            }
        }

        private double CalcularPromEnsamblesPorHora(int p10_nro_hora, int p10_nro_hora_anterior,int p10_contador_anterior, double p10_prom_ensambles)
        {
            if (p10_nro_hora != p10_nro_hora_anterior)
            {
                return (((p10_nro_hora_anterior - 1) * p10_prom_ensambles) + p10_contador_anterior) / p10_nro_hora_anterior;
            }
            else
            {
                return p10_prom_ensambles;
            }
        }



        private int CalcularContadorEnsamblesPorHora(double reloj, double reloj_anterior, int pedidos_realizados, int pedidos_realizados_anterior, int p10_contador)
        {
            if(pedidos_realizados != pedidos_realizados_anterior)
            {
                return p10_contador+1;
            }
            else
            {
                if(reloj >= reloj_anterior)
                {
                    return p10_contador;
                }
                else
                {
                    return 0;
                }
            }
        }

        private double CalcularPromTiempoEnsamble(double prom_tiempo_ensamble, double? tiempo_ensamble, int pedidos_realizados)
        {
            if (tiempo_ensamble.HasValue)
                return (double)(((pedidos_realizados - 1) * prom_tiempo_ensamble + tiempo_ensamble) / pedidos_realizados);
            else
                return prom_tiempo_ensamble;
        }

        private double? CalcularTiempoNetoEnsamble(double? camino1, double? camino3, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                if(camino1 >= camino3)
                {
                    return camino1;
                }
                return camino3;
            }
            else
            {
                return null;
            }
        }

        private double? CalcularCamino3(double? e_t_llegada_pedido, double? e_t_a3, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return (e_t_a3 - e_t_llegada_pedido);
            }
            else
            {
                return null;
            }
        }

        private double? CalcularCamino1(double? e_t_llegada_pedido, double? e_t_a5, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return (e_t_a5 - e_t_llegada_pedido);
            }
            else
            {
                return null;
            }
        }

        private void LimpiarModelo()
        {
            modelo.C6.ResetearCola();
            modelo.S5.ResetearServidor();
            modelo.S4.ResetearServidor();
            modelo.S3.ResetearServidor();
            modelo.S2.ResetearServidor();
            modelo.S1.ResetearServidor();
        }

        private double? CalcularTiemposAct5(Queue<double> q_tiempos_act5, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                if (modelo.S5.Tiempo.HasValue)
                {
                    q_tiempos_act5.Enqueue(modelo.S5.TiempoProx.Value);
                }
                return q_tiempos_act5.Dequeue();
            }
            else
            {
                if (modelo.S5.Tiempo.HasValue)
                {
                    q_tiempos_act5.Enqueue(modelo.S5.TiempoProx.Value);
                }
                if (q_tiempos_act5.Count == 0)
                {
                    return null;
                }
                return q_tiempos_act5.Peek();
            }
        }

        private double? CalcularTiemposAct4(Queue<double> q_tiempos_act4, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return q_tiempos_act4.Dequeue();
            }
            else
            {
                if (modelo.S4.Tiempo.HasValue)
                {
                    q_tiempos_act4.Enqueue(modelo.S4.TiempoProx.Value);
                }
                if (q_tiempos_act4.Count == 0)
                {
                    return null;
                }
                return q_tiempos_act4.Peek();
            }
        }

        private double? CalcularTiemposAct3(Queue<double> q_tiempos_act3, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                if (modelo.S3.Tiempo.HasValue)
                {
                    q_tiempos_act3.Enqueue(modelo.S3.TiempoProx.Value);
                }
                return q_tiempos_act3.Dequeue();
            }
            else
            {
                if (modelo.S3.Tiempo.HasValue)
                {
                    q_tiempos_act3.Enqueue(modelo.S3.TiempoProx.Value);
                }
                if (q_tiempos_act3.Count == 0)
                {
                    return null;
                }
                return q_tiempos_act3.Peek();
            }
        }

        private double? CalcularTiemposAct2(Queue<double> q_tiempos_act2, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return q_tiempos_act2.Dequeue();
            }
            else
            {
                if (modelo.S2.Tiempo.HasValue)
                {
                    q_tiempos_act2.Enqueue(modelo.S2.TiempoProx.Value);
                }
                if (q_tiempos_act2.Count == 0)
                {
                    return null;
                }
                return q_tiempos_act2.Peek();
            }
        }

        private double? CalcularTiemposAct1(Queue<double> q_tiempos_act1, int pedidos_realizados_anterior, int pedidos_realizados)
        {

            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return q_tiempos_act1.Dequeue();
            }
            else
            {
                if (modelo.S1.Tiempo.HasValue)
                {
                    q_tiempos_act1.Enqueue(modelo.S1.TiempoProx.Value);
                }
                if (q_tiempos_act1.Count == 0)
                {
                    return null;
                }
                return q_tiempos_act1.Peek();
            }

        }

        private double? CalcularTiemposLlegadaCliente(Queue<double> q_tiempos_llegada_pedido, int pedidos_realizados_anterior, int pedidos_realizados)
        {

            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return q_tiempos_llegada_pedido.Dequeue();
            }
            else
            {
                if (modelo.Llegadas.Tiempo.HasValue)
                {
                    q_tiempos_llegada_pedido.Enqueue(modelo.Llegadas.Tiempo_Prox.Value);
                }
                if (q_tiempos_llegada_pedido.Count == 0)
                {
                    return null;
                }
                return q_tiempos_llegada_pedido.Peek();
            }

        }

        private int? DeterminarNroPedidoRealizados(int pedidos_realizados, int pedidos_realizados_anterior, int? nro_pedido)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
                return nro_pedido;
            return null;
        }

        private int CalcularAcumuladorEnsamblesRealizados(string evento, int pedidos_realizados)
        {
            if(evento == Evento.Fin_Actividad_5 && modelo.C6.Cola2.Cantidad_Anterior > 0)
            {
                pedidos_realizados++;
            }
            if (evento == Evento.Fin_Actividad_3 && modelo.C6.Cola1.Cantidad_Anterior > 0)
            {
                pedidos_realizados++;
            }
            return pedidos_realizados;
        }

        private int? DeterminarNumeroPedido(string evento)
        {
            switch (evento)
            {
                case Evento.Llegada_Pedido:
                    return modelo.Llegadas.Prox_Nro_Pedido;
                case Evento.Fin_Actividad_1:
                    return modelo.S1.Nro_Pedido;
                case Evento.Fin_Actividad_2:
                    return modelo.S2.Nro_Pedido;
                case Evento.Fin_Actividad_3:
                    return modelo.S3.Nro_Pedido;
                case Evento.Fin_Actividad_4:
                    return modelo.S4.Nro_Pedido;
                case Evento.Fin_Actividad_5:
                    return modelo.S5.Nro_Pedido;
                default:
                    return 0;
            }
        }

        private string DeterminarEvento(double reloj)
        {
            if(reloj == modelo.Llegadas.Tiempo_Prox)
                return Evento.Llegada_Pedido;
            if (reloj == modelo.S1.TiempoProx)
                return Evento.Fin_Actividad_1;
            if (reloj == modelo.S2.TiempoProx)
                return Evento.Fin_Actividad_2;
            if (reloj == modelo.S3.TiempoProx)
                return Evento.Fin_Actividad_3;
            if (reloj == modelo.S4.TiempoProx)
                return Evento.Fin_Actividad_4;
            if (reloj == modelo.S5.TiempoProx)
                return Evento.Fin_Actividad_5;
            return "x";
        }

        private double ProxTiempoMinimo()
        {
            List<double> proximos_tiempos = new List<double>();
            double? t1 = modelo.Llegadas.Tiempo_Prox;
            double? t2 = modelo.S1.TiempoProx;
            double? t3 = modelo.S2.TiempoProx;
            double? t4 = modelo.S3.TiempoProx;
            double? t5 = modelo.S4.TiempoProx;
            double? t6 = modelo.S5.TiempoProx;

            if (t1.HasValue)
            {
                proximos_tiempos.Add((double)t1);
            }
            if (t2.HasValue)
            {
                proximos_tiempos.Add((double)t2);
            }
            if (t3.HasValue)
            {
                proximos_tiempos.Add((double)t3);
            }
            if (t4.HasValue)
            {
                proximos_tiempos.Add((double)t4);
            }
            if (t5.HasValue)
            {
                proximos_tiempos.Add((double)t5);
            }
            if (t6.HasValue)
            {
                proximos_tiempos.Add((double)t6);
            }
            proximos_tiempos.Sort();

            return proximos_tiempos.First();
        }


        private void InicializarColumnasTablas()
        {
            dtGeneral.Columns.Add("i");
            dtGeneral.Columns.Add("Reloj");
            dtGeneral.Columns.Add("Evento");
            dtGeneral.Columns.Add("Nro Pedido");
            dtGeneral.Columns.Add("Prox Pedido");
            dtGeneral.Columns.Add("Tiempo Lleg");
            dtGeneral.Columns.Add("Tiempo Prox Lleg");
            dtGeneral.Columns.Add("Cola 1");
            dtGeneral.Columns.Add("Estado Servidor 1");
            dtGeneral.Columns.Add("Nro Pedido en At 1");
            dtGeneral.Columns.Add("Tiempo A1");
            dtGeneral.Columns.Add("Prox Tiempo A1");
            dtGeneral.Columns.Add("Cola 2");
            dtGeneral.Columns.Add("Estado Servidor 2");
            dtGeneral.Columns.Add("Nro Pedido en At 2");
            dtGeneral.Columns.Add("Tiempo A2");
            dtGeneral.Columns.Add("Prox Tiempo A2");
            dtGeneral.Columns.Add("Cola 3");
            dtGeneral.Columns.Add("Estado Servidor 3");
            dtGeneral.Columns.Add("Nro Pedido en At 3");
            dtGeneral.Columns.Add("Tiempo A3");
            dtGeneral.Columns.Add("Prox Tiempo A3");
            dtGeneral.Columns.Add("Cola 4");
            dtGeneral.Columns.Add("Estado Servidor 4");
            dtGeneral.Columns.Add("Nro Pedido en At 4");
            dtGeneral.Columns.Add("Tiempo A4");
            dtGeneral.Columns.Add("Prox Tiempo A4");
            dtGeneral.Columns.Add("Cola 5a (A4)");
            dtGeneral.Columns.Add("Cola 5b (A2)");
            dtGeneral.Columns.Add("Estado Servidor 5");
            dtGeneral.Columns.Add("Nro Pedido en At 5");
            dtGeneral.Columns.Add("Tiempo A5");
            dtGeneral.Columns.Add("Prox Tiempo A5");
            dtGeneral.Columns.Add("Cola 6a (A5)");
            dtGeneral.Columns.Add("Cola 6b (A3)");
            dtGeneral.Columns.Add("EnsamblesRealizados");
            dtGeneral.Columns.Add("NroPedido Listo");
            dtGeneral.Columns.Add("Llegada Cliente");
            dtGeneral.Columns.Add("A1");
            dtGeneral.Columns.Add("A2");
            dtGeneral.Columns.Add("A3");
            dtGeneral.Columns.Add("A4");
            dtGeneral.Columns.Add("A5");
            dtGeneral.Columns.Add("Camino 1");
            dtGeneral.Columns.Add("Camino 2");
            dtGeneral.Columns.Add("Camino 3");
            dtGeneral.Columns.Add("Tiempo Ensamble/C MAX");
            dtGeneral.Columns.Add("Prom Tiempo Ensamble");
            dtGeneral.Columns.Add("Pedidos Solicitados");
            dtGeneral.Columns.Add("Proporcion PR - PS");
            dtGeneral.Columns.Add("Cantidad_Maxima C1");
            dtGeneral.Columns.Add("Cantidad_Maxima C2");
            dtGeneral.Columns.Add("Cantidad_Maxima C3");
            dtGeneral.Columns.Add("Cantidad_Maxima C4");
            dtGeneral.Columns.Add("Cantidad_Maxima C5");
            dtGeneral.Columns.Add("Cantidad_Maxima C6");
            dtGeneral.Columns.Add("Tiempo_Acumulado C1");
            dtGeneral.Columns.Add("Tiempo_Promedio C1");
            dtGeneral.Columns.Add("Tiempo_Acumulado C2");
            dtGeneral.Columns.Add("Tiempo_Promedio C2");
            dtGeneral.Columns.Add("Tiempo_Acumulado C3");
            dtGeneral.Columns.Add("Tiempo_Promedio C3");
            dtGeneral.Columns.Add("Tiempo_Acumulado C4");
            dtGeneral.Columns.Add("Tiempo_Promedio C4");
            dtGeneral.Columns.Add("Tiempo_Acumulado C5");
            dtGeneral.Columns.Add("Tiempo_Promedio C5");
            dtGeneral.Columns.Add("Tiempo_Acumulado C6");
            dtGeneral.Columns.Add("Tiempo_Promedio C6");
            dtGeneral.Columns.Add("Cant Prom en Cola C1");
            dtGeneral.Columns.Add("Cant Prom en Cola C2");
            dtGeneral.Columns.Add("Cant Prom en Cola C3");
            dtGeneral.Columns.Add("Cant Prom en Cola C4");
            dtGeneral.Columns.Add("Cant Prom en Cola C5");
            dtGeneral.Columns.Add("Cant Prom en Cola C6");
            dtGeneral.Columns.Add("Pedidos en Sistema");
            dtGeneral.Columns.Add("Prom Pedidos en Sistema");
            dtGeneral.Columns.Add("Tiempo_Ocupado S1");
            dtGeneral.Columns.Add("Porcentaje Ocupado S1");
            dtGeneral.Columns.Add("Tiempo_Ocupado S2");
            dtGeneral.Columns.Add("Porcentaje Ocupado S2");
            dtGeneral.Columns.Add("Tiempo_Ocupado S3");
            dtGeneral.Columns.Add("Porcentaje Ocupado S3");
            dtGeneral.Columns.Add("Tiempo_Ocupado S4");
            dtGeneral.Columns.Add("Porcentaje Ocupado S4");
            dtGeneral.Columns.Add("Tiempo_Ocupado S5");
            dtGeneral.Columns.Add("Porcentaje Ocupado S5");
            dtGeneral.Columns.Add("Tiempo Bloqueado S5");
            dtGeneral.Columns.Add("Proporcion Bloqueado - Ocupado S5");
            dtGeneral.Columns.Add("Proporcion Espera En Cola C6 (A5)");
            dtGeneral.Columns.Add("Proporcion Espera En Cola C6 (A3)");
            dtGeneral.Columns.Add("Reloj%60");
            dtGeneral.Columns.Add("Nro_hora");
            dtGeneral.Columns.Add("contador");
            dtGeneral.Columns.Add("prom_ensambles");
            dtGeneral.Columns.Add("p11_contador_mayor_igual");
            dtGeneral.Columns.Add("p11_probabilidad");
            dtGeneral.Columns.Add("camino_critico");
            dtGeneral.Columns.Add("p13_A1");
            dtGeneral.Columns.Add("p13_A2");
            dtGeneral.Columns.Add("p13_A3");
            dtGeneral.Columns.Add("p13_A4");
            dtGeneral.Columns.Add("p13_A5");
        }
        private void LimpiarTableDatas()
        {
            dtGeneral.Clear();
        }

        ///Evento Cerrar un Form
        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            //Remover Pantalla de la lista de Pantallas.
            Views.Remove(sender as Form);
            // NOTE: Terminar programa si no quedan mas Vistas/Forms o si se está cerrando la ventana principal.
            if (Views.Count == 0 || sender.GetType() == typeof(Frm_TP5_Principal)) Exit();
        }

        //Finalizar Programa
        public void Exit()
        {
            this.ExitThread();
        }
        /// <summary>
        /// /Crea Pantalla Simulacion
        /// </summary>
        public void OpcionPantallaSimulacion()
        {
            CreateView(new Frm_TP5_PantallaSimulacion());
        }

        /// <summary>
        /// /Crea Pantalla Enunciado
        /// </summary>
        public void OpcionPantallaEnunciado()
        {
            CreateView(new Frm_TP5_Enunciado());
        }
    }
}
