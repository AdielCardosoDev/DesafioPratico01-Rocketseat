using DesafioPratico01_Rocketseat;


Console.WriteLine($"Exercícios 01");
Console.Write("Digite o seu nome: ");
var nome = Console.ReadLine();
BoasVindas.NomeSobrenome(nome);

Console.WriteLine($"Exercícios 02");
Console.Write("Digite o seu Sobrenome: ");
var sobrenome = Console.ReadLine();
NomeCompleto.NomeSobrenome(nome, sobrenome);

Console.WriteLine($"Exercícios 03");
Console.Write("Digite o valor do seu salario Anual: ");
double valorDoSalarioAnual = double.Parse(Console.ReadLine());

Console.Write("Digite o valor do seu salario mensal: ");
double valorDoSalarioMensal = double.Parse(Console.ReadLine());

var soma = ValoresDetalhados.CalculoSoma(valorDoSalarioAnual, valorDoSalarioMensal);

Console.WriteLine($"Valor da Soma é: {soma} ");

var subtracao = ValoresDetalhados.CalculoSubtracao(valorDoSalarioAnual, valorDoSalarioMensal);

Console.WriteLine($"Valor da subtração é: {subtracao} ");

var multiplicacao = ValoresDetalhados.CalculoMultiplicacao(valorDoSalarioAnual, valorDoSalarioMensal);

Console.WriteLine($"Valor da multiplicação  é: {multiplicacao} ");

var divisao = ValoresDetalhados.CalculoDivisao(valorDoSalarioAnual, valorDoSalarioMensal);

Console.WriteLine($"Valor da divisão é: {divisao} ");

var media = ValoresDetalhados.CalculoMedia(valorDoSalarioAnual, valorDoSalarioMensal);

Console.WriteLine($"Valor da média é: {media} ");

Console.WriteLine($"Exercícios 04");
Console.Write("Digite uma ou mais palavras: ");
var texto = Console.ReadLine();

var resultado = ContaCaracteres.ContarCaracteres(texto);

Console.WriteLine($"Total de Caracteres é: {resultado.Length} ");

Console.WriteLine($"Exercícios 05");
Console.Write("Digite a placa do veículo: ");
string placa = Console.ReadLine().ToUpper();

if (ValidaPlacaDeVeiculos.ValidarPlaca(placa))
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}

Console.WriteLine($"Exercícios 06");
Console.WriteLine("Escolha um formato para exibir a data:");
Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
Console.WriteLine("2 - Apenas a data (formato DD/MM/AAAA)");
Console.WriteLine("3 - Apenas a hora (formato 24 horas)");
Console.WriteLine("4 - Data com o mês por extenso (DD de mês por extenso de AAAA)");
var tipoSelecionado = Console.ReadLine();

FormataData.FormatarData(tipoSelecionado);





