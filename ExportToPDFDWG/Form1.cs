using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

using eDrawings.Interop.EModelViewControl;

namespace ExportToPDFDWG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Instantiate the OpenFileDialog class
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();


            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = openFileDialog.SelectedPath;
                button4.Tag = folderPath;
            }

        }

        private void pdf_Click(object sender, EventArgs e)
        {
            //tak jadi lagi fck
            string path = (string)button4.Tag;

            if (path != null)
            {
                SldWorks swApp = null;
                ModelDoc2 swModel = null;
                DirectoryInfo folder = new DirectoryInfo(path);
                string pdfFolder = "PDF folder";
                string pdfFolderPath = Path.Combine(path, pdfFolder);
                Directory.CreateDirectory(pdfFolderPath);

                foreach (FileInfo file in folder.GetFiles())
                {
                    
                    string filePath = path + "\\" + file;
                    string fileName = pdfFolderPath + "\\" + file.Name.Replace(".SLDDRW", ".PDF");

                    //open the file in solidworks
                    swApp = (SldWorks)Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application"));
                    swModel = (ModelDoc2)swApp.OpenDoc6(filePath, (int)swDocumentTypes_e.swDocDRAWING, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", 0, 0);
                    swApp.Visible = true;

                    //check if solidwork file is null or not
                    if (swModel != null && swModel.GetType() == (int)swDocumentTypes_e.swDocDRAWING)
                    {
                        swModel.SaveAs4(fileName, (int)swSaveAsVersion_e.swSaveAsCurrentVersion, (int)swSaveAsOptions_e.swSaveAsOptions_Silent, 0, 0);

                    }
                    else
                        continue;

                    
                }
                MessageBox.Show("All files saved successfully to PDF");
            }
            else
                MessageBox.Show("Please browse a folder");


        }

        private void ExportDWG_Click(object sender, EventArgs e)
        {
            string path = (string)button4.Tag;

            if (path != null)
            {
                SldWorks swApp = null;
                ModelDoc2 swModel = null;
                DirectoryInfo folder = new DirectoryInfo(path);
                string pdfFolder = "DWG folder";
                string pdfFolderPath = Path.Combine(path, pdfFolder);
                Directory.CreateDirectory(pdfFolderPath);

                foreach (FileInfo file in folder.GetFiles())
                {

                    string filePath = path + "\\" + file;
                    string fileName = pdfFolderPath + "\\" + file.Name.Replace(".SLDDRW", ".DWG");

                    //open the file in solidworks
                    swApp = (SldWorks)Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application"));
                    swModel = (ModelDoc2)swApp.OpenDoc6(filePath, (int)swDocumentTypes_e.swDocDRAWING, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", 0, 0);
                    swApp.Visible = true;

                    //check if solidwork file is null or not
                    if (swModel != null && swModel.GetType() == (int)swDocumentTypes_e.swDocDRAWING)
                    {
                        swModel.SaveAs4(fileName, (int)swSaveAsVersion_e.swSaveAsCurrentVersion, (int)swSaveAsOptions_e.swSaveAsOptions_Silent, 0, 0);

                    }
                    else
                        continue;


                }
                MessageBox.Show("All files saved successfully to PDF");
            }
            else
                MessageBox.Show("Please browse a folder");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            string path = (string)button4.Tag;
            string pdfFolderPath = path + "\\" + "PDF folder";
            DirectoryInfo pdfFolder = new DirectoryInfo(pdfFolderPath);

            foreach(FileInfo file in pdfFolder.GetFiles())
            {
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //planning to 
            




        }
    }




}
