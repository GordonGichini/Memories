using Memories.Shared;
using System;
using System.Collections.Generic;

namespace Memories.Services
{
    public class MemoryService : IMemoryService
    {

        private List<Memory> memories = new List<Memory>();

        public List<Memory> GetMemories() => memories;

        public Memory GetMemoryById(int id) => memories.FirstOrDefault(m => m.Id == id);

        public void AddMemory(Memory memory)
        {
            memory.Id = memories.Count + 1;
            memories.Add(memory);
        }

        public void UpdateMemory(int id, Memory memory)
        {
            var existingMemory = GetMemoryById(id);
            if (existingMemory != null)
            {
                existingMemory.Name = memory.Name;
                existingMemory.Description = memory.Description;
                existingMemory.Date = memory.Date;
                existingMemory.Location = memory.Location;
            }
        }

        public void DeleteMemory(int id)
        {
            var memory = GetMemoryById(id);
            if (memory != null)
            {
                memories.Remove(memory);
            }
        }
    }

}
