using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTransform : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

    }
}
