using Microsoft.Extensions.DependencyInjection;
using Student.Web.Api.Data;
using Student.Web.Api.Models;
using System;
using System.Threading.Tasks;

// Existing data interface
public interface IDataService
{
    Task<List<Pupil>> GetAllPupils();
    Task AddPupil(Pupil pupil);
    Task UpdatePupil(Pupil pupil);
    Task DeletePupil(string studentId);
}