using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Student.Web.Api.Data;
using Student.Web.Api.Models;
using System;
using System.Threading.Tasks;


// Adapter pattern : Structural design pattern
public class StudentDataContextAdapter : IDataService
{
    private readonly StudentDataContext _studentDataContext;

    public StudentDataContextAdapter(StudentDataContext studentDataContext)
    {
        _studentDataContext = studentDataContext;
    }

    public async Task<List<Pupil>> GetAllPupils()
    {
        return await _studentDataContext.Students.ToListAsync();
    }

    public async Task AddPupil(Pupil pupil)
    {
        _studentDataContext.Add(pupil);
        await _studentDataContext.SaveChangesAsync();
    }

    public async Task UpdatePupil(Pupil pupil)
    {
        var existingPupil = await _studentDataContext.Students.FindAsync(pupil.StudentId);
        if (existingPupil != null)
        {
            existingPupil.LastName = pupil.LastName;
            existingPupil.Name = pupil.Name;
            existingPupil.MiddleName = pupil.MiddleName;

            await _studentDataContext.SaveChangesAsync();
        }
    }

    public async Task DeletePupil(string studentId)
    {
        var existingPupil = await _studentDataContext.Students.FindAsync(studentId);
        if (existingPupil != null)
        {
            _studentDataContext.Remove(existingPupil);
            await _studentDataContext.SaveChangesAsync();
        }
    }
}