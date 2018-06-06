using Sistema.Models;
using System.Linq;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaContext context)
        {
            context.Database.EnsureCreated();

            //Buscar si existe registros en la tabla categoria
            if (context.Categoria.Any())
            {
                return;
            }

            var categorias = new Categoria[]
                {
                    new Categoria
                    {
                        Nombre = "Programacion",
                        Descripcion = "Curso de Programacion",
                        Estado = true
                    },
                    new Categoria
                    {
                        Nombre = "Diseño Grafico",
                        Descripcion = "Curso de Diseño Grafico",
                        Estado = true
                    }
                };

            foreach (var item in categorias)
            {
                context.Categoria.Add(item);
            }

            context.SaveChanges();

        }
    }
}
