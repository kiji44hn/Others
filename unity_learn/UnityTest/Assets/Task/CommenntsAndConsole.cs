using System.Collections;　// インポート
using System.Collections.Generic;　// インポート
using UnityEngine;　// インポート

/*
 * コメントとコンソール
 */
public class CommenntsAndConsole : MonoBehaviour
{
    // Start関数はUpdate関数の前に1度だけ実行されるもの
    void Start()
    {
        int x = 100;
        Debug.Log(x);
        string y = "aiu";
        Debug.Log(y);
        x = -1;
        Debug.Log(x);
        y = "1,000";
        Debug.Log(y);

        Debug.Log("ログメッセージ確認");
    }

    // Update関数は、毎フレーム（約0.02秒に1回）実行されるもの
    void Update()
    {
        
    }
}
