// // // See https://aka.ms/new-console-template for more information
// // // Console.WriteLine("Hello, World!");


// // // tipo: textos atributo: nome
// // using System.Collections.Specialized;
// // using System.ComponentModel;
// // using System.Data;
// // using System.Diagnostics;
// // using System.Reflection.Emit;
// // using System.Reflection.Metadata;
// // using System.Reflection.Metadata.Ecma335;
// // using System.Runtime.CompilerServices;
// // using System.Runtime.InteropServices.Marshalling;
// // using System.Runtime.Serialization;
// // using System.Runtime.Serialization.Formatters;
// // using System.Security.Cryptography;
// // using System.Security.Principal;
// // using System.Text;

// // string nome = "samuel";
// // // Console.WriteLine(nome); 



// // nome = "rarin";
// // // Console.WriteLine(nome);

// // // Console.WriteLine("hello " + nome);
// // // Console.WriteLine($"hello {nome}");

// // nome = "        samuel          ";
// // // Console.WriteLine($"ola{nome}");


// // string nomeTratado = nome.Trim();
// // // Console.WriteLine($"ola {nomeTratado}");

// // // Console.WriteLine(nome.Length);
// // // Console.WriteLine(nomeTratado.Length);

// // string frase = "bom dia, bem vindos o senai";
// // String fraseModificada = frase.Replace("m dia", "a noite");
// // // Console.WriteLine(fraseModificada);

// // // Console.WriteLine(fraseModificada.Contains("noite"));

// // bool palavraEncontrada = fraseModificada.Contains("noite");
// // // bool palavraEncontrada = fraseModificada.StartsWith("noite");
// // // bool palavraEncontrada = fraseModificada.EndsWith("noite");
// // // Console.WriteLine(palavraEncontrada);

// // Console.WriteLine($"digite um numero:");
// // string? numero = Console.ReadLine();
// // Console.WriteLine(numero);

// //======================================================================================================
// // ------------  NUMERICOS ----------------   
// // string idade = "20"; // se nao houver calculo 

// // using System.Runtime.InteropServices;

// // int idade = 20; //inteiro, se houver calculo 

// // double altura = 1.70;  // (casa decimal) (16 decimais)

// // float temperatua = 25.1f; //(casa decimal) (7 decimais) (f- considere poucas casas decimais) 

// // int x = 10;
// // int y = 5;

// // Console.WriteLine(x + y); // soma
// // Console.WriteLine(x - y); // subtraçaao
// // Console.WriteLine(x * y); // multiplicaçao
// // Console.WriteLine(x / y); // divisao
// // Console.WriteLine(x % y); // resto da divisao

// // Console.WriteLine(Math.Pow(10, 5)); // potencia
// // Console.WriteLine(Math.Sqrt(25)); // raiz quadrada 
// // Console.WriteLine(Math.Round(10.5)); // arredonda 
// // Console.WriteLine(Math.Max(10 ,5)); // maximo
// // Console.WriteLine(Math.Min(10 ,5)); // minimo
// //=========================================================================

// //=========================================================================
// //---------------- CASO HAJA QUEBRA DE SISTEMA -------------------------
// // Console.WriteLine($"digite um numero ");
// // string numero = Console.ReadLine();
// //  int.TryParse(numero, out int numeroConvertido ); 
// // Console.WriteLine($"oque sobrou p beta {numeroConvertido * 2 } ");
// //========================================================================


// // bool maiorIdade = true; 
// // bool maiorIdade = false; 
// //=========================================================================

// //========================================================================
// // mostrar "maior de idade" | mostrar "menor de idade"
// // se a idade dele for > 18 | se a idade for < de 18
// //------------------ IF / ELSE -----------------------------------------

// // Console.WriteLine($"Digite sua idade:");
// // int idade = int.Parse(Console.ReadLine()); // string convertido em int;

// // //strutura condicional
// // if (idade >= 18) // condiçao
// // {
// //    Console.WriteLine($"Maior De Idade");

// // }
// // else 
// // { 
// //   Console.WriteLine($"Menor De Idade");

// // }
// //============================================================================


// //===============================================================
// // EXERCICIO - PEÇA UMA NOTA E INFORME SE ESTA APROVADA
// // Console.WriteLine($"Informe Sua Nota:");
// // int nota = int.Parse(Console.ReadLine());

