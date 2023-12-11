// Isaiah Reyes, Final Try, v0.1
using System;

class TurnBasedBattleGame
{
    // Game Variables
    int playerHealth = 100;              // Integer variable for player health
    float enemyHealth = 100.0f;          // Float variable for enemy health
    string playerName = "Hero";          // String variable for player name
    bool isPlayerTurn = true;            // Boolean variable to check if it's player's turn
    int[] damageValues = { 10, 20, 30 }; // Array variable for damage values

    static void Main(string[] args)
    {
        TurnBasedBattleGame game = new TurnBasedBattleGame();
        game.StartGame();
    }

}
