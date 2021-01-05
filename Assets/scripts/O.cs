using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O : MonoBehaviour
{
    public Sprite spo,spnull;
    public Button btn;
    public bool btnclked;

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(delegate { changeimg(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeimg()
    {
        if(btn.GetComponent<Image>().sprite == spnull)
        {
            btn.GetComponent<Image>().sprite = spo;
        }       
         
        
    }
}
