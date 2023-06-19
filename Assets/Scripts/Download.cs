using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Download : MonoBehaviour
{
    // Start is called before the first frame update
    RawImage image;
    RectTransform rect;
    bool downloaded;

    void Start()
    {
        image = GetComponent<RawImage>();
        rect = GetComponent<RectTransform>();
    }

    IEnumerator DownloadImage(string MediaUrl)
    {
        Debug.Log("Downloading " + MediaUrl);
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
            Debug.Log(request.error);
        else
        {
            ImageCacher cacher = new ImageCacher();
            image.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
            cacher.InsertIntoCache(GetComponent<GridItem>().number, (Texture2D)image.texture);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!downloaded && rect.IsVisibleFrom(Camera.main))
        {
            ImageCacher cacher = new ImageCacher();
            var number = GetComponent<GridItem>().number;
            if (cacher.IsCached(number))
            {
                image.texture = cacher.GetFromCache(number);
                downloaded = true;
                return;
            }

            StartCoroutine(DownloadImage($"http://data.ikppbb.com/test-task-unity-data/pics/{number}.jpg"));
            downloaded = true;
        }
    }
}
