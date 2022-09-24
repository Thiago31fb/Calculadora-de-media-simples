class Conclusao
{
    static void Main()
    {
        int opcao = 1;
        while (opcao >=1)
        {
            float soma = 0;

            Console.WriteLine("\t\tCALCULADORA DE MEDIA \n\nDeseja calcular a media de quantos valores?");
            int quantidade = int.Parse(Console.ReadLine());
            float[] valor = new float[quantidade];
            for (int x = 0 ;x < quantidade ;x++ )
            {
                Console.WriteLine("Digite o "+(x+1)+"º valor: ");
                valor[x] = float.Parse(Console.ReadLine());
                soma = soma + valor[x];
            }
            Console.WriteLine("A soma dos valores deu: "+soma+" dividindo por: "+quantidade+" a media é: "
                +(soma/quantidade)+" \n\n Deseja calcular outra media?       0 = Não; 1 = Sim");
            opcao = int.Parse(Console.ReadLine());

        }
    }
}