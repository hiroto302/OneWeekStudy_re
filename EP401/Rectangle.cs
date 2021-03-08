using System;

namespace EP401
{  class Rectangle
  {
    // フィールド 幅・高さ
    public double width = 0;
    public double height = 0;
    // メソッド
    // 面積の取得
    public double GetArea()
    {
      return width * height;
    }
    // 周の長さ
    public double GetPerimeter()
    {
      return (width + height) * 2;
    }
  }
}