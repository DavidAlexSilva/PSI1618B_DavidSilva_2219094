/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [log]
      ,[pass]
      ,[PessoaID]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Login]

insert into Login(pass,PessoaID)
values(1311,21)
insert into Login(pass,PessoaID)
values(1011,22)
insert into Login(pass,PessoaID)
values(1221,23)
insert into Login(pass,PessoaID)
values(1231,24)
insert into Login(pass,PessoaID)
values(4331,25)
insert into Login(pass,PessoaID)
values(4411,26)
select *from alunos
select * from Login
delete  from Login
select * from Login
inner join alunos on Login.PessoaID=alunos.PessoaId



