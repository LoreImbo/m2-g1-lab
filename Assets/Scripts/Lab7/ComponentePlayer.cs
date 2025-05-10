using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentePlayer : MonoBehaviour
{
    public int incremento;
    Player player1 = new Player();
    Enemy enemy1 = new();
    // Start is called before the first frame update
    void Start()
    {
        player1.nome = "Super Mario";
        player1.SetPunteggio(80);
        player1.SetDanno(3);

        Player player2 = new Player();
        player2.nome = "Luigi";
        player2.SetPunteggio(90);

        Debug.Log($"Player1 si chiama {player1.nome} e ha un punteggio di {player1.GetPunteggio()}");
        Debug.Log($"Player2 si chiama {player2.nome} e ha un punteggio di {player2.GetPunteggio()}");

        player1.IncrementaPunteggio(incremento);
        Debug.Log($"L'incremento del punteggio di {player1.nome} è {incremento} e ora ha un punteggio di {player1.GetPunteggio()}");

        if (player1.IsVincitore())
            Debug.Log($"Il player {player1.nome} ha vinto con un punteggio di {player1.GetPunteggio()}");

  
        enemy1.nome = "Bowser";
        enemy1.salute = 10;
        enemy1.livello = 1;

        InterazioneDannoSalute(player:player1, enemy:enemy1);
        
    }

    public void InterazioneDannoSalute(Player player, Enemy enemy)
    {
        Debug.Log($"Il nemico di nome {enemy.nome} ha {enemy.salute} salute rimanente");
        while (enemy.salute > 0)
        {
            enemy.SubisciDanno(player.GetDanno());
            Debug.Log($"Il nemico di nome {enemy.nome} ha {enemy.salute} salute rimanente");
        }
        Debug.Log($"Il nemico di nome {enemy.nome} è morto perché ha {enemy.salute} salute rimanente");
    }

    // Update is called once per frame
    void Update()
    {
        enemy1.SubisciDanno(player1.GetDanno());
    }
}
