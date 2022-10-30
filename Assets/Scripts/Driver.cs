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
        float turnInput = Input.GetAxis("Horizontal");
        float moveInput = Input.GetAxis("Vertical");
        float turnAmount = turnInput * _turnSpeed * moveInput * Time.deltaTime;
        float moveAmount = moveInput * _moveSpeed * Time.deltaTime;
        transform.Rotate(0f, 0f, -turnAmount);
        transform.Translate(0f, moveAmount, 0f);
    }
}
