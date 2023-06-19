using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button button;

    private void OnEnable()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        DataRetainer.LoadScene = "Gallery";
        SceneManager.LoadSceneAsync("Loading");
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
