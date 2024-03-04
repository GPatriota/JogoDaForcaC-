using System.ComponentModel;

Console.WriteLine ("Digite a palavra que você quer que seja adivinhada.");
string palavra = Console.ReadLine();
Console.Clear();

int caracteres = palavra.Length;
var texto = new string ('_', caracteres);

Console.WriteLine ($"A palavra para ser adivinhada já foi escolhida, ela possui {caracteres} caracteres.\n {texto}\n");
Console.WriteLine ("Cada '_' acima indica um caracter oculto da palavra, conforme for acertado uma letra, o caracter deixará de ser oculto e irá se transformar na letra.");
int erros = 0;
string palavraCobaia = "";
string palavraChute = "";
string palavraAtual = "";
int tentativas = 0;
Console.WriteLine ("Deseja chutar uma letra ou digitar a palavra?\n1 - Chutar a Letra\n2 - Chutar a palavra");
int opcao = int.Parse(Console.ReadLine());
int errosCobaia = 0;
if (opcao == 1)
{
    Console.WriteLine ("Digite a letra que deseja confirmar se tem na palavra:");
    char letra = char.Parse (Console.ReadLine());
    tentativas += 1;
    for (int i = 0; i<palavra.Length;i++)
    {
        if (palavra[i] == letra)
        {
            palavraCobaia += letra;
            errosCobaia += 1;
        }
        else
        {
            palavraCobaia += "_";
        }
    }
    if (errosCobaia == 0)
    {
        erros += 1;
    }
    errosCobaia = 0;
    palavraAtual = palavraCobaia;
    palavraCobaia = "";
    int opcao2 = 0;
    Console.WriteLine ("Sua palavra atualizada com suas tentativas e erros são:");
    Console.WriteLine ($"{palavraAtual}\n");
    Console.WriteLine ($"Seu número de erros é de: {erros}.\nSeu número de tentativas é: {tentativas}.");
    Console.WriteLine ("Deseja chutar uma letra ou digitar a palavra?\n1 - Chutar a Letra\n2 - Chutar a palavra");
    opcao2 = int.Parse(Console.ReadLine ());
    tentativas += 1;
    if (opcao2 == 1)
    {
        for (int i = erros; i <= 5; tentativas++)
        {
            Console.WriteLine ("Digite a letra que deseja confirmar se tem na palavra:");
            letra = char.Parse (Console.ReadLine());
            for (int x = 0; x<palavra.Length;x++)
            {
                if (palavra[x] == letra)
                {
                    palavraCobaia += letra;
                    errosCobaia += 1;
                }
                else
                {
                    if (palavraAtual[x] == '_')
                    {
                        palavraCobaia = palavraCobaia + "_";
                    }
                    else
                    {
                        palavraCobaia = palavraCobaia + palavraAtual[x];
                    }
                }
            }
            if (errosCobaia == 0)
            {
                i += 1;
            }
            erros = i;
            errosCobaia = 0;
            palavraAtual = palavraCobaia;
            palavraCobaia = "";
        
            if (i == 6)
            {
                Console.WriteLine ("Você perdeu, alcançou a quantidade máxima de erros (6).");
            }
            else
            {
                Console.WriteLine ("Sua palavra atualizada com suas tentativas e erros são:");
                Console.WriteLine ($"{palavraAtual}\n");
                Console.WriteLine ($"Seu número de erros é de: {i}.\nSeu número de tentativas é: {tentativas}.");
                Console.WriteLine ("Deseja chutar uma letra ou digitar a palavra?\n1 - Chutar a Letra\n2 - Chutar a palavra");
                int opcao3 = 0;
                opcao3 = int.Parse(Console.ReadLine ());
            
                if (opcao3 == 2)
                {
                    opcao = 2;
                    break;
                }
            }
        }
    }
    else if (opcao2 == 2)
    {
        opcao = 2;
    }
}

if (opcao ==2)
{
    Console.WriteLine ("Digite a palavra que você acredita ser:");
    palavraChute = Console.ReadLine();
    if (palavraChute == palavra)
    {
        Console.WriteLine ($"Parabéns, você ganhou com {tentativas} tentativas e {erros} erros.");
    }
    else
    {
        Console.WriteLine ("Você perdeu.");
    }
    
}





