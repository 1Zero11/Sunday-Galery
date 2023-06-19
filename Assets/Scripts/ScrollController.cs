using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ScrollController : MonoBehaviour
{
    public GameObject scrollItem;

    private RectTransform scrollRect;

    const int IMAGE_SIZE = 66;

    void Awake()
    {
        
    }

    private void Start()
    {
        for (int i = 1; i <= IMAGE_SIZE; i++)
        {
            var image = Instantiate(scrollItem, transform);
            image.GetComponent<GridItem>().number = i;
            image.GetComponent<RectTransform>().SetAsLastSibling();
        }
        

        scrollRect = GetComponent<RectTransform>();
        scrollRect.anchoredPosition = new Vector2(0, DataRetainer.ScrollPosition);

        LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());

    }
}
