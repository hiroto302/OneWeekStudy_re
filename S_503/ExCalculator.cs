using System;

namespace S_503
{
  // Calculatorクラスを継承
  class ExCalculator : Calculator
  {
    // 掛け算
    public void Mul()
    {
      Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
    }
    // 割り算
    public void Div()
    {
      Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
    }
  }
}