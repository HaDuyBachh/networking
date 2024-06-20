using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class BirdController : MonoBehaviour
{
    // Start is called before the first frame update
    public float flyPowerX;
    public float flyPowerY;
    /// <summary>
    /// public float downSpeed;
    /// </summary>
    Rigidbody rb;
    GameObject obj;
    GameObject gameController;
    private Animator anim;
    int count = 0;
    
    void Start()
    {
        obj = gameObject;
        rb = obj.GetComponent<Rigidbody>();
        flyPowerX = 0;
        flyPowerY = 200f;
        Time.timeScale = 0;
        //if(gameController == null)
        //{
        //    gameController = GameObject.FindGameObjectWithTag("GameController");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = Vector3.down * downSpeed * Time.deltaTime;
        if(count != 0)
        {
           Time.timeScale = 1;
        }
        if (InputDevicesManagement.Instance.isTriggerPressed)
        {
            count = 1;
            obj.GetComponent<Rigidbody>().AddForce(new Vector3( 0,flyPowerY,0));
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        EndGame();
    }
    public void EndGame()
    {
        Time.timeScale = 0;
        count = 0;
    }
}
