using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class popup : MonoBehaviour
{
    public TextMeshProUGUI mode;
    
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
        if(mode.text == "hard mode")
        {
            SceneManager.LoadScene(1);
        }
        if (mode.text == "easy mode")
        {
            SceneManager.LoadScene(0);
        }

    }
    private void onmain()
    {
        SceneManager.LoadScene(2);
    }
}
