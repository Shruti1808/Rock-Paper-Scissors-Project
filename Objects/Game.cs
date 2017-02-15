using System;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    private string _player1;
    private string _player2;

    public Game(string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;
    }

    public string GetPlayer1()
    {
      return _player1;
    }

    public string GetPlayer2()
    {
      return _player2;
    }

    public string PlayGame()
    {
      string player1 = GetPlayer1();
      string player2 = GetPlayer2();
      if (player1.Equals(player2) )
      {
        return "draw";
      }
      else
      {
        return "oops";
      }
    }
  }

}
