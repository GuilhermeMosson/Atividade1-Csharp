using System;

//Atividade 01 de Guilherme Hoinski Mosson - sala 10

int x = 1;

while (x != 0) 
{
    Console.WriteLine("\nEscolha a aplicação que deseja ver: ");
    Console.WriteLine("1 - (Hello Word)\n2 - (Calculadura)\n3 - (Par ou Impar)");
    Console.WriteLine("Escreva so o numero");
    int ap = Convert.ToInt32(Console.ReadLine());


    switch (ap)
    {
        case (1):
            Console.WriteLine("           _                                                                    _\r\n          ' )     )                   /'         /'                            ' )       )      )                                        /'           /'\r\n          /'    /'                  /'         /'                               /      _/      /                                       /'           /'\r\n       ,/'    /'        ____      /'         /'         ____                   /    _/~/    _/~       ____         ____        _____,/'           /'\r\n      /`---,/'        /'    )   /'         /'         /'    )--               /  _/~  /  _/~        /'    )--    )'    )--   /'    /'           /'\r\n    /'    /'        /(___,/'  /'         /'         /'    /'                 /_/~    /_/~         /'    /'     /'          /'    /'           /'\r\n(,/'     (_,       (________ (__        (__        (___,/'                  /~      /~           (___,/'     /'           (___,/(__         O\r\n\r\n\r\n\r\n");
            break;

        case (2):
            float resul;
            Console.WriteLine("\nNumero 1: ");
            float num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNumero 2: ");
            float num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInsira a condição: ");
            string cond = Console.ReadLine();

            if (cond == "+")
            {
                resul = num1 + num2;
                Console.WriteLine($"\n{num1} + {num2} = {resul}");
            }
            else if (cond == "-")
            {
                resul = num1 - num2;
                Console.WriteLine($"\n{num1} - {num2} = {resul}");
            }
            else if (cond == "*")
            {
                resul = num1 * num2;
                Console.WriteLine($"\n{num1} * {num2} = {resul}");
            }
            else if (cond == "/")
            {
                resul = num1 / num2;
                Console.WriteLine($"\n{num1} / {num2} = {resul}");
            }
            else
            {
                Console.WriteLine("\n**Condição não reconecida**");
            }
            break;

        case (3):
            Console.WriteLine("\nInsira um numero inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine($"\n{numero} -> Par");
            }
            else
            {
                Console.WriteLine($"\n{numero} -> impar");
            }
            break;
    }   

}
