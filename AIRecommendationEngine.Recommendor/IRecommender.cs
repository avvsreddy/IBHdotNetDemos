namespace AIRecommendationEngine.Recommendor
{
    public interface IRecommender
    {
        double GetCorellation(List<int> baseDate, List<int> otherData);
    }
}
