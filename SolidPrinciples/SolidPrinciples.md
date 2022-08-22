# Solid Principles

## S - The Single Responsabilty Principle

O principio da responsabilidade unica, este principio envolve que uma classe deve ter apenas uma responsabilidade, ou seja não pode ser uma classe canivete suiço, para que fique mais facil testar e dar manutenção.

## O - The Open-Closed Principle

O principipio de aberto e fechado,este principio diz que uma classe deve estar aberta para extensão e fechada para alteração, Sendo assim podemos adicionar novas funcionalidades em uma classe sem tocar no codigo dela, alguns exemplos são os metodos de extensão dos tipos em dotnet.

## L - Liskov Substitute Principle.

O principio de substituição de liskov significa que quando há herança de classe a classe filha pode ser utilizada no lugar da classe pai pois ela apenas extende os comportamentos da classe pai mas ela não limita seu uso.

## I - Interface Segregation Principle

O principio de segregação da interface, neste principio as interfaces criadas visando separar as funcionalidades de maneiras mais especificas para que as classes que as implementarem não precisem de um codigo da qual não vão utilizar.

## D - Dependence Inversion Principle

O principio de Injeção de dependencia, neste principio nossa classe deve depender de interfaces ou classes abstradas ao invés da classe concreta, pois assim uma mudança na implementação da classe não gera impactos onde ela está sendo utilizada.