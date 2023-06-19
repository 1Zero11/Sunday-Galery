using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageCacher
{
    public static Dictionary<int, Texture2D> keyValuePairs = new Dictionary<int, Texture2D>();

    public bool IsCached(int key)
    {
        return keyValuePairs.ContainsKey(key);
    }

    public Texture2D GetFromCache(int key)
    {
        return keyValuePairs[key];
    }

    public void InsertIntoCache(int key, Texture2D value)
    {
        keyValuePairs[key] = value;
    }
}
