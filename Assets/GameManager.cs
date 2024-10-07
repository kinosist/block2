using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Text");        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ゲームオーバー処理
    public void GameOver()
    {
        text.GetComponent<Text>().text = "Game Over";
    }

}
