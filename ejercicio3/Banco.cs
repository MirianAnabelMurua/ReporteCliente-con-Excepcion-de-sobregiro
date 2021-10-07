using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operacionesBancarias.dominio
{
    /*
    * La clase Banco implementa el patrón de diseño Singleton
    * porque sólo puede haber un objeto del tipo Banco
    */
    class Banco
    {
        /*
        * La variable de referencia qua almacena la instancia de Banco.
        */
        private static Banco instanciaBanco = new Banco();
        public static Banco getBanco()
        {
            return instanciaBanco;
        }

        private int MAX_CLIENTES = 10;
        private const double PORCENTAJE_CAJA_AHORRO = 3.5;
        private Cliente[] clientes;
        private int numeroDeClientes;

        private Banco()
        {
            clientes = new Cliente[MAX_CLIENTES];
            numeroDeClientes = 0;
        }

        public void AgregaCliente(String p, String a)
        {
            int i = numeroDeClientes++;
            clientes[i] = new Cliente(p, a);
        }
        public Cliente GetCliente(int indiceCliente)
        {
            return clientes[indiceCliente];
        }
        public int NumeroDeClientes
        {
            get
            {
                return numeroDeClientes;
            }
        }
    }
}
