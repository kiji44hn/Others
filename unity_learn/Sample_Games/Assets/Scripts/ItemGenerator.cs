using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] ItemListEntity itemListEntity = default;

    public static ItemGenerator instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public Item Spawn(Item.Type type)
    {
        // itemListの中からtypeと一致したら同じitemを生成して渡す
        foreach (Item item in itemListEntity.itemList)
        {
            if (item.type == type)
            {
                return new Item(item.type, item.sprite, item.zoomObj);
            }
        }
        return null;
    }

    // 生成するズームオブジェクトを返す関数（ZoomPanelスクリプトで使用）
    public GameObject GetZoomItem(Item.Type type)
    {
        foreach (Item item in itemListEntity.itemList) //アイテムリストの数だけ繰り返す
        {
            if (item.type == type) //アイテムリストのタイプと引数のタイプが同じなら
            {
                return item.zoomObj; //そのアイテムのズームオブジェクトを返す
            }
        }
        return null;
    }
}
