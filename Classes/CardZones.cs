using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyEights
{
    public static class CardZones
    {
        public static List<CardZone> Zones = new List<CardZone>();

        public static CardZone GetCurrentZone(Card card)
        {
            foreach (CardZone zone in Zones)
            {
                if (zone.Bounds.Contains(card.Bounds))
                    return zone;
            }
            return null;
        }
    }
}
