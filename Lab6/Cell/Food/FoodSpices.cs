namespace Lab8.Cell.Food
{
    public abstract class FoodSpices : IFood
    {
        protected IFood _food;
        public FoodSpices(IFood food) => _food = food;

        public abstract uint Power { get; }
    }
}
