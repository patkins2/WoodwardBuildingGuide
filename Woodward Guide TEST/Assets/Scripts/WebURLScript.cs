using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebURLScript : MonoBehaviour
{
    //[SerializeField] public Camera camera;

    public void OnMouseDown()
    {
        if (gameObject.name == "VisLab")
        {
            GameObject.Find("Main Camera").transform.position = GameObject.Find("VisLab").transform.position + new Vector3(12, 7, 0);
            GameObject.Find("Main Camera").transform.Rotate(GameObject.Find("VisLab").transform.position, 0.0f); 

            //Application.OpenURL("www.viscenter.uncc.edu");
        }
        else if (gameObject.name =="KDD")
        {
            //Application.OpenURL("www.kdd.uncc.edu");
        }
        else
        {
            Application.OpenURL("www.uncc.edu");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
