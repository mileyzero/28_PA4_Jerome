using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loadscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadAft1sec", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadAft1sec()
    {
        SceneManager.LoadScene(1);
    }
}
