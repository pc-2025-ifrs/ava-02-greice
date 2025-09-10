using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== TESTES DA CLASSE FRACAO ===");
        
        // Teste 1
        Console.WriteLine("\n1. Teste construtor com simplificação:");
        var f1 = new Fracao(5, 10);
        Console.WriteLine(f1.Numerador == 1); // True
        Console.WriteLine(f1.Denominador == 2);
        Console.WriteLine(f1.ToString() == "1/2");
        Console.WriteLine(f1); // 1/2

        // Teste 2
        Console.WriteLine("\n2. Teste construtor com inteiro:");
        var f2 = new Fracao(3);
        Console.WriteLine(f2); // "3/1"

        // Teste 3
        Console.WriteLine("\n3. Teste construtor com string:");
        var f3 = new Fracao("30/40");
        Console.WriteLine(f3.Numerador == 3);
        Console.WriteLine(f3.Denominador == 4);
        Console.WriteLine(f3); // "3/4"

        // Teste 4
        Console.WriteLine("\n4. Teste construtor com double (0.345):");
        var f4 = new Fracao(0.345);
        Console.WriteLine(f4); // "69/200"

        // Teste 5
        Console.WriteLine("\n5. Teste construtor com double (0.4):");
        var f5 = new Fracao(0.4);
        Console.WriteLine(f5.Numerador == 2);
        Console.WriteLine(f5.Denominador == 5);
        Console.WriteLine(f5); // "2/5"

        // Teste 6
        Console.WriteLine("\n6. Teste método Somar com inteiro:");
        var f6 = f1.Somar(2);
        Console.WriteLine(f6); // "5/2"

        // Teste 7
        Console.WriteLine("\n7. Teste operador + com inteiro:");
        var f7 = f1 + 2;
        Console.WriteLine(f7); // "5/2"

        // Teste 8
        Console.WriteLine("\n8. Teste operador + com double:");
        var f8 = f1 + 0.5;
        Console.WriteLine(f8); // "3/1"

        // Teste 9
        Console.WriteLine("\n9. Teste operador + com double (0.2862):");
        var f9 = f1 + 0.2862;
        Console.WriteLine(f9); // "16431/5000"

        // Teste 10
        Console.WriteLine("\n10. Teste operador + com string:");
        var f10 = f3 + "7/8";
        Console.WriteLine(f10.Numerador == 13);
        Console.WriteLine(f10.Denominador == 8);
        Console.WriteLine(f10); // "13/8"

        // Teste 11
        Console.WriteLine("\n11. Teste operador + com double (6.45):");
        var f11 = f3 + 6.45;
        Console.WriteLine(f11.Numerador == 323);
        Console.WriteLine(f11.Denominador == 40);
        Console.WriteLine(f11); // "323/40"

        // Teste 12-15
        Console.WriteLine("\n12-15. Teste de igualdade:");
        Fracao f12 = new(1, 5);
        Fracao f13 = new(1, 3);
        Fracao f14 = new(125, 375);
        Fracao f15 = new(15, 75);

        Console.WriteLine(f12.Equals(f14)); // false
        Console.WriteLine(f12 == f14); // false
        Console.WriteLine(f12 != f14); // true
        Console.WriteLine(f12 == f15); // true
        Console.WriteLine(f13 == f14); // true
        Console.WriteLine(new Fracao("3/19").Equals(new Fracao(3, 19))); // true

        // Teste 16-23
        Console.WriteLine("\n16-23. Teste operadores de comparação:");
        var f16 = new Fracao(2, 12);
        var f17 = new Fracao(3, 4);
        var f18 = new Fracao(9, 10);
        var f19 = new Fracao(5);
        var f20 = new Fracao(24, 18);
        var f21 = new Fracao(16, 8);
        var f22 = new Fracao(1, 8);
        var f23 = new Fracao(10, 80);

        Console.WriteLine(f16 < f17);
        Console.WriteLine(f18 > f17);
        Console.WriteLine(f19 > f18);
        Console.WriteLine(f12 >= f15);
        Console.WriteLine(f16 < f20);

        // Teste consultas
        Console.WriteLine("\nTeste de consultas:");
        Console.WriteLine(f16.IsImpropria); // False
        Console.WriteLine(f16.IsPropria); // True
        Console.WriteLine(f20.IsImpropria); // True
        Console.WriteLine(f20.IsAparente); // False
        Console.WriteLine(f21.IsPropria); // False
        Console.WriteLine(f21.IsAparente); // True
        Console.WriteLine(f21.IsUnitaria); // False
        Console.WriteLine(f22.IsUnitaria); // True
        Console.WriteLine(f23.IsUnitaria); // True

        // Teste exceção
        Console.WriteLine("\nTeste de exceção (denominador zero):");
        try
        {
            var f24 = new Fracao(5, 0);
            Console.WriteLine("ERRO: Não lançou exceção!");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"OK: Exceção lançada - {ex.Message}");
        }

        Console.WriteLine("\n=== TODOS OS TESTES CONCLUÍDOS ===");
    }
}