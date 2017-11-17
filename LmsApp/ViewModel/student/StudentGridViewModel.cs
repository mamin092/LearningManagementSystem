using Model;

namespace ViewModel
{
    public class StudentGridViewModel : BaseViewModel<Student>
    {
        public StudentGridViewModel(Student student) : base(student)
        {
            Phone = student.Phone;
            Name = student.Name;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
    }
}