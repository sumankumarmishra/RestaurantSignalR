﻿using SignalR.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Business.Interfaces
{
    public interface IOrderService:IGenericService<Order>
    {

        decimal LastOrderPrice();

        decimal TodaysTotalPrice();
    }
}
