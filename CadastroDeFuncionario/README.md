# Exercício — Sistema de Cadastro de Funcionários (Herança + Polimorfismo)

Você deverá criar um sistema de RH em C# que:

- Cadastra funcionários pelo console  
- Suporta diferentes tipos de funcionários  
- Exibe relatórios  

---

## Regras do Sistema

### 1. Classe Base: Funcionario

Crie a classe abstrata Funcionario e métodos abstratos com:

- Nome (string)
- Cpf (string)
- Tipo (string, Clt, Terceirizado ou Estagiario)

**Método:**

- `CalcularSalario() : double`

**Método virtual:**

- `ExibirDados() : void`

---

### 2. Classes Derivadas

#### FuncionarioClt

- SalarioBase (double)

**CalcularSalario()** retorna o salário base.

**No ExibirDados(), mostre:**
(mostra nome, documento e salário, e tipo)

---

#### FuncionarioEstagiario

- BolsaAuxilio (double)
- ValeTransporte (double)

**CalcularSalario() = Bolsa + ValeTransporte**

**ExibirDados(), mostre:**
(mostra nome, documento e salário, e tipo)

---

#### FuncionarioTerceirizado

Propriedades:

- HorasTrabalhadas (double)
- ValorHora (double)

**CalcularSalario() = HorasTrabalhadas * ValorHora**

**No ExibirDados(), mostre:**
(mostra nome, documento e salário, e tipo)

---

### 3. Cadastro pelo console

Implemente no Main():

Um menu:

1 - Cadastrar funcionário  
2 - Listar funcionários  
3 - Sair  

Se o usuário escolher cadastrar:

Pergunte o tipo de funcionário:

- (1) CLT  
- (2) Estagiário  
- (3) Terceirizado  

Para cada tipo, solicite os dados específicos usando Console.ReadLine()

Realize conversões de double com validação: (utilizar try-catch)

- `double.Parse`

Crie o objeto correspondente e adicione à lista

---

### 4. Listagem

Quando o usuário escolher "Listar Funcionários":

- Percorra a lista
- Chame ExibirDados() para cada funcionário
- Mostre salário formatado
