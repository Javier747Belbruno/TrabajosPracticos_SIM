using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_5.Entidades;

namespace TrabajosPracticosSIM.TP_6.Entidades
{
    public interface IModelo
    {
        Llegadas Llegadas { get; }
        List<IServidor> ListaServidores { get; }
        ServidorConCS S1 { get; }
        ServidorConCS S2 { get; }
        ServidorConCS S3 { get; }
        ServidorConCS S4 { get; }
        ServidorConCD S5 { get; }

        void CalcularReloj();

        void CalcularEvento();

        void CalcularNroPedido();

        void CalcularLlegada();

        void CalcularServidoresYColas();

        void CalcularPedidosRealizados();

        void CalcularNroPedidoRealizado();

        void CalcularTiemposDeCadaPedido();

        void CalcularCaminos();

        void CalcularTiempoEnsamble();

        void CalcularPunto2();//PromedioEnsamble

        void CalcularPunto3();//Proporcion_PR_PS

        void CalcularPunto4();//Calcular Max Cant En cada Cola

        void CalcularPunto5();//Tiempo Promedio En Cola

        void CalcularPunto6();//Cant Promedio En Cola

        void CalcularPunto7(int i);//Prom pedidos en sist

        void CalcularPunto8();//Porcentaje Ocupacion Servidor

        void CalcularPunto9();//ProporcionBloqueadoOcupado
                              //ProporcionesDeEspera

        void CalcularPunto10();//ContadorEnsamblesPorHora
                               //CalcularPromEnsamblesPorHora

        void CalcularPunto11(int param_punto_11);//Prob Mayor Igual Parametro

        void CalcularPunto13();//Proporcion Actividades de Caminos Criticos

        void AgregarFila(int i, ref DataTable dtGeneral);

        void GuardarLlegadaPedido();
        void ResetearValores();
    }
}
