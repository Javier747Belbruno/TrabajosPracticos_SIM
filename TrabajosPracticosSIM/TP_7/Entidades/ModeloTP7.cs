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
        public int? tn_actuales_camion { get; set; } = null;

        #endregion
        #region Secundarias

        public string tubo_aspirador { get; set; } = "-";
        public int? nro_primer_camion_en_salir { get; set; } = null;
        public int? tn_primer_camion_en_salir { get; set; } = null;
        public Queue<int> cola_camiones { get; set; } = new Queue<int>();
        public Queue<double> cola_tn { get; set; } = new Queue<double>();
        public double? tiempo_cambio { get; set; } = 0.00;
        public string silo_para_suministro { get; set; } = Estados.S2;
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
