using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : PiecesByTurn
{
    public override void NowYouCanMove()
    {
        Vector3 playerPos = GameController.Instance.playerRef.transform.position;
        Vector3 ourPosition = transform.position;
        Vector3 difference = playerPos - ourPosition;
        if (Mathf.Abs(difference.x) > Mathf.Abs(difference.y))
        {
            Vector2 newDirection = new Vector2(Mathf.Clamp(difference.x,-1,1), 0);
        }
        else
        {
            Vector2 newDirection = new Vector2(Mathf.Clamp(difference.y, -1, 1), 0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
