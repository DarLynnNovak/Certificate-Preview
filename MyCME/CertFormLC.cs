using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aptify.Framework.Application;
using Aptify.Framework.DataServices;
using Aptify.Framework.ExceptionManagement;
using Aptify.Framework.WindowsControls;
namespace ACSPreviewCertificate 
{
    class CertFormLC : FormTemplateLayout
    {
        private DataAction m_oda = new DataAction();
        private AptifyProperties m_oProps = new AptifyProperties();
        private AptifyApplication m_oApp = new AptifyApplication();
        private AptifyActiveButton previewBtn;
        public void Config()
        {
            try
            {
                m_oApp = ApplicationObject;
                m_oda = new Aptify.Framework.DataServices.DataAction(this.m_oApp.UserCredentials);

            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
            }
        }

        protected override void OnFormTemplateLoaded(FormTemplateLoadedEventArgs e)
        {
            base.OnFormTemplateLoaded(e);
            try
            {
                if (e.Operation == FormTemplateLoadedOperation.LoadTemplate)
                {
                    Config();

                    BindControls();

                }
            }

            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
            }
        }//End OnFormTemplateLoaded\
        protected virtual void BindControls()
        {
            try
            {
                if (previewBtn == null || previewBtn.IsDisposed)
                {
                    previewBtn = GetFormComponentByLayoutKey(this, "ACS.ACSCertificate.Tabs.General.Active Button.1") as AptifyActiveButton;
                }

                if (previewBtn != null)
                {
                    previewBtn.Click += previewBtn_Click;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
            }
        }//End Bind Controls 
        private void previewBtn_Click(object sender, EventArgs e)
        {

            UniqueIdFrm uniqueIdFrm = new UniqueIdFrm();
            uniqueIdFrm.Show();

        }
    }  
}
