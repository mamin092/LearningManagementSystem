using Model;

namespace ViewModel
{
    public class StudentDetailViewModel : BaseViewModel<Student>
    {
        public StudentDetailViewModel(Student student) : base(student)
        {
            Phone = student.Phone;
            Name = student.Name;
            Address = student.Address;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    public class StudentViewModel : BaseViewModel<Student>
    {

        public StudentViewModel (Entity entiry): base(entiry)
        {

        }
    }
}