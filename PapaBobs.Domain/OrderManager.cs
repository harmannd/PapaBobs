﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain {
    public class OrderManager {
        public static List<DTO.Order> GetOrders() {
            var orders = Persistance.OrderRepository.GetOrders();
            return orders;
        }
    }
}
