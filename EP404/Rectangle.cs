using System;

namespace EP404
{  class Rectangle
  {
    // フィールド 幅・高さ
    private double width = 0;
    private double height = 0;

    // プロパティー
    public double Width
    {
      set { width = value;}
      get { return width;}
    }
    public double Height
    {
      set { height = value;}
      get { return height;}
    }
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