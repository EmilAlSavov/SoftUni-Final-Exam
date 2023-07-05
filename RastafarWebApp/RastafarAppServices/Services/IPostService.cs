using RastafarAppServices.ViewModels.Export;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices.Services
{
    public interface IPostService
    {
        public List<PostPreviewViewModel> All();

        public List<PostPreviewViewModel> MyEvents();

        public List<PostPreviewViewModel> Fauvorite();

        public void Add();

        public void Edit();

        public void Delete();
    }
}
