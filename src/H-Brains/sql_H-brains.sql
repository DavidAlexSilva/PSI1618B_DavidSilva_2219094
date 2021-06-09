select*from alunos
order by Primeiro_Nome;

insert into alunos(PessoaId,Primeiro_Nome,Ultimo_Nome,Morada,Cidade)
values('12542256','Pedro','Santana','Av.Reinaldo dos Santos Odivelas','Lisboa');
insert into alunos(PessoaId,Primeiro_Nome,Ultimo_Nome,Morada,Cidade)
  values('12673434','David','Silva','R.Alberto V da Broa Entrecampos','Lisboa');
insert into alunos(PessoaId,Primeiro_Nome,Ultimo_Nome,Morada,Cidade)
values('12465323','José','Pedro','R.Combatentes da Grande Guerra Odivelas','Lisboa');
insert into alunos(PessoaId,Primeiro_Nome,Ultimo_Nome,Morada,Cidade)
values('12546764','Joaquim','Carvalho','R.D Afonso IV Campo pequeno ','Lisboa');
insert into alunos(PessoaId,Primeiro_Nome,Ultimo_Nome,Morada,Cidade)
values('12893423','Ana','Pereira','Av. Liberdade ','Lisboa')

delete from alunos;

select Primeiro_Nome
from alunos
