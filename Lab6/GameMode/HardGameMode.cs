using Lab8.Cell.Food;

namespace Lab8.GameMode
{
    public class HardGameMode : IGameMode
    {
        public IFood GenerateFood() => new Apple();
    }
}
