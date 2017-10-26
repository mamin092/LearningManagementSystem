using Model;

namespace ViewModel
{
    public class TeacherDetailViewModel : BaseViewModel
    {
        public TeacherDetailViewModel(Teacher teacher): base(teacher)
        {
            Name =teacher.Name;
        }

        public string Name { get; set; }
    }
}