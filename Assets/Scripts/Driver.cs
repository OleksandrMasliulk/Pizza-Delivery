using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float _turnSpeed = 1f;
    [SerializeField] private float _moveSpeed = .01f;

    void Start()
    {
        
    }

    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * _turnSpeed;
        float moveAmount = Input.GetAxis("Vertical") * _moveSpeed;
        transform.Rotate(0f, 0f, -turnAmount);
        transform.Translate(0f, moveAmount, 0f);
    }
}
