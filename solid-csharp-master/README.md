# Projeto para o curso de SOLID com CSharp

Projeto para estudar os Conceitos S.O.L.I.D

S - SRP - Single Responsability Principle (Principio de Responsabilidade Unica).
    
      Responsavel por trabalhar metodos e classes coesos. 
      Trabalhar Coesão de Codigo.
      
      DRY - Don't Repeat Yourself (não ter codigos repetidos dentro do projeto, se isso existe, o codigo não está coeso). 
      
      Metodos e Classes precisam ter Responsabilidades Unicas.Responsabilidade de Metodos e Classes são diferentes.
         Metodos - Apenas uma unica Intenção.
         Classes - Atender apenas um agente de Mudança. 

      Single Source of Truth - Unica fonte de Informação.

O - OCP - Open/Close Principle (Principio de Aberto/Fechado)
      
       Responsável por deixar as classes fechadas para alterações e aberto para extensões.
       Efeito disso é manter funcionalidades funcionais sem risco de afetar partes que não seriam necessárias alterações.
       Com isso as novas funcionalides utilizariam uma nova classe que herda da anterior assim mudando seu comportamento

L - LSP - Liskov Separation Principle (Principio de Separação de Liskov)

     YAGNI - You Ain't Gonna Need It (Você não vai precisar disso) ou seja não desenvolva metodos e classes que não precisará,
     pois gerara trabalho que não necessita, assim cumprindo com o principio de Liskov. 
     Caso disponibilize o metodo, garanta que o mesmo irá cumprir com seu objetivo, para que não indisponibilize aquilo que já foi
     prometido.
     Ex.: Você tem uma metodo que devolve um int de 0 a 50, você não pode mais limitar o retorno a 25, pois geraria erro de quem necessita
     o retorno de 26 a 50.

I - ISP - Interface Segregation Principle (Principio de Segregação de Interfaces)

     Responsável por fazer a segregação das Interfaces, para melhorar a coesão das Interfaces, pois não é por que se trata
     de Interfaces que não devemos cuidar da coesão, pois as classes que irão implementar a Interface também precisa da coesão
     da interface para não implementar processos errados 

D - DIP - Dependency Inversion Principle (Principio da Inversão de Dependencia) 

      Melhorar a Qualidade do Acoplamento.
      Acoplamentos sempre vão existir, porém temos que prezar pela qualidade do acoplamento. 
        Acoplamentos Bons - Tipos Estaveis (API e Abstrações)
        Acoplamentos Ruins - Tipo Instáveis (Implementações)
    
      Criar abstrações para melhorar a qualidade do acoplamento.
      Explicitar as dependencias do construtor para desacoplar.

      Explicitando a dependencia com outro tipo, precisa ser realizado a Injeção de Depencia(Quem Cria).

      Inversão de Controle (IOC) - Direção da Depencia - Classe "perde" o controle e passa essa responsabildiade para outra.
