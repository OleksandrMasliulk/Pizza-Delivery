using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float _turnSpeed = 1f;
    [SerializeField] private float _moveSpeed = .01f;
    [SerializeField] private float _boostSpeed;
    [SerializeField] private float _slowSpeed;

    void Update()
    {
        float turnInput = Input.GetAxis("Horizontal");
        float moveInput = Input.GetAxis("Vertical");
        float turnAmount = turnInput * _turnSpeed * moveInput * Time.deltaTime;
        float moveAmount = moveInput * _moveSpeed * Time.deltaTime;
        transform.Rotate(0f, 0f, -turnAmount);
        transform.Translate(0f, moveAmount, 0f);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Bump")) 
        {
            _moveSpeed = _slowSpeed;
            Debug.Log("Slow down!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Boost"))
        {
            _moveSpeed = _boostSpeed;
            Debug.Log("Speed boost!");
            Destroy(other.gameObject);
        }
    }
}
