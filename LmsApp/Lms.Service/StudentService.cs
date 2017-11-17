using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Repository;
using Model;
using RequestModel;
using ViewModel;

namespace Lms.Service
{
    public class StudentService  : BaseService<Student>
    {
        private GenericRepository<Student> repository;

        public StudentService()
        {
            repository = new GenericRepository<Student>();

        }

        public bool Add(Student student)
        {


            return repository.Add(student);
        }

        public List<StudentGridViewModel> Search(StudentRequestModel request)
        {
            var students = base.SearcgQueryable(request);
            var list = students.ToList().ConvertAll(x => new StudentGridViewModel(x));
            return list;
        }

        public StudentDetailViewModel Detail(string id)
        {
            Student x = this.repository.GetDetail(id);
            if (x == null)
            {
                throw new ObjectNotFoundException();
            }

            var vm = new StudentDetailViewModel(x);

            return vm;
        }

    }
}
