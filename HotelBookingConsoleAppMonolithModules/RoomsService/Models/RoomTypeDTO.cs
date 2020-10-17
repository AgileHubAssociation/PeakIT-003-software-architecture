﻿using System;
using System.Collections.Generic;
using System.Text;
using CrossCuttingConcerns.Models;

namespace RoomsService.Models
{
   public class RoomTypeDTO : Entity<Guid>
   {
      public string Title { get; set; }
      public decimal Price { get; set; }
   }
}
