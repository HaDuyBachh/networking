using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    // Start is called before the first frame
    public float minY;
    public float maxY;
    public float oldX;
    protected GameObject obj;
    void Start()
    {
        obj = gameObject;
        oldX = -10;
        minY = -3;
        maxY = -0.9f;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Reset"))
        {
            Debug.Log("Reset");
            obj.transform.position = new Vector3(oldX, Random.Range(minY, maxY + 1), 0);
        }
    }
}
