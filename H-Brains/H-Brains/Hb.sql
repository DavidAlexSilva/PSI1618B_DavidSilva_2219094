select * from alunos

select * from explicadores

select * from Materias
insert into Materias(Nome)
values('Portugues')
insert into Materias(Nome)
values('Matematica')
insert into Materias(Nome)
values('Ciencias')
insert into Materias(Nome)
values('Frances')
insert into Materias(Nome)
values('Fisica e Quimica')
insert into Materias(Nome)
values('Ingles')

select * from Tarefas
insert into Tarefas(AlunoID,MateriaId)
values(1,1)
insert into Tarefas(AlunoID,MateriaId)
values(2,1)

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






