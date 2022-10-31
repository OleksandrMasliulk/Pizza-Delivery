using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log($"Car bumped into a {other.gameObject.name}!");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Pizza"))
        {
            Debug.Log("Pizza picked up!");
        }
        else if (other.CompareTag("Customer"))
        {
            Debug.Log("Delivered pizza!");
        }
    }
}
