namespace Student.Web.Api.Models
{
    public class Pupil
    {
        public Pupil(string studentId)
        {
            StudentId = studentId;
        }

        public Pupil()
        {
            
        }
//Prototype pattern : Creational design patterm
        public string StudentId { get; private set; }
        public string LastName { get; set; } = string.Empty;
        public string FirsName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string MiddleInitial 
        { 
            get 
            {
                return MiddleName.Substring(0,1) + ".";
            } 
        }

        public List<Grade> Grades { get; set; }
        public object Name { get; internal set; }
    }
}