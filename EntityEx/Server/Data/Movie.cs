﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityEx.Server.Data
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Actor> Actors { get; set; }
    }
}
