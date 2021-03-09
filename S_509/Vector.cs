using System;

namespace S_509
{
    class Vector : VectorBase
    {
        private double x = 0.0;
        private double y = 0.0;
        // プロパティー
        public override double X
        {
          set { x = value; }
          get { return x; }
        }
        public override double Y
        {
          set { y = value; }
          get { return y; }
        }
    }
}
