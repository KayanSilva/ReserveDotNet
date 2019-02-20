namespace Refactoring.Models
{
    class Summary : SummaryBase
    {
        public Summary(Client client) : base(client)
        {
        }

        protected override string GetDebits()
        {
            return "Total devido: " + Client.TotalValue;
        }

        protected override string GetDetails(Location locacao)
        {
            return "\t" + locacao.Movie.Title;
        }

        protected override string GetPoints()
        {
            return $"Você ganhou: {Client.LoyaltyPoints.ToString()} pontos";
        }

        protected override string GetTitle()
        {
            return "Resumo de locações de " + Client.Name;
        }
    }
}