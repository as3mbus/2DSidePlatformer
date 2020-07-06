using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float _input = 0;
    [SerializeField]
    private SideMovement _sideMovement;

    // Update is called once per frame
    void Update()
    {
        _input = Input.GetAxis("Horizontal");
        _sideMovement.Move(_input);
    }
}
