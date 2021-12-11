using ReactiveUI_MemoryLeakTest_Wpf.Models;

namespace ReactiveUI_MemoryLeakTest_Wpf.ViewModels
{
    public class TestViewModel
    {
        public TestModel TestModel { get; set; }

        public TestViewModel(TestModel testModel)
        {
            TestModel = testModel;
        }
    }
}
