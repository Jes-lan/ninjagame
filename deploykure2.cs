using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class deploykure2 : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject kurePrefab;
    public float respawnTime = 2.0f;
    public Rigidbody rb;
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(kureWave());
       
    }
    private void spawnEnemy()
    {


                GameObject a = Instantiate(kurePrefab) as GameObject;
                a.transform.position = new Vector3(0, 2, -18);
                GameObject b = Instantiate(kurePrefab) as GameObject;
                b.transform.position = new Vector3(0, (float)1, -18);
                GameObject c = Instantiate(kurePrefab) as GameObject;
                c.transform.position = new Vector3(0, 0, -18);

           
       
    }
    IEnumerator kureWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "kure2(Clone)")
        {
            Destroy(gameObject, 3);
        }
    }
}
