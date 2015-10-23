using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoescuelaAppCSharp.Classes
{
    public class Usuario
    {


        public string Nombre { get; set; }
        private int _edad;
        public int Edad
        {
            get
            { return _edad; }

            set
            {
                if (value < 18 || value > 65)
                    throw new UserEdadException($"La edad {value} no es válida");
                _edad = value;
            }
        }

        public string PermisoActual { get; set; }

        private string _permiso;
        public string Permiso
        {
            get
            { return _permiso; }

            set
            {
                var letrap = Encoding.ASCII.GetBytes(value.ToLower())[0];
                var letrapa = Encoding.ASCII.GetBytes(PermisoActual.ToLower())[0] + 1;

                if (letrap == letrapa)
                {
                    _permiso = value;
                }
                else
                {
                    throw new UserPermisoException($"No cumples los requisitos para obtener el permiso {value}");
                }

            }
        }

        public Usuario(string nombre, int edad, string permisoActual, string permiso)
        {
            Edad = edad;
            PermisoActual = permisoActual;
            Permiso = permiso;
            Nombre = nombre;
        }

    }
}
