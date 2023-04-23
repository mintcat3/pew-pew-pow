using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelSelector : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OpenScene()
    {

        if (level == SelectionMenu.levelsBeaten + 1)
        {
             SceneManager.LoadScene("Level " + level.ToString());
        }
        else
        {
            SceneManager.LoadScene("Beat Prev Level");
        }
    }
}
