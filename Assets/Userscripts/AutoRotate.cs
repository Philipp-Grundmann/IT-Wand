using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 50, 0); // Rotation in Grad pro Sekunde (x, y, z)

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
