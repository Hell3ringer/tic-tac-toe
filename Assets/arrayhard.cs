using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrayhard : MonoBehaviour
{
    public GameObject board;
    public Sprite spx, spo;
    public Button btn;
    public GameObject popup;
    public bool cputurn = false;
    public GameObject cpturn, playerturn;
    private List<int> ranlist = new List<int>();
    int count;
    private char[] arr = new char[9] { 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e' };
    // Start is called before the first frame update
    void Start()
    {
        
        
            for (int i = 0; i < 9; i++)
            {
                ranlist.Add(i);
            }
        
    }

    // Update is called once per frame
    void Update()
    {
        checkarr();
        if (cputurn && !popup.activeInHierarchy)
        {
            cpturn.SetActive(true);
            playerturn.SetActive(false);
            //Invoke("randomAI", 5);
            if(popup)hardAI();
        }
        else
        {
            cpturn.SetActive(false);
            playerturn.SetActive(true);
        }
    }
    private void checkarr()
    {
        for (int i = 0; i < 9; i++)
        {
            if (board.transform.GetChild(i).gameObject.GetComponent<Image>().sprite == spo
                //board.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text == "o"
                )
            {
                arr[i] = 'o';
                ranlist.Remove(i);
            }
            /*if (board.transform.GetChild(i).gameObject.GetComponent<Image>().sprite == spx)
            {
                arr[i] = 'x';
                ranlist.Remove(i);
            }*/

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
    private void hardAI()
    {
        bool flag = true;
        for(int i = 0; i<3; i++)
        {
            if (arr[i] == 'o' && arr[i + 1] == 'o' || arr[i + 2] == 'o' && arr[i + 1] == 'o' || arr[i] == 'o' && arr[i + 2] == 'o')
            {
                if(arr[i] == 'e')
                {
                    board.transform.GetChild(i).gameObject.GetComponent<Animator>().Play("X animation");
                    arr[i] = 'x';
                    ranlist.Remove(i);
                    flag = false;goto sucess;
                    
                }
                if (arr[i + 1] == 'e')
                {
                    board.transform.GetChild(i + 1).gameObject.GetComponent<Animator>().Play("X animation");
                    arr[i + 1] = 'x';
                    ranlist.Remove(i + 1);
                    flag = false;goto sucess;
                }
                if (arr[i + 2] == 'e')
                {
                    board.transform.GetChild(i + 2).gameObject.GetComponent<Animator>().Play("X animation");
                    arr[i + 2] = 'x';
                    ranlist.Remove(i + 2);
                    flag = false;goto sucess;
                }
            }
            if (arr[i] == 'o' && arr[i + 3] == 'o' || arr[i + 6] == 'o' && arr[i + 3] == 'o' || arr[i] == 'o' && arr[i + 6] == 'o')
            {
                if (arr[i] == 'e')
                {
                    board.transform.GetChild(i).gameObject.GetComponent<Animator>().Play("X animation");
                    arr[i] = 'x';
                    ranlist.Remove(i);
                    flag = false;goto sucess;
                }
                if (arr[i + 3] == 'e')
                {
                    board.transform.GetChild(i + 3).gameObject.GetComponent<Animator>().Play("X animation");
                    arr[i + 3] = 'x';
                    ranlist.Remove(i + 3);
                    flag = false;goto sucess;
                }
                if (arr[i + 6] == 'e')
                {
                    board.transform.GetChild(i + 6).gameObject.GetComponent<Animator>().Play("X animation");
                    arr[i + 6] = 'x';
                    ranlist.Remove(i + 6);
                    flag = false;goto sucess;
                }
            }
        }
        if (arr[0] == 'o' && arr[4] == 'o' || arr[8] == 'o' && arr[4] == 'o' || arr[0] == 'o' && arr[8] == 'o')
        {
            if (arr[0] == 'e')
            {
                board.transform.GetChild(0).gameObject.GetComponent<Animator>().Play("X animation");
                arr[0] = 'x';
                ranlist.Remove(0);
                flag = false;goto sucess;
            }
            if (arr[4] == 'e')
            {
                board.transform.GetChild(4).gameObject.GetComponent<Animator>().Play("X animation");
                arr[4] = 'x';
                ranlist.Remove(4);
                flag = false;goto sucess;
            }
            if (arr[8] == 'e')
            {
                board.transform.GetChild(8).gameObject.GetComponent<Animator>().Play("X animation");
                arr[8] = 'x';
                ranlist.Remove(8);
                flag = false;goto sucess;
            }
        }
        if (arr[2] == 'o' && arr[4] == 'o' || arr[6] == 'o' && arr[4] == 'o' || arr[6] == 'o' && arr[2] == 'o')
        {
            if (arr[2] == 'e')
            {
                board.transform.GetChild(2).gameObject.GetComponent<Animator>().Play("X animation");
                arr[2] = 'x';
                ranlist.Remove(2);
                flag = false;goto sucess;
            }
            if (arr[4] == 'e')
            {
                board.transform.GetChild(4).gameObject.GetComponent<Animator>().Play("X animation");
                arr[4] = 'x';
                ranlist.Remove(4);
                flag = false;goto sucess;
            }
            if (arr[6] == 'e')
            {
                board.transform.GetChild(6).gameObject.GetComponent<Animator>().Play("X animation");
                arr[6] = 'x';
                ranlist.Remove(6);
                flag = false;goto sucess;
            }
        }
        sucess: { }
        if (flag)
        {
            randomAI();
            flag = false;
        }

    }
    private void randomAI()
    {

        if (ranlist.Count != 0)
        {
            int randomnum = Random.Range(0, ranlist.Count);
            //Debug.Log(ranlist.Count + "randomnum: " + randomnum);
            int r = ranlist[randomnum];
            //Debug.Log("r value :" + r);
            board.transform.GetChild(r).gameObject.GetComponent<Animator>().Play("X animation");
            //board.transform.GetChild(r).gameObject.GetComponent<Image>().sprite = spx;
            arr[r] = 'x';
            ranlist.Remove(r);
        }
    }
}
