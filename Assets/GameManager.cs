using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();
        player1.InitializePlayer("Abu Saqer", 60);
        player2.InitializePlayer("Abu Hossam", 90);

        player1.Heal(20);
        player2.Heal(true);

        Player.ShowPlayerCount();
    }
}
