using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O : MonoBehaviour
{
    public Sprite spo,spnull;
    public Button btn;
    public bool btnclked;
    
    //public Image image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        btn.onClick.AddListener(delegate { changeimg(); });
    }
    public void changeimg()
    {
        
        if (btn.GetComponent<Image>().sprite == spnull)
        {

            btn.GetComponent<Animator>().Play("O animation");
            
            //btn.GetComponent<Image>().sprite = spo;
            
        }
        

    }
}
