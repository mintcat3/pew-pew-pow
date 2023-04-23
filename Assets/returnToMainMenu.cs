using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToMainMenu : MonoBehaviour
{
    void Start()
    {

    }
    public void Return()
    {
        SceneManager.LoadScene("Level Selection Menu");
    }
}
