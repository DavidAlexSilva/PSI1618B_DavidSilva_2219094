/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [TarefaID]
      ,[AlunoID]
      ,[MateriaId]
      ,[Data]
      ,[Texto]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Tarefas]

  select PessoaId from explicadores
  where PessoaId = 1

select * from Login
where log='2'and pass='6'