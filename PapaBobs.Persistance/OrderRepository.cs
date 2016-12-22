using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistance {
    public class OrderRepository {
        public static void CreateOrder(DTO.Order orderDTO) {
            var db = new PapaBobsDbEntities();

            var order = converToEntity(orderDTO);
            db.OrderEntities.Add(order);
            db.SaveChanges();
        }

        public static List<DTO.Order> GetOrders() {
            var db = new PapaBobsDbEntities();
            var dbOrders = db.OrderEntities.ToList();

            var dtoOrders = new List<DTO.Order>();

            foreach (var dbOrder in dbOrders) {
                var dtoOrder = new DTO.Order();

                dtoOrder.OrderId = dbOrder.OrderId;
                dtoOrder.Size = dbOrder.Size;
                dtoOrder.Crust = dbOrder.Crust;
                dtoOrder.Sausage = dbOrder.Sausage;
                dtoOrder.Pepperoni = dbOrder.Pepperoni;
                dtoOrder.Onions = dbOrder.Onions;
                dtoOrder.GreenPeppers = dbOrder.GreenPeppers;
                dtoOrder.TotalCost = dbOrder.TotalCost;
                dtoOrder.Name = dbOrder.Name;
                dtoOrder.Address = dbOrder.Address;
                dtoOrder.Zip = dbOrder.Zip;
                dtoOrder.Phone = dbOrder.Phone;
                dtoOrder.PaymentType = dbOrder.PaymentType;
                dtoOrder.Completed = dbOrder.Completed;

                dtoOrders.Add(dtoOrder);
            }
            return dtoOrders;
        }

        private static OrderEntity converToEntity(DTO.Order orderDTO) {
            var orderEntity = new OrderEntity();

            orderEntity.OrderId = orderDTO.OrderId;
            orderEntity.Size = orderDTO.Size;
            orderEntity.Crust = orderDTO.Crust;
            orderEntity.Sausage = orderDTO.Sausage;
            orderEntity.Pepperoni = orderDTO.Pepperoni;
            orderEntity.Onions = orderDTO.Onions;
            orderEntity.GreenPeppers = orderDTO.GreenPeppers;
            orderEntity.TotalCost = orderDTO.TotalCost;
            orderEntity.Name = orderDTO.Name;
            orderEntity.Address = orderDTO.Address;
            orderEntity.Zip = orderDTO.Zip;
            orderEntity.Phone = orderDTO.Phone;
            orderEntity.PaymentType = orderDTO.PaymentType;
            orderEntity.Completed = orderDTO.Completed;

            return orderEntity;
        }
    }
}
