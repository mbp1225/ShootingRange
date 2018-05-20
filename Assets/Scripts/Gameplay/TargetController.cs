using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public void GetHit()
    {
        Destroy(gameObject);
    }
}
