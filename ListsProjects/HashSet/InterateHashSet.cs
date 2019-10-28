using System;
using System.Collections.Generic;
using System.Text;

namespace ListsProjects.HashSet
{
    public class InterateHashSet
    {
        public InterateHashSet()
        {
            var hashSet = new HashSet<int>();

            var hashSet2 = new HashSet<int>() {1, 2, 3};

            hashSet.Add (4);
            hashSet.Remove (3);


            hashSet.Clear();

            var contains = hashSet.Contains (1);


            var count = hashSet.Count;

            hashSet.IntersectWith (hashSet2);

            hashSet.ExceptWith (hashSet2);
            

            hashSet.UnionWith (hashSet2);

            var isSupersetOf = hashSet.IsSupersetOf (hashSet2);
            var isSubsetOf = hashSet.IsSubsetOf (hashSet2);
            var equals = hashSet.SetEquals (hashSet2);
        }

    }
}
