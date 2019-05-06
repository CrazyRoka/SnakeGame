namespace Lab8.Cell.Food
{
    public class Sous : FoodSpices
    {
        public Sous(IFood food) : base(food) { }

        public override uint Power => _food.Power + 5;
    }
}
