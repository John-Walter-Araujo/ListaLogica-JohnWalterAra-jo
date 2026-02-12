// See https://aka.ms/new-console-template for more information
//Nivel 1: Variáveis e Operações Básicas
#region 1. Calculadora de média
//Console.Write("Olá, digite a primeira nota: ");
//double nota1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Digite a segunda nota: ");
//double nota2 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Digite sua terceira nota: ");
//double nota3 = Convert.ToDouble(Console.ReadLine());

//double media = ((nota1 + nota2 + nota3) / 3);

//if (media > 7)
//{
//    Console.WriteLine("Parabéns, você passou!!!");
//}
//else if (media == 6)
//{
//    Console.WriteLine("Você está de recuperação.");
//}
//else
//{
//    Console.WriteLine("Você está reprovado.");
//}
//#endregion

//#region 2. Conversor de idade
//Console.Write("Digite qual sua idade atual: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//int idadeEmDiasCalculo = (idade * 365);

//Console.WriteLine("Sua idade é equivalente a: " + idadeEmDiasCalculo + " dias.");
#endregion
#region 3. Troca de Valores
string Refrigerante01 = "Cajuína";
string Refrigerante02 = "Coca-Cola";

Console.WriteLine($"Atualmente o Refrigerante01 está com: {Refrigerante01} e o Refrigerante02 está com: {Refrigerante02}");
string RecipenteParaGuardarRefrigerante01 = Refrigerante01;
string RecipenteParaGuardarRefrigerante02 = Refrigerante02;
Refrigerante01 = RecipenteParaGuardarRefrigerante02;
Refrigerante02 = RecipenteParaGuardarRefrigerante01;

Console.WriteLine($"Atualmente o Refrigerante01 está com: {Refrigerante01} e o Refrigerante02 está com: {Refrigerante02}");
#endregion
