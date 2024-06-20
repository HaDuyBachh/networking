using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    // Start is called before the first frame update
    float maxP;
    GameObject obj;
    void Start()
    {
        obj = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        maxP = Random.Range(1f, 5f);
        obj.GetComponent<Rigidbody>().AddForce(0, maxP*Time.deltaTime, 0);
    }
}
