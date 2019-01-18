using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace proCart
{
    [Serializable]
    public class Item
    {
        private string name;
        private string description;
        private Image photo;
        private Func<string> getName1;
        private Func<string> getDescription1;

        public Item(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public Item(string name, string description, Image photo)
        {
            this.name = name;
            this.description = description;
            this.photo = photo;
        }

        public Item(Func<string> getName1, Func<string> getDescription1)
        {
            this.getName1 = getName1;
            this.getDescription1 = getDescription1;
        }

        public string getName()
        {
            return this.name;
        }

        public string getDescription()
        {
            return this.description;
        }

        public Image getImage()
        {
            return this.photo;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setImage(Image photo)
        {
            this.photo = photo;
        }
    }
}
