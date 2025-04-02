﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuedesTime.Domain.Models
{
    public class Instituicao : Entity
    {
        public string Nome { get; set; }
        public string Inep { get; set; }
        public string Cnpj { get; set; }
        public Guid UsuarioId { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Professor> Professores { get; set; }
        public ICollection<Turma>? Turmas { get; set; }
        public ICollection<Disciplina>? Disciplinas { get; set; }
        public ICollection<Sala>? Salas { get; set; }
        public ICollection<Horario>? Horarios { get; set; }
        public ICollection<Feriado>? Feriados { get; set; }
    }

}
