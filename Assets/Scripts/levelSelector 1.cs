using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelSelector : MonoBehaviour
{
    public static int level = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {

    }
    
    public void OpenScene()
    {

        if (level <= SelectionMenu.levelsBeaten + 1)
        {
             SceneManager.LoadScene("Level 1");
        }
        else
        {
            SceneManager.LoadScene("Beat Prev Level");
        }
    }
}
