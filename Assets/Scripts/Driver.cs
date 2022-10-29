using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    private float _turnSpeed = 1f;
    private float _moveSpeed = .01f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0f, 0f, _turnSpeed);
        transform.Translate(0f, _moveSpeed, 0f);
    }
}
