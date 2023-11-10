using bytebank_ATENDIMENTO.bytebank.Atendimento;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
new ByteBankAtendimento().AtendimentoCliente();

//#region
//int[] idades = new int[5];
//idades[0] = 30;
//idades[1] = 40;
//idades[2] = 17;
//idades[3] = 21;
//idades[4] = 18;

//Array amostra = Array.CreateInstance(typeof(double), 6);
//amostra.SetValue(6.9, 4);
//amostra.SetValue(10, 3);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(11, 5);

//void TestaBuscaPalavra()
//{
//    string[] arrayDePalavras = new string[5];

//    for (int i = 0; i < arrayDePalavras.Length; i++)
//    {
//        Console.Write($"Digite {i+1}ª palavra: ");
//        arrayDePalavras[i] = Console.ReadLine()!;
//    }

//    Console.Write("Digite palavra a ser encontrada: ");
//    string busca = Console.ReadLine()!;

//    foreach (string palavra in arrayDePalavras)
//    {
//        if (palavra.Equals(busca))
//        {
//            Console.WriteLine($"Palavra encontrada = {busca}");
//            break;
//        }
//    }
//}

//void TestaMediana(Array array)
//{
//    if ((array == null) || (array.Length == 0)) {
//        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
//    }
//    else
//    {
//        double[] numeroOrdenados = (double[])array.Clone();
//        Array.Sort(numeroOrdenados);
//        int tamanho = numeroOrdenados.Length;
//        int meio = tamanho / 2;
//        double mediana = (tamanho % 2 != 0) ? numeroOrdenados[meio] : (numeroOrdenados[meio] + numeroOrdenados[meio - 1]) / 2;
//        Console.WriteLine($"Com base na amostra, a mediana é igual a {mediana}");
//    }
//}

////int[] valores = { 10, 58, 36, 47 };
////for (int i = 0; i < 5; i++)
////{
////    Console.WriteLine(valores[i]);
////}
//void TestaArrayDeContasCorrentes()
//{
//    ContaCorrente[] listasDeContas = new ContaCorrente[]
//    {
//        new ContaCorrente(874, "5679787-A"),
//        new ContaCorrente(874, "4456668-B"),
//        new ContaCorrente(874, "7781438-C"),
//    };

//    for (int i = 0; i < listasDeContas.Length; i++)
//    {
//        ContaCorrente contaAtual = listasDeContas[i];
//        Console.WriteLine($"Índice {i} - Conta {contaAtual.Conta}");
//    }
//}
//#endregion

//List<string> nomesDosEscolhidos = new List<string>()
//{
//    "Bruce Wayne",
//    "Carlos Vilagran",
//    "Richard Grayson",
//    "Bob Kane",
//    "Will Farrel",
//    "Lois Lane",
//    "General Welling",
//    "Perla Letícia",
//    "Uxas",
//    "Diana Prince",
//    "Elisabeth Romanova",
//    "Anakin Wayne"
//};

//void buscarEscolhido(List<string> nomes, string nomeAProcurar)
//{
//    Console.WriteLine();
//    foreach (string nome in nomes)
//    {
//        if (nomes.Contains(nomeAProcurar))
//        {
//            Console.WriteLine($"Sua busca logrou exito. {nomeAProcurar} foi encontrado e é um dos escolhidos\n");
//            return;
//        }
//    }
//    Console.WriteLine($"Infelismente {nomeAProcurar} não é um dos escolhidos\n");
//}

//buscarEscolhido(nomesDosEscolhidos, "Genral Welling");