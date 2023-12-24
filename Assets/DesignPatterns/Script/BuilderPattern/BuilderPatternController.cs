using UnityEngine;

namespace DesignPatterns.Script.BuilderPattern
{
    /// <summary>
    /// 建造者模式
    /// 针对同一类对象的不同具体实现，固定一套建造流程，流程的每个步骤通过抽象方法完成不同实现
    /// </summary>
    public class BuilderPatternController : MonoBehaviour
    {
        private CreateCountryDirector _createCountryDirector;
        private BaseCountryBuilder _baseCountryBuilderA;
        private BaseCountryBuilder _baseCountryBuilderB;

        private void Awake()
        {
            _createCountryDirector = new CreateCountryDirector();
            _baseCountryBuilderA = new CountryBuilderA();
            _baseCountryBuilderB = new CountryBuilderB();
        }

        private void Start()
        {
            _createCountryDirector.CountryBuild(_baseCountryBuilderA);
            Country countryA = _baseCountryBuilderA.GetCountry();
            countryA.Show();
            _createCountryDirector.CountryBuild(_baseCountryBuilderB);
            Country countryB = _baseCountryBuilderB.GetCountry();
            countryB.Show();
        }
    }
}