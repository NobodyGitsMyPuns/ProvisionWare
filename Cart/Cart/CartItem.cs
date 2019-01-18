using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace proCart
{
    [Serializable]
    public class CartItem : Item
    {
        private string itemName;
        private int quantity;

        public CartItem(Item i, int quantity) : base(i.getName, i.getDescription)
        {
            this.itemName = i.getName();
            this.quantity = quantity;
        }

        public string getItemName()
        {
            return this.itemName;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

    }
}
