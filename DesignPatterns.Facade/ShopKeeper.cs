using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade
{
    public class ShopKeeper
    {
        private IMobileShop iphone;
        private IMobileShop samsung;
        private IMobileShop blackBerry;

        public ShopKeeper()
        {
            iphone = new IPhone();
            samsung = new Samsung();
            blackBerry = new BlackBerry();
        }
        public void IPhoneSale()
        {
            iphone.ModelNo();
            iphone.Price();
        }
        public void SamsungSale()
        {
            samsung.ModelNo();
            samsung.Price();
        }
        public void BlackBerrySale()
        {
            blackBerry.ModelNo();
            blackBerry.Price();
        }
    }
}