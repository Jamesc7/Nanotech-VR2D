using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class summaryMatch : MonoBehaviour {

    //one variable per answer, either attached or not
    private static bool nano1 = false;
    private static bool nano2 = false;
    private static bool nano3 = false;
    private static bool nano4 = false;

    private static bool lipo1 = false;
    private static bool lipo2 = false;
    private static bool lipo3 = false;
    private static bool lipo4 = false;
    private static bool lipo5 = false;

    public GameObject Correct1;
    public GameObject Correct2;
    public GameObject Correct3;
    public GameObject Correct4;
    public GameObject Correct5;

    public GameObject step1;
    public GameObject step2;
    public GameObject step3;
    public GameObject step4;
    public GameObject step5;

    public GameObject lipoCheckmark1;
    public GameObject lipoCheckmark2;
    public GameObject lipoCheckmark3;
    public GameObject lipoCheckmark4;
    public GameObject lipoCheckmark5;

    public GameObject lipoXmark1;
    public GameObject lipoXmark2;
    public GameObject lipoXmark3;
    public GameObject lipoXmark4;
    public GameObject lipoXmark5;

    public GameObject nanoCheckmark1;
    public GameObject nanoCheckmark2;
    public GameObject nanoCheckmark3;
    public GameObject nanoCheckmark4;

    public GameObject nanoXmark1;
    public GameObject nanoXmark2;
    public GameObject nanoXmark3;
    public GameObject nanoXmark4;

    public GameObject nanoSet;
    public GameObject lipoSet;

    public GameObject nanoCheckBtn;
    public GameObject lipoCheckBtn;
    //questionSet 1 for nanoparticle, 2 for lipid

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("step1"))
        {
            
            if (nanoSet.activeInHierarchy)
            {

                if (gameObject.CompareTag("ans0") && nano1 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.683f, -13.103f);
                    step1.GetComponentInChildren<TextMesh>().text = "";
                    nano1 = true;
                    
                }
                else if (gameObject.CompareTag("ans1") && nano1 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.683f, -13.103f);
                    step1.GetComponentInChildren<TextMesh>().text = "";
                    nano1 = true;


                }
                else if (gameObject.CompareTag("ans2") && nano1 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.683f, -13.103f);
                    step1.GetComponentInChildren<TextMesh>().text = "";
                    nano1 = true;
                    Correct1.SetActive(true);

                }
                else if (gameObject.CompareTag("ans3") && nano1 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.683f, -13.103f);
                    step1.GetComponentInChildren<TextMesh>().text = "";
                    nano1 = true;

                }
            }
            else if (lipoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0") && lipo1 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.814683f, 9.442f);
                    step1.GetComponentInChildren<TextMesh>().text = "";
                    lipo1 = true;
                }
                else if (gameObject.CompareTag("ans1") && lipo1 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.814683f, 9.442f);
                    step1.GetComponentInChildren<TextMesh>().text = "";
                    lipo1 = true;
                    Correct1.SetActive(true);

                }
                else if (gameObject.CompareTag("ans2") && lipo1 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.814683f, 9.442f);
                    step1.GetComponentInChildren<TextMesh>().text = "";
                    lipo1 = true;

                }
                else if (gameObject.CompareTag("ans3") && lipo1 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.814683f, 9.442f);
                    step1.GetComponentInChildren<TextMesh>().text = "";
                    lipo1 = true;
                }
                else if (gameObject.CompareTag("ans4") && lipo1 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.814683f, 9.442f);
                    step1.GetComponentInChildren<TextMesh>().text = "";
                    lipo1 = true;
                }
            }
            

            //Debug.Log("attached1 = " + attached1);
        }
        else if (collider.gameObject.CompareTag("step2"))
        {
            if (nanoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0") && nano2 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.265f, -13.103f);
                    step2.GetComponentInChildren<TextMesh>().text = "";
                    nano2 = true;
                    Correct2.SetActive(true);
                }
                else if (gameObject.CompareTag("ans1") && nano2 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.265f, -13.103f);
                    step2.GetComponentInChildren<TextMesh>().text = "";
                    nano2 = true;

                }
                else if (gameObject.CompareTag("ans2") && nano2 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.265f, -13.103f);
                    step2.GetComponentInChildren<TextMesh>().text = "";
                    nano2 = true;
                    
                }
                else if (gameObject.CompareTag("ans3") && nano2 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.265f, -13.103f);
                    step2.GetComponentInChildren<TextMesh>().text = "";
                    nano2 = true;

                }
            }
            else if (lipoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0") && lipo2 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.469f, 9.442f);
                    step2.GetComponentInChildren<TextMesh>().text = "";
                    lipo2 = true;
                }
                else if (gameObject.CompareTag("ans1") && lipo2 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.469f, 9.442f);
                    step2.GetComponentInChildren<TextMesh>().text = "";
                    lipo2 = true;

                }
                else if (gameObject.CompareTag("ans2") && lipo2 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.469f, 9.442f);
                    step2.GetComponentInChildren<TextMesh>().text = "";
                    lipo2 = true;

                }
                else if (gameObject.CompareTag("ans3") && lipo2 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.469f, 9.442f);
                    step2.GetComponentInChildren<TextMesh>().text = "";
                    lipo2 = true;
                }
                else if (gameObject.CompareTag("ans4") && lipo2 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.469f, 9.442f);
                    step2.GetComponentInChildren<TextMesh>().text = "";
                    lipo2 = true;
                    Correct2.SetActive(true);
                }
            }
            //Debug.Log("nano2 = " + nano2);
        }
        else if (collider.gameObject.CompareTag("step3"))
        {
            if (nanoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0") && nano3 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .864f, -13.103f);
                    step3.GetComponentInChildren<TextMesh>().text = "";
                    nano3 = true;
                }
                else if (gameObject.CompareTag("ans1") && nano3 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .864f, -13.103f);
                    step3.GetComponentInChildren<TextMesh>().text = "";
                    nano3 = true;
                    Correct3.SetActive(true);
                }
                else if (gameObject.CompareTag("ans2") && nano3 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .864f, -13.103f);
                    step3.GetComponentInChildren<TextMesh>().text = "";
                    nano3 = true;
                }
                else if (gameObject.CompareTag("ans3") && nano3 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .864f, -13.103f);
                    step3.GetComponentInChildren<TextMesh>().text = "";
                    nano3 = true;
                }
            }
            else if (lipoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0") && lipo3 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.105f, 9.442f);
                    step3.GetComponentInChildren<TextMesh>().text = "";
                    lipo3 = true;

                }
                else if (gameObject.CompareTag("ans1") && lipo3 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.105f, 9.442f);
                    step3.GetComponentInChildren<TextMesh>().text = "";
                    lipo3 = true;

                }
                else if (gameObject.CompareTag("ans2") && lipo3 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.105f, 9.442f);
                    step3.GetComponentInChildren<TextMesh>().text = "";
                    lipo3 = true;

                }
                else if (gameObject.CompareTag("ans3") && lipo3 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.105f, 9.442f);
                    step3.GetComponentInChildren<TextMesh>().text = "";
                    lipo3 = true;
                    Correct3.SetActive(true);
                }
                else if (gameObject.CompareTag("ans4") && lipo3 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, 1.105f, 9.442f);
                    step3.GetComponentInChildren<TextMesh>().text = "";
                    lipo3 = true;
                }
            }

            //Debug.Log("nano2 = " + nano2);
        }
        else if (collider.gameObject.CompareTag("step4"))
        {
            if (nanoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0") && nano4 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .45f, -13.103f);
                    step4.GetComponentInChildren<TextMesh>().text = "";
                    nano4 = true;

                }
                else if (gameObject.CompareTag("ans1") && nano4 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .45f, -13.103f);
                    step4.GetComponentInChildren<TextMesh>().text = "";
                    nano4 = true;


                }
                else if (gameObject.CompareTag("ans2") && nano4 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .45f, -13.103f);
                    step4.GetComponentInChildren<TextMesh>().text = "";
                    nano4 = true;

                }
                else if (gameObject.CompareTag("ans3") && nano4 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .45f, -13.103f);
                    step4.GetComponentInChildren<TextMesh>().text = "";
                    nano4 = true;
                    Correct4.SetActive(true);
                }
            }
            else if (lipoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0") && lipo4 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .76f, 9.442f);
                    step4.GetComponentInChildren<TextMesh>().text = "";
                    lipo4 = true;
                    Correct4.SetActive(true);
                }

                else if (gameObject.CompareTag("ans1") && lipo4 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .76f, 9.442f);
                    step4.GetComponentInChildren<TextMesh>().text = "";
                    lipo4 = true;

                }
                else if (gameObject.CompareTag("ans2") && lipo4 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .76f, 9.442f);
                    step4.GetComponentInChildren<TextMesh>().text = "";
                    lipo4 = true;

                }
                else if (gameObject.CompareTag("ans3") && lipo4 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .76f, 9.442f);
                    step4.GetComponentInChildren<TextMesh>().text = "";
                    lipo4 = true;
                }
                else if (gameObject.CompareTag("ans4") && lipo4 == false)
                {
                    gameObject.transform.position = new Vector3(-2.93f, .76f, 9.442f);
                    step4.GetComponentInChildren<TextMesh>().text = "";
                    lipo4 = true;
                }
            }

        }
        //Only liposome has 5 answers
        else if (collider.gameObject.CompareTag("step5"))
        {
            if (gameObject.CompareTag("ans0") && lipo5 == false)
            {
                gameObject.transform.position = new Vector3(-2.93f, .414f, 9.442f);
                step5.GetComponentInChildren<TextMesh>().text = "";
                lipo5 = true;
            }
            else if (gameObject.CompareTag("ans1") && lipo5 == false)
            {
                gameObject.transform.position = new Vector3(-2.93f, .414f, 9.442f);
                step5.GetComponentInChildren<TextMesh>().text = "";
                lipo5 = true;

            }
            else if (gameObject.CompareTag("ans2") && lipo5 == false)
            {
                gameObject.transform.position = new Vector3(-2.93f, .414f, 9.442f);
                step5.GetComponentInChildren<TextMesh>().text = "";
                lipo5 = true;
                Correct5.SetActive(true);

            }
            else if (gameObject.CompareTag("ans3") && lipo5 == false)
            {
                gameObject.transform.position = new Vector3(-2.93f, .414f, 9.442f);
                step5.GetComponentInChildren<TextMesh>().text = "";
                lipo5 = true;
            }
            else if (gameObject.CompareTag("ans4") && lipo5 == false)
            {
                gameObject.transform.position = new Vector3(-2.93f, .414f, 9.442f);
                step5.GetComponentInChildren<TextMesh>().text = "";
                lipo5 = true;
            }
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("step1"))
        {
            if (nanoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0"))
                {
                    step1.GetComponentInChildren<TextMesh>().text = "Step 1";
                    nano1 = false;
                }
                else if (gameObject.CompareTag("ans1"))
                {
                    step1.GetComponentInChildren<TextMesh>().text = "Step 1";
                    nano1 = false;
                }
                else if (gameObject.CompareTag("ans2"))
                {
                    step1.GetComponentInChildren<TextMesh>().text = "Step 1";
                    nano1 = false;
                    Correct1.SetActive(false);
                }
                else if (gameObject.CompareTag("ans3"))
                {
                    step1.GetComponentInChildren<TextMesh>().text = "Step 1";
                    nano1 = false;
                }
            }
            else if (lipoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0") && lipo1 == true)
                {
                    step1.GetComponentInChildren<TextMesh>().text = "Step 1";
                    lipo1 = false;
                }
                else if (gameObject.CompareTag("ans1") && lipo1 == true)
                {
                    step1.GetComponentInChildren<TextMesh>().text = "Step 1";
                    lipo1 = false;
                    Correct1.SetActive(false);
                }
                else if (gameObject.CompareTag("ans2") && lipo1 == true)
                {
                    step1.GetComponentInChildren<TextMesh>().text = "Step 1";
                    lipo1 = false;
                }
                else if (gameObject.CompareTag("ans3") && lipo1 == true)
                {
                    step1.GetComponentInChildren<TextMesh>().text = "Step 1";
                    lipo1 = false;
                }
                else if (gameObject.CompareTag("ans4") && lipo1 == true)
                {
                    step1.GetComponentInChildren<TextMesh>().text = "Step 1";
                    lipo1 = false;
                }
            }
            
            //Debug.Log("attached1 = " + attached1);
        }
        else if (collider.gameObject.CompareTag("step2"))
        {
            if (nanoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0"))
                {
                    nano2 = false;
                    step2.GetComponentInChildren<TextMesh>().text = "Step 2";
                    Correct2.SetActive(false);
                }
                else if (gameObject.CompareTag("ans1"))
                {
                    nano2 = false;
                    step2.GetComponentInChildren<TextMesh>().text = "Step 2";
                }
                else if (gameObject.CompareTag("ans2"))
                {
                    nano2 = false;
                    step2.GetComponentInChildren<TextMesh>().text = "Step 2";
                }
                else if (gameObject.CompareTag("ans3"))
                {
                    nano2 = false;
                    step2.GetComponentInChildren<TextMesh>().text = "Step 2";
                }
            }
            else if (lipoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0"))
                {
                    step2.GetComponentInChildren<TextMesh>().text = "Step 2";
                    lipo2 = false;
                }
                else if (gameObject.CompareTag("ans1"))
                {
                    step2.GetComponentInChildren<TextMesh>().text = "Step 2";
                    lipo2 = false;
                }
                else if (gameObject.CompareTag("ans2"))
                {
                    step2.GetComponentInChildren<TextMesh>().text = "Step 2";
                    lipo2 = false;
                }
                else if (gameObject.CompareTag("ans3"))
                {
                    step2.GetComponentInChildren<TextMesh>().text = "Step 2";
                    lipo2 = false;
                }
                else if (gameObject.CompareTag("ans4"))
                {
                    step2.GetComponentInChildren<TextMesh>().text = "Step 2";
                    lipo2 = false;
                    Correct2.SetActive(false);
                }
            }
            //Debug.Log("nano2 = " + nano2);
        }
        else if (collider.gameObject.CompareTag("step3"))
        {
            if (nanoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0"))
                {
                    nano3 = false;
                    step3.GetComponentInChildren<TextMesh>().text = "Step 3";
                }
                else if (gameObject.CompareTag("ans1"))
                {
                    nano3 = false;
                    step3.GetComponentInChildren<TextMesh>().text = "Step 3";
                    Correct3.SetActive(false);
                }
                else if (gameObject.CompareTag("ans2"))
                {
                    nano3 = false;
                    step3.GetComponentInChildren<TextMesh>().text = "Step 3";
                }
                else if (gameObject.CompareTag("ans3"))
                {
                    nano3 = false;
                    step3.GetComponentInChildren<TextMesh>().text = "Step 3";
                }
            }
            else if (lipoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0"))
                {
                    step3.GetComponentInChildren<TextMesh>().text = "Step 3";
                    lipo3 = false;
                }
                else if (gameObject.CompareTag("ans1"))
                {
                    step3.GetComponentInChildren<TextMesh>().text = "Step 3";
                    lipo3 = false;
                }
                else if (gameObject.CompareTag("ans2"))
                {
                    step3.GetComponentInChildren<TextMesh>().text = "Step 3";
                    lipo3 = false;
                }
                else if (gameObject.CompareTag("ans3"))
                {
                    step3.GetComponentInChildren<TextMesh>().text = "Step 3";
                    lipo3 = false;
                    Correct3.SetActive(false);
                }
                else if (gameObject.CompareTag("ans4"))
                {
                    step3.GetComponentInChildren<TextMesh>().text = "Step 3";
                    lipo3 = false;
                }
            }
            //Debug.Log("nano2 = " + nano2);
        }
        else if (collider.gameObject.CompareTag("step4"))
        {
            if (nanoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0"))
                {
                    nano4 = false;
                    step4.GetComponentInChildren<TextMesh>().text = "Step 4";
                }
                else if (gameObject.CompareTag("ans1"))
                {
                    nano4 = false;
                    step4.GetComponentInChildren<TextMesh>().text = "Step 4";
                    //.SetActive(false);
                    //Debug.Log("BYE CON");
                }
                else if (gameObject.CompareTag("ans2"))
                {
                    nano4 = false;
                    step4.GetComponentInChildren<TextMesh>().text = "Step 4";
                }
                else if (gameObject.CompareTag("ans3"))
                {
                    nano4 = false;
                    step4.GetComponentInChildren<TextMesh>().text = "Step 4";
                    Correct4.SetActive(false);
                }
            }
            else if (lipoSet.activeInHierarchy)
            {
                if (gameObject.CompareTag("ans0"))
                {
                    step4.GetComponentInChildren<TextMesh>().text = "Step 4";
                    lipo4 = false;
                    Correct4.SetActive(false);
                }
                else if (gameObject.CompareTag("ans1"))
                {
                    step4.GetComponentInChildren<TextMesh>().text = "Step 4";
                    lipo4 = false;
                }
                else if (gameObject.CompareTag("ans2"))
                {
                    step4.GetComponentInChildren<TextMesh>().text = "Step 4";
                    lipo4 = false;
                }
                else if (gameObject.CompareTag("ans3"))
                {
                    step4.GetComponentInChildren<TextMesh>().text = "Step 4";
                    lipo4 = false;
                }
                else if (gameObject.CompareTag("ans4"))
                {
                    step4.GetComponentInChildren<TextMesh>().text = "Step 4";
                    lipo4 = false;
                }
            }
            //Debug.Log("nano2 = " + nano2);
        }
        else if (collider.gameObject.CompareTag("step5"))   //Lipo has 5 steps
        {
            if (gameObject.CompareTag("ans0"))
            {
                step5.GetComponentInChildren<TextMesh>().text = "Step 5";
                lipo5 = false;
            }
            else if (gameObject.CompareTag("ans1"))
            {
                step5.GetComponentInChildren<TextMesh>().text = "Step 5";
                lipo5 = false;
            }
            else if (gameObject.CompareTag("ans2"))
            {
                step5.GetComponentInChildren<TextMesh>().text = "Step 5";
                lipo5 = false;
                Correct5.SetActive(false);
            }
            else if (gameObject.CompareTag("ans3"))
            {
                step5.GetComponentInChildren<TextMesh>().text = "Step 5";
                lipo5 = false;
            }
            else if (gameObject.CompareTag("ans4"))
            {
                step5.GetComponentInChildren<TextMesh>().text = "Step 5";
                lipo5 = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (nanoSet.activeInHierarchy)
        {
            if (nano1 && nano2 && nano3 && nano4)
            {
                nanoCheckBtn.SetActive(true);
            }
            else
            {
                nanoCheckBtn.SetActive(false);
                nanoCheckmark1.SetActive(false);
                nanoCheckmark2.SetActive(false);
                nanoCheckmark3.SetActive(false);
                nanoCheckmark4.SetActive(false);
                nanoXmark1.SetActive(false);
                nanoXmark2.SetActive(false);
                nanoXmark3.SetActive(false);
                nanoXmark4.SetActive(false);
            }
        }
        if (lipoSet.activeInHierarchy)
        {
            if (lipo1 && lipo2 && lipo3 && lipo4 && lipo5)
            {
                lipoCheckBtn.SetActive(true);
            }
            else
            {
                lipoCheckBtn.SetActive(false);
                lipoCheckmark1.SetActive(false);
                lipoCheckmark2.SetActive(false);
                lipoCheckmark3.SetActive(false);
                lipoCheckmark4.SetActive(false);
                lipoCheckmark5.SetActive(false);
                lipoXmark1.SetActive(false);
                lipoXmark2.SetActive(false);
                lipoXmark3.SetActive(false);
                lipoXmark4.SetActive(false);
                lipoXmark5.SetActive(false);
            }
        }

    }
}

