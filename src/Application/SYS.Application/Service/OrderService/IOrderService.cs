﻿using SYS.Application.Models.DTOs;
using SYS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Service.OrderService
{
    public interface IOrderService
    {
        Task<string> CreateOrder(AddOrderDTO model);
    }
}
