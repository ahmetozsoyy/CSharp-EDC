using CSharpEgitim.DataAccessLayer.Abstract;
using CSharpEgitim.DataAccessLayer.Repositories;
using CSharpEgitim.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitim.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category> , ICategoryDal
    {
    }
}
