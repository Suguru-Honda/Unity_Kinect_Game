using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetButtonDown("Jump"))
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
    }
        
    }

    private void OnCollisionEnter (Collision col)
    {
        //Destroy(col.gameObject);
        if (col.gameObject.name == "Credit(Clone)")
        {
            FindObjectOfType<Score>().AddCreditPoint(4);
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "Meeting(Clone)")
        {
            FindObjectOfType<Score>().AddResearchPoint(10);
            int minute = FindObjectOfType<CountDownTimer>().minute;
            float second = FindObjectOfType<CountDownTimer>().second;

            FindObjectOfType<CountDownTimer>().DecreaseTime(minute, second);

            Destroy(col.gameObject);
        }
        //Destroy(col.gameObject);
    }

}
