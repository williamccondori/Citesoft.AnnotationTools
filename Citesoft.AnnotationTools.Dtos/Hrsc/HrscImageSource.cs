namespace Citesoft.AnnotationTools.Dtos.Hrsc
{
    public class HrscImageSource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static HrscImageSource Create(int id
            , string name)
        {
            return new HrscImageSource
            {
                Id = id,
                Name = name
            };
        }
    }
}
