using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace QuartoProjeto
{
    internal class Program
    {
        //Criando uma estrutura de cadastro com Struct
        struct DadosCadastrais_struct // Defindo struct com o nome da estrurura
        {
            public string nome; // Dados que compoem a estrura de cadastro
            public string nomeDaRua;
            public UInt32 numeroDaCasa;
            public string numeroDoDocumento;


        };
        static void Main(string[] args)
        {

            //Criando a lista para obter os dados da struct
            List<DadosCadastrais_struct> listaDeCadastros = new List<DadosCadastrais_struct>();
            string opcao;

            //Criando um DO para aplicar as condições 
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")

                {
                    // Cadastrar um novo usuário

                    DadosCadastrais_struct dadosCadastrais;
                    Console.WriteLine("Digite o nome completo");
                    dadosCadastrais.nome = Console.ReadLine();
                    Console.WriteLine("Digite o nome da rua");
                    dadosCadastrais.nomeDaRua = Console.ReadLine();
                    Console.WriteLine("Digite o numero da Casa");
                    dadosCadastrais.numeroDaCasa = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("Digite o número do documento");
                    dadosCadastrais.numeroDoDocumento = Console.ReadLine();
                    listaDeCadastros.Add(dadosCadastrais);

                    Console.Clear();

                }
                else if (opcao == "s")
                {
                    //Encerrar a aplicação
                    Console.WriteLine("Encerrando a aplicação");
                    break;

                }

                else
                {       //Repetir tudo quando der opção desconhecida
                    Console.WriteLine("Opção desconhecida!");

                }
                //Enquanto não atingir o resultado, fica repetindo. 

            } while (opcao != "s");
            Console.WriteLine("Pressione qualquer tecla para sair");


        }
    }
}
