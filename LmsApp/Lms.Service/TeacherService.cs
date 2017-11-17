using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using Lms.Repository;
using Model;
using RequestModel;
using ViewModel;
using ViewModel.teacher;
using System.Linq.Expressions;

namespace Lms.Service
{
    public class TeacherService : BaseService<Teacher>
    {
        private GenericRepository<Teacher> repository;

        public TeacherService()
        {
            this.repository = new GenericRepository<Teacher>();
        }

        public bool Add(Teacher teacher)
        {
            return repository.Add(teacher);
        }

        public List<TeacherGridViewModel> Search(TeacherRequestModel request)
        {

            var teachers = base.SearcgQueryable(request);

            var list = teachers.ToList().ConvertAll(x => new TeacherGridViewModel(x));
            return list;

        }



        public TeacherDetailViewModel Detail(string id)
        {
            Teacher x = this.repository.GetDetail(id);
            if (x == null)
            {
                throw new ObjectNotFoundException();
            }
            var vm = new TeacherDetailViewModel(x);
            return vm;
        }
    }
}
