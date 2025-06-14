﻿using GuedesTime.Data.Context;
using GuedesTime.Domain.Intefaces;
using GuedesTime.Domain.Models;

namespace GuedesTime.Service.Services
{
    public class DisciplinaService : BaseService<Disciplina>, IDisciplinaService
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaService( IDisciplinaRepository disciplinaRepository,
                            INotificador notificador,
                            MeuDbContext context,
                            IPagedResultRepository<Disciplina> pagedRepository) : base(notificador, context, pagedRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }

        public async Task ObterTodos()
        {
            await _disciplinaRepository.ObterTodos();
        }

        public async Task<Disciplina> ObterDisciplinaPorNome(Guid instituicaoId, string nomeDisciplina)
        {
            return await _disciplinaRepository.ObterDisciplinaPorNome(instituicaoId, nomeDisciplina);
        }
		public async Task<(bool Existe, List<string> NomesExistentes)> VerificarDisciplinasExistentesPorNomes(Guid instituicaoId, List<string> nomes)
		{
			return await _disciplinaRepository.VerificarDisciplinasExistentesPorNomes(instituicaoId, nomes);
		}
		public async Task Adicionar(Disciplina Disciplina)
        {
            await _disciplinaRepository.Adicionar(Disciplina);
        }

		public async Task AdicionarDisciplinas(Guid InstituicaoId, List<string> listaDeDisciplinas)
		{
			var disciplinas = listaDeDisciplinas
				.Where(nome => !string.IsNullOrWhiteSpace(nome))
				.Select(nome => new Disciplina
				{
					Nome = nome.Trim(),
					InstituicaoId = InstituicaoId,
					Ativo = true,
				}).ToList();

			await _disciplinaRepository.AdicionarLista(disciplinas);
		}

		public async Task Atualizar(Disciplina Disciplina)
        {
            await _disciplinaRepository.Atualizar(Disciplina);
        }

        public async Task Remover(Guid id)
        {
            await _disciplinaRepository.Remover(id);
        }

        public void Dispose()
        {
            _disciplinaRepository?.Dispose();
        }

        public async Task<Disciplina> ObterPorId(Guid DisciplinaId)
        {
            return await _disciplinaRepository.ObterPorId(DisciplinaId);
        }
    }
}