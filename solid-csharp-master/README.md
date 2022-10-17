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

O - 
L - 
I - 

D - DIP - Dependency Inversion Principle (Principio da Inversão de Dependencia) - Melhorar a Qualidade do Acoplamento.

   Acoplamentos sempre vão existir, porém temos que prezar pela qualidade do acoplamento. 
     Acoplamentos Bons - Tipos Estaveis (API e Abstrações)
     Acoplamentos Ruins - Tipo Instáveis (Implementações)
    
   Criar abstrações para melhorar a qualidade do acoplamento.
   Explicitar as dependencias do construtor para desacoplar.

   Explicitando a dependencia com outro tipo, precisa ser realizado a Injeção de Depencia(Quem Cria).

   Inversão de Controle (IOC) - Direção da Depencia - Classe "perde" o controle e passa essa responsabildiade para outra.
