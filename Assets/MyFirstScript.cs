using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    [SerializeField]
    public int frameNum;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I was told to start: " +  this.gameObject.name);


       frameNum = 1;
    }

    // Update is called once per frame
    void Update()
    {

       // Debug.LogFormat("FrameDebug#{0} : Update at Time: {1}", framenum, Time.time);
        Debug.Log("Frame" + frameNum + "Update at Time:" + Time.time);
        frameNum = frameNum + 1;

    }
}
