using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPlannerApp
{
    public partial class Direction : Form
    {
        public delegate void sendPlaces(string places);
        public sendPlaces SenderP;
        public Direction()
        {
            InitializeComponent();
            SenderP = new sendPlaces(GetPlaces);

        }
       
        
        private void Direction_Load(object sender, EventArgs e)    
        {
            
        }
        private void GetPlaces(string places)
        {

            string start = "University of information technology VNU-HCM";
            string Start = start.Replace(" ", "+");
            string ends = places;
            string End = ends.Replace(" ", "+");
            StringBuilder query = new StringBuilder();
            query.Append("http://maps.google.com/maps/dir/");
            query.Append(Start + "/" + End);
            webBrowser1.Navigate(query.ToString());
        }

        
    }
}
