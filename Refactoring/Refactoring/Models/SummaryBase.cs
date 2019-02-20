using System.Text;

namespace Refactoring.Models
{
    abstract class SummaryBase
    {
        protected readonly Client Client;

        protected SummaryBase(Client client)
        {
            Client = client;
        }

        public string GetResumo()
        {
            var resultado = new StringBuilder();
            resultado.AppendLine(GetTitle());
            foreach (var locacao in Client.Location)
            {
                resultado.AppendLine(GetDetails(locacao));
            }
            resultado.AppendLine(GetDebits());
            resultado.AppendLine(GetPoints());
            return resultado.ToString();
        }

        protected abstract string GetPoints();
        protected abstract string GetDebits();
        protected abstract string GetDetails(Location locacao);
        protected abstract string GetTitle();
    }
}