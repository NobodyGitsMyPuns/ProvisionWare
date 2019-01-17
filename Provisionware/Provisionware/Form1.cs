using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


namespace Provisionware
{
    public partial class Form1 : Form
    {
       private byte[] ip = new byte[] { 127, 0, 0, 1 };
       private int port = 6000;
        //Listens for a connection from TCP clients
        TcpListener listen = null;
        //provides Client Connection
        TcpClient client = null;
        //Stream of Network Data
        NetworkStream networkStreamData = null;
        //BinaryWriter writer = null;
        //BinaryReader reader = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
          
        }

        private void setIPPortbtn_Click(object sender, EventArgs e)
        {
            ChangePortandIp();
        }

        private void ChangePortandIp()
        {
            if (iptxtbx.Text == "" || porttxbx.Text == "")
            {
                currentSettingstxt.ForeColor = System.Drawing.Color.Red;
                currentSettingstxt.Text = "<Please enter in both a valid IP and Port>";
            }
            else
            {
                currentSettingstxt.ForeColor = System.Drawing.Color.ForestGreen;
                try
                {
                   // get the Ip entered in by the user
                    var getIps = iptxtbx.Text.Split(',');

                    //Convert it to a byte array
                    for (int i = 0; i < 4; i++)
                    {
                        Byte.TryParse(getIps[i], out ip[i]);
                    }
                    
                    Int32.TryParse(porttxbx.Text, out port);
                    
                 currentSettingstxt.Text = ("IP "+iptxtbx.Text + " Port " + port.ToString());
                }
                catch(Exception e)

                {
                    AddText(logtxtbx,"Failed to change IP address or Port: "+e.ToString());
                }
            }
         }

        private void listenbtn_Click(object sender, EventArgs e)
        {
            try
            {
                listen = new TcpListener(new IPAddress(ip), port);
                listen.Start();
                AddText(logtxtbx, "Server Started on: "+ ip[0] + "." + ip[1] + "." + ip[2] + "." + ip[3] + "/" + port);
             string message = null;
                /* Can only proceed from here 
                 * if a client makes a request to our application. 
                 * Once receives a request, should proceed from this line. */
                Task.Run(() => Listen());
                // Reads the bytes from the network  

            }
            catch (Exception ex)
            {
                AddText(logtxtbx, "Listen attempt Failed:" + ex.ToString());
            }
        }

        private void Listen()
        {
            try
            {
                AddText(logtxtbx, "Server Listening on: "+ ip[0]+"."+ ip[1]+ "." + ip[2]+ "." + ip[3]+"/"+port);
                const int bytesize = 1000; 
                byte[] buffer = new byte[bytesize];
                var senderRequest = listen.AcceptTcpClient();
                senderRequest.GetStream().Read(buffer, 0, bytesize);
               // string decoded = Encoding.ASCII.GetString(buffer,0,bytesize);
                Cart.Cart cartRequest=(Cart.Cart) ByteArrayToObject(buffer);
                string order="Order Number: "+cartRequest.OrderNumber+"\r\nName: "+cartRequest.userName+"\r\n";
                foreach (var item in cartRequest.Items)
                {
                    order += item + "\r\n";
                }
                AddText(logtxtbx, order);
                //AddText(logtxtbx, decoded);
                senderRequest.Close();
                listen.Stop();

            }
            catch (Exception e)
            {
                AddText(logtxtbx, "Listening was interupted: " + e.ToString());
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
                    Invoke(d, textBox, "\r\n"+text);
                }
                else
                {
                    textBox.Text += "\r\n"+text;
                    //scroll as log populates
                    logtxtbx.SelectionStart = logtxtbx.Text.Length;
                    logtxtbx.ScrollToCaret();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" cross-thread call exception " + ex);
            }
        }

        private void stopListening_Click(object sender, EventArgs e)
        {
            try
            {
                listen.Stop();
                AddText(logtxtbx, "Stopping Server");
            }
            catch (Exception exception)
            {
                AddText(logtxtbx,"Failed to stop server:"+exception.ToString());
              
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
                return obj as Cart.Cart;
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