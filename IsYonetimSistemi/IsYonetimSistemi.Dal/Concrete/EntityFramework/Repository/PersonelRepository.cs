﻿using IsYonetimSistemi.Dal.Abstract;
using IsYonetimSistemi.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace IsYonetimSistemi.Dal.Concrete.EntityFramework.Repository
{
    public class PersonelRepository : GenericRepository<Personel>, IPersonelRepository
    {
        public PersonelRepository(DbContext context) : base(context)
        {
        }
    }
}
