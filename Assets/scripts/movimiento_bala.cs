using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_bala : MonoBehaviour
{
    Rigidbody2D _componentRigidbody2D;
    public float speed;
    
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

    }
    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(0, speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "limits")
        {
            Destroy(this.gameObject);
        }
    }
}
