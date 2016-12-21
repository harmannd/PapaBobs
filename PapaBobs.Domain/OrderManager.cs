using PapaBobs.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain {
    public class OrderManager {
        public static List<DTO.Order> GetOrders() {
            return Persistance.OrderRepository.GetOrders();
        }

        public List<Crusts> populateCrustDropdown() {
            List<Crusts> crusts = new List<Crusts>();

            foreach (Crusts enumVal in Enum.GetValues(typeof(Crusts))) {
                crusts.Add(enumVal);
            }
            return crusts;
        }

        public List<Sizes> populateSizeDropdown() {
            List<Sizes> sizes = new List<Sizes>();

            foreach (Sizes enumVal in Enum.GetValues(typeof(Sizes))) {
                sizes.Add(enumVal);
            }
            return sizes;
        }

        public bool ValidateSizeInput(String size) {
            foreach (Sizes enumVal in Enum.GetValues(typeof(Sizes))) {
                if (size.Equals(enumVal.ToString())) {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateCrustInput(String crust) {
            foreach (Crusts enumVal in Enum.GetValues(typeof(Crusts))) {
                if (crust.Equals(enumVal.ToString())) {
                    return true;
                }
            }
            return false;
        }
    }
}
