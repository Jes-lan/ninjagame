using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.SceneManagement;
public class canbar1 : MonoBehaviour
{
    public GameObject canbar;
    public float can;
    public float hak = 4.0f;
    public Hareket hareket;
    void Start()
    {
        can = 100.0f;
    }

    void Update()
    {
        if (hak == 0)
        {
            hareket.enabled = false;
            SceneManager.LoadScene(2);
        }
        canbar.transform.localScale = new Vector3(can / 100, 1, 1);
        if (can >= 100)
        {
            can = 100.0f;
        }
        else if (can <= 0)
        {
            can = 0f;
        }


    }
    private void OnCollisionEnter(Collision collision) //E�er s�rekli platforma de�iyorsa
    {
        if (collision.gameObject.tag == "Player") //e�er platform etiketli nesneye de�erse
        {

            canbar.transform.Translate(new Vector3(-1000f * Time.deltaTime, 0, 0));
            hak--;


        }

    }
}
