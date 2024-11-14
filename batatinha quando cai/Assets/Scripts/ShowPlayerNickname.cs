using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerNickname : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = photonView.Owner.NickName.Split(" | ")[0];     
        print (photonView.Owner.NickName.Split(" | "));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}