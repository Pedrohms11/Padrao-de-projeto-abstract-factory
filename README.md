# Padrao-de-projeto-abstract-factory
Situação de aprendizagem do curso de desenvolvimento de sistemas sobre o design Abstract Factory:

O abstract factory está inserido dentro dos padrões de projetos criacionais, esses padrões fornecem vários mecanismos de criação de objeto que aumantam a flexibilidade e reutilização de código, ele permite que você prooduza famílias de objetos relacionados sem necessariamente especificar suas classes concretas

<img width="690" height="480" alt="image" src="https://github.com/user-attachments/assets/fd096754-fe44-49db-a9bd-07c46a01e935" />

# Problema que o padrão resolve:
A primeira coisa que :o padrão Abastract Factory sugere e declarar explicitamente interfaces para cada produto distinto da família de produtos.Então você pode fazer todas as variantes dos produtos seguirem essaas interfaces. Pensando no nosso dia a dia nos observamos essa mudança nos nossos aparelhos de celular, exatamente o que acontece quando mudamos o tema do nosso aparelho entre modo claro ou escuro.

# EStrutura do padrão:

<img width="495" height="321" alt="image" src="https://github.com/user-attachments/assets/e10e335f-5469-448c-8888-f5fc74f6b9ba" />



•	Produtos abstratos: Declaram interfaces para um conjunto de produtos distintos, mas relacionados que fazem parte de uma família de produtos.

•	Produtos concretos: São várias implementações de produtos abstratos, agrupados por variantes. Cada produto abstrato deve ser implementado em todas as variantes dadas.

•	Interface: A fabrica abstrata declara um conjunto de métodos para criação e cada um dos produtos abstratos. Cada fabrica concreta corresponde a uma variante especifica de produtos e cria apenas aquelas variantes de produto.

•	Cliente: Este pode trabalhar com qualquer variante de produto/fábrica desde que ele  se comunique com seus objetos via interfaces.

# Análise Critica:

Abordagem Sem o Padrão: Riscos e Limitações
Em um cenário onde o Abstract Factory não é utilizado, o código cliente geralmente recorre à instanciação direta de classes concretas via operador new
Isso gera diversos problemas técnicos descritos nas fontes:
Acoplamento Forte: O sistema torna-se dependente de classes específicas, o que reduz a flexibilidade e dificulta a reutilização do código

Código "Sujo" com Condicionais: Sem a fábrica, o programador frequentemente utiliza estruturas complexas de switch-case ou if-else espalhadas pelo sistema para decidir qual objeto criar
Isso viola o Princípio de Responsabilidade Única, pois a lógica de criação fica misturada à lógica de negócio

Inconsistência entre Famílias de Produtos: Existe o risco constante de o desenvolvedor misturar objetos de "famílias" diferentes que não deveriam colaborar entre si, resultando em falhas de compatibilidade

Violação do Princípio Aberto/Fechado: Toda vez que um novo produto ou variante é adicionado, é necessário modificar o código-fonte existente, o que aumenta o risco de introduzir bugs em funcionalidades que já estavam operando

Com o Abstract Factory
A implementação do padrão oferece uma solução estruturada para os problemas acima, mas impõe seu próprio conjunto de desafios:
Vantagens (Prós)
Garantia de Compatibilidade: O padrão assegura que os produtos obtidos de uma fábrica sejam compatíveis entre si, eliminando o erro humano de misturar variantes incompatíveis

Isolamento de Responsabilidade: Toda a lógica de criação é extraída para um único lugar, facilitando a manutenção e o entendimento da "receita" de fabricação dos objetos

Independência de Plataforma/Variante: O código cliente interage apenas com interfaces abstratas, permitindo que o sistema suporte novas famílias de produtos sem que o código principal precise ser alterado ou mesmo conheça as classes concretas

