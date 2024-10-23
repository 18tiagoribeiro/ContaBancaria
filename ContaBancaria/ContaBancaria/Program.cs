Conta conta1 = new Conta();
conta1.titular = "Tiago Ribeiro";
conta1.numero = 25554501;
conta1.saldo = 165780000;
conta1.senha = 5667;

Conta conta2 = new Conta();
conta2.titular = "Edu";
conta2.numero = 164156;
conta2.saldo = 800000;
conta2.senha = 5789;

conta2.ExibirConta();
Console.WriteLine("");
conta1.ExibirConta();
//Console.ReadLine();