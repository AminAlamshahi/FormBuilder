﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Models;

namespace DataLayer.Context
{
    public class FormDataBase : DbContext
    {
        //form db context.
        public FormDataBase()
        {

        }
        public DbSet<BaseComponent> Components { get; set; }
        public DbSet<Form> Forms { get; set; }
    }
}
