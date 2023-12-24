namespace DesignPatterns.Script.BuilderPattern
{
    /// <summary>
    /// 创建国家A
    /// </summary>
    public class CountryBuilderA : BaseCountryBuilder
    {
        private readonly Country _country = new Country();

        public override void InitRegime()
        {
            _country.AddParts("国家A的政体");
        }

        public override void InitCulture()
        {
            _country.AddParts("国家A的文化");
        }

        public override void InitArm()
        {
            _country.AddParts("国家A的兵种");
        }

        public override Country GetCountry()
        {
            return _country;
        }
    }
}