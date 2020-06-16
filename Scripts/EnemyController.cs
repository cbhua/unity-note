using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;
    public float changeTimer = 3.0f;
    
    float timer;
    int direction = 1;

    Rigidbody2D rigidbody2D;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTimer;
    }

    void Update() {
        timer -= Time.deltaTime;
        if (timer < 0) {
            direction = -direction;
            timer = changeTimer;
        }
    }

    void FixedUpdate() {
        Vector2 position = rigidbody2D.position;

        if (vertical) {
            position.x = position.x + Time.deltaTime * speed * direction;
        }
        else {
            position.y = position.y + Time.deltaTime * speed * direction;
        }

        rigidbody2D.MovePosition(position);
    }

    void OnCollisionEnter2D(Collision2D other) {
        RubyController player = other.gameObject.GetComponent<RubyController>();
        if(player != null) {
            player.ChangeHealth(-1);
        }
    }
}
