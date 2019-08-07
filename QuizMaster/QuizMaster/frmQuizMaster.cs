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

namespace QuizMaster
{
    public partial class frmQuizMaster : Form
    {
        String answer;
        Thread svthread;
        UdpClient server = new UdpClient(200);
        int rank=1;
        public frmQuizMaster()
        {
            InitializeComponent();
            svthread = new Thread(new ThreadStart(startserver));
            svthread.IsBackground = true;
            svthread.Start();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
           string question;
           byte[] senddata;
           question = que.Text + "@" + Dns.GetHostName();
           answer = ans.Text ;
           senddata = Encoding.ASCII.GetBytes(question);
           try
           {
               server.Send(senddata, senddata.Length, pcName1.Text, 201);
           }
           catch
           {
               MessageBox.Show ("Cannot send to " + pcName1.Text);
           }
           try
           {
               server.Send(senddata, senddata.Length, pcName2.Text, 201);
           }
           catch
           {
               MessageBox.Show("Cannot send to " + pcName2.Text);
           }
        }
        delegate void delEditaListBox(ListBox l, String t);
        void EditaListBox(ListBox l, String t)
        {
            if (l.InvokeRequired)
                l.Invoke(new delEditaListBox(EditaListBox), l, t);
            else
                l.Items.Add(t);
        }
        public void startserver()
        {
           // 1-Create an IPEndPoint to receive messages
           IPEndPoint recvpt = new IPEndPoint ( IPAddress.Any, 0 ) ;
           byte[] data; 
           string str, from;
           int index;
           while(true)
           {
		        // 2-Receive data
		        data = server.Receive(ref recvpt);
		        str = Encoding.ASCII.GetString (data);
		        index = str.LastIndexOf("@");
		        from = str.Substring(index + 1);
                EditaListBox(lbAnswers, str);
		        str = str.Remove(index, str.Length - index);
		        // 3-Check the answer 
		        string result;
		        if(str.CompareTo(answer)==0)
		        {
                    result = "Correct! your rank is " + rank + "@" + Dns.GetHostName();
			        rank += 1;
		        }
		        else
		        result = "Your answer is wrong!" + "@" + Dns.GetHostName();
		        if(rank == 3)
		        rank = 1;
        		
		        // 4-Send the result
		        byte[] senddata;
		        senddata=Encoding.ASCII.GetBytes(result);
		        try
		        {
                    server.Send(senddata, senddata.Length, from, 201);
		        }
		        catch
		        {
			        MessageBox.Show ( "Cannot send result" ) ;
		        }
           }
        }
        private void frmQuizMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            svthread.Abort();
        } 
    }
}
