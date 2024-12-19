using UnityEngine;

//Collision handler for objects that fly at the player.
public class FlyAtPlayerCollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!transform.parent.TryGetComponent<FlyAtPlayer>(out FlyAtPlayer flyAtPlayer))
            {
                Debug.Log($"Missing script on parent game object {transform.parent}");
                return;
            }
            flyAtPlayer.MoveTowardsObject(other.gameObject.transform.position);
        }
    }
}
