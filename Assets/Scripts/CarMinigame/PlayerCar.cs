using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCar : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 5.0f;
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveCar();
    }
    void moveCar()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"),0);
        rb.MovePosition((Vector2)transform.position + (movement * speed * Time.deltaTime));
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "EnemyCar")
        {
            SceneManager.LoadScene("Car Racer Scene"); 
        }
    }
}
