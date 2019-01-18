using System;
using System.Collections.Generic;

namespace proCart
{
    [Serializable]
    public class Cart
    {

        /*
        public string userName { get; set; }
        public string OrderNumber { get; set; }
        public List<string> Items { get; set; }
        public List<int> quantity { get; set; }
        */

        private List<CartItem> contents;
        private DateTime date;
        private Requestor requestor;
        

        public Cart(Requestor r)
        {
            this.contents = new List<CartItem>();
            this.date = DateTime.Today;
            this.requestor = r;
        }

        public CartItem getCartItem(int index)
        {
            return contents[index];
        }

        public List<CartItem> getContentList()
        {
            return this.contents;
        }
        
        public void setCartItem(CartItem newItem)
        {
            contents.Add(newItem);
        }

        public DateTime getDate()
        {
            return date;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public Requestor getRequestor()
        {
            return this.requestor;
        }

        public void setRequestor(Requestor r)
        {
            this.requestor = r;
        }
    }

}