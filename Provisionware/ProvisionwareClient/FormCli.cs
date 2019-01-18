
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
        private string message = "This is my Data";
        public byte[] cartByte;
        public FormCli()
        {
            InitializeComponent();
            Requestor requestor = new Requestor("John", "Wick");
            Item myItem = new Item("Deoderant", "An oder blocking gel applicator.");
            CartItem index0 = new CartItem(myItem, 6);
            Cart myCart = new Cart(requestor);
            myCart.setCartItem(index0);

             cartByte = ObjectToByteArray(myCart);
           // var cartObject = ByteArrayToObject(cartByte);

        }
        string ipAddress = "localhost";
        private int port = 6000;
        //Listens for a connection from TCP clients
        TcpListener listen = null;
        //provides Client Connection
        TcpClient client = null;
        //Stream of Network Data
        NetworkStream networkStreamData = null;
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


    }


    

}
