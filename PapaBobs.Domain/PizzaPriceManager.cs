using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaBobs.DTO;

namespace PapaBobs.Domain {
    public class PizzaPriceManager {
        public static decimal CalculateCost(DTO.Order order) {
            decimal cost = 0;
            DTO.PizzaPriceDTO prices = GetPizzaPrices();

            cost += calculateSizeCost(order, prices);
            cost += calculateCrustCost(order, prices);
            cost += calculateToppingsCost(order, prices);

            return cost;
        }

        private static decimal calculateToppingsCost(Order order, DTO.PizzaPriceDTO prices) {
            decimal cost = 0;
            if (order.Sausage) {
                cost += prices.SausageCost;
            }
            if (order.Pepperoni) {
                cost += prices.PepperoniCost;
            }
            if (order.Onions) {
                cost += prices.OnionsCost;
            }
            if (order.GreenPeppers) {
                cost += prices.GreenPeppersCost;
            }
            return cost;
        }

        private static decimal calculateCrustCost(Order order, DTO.PizzaPriceDTO prices) {
            decimal cost = 0;
            switch (order.Crust) {
                case DTO.Enums.Crusts.Regular:
                    cost = prices.RegularCrustCost;
                    break;
                case DTO.Enums.Crusts.Thin:
                    cost = prices.ThinCrustCost;
                    break;
                case DTO.Enums.Crusts.Thick:
                    cost = prices.ThickCrustCost;
                    break;
                default:
                    break;
            }
            return cost;
        }

        private static decimal calculateSizeCost(Order order, DTO.PizzaPriceDTO prices) {
            decimal cost = 0;
            switch (order.Size) {
                case DTO.Enums.Sizes.Small:
                    cost = prices.SmallSizeCost;
                    break;
                case DTO.Enums.Sizes.Medium:
                    cost = prices.MediumSizeCost;
                    break;
                case DTO.Enums.Sizes.Large:
                    cost = prices.LargeSizeCost;
                    break;
                default:
                    break;
            }
            return cost;
        }

        public static DTO.PizzaPriceDTO GetPizzaPrices() {
            return Persistance.PizzaPriceRepository.GetPizzaPrices();
        }
    }
}
