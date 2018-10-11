using System;
using System.IO;
using System.Windows.Forms;

namespace Citesoft.AnnotationTools.Presentacion
{
    public partial class AnnotationTool : Form
    {
        public AnnotationTool()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void btnSearchCacheDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK
                && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                txtCacheDirectory.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnSearchSystemDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK
                && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                txtSystemDirectory.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnSearchSystemFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            if (File.Exists(txtSystemFile.Text))
                openFileDialog.FileName = txtSystemFile.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK
                && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                txtSystemFile.Text = openFileDialog.FileName;
        }

        private void btnCreateSystemDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("It creates a new dataset, are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (!(dialogResult == DialogResult.Cancel) && !(dialogResult == DialogResult.No))
                {
                    if (!Directory.Exists(txtSystemDirectory.Text))
                        throw new ApplicationException("Please select a directory");
                    CreateProjectTree(txtSystemDirectory.Text);
                    AnnotationManageForm annotationManageForm = new AnnotationManageForm();

                    if (string.IsNullOrEmpty(txtCacheDirectory.Text))
                        CreateProjectCache(txtSystemDirectory.Text);
                    else
                    {
                        //_aform.M_CacheDir = this.tCache.Text + "\\";
                    }

                    /**
                    annotationManageForm.M_SysDataXmlPath = txt_sysdatadir.Text + "\\FullDataSet\\sysdata.xml";
                    annotationManageForm.M_SysDirPath = txt_sysdatadir.Text + "\\";

                    HRSC_DATASET_MDL_XML mdl = new HRSC_DATASET_MDL_XML(_aform.M_SysDataXmlPath);
                    DataSet _ds = mdl.Get_DataSetAllData();
                    DataRow dr = _ds.Tables["HRSC_DataSet"].Rows[0];
                    dr["DS_RootDir"] = _aform.M_SysDirPath;
                    mdl.SaveSysDataToXml(_ds);
    **/
                    annotationManageForm.StartPosition = FormStartPosition.CenterParent;
                    annotationManageForm.Show(this);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CreateProjectCache(string baseProjectPath)
        {
            if (Directory.Exists(baseProjectPath + "\\FullDataSet"))
                Directory.Delete(baseProjectPath + "\\FullDataSet", true);
        }

        private void CreateProjectTree(string baseProjectPath)
        {
            if (Directory.Exists(baseProjectPath + "\\FullDataSet"))
                Directory.Delete(baseProjectPath + "\\FullDataSet", true);
            Directory.CreateDirectory(baseProjectPath + "\\FullDataSet");
            Directory.CreateDirectory(baseProjectPath + "\\FullDataSet\\AllImages");
            Directory.CreateDirectory(baseProjectPath + "\\FullDataSet\\Annotations");
            Directory.CreateDirectory(baseProjectPath + "\\FullDataSet\\Segmentations");
            //File.Copy("sysdata.xml", baseProjectPath + "\\FullDataSet\\sysdata.xml", true);
        }
    }
}
