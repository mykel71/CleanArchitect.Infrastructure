﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitect.Infrastructure
{
    public interface IMovieRentalDbContext
    {
        DbSet<Movie> Movies { get; set; }
    }
}
