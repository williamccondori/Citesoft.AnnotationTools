using Citesoft.AnnotationTools.Dtos.Hrsc;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Citesoft.AnnotationTools.Logic.XmlManager
{
    public class XmlManagerHrsc
    {
        private string _systemDataPath;

        public XmlManagerHrsc()
        {

        }

        /// <summary>
        /// Sobrecarga de constructor.
        /// </summary>
        /// <param name="systemDataPath">Direccion del archivo de configuracion.</param>
        public XmlManagerHrsc(string systemDataPath)
        {
            _systemDataPath = systemDataPath;
        }

        /// <summary>
        /// Se leen los datos del archivo XML.
        /// </summary>
        /// <returns>Objeto con los datos del archivo del XML.</returns>
        public HrscXml ReadDatasetInformationFromXml()
        {
            HrscXml hrscXml = new HrscXml();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(_systemDataPath);

            XmlNode xmlNodeDataSet = xmlDocument.SelectSingleNode("sysdata/HRSC_DataSet");
            HrscDataset hrscDataset = HrscDataset.Create(
                Convert.ToInt32(xmlNodeDataSet.SelectSingleNode("DS_ID").InnerText),
                xmlNodeDataSet.SelectSingleNode("DS_Name").InnerText,
                xmlNodeDataSet.SelectSingleNode("DS_Des").InnerText,
                xmlNodeDataSet.SelectSingleNode("DS_RootDir").InnerText,
                xmlNodeDataSet.SelectSingleNode("DS_Folder").InnerText,
                xmlNodeDataSet.SelectSingleNode("DS_ImgsFolder").InnerText,
                xmlNodeDataSet.SelectSingleNode("DS_AnnotationsFolder").InnerText,
                xmlNodeDataSet.SelectSingleNode("DS_LandMaskFolder").InnerText,
                xmlNodeDataSet.SelectSingleNode("DS_ObjectSegFolder").InnerText);

            List<HrscClass> hrscClasses = new List<HrscClass>();
            XmlNodeList xmlNodeClasses = xmlDocument.SelectNodes("sysdata/HRSC_Classes/HRSC_Class");
            foreach (XmlNode xmlNodeClass in xmlNodeClasses)
                hrscClasses.Add(HrscClass.Create(
                    Convert.ToInt32(xmlNodeClass.SelectSingleNode("Class_ID").InnerText),
                    xmlNodeClass.SelectSingleNode("HRS_Class_ID").InnerText.Length > 0 ?
                    Convert.ToInt32(xmlNodeClass.SelectSingleNode("HRS_Class_ID").InnerText) : 0,
                    Convert.ToInt32(xmlNodeClass.SelectSingleNode("Class_Layer").InnerText),
                    xmlNodeClass.SelectSingleNode("Class_NO").InnerText,
                    string.Empty,
                    xmlNodeClass.SelectSingleNode("Class_Name").InnerText,
                    xmlNodeClass.SelectSingleNode("Class_EngName").InnerText,
                    xmlNodeClass.SelectSingleNode("Class_ShortName").InnerText,
                    xmlNodeClass.SelectSingleNode("Class_DisplayColor").InnerText,
                    xmlNodeClass.SelectSingleNode("seg_color").InnerText,
                    xmlNodeClass.SelectSingleNode("edg_color").InnerText));
            hrscClasses.ForEach(p => p.ParentNo = p.No);

            List<HrscImageSource> hrscImageSources = new List<HrscImageSource>();
            XmlNodeList xmlNodeImageSources = xmlDocument.SelectNodes("sysdata/HRSC_ImgSrces/HRSC_ImgSrc");
            foreach (XmlNode xmlNodeImageSource in xmlNodeImageSources)
                hrscImageSources.Add(HrscImageSource.Create(
                    Convert.ToInt32(xmlNodeImageSource.SelectSingleNode("Source_ID").InnerText),
                    xmlNodeImageSource.SelectSingleNode("Source_Name").InnerText));

            List<HrscPlace> hrscPlaces = new List<HrscPlace>();
            XmlNodeList xmlNodePlaces = xmlDocument.SelectNodes("sysdata/HRSC_Places/HRSC_Place");
            foreach (XmlNode xmlNodePlace in xmlNodePlaces)
                hrscPlaces.Add(HrscPlace.Create(
                    Convert.ToInt32(xmlNodePlace.SelectSingleNode("Place_ID").InnerText),
                    xmlNodePlace.SelectSingleNode("PlaceNO").InnerText,
                    xmlNodePlace.SelectSingleNode("PlaceName").InnerText,
                    xmlNodePlace.SelectSingleNode("CountryName").InnerText));

            hrscXml.HrscDataset = hrscDataset;
            hrscXml.HrscClasses = hrscClasses;

            hrscXml.HrscImageSources = hrscImageSources;
            hrscXml.HrscPlaces = hrscPlaces;
            return hrscXml;
        }
    }
}
