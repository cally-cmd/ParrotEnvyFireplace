using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrot : MonoBehaviour
{
    private Rigidbody2D body;

    public float horizontal;
    public float vertical;

    public float limit = 0.7f;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        if (horizontal != 0 && vertical != 0) {
            horizontal *= limit;
            vertical *= limit;
        }

        body.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
