using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cearenemigo : MonoBehaviour
{
    public GameObject Prefap;
    public float counter;
    public float limit;
    public float maxvalue;
    public float minvalue;
    // Start is called before the first frame update
    void awake()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > limit)
        {
            float rango = Random.Range(minvalue, maxvalue);
            Instantiate(Prefap, new Vector2(rango,transform.position.y),transform.rotation);
            counter = 0;
        }
        counter = counter + Time.deltaTime;
    }
}
