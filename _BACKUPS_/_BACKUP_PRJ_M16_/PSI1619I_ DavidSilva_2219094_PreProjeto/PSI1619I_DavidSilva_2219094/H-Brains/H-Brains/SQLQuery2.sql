select 
MateriaId,
Primeiro_Nome + ' ' + Ultimo_Nome as 'Explicadores' 
from Materias 
inner join explicadores on explicadores.PessoaId=Materias.explicadorid


