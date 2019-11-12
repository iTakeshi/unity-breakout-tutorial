using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    public GameObject master;

    void OnCollisionEnter(Collision collision) {
        master.GetComponent<GameMaster>().nBlocks--;
        Destroy(gameObject);
    }

}
