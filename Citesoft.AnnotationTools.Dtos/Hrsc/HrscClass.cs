namespace Citesoft.AnnotationTools.Dtos.Hrsc
{
    public class HrscClass
    {
        public int Id { get; set; }
        public int HrsId { get; set; }
        public int Layer { get; set; }
        public string No { get; set; }
        public string ParentNo { get; set; }
        public string Name { get; set; }
        public string EngName { get; set; }
        public string ShortName { get; set; }
        public string DisplayColor { get; set; }
        public string SegmentationColor { get; set; }
        public string EdgeColor { get; set; }

        public static HrscClass Create(int id
            , int hrscId
            , int layer
            , string no
            , string parentNo
            , string name
            , string engName
            , string shortName
            , string displayColor
            , string segmentationColor
            , string edgeColor)
        {
            return new HrscClass
            {
                Id = id,
                HrsId = hrscId,
                Layer = layer,
                No = no,
                ParentNo = parentNo,
                Name = name,
                EngName = engName,
                ShortName = shortName,
                DisplayColor = displayColor,
                SegmentationColor = segmentationColor,
                EdgeColor = edgeColor
            };
        }
    }
}
