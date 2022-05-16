using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace JogoDaForca;

public class InterfaceForca
{
    private char[] palavraSelecionada;
    private char[] tmp;
    private int tentativas;
    private int numCaracter;
    string caracteresDigitados = "";

    Palavra p1 = new Palavra();

    public InterfaceForca()
    {
        this.palavraSelecionada = this.p1.Palavra1.ToCharArray();

        this.numCaracter = palavraSelecionada.Length;
        this.tmp = new char[numCaracter];
        for (int i = 0; i < numCaracter; i++)
        {
            this.tmp[i] = ('_');
        }
    }

    public void inicializacao()
    {
        Console.WriteLine(" ********  ********  ********  ********  ******** ");
        Console.WriteLine(" **        **    **  **    **  **        **    ** ");
        Console.WriteLine(" ********  **    **  ********  **        ******** ");
        Console.WriteLine(" **        **    **  ** **     **        **    ** ");
        Console.WriteLine(" **        ********  **   ***  ********  **    ** ");

        volta:
        Console.WriteLine("\nEscolha o nível do jogo: [1]FÁCIL [2]MÉDIO [3]DIFÍCIL: ");
        string numTmp = Console.ReadLine();

        if (numTmp == "1")
            this.tentativas = 7;
        else if (numTmp.Equals("2"))
            this.tentativas = 6;
        else if (numTmp.Equals("3"))
            this.tentativas = 5;
        else
        {
            Console.WriteLine("Não digitou uma opção válida");
            goto volta;
        }

        Console.Clear();
    }

    public void preenchimento()
    {
        int cont = 0;

        Console.Write("\n\nDigite uma letra:");
        char letra = (Convert.ToChar(Console.ReadLine()));

        for (int i = 0; i < this.numCaracter; i++)
        {
            if (letra.Equals(this.palavraSelecionada[i]))
                this.tmp[i] = letra;
            else
            {
                cont++;
                if (cont == this.numCaracter && i == (this.numCaracter - 1))
                {
                    this.tentativas--;
                    caracteresDigitados += letra + "  ";
                }
            }
        }
    }
    public void mostrarStrJogo()
    {
        Console.Write("\t\t ");
        foreach (char i in tmp)
        {
            Console.Write(" {0}  ", i); 
        }

    }
    public void apresentacaoBoneco()
    {
        Console.WriteLine("\n\t\tPalavra da categoria {0}, com {1} letra(s). Você têm {2} tentativas restantes" , (Categoria) this.p1.NumCategoria  , this.numCaracter, this.tentativas);
        if(!(this.caracteresDigitados.Equals("")))
            Console.WriteLine("\t\tErros ----> {0}", this.caracteresDigitados);

        boneco(this.tentativas);
    }

    public void boneco(int num)
    {
        if(num >= 5)
            Console.WriteLine(" ********   \n **    (_)  \n **    /|\\ \n **     |   \n **    / \\ \n **");
        else if (num == 4)
            Console.WriteLine(" ********   \n **    (_)  \n **    /|\\ \n **     |   \n **         \n **");
        else if(num == 3)
            Console.WriteLine(" ********   \n **    (_)  \n **    /|\\ \n **         \n **         \n **");
        else if(num == 2)
            Console.WriteLine(" ********   \n **    (_)  \n **     |   \n **         \n **         \n **");
        else if(num == 1)
            Console.WriteLine(" ********   \n **    (_)  \n **         \n **         \n **         \n **");
    }
    public void jogando()
    {
        inicializacao();
        while (this.tentativas > 0 && this.tmp.Contains('_'))
        {
            apresentacaoBoneco();
            mostrarStrJogo();
            preenchimento();
            Console.Clear();
            
        }
        if(!(this.tmp.Contains('_')))
            Console.WriteLine("PARABENS, GANHOU O JOGO!");
        else
        {
            Console.WriteLine("PERDEU O JOGO!");
        }
    }
}
