using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShot : MonoBehaviour {

    void Start() {
        transform.eulerAngles = new Vector3(0, Random.Range(60, 120), 0);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
    }

}
