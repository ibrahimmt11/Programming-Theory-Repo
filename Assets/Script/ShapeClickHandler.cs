using UnityEngine;

public class ShapeClickHandler : MonoBehaviour
{
    void OnMouseDown()
    {
        Shape shape = GetComponent<Shape>();
        if (shape != null)
        {
            shape.DisplayShapeInfo();
        }
    }
}
