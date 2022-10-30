using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;

    void LateUpdate()
    {
        transform.position = _target.position + _offset;
    }
}
