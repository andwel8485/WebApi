using System;
using ApplicationCore.Entities;
namespace ApplicationCore.Contracts.Services
{
	public interface ICandidateService
	{
		IEnumerable<Candidate> GetAllCandidate();
		Candidate? GetCandidateById(int id);
		int DeleteCandidate(int id);
		int UpdateCandidate(Candidate c);
		int InsertCandidate(Candidate c);
	}
}

