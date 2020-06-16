using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    // Only the first frame will call this function
    void OnTriggerEnter2D(Collider2D other) {
        RubyController controller = other.GetComponent<RubyController>();

        if((controller != null) && (controller.health < controller.maxHealth)) {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}
