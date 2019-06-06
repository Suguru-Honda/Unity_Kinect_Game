using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChange : MonoBehaviour
{

    public GameObject messageText;  
    private string[] class_name = new string[29] { "情報理工学序論", "情報生命科学序論", "科学哲学", "コンピュータグラフィックス", "信号検出理論", "ロボティクス", "情報理論", "確率過程論", "データ工学基礎", "高性能計算基盤", "バーチャルリアリティ", "データ解析", "コロキアムA", "知的財産権", "ユビキタスシステム", "メディア情報処理", "信号処理論", "パターン認識","ソフトウェア設計論","環境知能","光学", "技術と倫理","応用解析学","機械学習概論","形式言語理論","ソフトウェア工学","自然言語処理","コンピュータビジョン",""};
    public BoxCollider text_Collider;
    private int num;

    // Start is called before the first frame update
    void Start()
    {
        num = (int)Random.Range(0f, 29f);
        //num = 2;
        messageText.GetComponent<TextMesh>().text = class_name[num];

        gameObject.GetComponent<TextMesh>().color = Color.black;


        text_Collider = GetComponent<BoxCollider>();
        text_Collider.size = new Vector3((float)0.3 * class_name[num].Length, (float)0.4, 1);
        text_Collider.center = new Vector3(text_Collider.size.x /2, (float)-0.2, 0);

        Debug.Log(text_Collider.size);
        Debug.Log(text_Collider.center);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
