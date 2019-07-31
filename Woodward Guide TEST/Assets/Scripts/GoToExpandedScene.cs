using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToExpandedScene : MonoBehaviour
{
    
    public void OnMouseClick()
    {
        Application.LoadLevel("building_scene_separated");
    }
}