// // if (nota >=7)
// // { Console.WriteLine($"Aprovado");


// // } else
// // {
// //     Console.WriteLine($"Reprovado");

// // }
// //=========================================================

// //------------  MAIS CONDIÇOES ------------------------------
// // Console.WriteLine($"Digite sua idade:");
// //  int idade = int.Parse(Console.ReadLine());

// //  if (idade <= 10)
// //  {
// //      Console.WriteLine($"pivet");

// //  } else if (idade <=18) // else if quando se trata do mesmo elemento 
// //  {
// //     Console.WriteLine($"jovenzinho");

// //  }else
// //  {
// //     Console.WriteLine($"adulto");

// //  }
// //===========================================================

// //  Console.WriteLine($"Digite sua Nota Do Boletim:");
// //  int nota = int.Parse(Console.ReadLine());

// //  if (nota >=7)
// //  {
// //     Console.WriteLine($"Aprovado");

// //  } else if (nota <= 5)
// //  { Console.WriteLine($"Recuperaçao");


// //  } else 
// //  { 
// //     Console.WriteLine($"Reprovado");

// //  }
// //==============================================================

// //switch nao e posivel fazer comparaçoes) somente ==

// // Console.WriteLine($"selecione um prato");
// // string prato = Console.ReadLine();

// //  switch (prato) // somente igualdade



// //  { case "arroz":
// //  Console.WriteLine($"o valor é R$10,00");
// //  break;

// //  case "macarrao":
// //  Console.WriteLine($"o valor é R$18,00");
// //  break;



// //     default:
// //     Console.WriteLine($"nao temos essa opçao ");

// //     break;
// //  }
// //===================================================================





// // -----------------------------PEÇA UM NUMERO DE 1 A 7 E MOSTRE O DIA DA SEMANA-----------------------------
// // Console.WriteLine($"Digite um numero");
// // string numero = Console.ReadLine();

// // switch (numero) // somente igualdade



// //  { case "1":
// //  Console.WriteLine($"segunda feira");
// //  break;

// //  case "2":
// //  Console.WriteLine($"terça feira");
// //  break;

// //  case "3":
// //  Console.WriteLine($"quarta feira");
// //  break;

// //  case "4":
// //  Console.WriteLine($"quinta feira");
// //  break;

// //  case "5":
// //  Console.WriteLine($"sexta feira");
// //  break;

// //  case "6":
// //  Console.WriteLine($"sabado");
// //  break;

// //  case "7":
// //  Console.WriteLine($"domingo");
// //  break;
// //     default:
// //     Console.WriteLine($"nao temos essa opçao ");

// //     break;
// //  }
// //========================================================================================================
// // ESCREVER NO CONSOLE "ddd dd mmm yyyy
// // using System.Globalization;
// // Console.WriteLine(DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
// //===================================================================================================



// // DateTime agora = DateTime.Now;
// // string mes;
// // switch (agora.Month)
// // {
// //     case 1: 
// //     mes = "Janeiro";
// //     break;
// //     case 2:
// //     mes = "Fevereiro";
// //     break;
// //     case 3:
// //     mes = "Março";
// //     break;
// //     case 4:
// //     mes = "Abril";
// //     break;
// //     case 5:
// //     mes = "Maio";
// //     break;
// //     case 6:
// //     mes = "Junho";
// //     break;
// // }


// // string semana;
// // switch (agora.DayOfWeek.ToString())
// // {
// //     case "Sunday":
// //         semana = "Domingo";
// //         break;
// //     case "Monday":
// //         semana = "Segunda-feira";
// //         break;
// //     case "Tuesday":
// //         semana = "Terça-feira";
// //         break;
// //     case "Wednesday":
// //         semana = "Quarta-feira";
// //         break;
// //     case "Thursday":
// //         semana = "Quinta-feira";
// //         break;
// //     case "Friday":
// //         semana = "Sexta-feira";
// //         break;
// //     case "Saturday":
// //         semana = "Sábado";
// //         break;
// //     default:
// //         semana = "";
// //         break;
// // }
// // Console.WriteLine($"{agora.ToString("dddd dd 'de' MMMM 'de' yyyy")}, e faltam {365 - agora.DayOfYear} para o fim do ano.");

