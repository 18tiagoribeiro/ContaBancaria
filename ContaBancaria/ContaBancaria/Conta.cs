class Conta
{
    public string titular;
    public int numero;
    public int saldo;
    public int senha;

    public void ExibirConta()
    {
        Console.WriteLine($"Titular da conta: {titular}");
        Console.WriteLine($"Número da conta: {numero}");
        Console.WriteLine($"Saldo: {saldo} R$");
        Console.WriteLine($"Senha: {senha}");
        
    }
}