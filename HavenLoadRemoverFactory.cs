using System;
using LiveSplit.Model;
using LiveSplit.UI.Components;

[assembly: ComponentFactory(typeof(HavenLoadRemoverFactory))]
namespace LiveSplit.UI.Components
{
    public class HavenLoadRemoverFactory : IComponentFactory
    {
        public string ComponentName => "HCOTK Load Remover";
        public string Description => "Removes loads and auto-splits when running Haven: Call of the King.";
        public ComponentCategory Category => ComponentCategory.Control;
        public string UpdateName => ComponentName;
        public string XMLURL => "";
        public string UpdateURL => "";
        public Version Version => Version.Parse("1.0.0");
        
        public IComponent Create(LiveSplitState state)
        {
            return new HavenLoadRemoverComponent(state);
        }
    }
}