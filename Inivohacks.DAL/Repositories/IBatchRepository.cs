﻿using Inivohacks.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inivohacks.DAL.Repositories
{
    public interface IBatchRepository : IRepository<Batch>
    {
        Task<Batch> AddbatchAsync(Batch batch);
    }
}
