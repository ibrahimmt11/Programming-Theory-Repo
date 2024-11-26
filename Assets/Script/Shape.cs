using UnityEngine;

public class Shape : MonoBehaviour
{
    // Encapsulation
    private string _name;
    private string _color;

    // Properties with getters and setters for encapsulation
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
    public virtual void DisplayText()
    {
        Debug.Log("Displaying a shape!");
    }

    // abstraction
    public void DisplayShapeInfo()
    {
        Debug.Log($"Shape: {Name}, Color: {Color}");
        DisplayText();
    }
}
