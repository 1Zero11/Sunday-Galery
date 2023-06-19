using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ViewImage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (DataRetainer.imageToView != null)
        {
            GetComponent<RawImage>().texture = DataRetainer.imageToView;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
