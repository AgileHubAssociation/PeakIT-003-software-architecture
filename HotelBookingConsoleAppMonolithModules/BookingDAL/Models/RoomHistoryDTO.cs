﻿using System;
using System.Collections.Generic;
using System.Text;
using CrossCuttingConcerns.Models;

namespace BookingDAL.Models
{
   public class RoomHistoryDTO : Entity<Guid>
   {
      public Guid RoomId { get; set; }

      public Guid GuestId { get; set; }

      public Guid OrderId { get; set; }
   }
}
