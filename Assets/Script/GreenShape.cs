using UnityEngine;

public class GreenShape : Shape
{
    void Start()
    {
        Name = "Sphere";
        Color = "Green";
    }

    // Polymorphism
    public override void DisplayText()
    {
        Debug.Log("This is a Green sphere!");
    }
}
