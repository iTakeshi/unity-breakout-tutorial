using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInit : MonoBehaviour {

    public GameObject blockObjPrefab;
    public GameObject blocksObj;

    void Awake() {
        GameObject master = GameObject.Find("Master");
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 5; y++) {
                GameObject go = Instantiate(blockObjPrefab, blocksObj.transform);
                go.transform.position = new Vector3(-2f - 1f * y, 0.4f, -4.2f + 1.2f * x);
                go.GetComponent<Destroyer>().master = master;
            }
        }
    }

}
