using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenScene()
    {
        takesCareOfLevelIDK.buttonPressed = 2;
        SceneManager.LoadScene("Level 1");
    }
}
