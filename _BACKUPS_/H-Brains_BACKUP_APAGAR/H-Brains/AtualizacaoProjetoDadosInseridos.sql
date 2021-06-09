select 
concat(alunos.Primeiro_Nome, ' ', alunos.Ultimo_Nome) AS 'Aluno',
Materias.Nome,
concat(explicadores.Primeiro_Nome,'',explicadores.Ultimo_Nome) as 'Explicadores',
Texto
FROM Tarefas
INNER JOIN alunos ON alunos.PessoaId = Tarefas.AlunoID
INNER JOIN Materias ON Materias.MateriaId = Tarefas.MateriaId
INNER JOIN explicadores ON explicadores.PessoaId = Materias.ExplicadorID
order by alunos.PessoaId

insert into Tarefas(AlunoID,MateriaId,Texto)
values(23,27,'Tarefa para esta noite fazer um trabalho sobre Homo Sapiens ')
insert into Tarefas(AlunoID,MateriaId,Texto)
values(24,30,'Tarefa para esta noite exercicios do verbo to be')
insert into Tarefas(AlunoId,MateriaID,Texto)
values(21,30,'Tarefa para esta noite exercicios do verbo to have')
insert into Tarefas(AlunoID,MateriaId,Texto)
values(25,27,'Tarefa para esta noite ler pg 9 sobre o tema dos varios tipos de rochas ')
insert into Tarefas(AlunoID,MateriaId,Texto)
values(21,25,'Tarefa para esta noite Ler pg 4 manual ')
insert into Tarefas(AlunoID,MateriaId,Texto)
values(22,26,'Tarefa para esta noite exercicios de geometria 1,2 pg 2 manual ')
insert into Tarefas(AlunoID,MateriaId,Texto)
values(23,28,'Tarefa para esta noite exercicios da pg 11 manual sobre os desportos traduzindo para frances')
insert into Tarefas(AlunoID,MateriaId,Texto)
values(24,29,'Tarefa para esta noite estudar os riscos da corrente eletrica para as criancas ')
insert into Tarefas(AlunoID,MateriaId,Texto)
values(25,30,'Tarefa para esta noite exercicios sobre Relative Pronoums ')
insert into Tarefas(AlunoID,MateriaId,Texto)
values(26,27,'Tarefa para esta noite exercicios sobre o impacto do aquecimento global ')