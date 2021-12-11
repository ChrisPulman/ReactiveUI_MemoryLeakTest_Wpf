using System;

namespace ReactiveUI_MemoryLeakTest_Wpf.Models
{
    public class TestModel
    {
        public TestModel(int id, string name, TimeSpan duration)
        {
            Id = id;
            Name = name;
            Duration = duration;
        }

        public int Id { get; set; }
     
        public string Name { get; set; }
        
        public TimeSpan Duration { get; set; }
    }
}
