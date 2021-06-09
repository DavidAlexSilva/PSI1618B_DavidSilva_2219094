insert into Tarefas(AlunoID,MateriaId)
values(23,27)
insert into Tarefas(AlunoID,MateriaId)
values(24,30)
insert into Tarefas(AlunoId,MateriaID)
values(21,30)
insert into Tarefas(AlunoID,MateriaId)
values(25,27)
insert into Tarefas(AlunoID,MateriaId)
values(21,25)
insert into Tarefas(AlunoID,MateriaId)
values(22,26)
insert into Tarefas(AlunoID,MateriaId)
values(23,28)
insert into Tarefas(AlunoID,MateriaId)
values(24,29)
insert into Tarefas(AlunoID,MateriaId)
values(25,30)
insert into Tarefas(AlunoID,MateriaId)
values(26,27)

SELECT
concat(alunos.Primeiro_Nome, ' ', alunos.Ultimo_Nome) AS 'Aluno',
Materias.Nome,
concat(explicadores.Primeiro_Nome,'',explicadores.Ultimo_Nome) as 'Explicadores'
FROM Tarefas
INNER JOIN alunos ON alunos.PessoaId = Tarefas.AlunoID
INNER JOIN Materias ON Materias.MateriaId = Tarefas.MateriaId
INNER JOIN explicadores ON explicadores.PessoaId = Materias.ExplicadorID
order by alunos.PessoaId
select * from Tarefas
select *from alunos
