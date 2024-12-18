using UnityEngine;

public class Mover : MonoBehaviour
{
    float xValue = 0.01f;
    float yValue = 0.01f;
    float zValue = 0.01f;


    void Start()
    {
        
    }

    void Update()
    {


        transform.Translate(xValue,yValue,zValue);
    }
}
