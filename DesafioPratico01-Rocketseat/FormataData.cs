using System.Globalization;

namespace DesafioPratico01_Rocketseat;

public class FormataData
{
    public static void FormatarData(string tipo)
    {
        DateTime dataAtual = DateTime.Now;
        switch (tipo)
        {
            case "1":
                Console.WriteLine(dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-PT")));
                break;

            case "2":
                Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
                break;

            case "3":
                Console.WriteLine(dataAtual.ToString("HH:mm"));
                break;

            case "4":
                Console.WriteLine(dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-PT")));
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
