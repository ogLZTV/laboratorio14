using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class muerte_enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosion;
    public float velocity;
    Rigidbody2D _ComponentRigidbody;

    void Awake()
    {
        _ComponentRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _ComponentRigidbody.velocity = new Vector2(0, velocity);
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ammo")
        {
            Instantiate(explosion, transform.position,transform.rotation);
        }
        if(collision.gameObject.tag == "player")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            SceneManager.LoadScene("menu");
            
        }
        if (collision.gameObject.tag == "limits")
            {
                Destroy(this.gameObject);
            }
    }
}
