using PapaBobs.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain {
    public static class OrderManager {
        public static void CreateOrder(DTO.Order dtoOrder) {
            dtoOrder.OrderId = Guid.NewGuid();
            dtoOrder.TotalCost = PizzaPriceManager.CalculateCost(dtoOrder);
            Persistance.OrderRepository.CreateOrder(dtoOrder);
        }

        public static List<DTO.Order> GetOrders() {
            return Persistance.OrderRepository.GetOrders();
        }

    }
}
