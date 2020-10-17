﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookingDAL.Models;

namespace BookingDAL.Repositories
{
   public interface IRepository<TKey>
   {
      public IQueryable<Entity<Guid>> GetAll();

      TKey Add(Entity<TKey> newEntity);
      Entity<TKey> Read(TKey existingEntityId);
      bool Update(Entity<TKey> existingEntity);
      bool Delete(TKey existingEntityId);
   }
}
