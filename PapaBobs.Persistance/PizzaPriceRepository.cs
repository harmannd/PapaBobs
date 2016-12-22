using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistance {
    public class PizzaPriceRepository {
        public static DTO.PizzaPriceDTO GetPizzaPrices() {
            var db = new PapaBobsDbEntities();
            var prices = db.PizzaPrices.First();
            var pizzPriceDTO = convertToDTO(prices);

            return pizzPriceDTO;
        }

        private static DTO.PizzaPriceDTO convertToDTO(PizzaPrice pizzaPrice) {
            var pizzaPriceDTO = new DTO.PizzaPriceDTO();

            pizzaPriceDTO.SmallSizeCost = pizzaPrice.SmallSizeCost;
            pizzaPriceDTO.MediumSizeCost = pizzaPrice.MediumSizeCost;
            pizzaPriceDTO.LargeSizeCost = pizzaPrice.LargeSizeCost;
            pizzaPriceDTO.ThickCrustCost = pizzaPrice.ThickCrustCost;
            pizzaPriceDTO.ThinCrustCost = pizzaPrice.ThinCrustCost;
            pizzaPriceDTO.RegularCrustCost = pizzaPrice.RegularCrustCost;
            pizzaPriceDTO.PepperoniCost = pizzaPrice.PepperoniCost;
            pizzaPriceDTO.SausageCost = pizzaPrice.SausageCost;
            pizzaPriceDTO.OnionsCost = pizzaPrice.OnionsCost;
            pizzaPriceDTO.GreenPeppersCost = pizzaPrice.GreenPeppersCost;

            return pizzaPriceDTO;
        }
    }
}
