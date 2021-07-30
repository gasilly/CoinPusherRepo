using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarBehavior : MonoBehaviour
{
    public float speed = 0.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveEnemyCar();
    }

    void MoveEnemyCar()
    {
        rb.MovePosition((Vector2)transform.position + new Vector2(0,-1 * speed * Time.deltaTime));
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
