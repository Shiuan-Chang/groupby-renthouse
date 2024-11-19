using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupby_renthouse
{
    public class RentalProperty
    {
        public string Location { get; set; }
        public string Type { get; set; }
        public int Rent { get; set; }
        public int Layout { get; set; }
        public bool IsNew { get; set; }
        public bool NearMRT { get; set; }
        public bool PetAllowed { get; set; }
        public bool HasParking { get; set; }
        public bool HasElevator { get; set; }
        public bool HasBalcony { get; set; }
        public bool ShortTermRental { get; set; }

        public override string ToString()
        {
            return $"Location: {Location}, Type: {Type}, Rent: {Rent}元, Layout: {Layout}房, " +
                   $"IsNew: {IsNew}, NearMRT: {NearMRT}, PetAllowed: {PetAllowed}, HasParking: {HasParking}, " +
                   $"HasElevator: {HasElevator}, HasBalcony: {HasBalcony}, ShortTermRental: {ShortTermRental}";
        }
    }


}
