using System.Collections;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.forward * 50 * Time.deltaTime);
    }
}
