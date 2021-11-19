using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Horadagua.Modelo
{
    public class Hidratacao
    {
        [PrimaryKey, AutoIncrement]
        public long HidratacaoId { get; set; }
        public string Quantidade { get; set; }
        public DateTime? DataHora { get; set; }
    }
}
