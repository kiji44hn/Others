using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclarationAndAssignment : MonoBehaviour
{
    // Start関数はUpdate関数の前に1度だけ実行されるもの
    void Start()
    {
        string s; // 宣言
        s = "変数"; // 代入
        string needName = "Dog"; // 宣言と代入

        Debug.Log(s);
        Debug.Log(needName);
    }
}
