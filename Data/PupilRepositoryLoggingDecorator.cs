using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using Student.Web.Api.Data;
using Student.Web.Api.Models;

// Decorator Pattern : Structural design Pattern
public class PupilRepositoryLoggingDecorator : IPupilRepository
{
    private readonly IPupilRepository _pupilRepository;

    public PupilRepositoryLoggingDecorator(IPupilRepository pupilRepository)
    {
        _pupilRepository = pupilRepository;
    }

    public async Task<List<Pupil>> GetAllAsync()
    {
        Console.WriteLine("Getting all pupils...");

        return await _pupilRepository.GetAllAsync();
    }

    public void Add(Pupil newPupil)
    {
        Console.WriteLine($"Adding pupil with ID: {newPupil.StudentId}");

        _pupilRepository.Add(newPupil);
    }

    public void Delete(Pupil item)
    {
        Console.WriteLine($"Deleting pupil with ID: {item.StudentId}");

        _pupilRepository.Delete(item);
    }

    public async Task<Pupil?> GetById<K>(K id)
    {
        Console.WriteLine($"Getting pupil by ID: {id}");

        return await _pupilRepository.GetById(id);
    }

    public async Task<bool> SaveAllChangesAsync()
    {
        Console.WriteLine("Saving changes...");

        return await _pupilRepository.SaveAllChangesAsync();
    }

    public Task AddPupil(Pupil pupil)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePupil(Pupil pupil)
    {
        throw new NotImplementedException();
    }

    public Task DeletePupil(string studentId)
    {
        throw new NotImplementedException();
    }
}
