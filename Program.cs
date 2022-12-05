using System;
using System.Diagnostics;
using System.IO;

namespace Calculo
{
  public class Program
  {
    static void Main(String[] args)
    {
      int C1, C2, i;
      float C3;
      double R1, R2, R3,R4;

      for (i = 1; i <= 15; i++)
      {


        //Inicio

        Console.WriteLine("->Base de calculo do Paypal<-");

        //opcao de escolha

        Console.WriteLine("\n");

        Console.WriteLine("*Opcoes disponiveis*");

        Console.WriteLine("\n");

        Console.WriteLine("[1] Fazer outro cotacao");
        Console.WriteLine("[2] Abri o Historico de cotacoes");
        Console.WriteLine("[3] Abri o local onde estra o Historico");
        Console.WriteLine("\n");
        Console.Write("Informe a opcao que voce deseja: ");

        R4 = int.Parse(Console.ReadLine());

        Console.WriteLine("\n");

        while ((R4 < 1) || (R4 > 3))
        {
          Console.WriteLine("Essa opcao nao e valida");

          Console.WriteLine("\n");

          Console.Write("Escolha uma opcao valida:");

          R4 = int.Parse(Console.ReadLine());

          Console.WriteLine("\n");
        }

        switch (R4)
        {
          case 1:
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            Console.Write("\n");

            Console.WriteLine("*Base de calculo do Paypal*");

            //Informacoes 

            Console.Write("\n");

            Console.Write("Coloque o preco da comissao: ");
            C1 = int.Parse(Console.ReadLine());

            Console.Write("\n");

            Console.Write("Numero de clientes: ");
            C2 = int.Parse(Console.ReadLine());

            Console.Write("\n");

            Console.Write("Cotacao do dolar (Use a , para o resultado) : ");
            C3 = float.Parse(Console.ReadLine());

            //Calculos 

            R1 = C1 - (C1 * 0.044);
            R2 = (C2 * R1);
            R3 = (R2 * C3);

            //Final

            Console.Write("\n");

            Console.WriteLine($"O resultado seria:{R3:0.00}",R3);

            Console.WriteLine("\n");

             Console.ReadKey();

                         

            Console.Clear();

                       

            //Aquivo txt (Manda informacoes para o arquivo txt)

            StreamWriter sr = new StreamWriter(@"C:\Users\Public\Documents\Resultado.txt", true);
            sr.WriteLine("o resultado do seu calculo anterior no:{0}", R3);
            sr.Close();
                        Console.Clear();
                        Console.WriteLine("Digite qualquer tecla.....")

            break;

          case 2:
            Process.Start("notepad.exe", "C:\\Users\\Public\\Documents\\Resultado.txt");
                        Console.ReadKey();
            Console.Clear();
                        Console.WriteLine("Digite qualquer tecla.....")


            break;

          case 3:
            Process.Start("explorer.exe", "C:\\Users\\Public\\Documents");
                        Console.ReadKey();
            Console.Clear();
                        Console.WriteLine("Digite qualquer tecla.....")
            break;
        }
        Console.ReadKey();
      }
    }
  }
}