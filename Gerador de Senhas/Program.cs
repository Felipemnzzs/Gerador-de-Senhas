namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int Comprimento = 0;
            Console.WriteLine("Bem vindo ao Gerador de Senhas");

            while (true)
            {

                Console.Write("Digite o tamanho da senha desejavél: ");
                String Entrada = Console.ReadLine();

                if (int.TryParse(Entrada, out Comprimento))
                {

                    if (Comprimento > 5 && Comprimento <= 20)
                    {
                        break;
                    } else {
                        Console.WriteLine("O comprimento da senha deve ser no mínimo 5 e no máximo 20 caracteres.");
                    }
                } else {
                    Console.WriteLine("Por favor, digite apenas números inteiros.");
                }
            }

            Console.WriteLine($"Comprimento da senha: {Comprimento} caracteres.");


            const string CaracteresOK = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*.-_";


            Random sorteio = new Random();
            String SenhaGerada = "";
            bool continuar = true;

            while (continuar)
            {
                for (int i = 0; i < Comprimento; i++)
                {
                    int Indice = sorteio.Next(0, CaracteresOK.Length);
                    char Sorteado = CaracteresOK[Indice];
                    SenhaGerada += Sorteado;
                }

                Console.WriteLine($"A senha gerada é: {SenhaGerada}");

                Console.WriteLine("Digite 1 para gerar uma nova senha. Outro caractere para sair");
                string ler = Console.ReadLine();
                SenhaGerada = "";
                if (ler != "1")
                {
                    continuar = false;
                }
            }
        }
    }
}
    

