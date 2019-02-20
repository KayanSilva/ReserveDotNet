using Refactoring.Models;

namespace Refactoring.Codes
{
    public static class FormTemplateMethod
    {
        public static void FormTemplateMain()
        {
            var client = new Client();

            //....
            //....
            //....

            var resumo = new Summary(client).GetResumo();
            var resumoHTML = new SummaryHtml(client).GetResumo();
        }
    }
}