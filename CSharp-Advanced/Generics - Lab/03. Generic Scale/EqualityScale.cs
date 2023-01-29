using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T left;
        private T right;
        
        public EqualityScale(T left, T rigth)
        {
            this.left = left;
            this.right = rigth;
        }

        public bool AreEqual()
        {
            return left.Equals(right);
        }
    }
}
