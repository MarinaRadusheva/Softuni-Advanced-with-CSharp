
namespace CommandPattern.Models
{
    public class HelloCommand : Command
    {
        public override string Execute(string[] args)
        {   
            return $"Hello, {string.Join(" ",args)}";
        }
    }
}
