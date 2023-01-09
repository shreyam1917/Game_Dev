using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Hit : MonoBehaviour
{
    public float Health = 50;
    public GameObject Explosion;
    public AudioSource Explosion_Sound;
    // Start is called before the first frame update

    public void Shoot_Damage (float damage_amount)
    {
        Health -= damage_amount;
        if(Health <= 0)
        {
            Explosion_Sound.Play();
            var clone = Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(clone, 2);
            Destroy(this.gameObject);
            
        }
    }
}
