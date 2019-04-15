namespace Ex1 //Qual projeto está relacionado
{
    public class ContaCorrente {
        // get- pega
        //set- setar, configurar, introduzir, inserir
        //void nao tem retorno
        //retorno - oq irá retornar para mim 
        //bool - verdadeiro ou falso
        //public - deixa vc acessar as coisas 
        //metodo - voce tem um filtro (validaçoes e seguranca) para acessar um atributo
        //atributo - vc acessa diretamente o atributo
        //fazer o erro primeiro 
        public string titular; 

        public int agencia;

        public int numeroConta;

        private double saldo { get; set;}
        
        public void Depositar (double valor){
            saldo += valor;
        }
        public bool Sacar (double valor) {
            if (valor > saldo) {
                return false;
            } else {
                saldo -= valor;
                return true;
            }

        } //fim do saque
        public double ExibirSaldo (){
            return saldo;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino){
            if(valor > saldo){
                return false;
            }else{
                saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }
        }

    }
}