using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama;
    oyunKontrol OyunkontrolcuSC;
    // Start is called before the first frame update
    void Start()
    {
        OyunkontrolcuSC = GameObject.Find("_Scripts").GetComponent<oyunKontrol>();
    }
    void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.333f);
        OyunkontrolcuSC.balonEkle();
    }
}
