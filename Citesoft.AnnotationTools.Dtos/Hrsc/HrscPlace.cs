namespace Citesoft.AnnotationTools.Dtos.Hrsc
{
    public class HrscPlace
    {
        public int Id { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string CountryName { get; set; }

        public static HrscPlace Create(int id,
            string no,
            string name,
            string countyrName)
        {
            return new HrscPlace
            {
                Id = id,
                No = no,
                Name = name,
                CountryName = countyrName
            };
        }
    }
}
