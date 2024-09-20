using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
           float val_pag;
           Console.WriteLine("Informar Nome: ");
           string var_nome = Console.ReadLine();
           Console.WriteLine("Informar Endereço: ");
           string var_endereco = Console.ReadLine();
           Console.WriteLine("Pessoa Física (F) ou Jurídica (J)");
           string var_tipo = Console.ReadLine();

           if(var_tipo == "f" || var_tipo == "F")
           {
                // --- Pessoa Física ---
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.Nome = var_nome;
                pf.Endereco = var_endereco;
                Console.WriteLine("Informar CPF: ");
                pf.cpf = Console.ReadLine();
                System.Console.WriteLine("Informar RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe o Valor do Produto: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);   
                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("");
                Console.WriteLine("Nome ..........: " + pf.Nome);
                Console.WriteLine("Endereço ......: " + pf.Endereco);
                Console.WriteLine("CPF ...........: " + pf.cpf);
                Console.WriteLine("RG ............: " + pf.rg);
                Console.WriteLine("Valor de Compra: " + pf.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pf.Valor_Imposto.ToString("C"));
                Console.WriteLine("Total a Pagar .: " + pf.Total.ToString("C"));
           } 
           
           else if(var_tipo == "j" || var_tipo == "J")
           {
                // --- Pessoa Jurídica ---
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.Nome = var_nome;
                pj.Endereco = var_endereco;
                System.Console.WriteLine("Informar CNPJ: ");
                pj.cnpj = Console.ReadLine();
                System.Console.WriteLine("Informar IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o Valor do Produto: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Jurídica --------");
                Console.WriteLine("");
                Console.WriteLine("Nome ..........: " + pj.Nome);
                Console.WriteLine("Endereço ......: " + pj.Endereco);
                Console.WriteLine("CPF ...........: " + pj.cnpj);
                Console.WriteLine("RG ............: " + pj.ie);
                Console.WriteLine("Valor de Compra: " + pj.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.Valor_Imposto.ToString("C"));
                Console.WriteLine("Total a Pagar .: " + pj.Total.ToString("C"));
            } 
           else 
           {
                var_tipo = "Tipo Inválido";
           }

           while (var_tipo == "Tipo Inválido")
           {
                Console.WriteLine("Pessoa Física (F) ou Jurídica (J)");
                var_tipo = Console.ReadLine();
           }
        }
    }
}

