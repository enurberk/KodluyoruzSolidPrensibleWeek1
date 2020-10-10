using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiskovSubstitution : MonoBehaviour
{
    public void onClickLButton()
    {
        Player player = new Player1();
        player.GetPlayer();
        player = new Player2();
        player.GetPlayer();
    }
}

public abstract class Player
{
    public abstract void GetPlayer();
}

public class Player1 : Player
{
    public override void GetPlayer()
    {
        Debug.Log("Player1");
    }
}

public class Player2 : Player1
{
    public override void GetPlayer()
    {
        Debug.Log("Player2");
    }
}