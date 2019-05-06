namespace Lab7.Cell.Food
{
    public class Ketchup : FoodSpices
    {
        public Ketchup(IFood food) : base(food) { }

        public override uint Power => _food.Power + 3;
    }
}
