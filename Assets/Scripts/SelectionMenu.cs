using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionMenu : MonoBehaviour
{
    public Button[] lvlButtons;
    public static int levelsBeaten = 0;
    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 1);

        for (int i = 0; i < levelsBeaten; i ++)
        {
            if (i + 1 > levelAt)
            {
                lvlButtons[i + 1].interactable = false;
            }
        }
    }

}
