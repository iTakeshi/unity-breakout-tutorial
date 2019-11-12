using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    public int nBlocks;
    public float time;

    void Start () {
        nBlocks = 8 * 5;
        time = 0;
    }

    void Update() {
        time += Time.deltaTime;
        if (nBlocks <= 0) GameOver($"Clear!! ({time.ToString("F0")} sec.)");
    }

    public void GameOver(string message) {
        DataSender.resultMessage = message;
        SceneManager.LoadScene("Result");
    }

}
