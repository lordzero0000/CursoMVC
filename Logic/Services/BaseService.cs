﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Model;

namespace Logic.Services
{
    public class BaseService
    {
        public CursoEntities _context;

        public BaseService()
        {
            _context = new CursoEntities();
        }

    }
}
