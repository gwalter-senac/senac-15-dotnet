# Crie uma aplicação console que:

1. Defina uma interface IPagamento contendo:

- Método void Pagar(double valor);

2. Crie 3 classes que implementam a interface:

- PagamentoCartaoCredito
ValorFinal = valor + 10%

- PagamentoBoleto
ValorFinal = valor - 5%

- PagamentoPix
ValorFinal = valor - 7%

Cada classe deve exibir uma mensagem específica ao pagar, por exemplo:

Processando pagamento de R$ 100,00 no cartão de crédito...

3. Cada pagamento deve ser salvo em uma lista e deve existir uma opção no menu para listar os pagamentos com o valor final e o tipo de pagamento.

4. No método Main:

- Opcao de registrar pagamento
    - Peça ao usuário para escolher a forma de pagamento (1, 2 ou 3)
    - Peça o valor a ser pago

    - Instancie o tipo correto conforme a escolha

    - Execute o método Pagar()

- Opcao de listar pagamentos
    - Listar valores e tipo de pagamento de cada pagamento.