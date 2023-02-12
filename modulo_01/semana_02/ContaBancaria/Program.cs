using ContaBancaria.Classes;

cBancaria minhaConta = new cBancaria();
minhaConta.titular = "Jailson";
minhaConta.numero = 3213441;
minhaConta.tipo = tipoContaBancaria.POUPANCA;

minhaConta.depositar(1500);
minhaConta.sacar(135);
minhaConta.mostrarSaldo();