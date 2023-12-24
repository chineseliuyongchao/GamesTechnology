namespace DesignPatterns.Script.BuilderPattern
{
    /// <summary>
    /// 国家的基类
    /// </summary>
    public abstract class BaseCountryBuilder
    {
        /// <summary>
        /// 初始化政体
        /// </summary>
        public abstract void InitRegime();

        /// <summary>
        /// 初始化文化
        /// </summary>
        public abstract void InitCulture();

        /// <summary>
        /// 初始化军队
        /// </summary>
        public abstract void InitArm();

        public abstract Country GetCountry();
    }
}