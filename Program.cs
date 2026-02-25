// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");


// // tipo: textos atributo: nome
// using System.Collections.Specialized;
// using System.ComponentModel;
// using System.Data;
// using System.Diagnostics;
// using System.Reflection.Emit;
// using System.Reflection.Metadata;
// using System.Reflection.Metadata.Ecma335;
// using System.Runtime.CompilerServices;
// using System.Runtime.InteropServices.Marshalling;
// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Formatters;
// using System.Security.Cryptography;
// using System.Security.Principal;
// using System.Text;

// string nome = "samuel";
// // Console.WriteLine(nome); 



// nome = "rarin";
// // Console.WriteLine(nome);

// // Console.WriteLine("hello " + nome);
// // Console.WriteLine($"hello {nome}");

// nome = "        samuel          ";
// // Console.WriteLine($"ola{nome}");


// string nomeTratado = nome.Trim();
// // Console.WriteLine($"ola {nomeTratado}");

// // Console.WriteLine(nome.Length);
// // Console.WriteLine(nomeTratado.Length);

// string frase = "bom dia, bem vindos o senai";
// String fraseModificada = frase.Replace("m dia", "a noite");
// // Console.WriteLine(fraseModificada);

// // Console.WriteLine(fraseModificada.Contains("noite"));

// bool palavraEncontrada = fraseModificada.Contains("noite");
// // bool palavraEncontrada = fraseModificada.StartsWith("noite");
// // bool palavraEncontrada = fraseModificada.EndsWith("noite");
// // Console.WriteLine(palavraEncontrada);

// Console.WriteLine($"digite um numero:");
// string? numero = Console.ReadLine();
// Console.WriteLine(numero);

//======================================================================================================
// ------------  NUMERICOS ----------------   
// string idade = "20"; // se nao houver calculo 

// using System.Runtime.InteropServices;

// int idade = 20; //inteiro, se houver calculo 

// double altura = 1.70;  // (casa decimal) (16 decimais)

// float temperatua = 25.1f; //(casa decimal) (7 decimais) (f- considere poucas casas decimais) 

// int x = 10;
// int y = 5;

// Console.WriteLine(x + y); // soma
// Console.WriteLine(x - y); // subtraçaao
// Console.WriteLine(x * y); // multiplicaçao
// Console.WriteLine(x / y); // divisao
// Console.WriteLine(x % y); // resto da divisao

// Console.WriteLine(Math.Pow(10, 5)); // potencia
// Console.WriteLine(Math.Sqrt(25)); // raiz quadrada 
// Console.WriteLine(Math.Round(10.5)); // arredonda 
// Console.WriteLine(Math.Max(10 ,5)); // maximo
// Console.WriteLine(Math.Min(10 ,5)); // minimo
//=========================================================================

//=========================================================================
//---------------- CASO HAJA QUEBRA DE SISTEMA -------------------------
// Console.WriteLine($"digite um numero ");
// string numero = Console.ReadLine();
//  int.TryParse(numero, out int numeroConvertido ); 
// Console.WriteLine($"oque sobrou p beta {numeroConvertido * 2 } ");
//========================================================================


// bool maiorIdade = true; 
// bool maiorIdade = false; 
//=========================================================================

//========================================================================
// mostrar "maior de idade" | mostrar "menor de idade"
// se a idade dele for > 18 | se a idade for < de 18
//------------------ IF / ELSE -----------------------------------------

// Console.WriteLine($"Digite sua idade:");
// int idade = int.Parse(Console.ReadLine()); // string convertido em int;

// //strutura condicional
// if (idade >= 18) // condiçao
// {
//    Console.WriteLine($"Maior De Idade");

// }
// else 
// { 
//   Console.WriteLine($"Menor De Idade");

// }
//============================================================================


//===============================================================
// EXERCICIO - PEÇA UMA NOTA E INFORME SE ESTA APROVADA
// Console.WriteLine($"Informe Sua Nota:");
// int nota = int.Parse(Console.ReadLine());

// if (nota >=7)
// { Console.WriteLine($"Aprovado");


// } else
// {
//     Console.WriteLine($"Reprovado");

// }
//=========================================================

//------------  MAIS CONDIÇOES ------------------------------
// Console.WriteLine($"Digite sua idade:");
//  int idade = int.Parse(Console.ReadLine());

//  if (idade <= 10)
//  {
//      Console.WriteLine($"pivet");

//  } else if (idade <=18) // else if quando se trata do mesmo elemento 
//  {
//     Console.WriteLine($"jovenzinho");

//  }else
//  {
//     Console.WriteLine($"adulto");

//  }
//===========================================================

//  Console.WriteLine($"Digite sua Nota Do Boletim:");
//  int nota = int.Parse(Console.ReadLine());

//  if (nota >=7)
//  {
//     Console.WriteLine($"Aprovado");

//  } else if (nota <= 5)
//  { Console.WriteLine($"Recuperaçao");


//  } else 
//  { 
//     Console.WriteLine($"Reprovado");

//  }
//==============================================================

//switch nao e posivel fazer comparaçoes) somente ==

// Console.WriteLine($"selecione um prato");
// string prato = Console.ReadLine();

