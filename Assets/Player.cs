using UnityEngine;

public class Player
{
    private string playerName;
    private int health;
    static int maxHealth = 100;
    static int playerCount = 0;
    public void InitializePlayer(string name, int initialHealth) 
    {
        playerName = name;
        if (initialHealth > 100)
        {
            initialHealth = 100;    
        }
        health = initialHealth;
        playerCount++;
    }
    public void Heal(int amount) 
    {
        Debug.Log(playerName + " Previous Health : " + health);
        health += amount;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        Debug.Log("Player " + playerName + " healed by : " + amount + " , Current Health : " + health);
    }
    public void Heal(bool fullRestore) 
    {
        if (fullRestore) 
        {
            health = maxHealth;
            Debug.Log(playerName + " Full Health Restored, Current Health : " + health);
        }
    }
    public static void ShowPlayerCount() 
    {
        Debug.Log("Player Counter : " + playerCount);
    }
}
