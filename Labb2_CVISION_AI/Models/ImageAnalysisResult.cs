namespace Labb2_CVISION_AI.Models
{
    public class ImageAnalysisResult
    {
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Objects { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
