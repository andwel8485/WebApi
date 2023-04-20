using System;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
	public interface ISubmissionService
	{
        IEnumerable<Submission> GetAllSubmission();
        Submission? GetSubmissionById(int id);
        int DeleteSubmission(int id);
        int UpdateSubmission(Submission c);
        int InsertSubmission(Submission c);
    }
}

