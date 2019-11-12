using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    private float velocity = 0.2f;

    void Update() {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += transform.forward * velocity;
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= transform.forward * velocity;
    }

}
