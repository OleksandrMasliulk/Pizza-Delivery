using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Delivery : MonoBehaviour
{
    private bool _hasPizza = false;
    [SerializeField] private float _destroyPizzaDelay;

    [SerializeField] private Color32 _defaultColor;
    [SerializeField] private Color32 _hasPizzaColor;

    private SpriteRenderer _spriteRenderer;

    private void Awake() 
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start() 
    {
        _spriteRenderer.color = _defaultColor;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Pizza") && !_hasPizza)
        {
            Debug.Log("Pizza picked up!");
            _hasPizza = true;
            _spriteRenderer.color = _hasPizzaColor;
            Destroy(other.gameObject, _destroyPizzaDelay);
        }

        if (other.CompareTag("Customer") && _hasPizza)
        {
            Debug.Log("Pizza delivered!");
            _spriteRenderer.color = _defaultColor;
            _hasPizza = false;
        }
    }
}
