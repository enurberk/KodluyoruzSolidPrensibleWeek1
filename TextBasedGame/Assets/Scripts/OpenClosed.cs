using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosed : MonoBehaviour
{ 
    public void onClickOButton()
    {
        Tank tank = new Tank();
        tank.LandType();

        Ship ship = new Ship();
        ship.LandType();

        Plane plane = new Plane();
        plane.LandType();
    }
}

public interface Vehicles
{
    void LandType();
}

public class Tank : Vehicles
{
    public void LandType()
    {
        Debug.Log("Tank is a land vehicle. ");
    }
}

public class Ship : Vehicles
{
    public void LandType()
    {
        Debug.Log("Ship is a sea vehicle. ");
    }
}

public class Plane : Vehicles
{
    public void LandType()
    {
        Debug.Log("Plane is a air vehicle. ");
    }
}