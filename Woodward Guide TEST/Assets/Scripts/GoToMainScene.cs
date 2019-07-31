using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToMainScene : MonoBehaviour
{
    
    public void OnMouseClick()
    {
        Application.LoadLevel("building_scene");
    }
}
