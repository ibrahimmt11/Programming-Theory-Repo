using UnityEngine;

public class RedShape : Shape
{
    void Start()
    {
        Name = "Cube";
        Color = "Red";
    }

    // Polymorphism
    public override void DisplayText()
    {
        Debug.Log("This is a Red cube!");
    }
}
