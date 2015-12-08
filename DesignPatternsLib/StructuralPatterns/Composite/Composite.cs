using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Composite
{
    public class Composite : Component, IEnumerable<Component>
    {
        public override string Operation()
        {
            return children.Count.ToString();
        }

        private List<Component> children = new List<Component>();

        public void AddChild(Component component)
        {
            children.Add(component);
        }
        public void RemoveChild(Component component)
        {
            if(children.Contains(component))
            children.Remove(component);
        }
        public Component GetChild(int i)
        {
            if(i<0 || i >= children.Count)
                return null;
            return children[i];
        }

        public IEnumerator<Component> GetEnumerator()
        {
            foreach (var child in children)
            {
                yield return child;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
