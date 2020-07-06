using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceJump : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidBody;
    [SerializeField]
    private float _force;
    [SerializeField]
    private ForceMode2D _forceMode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;
        _rigidBody.AddForce(Vector2.up * _force,_forceMode);
    }
}
