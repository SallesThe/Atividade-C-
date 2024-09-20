namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}
        public override void Pagar_Imposto(float valor)
        {
            Valor = valor;
            Valor_Imposto = Valor * 20/100;
            Total = Valor + Valor_Imposto;
        }
    }
}