// // // 1int numero = 10;
// // // Console.WriteLine($"{numero.ToString("C")}"); // identiica o tipo do numero e coloca o simbolo da moeda


// //=============================================  ARRAY  ==================================================

// //[] significa que é um array, ou seja, uma coleção de dados do mesmo tipo.
// // 0 a 6
// // String  [] nomes = new string [7]; // array de string com 7 posiçoes
// // nomes [0] = "samuel";
// // nomes [1] = "rarin";    
// // Console.WriteLine($"{nomes[0]}");
// //--------------------------------------------------------------------
// // bool [] saila new bool [10]; // array de booleanos com 10 posiçoes
// //----------------------------------------------------------------------------------------------------------------
// // int [] valores = [0]; // gera um array de inteiros com 1 posiçao, e o valor dessa posiçao é 0
// // int [] valores = {5, 0, 1, 10}; // gera um array de inteiros com 3 posiçoes, e os valores dessas posiçoes são 5, 0 e 1 respectivamente
// // Console.WriteLine($"{valores[1]}");
// //-------------------------------------------------------------
// // estrutura de repetição for, quando se sabe o numero de vezes que a estrutura deve ser repetida
// // for (int i = 0; i < 10; i++) //serve para percorrer o array, i é o indice do array, e valores.Length é o tamanho do array
// // {
// //     Console.WriteLine($"666-777 harida");
// // }
// // {

// // }
// // // estrutura de repetição while, quando nao se sabe o numero de vezes que a estrutura deve ser repetida
// // int i = 0;
// // if  (i < 10)
// // {
// //     Console.WriteLine($"666-777 harida");
// //     i = i + 1; //++ ou i += 1
// // }

// String  [] nomes = new string [7]; 
// nomes [0] = "samuel";
// nomes [1] = "rarin";    
// for (int i = 0; i < nomes.Length; i++) // consulta o tamanho do array, e enquanto o indice for menor que o tamanho do array, ele vai executar o bloco de codigo
// {

// Console.WriteLine($"{nomes[0]}");
// }

// // A CADA VOLRA O FOR AMENTA UM NUMERO, E ESSE NUMERO É O INDICE DO ARRAY, ENTÃO ELE VAI PERCORRER O ARRAY E IMPRIMIR O VALOR DE CADA POSIÇÃO DO ARRAY.




//==========================================================================================
// //------------------- EXERCICIO - PEÇA 5 NOMES E IMPRIMA-OS --------------------------------
// using System.Diagnostics; //

// String [] nomes = new string[5]; // ISSO FAZ UM ARRAY DE STRING COM 5 POSIÇÕES, E CADA POSIÇÃO DO ARRAY VAI RECEBER UM NOME DIGITADO PELO USUÁRIO.
// for (int i = 0; i <5; i++) // ISSO FAZ UM LAÇO DE REPETIÇÃO QUE VAI SE REPETIR 5 VEZES, E A CADA VEZ O VALOR DE I VAI AUMENTAR EM 1, E ESSE VALOR DE I VAI SER USADO COMO INDICE DO ARRAY PARA ARMAZENAR O NOME DIGITADO PELO USUÁRIO.
// {
//     Console.Write($"Digite o {i + 1}  nome : "); // ISSO IMPRIME NO CONSOLE A MENSAGEM "DIGITE O NOME" E O NUMERO DO NOME QUE O USUÁRIO DEVE DIGITAR, O NUMERO DO NOME É DADO POR I+1, POIS O INDICE DO ARRAY COMEÇA EM 0, ENTÃO PARA MOSTRAR O NUMERO DO NOME PARA O USUÁRIO, É PRECISO SOMAR 1 AO VALOR DE I.
//     nomes[i] = Console.ReadLine(); // ISSO LÊ O NOME DIGITADO PELO USUÁRIO E ARMAZENA NO ARRAY NA POSIÇÃO INDICADA POR I.
// }


