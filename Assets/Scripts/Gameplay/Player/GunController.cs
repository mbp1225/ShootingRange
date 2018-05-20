using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GunController : MonoBehaviour
{
    AudioSource src;

    bool canShoot = true;

    private void Start()
    {
        src = GetComponent<AudioSource>();
    }

    public void Shoot()
    {
        if (canShoot)
        {
            src.Play();
            transform.DOPunchRotation(new Vector3(-30f, 0, 0), .1f, 10, .5f);
        }
    }
}
