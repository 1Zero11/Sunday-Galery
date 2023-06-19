using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public float time = 2f;
    Slider slider;
    
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        slider = GetComponent<Slider>();
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        var timeElapsed = 0f;
        while (timeElapsed < time)
        {
            timeElapsed += Time.deltaTime;
            slider.value = timeElapsed/2f;
            yield return new WaitForEndOfFrame();
        }
        SceneManager.LoadSceneAsync(DataRetainer.LoadScene);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
