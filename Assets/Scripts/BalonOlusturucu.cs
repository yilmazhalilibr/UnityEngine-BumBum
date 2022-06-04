using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour
{
    public GameObject balon;
    float timer = 0f;
    float balonOlusturmaSuresi = 1f;
    oyunKontrol okScript;
    // Start is called before the first frame update
    void Start()
    {
        okScript = this.gameObject.GetComponent<oyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        int katsayi = (int)(okScript.zamansayaci / 10) - 6;
        katsayi *= -1;
        timer -= Time.deltaTime;
        if (timer<0 && okScript.zamansayaci >0) 
        {
            GameObject  go = Instantiate(balon,new Vector3(Random.Range(-2.75f,2.75f),-6f,0f),Quaternion.Euler(0,0,0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, Random.Range(90f* katsayi, 150f* katsayi), 0f));
            timer = balonOlusturmaSuresi;
        }
    }
}
