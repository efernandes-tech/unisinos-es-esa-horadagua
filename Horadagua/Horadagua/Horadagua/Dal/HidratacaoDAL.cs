using Horadagua.Infraestrutura;
using Horadagua.Modelo;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Horadagua.Dal
{
    public class HidratacaoDAL
    {
        private SQLiteConnection sqlConnection;

        public HidratacaoDAL()
        {
            this.sqlConnection = DependencyService.Get<IDatabaseConnection>().DbConnection();
            this.sqlConnection.CreateTable<Hidratacao>();
        }

        public IEnumerable<Hidratacao> GetAll()
        {
            return (from t in sqlConnection.Table<Hidratacao>() select t).OrderBy(i => i.Quantidade).ToList();
        }

        public Hidratacao GetItemById(long id)
        {
            return sqlConnection.Table<Hidratacao>().FirstOrDefault(t => t.HidratacaoId == id);
        }

        public void DeleteById(long id)
        {
            sqlConnection.Delete<Hidratacao>(id);
        }

        public void Add(Hidratacao hidratacao)
        {
            sqlConnection.Insert(hidratacao);
        }

        public void Update(Hidratacao hidratacao)
        {
            sqlConnection.Update(hidratacao);
        }
    }
}
