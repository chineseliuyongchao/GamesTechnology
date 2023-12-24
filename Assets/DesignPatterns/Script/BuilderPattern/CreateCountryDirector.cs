namespace DesignPatterns.Script.BuilderPattern
{
    /// <summary>
    /// 创建国家的指挥者类
    /// </summary>
    public class CreateCountryDirector
    {
        public void CountryBuild(BaseCountryBuilder countryBuilder)
        {
            countryBuilder.InitRegime();
            countryBuilder.InitCulture();
            countryBuilder.InitArm();
        }
    }
}