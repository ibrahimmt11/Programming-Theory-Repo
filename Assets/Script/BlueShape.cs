using UnityEngine;

public class BlueShape : Shape
{
    void Start()
    {

        Name = "Capsule";
        Color = "Blue";
    }

    // Polymorphism
    public override void DisplayText()
    {
        Debug.Log("This is a Blue sapsule!");
    }
}
