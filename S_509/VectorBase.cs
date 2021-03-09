using System;

namespace S_509
{
    // 抽象クラス
    abstract class VectorBase
    {
        // 抽象プロパティー
        public abstract double X
        {
          set;
          get;
        }
        public abstract double Y
        {
          set;
          get;
        }
    }
}
