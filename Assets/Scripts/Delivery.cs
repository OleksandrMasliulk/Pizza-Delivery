using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool _hasPizza = false;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log($"Car bumped into a {other.gameObject.name}!");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Pizza") && !_hasPizza)
        {
            Debug.Log("Pizza picked up!");
            _hasPizza = true;
        }
        
        if (other.CompareTag("Customer") && _hasPizza)
        {
            Debug.Log("Pizza delivered!");
            _hasPizza = false;
        }
    }
}
