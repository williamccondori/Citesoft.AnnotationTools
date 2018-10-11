namespace Citesoft.AnnotationTools.Dtos.Hrsc
{
    public class HrscDataset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RootDirectory { get; set; }
        public string Folder { get; set; }
        public string ImagesFolder { get; set; }
        public string AnnotationFolder { get; set; }
        public string LandMaskFolder { get; set; }
        public string ObjectSegmantationFolder { get; set; }

        public HrscDataset()
        {

        }

        public static HrscDataset Create(
            int id
            , string name
            , string description
            , string rootDirectory
            , string folder
            , string imagesFolder
            , string annotationFolder
            , string landMaskFolder
            , string objectSegmentationFolder)
        {
            return new HrscDataset
            {
                Id = id,
                Name = name,
                Description = description,
                RootDirectory = rootDirectory,
                Folder = folder,
                ImagesFolder = imagesFolder,
                AnnotationFolder = annotationFolder,
                LandMaskFolder = landMaskFolder,
                ObjectSegmantationFolder = objectSegmentationFolder
            };
        }
    }
}
