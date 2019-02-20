namespace Refactoring.Models
{
    class SummaryHtml : SummaryBase
    {
        public SummaryHtml(Client client) : base(client)
        {
        }

        protected override string GetDebits()
        {
            return "<p> Você deve: <em>R$ " + Client.TotalValue + "</em></p>";
        }

        protected override string GetDetails(Location locacao)
        {
            return locacao.Movie.Title + "<br/>";
        }

        protected override string GetPoints()
        {
            return "Você ganhou: " + Client.LoyaltyPoints + "</em> pontos.";
        }

        protected override string GetTitle()
        {
            return "<h1>Locações de <em>" + Client.Name + "</em></h1>";
        }
    }
}