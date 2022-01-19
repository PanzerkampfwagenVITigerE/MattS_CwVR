using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeat : MonoBehaviour
{
  public void start()
    {
        InvokeRepeating("Launch", 5.0f, 5.0f);
    }

    public void Launch()
    {

    }
}
