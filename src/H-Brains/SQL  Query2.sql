SELECT
concat(alunos.Primeiro_Nome, ' ', alunos.Ultimo_Nome) AS 'Aluno',
Materias.Nome,
concat(explicadores.Primeiro_Nome,' ',explicadores.Ultimo_Nome) as 'Explicadores',
Texto
FROM Tarefas
INNER JOIN alunos ON alunos.PessoaId = Tarefas.AlunoID
INNER JOIN Materias ON Materias.MateriaId = Tarefas.MateriaId
INNER JOIN explicadores ON explicadores.PessoaId = Materias.ExplicadorID
order by alunos.PessoaId

insert into Tarefas(AlunoID,MateriaId,Texto)
values(21,25,'Tarefa para esta noite ler pg 2 Manuel de Portugues')



select * from Tarefas
select *from alunos
select * from Materias