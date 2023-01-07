using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using DAL.Ef;

namespace DAL.Repositories.Impl
{
    public class EduInfoSystemRepository
            : BaseRepository<EduInfoSystem>, IEduInfoSystemRepository
    {
        internal EduInfoSystemRepository(EduInfoSystemContext context)
            : base(context)
        {
        }
    }
}