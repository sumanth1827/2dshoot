using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0f, -3.4f); 
    }
    private void OnTriggerEnter2D(Collider2D ci)
    {
        if(ci.tag == "Player" && ci.GetType() == typeof(CapsuleCollider2D))
        {
            ci.GetComponent<health>().damage();
            ci.GetComponent<health>().healths -= 1;
        }
        if(ci.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
