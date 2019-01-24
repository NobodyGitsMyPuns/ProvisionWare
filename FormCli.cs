
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using proCart;



namespace ProvisionwareClient
{
    public partial class FormCli : Form
    {
        private Requestor requestor;
        private string message = "This is my Data";
        private List<Item> itemList;
        private List<CartItem> cartItems;
        private Cart myCart;
        public byte[] cartByte;
        string ipAddress = "localhost";
        private int port = 6000;
        //Listens for a connection from TCP clients
        TcpListener listen = null;
        //provides Client Connection
        TcpClient client = null;
        //Stream of Network Data
        NetworkStream networkStreamData = null;

        //constructor (has stub catalog items)
        public FormCli(Requestor r)
        {

            this.requestor = r;
            this.Shown += new EventHandler(FormCli_Shown);
            this.itemList = new List<Item>();
            this.cartItems = new List<CartItem>();
           
            InitializeComponent();

            //********************************************************************************************************\\
            //Stub cart items for testing functionality, remove after server supplies catalog items
            Item item1 = new Item("Batteries, AA, 4 pack", "A 4 pack of AA batteries");
            Item item2 = new Item("Pen, Ballpoint, Black Ink", "A ballpoitn pen, made by Skillcraft.  Black ink.");
            itemList.Add(item1);
            itemList.Add(item2);
            this.listBoxCatalogViewer.Items.AddRange(new object[] {
            itemList[0].getName(),
            itemList[1].getName()});
            //Stub cart items for testing functionality, remove after server supplies catalog items
            //********************************************************************************************************\\
        }
        
        //message for logging
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

            
            AddText(logtxtbx, "Logging started");
            
            }
            catch (Exception exception)
            {
                AddText(logtxtbx,exception.ToString());
            }
            }

        //adds to the text without clearing the previous text.
        private delegate void SetTextCallBack(TextBox textBox, string text);
        public void AddText(TextBox textBox, string text)
        {
            try
            {
                if (textBox.InvokeRequired)
                {
                    var d = new SetTextCallBack(AddText);
                    Invoke(d, textBox, text);
                }
                else
                {
                    textBox.Text += text;
                    //scroll as log populates
                    logtxtbx.SelectionStart = logtxtbx.Text.Length;
                    logtxtbx.ScrollToCaret();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(" cross-thread call exception " + e);
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (client = new TcpClient(ipAddress, port))
                {
                    //
                    int byteCount = Encoding.ASCII.GetByteCount(message);
                    //
                    byte[] sendDate = new byte[byteCount];
                    //
                    sendDate = Encoding.ASCII.GetBytes(message);
                    //
                    networkStreamData = client.GetStream();
                    //
                    networkStreamData.Write(cartByte, 0, cartByte.Length);
                    //
                    networkStreamData.Close();
                    client.Close();

                }
            }
            catch (Exception exception)
            {
                AddText(logtxtbx, exception.ToString());
            }
        }
        
        // Convert a byte array to an Object
        public static Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }
        public static byte[] ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        //add item from catalog to Cart
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            //TODO ensure qty is an integer before adding to cart
            int qty = Convert.ToInt32(textBoxQuantityInput.Text);
            if (!listBoxCartViewer.Items.Contains(listBoxCatalogViewer.SelectedItem))
            {
                this.listBoxCartViewer.Items.Add(listBoxCatalogViewer.SelectedItem);
                int index = listBoxCartViewer.Items.Count - 1;
                CartItem cartItem = new CartItem(itemList[index], qty);
                if (myCart == null)
                {
                    myCart = new Cart(requestor);
                }
                myCart.setCartItem(cartItem);
            }
            

        }

        //Quantity textbox
        private void textBoxQuantityInput_Enter(object sender, EventArgs e)
        {
            this.textBoxQuantityInput.Text = "";
        }


        //set default Catalog highlight to the first item in the list (index 0)
        private void FormCli_Shown(object sender, EventArgs e)
        {
            listBoxCatalogViewer.SelectedIndex = 0;
        }
        

        //Submit Cart object to server
        private void buttonSubmitRequest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cartItems.Count; i++)
            {
                myCart.setCartItem(cartItems[i]);
            }
            cartByte = ObjectToByteArray(myCart);

            try
            {
                using (client = new TcpClient(ipAddress, port))
                {
                    //
                    int byteCount = Encoding.ASCII.GetByteCount(message);
                    //
                    byte[] sendDate = new byte[byteCount];
                    //
                    sendDate = Encoding.ASCII.GetBytes(message);
                    //
                    networkStreamData = client.GetStream();
                    //
                    networkStreamData.Write(cartByte, 0, cartByte.Length);
                    //
                    networkStreamData.Close();
                    client.Close();

                }
            }
            catch (Exception exception)
            {
                AddText(logtxtbx, exception.ToString());
            }
        }
    }
}
