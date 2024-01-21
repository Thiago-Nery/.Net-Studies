using Microsoft.EntityFrameworkCore;

namespace Revisao_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new ClienteCRUD();


            /*            db.Create("Thiago", "Nery");
                        db.Create("Teste 2");
                        db.Read();
            */
            db.Update(id: 10, nome: "Thiago");
            db.Read();

            /*            db.Delete();
            */

            //restart auto-ident
            /*          using (var context = new DatabaseContext())
                        {
                            context.Database.ExecuteSqlRaw("DBCC CHECKIDENT (CLIENTES, RESEED, 0)");
                        }
            */
        }
    }
}