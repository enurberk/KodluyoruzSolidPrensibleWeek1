using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceSegregation : MonoBehaviour
{
    public void onClickIButton()
    {
        FlyingFish flyingFish = new FlyingFish();
        flyingFish.Fly();
        flyingFish.Swim();
        Anchovy anchovy = new Anchovy();
        anchovy.Swim();
    }
}

public interface Swimable
{
    void Swim();
}
public interface Flyable
{
    void Fly();
}
public class FlyingFish : Swimable, Flyable
{
    public void Fly()
    {
        Debug.Log("Flying fish can fly.");
    }

    public void Swim()
    {
        Debug.Log("Flying fish can swim.");
    }
}

public class Anchovy : Swimable
{
    public void Swim()
    {
        Debug.Log("Anchovy can swim.");
    }
}