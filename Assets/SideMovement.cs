using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMovement : MonoBehaviour
{
    private float _input;
    [SerializeField]
    private float _speed = 1;
    public void Move(float value)
    {
        _input = value;
    }
    private void FixedUpdate()
    {
        transform.position += Vector3.right * _input * Time.deltaTime * _speed;
    }
}
