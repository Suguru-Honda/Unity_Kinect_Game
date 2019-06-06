using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject wallPrefab;
    private GameObject[] Text_Objects;
    public float interval;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            transform.position = new Vector3(Random.Range(-1.8f, 1.8f), Random.Range(1f, 2.3f), transform.position.z);
            Instantiate(wallPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);

            int minute = FindObjectOfType<CountDownTimer>().minute;
            float second = FindObjectOfType<CountDownTimer>().second;
            float totalTime = minute * 60 + second;

            if (totalTime < 0)
            {
                /*Text_Objects = GameObject.FindGameObjectsWithTag("Text Object");
                foreach (GameObject Text_Object in Text_Objects)
                {
                    Destroy(Text_Object);
                }*/
                break;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}