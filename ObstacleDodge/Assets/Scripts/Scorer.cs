using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<ObjectHit>(out ObjectHit objectHit))
        {
            if (objectHit.IsHit) { return; }

            score++;
            Debug.Log($"Objects hit: {score}");
        }
    }
}
