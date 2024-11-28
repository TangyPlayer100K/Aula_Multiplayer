using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class boss : MonoBehaviour
{
    public int bossHp = 1000;

    public TextMeshProUGUI bossHpBar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bossHpBar.text = "vida: " + bossHp;
        if (bossHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Melle"))
        {
            bossHp -= 50;
        }
        if (other.gameObject.CompareTag("MelleWeak"))
        {
            bossHp -= 25;
        }
        if (other.gameObject.CompareTag("Magic"))
        {
            bossHp -= 5;
        }
    }
}
