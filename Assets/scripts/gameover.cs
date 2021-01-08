using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public GameObject board,winningline,popup;
    public Sprite spo,spx;
    public TextMeshProUGUI winnername;
    private string[,] arr = new string[3,3] { { "e", "e", "e" },{ "e", "e", "e", }, { "e", "e", "e", } };
    private string[] winarr = new string[8] { "h1", "h2", "h3", "v1", "v2", "v3", "d1", "d2" };

    // 1 2 3    (1,2,3)(1,4,7)(1,5,9)
    // 4 5 6
    // 7 8 9
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Pwin();
    }
    private void Pwin()
    {
        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                count++;
                if (board.transform.GetChild(count - 1).gameObject.GetComponent<Image>().sprite == spo)

                {
                    arr[i, j] = "o";
                    
                }
                if (board.transform.GetChild(count - 1).gameObject.GetComponent<Image>().sprite == spx)

                {
                    arr[i, j] = "x";
                }
            }
        }
        int sum1,sum2,sum3,sum4;
        for(int i = 0; i < 3; i++)
        {
            sum1 = 0; sum2 = 0; sum3 = 0; sum4 = 0;
            for (int j = 0; j< 3; j++)
            {
                if (arr[i, j] == "o")
                {
                    sum1++;                    
                }
                if (arr[j, i] == "o")
                {
                    sum2++;
                }
                if (arr[j, j] == "o")
                {
                    sum3++;
                }
                if (arr[0, 2] == "o" && arr[1, 1] == "o" && arr[2, 0] == "o")
                {
                    sum4 = 3;
                }
                if (sum1 == 3 )
                {
                    
                   
                    winnername.text = "player wins ...";
                    winningline.transform.GetChild(i).gameObject.SetActive(true);
                    popup.SetActive(true);
                    popup.GetComponent<Animator>().Play("popup animation");
                }
                if (sum2 == 3)
                {
                    
                    
                    winnername.text = "player wins ...";
                    winningline.transform.GetChild(i + 3).gameObject.SetActive(true);
                    popup.SetActive(true);
                    popup.GetComponent<Animator>().Play("popup animation");
                }
                if (sum3 == 3)
                {
                    
                    
                    winnername.text = "player wins ...";
                    winningline.transform.GetChild(6).gameObject.SetActive(true);
                    popup.SetActive(true);
                    popup.GetComponent<Animator>().Play("popup animation");
                }
                if (sum4 == 3)
                {
                    
                    
                    winnername.text = "player wins ...";
                    winningline.transform.GetChild(7).gameObject.SetActive(true);
                    popup.SetActive(true);
                    popup.GetComponent<Animator>().Play("popup animation");
                }
            }            
            
        }
        for (int i = 0; i < 3; i++)
        {
            sum1 = 0; sum2 = 0; sum3 = 0; sum4 = 0;
            for (int j = 0; j < 3; j++)
            {
                if (arr[i, j] == "x")
                {
                    sum1++;
                }
                if (arr[j, i] == "x")
                {
                    sum2++;
                }
                if (arr[j, j] == "x")
                {
                    sum3++;
                }
                if (arr[0, 2] == "x" && arr[1, 1] == "x" && arr[2, 0] == "x")
                {
                    sum4 = 3;
                }
                if (sum1 == 3)
                {

                    winnername.text = "cpu wins ...";
                    winningline.transform.GetChild(i).gameObject.SetActive(true);
                    popup.GetComponent<Animator>().Play("popup animation");


                }
                if (sum2 == 3)
                {

                    winnername.text = "cpu wins ...";
                    winningline.transform.GetChild(i + 3).gameObject.SetActive(true);
                    popup.GetComponent<Animator>().Play("popup animation");
                }
                if (sum3 == 3)
                {

                    winnername.text = "cpu wins ...";
                    winningline.transform.GetChild(6).gameObject.SetActive(true);
                    popup.GetComponent<Animator>().Play("popup animation");
                }
                if (sum4 == 3)
                {

                    winnername.text = "cpu wins ...";
                    winningline.transform.GetChild(7).gameObject.SetActive(true);
                    popup.GetComponent<Animator>().Play("popup animation");
                }
            }

        }
    }
}
