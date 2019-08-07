using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Player
{
    public partial class frmPlayer : Form
    {
        Thread svthread;
        UdpClient client = new UdpClient(201);
        String from;
        public frmPlayer()
        {
            InitializeComponent();
            svthread = new Thread(new ThreadStart(startplayer));
            svthread.IsBackground = true;
            svthread.Start(); 
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] senddata ;
            string answer;
            answer = ans.Text + "@" + Dns.GetHostName( ) ;
            senddata = Encoding.ASCII.GetBytes ( answer ) ;
            try
            {
                client.Send ( senddata, senddata.Length, from, 200 ) ;
            }
            catch
            {
                MessageBox.Show ( "Error sending data" ) ;
            }
        }
        delegate void delEditaEtiqueta(Label l, String t);
        void EditaEtiqueta(Label l, String t)
        {
            if (l.InvokeRequired)
                l.Invoke(new delEditaEtiqueta(EditaEtiqueta), l, t);
            else
                l.Text = t;
        }
        public void startplayer()
        {
            IPEndPoint recvpt = new IPEndPoint(IPAddress.Any, 200);
            byte[] data;
            string str;
            int index;
            while (true)
            {
                data=client.Receive(ref recvpt);
                str=Encoding.ASCII.GetString(data); 
                index=str.LastIndexOf("@");
                from=str.Substring(index+1);
                str=str.Remove(index, str.Length - index);
                EditaEtiqueta(question, str);
            }
        }
    }
}
