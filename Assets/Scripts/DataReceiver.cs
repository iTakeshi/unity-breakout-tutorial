using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataReceiver : MonoBehaviour {

    public Text resultText;

    void Start() {
        resultText.text = DataSender.resultMessage;
    }

}
