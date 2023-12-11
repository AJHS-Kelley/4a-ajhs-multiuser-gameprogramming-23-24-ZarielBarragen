// Isaiah Reyes, Final Try, v0.3
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

    // Starts the game
    void StartGame()
    {
        Console.WriteLine("Turn-Based Battle Game!");
        while (playerHealth > 0 && enemyHealth > 0)
        {
            if (isPlayerTurn)
            {
                PlayerTurn();
            }
            else
            {
                EnemyTurn();
            }

            isPlayerTurn = !isPlayerTurn; // Switch turns
        }

        EndGame();
    }

    // Handles the player's turn
    void PlayerTurn()
    {
        Console.WriteLine("Choose an action: \n1. Attack \n2. Heal");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            // Attack
            int damage = CalculateDamage();
            enemyHealth -= damage;
            Console.WriteLine($"You attacked the enemy for {damage} damage!");
        }
        else if (choice == "2")
        {
            // Heal
            playerHealth = Math.Min(playerHealth + healAmount, 100); // Ensure health does not exceed 100
            Console.WriteLine($"You healed for {healAmount} health!");
        }
    }

    // Handles the enemy's turn
    void EnemyTurn()
    {
        int action = new Random().Next(0, 2);
        if (action == 0)
        {
            int damage = CalculateDamage();
            playerHealth -= damage;
            Console.WriteLine($"Enemy attacked you for {damage} damage!");
        }
        else
        {
            // Enemy heals itself
            float heal = 10.0f;
            enemyHealth = Math.Min(enemyHealth + heal, 100.0f);
            Console.WriteLine($"Enemy healed itself for {heal} health!");
        }
    }
}    