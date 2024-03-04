using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public Rigidbody2D hand;
    public float force = 3f;

    // Start is called before the first frame update
    void Start()
    {
        hand = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Move();

        
    }


    void Move()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            hand.AddForce(Vector3.up * force, ForceMode2D.Impulse);
        }
    }
    
}
