using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;

namespace Negocios
{
    public class Usuario
    {   
        Datos.Usuario CD_Usuario = new Datos.Usuario();
        
        public Usuario() { }

        public List<Entidades.Models.Usuario> obtenerTodosLosUsuarios()
        {
            return CD_Usuario.obtenerTodosLosUsuarios();
        }

        public Entidades.Models.Usuario obtenerUsuarioPorId(int id)
        {
            return CD_Usuario.obtenerUsuarioPorId(id);
        }

        public Boolean crearUsuario(string nom, string ap, string tel, DateTime fechaNac)
        {

            if (ap.Contains('@'))
            {
                Entidades.Models.Usuario usu = new Entidades.Models.Usuario()
                {
                    Nombre = nom,
                    Apellido = ap,
                    FechaNacimiento = fechaNac,
                    Telefono = tel,
                };
                CD_Usuario.crearUsuario(usu);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void eliminarUsuario(int id)
        {
            CD_Usuario.eliminarUsuario(id);
        }

        public void actualizarUsuario(int id, string nom, string ap, string tel, DateTime fechaNac)
        {
            Entidades.Models.Usuario usu = new Entidades.Models.Usuario()
            {
                Nombre = nom,
                Apellido = ap,
                FechaNacimiento = fechaNac,
                Telefono = tel,
            };
            CD_Usuario.actualizarUsuario(id, usu);
        }


        public List<Entidades.Models.Usuario> obtenerUsuarioPorNombre(string nombre)
        {
            return CD_Usuario.obtenerUsuarioPorNombre(nombre);
        }



    }
}
