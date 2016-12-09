using System;
using System.Collections.Generic;
using System.Text;

namespace Sky.Darkness.Commons.Util
{
    public class Set<T>: List<T>
    {
        public void AddItem(T item)
        {
            if (!this.Contains(item))
            {
                this.Add(item);
            }
        }
    }
}
