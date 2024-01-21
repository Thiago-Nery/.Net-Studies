using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao_EF
{
    public class ClienteCRUD : IDisposable
    {
        private DatabaseContext db = new DatabaseContext();
        public void Create(string nome, string sobrenome = "")
        {
            db.Clientes.Add(new Cliente { Nome = nome, Sobrenome = sobrenome} );
            db.SaveChanges();
        }
        public void Read(int? id = null)
        {
            if (id == null)
            {
                foreach (var cliente in db.Clientes)
                {
                    Console.WriteLine($"{cliente.Id} - {cliente.Nome} - {cliente.Sobrenome}");
                }
                
            }
            else
            {
                var cliente = db.Clientes.Find(id);
                Console.WriteLine($"{cliente.Id} - {cliente.Nome}");
            }
        }
        public void Update(int id, string? nome = null, string? sobrenome = null)
        {
            var cliente = db.Clientes.Find(id);
            if (nome != null) cliente.Nome = nome;
            if (sobrenome != null) cliente.Sobrenome = sobrenome;
            db.SaveChanges();
        }
        public void Delete(int? id = null )
        {
            if (id == null)
            {
                foreach(var cliente in db.Clientes)
                {
                    db.Clientes.Remove(cliente);
                }
                db.SaveChanges();
            }
            else 
            {
                db.Clientes.Remove(db.Clientes.Find(id));
                db.SaveChanges();
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