// //==========================================================================================
// //------------------- EXERCICIO - IMPRIMA OS NOMES DIGITADOS --------------------------------
// for (int i = 0; i < nomes.Length; i++) // ISSO FAZ UM LAÇO DE REPETIÇÃO QUE VAI SE REPETIR O NOME DE VEZES, ONDE NOME DE VEZES É O TAMANHO DO ARRAY, E A CADA VEZ O VALOR DE I VAI AUMENTAR EM 1, E ESSE VALOR DE I VAI SER USADO COMO INDICE DO ARRAY PARA IMPRIMIR O NOME ARMAZENADO NA POSIÇÃO INDICADA POR I.
// {
//     Console.WriteLine($"Nome {i+1}: {nomes[i]}"); // ISSO IMPRIME NO CONSOLE A MENSAGEM "NOME" E O NUMERO DO NOME, E O NOME ARMAZENADO NA POSIÇÃO INDICADA POR I, O NUMERO DO NOME É DADO POR I+1, POIS O INDICE DO ARRAY COMEÇA EM 0, ENTÃO PARA MOSTRAR O NUMERO DO NOME PARA O USUÁRIO, É PRECISO SOMAR 1 AO VALOR DE I.
// }

//===========================================================================================
// string[] nomes = new string[5]; // tamanho fixo
using System.Runtime.Intrinsics.X86;

// List<string> nomes = new List<string>(); // ISSO FAZ UMA LISTA DE STRING, ONDE CADA ELEMENTO DA LISTA VAI RECEBER UM NOME DIGITADO PELO USUÁRIO. INT OU STRING, O TIPO DE DADO DA LISTA É DEFINIDO
// nomes.Add("samuel"); // ISSO ADICIONA O NOME "SAMUEL" NA LISTA, E O NOME VAI FICAR NA POSIÇÃO 0 DA LISTA, POIS A LISTA COMEÇA EM 0.
// nomes.Add("rarin"); 

// Console.WriteLine($"Nomes digitados:"); // ISSO IMPRIME NO CONSOLE A MENSAGEM "DIGITE UM NOME" PARA O USUÁRIO.


// foreach (string nome  in nomes) // ISSO FAZ UM LAÇO DE REPETIÇÃO QUE VAI PERCORRER CADA ELEMENTO DA LISTA, E A CADA VEZ O VALOR DE NOME VAI RECEBER O VALOR DO ELEMENTO ATUAL DA LISTA, E O BLOCO DE CODIGO DENTRO DO FOREACH VAI SER EXECUTADO PARA CADA ELEMENTO DA LISTA.
// {
//     Console.WriteLine(nome); // ISSO IMPRIME NO CONSOLE O NOME ATUAL DA LISTA, E A CADA VEZ O VALOR DE NOME VAI RECEBER O VALOR DO ELEMENTO ATUAL DA LISTA, ENTÃO ELE VAI IMPRIMIR O NOME "SAMUEL" E O NOME "RARIN" NA LISTA.
// }

//  // ISSO REMOVE O NOME "RARIN" DA LISTA, E O NOME VAI SER REMOVIDO DA POSIÇÃO 1 DA LISTA, POIS O NOME "RARIN" ESTAVA NA POSIÇÃO 1 DA LISTA. SE O NOME NÃO EXISTIR NA LISTA, O MÉTODO REMOVE NÃO VAI FAZER NADA. SE HOUVER MAIS DE UM ELEMENTO COM O MESMO VALOR, APENAS O PRIMEIRO ELEMENTO ENCONTRADO VAI SER REMOVIDO.
// nomes.Remove("rarin");
// Console.WriteLine($"lista atulizada2026"); // ISSO IMPRIME NO CONSOLE A MENSAGEM "NOMES DIGITADOS" PARA O USUÁRIO, APÓS A REMOÇÃO DO NOME "RARIN" DA LISTA.
    
