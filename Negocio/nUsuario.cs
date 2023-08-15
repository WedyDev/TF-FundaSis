using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class nUsuario
    {
        dUsuario dusuario = new dUsuario();
        public string Registrar(string nombre,string contraseña,int telefono)
        {
            eUsuario obj = new eUsuario
            {
                nombre = nombre,
                contraseña = contraseña,
                telefono = telefono
            };
            return dusuario.Registrar(obj);
        }

        public string Iniciar_Sesion(string nombre, string contraseña)
        {
            eUsuario obj = new eUsuario
            {
                nombre = nombre,
                contraseña = contraseña
            };
            return dusuario.IniciarSesion(obj);
        }
        public string Limpiar()
        {
            return dusuario.Limpiar();
        }
    }
}
