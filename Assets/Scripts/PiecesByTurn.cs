using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PiecesByTurn: MonoBehaviour
{
    public abstract void NowYouCanMove();

    public GameObject WhatsInThisPosition(Vector2 pos)
    {
        Collider2D col= Physics2D.OverlapPoint(pos);
        if(col == null)
        {
            return null;
        }else return col.gameObject;
    }
}
