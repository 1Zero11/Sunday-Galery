using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GridItem : MonoBehaviour, IPointerClickHandler
{
    public int number;

    public void OnPointerClick(PointerEventData eventData)
    {
        DataRetainer.imageToView = (Texture2D)GetComponent<RawImage>().texture;

        var scrollRect = transform.parent.GetComponent<RectTransform>();

        DataRetainer.ScrollPosition = scrollRect.anchoredPosition.y;
        SceneManager.LoadSceneAsync("View");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
