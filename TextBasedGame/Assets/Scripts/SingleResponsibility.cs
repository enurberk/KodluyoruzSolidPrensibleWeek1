using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleResponsibility : MonoBehaviour
{
    public void onClickSButton()
    {
        Move move = new Move();
        move.FollowEnemy();
    }
}
public class Move
{
    EnemyPosition position = new EnemyPosition();
    Shot shot = new Shot();
    public void FollowEnemy()
    {
        position.FindEnemy("The enemy is being followed..");
        shot.ShotEnemy("The enemy is being shot..");
    }
}

public class Shot
{
    public void ShotEnemy(string y)
    {
        Debug.Log(y);
    }
}

public class EnemyPosition
{
    public void FindEnemy(string x)
    {
        Debug.Log(x);
    }
}