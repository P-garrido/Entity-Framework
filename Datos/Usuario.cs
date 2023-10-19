using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        DbPracticaParcialContext context = new DbPracticaParcialContext();

        public Usuario() { }

        public List<Entidades.Models.Usuario> obtenerTodosLosUsuarios()
        {
            List<Entidades.Models.Usuario> usuarios = new List<Entidades.Models.Usuario>();
            foreach (Entidades.Models.Usuario usuario in context.Usuarios)
            {
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public Entidades.Models.Usuario  obtenerUsuarioPorId(int id)
        {
            Entidades.Models.Usuario usuario = context.Usuarios.Find(id);
            return usuario;
        }

        public void crearUsuario(Entidades.Models.Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public void eliminarUsuario(int id)
        {
            Entidades.Models.Usuario usuAEliminar = context.Usuarios.Find(id);

            if (usuAEliminar != null)
            {
                context.Usuarios.Remove(usuAEliminar);
                context.SaveChanges();
            }
        }

        public void actualizarUsuario(int id, Entidades.Models.Usuario usuActualizado)
        {
            Entidades.Models.Usuario usuAActualizar = context.Usuarios.Find(id);

            if (usuAActualizar != null)
            {
                usuAActualizar.Nombre = usuActualizado.Nombre;
                usuAActualizar.Telefono = usuActualizado.Telefono;
                usuAActualizar.Apellido = usuActualizado.Apellido;
                usuAActualizar.FechaNacimiento = usuActualizado.FechaNacimiento;
                context.SaveChanges();
            }
        }

        public List<Entidades.Models.Usuario> obtenerUsuarioPorNombre(string nombre)
        {
            List<Entidades.Models.Usuario> usuarios = new List<Entidades.Models.Usuario> ();
            foreach (Entidades.Models.Usuario usuario in context.Usuarios.Where(usu=> usu.Nombre.Contains(nombre)))
            {
                usuarios.Add(usuario);
            }
            return usuarios;
        }
    }
}
