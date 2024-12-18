using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;


    private void OnCollisionEnter(Collision other)
    {
        score++;
        Debug.Log($"Objects hit: {score}");
    }
}
