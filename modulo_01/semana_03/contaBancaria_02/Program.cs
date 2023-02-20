using contaBancaria.Classes;

ContaBancaria conta1 = new ContaBancaria("Jailson", 2311, 1874, tipoConta.CORRENTE);
ContaBancaria conta2 = new ContaBancaria("Jerivaldo", tipoConta.CORRENTE);

conta1.Depositar(2500);
conta1.MostrarSaldo();

conta1.Transferir(conta2, 500);
conta2.MostrarSaldo();
conta1.MostrarSaldo();