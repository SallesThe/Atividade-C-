namespace Atividade
{
    class Clientes
    {
        public string Nome {get; set;}
        public string Endereco {get; set;}
        public float Valor {get; protected set;}
        public float Valor_Imposto {get; protected set;}
        public float Total {get; protected set;}

        public virtual void Pagar_Imposto(float valor)
        {
            Valor = valor;
            Valor_Imposto = Valor * 10/100;
            Total = Valor + Valor_Imposto;
        } 
    }
}