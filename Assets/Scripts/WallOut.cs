using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOut : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {
        GameObject.Find("Master").GetComponent<GameMaster>().GameOver("Failed...");
    }

}
