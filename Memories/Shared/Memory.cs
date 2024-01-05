namespace Memories.Shared
{
    public class Memory
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int Id { get; internal set; }
    }
}
