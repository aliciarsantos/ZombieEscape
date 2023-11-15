using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    public Player playerRef;
    public List<Enemy> enemies;
    void Start()
    {
        playerRef.NowYouCanMove();
    }

    public void PlayerTurnFinished()
    {
        StartCoroutine(EnemiesTurn());
    }
    IEnumerator EnemiesTurn()
    {
        foreach(Enemy currentEnemy in enemies)
        {
            yield return new WaitForSeconds(0.5f);
            currentEnemy.NowYouCanMove();
        }
        playerRef.NowYouCanMove();
    }
}
