/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [TarefaID]
      ,[AlunoID]
      ,[MateriaId]
      ,[Data]
      ,[Texto]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Tarefas]

  insert into Tarefas(AlunoID,MateriaId,Texto)
 values(23,28,'Marcar para dia 29 as 15 horas Francês')

  select *from Tarefas
 where TarefaID=83

 
  insert into Tarefas(AlunoID,MateriaId,Texto)
 values(23,27,'Tarefa diária: ler pg 9 sobre o tema dos varios tipos de rochas ')

   select *from Tarefas
 where TarefaID=82

 insert into Tarefas(AlunoID,MateriaId,Texto)
 values(24,29,'Marcar para dia 30 as 16 horas Física e Química')
   select *from Tarefas
 where TarefaID=84

  insert into Tarefas(AlunoID,MateriaId,Texto)
 values(25,30,'Marcar para dia 22 as 11:30 horas Inglês')

 select *from Tarefas
 where TarefaID=85