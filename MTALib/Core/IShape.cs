namespace MTALib.Core
{
    internal interface IShape
    {
        public string Name { get; set; }
        public double GetArea();
    }
}