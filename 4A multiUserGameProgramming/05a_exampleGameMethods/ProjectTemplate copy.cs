// Isaiah Reyes, Final Try, v0.3
using System;

class TurnBasedBattleGame
{
    // Game Variables
    int playerHealth = 100;
    float enemyHealth = 100.0f;
    string playerName = "Hero";
    bool isPlayerTurn = true;
    int[] damageValues = { 10, 20, 30 };
    int healAmount = 20;
    int difficultyLevel;  // 1 for Easy, 2 for Hard

    static void Main(string[] args)
    {
        TurnBasedBattleGame game = new TurnBasedBattleGame();
        game.SetupGame();
        game.StartGame();
    }

    // Setup game with difficulty level
    void SetupGame()
    {
        Console.WriteLine("Choose difficulty: \n1. Easy \n2. Hard");
        difficultyLevel = int.Parse(Console.ReadLine());
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
                if (difficultyLevel == 2) // Hard difficulty gets an extra turn
                {
                    EnemyTurn();
                }
            }

            isPlayerTurn = !isPlayerTurn;
        }

        EndGame();
    }

    // Handles the player's turn
    void PlayerTurn()
    {
        Console.WriteLine("Choose an action: \n1. Attack \n2. Heal \n3. Fireball \n4. Freeze \n5. Lightning Strike");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": // Attack
                AttackEnemy();
                break;
            case "2": // Heal
                HealPlayer();
                break;
            case "3": // Fireball
                CastSpell("Fireball", 30);
                break;
            case "4": // Freeze
                CastSpell("Freeze", 20);
                break;
            case "5": // Lightning Strike
                CastSpell("Lightning Strike", 40);
                break;
        }
    }

    // Attack Enemy
    void AttackEnemy()
    {
        int damage = CalculateDamage();
        enemyHealth -= damage;
        Console.WriteLine($"You attacked the enemy for {damage} damage!");
    }

    // Heal Player
    void HealPlayer()
    {
        playerHealth = Math.Min(playerHealth + healAmount, 100);
        Console.WriteLine($"You healed for {healAmount} health!");
    }

    // Cast a spell
    void CastSpell(string spellName, int spellDamage)
    {
        enemyHealth -= spellDamage;
        Console.WriteLine($"You cast {spellName}, dealing {spellDamage} damage to the enemy!");
    }

    // Handles the enemy's turn
    void EnemyTurn()
    {
        int action = new Random().Next(0, difficultyLevel == 1 ? 2 : 3); // More healing on hard difficulty
        if (action == 0)
        {
            int damage = CalculateDamage();
            playerHealth -= damage;
            Console.WriteLine($"Enemy attacked you for {damage} damage!");
        }
        else
        {
            float heal = difficultyLevel == 1 ? 10.0f : 20.0f; // Enemy heals more on hard difficulty
            enemyHealth = Math.Min(enemyHealth + heal, 100.0f);
            Console.WriteLine($"Enemy healed itself for {heal} health!");
        }
    }

    // Calculate damage
    int CalculateDamage(int baseDamage = 10)
    {
        int randomIndex = new Random().Next(0, damageValues.Length);
        return baseDamage + damageValues[randomIndex];
    }

    // End the game
    void EndGame()
    {
        if (playerHealth <= 0)
        {
            Console.WriteLine("You lost!");
        }
        else
        {
            Console.WriteLine("You won!");
        }
    }
}
