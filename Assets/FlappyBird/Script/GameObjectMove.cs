using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public float moveRange;
    protected Vector3 oldPosition;
    protected GameObject obj;
    void Start()
    {
        obj = gameObject;
        oldPosition = transform.position;
        moveRange = 10;
        moveSpeed = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed,0,0));
        if (Vector3.Distance(oldPosition, obj.transform.position) > moveRange)
        {
            obj.transform.position = oldPosition;
        }
    }
}
