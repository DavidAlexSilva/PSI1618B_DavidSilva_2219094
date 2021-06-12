/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [TarefaID]
      ,[AlunoID]
      ,[MateriaId]
      ,[Data]
      ,[Texto]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Tarefas]

  insert into Tarefas()

  select * from Tarefas
  where TarefaID=72

    select * from Tarefas
  where TarefaID=73
 
     select * from Tarefas
  where MateriaId=27
      select * from Tarefas
  where MateriaId=27

  
    select * from Tarefas
  where TarefaID=74

    
    select * from Tarefas
  where TarefaID=75

      
    select * from Tarefas
  where TarefaID=69
      
    select * from Tarefas
  where TarefaID=70
      
    select * from Tarefas
  where TarefaID=76

  select *from Login

  SELECT
concat(alunos.Primeiro_Nome, ' ', alunos.Ultimo_Nome) AS 'Aluno',
Login.log
FROM Tarefas
INNER JOIN alunos ON alunos.PessoaId = Tarefas.AlunoID
INNER JOIN Login ON Login.log = alunos.Primeiro_Nome


