# Relatório - Aula 11 – Loops de repetição

## Parte 1: Análise da aula e respostas teóricas

1. **Por que utilizamos laços de repetição?**

   utilizamos laços de repetição quando queremos fazer um programa repetir uma determinada tarefa, por exemplo; suponhamos que estamos fazendo um cálculo complexo de mesa, e para não precisar ficar rodando o programa a cada cálculo, usamos o laço de repetição while (enquanto) com a variável “!= 0 (diferente de: 0)”, enquanto os valores captados pelo scanner forem diferentes de 0, o programa vai se encontrar em um estado de loop de repetição até que o usuário digite 0, encerrando o programa, como dito no vídeo **(youtube.com/watch?v=JzwH1EVyO1Q), no minuto; 09:19**. 

   ---

2. **Qual é a diferença entre while e do-while? Criem um exemplo de situação em que essa diferença seja importante.**

   A diferença entre **while** e **do-while** é que em **while** precisamos de uma condição inicial para rodar o programa, por exemplo; 

```java
  int valor = 1000;
   
   while (valor != 0) {

       valor = 0; 
   }
```
Ele precisa de uma condição de entrada, a condição fica no começo do laço, enquanto o do-while a condição fica no final do laço, por exemplo;

```java
   int valor;

   do {
    
   } while (valor != 0);

```

O **do-while** roda o bloco primeiro e verifica depois, o **while** roda o bloco já verificando a condição, se a condição for falsa o programa não inicia, e no **do-while** a mesma coisa, ele verifica o bloco e se a condição for falsa o programa não inicia, como dito no vídeo **(youtube.com/watch?v=JzwH1EVyO1Q), no minuto; 13:50**.

---

3. **No exemplo dos times em C#, por que são necessários dois laços?**

É necessário para evitar que os times se “enfrentem”, será usado um loop aninhado, para que na hora de imprimir no terminal, ele consiga distribuir os jogos sem que um time apareça jogando contra ele mesmo e tenha pelo menos 1 jogo contra todos os outros times.

---

4. **Qual é a função do if que impede confrontos de um time contra ele mesmo?**

A função do **if (se)**, é usada para quando temos duas listas, listaTimes e listaAdversarios, cada uma sendo identificada pela variável **int = i** ou **int = j**, sendo que se **i != j**, logo o problema de os times caírem contra eles mesmos é corrigido.

---

5. **Comparando os exemplos de Java, C# e Rust, indiquem duas diferenças de sintaxe e um conceito lógico que permanece igual.**

Duas diferenças de sintaxes que pudemos observar é que em Java usamos **“System.out.println()”** para imprimir no console e o CSharp se usa o **“Console.WriteLine()”** para imprimir.

Já o conceito lógico que permanece é o uso dos laços de repetição, usado para analisar os blocos de forma repetitiva infinitamente ou até atingir uma quantidade de passos pré-determinada, é igual nas três linguagens. 

---

## Parte 2: Leitura e relação com o livro (*Entendendo Algoritmos* - Aditya Bhargava)
*(Referência: BHARGAVA, Aditya. Entendendo Algoritmos: um guia ilustrado para programadores e outros curiosos. Capítulo 2: Memória, Arrays e Listas Encadeadas).*

1. **Como os elementos de um array são organizados e acessados?**

Os dados armazenados dentro de uma **array** são organizadas de forma numerada, você determina uma lista com quantidade de espaços na memória pré-selecionados, os dados são inseridos nesses espaços e lhe é atribuído um índice, **esse índice começa em 0**, a **array** permite que você acesse esses índices de forma aleatória, pois você sabe exatamente em qual índice está cada dado.

---

2. **Como os elementos de uma lista encadeada são organizados? Apresentem um desenho simples.**

As listas encadeadas são organizadas de forma dividida dentro dos slots da memória, não se sabe o índice onde o próximo dado está armazenado, sendo necessário percorrer cada dado para encontrar o endereço do próximo.

![Desenho simples de exemplo](Assets/Screenshot_1.png)

---

3. **Por que inserir ou excluir elementos pode exigir operações diferentes nessas duas estruturas?**

Porque a forma de distribuição dos dados de cada estrutura é diferente, em **listas encadeadas** você precisa apenas apagar o endereço que o dado anterior esta indicando, e em **arays** será necessário mover todos os dados quando um é apagado.

---

4. **Uma coleção chamada “lista” em uma linguagem é necessariamente uma lista encadeada? Pesquisem especificamente List de C# e Vec de Rust.**

Não necessáriamente, pesquisando usando o Gemini.AI, descobrimos que existem **arrays dinâmicos**, 

---

5. **Para guardar os times e percorrê-los repetidamente, quais vantagens vocês identificam em uma estrutura baseada em array?**