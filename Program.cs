// Exercício do curso do Nélio Alves "Média Vetor"
// Esse programa o usuário irá digitar as notas de um aluno conforme a quantidade "N".
// Em seguida o programa mostrará a média aritimética de toas as notas e também, quais delas estáo abaixo da média.


int N = int.Parse(Console.ReadLine());
double [] Notas = new double[N];

string [] X = Console.ReadLine().Split(' ');

// Comando para leitura das notas na mesma linha;
for (int i = 0; i < N; i++)
{
    Notas[i] = double.Parse(X[i]);
}

// Comando para calcular média aritimética das notas;
double Media, Soma = 0;
for (int i = 0; i < N; i ++)
{
    Soma = Soma + Notas[i];
}
Media = Soma / N;
Console.WriteLine(Media.ToString("F3"));

// Comando para mostrar as as notas abaixo da média;
for (int i = 0; i < N; i ++)
{
    if (Notas[i] < Media)
    {
        Console.WriteLine(Notas[i].ToString("F1"));
    }
}