//  switch (prato) // somente igualdade



//  { case "arroz":
//  Console.WriteLine($"o valor é R$10,00");
//  break;

//  case "macarrao":
//  Console.WriteLine($"o valor é R$18,00");
//  break;



//     default:
//     Console.WriteLine($"nao temos essa opçao ");

//     break;
//  }
//===================================================================





// -----------------------------PEÇA UM NUMERO DE 1 A 7 E MOSTRE O DIA DA SEMANA-----------------------------
// Console.WriteLine($"Digite um numero");
// string numero = Console.ReadLine();

// switch (numero) // somente igualdade



//  { case "1":
//  Console.WriteLine($"segunda feira");
//  break;

//  case "2":
//  Console.WriteLine($"terça feira");
//  break;

//  case "3":
//  Console.WriteLine($"quarta feira");
//  break;

//  case "4":
//  Console.WriteLine($"quinta feira");
//  break;

//  case "5":
//  Console.WriteLine($"sexta feira");
//  break;

//  case "6":
//  Console.WriteLine($"sabado");
//  break;

//  case "7":
//  Console.WriteLine($"domingo");
//  break;
//     default:
//     Console.WriteLine($"nao temos essa opçao ");

//     break;
//  }
//========================================================================================================
// ESCREVER NO CONSOLE "ddd dd mmm yyyy
// using System.Globalization;
// Console.WriteLine(DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
//===================================================================================================



// DateTime agora = DateTime.Now;
// string mes;
// switch (agora.Month)
// {
//     case 1: 
//     mes = "Janeiro";
//     break;
//     case 2:
//     mes = "Fevereiro";
//     break;
//     case 3:
//     mes = "Março";
//     break;
//     case 4:
//     mes = "Abril";
//     break;
//     case 5:
//     mes = "Maio";
//     break;
//     case 6:
//     mes = "Junho";
//     break;
// }


// string semana;
// switch (agora.DayOfWeek.ToString())
// {
//     case "Sunday":
//         semana = "Domingo";
//         break;
//     case "Monday":
//         semana = "Segunda-feira";
//         break;
//     case "Tuesday":
//         semana = "Terça-feira";
//         break;
//     case "Wednesday":
//         semana = "Quarta-feira";
//         break;
//     case "Thursday":
//         semana = "Quinta-feira";
//         break;
//     case "Friday":
//         semana = "Sexta-feira";
//         break;
//     case "Saturday":
//         semana = "Sábado";
//         break;
//     default:
//         semana = "";
//         break;
// }
// Console.WriteLine($"{agora.ToString("dddd dd 'de' MMMM 'de' yyyy")}, e faltam {365 - agora.DayOfYear} para o fim do ano.");

// // 1int numero = 10;
// // Console.WriteLine($"{numero.ToString("C")}"); // identiica o tipo do numero e coloca o simbolo da moeda


//=============================================  ARRAY  ==================================================

//[] significa que é um array, ou seja, uma coleção de dados do mesmo tipo.
// 0 a 6
// String  [] nomes = new string [7]; // array de string com 7 posiçoes
// nomes [0] = "samuel";
// nomes [1] = "rarin";    
// Console.WriteLine($"{nomes[0]}");
//--------------------------------------------------------------------
// bool [] saila new bool [10]; // array de booleanos com 10 posiçoes
//----------------------------------------------------------------------------------------------------------------
// int [] valores = [0]; // gera um array de inteiros com 1 posiçao, e o valor dessa posiçao é 0
// int [] valores = {5, 0, 1, 10}; // gera um array de inteiros com 3 posiçoes, e os valores dessas posiçoes são 5, 0 e 1 respectivamente
// Console.WriteLine($"{valores[1]}");
//-------------------------------------------------------------
// estrutura de repetição for, quando se sabe o numero de vezes que a estrutura deve ser repetida
// for (int i = 0; i < 10; i++) //serve para percorrer o array, i é o indice do array, e valores.Length é o tamanho do array
// {
//     Console.WriteLine($"666-777 harida");
// }
// {
    
// }
// estrutura de repetição while, quando nao se sabe o numero de vezes que a estrutura deve ser repetida
// int i = 0;
// if  (i < 10)
// {
//     Console.WriteLine($"666-777 harida");
//     i = i + 1; //++ ou i += 1
// }

String  [] nomes = new string [7]; 
nomes [0] = "samuel";
nomes [1] = "rarin";    
for (int i = 0; i < nomes.Length; i++) // consulta o tamanho do array, e enquanto o indice for menor que o tamanho do array, ele vai executar o bloco de codigo
{
    
Console.WriteLine($"{nomes[0]}");
}

// A CADA VOLRA O FOR AMENTA UM NUMERO, E ESSE NUMERO É O INDICE DO ARRAY, ENTÃO ELE VAI PERCORRER O ARRAY E IMPRIMIR O VALOR DE CADA POSIÇÃO DO ARRAY.



for (int i = 1; i <= 10; i=i+2)
{
    Console.WriteLine($"1 x {i} = {1 * i}");
    
} 

//peça 5 nomes e armazene em um array.