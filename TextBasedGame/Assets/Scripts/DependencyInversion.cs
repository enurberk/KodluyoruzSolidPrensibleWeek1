using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DependencyInversion : MonoBehaviour
{
    public void onClickDButton()
    {
        //IAnimal animal = new Cat();
        IAnimal animal = new Sheep();
        AnimalController animalController = new AnimalController(animal);
        animal.Eat();
        animal.Run();

    }
}
 public interface IAnimal
{
    void Eat();
    void Run();
}
public class Cat : IAnimal
{
    public void Eat()
    {
        Debug.Log("Cat is eating cat food.");
    }

    public void Run()
    {
        Debug.Log("Cat is running.");   
    }
}
public class Sheep : IAnimal
{
    public void Eat()
    {
        Debug.Log("Sheep is eating weed.");
    }

    public void Run()
    {
        Debug.Log("Sheep is running.");
    }
}
public class AnimalController
{
    IAnimal m_animal;
    public AnimalController(IAnimal _animal)
    {
        this.m_animal = _animal;
    }
    public void Eat()
    {
        m_animal.Eat();
    }

    public void Run()
    {
        m_animal.Run();
    }
}