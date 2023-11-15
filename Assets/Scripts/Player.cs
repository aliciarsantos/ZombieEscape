using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PiecesByTurn
{
    bool ICanMove = false;

    public override void NowYouCanMove()
    {
        ICanMove = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ICanMove)
        {
            Vector2Int moveToDirection = Vector2Int.zero;

            if (Input.GetKeyDown(KeyCode.UpArrow)){
                moveToDirection.y += 1;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow)){
                moveToDirection.y -= 1;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveToDirection.x-= 1;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveToDirection.x+= 1;
            }
            if(moveToDirection != Vector2Int.zero)
            {
                Vector2 newPos = new Vector2(transform.position.x, transform.position.y);
                newPos += moveToDirection;
                GameObject go = WhatsInThisPosition(newPos);
                if (go == null)
                {
                    transform.position += new Vector3(moveToDirection.x, moveToDirection.y);
                    GameController.Instance.PlayerTurnFinished();
                }
               
            }
        }
       
    }

}
