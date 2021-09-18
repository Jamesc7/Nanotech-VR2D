using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomSet : MonoBehaviour
{

    public static int correct;
    public static int wrong1;
    public static int wrong2;
    public static int wrong3;

    public GameObject ans0;
    public GameObject ans1;
    public GameObject ans2;
    public GameObject ans3;

    public GameObject start;


    public Material material0;
    public Material material1;
    public Material material2;
    public Material material3;

    public Material material4;
    public Material material5;
    public Material material6;
    public Material material7;

    private int questionNum = 0;
    public static Material[] materials0 = new Material[4];
    public static Material[] materials1 = new Material[4];

    public static Material[,] materials;
    



    public static int[] buttonAssign = new int[] { 0, 1, 2, 3 };

    // Use this for initialization
    void Start()
    {

        /////////// Working on button randomization. Need to assign buttons
        materials0[0] = material0;
        materials0[1] = material1;
        materials0[2] = material2;
        materials0[3] = material3;

        materials1[0] = material4;
        materials1[1] = material5;
        materials1[2] = material6;
        materials1[3] = material7;

        materials = new Material[2, 4];
        
        // working on 2D material list
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == 0)
                {
                    materials[i, j] = materials0[j];
                }
                else if (i == 1)
                {
                    materials[i, j] = materials1[j];
                }
            }
            
        }
        /*if (start.CompareTag("Start"))
        {
            randomSet();
        }*/
            
    }

    

    public static void RemoveAt<T>(ref T[] arr, int index)
    {
        for (int a = index; a < arr.Length - 1; a++)
        {
            // moving elements downwards, to fill the gap at [index]
            arr[a] = arr[a + 1];
        }
        
        // finally, let's decrement Array's size by one
        Array.Resize(ref arr, arr.Length - 1);
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log("Resize????? " + arr[i]);
        }
    }

    private void randomSet()
    {



        // Out of the 4 buttons, assigns a random number 1 - 4 to each button
        // Random.range
        correct = UnityEngine.Random.Range(0, 4);
        Debug.Log(correct);
        Debug.Log(buttonAssign[correct]);
        for (int i = 0; i < 4; i++)
        {
            Debug.Log("Index #" + i + ": " + buttonAssign[i]);
        }
        //RemoveAt(ref buttonAssign, correct);

        wrong1 = UnityEngine.Random.Range(0, 3);
        Debug.Log(buttonAssign[wrong1]);
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Index #" + i + ": " + buttonAssign[i]);
        }
        /*for (int i = 0; i < 3; i++)
        {
            Debug.Log("Element: " + buttonAssign[i]);
        }*/
        //RemoveAt(ref buttonAssign, wrong1);

        wrong2 = UnityEngine.Random.Range(0, 2);
        Debug.Log(buttonAssign[wrong2]);
        for (int i = 0; i < 2; i++)
        {
            Debug.Log("Index #" + i + ": " + buttonAssign[i]);
        }
        //RemoveAt(ref buttonAssign, wrong2);

        wrong3 = UnityEngine.Random.Range(0, 1);
        Debug.Log(buttonAssign[wrong3]);
        for (int i = 0; i < 1; i++)
        {
            Debug.Log("Index #" + i + ": " + buttonAssign[i]);
        }
        //RemoveAt(ref buttonAssign, wrong3);

        if (correct == 0)
        {
            if (ans0.CompareTag("ans0"))
            {

                //ans0.GetComponent<Renderer>().material = material2;
                /*rend0 = GetComponent<Renderer>();
                rend0.enabled = true;
                rend0.material = material1;*/


                Debug.Log("it workds 0 inner");
            }
            Debug.Log("it workds 0");
        }
        if (correct == 1)
        {
            if (ans1.CompareTag("ans1"))
            {
                //ans1.GetComponent<Renderer>().material = material2;
                /*rend1 = GetComponent<Renderer>();
                rend1.enabled = true;
                rend1.material = material1;*/



                Debug.Log("it workds 1 inner");
            }
            Debug.Log("it workds 1");
        }
        if (correct == 2)
        {
            if (ans2.CompareTag("ans2"))
            {


                //ans2.GetComponent<Renderer>().material = material2;
                /*rend2 = GetComponent<Renderer>();
                rend2.enabled = true;
                rend2.material = material1;*/


                Debug.Log("it workds 2 inner");
            }
            Debug.Log("it workds 2");
        }
        if (correct == 3)
        {
            if (ans3.CompareTag("ans3"))
            {


                //ans3.GetComponent<Renderer>().material = material2;
                /*rend3 = GetComponent<Renderer>();
                rend3.enabled = true;
                rend3.material = material1;*/

                Debug.Log("it workds 3 inner");
            }
            Debug.Log("it workds 3");
        }
    }
}
