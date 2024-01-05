using Memories.Shared;

namespace Memories.Services
{
    public interface IMemoryService
    {
 
        List<Memory> GetMemories();
        Memory GetMemoryById(int id);
        void AddMemory(Memory memory);
        void UpdateMemory(int id, Memory memory);
        void DeleteMemory(int id);
    }
}
