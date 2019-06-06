using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShader : MonoBehaviour
{

    private Renderer rend;
    private Shader ad;
    public Material mat;
    Renderer m_Renderer;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().material = mat;
    }

    // Update is called once per frame
    void Update()
    {
        //this.GetComponent<Renderer>().material = mat;
    }
}