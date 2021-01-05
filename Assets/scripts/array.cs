using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class array : MonoBehaviour
{
    public GameObject board;
    public Sprite spx,spo;
    public Button btn;
    public bool cputurn = false;
    public GameObject cpturn, playerturn;
    public List<int> ranlist = new List<int>();
    int count;
    private char[] arr = new char[9] {  'e', 'e', 'e' ,  'e', 'e', 'e' ,  'e', 'e', 'e' };
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 9; i++)
        {
            ranlist.Add(i);
        }
        btn.onClick.AddListener(delegate { if (cputurn) { randomAI(); } });
        if (cputurn)
        {
            cpturn.SetActive(true);
            playerturn.SetActive(false);
        }
        else
        {
            cpturn.SetActive(false);
            playerturn.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {
        checkarr();
        


    }
    private void checkarr()
    {
        for (int i = 0; i < 9; i++) {
            if(board.transform.GetChild(i).gameObject.GetComponent<Image>().sprite == spo)
            {
                arr[i] = 'o';
                ranlist.Remove(i);
            }
            if (board.transform.GetChild(i).gameObject.GetComponent<Image>().sprite == spx)
            {
                arr[i] = 'x';
                ranlist.Remove(i);
            }

        }
        cputurn = false;
        count = 0;
        for (int i = 0; i < 9; i++)
        {
            
            if (arr[i] == 'o' || arr[i] == 'x')
            {
                count++;
            }

        }
        if (count % 2 != 0)
        {
            cputurn = true;
            
        }
    }
    private void randomAI()
    {
        
        
        int randomnum = Random.Range(0, ranlist.Count);
        Debug.Log(ranlist.Count + "randomnum: " + randomnum);
        int r = ranlist[randomnum];
        Debug.Log("r value :"+ r);
       
        
        
            board.transform.GetChild(r).gameObject.GetComponent<Image>().sprite = spx;
            arr[r] = 'x';
            

        

    }
}
