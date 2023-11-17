using Student.Web.Api.Models;

namespace Student.Web.Api.Data
{
    //Abstract Factory Pattern : Creational Design Pattern
    public interface IGradeRepository : IRepository<Grade>
    {
        //Facade Pattern : Structural design pattern
         Task<List<Grade>> GetAllByPupilIdAsync(string pupilId);
         Task<List<Grade>> GetAllBySubjecIdAsync(int subjectId);
    }
}