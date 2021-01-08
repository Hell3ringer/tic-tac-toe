using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class popup : MonoBehaviour
{
    //public GameObject popupui;
    
    public Button mainmenu, reset;
    // Start is called before the first frame update
    void Start()
    {
        reset.onClick.AddListener(delegate { onreset(); });
        mainmenu.onClick.AddListener(delegate { onmain(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void onreset()
    {
        SceneManager.LoadScene(0);
    }
    private void onmain()
    {
        SceneManager.LoadScene(1);
    }
}
