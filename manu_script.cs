using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class manu_script : MonoBehaviour
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