using RiskSystem.Domain.Entities;
using RiskSystem.Domain.Interfaces;
using RiskSystem.Domain.Services;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a data:");
        // Parse input
        string[] referenceDateStr = Console.ReadLine().Split('/');
        DateTime referenceDate = new DateTime(int.Parse(referenceDateStr[2]), int.Parse(referenceDateStr[0]), int.Parse(referenceDateStr[1]));

        Console.WriteLine("Quantidade de Trades:");
        int n = int.Parse(Console.ReadLine());

        // Create trade classifier
        TradeClassifier classifier = new TradeClassifier(new ExpiredCategory(referenceDate), new HighRiskCategory(), new MediumRiskCategory());

        List<ITrade> trades = new List<ITrade>();


        Console.WriteLine("Digite os valores das negociações (valor, setor do cliente, data de pagamento):");
        // Classify trades
        for (int i = 0; i < n; i++)
        {
            string[] tradeInfo = Console.ReadLine().Split();
            double value = double.Parse(tradeInfo[0]);
            string clientSector = tradeInfo[1];
            string[] paymentDateStr = tradeInfo[2].Split('/');
            DateTime nextPaymentDate = new DateTime(int.Parse(paymentDateStr[2]), int.Parse(paymentDateStr[0]), int.Parse(paymentDateStr[1]));

            ITrade trade = new Trade(value, clientSector, nextPaymentDate);
            trades.Add(trade);

            //ITrade trade = new Trade(value, clientSector, nextPaymentDate);
            //Console.WriteLine(classifier.ClassifyTrade(trade));
        }

        Console.WriteLine("\nResultados da classificação das negociações:");

        foreach (var trade in trades)
        {
            Console.WriteLine(classifier.ClassifyTrade(trade));
        }
    }
}