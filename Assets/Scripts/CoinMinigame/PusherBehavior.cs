using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherBehavior : MonoBehaviour
{
    public float speed = 0.0f;
    public Vector2 movement;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        StartCoroutine(SwitchDirection());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePusher(movement);
    }

    void MovePusher(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

    IEnumerator SwitchDirection() //Move in the desired direction for the desired amount of time indefinetly 
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            movement = movement * -1;
        }
    }
}
