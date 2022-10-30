using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log($"Car bumped into a {other.gameObject.name}!");
    }
}
