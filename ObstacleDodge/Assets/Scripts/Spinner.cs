using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]
    [Range(-360f,360f)]
    float rotateSpeed;

    void Update()
    {
        transform.Rotate(0,rotateSpeed * Time.deltaTime,0);
    }
}
