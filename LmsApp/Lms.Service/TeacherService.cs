using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Repository;
using Model;
using RequestModel;
using ViewModel;
using ViewModel.teacher;

namespace Lms.Service
{
    public class TeacherService
    {
        private BaseRepository<Teacher> repository;

        public TeacherService()
        {
            this.repository = new BaseRepository<Teacher>();
        }

        public bool Add(Teacher teacher)
        {
            return repository.Add(teacher);
        }

        public List<TeacherGridViewModel> Search(TeacherRequestModel request)
        {
            IQueryable<Teacher> teachers = this.repository.Get();

            if (!string.IsNullOrWhiteSpace(request.Name))
            {
                teachers = teachers.Where(x => x.Name.ToLower().Contains(request.Name.ToLower()));
             
            }
            teachers = teachers.OrderBy(x => x.Modified);
            //if (!string.IsNullOrWhiteSpace(request.OrderBy))
            //{
            //    if (request.OrderBy.ToLower()=="name")
            //    {
            //        teachers = request.IsAscending
            //            ? teachers.OrderBy(x => x.Name)
            //            : teachers.OrderByDescending(x => x.Name);
            //    }
            //}
            if (!string.IsNullOrWhiteSpace(request.OrderBy) && request.OrderBy.ToLower() == "name")
            {
                teachers = request.IsAscending
                    ? teachers.OrderBy(x => x.Name)
                    : teachers.OrderByDescending(x => x.Name);
            }

            teachers = teachers.Skip((request.Page - 1) * 10).Take(request.PerPageCount);

            var list = teachers.ToList().ConvertAll(x => new TeacherGridViewModel(x));
            return list;
        }


        public TeacherDetailViewModel Detail(string id)
        {
            Teacher x = this.repository.GetDetail(id);
            if (x==null)
            {
                throw new ObjectNotFoundException();
            }
            var vm = new TeacherDetailViewModel(x);
            return vm;
        }
    }
}
