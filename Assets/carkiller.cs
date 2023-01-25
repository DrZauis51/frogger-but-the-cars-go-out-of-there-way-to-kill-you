using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class carkiller : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "car") {
            Destroy(other.gameObject);
        }
    }
}

