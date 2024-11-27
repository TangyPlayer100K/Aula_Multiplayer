using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelleHit : MonoBehaviourPunCallbacks
{
    //public float stamina = 100;
    public GameObject melleHitbox;
    public bool batendo;
    
    void Start()
    {
        melleHitbox.SetActive(false);
        batendo = false;
    }

    void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.Space) && batendo == false)
            {
                //stamina -= 10;
                melleHitbox.SetActive(true);
                batendo = true;
                Invoke("DesligaHit", 1f);
            }
        }
        //if (photonView.IsMine)
        //{
        //    stamina += 10 * Time.deltaTime;
        //}
    }
    public void DesligaHit()
    {
        melleHitbox.SetActive(false);
        batendo = false;
    }
}
