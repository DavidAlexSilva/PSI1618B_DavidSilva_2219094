SELECT
concat(alunos.Primeiro_Nome, ' ', alunos.Ultimo_Nome) AS 'Aluno',
Materias.Nome,
concat(explicadores.Primeiro_Nome,'',explicadores.Ultimo_Nome) as 'Explicadores'
FROM Tarefas
INNER JOIN alunos ON alunos.PessoaId = Tarefas.AlunoID
INNER JOIN Materias ON Materias.MateriaId = Tarefas.MateriaId
INNER JOIN explicadores ON explicadores.PessoaId = Materias.ExplicadorID
order by alunos.PessoaId

insert into Tarefas()
values('')



select * from Tarefas
select *from alunos
select * from Materias