using Shapes.Contracts;
namespace Shapes.Models
{
    public abstract class Shape : IDrawable
    {
        public IDrawer Drawer => new ConsoleDrawer();

        public abstract void Draw();
    }
}
