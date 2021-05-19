using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class LightSwitch : MonoBehaviour
{

    public Light light;
    // Start is called before the first frame update
   

    public void Switch()
    {

        light.enabled = false;
        
    }
    public void SwitchOn()
    {
        light.enabled = true;
    }
}
