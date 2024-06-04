using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovie : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    float horizontal;
    float vertical;
    public float speed;
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        horizontal=Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        _rigidbody2D.velocity = new Vector2(horizontal * speed , vertical * speed);
    }
}
