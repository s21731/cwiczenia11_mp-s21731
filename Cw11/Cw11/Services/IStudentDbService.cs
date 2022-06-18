using Cw11.Models;

namespace Cw11.Services
{
    public interface IStudentDbService
    {
        public Student FindStudentById(int idStudent);
        public void DeleteStudent(int idStudent);
    }
}