Desvantagens (Contras)
Explosão de Classes e Interfaces: A principal crítica ao padrão é que ele pode tornar o código excessivamente complicado
Para cada novo conjunto de produtos, é necessário criar uma nova interface de fábrica, fábricas concretas e interfaces para cada produto

Dificuldade de Extensão de Produtos: Embora seja fácil adicionar novas famírias (variantes), adicionar um novo tipo de produto à interface da fábrica abstrata exige alterar a interface base e todas as fábricas concretas já implementadas

Conclusão da Comparação
Enquanto a abordagem sem o padrão é mais rápida de implementar inicialmente, ela resulta em um sistema rígido e propenso a erros de compatibilidade
O Abstract Factory, por outro lado, é uma ferramenta de escalabilidade, recomendada quando o sistema lida com diversas famílias de produtos que precisam evoluir de forma independente das classes que os utilizam, aceitando o custo de uma estrutura de classes mais robusta e populada
# Exemplo Real de uso:

Frameworks Cross-Platform (Qt, Flutter)

São frameworks utilizados para desenvolver aplicações graficas que funcionam em multiplos sistemas operacionais, Windows, MacOS e Linux, a partir de uma base unica de código.

Ele é aplicado no contexto de cada sistema operacional em sua interfaxe grafica, devido ao comportamento distinto de cada uma, sendo abplicados em elementos de interfae como botões, caixa de seleção, menus e barras de rolagem. 

O framework define uma fábrica abstrata que declara metodos. Para cada sistema operacional, existe uma fabrica concreta.
Resultado: O código da sua aplicação não precisa se preocupar com qual SO está rodando. Ele simplesmente recebe a fábrica correta e pede a criação de um botão. O padrão garante que todos os componentes criados para uma determinada execução pertençam à mesma família (todos do Windows, por exemplo), evitando a mistura inconsistente de estilos 

<img width="458" height="320" alt="image" src="https://github.com/user-attachments/assets/e1499d1c-0da3-4603-9d3c-e5c55ca82e4d" />


# Exemplos didaticos:
Varias variante da mesma familia: 
Com o Abstract Method a cada nova variante da mesma famnilia de objetos e representada em uma nova classe de acordo com suas especificidades

<img width="557" height="332" alt="image" src="https://github.com/user-attachments/assets/eb7dc616-61f0-48b3-b453-a703f2b72808" />

Erros comuns de padrão:
Um padrão incompativél e visto como um erro, mesmo se tratando de um mesmo objeto se a variante for diferente eles não combinam.

<img width="533" height="232" alt="image" src="https://github.com/user-attachments/assets/5212eeb3-ceca-4c14-acac-12b97e658e37" />

Fromato geral da fabrica concreta:
Todas as variantes do mesmo objeto podem ser movidas para uma mesma
hierarquia de classe

<img width="477" height="321" alt="image" src="https://github.com/user-attachments/assets/7ef49799-3408-4e0d-8a2d-301cac1d88ad" />

Cada fábrica concreta corresponde a uma variante de produto específica
<img width="521" height="235" alt="image" src="https://github.com/user-attachments/assets/4e337958-3716-4d25-b4fd-558496108154" />

Independencia do codigo cliente em relação a fabrica utilizada:

<img width="426" height="220" alt="image" src="https://github.com/user-attachments/assets/3950438b-3737-417c-92e8-c5b7622b9913" />.
 

# Referencias
GURU DA REFATORAÇÃO. Abstract Factory . Disponível em: https://refactoring.guru/design-patterns/abstract-factory  Acesso em: 23 mar. 2026

GAMMA, Erich; HELM, Richard; JOHNSON, Ralph; VLISSIDES, John. Design Patterns: Elements of Reusable Object-Oriented Software. Indianapolis: Addison-Wesley Professional, 1994.
SANTANA, Rodrigo Gonçalves. Design Patterns com C#: Aprenda padrões de projeto com os games. São Paulo: Casa do Código, 2024. (ISBN 978-85-7254-051-3). Disponível também em versão MOBI (ISBN 978-85-7254-053-7).


