select * from alunos

select * from explicadores

select * from Materias
insert into Materias(Nome,ExplicadorID)
values('Portugues',1)
insert into Materias(Nome,ExplicadorID)
values('Matematica',2)
insert into Materias(Nome,ExplicadorID)
values('Ciencias',3)
insert into Materias(Nome,ExplicadorID)
values('Frances',4)
insert into Materias(Nome,ExplicadorID)
values('Fisica e Quimica',5)
insert into Materias(Nome,ExplicadorID)
values('Ingles',6)

delete from Materias

select * from Tarefas
insert into Tarefas(AlunoID,MateriaId)
values(21,25)
insert into Tarefas(AlunoID,MateriaId)
values(22,26)
insert into Tarefas(AlunoID,MateriaId)
values(23,30)
insert into Tarefas(AlunoID,MateriaId)
values(24,28)
 delete  from Tarefas
select 
MateriaId,
Primeiro_Nome + ' ' + Ultimo_Nome as 'Explicadores' 
from Materias 
inner join explicadores on explicadores.PessoaId=Materias.explicadorid;
select 
Primeiro_Nome + ' ' + Ultimo_Nome as 'Alunos'
from alunos
inner join  Materias on Materias.MateriaId= Materias.explicadorid

select * from alunos
order by PessoaId
insert into alunos(Primeiro_Nome,Ultimo_Nome,Morada,Cidade)
values('David','Silva','R.Liberdade de Portugal','Lisboa')
insert into alunos(Primeiro_Nome,Ultimo_Nome,Morada,Cidade)
values('Pedro','Santana','Avenida do Soldado','Loures')
insert into alunos(Primeiro_Nome,Ultimo_Nome,Morada,Cidade)
values('Jose','Pedro','R. Dos Agricultores','Lisboa')
insert into alunos(Primeiro_Nome,Ultimo_Nome,Morada,Cidade)
values('Tiago','Antunes','Avenida dos Combatentes','Loures')
insert into alunos(Primeiro_Nome,Ultimo_Nome,Morada,Cidade)
values('Miguel','Ferreira','R. Dom Pedro VI','Lisboa')
insert into alunos(Primeiro_Nome,Ultimo_Nome,Morada,Cidade)
values('Joao','Hortencio','Avenida da Compreensao','Loures')

                        select alunos.Primeiro_Nome + ' ' + alunos.Ultimo_Nome as 'Aluno',
                                Materias.Nome as 'Disciplina',
                                explicadores.Primeiro_Nome + ' ' + explicadores.Ultimo_Nome as 'Explicador'
                                from Tarefas
                                inner join alunos on alunos.PessoaId = Tarefas.AlunoID
                                inner
                                join Materias on Materias.MateriaId = Tarefas.MateriaId
                                inner
                                join explicadores on explicadores.PessoaId = Materias.ExplicadorID

SELECT * FROM Tarefas


		select * from alunos
		select * from explicadores
		select * from Materias
		select * from Tarefas

		insert into Tarefas(AlunoID,MateriaId)
		values(21,13)
		


