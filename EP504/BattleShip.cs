using System;

namespace EP504
{
  class BattleShip : Ship
  {
    //　船の種類
    private string type = "戦闘船";
    // プロパティー
    public override string Type
    {
      set {type = value; }
      get {return type; }
    }
    // 戦闘メソッド
    public void Battle()
    {
      Console.WriteLine("戦闘する");
    }
  }
}