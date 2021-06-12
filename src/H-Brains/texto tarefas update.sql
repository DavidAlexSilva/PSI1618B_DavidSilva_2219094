/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [log]
      ,[pass]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Login]


select * from alunos

select * from Login
select
concat(alunos.Primeiro_Nome,' ',Ultimo_Nome)as 'Aluno'
from alunos
Inner join Login on Login.log=alunos.PessoaId

SELECT
concat(alunos.Primeiro_Nome, ' ', alunos.Ultimo_Nome) AS 'Aluno',
alunos.Primeiro_Nome,' ',alunos.Ultimo_nome,
concat(Login.log,Login.pass) as 'Conta'
FROM Login
INNER JOIN alunos ON alunos.PessoaId = Login.log

