using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log($"Car bumped into a {other.gameObject.name}!");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
       Debug.Log($"Car entered a {other.name} trigger!"); 
    }
}
