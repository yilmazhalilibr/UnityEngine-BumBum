using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buton : MonoBehaviour
{
    // Start is called before the first frame update
    public void digerSahne() 
    {
        SceneManager.LoadScene("SampleScene");
    }
}
