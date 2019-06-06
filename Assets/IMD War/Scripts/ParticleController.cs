using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        Vector3 position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
        transform.position = position;
    }
}
