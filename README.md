# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Desafio de Projeto, utilizando conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Projeto
Modelar um sistema que trabalha com celulares. Para isso, foi feita uma abstração de um celular, disponibilizando diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
De acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Tecnologias utilizadas
**Linguagem:** c#

**IDE:** Visual Studio

## Referências
Link do projeto original:
https://github.com/digitalinnovationone/trilha-net-poo-desafio  em seguida, implemente conforme as regras acima.