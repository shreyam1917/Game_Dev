using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Shooter : MonoBehaviour
{
    public float Damage = 10;
    public float Range = 100;
    public Camera cam;
    public ParticleSystem fireeffect;
    public GameObject groundeffect;
    public Animator gun_anim;
    bool is_shooting = false;
    /*public AudioSource Shoot_sound;*/
   

    public void Shoot()
    {
        fireeffect.Play();
        RaycastHit Hit;
                   
       
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out Hit, Range))
        {
           
            
                var clone_ground = Instantiate(groundeffect, Hit.point, Quaternion.LookRotation(Hit.normal));
                Destroy(clone_ground, 3);
            
            Target_Hit target = Hit.transform.GetComponent<Target_Hit>();

            if (target != null)
            {
                target.Shoot_Damage(Damage);
            }
           
        }

        if (is_shooting == true)
        {
            gun_anim.SetBool("is_firing", true);
        }
        else
        {
            gun_anim.SetBool("is_firing", false);
        }

    }



public void firingPress()
    {
        is_shooting = true;
    }

    public void firingRelesase()
    {
        is_shooting = false;
    }
}
