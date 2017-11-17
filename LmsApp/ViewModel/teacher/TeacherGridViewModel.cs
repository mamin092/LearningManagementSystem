using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel.teacher
{
    public class TeacherGridViewModel : BaseViewModel<Teacher>
    {

        public TeacherGridViewModel(Teacher teacher) : base(teacher)
        {
            Name = teacher.Name;
        }

        public string Name { get; set; }
    }
}
