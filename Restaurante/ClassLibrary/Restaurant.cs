using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Restaurant
    {
        //Atributos
        private string dueño;
        private string direccion = "";
        private bool ruidoso = false;
        private int cantClientes = 0;

        //Métodos
        public string Dueño
        {
            set
            {
                this.dueño = value.ToUpper();
            }
            get
            {
                return this.dueño;
            }
        }
        public string Direccion
        {
            set
            {
                this.direccion = value.ToUpper();
            }
            get
            {
                return this.direccion;
            }
        }
        public bool Ruidoso
        {
            set
            {
                this.ruidoso = value;
            }
            get
            {
                return this.ruidoso;
            }
        }
        public int CantClientes
        {
            set
            {
                this.cantClientes = value;
            }
            get
            {
                return this.cantClientes;
            }
        }
        public string EstadoDeRuido()
        {
            if (Ruidoso)
            {
                return "Restaurante bullicioso";
            }
            else
            {
                return "Restaurante tranquilo";
            }
        }
        public void CambiarEstadoDeRuido(int clientes)
        {
            if (clientes > 500)
            {
                Ruidoso = true;
            }
            else
            {
                Ruidoso = false;
            }
        }
    }
}
