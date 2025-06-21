using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPanel : MonoBehaviour
{
    [SerializeField] GameObject panel = default;
    [SerializeField] Transform objParent = default;
    GameObject zoomObj;

    private void Start()
    {
        panel.SetActive(false);
    }

    // アイテムを選択時
    // Zoomボタン押下後、パネルを表示
    public void ShowPanel()
    {
        Item item = ItemBox.instance.GetSelectedItem();
        if (item != null)
        {
            Destroy(zoomObj);
            panel.SetActive(true);
            // アイテムを表示
            // ObjParentにアイテムを生成する
            GameObject zoomObjPrefab = ItemGenerator.instance.GetZoomItem(item.type);
            zoomObj = Instantiate(zoomObjPrefab, objParent);
        }

    }
    // アイテムを表示
    // Closeボタン押下後、パネルを非表示
    public void ClosePanel()
    {
        panel.SetActive(false);
        Destroy(zoomObj);
    }
}
