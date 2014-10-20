/*
 *  Created on 10/18/2014 by Andrew Simontsev (Aurigma, Inc). 
 *  
 *  Why this application is created
 *  
 *  When IE is running in Enhanced Protection Mode (EPM) and it opens a page with
 *  an ActiveX control, BHO or any other IE Addon which is not marked as 
 *  "AppContainer compatible", it suggests either to turn EPM off for this particular 
 *  website (thus allow using the ActiveX) or proceed with EPM enabled (ActiveX will be 
 *  blocked then). Once the user makes a choice, he or she cannot change it anymore.  
 * 
 *  This application allows to undo the user's choice. According to Eric Law (ex IE developer)
 *  it is stored under HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\TabProcConfig
 *  
 *  http://blogs.msdn.com/b/ie/archive/2012/11/13/ie10-fast-fluid-perfect-for-touch-and-available-now-for-windows-7.aspx#10369000
 *
 *  So we just work with this entry. This key is undocumented, so this application may fail to 
 *  work in future.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace EpmManager
{


    public partial class MainForm : Form
    {

        // These values are "magic numbers" which are result of experiments on several machines.
        // Apparently they are a sort of bit flags but since we don't have any information how these flags 
        // work, let's just hardcode these numbers.
        const int EpmOff = 0x47B;
        const int EpmOff2 = 0x57B;
        const int EpmOn = 0x37A;
        const int EpmOn2 = 0x201;
        const int IEAskAgain = 0;
        const int IEAskAgain2 = 0x200;
  
        public MainForm()
        {
            InitializeComponent();
        }


        private void RefreshTabProcConfigList()
        {
            int[] selection = new int[websiteListView.SelectedIndices.Count];
            websiteListView.SelectedIndices.CopyTo(selection,0);

            //HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\TabProcConfig
            RegistryKey tabProcConfigKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\TabProcConfig", true);
            if (tabProcConfigKey == null)
            {
                MessageBox.Show(@"No websites with custom EPM setting found.");
                return;
            }
            websiteListView.Items.Clear();
            int i=0;
            foreach (string websiteName in tabProcConfigKey.GetValueNames()) 
            {
                int websiteValue = Convert.ToInt32(tabProcConfigKey.GetValue(websiteName));
                int iconIndex = -1;
                string valueDescription = "";
                switch (websiteValue)
                {
                    case EpmOff:
                    case EpmOff2:
                        iconIndex = 0;
                        valueDescription = String.Format("Epm Off (0x{0:X})", websiteValue);
                        break;
                    case EpmOn:
                    case EpmOn2:
                        iconIndex = 1;
                        valueDescription = String.Format("Epm On (0x{0:X})", websiteValue);
                        break;
                    case IEAskAgain:
                    case IEAskAgain2:
                        iconIndex = 2;
                        valueDescription = String.Format("IE will ask again (0x{0:X})", websiteValue);
                        break;
                    default:
                        /*    
                        // Perhaps the first bit means whether IE will re-ask for permissions.
                        if ((websiteValue & (1<<0)) == 0)
                        {
                            iconIndex = 2;
                            valueDescription = String.Format("IE will ask again (0x{0:X})", websiteValue);
                        }
                        else
                        {
                            iconIndex = 3;
                            valueDescription = String.Format("Unknown (0x{0:X})", websiteValue);
                        }
                        */
                        iconIndex = 3;
                        valueDescription = String.Format("Unknown (0x{0:X})", websiteValue);
                        break;
                }
                string[] element = { websiteName, valueDescription };
                websiteListView.Items.Add(new ListViewItem(element, iconIndex)).Selected = selection.Contains(i);
                i++;
            }
            tabProcConfigKey.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxInstructions.Rtf = EpmManager.Properties.Resources.Instructions;
            
            imageListIcons.Images.Add(EpmManager.Properties.Resources.thumbs_up_16);
            imageListIcons.Images.Add(EpmManager.Properties.Resources.thumbs_up2_16);
            imageListIcons.Images.Add(EpmManager.Properties.Resources.IE_16);
            imageListIcons.Images.Add(EpmManager.Properties.Resources.confused_16);
            
            toolStripButtonEpmOff.Enabled = false;
            toolStripButtonEpmOn.Enabled = false;
            toolStripButtonReset.Enabled = false;
            
            RefreshTabProcConfigList();
        }

        private void websiteListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (websiteListView.SelectedItems.Count >= 1)
            {
                toolStripButtonEpmOff.Enabled = true;
                toolStripButtonEpmOn.Enabled = true;
                toolStripButtonReset.Enabled = true;
            }
            else
            {
                toolStripButtonEpmOff.Enabled = false;
                toolStripButtonEpmOn.Enabled = false;
                toolStripButtonReset.Enabled = false;
            }
        }

        private void ChangeSelectedValuesTo(int val)
        {
            RegistryKey tabProcConfigKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\TabProcConfig", true);

            foreach (ListViewItem websiteItem in websiteListView.SelectedItems)
            {
                tabProcConfigKey.SetValue(websiteItem.Text, val);
            }
            tabProcConfigKey.Close();

            RefreshTabProcConfigList();        
        }

        private void toolStripButtonEpmOff_Click(object sender, EventArgs e)
        {
            ChangeSelectedValuesTo(EpmOff);
        }

        private void toolStripButtonEpmOn_Click(object sender, EventArgs e)
        {
            ChangeSelectedValuesTo(EpmOn);
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            ChangeSelectedValuesTo(IEAskAgain);
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTabProcConfigList();
        }

    }
}
