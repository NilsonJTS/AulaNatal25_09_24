namespace ExercicioNatal24_09_24;

public class Conta
{
    //atribuindo atributos
    public int numero; 
    private double saldo;
    public Cliente cliente;
/*
    //getters e setters
    //==================================
    public double getSaldo(){
        return this.saldo;
    }

    public void setSaldo(double saldo){
        this.saldo=saldo;
    }
    //===================================
*/

    //métodos

    public Conta(int numero, double saldo, Cliente cli){
        this.numero=numero;
        Saldo=saldo;
        this.cliente=cli;
    }

    public double Saldo{get;set;}

    //métodos
    public void Creditar(double valor){
        Saldo+=valor;
    }

    public void Debitar(double valor){
        Saldo-=valor;
    }

    public void MostrarSaldo(){
         Console.WriteLine($"O saldo atual é: R$ {Saldo}");
    }

}
