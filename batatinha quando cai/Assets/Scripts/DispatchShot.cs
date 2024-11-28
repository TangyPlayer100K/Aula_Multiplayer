using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispatchShot : MonoBehaviourPunCallbacks
{
    public float mana = 100;
    public GameObject bulletSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(photonView.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.Space) && mana > 10)
            {
                mana -= 10;
                PhotonNetwork.Instantiate("Bullet", bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
            }
        }
        if (mana > 100)
        {
            mana = 100;
        }
        if (photonView.IsMine)
        {
            mana += 10 * Time.deltaTime;
        }
    }
}
