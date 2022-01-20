using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeat : MonoBehaviour
{
  public void start()
    {
        InvokeRepeating("Fire", 5.0f, 5.0f);
    }

    public void Fire()
    {
        GameObject newObject = Instantiate(projectilePrefab, startPoint.position, startPoint.rotation);
        if (newObject.TryGetComponet(out Rigidbody rigidBody))
            ApplyForce(rigidBody);
    }

    public void Repeater()
    {
        InvokeRepeating("fire", Delay, Speed);
    }
}
