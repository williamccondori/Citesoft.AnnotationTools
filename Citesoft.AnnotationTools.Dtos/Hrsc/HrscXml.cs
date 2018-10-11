using System.Collections.Generic;

namespace Citesoft.AnnotationTools.Dtos.Hrsc
{
    public class HrscXml
    {
        public HrscDataset HrscDataset { get; set; }
        public IList<HrscClass> HrscClasses { get; set; }

        public IList<HrscImageSource> HrscImageSources { get; set; }
        public IList<HrscPlace> HrscPlaces { get; set; }
    }
}
