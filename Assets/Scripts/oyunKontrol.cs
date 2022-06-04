using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunKontrol : MonoBehaviour
{
    public float zamansayaci = 60f;
    int patlayanBalon = 0;
    public UnityEngine.UI.Text zamanText, balonText;
    public GameObject patlama;
    // Start is called before the first frame update
    void Start()
    {
        balonEkle();
    }

    // Update is called once per frame
    void Update()
    {
        if (zamansayaci>0)
        {
            zamansayaci -= Time.deltaTime;
            zamanText.text = "Süre " + (int)zamansayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balonum");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }
        
    }
    public void balonEkle()
    {
        patlayanBalon += 1;
        balonText.text = "Patlatýlan " + patlayanBalon;
    }
}
