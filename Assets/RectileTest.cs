using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RectileTest : MonoBehaviour
{
    GameObject cube;
    void Start()
    {
        cube = this.gameObject;
    }
    public void onHowerEnter()
    {
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        
    }
    public void onHowerExit()
    {
        cube.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
