using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjReset : MonoBehaviour
{
    public GameObject[] objs;
    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject temp in objs)
        {
            temp.transform.position = new Vector3(0, 0, 0);
        }
    }
}
