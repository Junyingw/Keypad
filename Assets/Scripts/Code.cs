using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code : MonoBehaviour
{
public GameObject num0;
    public GameObject num1;
    public GameObject num2;
    public GameObject num3;
    public GameObject num4;
    public GameObject num5;
    public GameObject num6;
    public GameObject num7;
    public GameObject num8;
    public GameObject num9;

    public GameObject cancle;
    public GameObject OK;

    public GameObject text;

   // public string textEnter;
    public string textError;
    public string textCorrect;

    List<int> cod = new List<int>();
   
    int index = 0;

    void Start()
    {
    //  text.GetComponent<Text>().text = textEnter;
    }

    public void Receiver(GameObject go)
    {
        if (go == num0)
        {
            addCode(0);
        }
        if (go == num1)
        {
            addCode(1);
        }
        if (go == num2)
        {
            addCode(2);
        }
        if (go == num3)
        {
            addCode(3);
        }
        if (go == num4)
        {
            addCode(4);
        }
        if (go == num5)
        {
            addCode(5);
        }
        if (go == num6)
        {
            addCode(6);
        }
        if (go == num7)
        {
            addCode(7);
        }
        if (go == num8)
        {
            addCode(8);
        }
        if (go == num9)
        {
            addCode(9);
        }
        if (go == cancle)
        {
            Delete();
        }
        if (go == OK)
        {
            Enter(); 
        }
    }

    // when we enter cancle, delelte the number
    void Delete()
    {
        cod.Clear();
        index = 0;
        text.GetComponent<Text>().text = "";
      
    }

    void Enter()
    {
        //bool isCorrect;
        List<int> inputCode = new List<int>() {1,2,3,4};
        //foreach (var x in inputCode){
        //    Debug.Log(x);
        //}

      /*  if (inputCode == cod){
            //isCorrect = true;
            text.GetComponent<Text>().text = textCorrect;
        }
        else{

            foreach (var num in inputCode)
            {
                Debug.Log(num);
            }
            //Debug.Log("first");
            foreach (var num in cod)
            {
                Debug.Log(num);
            }
            //Debug.Log("second");
            //Debug.Log(string.Join(",", correct));
            //Debug.Log(cod);

            //isCorrect = false;
            text.GetComponent<Text>().text = textError;
        }*/



        if(index == inputCode.Count)
        {
            bool isCorrect = true;
            for (int i = 0; i < inputCode.Count; i++)
            {
                if(cod[i]!= inputCode[i])
                {
                    isCorrect = false;
                    break;
                }
            }
            if(isCorrect)
            {
                text.GetComponent<Text>().text = textCorrect;
            }
            else
            {
                text.GetComponent<Text>().text = textError;
            }
        }
        else
        {
            text.GetComponent<Text>().text = textError;
            Delete();
        }
    }


    public void  addCode(int num)
    {
        cod.Add(num);
        index++;

      //  text.GetComponent<Text>().text += "";

        //for (int i = 0; i < index; i++)
        //{
            text.GetComponent<Text>().text += num;
        //}
    }

}
