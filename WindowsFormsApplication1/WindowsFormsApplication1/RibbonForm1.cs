using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WindowsFormsApplication1
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void axLicenseControl1_Enter(object sender, EventArgs e)
        {

        }
        
        private void RibbonForm1_Load(object sender, EventArgs e)
        {
   

            axTOCControl1.Location = dockPanel1.Location;
            axTOCControl1.Size = dockPanel1.Size;
            axTOCControl1.Dock = DockStyle.Fill;
            axTOCControl1.Parent = dockPanel1;

            axMapControl1.Location = dockPanel2.Location;
            axMapControl1.Size = dockPanel2.Size;
            axMapControl1.Dock = DockStyle.Fill;
            axMapControl1.Parent = dockPanel2;

            axTOCControl1.SetBuddyControl(axMapControl1);
        }

        private void barbuttonitem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //MessageBox.Show("Hello word");
        }

        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {

        }

        private void RibbonForm1_Shown(object sender, EventArgs e)
        {
           
            this.dockPanel1.Width = this.Width / 3;
            this.dockPanel1.Height = this.Height*2/3;
          
            this.dockPanel2.Width = this.Width *2/ 3;
            this.dockPanel2.Height = this.Height ;
            this.dockPanel5.Width = this.Width / 3; ;
            this.dockPanel5.Height = this.Height / 3;
            
            
            //this.dockPanel1.Refresh();
       
            //this.dockPanel5.Location.X = this.dockPanel2.Location.X;
            //this.dockPanel5.Refresh();
            //this.dockPanel2.Refresh();
        }

  

        private void dockPanel2_Resize(object sender, EventArgs e)
        {
           // this.dockPanel2.Width = this.Width * 2 / 3;
            //this.dockPanel2.Height = this.Height * 2 / 3;
        }

        private void dockPanel5_LocationChanged(object sender, EventArgs e)
        {
            //this.dockPanel5.Location.X = this.dockPanel2.Location.X;
            //this.dockPanel5.Location.Y = this.dockPanel2.Location.Y + dockPanel2.Height;

        }

        private void dockPanel5_Resize(object sender, EventArgs e)
        {

           // this.dockPanel5.Height = this.Height / 2;
            //this.dockPanel5.Height = this.dockPanel1.Height;
           // this.dockPanel5.Width = this.dockPanel1.Width;
        }

        

      //using DevExpress.XtraBars.Docking;
      //dockManager1.StartSizing += dockManager1_StartSizing;

      //void dockManager1_StartSizing(object sender, StartSizingEventArgs e) {
      //if(e.Panel == dockPanel1)
         //  e.Cancel = true;
       //} 
        
    }
}