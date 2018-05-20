using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GunController : MonoBehaviour
{
    AudioSource src;
    [SerializeField] Camera cam;

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

            RaycastHit hit;
            if (Physics.Raycast(cam.transform.position, cam.transform.forward/* + (Random.insideUnitSphere * currentRecoil)*/, out hit, 100f))
            {
                //Instantiate(hitDecal, hit.point, Quaternion.LookRotation(hit.normal), null);
                if (hit.transform.tag == "Target") hit.transform.GetComponent<TargetController>().GetHit();
            }
        }
    }
}
