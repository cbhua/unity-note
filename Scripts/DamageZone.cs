using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    // Only the first frame will call this function
    void OnTriggerStay2D(Collider2D other) {
        RubyController controller = other.GetComponent<RubyController>();

        if((controller != null) && (controller.health > 0)) {
            controller.ChangeHealth(-1);
        }
    }
}
