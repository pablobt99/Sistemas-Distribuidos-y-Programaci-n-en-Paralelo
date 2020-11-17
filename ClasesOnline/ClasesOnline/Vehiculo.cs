using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ClasesOnline
{
    public class Vehiculo
    {
        private string modelo;
        private int velocidad = 0;


        public string Modelo
        {
            get
            {
                return this.modelo;
            }
            set
            {
                this.modelo = value;
            }
        }
        public string Submodelo { get; set; }
        //constructor
        public  Vehiculo()
        {
            this.Modelo = "URMAFE";
            this.Submodelo = "SUB";
        }
        //campos
        //public string Modelo;

        //modificadores de acceso public; private; internal(desde dentro del ensambado); protected(accesible desde la propia clase y desde clases derivadas);

        //procedimiento de propiedad a diferencia de los campos se divide en getter y setter

        //metodo acelerar
        public void Acelerar(int NumKmHora)
        {
            this.Acelerar(NumKmHora, false);
            this.velocidad = this.velocidad + NumKmHora;
        }
        //sobrecaga de metodos
        public void Acelerar(int NumKmHora, bool UsarTurbo)
        {
            if(UsarTurbo == true)
            {
                //codigo para usar el turbo
            }
            this.velocidad = this.velocidad + NumKmHora;
        }
        public static decimal ConverturMiilasAKilometros(int NumMillas)
        {
            return NumMillas / 1.4m;
        }
    }
}
