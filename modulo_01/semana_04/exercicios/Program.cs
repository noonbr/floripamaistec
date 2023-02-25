using exercicios.Classes;

Cliente cliente1 = new Cliente("Jailson", DateTime.Parse("2003-08-25"), "Desenvolvedor", EstadoCivil.SOLTEIRO, TipoPessoa.FISICA);
Cliente cliente2 = new Cliente("Marcão", DateTime.Parse("1989-08-25"), "Carpinteiro", EstadoCivil.CASADO, TipoPessoa.JURIDICA);

ContaPoupanca c1 = new ContaPoupanca(6543, 1874, cliente1);
ContaEmpresarial c2 = new ContaEmpresarial(6544, 1874, cliente2, 15000, 10, "212355533123");

c1.ExibirSaldo();

c2.Depositar(3500);
c2.ExibirSaldo();

c2.FazerEmprestimo(15000);
c2.PagarEmprestimo();
c2.ExibirSaldo();

c2.Sacar(1500);
c2.ExibirSaldo();
