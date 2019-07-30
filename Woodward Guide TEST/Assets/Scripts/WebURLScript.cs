using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebURLScript : MonoBehaviour
{
   
    public void OnMouseDown()
    {
        if (gameObject.name == "VisLab")
        {
            Application.OpenURL("www.viscenter.uncc.edu");
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
