using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hp = 1;  // ブロックのHP
    // ブロックがヒットした時に表示するマテリアル
    public Material hitMaterial;

    // ブロックのデフォルトのマテリアル
    private Material defaultMaterial;   

    // Start is called before the first frame update
    void Start()
    {
        // ブロックのデフォルトのマテリアルを取得
        defaultMaterial = GetComponent<Renderer>().material;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnCollisionEnterはコライダーに他のオブジェクトが当たった時に呼び出される
    // 引数には当たった他のオブジェクトが入る
    private void OnCollisionEnter(Collision collision)
    {
        // ヒットしたらヒットマテリアルに切り替えて0.1秒後に元に戻す
        StartCoroutine(Grow());

        // ブロックのHPを減らす
        hp--;

        // HPが0以下になったらブロックを削除
        if (hp <= 0)
        {
            Destroy(gameObject);    // ブロックを削除
        }
    }

    // ヒットしたらマテリアルを切り替える
    private IEnumerator Grow()
    {
        // ヒットマテリアルに切替
        GetComponent<Renderer>().material = hitMaterial;
        // 0.1秒待つ
        yield return new WaitForSeconds(0.1f);
        // デフォルトマテリアルに戻す
        GetComponent<Renderer>().material = defaultMaterial;        
    }
}
