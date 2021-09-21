using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPdf;
namespace ACSPreviewCertificate
{
	public partial class UniqueIdFrm : Form
	{
        string uniqueId;
        string personsql;
        string eventsql;
                        

		public UniqueIdFrm()
		{
            CheckKey();
			InitializeComponent();
		}

		private void PreviewBtn_Click(object sender, EventArgs e)
		{
            uniqueId = UniqueIdTxtBox.Text;
            //MessageBox.Show(uniqueId);
            string sURL = "http://dev.facs.org/Certificate/Display/Index?auid=" + uniqueId;
            //string finalURL = sURL + uniqueId;
            this.Close();
            Process.Start(sURL);
        }
         
        private void CheckKey()
        {
            try
            {
                // Dim appSettingsReader = New AppSettingsReader()
                // Dim key As String = appSettingsReader.GetValue("IronPdfKey", GetType(String))
                string key = "IRONPDF-49375960F4-720786-6BFD0A-2F308E1D40-7ECEEDDF-UEx60905F54E21F8D8-AMERICANCOLLEGEOFSURGEONS.IRO200326.7419.20147.ORG.5DEV.1YR.SUPPORTED.UNTIL.27.MAR.2021";
				// Example reading key from appsettings
				IronPdf.License.LicenseKey = key;
            }
            catch (Exception ex)
            {
                Aptify.Framework.ExceptionManagement.ExceptionManager.Publish(ex);
            }
        }
        private void getPersonFields()
        {
            personsql = "select personid from acspersoncme where acsuniqueid = " + uniqueId;
        }
        private void getEventFields()
        {
            eventsql = "select ACSCMEEventId from acspersoncme where acsuniqueid = " + uniqueId;
        }


    }
}
