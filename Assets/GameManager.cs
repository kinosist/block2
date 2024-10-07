using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject text;
    private GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Text");
        restartButton = GameObject.Find("RestartButton");

        // ボタンを非表示
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ゲームオーバー処理
    public void GameOver()
    {
        text.GetComponent<Text>().text = "Game Over";

        // ボタンを表示
        restartButton.SetActive(true);
    }

    // リスタート処理
    public void Restart()
    {
        // 現在のシーンを再読み込み
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
