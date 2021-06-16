/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [PessoaId]
      ,[Primeiro_Nome]
      ,[Ultimo_Nome]
      ,[Morada]
      ,[Cidade]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[explicadores]

  insert into Login(pass,PessoaID)
values(6631,1)
insert into Login(pass,PessoaID)
values(3141,2)
insert into Login(pass,PessoaID)
values(7631,3)
insert into Login(pass,PessoaID)
values(8912,4)
insert into Login(pass,PessoaID)
values(9912,5)
insert into Login(pass,PessoaID)
values(1212,6)

select * from Login
inner join explicadores on Login.PessoaID=explicadores.PessoaId
