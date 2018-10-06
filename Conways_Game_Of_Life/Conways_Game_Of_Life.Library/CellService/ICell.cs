namespace Conways_Game_Of_Life.Library.CellService
{
    public interface ICell
    {
        int Collumn { get; }
        int ID { get; }
        bool IsAlive { get; set; }
        int Row { get; }
    }
}