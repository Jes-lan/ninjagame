using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuscript3 : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }



    public void Quitbutton()
    {
        Application.Quit();
    }
}