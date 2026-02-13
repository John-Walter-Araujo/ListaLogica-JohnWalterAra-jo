
//Nivel 1: Variáveis e Operações Básicas
#region 1. Calculadora de média
Console.Write("Olá, digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite sua terceira nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

double media = ((nota1 + nota2 + nota3) / 3);

if (media > 7)
{
    Console.WriteLine("Parabéns, você passou!!!");
}
else if (media == 6)
{
    Console.WriteLine("Você está de recuperação.");
}
else
{
    Console.WriteLine("Você está reprovado.");
}
#endregion

#region 2. Conversor de idade
Console.Write("Digite qual sua idade atual: ");
int idade = Convert.ToInt32(Console.ReadLine());

int idadeEmDiasCalculo = (idade * 365);

Console.WriteLine("Sua idade é equivalente a: " + idadeEmDiasCalculo + " dias.");
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
// Nivel 2: Estrutras Condicionais
#region 1.Verificador de Maioridade

Console.Write("Olá qual sua idade? ");
int idadeUsuario = Convert.ToInt32(Console.ReadLine());

if (idadeUsuario >= 18)
{
    Console.WriteLine("Entrada autorizada.");
}
else
{
    Console.WriteLine("Entrada não autorizada. Menor de idade.");
}
#endregion
#region 2. Classificador de Número
Console.Write("Digite um número inteiro: ");
int numeroUsuario = Convert.ToInt32(Console.ReadLine());

if (numeroUsuario % 2 == 0 && numeroUsuario > 0)
{
    Console.WriteLine($"O número : {numeroUsuario} é Par e Positivo!");
}
else if (numeroUsuario % 2 != 0 && numeroUsuario > 0)
{
    Console.WriteLine($"O número : {numeroUsuario} é Ímpar e Positivo!");
}
else if (numeroUsuario < 0)
{
    Console.WriteLine($"O número {numeroUsuario} é negativo!");
}
else if (numeroUsuario == 0)
{
    Console.WriteLine($"O número {numeroUsuario} é Zero!");
}
#endregion
#region 3. Validação de Login Simples
string Usuario_Correto = "admin";
int Senha_Correta = 12345;

int contador = 1;



do
{
    Console.Write("Olá, digite seu Usuário: ");
    string NomeUsuário = Console.ReadLine();
    Console.Write("Digite a senha: ");
    int SenhaUsuario = Convert.ToInt32(Console.ReadLine());


    if (Usuario_Correto == "admin" && SenhaUsuario == Senha_Correta)
    {
        Console.WriteLine("Login efetuado com sucesso!");
        contador++;

    }
    else
    {
        Console.WriteLine("Usuário ou senha inválidos. Tente novamente!");
        contador++;
    }
} while (contador != 3);
#endregion
// Nivel 3: Estruturas de Repetição
#region 1. Contagem Regressiva
for (int i = 10; i >= 1; i--)
{
    Thread.Sleep(1000);
    Console.WriteLine(i);
}
Console.WriteLine("Lançar");

#endregion
