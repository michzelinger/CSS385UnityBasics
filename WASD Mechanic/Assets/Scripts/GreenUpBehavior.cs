using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenUpBehavior : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;
        }
        
        if(Input.GetKey(KeyCode.E))
        {
            pos.y += speed * Time.deltaTime;
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            pos.y += speed * Time.deltaTime;
            pos.x -= speed * Time.deltaTime;
        }

        

        

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            pos.y -= speed * Time.deltaTime;
            pos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.C))
        {
            pos.y -= speed * Time.deltaTime;
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
