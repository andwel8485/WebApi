using System;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Contracts.Repositories;
using Infrastructure.Repositories;
using ApplicationCore.Entities;

namespace Infrastructure.Services
{
	public class CandidateService:ICandidateService
	{
        private readonly ICandidateRepository _candidateRepo;
		public CandidateService(ICandidateRepository candidateRepository)
		{
            _candidateRepo = candidateRepository;

        }

        public IEnumerable<Candidate> GetAllCandidate()
        {
            return _candidateRepo.GetAll();
        }
        public Candidate? GetCandidateById(int id)
        {
            return _candidateRepo.GetById(id);
        }
        public int DeleteCandidate(int id)
        {
            return _candidateRepo.Delete(id);
        }
        public int UpdateCandidate(Candidate c)
        {
            return _candidateRepo.Update(c);
        }
        public int InsertCandidate(Candidate c)
        {
            return _candidateRepo.Insert(c);
        }
    }
}

