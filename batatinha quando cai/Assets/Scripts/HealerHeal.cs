using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealerHeal : MonoBehaviourPunCallbacks
{
    public float mana = 100;
    public GameObject melleHitbox;
    public GameObject healHitbox;
    public bool batendo;
    public bool curando;

    void Start()
    {
        melleHitbox.SetActive(false);
        batendo = false;
        healHitbox.SetActive(false);
        curando = false;
    }

    void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.Space) && batendo == false)
            {
                melleHitbox.SetActive(true);
                batendo = true;
                Invoke("DesligaHit", 1f);
            }
            if (Input.GetKeyDown(KeyCode.E) && curando == false && mana > 60)
            {
                mana -= 60;
                healHitbox.SetActive(true);
                curando = true;
                Invoke("DesligaHeal", 1f);
            }
            if (mana > 100)
            {
                mana = 100;
            }
        }

        if (photonView.IsMine)
        {
            mana += 5 * Time.deltaTime;
        }
    }
    public void DesligaHit()
    {
        melleHitbox.SetActive(false);
        batendo = false;
    }
    public void DesligaHeal()
    {
        healHitbox.SetActive(false);
        curando = false;
    }
}
