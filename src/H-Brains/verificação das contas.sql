/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [log]
      ,[pass]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Login]

  select 
  concat(Login.log, Login.pass) as 'contas',
  
  concat(alunos.Primeiro_Nome, ' ', alunos.Ultimo_Nome) as 'Aluno',
    concat(alunos.Primeiro_Nome, ' ', alunos.Ultimo_Nome) as 'Explicador'
  from Login
  inner join alunos on alunos.PessoaId= Login.log
  inner join explicadores on explicadores.PessoaId=Login.pass

  
