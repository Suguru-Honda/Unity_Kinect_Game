using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    private float totalTime;
    public int minute;
    public float second;
    public float decreaseTime; // when player get meeting target.
    public Text timerText;
    public GameObject EndText;
    private GameObject[] Text_Objects;
    private float oldSecond;

    void Start()
    {
        totalTime = minute * 60 + second;
        oldSecond = 0f;
        EndText.SetActive(false);
    }

    void Update()
    {

        totalTime -= Time.deltaTime;

        minute = (int)totalTime / 60;
        second = totalTime - minute * 60;

        Debug.Log("toal : " + totalTime);

        if ((int)second != (int)oldSecond)
        {
            timerText.text = minute.ToString("00") + ":" + second.ToString("00");
            oldSecond = second;
        }
        if (totalTime < 0)
        {
            timerText.text = "00:00";

            Text_Objects = GameObject.FindGameObjectsWithTag("Text Object");
            foreach (GameObject Text_Object in Text_Objects)
            {
                Destroy(Text_Object);
            }

            EndText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //EndText.SetActive(false);
                Destroy(EndText.gameObject);
                FindObjectOfType<ShowResult>().showResult();
            }
        }
    }

    public void DecreaseTime(int min, float sec)
    {
        
        totalTime = minute * 60 + second - decreaseTime;
        Debug.Log("decrease time : "+totalTime);
        ParticleSystem timeParticle = FindObjectOfType<Score>().timeParticle;
        timeParticle.Emit(1);
    }
}