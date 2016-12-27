using PapaBobs.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain {
    public static class OrderManager {
        public static void CreateOrder(DTO.Order dtoOrder) {
            if (dtoOrder.Name.Trim().Length == 0) {
                throw new Exception("Name is required.");
            }
            if (dtoOrder.Address.Trim().Length == 0) {
                throw new Exception("Address is required.");
            }
            if (dtoOrder.Zip.Trim().Length == 0) {
                throw new Exception("Zip code is required.");
            }
            if (dtoOrder.Phone.Trim().Length == 0) {
                throw new Exception("Phone number is required.");
            }

            dtoOrder.OrderId = Guid.NewGuid();
            dtoOrder.TotalCost = PizzaPriceManager.CalculateCost(dtoOrder);
            Persistance.OrderRepository.CreateOrder(dtoOrder);
        }

        public static List<DTO.Order> GetOrders() {
            return Persistance.OrderRepository.GetOrders();
        }

        public static void CompleteOrder(Guid orderId) {
            Persistance.OrderRepository.CompleteOrder(orderId);
        }
    }
}
