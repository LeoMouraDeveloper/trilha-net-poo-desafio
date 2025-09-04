# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

# Sistema de Cadastro e Listagem de Smartphones

Este projeto é um sistema de console em C# para cadastro e listagem de aparelhos celulares, permitindo ao usuário registrar smartphones do tipo Nokia ou iPhone, visualizar todos os aparelhos cadastrados e encerrar o programa de forma intuitiva.

## Funcionalidades

- **Menu interativo em loop:**  
  O usuário pode escolher entre cadastrar um novo aparelho, listar todos os aparelhos cadastrados ou encerrar o programa.

- **Cadastro de aparelhos:**  
  - Escolha entre Nokia ou iPhone.
  - Insira número, modelo, IMEI e memória do aparelho.
  - Os dados são armazenados em uma lista e podem ser consultados a qualquer momento.

- **Listagem de aparelhos:**  
  - Exibe todos os aparelhos cadastrados, mostrando tipo, modelo, memória e número.

- **Encerramento:**  
  - O programa só encerra quando o usuário escolhe explicitamente a opção "Sair".

## Exemplo de uso

```
O que deseja fazer?
1 - Cadastrar aparelho
2 - Listar aparelhos
3 - Sair

Qual smartphone deseja cadastrar? (1 - Nokia, 2 - iPhone)
Cadastro do smartphone Nokia:
Digite o número: 11999999999
Digite o modelo: Nokia 3310
Digite o IMEI: 123456789012345
Digite a memória (GB): 16
Nokia cadastrado com sucesso!

O que deseja fazer?
2 - Listar aparelhos
Aparelhos cadastrados:
Nokia - Modelo: Nokia 3310 - Memória: 16GB - Número: 11999999999
```

## Estrutura do projeto

- `Program.cs`: Gerencia o menu principal, cadastro e listagem dos aparelhos.
- `Models/Smartphone.cs`: Classe abstrata base para os aparelhos.
- `Models/Nokia.cs`: Classe derivada para aparelhos Nokia.
- `Models/Iphone.cs`: Classe derivada para aparelhos iPhone.

## Observações

- O sistema valida a opção escolhida pelo usuário e exibe mensagens claras em caso de erro.
- O menu principal permanece em execução até que o usuário escolha sair.
- Os dados dos aparelhos são mantidos apenas durante a execução do programa (não há persistência em arquivo ou banco).

---

**Desenvolvido para fins didáticos na trilha .NET