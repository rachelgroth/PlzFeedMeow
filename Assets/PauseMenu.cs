using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    GameObject[] pauseObjects;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("pauseObjects");
        hidePaused();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("escape"))
        {
            if(Time.timeScale ==1)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else if(Time.timeScale == 0)
            {
                Debug.Log("back to the game");
                Time.timeScale = 1;
                hidePaused();

            }
        }
    }
    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

}
