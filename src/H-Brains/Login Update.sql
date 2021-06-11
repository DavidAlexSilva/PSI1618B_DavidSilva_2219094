/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [log]
      ,[pass]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Login]

  update Login
  set log='explic'
  where log ='admin'
  
   update Login
  set log='aluno'
  where log ='log'
  
  select* from Login
  insert into Login(log,pass)
  values('explicador','1212')
insert into Login(log,pass)
values('aluno','1234')

  