// foreach (string nome in nomes) // isso FAZ UM LAÇO DE REPETIÇÃO QUE VAI PERCORRER CADA ELEMENTO DA LISTA, E A CADA VEZ O VALOR DE NOME VAI RECEBER O VALOR DO ELEMENTO ATUAL DA LISTA, E O BLOCO DE CODIGO DENTRO DO FOREACH VAI SER EXECUTADO PARA CADA ELEMENTO DA LISTA. APÓS A REMOÇÃO DO NOME "RARIN" DA LISTA, O LAÇO DE REPETIÇÃO VAI PERCORRER APENAS O NOME "SAMUEL", POIS O NOME "RARIN" FOI REMOVIDO DA LISTA.
// {
//     Console.WriteLine(nome); // isso IMPRIME NO CONSOLE O NOME ATUAL DA LISTA, APÓS A REMOÇÃO DO NOME "RARIN" DA LISTA.
// // }
//========================================================================================================================
// //-------------------------------- PEÇA 5 NOMES E ARMAZENE EM UMA LISTA USANDO LIST. --------------------------------
// List<string> nomes2 = new List<string>(); 
// for (int i = 0; i < 5; i++) // ISSO FAZ UM LAÇO DE REPETIÇÃO QUE VAI SE REPETIR 5 VEZES, E A CADA VEZ O VALOR DE I VAI AUMENTAR EM 1, E ESSE VALOR DE I VAI SER USADO COMO INDICE DO ARRAY PARA ARMAZENAR O NOME DIGITADO PELO USUÁRIO.
// {
//     Console.Write($"Digite o {i + 1} nome: "); // ISSO IMPRIME NO CONSOLE A MENSAGEM "DIGITE O NOME" E O NUMERO DO NOME QUE O USUÁRIO DEVE DIGITAR, O NUMERO DO NOME É DADO POR I+1, POIS O INDICE DO ARRAY COMEÇA EM 0, ENTÃO PARA MOSTRAR O NUMERO DO NOME PARA O USUÁRIO, É PRECISO SOMAR 1 AO VALOR DE I.
//     string nome = Console.ReadLine(); // ISSO LÊ O NOME DIGITADO PELO USUÁRIO E ARMAZENA NA VARIÁVEL NOME.
//     nomes2.Add(nome); // ISSO ADICIONA O NOME DIGITADO PELO USUÁRIO NA LISTA, E O NOME VAI FICAR NA POSIÇÃO DA LISTA CORRESPONDENTE AO VALOR DE I, POIS A LISTA COMEÇA EM 0.
// }
// Console.WriteLine($"Nomes digitados:"); // ISSO IMPRIME NO CONSOLE A MENSAGEM "DIGITE UM NOME" PARA O USUÁRIO.

// foreach (string nome in nomes2) // ISSO FAZ UM LAÇO DE REPETIÇÃO QUE VAI PERCORRER CADA ELEMENTO DA LISTA, E A CADA VEZ O VALOR DE NOME VAI RECEBER O VALOR DO ELEMENTO ATUAL DA LISTA, E O BLOCO DE CODIGO DENTRO DO FOREACH VAI SER EXECUTADO PARA CADA ELEMENTO DA LISTA.
// {
//     Console.WriteLine(nome); // ISSO IMPRIME NO CONSOLE O NOME ATUAL DA LISTA.
// }
//========================================================================================================================
//------------------------------- COREÇAO --------------------------------

// List<string> nomes = new List<string>();
// for (int i = 0; i <5; i++)
// {
//     Console.WriteLine($"digite o {i + 1} nome:");
//     nomes.Add(Console.ReadLine());
// }
// Console.WriteLine($"os nomes digitados sao:");
// foreach (string n in nomes)
// {
//      Console.WriteLine(n);    
// }
//========================================================================================================================


List<string> nomes = new List<string> ();
nomes.Add("samuel");
nomes.Add("guidolin");
nomes.Add("ribeiro");

//=============================
// Console.WriteLine(nomes.Count); // ISSO IMPRIME NO CONSOLE O NÚMERO DE ELEMENTOS DA LISTA, QUE É 3, POIS A LISTA CONTÉM 3 ELEMENTOS: "SAMUEL", "GUIDOLIN" E "RIBEIRO". usado para lista
//=============================
//=================================================
Console.WriteLine(nomes.Find(n => n == "samuel")); // ISSO IMPRIME NO CONSOLE O NOME "SAMUEL", POIS O MÉTODO FIND PROCURA NA LISTA O ELEMENTO QUE CORRESPONDE AO VALOR ESPECIFICADO, E SE ENCONTRAR, ELE RETORNA O VALOR DO ELEMENTO ENCONTRADO. SE NÃO ENCONTRAR, ELE RETORNA NULL. USADO PARA LISTA
//=================================================
