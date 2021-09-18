using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial1 : MonoBehaviour
{
    Renderer rend;
    public Material material0;
    public Material material1;
    public Material material2;
    public Material material3;
    // Use this for initialization
    void Start()
    {

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        /*if (RandomSet.correct == 1)
        {
            //rend.sharedMaterial = material0;
            rend.sharedMaterial = RandomSet.materials[0, 2];
            //RandomSet.RemoveAt(ref RandomSet.buttonAssign, RandomSet.correct);
        }

        else if (RandomSet.correct == 0)
        {
            //rend.sharedMaterial = RandomSet.materials[RandomSet.buttonAssign[RandomSet.wrong1]];
            //rend.sharedMaterial = RandomSet.materials0[0];
            rend.sharedMaterial = RandomSet.materials[0, 0];
            //RandomSet.RemoveAt(ref RandomSet.buttonAssign, RandomSet.wrong1);
        }
        else if (RandomSet.correct == 2)
        {
            //rend.sharedMaterial = RandomSet.materials[RandomSet.buttonAssign[RandomSet.wrong2]];
            //rend.sharedMaterial = RandomSet.materials0[1];
            rend.sharedMaterial = RandomSet.materials[0, 1];
            //RandomSet.RemoveAt(ref RandomSet.buttonAssign, RandomSet.wrong2);
        }
        else if (RandomSet.correct == 3)
        {
            //rend.sharedMaterial = RandomSet.materials[RandomSet.buttonAssign[RandomSet.wrong3]];
            //rend.sharedMaterial = RandomSet.materials0[1];
            rend.sharedMaterial = RandomSet.materials[0, 1];
            //RandomSet.RemoveAt(ref RandomSet.buttonAssign, RandomSet.wrong3);
        }*/

        /*else if (RandomSet.buttonAssign[RandomSet.wrong1] == 1)
        {
            rend.sharedMaterial = RandomSet.materials[RandomSet.buttonAssign[RandomSet.wrong1]];
            //RandomSet.RemoveAt(ref RandomSet.buttonAssign, RandomSet.wrong1);
        }
        else if (RandomSet.buttonAssign[RandomSet.wrong2] == 1)
        {
            rend.sharedMaterial = RandomSet.materials[RandomSet.buttonAssign[RandomSet.wrong2]];
            //RandomSet.RemoveAt(ref RandomSet.buttonAssign, RandomSet.wrong2);
        }
        else if (RandomSet.buttonAssign[RandomSet.wrong3] == 1)
        {
            rend.sharedMaterial = RandomSet.materials[RandomSet.buttonAssign[RandomSet.wrong3]];
            //RandomSet.RemoveAt(ref RandomSet.buttonAssign, RandomSet.wrong3);
        }*/
    }

    // Update is called once per frame
    void Update()
    {

    }
}
