//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Demonstrates how to create a simple interactable object
//
//=============================================================================

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem.Sample
{
    //-------------------------------------------------------------------------
    [RequireComponent(typeof(AudioSource))]
    [RequireComponent(typeof(Interactable))]
    public class InteractableExample : MonoBehaviour
    {
        /////////////////////////
        /// Summary stuff
        /// 
        public GameObject prog1;
        public GameObject prog2;
        public GameObject prog3;
        public GameObject prog4;
        public GameObject prog5;
        public GameObject prog6;
        public GameObject prog7;
        public GameObject prog8;
        public GameObject prog9;
        public GameObject prog10;

        public GameObject nanoPicsAns;
        public GameObject lipoPicsAns;

        public GameObject nanoCheckBtn;
        public GameObject lipoCheckBtn;

        public GameObject nanoFinalTxt;
        public GameObject lipoFinalTxt;

        public GameObject closeAppButton;

        public GameObject nanoSummaryRoom;
        public GameObject lipoSummaryRoom;

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

        public GameObject correct1;
        public GameObject correct2;
        public GameObject correct3;
        public GameObject correct4;
        public GameObject correct5;

        public GameObject playerOne;
        //-------------------------------------------------
        //              Text-to-speech variables, etc.
        //-------------------------------------------------
        //End Audio
        public AudioClip nanoEnd;
        public AudioClip lipoEnd;

        //Introduction
        public AudioClip Intro1;
        public AudioClip Intro2;
        public AudioClip Intro1_2;
        public AudioClip Intro59;

        //Tutorial & Controller Diagram
        public GameObject controller_diagram;
        public GameObject tutorial_cube;

        //Nano Intro
        public AudioClip Intro3;

        //Lipo Intro
        public AudioClip Intro33;

        //Nanoparticle Questions
        public AudioClip Nano1;
        public AudioClip Nano2;
        public AudioClip Nano3;
        public AudioClip Nano4;
        public AudioClip Nano5;
        public AudioClip Nano6;
        public AudioClip Nano7;
        public AudioClip Nano8;
        public AudioClip Nano9;
        public AudioClip NanoTransition1;
        public AudioClip NanoTransition2;
        public AudioClip NanoTransition3;
        public AudioClip NanoTransition4;
        public AudioClip NanoTransition5;
        public AudioClip NanoTransition6;
        public AudioClip NanoTransition7;
        public AudioClip NanoCorrect1;
        public AudioClip NanoCorrect2;
        public AudioClip NanoCorrect3;
        public AudioClip NanoCorrect4;
        public AudioClip NanoCorrect5;
        public AudioClip NanoCorrect6;
        public AudioClip NanoCorrect7;
        public AudioClip NanoCorrect8;
        public AudioClip NanoCorrect9;
        public AudioClip NanoBetweenQ1Q2;

        public AudioClip NanoSummary;

        //Liposome Questions
        public AudioClip Lipo1;
        public AudioClip Lipo2;
        public AudioClip Lipo3;
        public AudioClip Lipo4;
        public AudioClip Lipo5;
        public AudioClip Lipo6;
        public AudioClip Lipo7;
        public AudioClip Lipo8;
        public AudioClip Lipo9;
        public AudioClip LipoTransition1;
        public AudioClip LipoTransition2;
        public AudioClip LipoTransition3;
        public AudioClip LipoTransition4;
        public AudioClip LipoTransition5;
        public AudioClip LipoCorrect1;
        public AudioClip LipoCorrect2;
        public AudioClip LipoCorrect3;
        public AudioClip LipoCorrect4;
        public AudioClip LipoCorrect5;
        public AudioClip LipoCorrect6;
        public AudioClip LipoCorrect7;
        public AudioClip LipoCorrect8;
        public AudioClip LipoCorrect9;
        public AudioClip LipoBetweenQ1Q2;

        public AudioClip LipoSummary;

        //Transition
        public AudioClip Transition;
        //General variables
        AudioSource audioSource;
        public GameObject stopLid;
        public GameObject nanoRotFlask;
        public GameObject lipoRotFlask;
        public GameObject correct_once_the;
        //-------------------------------------------------
        // ^^^^^^^^^^^^^Text-to-speech variables^^^^^^^^^^^
        //-------------------------------------------------

        private TextMesh generalText;
        private TextMesh hoveringText;
        private Vector3 oldPosition;
        private Quaternion oldRotation;

        private float attachTime;

        private Hand.AttachmentFlags attachmentFlags = Hand.defaultAttachmentFlags & (~Hand.AttachmentFlags.SnapOnAttach) & (~Hand.AttachmentFlags.DetachOthers) & (~Hand.AttachmentFlags.VelocityMovement);

        private Interactable interactable;

        public GameObject plungers;
        Animator extrude;

        public GameObject solution;
        Animator moveSolution;

        public GameObject rotaryEvapNano;
        public GameObject rotaryEvapLip;

        public Text text;

        // Sets the middle board blank after introduction is finished
        public Text text2;

        private string[] introNano = {
            //"Welcome to the Introduction to Nanotechnology Lab! For this experience, you will need to use your mouse or mousepad and your keyboard. Please proceed by pointing the cursor at the 'Next' button below and left clicking on it.",
            "Welcome to the Introduction to Nanotechnology Lab! For this experience, you will only need to use your mouse and keyboard. Please proceed by pointing the cursor at the 'Next' button below and left clicking on it.",
            "You can also point at objects and then press & hold the left mouse button to grab them. Please test this function by grabbing the cube below. When ready, click the 'Next' button below to proceed.",
            "To move around, use the 'WASD' keys on your keyboard. To zoom the camera in, press the 'E' or 'Z' key. Click the 'Next' button to continue.",
            "In this virtual reality (VR) simulation, you will learn the process of fabricating and characterizing nanotechnology-based drug delivery carriers. You will be randomly assigned to two learning modules on polymeric nanoparticles and liposomes.",
            "Are you ready to make your own nanoparticles?",
            ""
        };

        private string[] introLip = {
            "Welcome to the Introduction to Nanotechnology Lab! For this experience, you will only need to use your mouse and keyboard. Please proceed by pointing the cursor at the 'Next' button below and left clicking on it.",
            "You can also point at objects and then press & hold the left mouse button to grab them. Please test this function by grabbing the cube below. When ready, click the 'Next' button below to proceed.",
            "To move around, use the 'WASD' keys on your keyboard. To zoom the camera in, press the 'E' or 'Z' key. Click the 'Next' button to continue.",
            "In this virtual reality (VR) simulation, you will learn the process of fabricating and characterizing nanotechnology-based drug delivery carriers. You will be randomly assigned to two learning modules on polymeric nanoparticles and liposomes.",
            "Are you ready to make your own liposomes?",
            ""
        };
        //Old intro



        private int introCounter = 0;

        public GameObject introNext;

        public GameObject mixture;
        public GameObject grabBeaker;
        public GameObject nanoMat;
        public GameObject lipMat;

        public GameObject hydra_extru;

        public GameObject probe_son;

        public GameObject No;
        public GameObject Yes;
        public GameObject Next;
        public GameObject Next2;
        public GameObject Next3;

        public GameObject startIntro;
        public GameObject start;
        public GameObject start2;
        public GameObject start3;

        public GameObject arrowIntro;

        public GameObject q1_key;
        public GameObject q4_key;

        //PLGA NP q1
        public GameObject ans0;
        public GameObject ans1;
        public GameObject ans2;
        public GameObject ans3;
        // PLGA NP q2
        public GameObject ans4;
        public GameObject ans5;
        public GameObject ans6;
        public GameObject ans7;
        //PLGA NP q3
        public GameObject ans8;
        public GameObject ans9;
        public GameObject ans10;
        public GameObject ans11;
        // PLGA NP q4
        public GameObject ans12;
        public GameObject ans13;
        public GameObject ans14;
        public GameObject ans15;
        //PLGA NP q5
        public GameObject ans16;
        public GameObject ans17;
        public GameObject ans18;
        public GameObject ans19;
        // PLGA NP q6
        public GameObject ans20;
        public GameObject ans21;
        public GameObject ans22;
        public GameObject ans23check;

        public GameObject grabFlaskNano;
        public GameObject grabFlaskLip;
        public GameObject rotFlaskNano;
        public GameObject waterNano;
        public GameObject soluteNano;
        public GameObject nanoDroplet;

        public GameObject soluteLipid;
        public GameObject rotFlaskLip;
        public GameObject lipDroplet;

        public GameObject label_arrows;
        public GameObject arrow;
        public GameObject rotationArrow;

        public GameObject correctEvap;
        public GameObject correctCon;

        public GameObject diagram;
        //PLGA NP q7
        public GameObject ans24;
        public GameObject ans25;
        public GameObject ans26;
        public GameObject ans27;

        //PLGA NP q8
        public GameObject ans28;
        public GameObject ans29;

        //PLGA NP q9
        public GameObject ans30;
        public GameObject ans31;
        public GameObject ans32;

        public GameObject dontMindMePlaceholder;

        // liposome q1
        public GameObject ans33;
        public GameObject ans34;
        public GameObject ans35;
        public GameObject ans36;

        //liposome q2
        public GameObject ans37;
        public GameObject ans38;
        public GameObject ans39;
        public GameObject ans40;

        // liposome q3
        public GameObject ans41;
        public GameObject ans42;
        public GameObject ans43;
        public GameObject ans44;

        //liposome q4
        public GameObject ans45;
        public GameObject ans46;
        public GameObject ans47;
        public GameObject ans48;

        // liposome q5
        public GameObject ans49;
        public GameObject ans50;
        public GameObject ans51;
        public GameObject ans52;

        //liposome q6
        // The same question as q6 for nanoparticles

        //public GameObject ans53check;

        public GameObject hydra_arrow;
        public GameObject hydra_flask_placement;

        //liposome q7
        public GameObject ans53;
        public GameObject ans54;
        public GameObject ans55;

        public GameObject hydra_flask_temp;
        public GameObject hydra_grabFlask;
        public GameObject extrude_arrow1;
        public GameObject extrude_flask_placement;

        //liposome q8
        public GameObject ans56;
        public GameObject ans57;

        //liposome q9
        public GameObject ans58;
        public GameObject ans59;
        public GameObject ans60;

        bool ans_set1;
        bool ans_set2;
        bool ans_set3;
        bool ans_set4;
        bool ans_set5;
        bool ans_set6;
        bool ans_set7;
        bool ans_set8;
        bool ans_set9;
        bool ans_set10;
        bool ans_set11;

        /////////////added new material4 /////////////////////////////////////////////////////
        public Material material0;
        public Material material1;
        public Material material2;
        public Material material3;

        public static int correct;
        public static int wrong1;
        public static int wrong2;
        public static int wrong3;

        int[] correctIndex = { };
        static int counter = 0;

        string[] correctOrder = { "ans3", "ans2", "ans1", "ans1", "ans3" };



        /// /////////////////////////////////////////////////////////////////////////////////////////
        /// Stuff for inputting Name
        /// /// /////////////////////////////////////////////////////////////////////////////////////////

        public GameObject playerName;
        public GameObject playerID;
        private static string studentName;
        private static string studentID;
        private static Boolean getName = false;

        /// /////////////////////////////////////////////////////////////////////////////////////////
        /// Stuff for inputting Name
        /// /// /////////////////////////////////////////////////////////////////////////////////////////









        /*Renderer rend0;
        Renderer rend1;
        Renderer rend2;
        Renderer rend3;*/



        //private int[] buttonAssign = new int[] { 0, 1, 2, 3 };


        static bool pressed = false;

        private static int i = 0;
        private static int z = 0;

        private static int questionSet = 1; // 1 for nanoparticle, 2 for lipid, Randomized at start()
        public GameObject questionSet1Check;
        public GameObject questionSet2Check;

        private string[] questionsNano1 = {
            "Which of the following is an example of a PLGA nanoparticle?",

            "Now, you need to select suitable materials for producing PLGA nanoparticles.",

            "Pick the correct polymer used to make PLGA nanoparticles.",
            "Pick a solvent that can be used to dissolve the polymer to make nanoparticles.",
            "What is the correct chemical structure of dichloromethane (DCM)?",
            "Pick a stabilizer that can be used to make stable emulsion droplets for preparing PLGA nanoparticles.",

            "Good job! You have picked all correct materials. Next, you will make an emulsion containing PLGA polymer. To do this, dissolve PLGA in DCM by placing them in one beaker and then dissolve PVA in water by placing them in the other beaker.",
            //"Now, in front of you are 2 pairs of materials and 2 beakers. Add the materials to the respective beakers below them. Once the materials have been added, take the beaker on your right, and touch it to the beaker on the left to mix the materials together. After that, follow the indicators and take the resulting beaker to the probe sonicator to emulsify the mixture.",

            "Select 2 terms from the right, and match them to the processes to the rotary evaporator diagram:",

            "Now let’s measure the particle size of your nanoparticles. Follow the arrows and transfer the nanoparticles from the righthand flask to a cuvette and place the cuvette in the Zetasizer.",
            //"Now, remove the flask on the right hand side of the rotary evaporator. Follow the arrows and take it the DLS machine to analyze the solution. Then answer the questions on the black board.",

            "Which of the following represents a monodispersed nanoparticle system?",
            "How can we visualize the PLGA Nanoparticles?",
            "Which step is used to reduce particle size?",
            "You have reached the end of the nanoparticles module. This next and final section will summarize everything you have learned in this module. <color=red>You will be teleported shortly</color>"
        };

        /*private string[] questionsNano2 =
        {
            "Match the process to the diagram:",
            "How can we visualize the PLGA Nanoparticles?",
            "Which of the following represents a monodispersed nanoparticle system?"
        };*/

        private string[] feedback1 = {
            "Correct! PLGA nanoparticles have a spherical shape with a matrix structure.",
            "", //placeholder to keep up with the index
            "Correct! <color=red>PLGA is a copolymer consisting of two monomers (i.e. lactic acid and glycolic acid)</color> and is a widely used biodegradable polymer used to make nanoparticles.",
            "Correct! <color=red>PLGA is not soluble in water, however it dissolves in</color> many <color=red>chlorinated solvents such as dichloromethane (DCM).</color>",
            "Correct! Dichloromethane is a molecule that contains 2 chlorine atoms (hence di- prefix) attached to a central carbon atom.",
            "Correct! <color=red>PVA is a common stabilizer in nanoparticle fabrication</color>. It can prevent droplet/nanoparticle aggregation, leading to a stable formulation.",

            "Correct! Organic solvent is evaporated in the round bottom flask and travels to the chiller, where it is condensed on the coils and collected in the waste flask.",

            "Correct! <color=red>A monodispersed nanoparticle system will exhibit a single, narrow peak on a particle size analyzer</color> indicating that the majority of particles fall within that size range.",
            "Correct! <color=red>Nanoparticles</color>, as the name implies, <color=red>are too small to be seen by the naked eye</color> and are even too small to be viewed on a traditional <color=red>light microscope</color>. Thus, <color=red>electron microscopy is utilized to visualize these particles</color>.",
            "Correct! Probe sonicators use high energy sound waves to physically disrupt and break apart droplets."
        }; // YES
        private string[] feedback2 = {
            "Hint: PLGA nanoparticles have a spherical shape with a matrix structure.",
            "", //placeholder to keep up with the index
            "Hint: PLGA is a copolymer consisting of two monomers (i.e. lactic acid and glycolic acid). So pick the structure containing these two components.",
            "Hint: PLGA is not soluble in water, however it dissolves in many chlorinated solvents.",
            "Hint: Break down the name. Di = 2, chloro = referring to chlorine.",
            "Hint: Stabilizers are typically surfactants.",

            "Hint: Organic solvent is evaporated in the round bottom flask and travels to the chiller, where it is condensed on the coils and collected in the waste flask.",

            "Hint: Break down the name, mono = 1...",
            "Hint: Nanoparticles, are considered colloidal disperse systems. What tools can be used to visualize colloidal disperse systems?",
            "Hint: Using external force to break down droplets"
        }; // NO

        private string[] questionsLip = {
            "Which of the following is an example of a liposome?",

            "Now, you need to select suitable materials for fabricating liposomes.",

            "Pick a lipid that can be used to make liposomes.",
            "Pick a solvent that can be used to dissolve the lipid.",
            "Pick a correct stabilizer that can be used to make stable liposomes.",
            "Pick the correct chemical structure for cholesterol.",

            "Good job! You have picked all correct materials. Next, you will make a thin film in a round bottom flask. To do this, add lipid, cholesterol, and chloroform into the beaker in front of you. ",

            "Select 2 terms from the right, and match them to the processes to the rotary evaporator diagram:",
            "Once the lipid thin film is formed, the next step is to hydrate the film using an aqueous medium. Take the round bottom flask over to the pipette and add aqueous media into the flask to initiate the hydration step. This will form the liposomes.",
            "If initial particle size of liposomes is larger than 800 nm, what technique could be used to reduce size down to below 200nm?",

            "Now, let us move to the extrusion stage. Follow the arrow and bring your flask over to the extruder and withdraw liposome solution into the syringe.",

            "Which of the following represents a monodispersed liposome system?",
            "How can we visualize nanosized liposomes?",
            "You have reached the end of the liposomes module. This next and final section will summarize everything you have learned in this module. <color=red>You will be teleported shortly</color>"
        };

        private string[] feedback3 = {
            "Correct! <color=red>Liposomes consist of a lipid bilayer structure</color>, and can be used as drug carriers, owing to a hydrophilic core for hydrophilic drugs and a hydrophobic bilayer for hydrophobic drugs.",
            "",
            "Correct! <color=red>A lipid looks like a surfactant molecule with long chain hydrocarbons</color> (hydrophobic) and <color=red>a hydrophilic part</color> (e.g. <color=red>phosphate head group</color>).",
            "Correct! <color=red>Lipids</color> are insoluble in aqueous solvents but <color=red>can be dissolved in organic solvents, such as chloroform</color>.",
            "Correct! <color=red>Cholesterol is one of the primary components of plasma membrane</color>, and can serve to fill gaps left by imperfect packing of lipids in a liposome.",
            "Correct! <color=red>Cholesterol is a molecule consisting of a bulky steroid structure</color> (remember the fused ring structure).",

            "Correct! Organic solvent is evaporated in the round bottom flask and travels to the chiller, where it is condensed on the coils and collected in the waste flask.",
            //Once the lipid thin film is formed, the next step is to hydrate the film using an aqueous medium. Take the round bottom flask over to the pipette and add aqueous media into the flask to initiate the hydration step. This will form the liposomes.",
            "",
            "Correct! Extrusion back and forth through membranes can reduce size of liposomes.",

            "Correct! <color=red>A monodispersed liposome system will exhibit a single, narrow peak on a particle size analyzer</color> indicating that the majority of liposomes fall within that size range.",
            "Correct! <color=red>Liposomes are too small to be seen by the naked eye</color> and are even too small to be viewed on a <color=red>traditional light microscope. Thus, electron microscopy is required</color> to visualize these particles."
        }; // YES

        private string[] feedback4 = {
            "Hint: Liposomes consist of a lipid bilayer structure. They look like cells in our body.",
            "",
            "Hint: A lipid looks like a surfactant molecule with long chain hydrocarbons (hydrophobic) and a hydrophilic part (e.g. phosphate head group).",
            "Hint: Lipids are insoluble in aqueous solvents.",
            "Hint: Basic components of plasma membrane are lipids such as phopholipids and cholesterol.",
            "Hint: Cholesterol is a molecule consisting of a bulky steroid structure.",

            "Hint: Organic solvent is evaporated in the round bottom flask and travels to the chiller, where it is condensed on the coils and collected in the waste flask.",
            "",
            "Hint: Extrusion back and forth through membranes can reduce the size of liposomes.",

            "Hint: Break down the name, mono = 1...",
            "Hint: Liposomes are considered colloidal disperse systems. What tools can be used to visualize colloidal disperse systems?"
            
        };

        private static bool randomOnce = true;
        //-------------------------------------------------
        private void Start()
        {
            /*if (randomOnce)
            {
                questionSet = UnityEngine.Random.Range(1, 3); //(min inclusive, max exclusive) integers
                randomOnce = false;
                Debug.Log("Random Once");
                Debug.Log($"QuestionSet = {questionSet}");
            }*/
            if (gameObject.CompareTag("RightExtrude") || gameObject.CompareTag("LeftExtrude"))
            {
                extrude = plungers.GetComponent<Animator>();
            }

            if (gameObject.CompareTag("introNext"))
            {
                if (questionSet == 1) // 1 for nanoparticle, 2 for lipid
                {
                    text.text = "Welcome to the Introduction to Nanotechnology Lab! For this experience, you will only need to use your mouse and keyboard. Please proceed by pointing the cursor at the 'Next' button below and left clicking on it.";
                    rotaryEvapLip.SetActive(false);
                    questionSet2Check.SetActive(false);
                }
                else
                {
                    text.text = "Welcome to the Introduction to Nanotechnology Lab! For this experience, you will only need to use your mouse and keyboard. Please proceed by pointing the cursor at the 'Next' button below and left clicking on it.";
                    probe_son.SetActive(false);
                    rotaryEvapNano.SetActive(false);
                    questionSet1Check.SetActive(false);
                    hydra_extru.SetActive(true);
                }
            }

            if (this.gameObject.name == "Intro Next")
            {
                Debug.Log("Get player name and full name");
                studentName = playerName.name;
                studentID = playerID.name;
                
            }

            //Text to speech 
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(Intro1, .7f);
            /*rend0 = GetComponent<Renderer>();
            rend0.enabled = true;
            rend0.sharedMaterial = material0;
            rend1 = GetComponent<Renderer>();
            rend1.enabled = true;
            rend1.sharedMaterial = material1;
            rend2 = GetComponent<Renderer>();
            rend2.enabled = true;
            rend2.sharedMaterial = material2;
            rend3 = GetComponent<Renderer>();
            rend3.enabled = true;
            rend3.sharedMaterial = material3;*/

        }


        void Awake()
        {
            var textMeshs = GetComponentsInChildren<TextMesh>();
            //generalText = textMeshs[0];
            //hoveringText = textMeshs[1];

            //generalText.text = "No Hand Hovering";
            //hoveringText.text = "Hovering: False";

            interactable = this.GetComponent<Interactable>();


        }


        //-------------------------------------------------
        // Called when a Hand starts hovering over this object
        //-------------------------------------------------
        /*private void OnHandHoverBegin( Hand hand )
		{
			generalText.text = "Hovering hand: " + hand.name;
		}


		//-------------------------------------------------
		// Called when a Hand stops hovering over this object
		//-------------------------------------------------
		private void OnHandHoverEnd( Hand hand )
		{
			generalText.text = "No Hand Hovering";
		}*/


        //-------------------------------------------------
        // Called every Update() while a Hand is hovering over this object
        //-------------------------------------------------
        private void HandHoverUpdate(Hand hand)
        {
            GrabTypes startingGrabType = hand.GetGrabStarting();
            bool isGrabEnding = hand.IsGrabEnding(this.gameObject);

            if (interactable.attachedToHand == null && startingGrabType != GrabTypes.None)
            {
                // Save our position/rotation so that we can restore it when we detach
                oldPosition = transform.position;
                oldRotation = transform.rotation;

                // Call this to continue receiving HandHoverUpdate messages,
                // and prevent the hand from hovering over anything else
                hand.HoverLock(interactable);

                // Attach this object to the hand
                hand.AttachObject(gameObject, startingGrabType, attachmentFlags);
                hand.DetachObject(gameObject);
            }
            /*
            else if (isGrabEnding)
            {
                // Detach this object from the hand
                hand.DetachObject(gameObject);

                // Call this to undo HoverLock
                hand.HoverUnlock(interactable);

                // Restore position/rotation
                transform.position = oldPosition;
                transform.rotation = oldRotation;
            }
            */
        }


        //-------------------------------------------------
        // Called when this GameObject becomes attached to the hand
        //-------------------------------------------------
        /*
		private void OnAttachedToHand( Hand hand )
        {
            generalText.text = string.Format("Attached: {0}", hand.name);
            attachTime = Time.time;
		}
        */

        //---------------------------
        // Randomizer Function
        // Takes as many answers as user wants, switches positions of answers
        //---------------------------
        private void randomizeAnswers(params GameObject[] objects)
        {
            System.Random random = new System.Random();
            var list = new ArrayList { };

            //Creates a list of positions of all the objects
            for (int aa = 0; aa < objects.Length; aa++)
            {
                list.Add(objects[aa].transform.localPosition);
            }

            //Chooses a random position from the list and deletes it while changing the position
            for (int bb = 0; bb < objects.Length; bb++)
            {
                int index = random.Next(list.Count);
                Vector3 tempPosition = (Vector3)list[index];
                list.RemoveAt(index);
                objects[bb].transform.localPosition = tempPosition;
            }
        }

        //-------------------------------------------------
        // Called when this GameObject is detached from the hand
        //-------------------------------------------------
        private void OnDetachedFromHand(Hand hand)
        {
            //generalText.text = string.Format("Detached: {0}", hand.name);
            //////////////////////////////////////////////////////////////////////
            /////Summary stuff
            if (CompareTag("nanoCheck"))
            {
                if (correct1.activeInHierarchy && correct2.activeInHierarchy && correct3.activeInHierarchy && correct4.activeInHierarchy)
                {
                    prog10.SetActive(true);
                    audioSource.PlayOneShot(nanoEnd, .7f);
                    nanoPicsAns.SetActive(false);
                    //nanoCheckBtn.SetActive(false);
                    nanoFinalTxt.GetComponent<TextMesh>().text = "Congratulations, you have completed the nanoparticles module! \nPress 'close' to exit the application.";
                    nanoCheckBtn.transform.localPosition = new Vector3(nanoCheckBtn.transform.localPosition.x, nanoCheckBtn.transform.localPosition.y, 50f);
                    reviewAttempts += 1;
                    Send();
                    closeAppButton.SetActive(true);
                    Debug.Log("Hey this works");
                }else
                {
                    reviewAttempts += 1;
                }

                //Check1
                if (correct1.activeInHierarchy)
                {
                    nanoCheckmark1.SetActive(true);
                }
                else
                {
                    nanoXmark1.SetActive(true);
                }

                //Check2
                if (correct2.activeInHierarchy)
                {
                    nanoCheckmark2.SetActive(true);
                }
                else
                {
                    nanoXmark2.SetActive(true);
                }

                //Check3
                if (correct3.activeInHierarchy)
                {
                    nanoCheckmark3.SetActive(true);
                }
                else
                {
                    nanoXmark3.SetActive(true);
                }

                //Check1
                if (correct4.activeInHierarchy)
                {
                    nanoCheckmark4.SetActive(true);
                }
                else
                {
                    nanoXmark4.SetActive(true);
                }



            }

            if (CompareTag("lipoCheck"))
            {
                if (correct1.activeInHierarchy && correct2.activeInHierarchy && correct3.activeInHierarchy && correct4.activeInHierarchy && correct5.activeInHierarchy)
                {
                    prog10.SetActive(true);
                    audioSource.PlayOneShot(lipoEnd, .7f);
                    lipoPicsAns.SetActive(false);
                    //lipoCheckBtn.SetActive(false);
                    lipoCheckBtn.transform.localPosition = new Vector3(lipoCheckBtn.transform.localPosition.x, lipoCheckBtn.transform.localPosition.y, 50f);
                    lipoFinalTxt.GetComponent<TextMesh>().text = "Congratulations, you have completed the liposomes module! \nPress 'close' to exit the application.";
                    reviewAttempts += 1;
                    Send();
                    closeAppButton.SetActive(true);
                    Debug.Log("Hey this works");
                }
                else
                {
                    reviewAttempts += 1;
                }

                //Check1
                if (correct1.activeInHierarchy)
                {
                    lipoCheckmark1.SetActive(true);
                }
                else
                {
                    lipoXmark1.SetActive(true);
                }

                //Check2
                if (correct2.activeInHierarchy)
                {
                    lipoCheckmark2.SetActive(true);
                }
                else
                {
                    lipoXmark2.SetActive(true);
                }

                //Check3
                if (correct3.activeInHierarchy)
                {
                    lipoCheckmark3.SetActive(true);
                }
                else
                {
                    lipoXmark3.SetActive(true);
                }

                //Check4
                if (correct4.activeInHierarchy)
                {
                    lipoCheckmark4.SetActive(true);
                }
                else
                {
                    lipoXmark4.SetActive(true);
                }

                //Check5
                if (correct5.activeInHierarchy)
                {
                    lipoCheckmark5.SetActive(true);
                }
                else
                {
                    lipoXmark5.SetActive(true);
                }
            }

            if (CompareTag("Close"))
            {
                /*if (questionSet == 1)
                {
                    questionSet = 2;
                }
                else
                {
                    questionSet = 1;
                }*/
                //SceneManager.LoadScene("Test 1");
                Debug.Log("no");
                Application.Quit();
            }


            /////////////////////////////////////////////////////////////////
            // Used for the intro text
            if (CompareTag("introNext"))
            {
                /*
                if (questionSet == 1)
                {
                    nanoSummaryRoom.SetActive(true);
                }
                else if (questionSet == 2)
                {
                    lipoSummaryRoom.SetActive(true);
                }
                */
                if (questionSet == 1)
                {
                    text.text = introNano[++introCounter];
                } else
                {
                    text.text = introLip[++introCounter];
                }
                if (introCounter == 1)
                {

                    audioSource.Stop();
                    audioSource.PlayOneShot(Intro1_2, .7f); //play audio
                    tutorial_cube.SetActive(true);
                    //introNext.transform.localPosition = new Vector3(0, 0, .5f);
                }
                if (introCounter == 2)
                {
                    //controller_diagram.SetActive(false);
                    tutorial_cube.SetActive(false);
                    audioSource.Stop();
                    audioSource.PlayOneShot(Intro59, .7f); //play audio

                }
                if (introCounter == 3)
                {

                    audioSource.Stop();
                    audioSource.PlayOneShot(Intro2, .7f);
                }
                if (introCounter == 4)
                {
                    if (questionSet == 1)
                    {
                        //Nano
                        audioSource.Stop();
                        audioSource.PlayOneShot(Intro3, .7f);
                    } else
                    {
                        //Lipo
                        audioSource.Stop();
                        audioSource.PlayOneShot(Intro33, .7f);
                    }

                }
                if (introCounter == 5)
                {
                    audioSource.Stop();
                    audioSource.PlayOneShot(Transition, .7f);
                    text.text = "Move to the next board.";
                    startIntro.SetActive(true);
                    arrowIntro.SetActive(true);
                    introNext.transform.localPosition = new Vector3(25, 0, 0);
                }
            }

            if (CompareTag("StartIntro"))
            {
                if (questionSet == 1)
                {
                    introNext.GetComponent<AudioSource>().Stop();
                    audioSource.PlayOneShot(Nano1, .7f);
                    text2.text = "";
                    text.text = "Today, we will practice producing nanoparticles via an emulsion-solvent evaporation method.";
                } else
                {
                    introNext.GetComponent<AudioSource>().Stop();
                    audioSource.PlayOneShot(LipoTransition1, .7f);
                    text2.text = "";
                    text.text = "Today, we will practice producing liposomes via a thin-film hydration method, which is common for hydrophobic compounds such as chemotherapeutics.";
                }
                start.SetActive(true);
                arrowIntro.SetActive(false);
                startIntro.transform.localPosition = new Vector3(0, -25, 0);
            }

            // "Start", "Start2", and "Start3" are all used for the nanoparticle and liposome questions (question set 1)
            if (CompareTag("Start"))
            {
                introNext.SetActive(false);
                if (questionSet == 1)
                {
                    //Question 1 PLGA Nanoparticle
                    text.text = questionsNano1[i];
                    //text2.text = "";
                    /*ans_set1 = true;
                    startTime = Time.time;*/
                    ans0.SetActive(true);
                    ans1.SetActive(true);
                    ans2.SetActive(true);
                    ans3.SetActive(true);
                    startIntro.GetComponent<AudioSource>().Stop();
                    audioSource.PlayOneShot(Nano1, .7f);
                }
                else
                {
                    //Question 1 Liposome
                    text.text = questionsLip[i];
                    text2.text = "";
                    /*ans_set1 = true;
                    startTime = Time.time;*/
                    ans33.SetActive(true);
                    ans34.SetActive(true);
                    ans35.SetActive(true);
                    ans36.SetActive(true);
                    startIntro.GetComponent<AudioSource>().Stop();
                    audioSource.PlayOneShot(Lipo1, .7f);
                }

                q1_key.SetActive(true);
                //gameObject.SetActive(false);
                gameObject.transform.localPosition = new Vector3(0, -1, -10);
                //RandomSet.randomSet();
            }
            if (CompareTag("Start2"))
            {
                // Question 6 (same for both modules)
                if (questionSet == 1)
                {
                    text.text = questionsNano1[++i];
                    nanoRotFlask.GetComponent<AudioSource>().Stop();
                    audioSource.PlayOneShot(Nano6, .7f);
                }
                else
                {
                    text.text = questionsLip[++i];
                    lipoRotFlask.GetComponent<AudioSource>().Stop();
                    audioSource.PlayOneShot(Lipo6, .7f);
                    //ans53check.SetActive(true);
                }
                ans20.SetActive(true);
                ans21.SetActive(true);
                ans22.SetActive(true);
                /*ans_set7 = true;
                startTime = Time.time;*/
                ans23check.SetActive(true);
                diagram.SetActive(true);

                gameObject.transform.localPosition = new Vector3(0, -1, -11);
                //gameObject.SetActive(false);
            }
            if (CompareTag("Start3"))
            {
                if (questionSet == 1) // Question 7 for nanoparticle
                {
                    text.text = questionsNano1[++i];
                    ans24.SetActive(true);
                    ans25.SetActive(true);
                    //ans26.SetActive(true);
                    //ans27.SetActive(true);
                    /*ans_set8 = true;
                    startTime = Time.time;*/
                    stopLid.GetComponent<AudioSource>().Stop();
                    audioSource.PlayOneShot(Nano7, .7f);
                }
                else
                {
                    text.text = questionsLip[++i]; // Question 8 for liposome
                    ans56.SetActive(true);
                    ans57.SetActive(true);
                    /*ans_set9 = true;
                    startTime = Time.time;*/
                    stopLid.GetComponent<AudioSource>().Stop();
                    audioSource.PlayOneShot(Lipo8, .7f);
                }

                gameObject.transform.localPosition = new Vector3(10, 0, -1);
                //gameObject.SetActive(false);
            }



            if (CompareTag("Yes"))
            {

                text.text = feedback1[i];
                Vector3 temp = new Vector3(7.0f, 14.0f, 0);
                if (pressed == false)
                {
                    Next.transform.position += temp;
                    pressed = true;
                }
                Debug.Log(i);
                /*
                if (a == 1)
                {
                    audioSource.PlayOneShot(pop, 1f);
                    audioSource.PlayOneShot(msg, 1f);
                    playAudio.stopMethyl = true;

                };

                
                //If audio of 1000x msg is playing then cant trigger next line
                a = 2;
                textMesh.text = "The addition of a methyl allows" + "\n" + "MTX to bind to the enzyme with" + "\n" + "<color=lime>greater</color> affinity!";
                //textMesh.text = "The methyl and 180° ring rotation" + "\n" + "allows MTX to bind to the enzyme" + "\n" + "with <color=lime>1000X</color> greater affinity!"; //+ hand.name;
                transform.GetChild(10).gameObject.SetActive(true);
                */
            }
            if (CompareTag("No"))
            {
                text.text = feedback2[i];
                Vector3 temp = new Vector3(7.0f, 14.0f, 0);
                if (pressed == false)
                {
                    Next.transform.position += temp;
                    pressed = true;
                }
                Debug.Log(i);
            }

            if (CompareTag("Next")) // Used for questions 1-5 for both modules
            {
                // Changes question on board from q1 to q2
                if (questionSet == 1)
                {
                    text.text = questionsNano1[++i];
                }
                else
                {
                    text.text = questionsLip[++i];
                }

                ++z;
                //Vector3 temp = new Vector3(7.0f, 0, 0);
                Vector3 temp = new Vector3(0, 14.0f, 7.0f);

                //Next.transform.position -= temp;
                pressed = false;
                counter++;
                Debug.Log("Counter = " + counter);

                if (counter == 1) // Transition
                {
                    if (questionSet == 1) // nanoparticle
                    {
                        ans0.SetActive(false);
                        ans1.SetActive(false);
                        ans2.SetActive(false);
                        ans3.SetActive(false);
                        //startTime = Time.time;
                        //Debug.Log("Where am I???");
                        start.GetComponent<AudioSource>().Stop();
                        audioSource.Stop();
                        audioSource.PlayOneShot(NanoBetweenQ1Q2, .7f);
                        prog1.SetActive(true);
                        //audioSource.PlayOneShot(Nano2, .7f);
                    }
                    else // liposome
                    {
                        ans33.SetActive(false);
                        ans34.SetActive(false);
                        ans35.SetActive(false);
                        ans36.SetActive(false);
                        //startTime = Time.time;
                        start.GetComponent<AudioSource>().Stop();
                        audioSource.Stop();
                        audioSource.PlayOneShot(LipoBetweenQ1Q2, .7f);
                        prog1.SetActive(true);
                        //audioSource.PlayOneShot(Lipo2, .7f);
                    }
                }
                if (counter == 2) //question 2
                {
                    Next.transform.position -= temp;
                    if (questionSet == 1) // nanoparticle
                    {
                        /*ans0.SetActive(false);
                        ans1.SetActive(false);
                        ans2.SetActive(false);
                        ans3.SetActive(false);*/
                        ans4.SetActive(true);
                        ans5.SetActive(true);
                        ans6.SetActive(true);
                        ans7.SetActive(true);
                        /*ans_set2 = true;
                        startTime = Time.time;*/
                        Debug.Log("Who????");
                        randomizeAnswers(ans4, ans5, ans6, ans7);
                        start.GetComponent<AudioSource>().Stop();
                        audioSource.Stop();
                        audioSource.PlayOneShot(Nano2, .7f);
                    }
                    else // liposome
                    {
                        /*ans33.SetActive(false);
                        ans34.SetActive(false);
                        ans35.SetActive(false);
                        ans36.SetActive(false);*/
                        ans37.SetActive(true);
                        ans38.SetActive(true);
                        ans39.SetActive(true);
                        ans40.SetActive(true);
                        /*ans_set2 = true;
                        startTime = Time.time;*/
                        randomizeAnswers(ans37, ans38, ans39, ans40);
                        start.GetComponent<AudioSource>().Stop();
                        audioSource.Stop();
                        audioSource.PlayOneShot(Lipo2, .7f);
                    }
                    prog2.SetActive(true);
                }
                if (counter == 3) // question 3
                {
                    Next.transform.position -= temp;
                    if (questionSet == 1) // nanoparticle
                    {
                        ans4.SetActive(false);
                        ans5.SetActive(false);
                        ans6.SetActive(false);
                        ans7.SetActive(false);
                        ans8.SetActive(true);
                        ans9.SetActive(true);
                        ans10.SetActive(true);
                        ans11.SetActive(true);
                        /*ans_set3 = true;
                        startTime = Time.time;*/
                        randomizeAnswers(ans8, ans9, ans10, ans11);
                        audioSource.Stop();
                        audioSource.PlayOneShot(Nano3, .7f);
                    }
                    else // liposome
                    {
                        //q4_key.SetActive(true);
                        audioSource.Stop();
                        audioSource.PlayOneShot(Lipo3, .7f);
                        ans37.SetActive(false);
                        ans38.SetActive(false);
                        ans39.SetActive(false);
                        ans40.SetActive(false);
                        ans41.SetActive(true);
                        ans42.SetActive(true);
                        ans43.SetActive(true);
                        ans44.SetActive(true);
                        /*ans_set3 = true;
                        startTime = Time.time;*/
                        randomizeAnswers(ans41, ans42, ans43, ans44);
                    }
                    prog3.SetActive(true);
                }
                if (counter == 4) // question 4
                {
                    Next.transform.position -= temp;
                    if (questionSet == 1) // nanoparticle
                    {
                        ans8.SetActive(false);
                        ans9.SetActive(false);
                        ans10.SetActive(false);
                        ans11.SetActive(false);
                        ans12.SetActive(true);
                        ans13.SetActive(true);
                        ans14.SetActive(true);
                        ans15.SetActive(true);
                        /*ans_set4 = true;
                        startTime = Time.time;*/
                        randomizeAnswers(ans12, ans13, ans14, ans15);
                        q4_key.SetActive(true);
                        audioSource.Stop();
                        audioSource.PlayOneShot(Nano4, .7f);
                    }
                    else // liposome
                    {
                        ans41.SetActive(false);
                        ans42.SetActive(false);
                        ans43.SetActive(false);
                        ans44.SetActive(false);
                        ans45.SetActive(true);
                        ans46.SetActive(true);
                        ans47.SetActive(true);
                        ans48.SetActive(true);
                        /*ans_set4 = true;
                        startTime = Time.time;*/
                        randomizeAnswers(ans45, ans46, ans47, ans48);
                        audioSource.Stop();
                        audioSource.PlayOneShot(Lipo4, .7f);
                    }
                    prog4.SetActive(true);
                }
                if (counter == 5) // question 5
                {
                    Next.transform.position -= temp;
                    if (questionSet == 1) // nanoparticle
                    {
                        ans12.SetActive(false);
                        ans13.SetActive(false);
                        ans14.SetActive(false);
                        ans15.SetActive(false);
                        ans16.SetActive(true);
                        ans17.SetActive(true);
                        ans18.SetActive(true);
                        ans19.SetActive(true);
                        /*ans_set5 = true;
                        startTime = Time.time;*/
                        randomizeAnswers(ans16, ans17, ans18, ans19);
                        audioSource.Stop();
                        audioSource.PlayOneShot(Nano5, .7f);
                    }
                    else // liposome
                    {
                        ans45.SetActive(false);
                        ans46.SetActive(false);
                        ans47.SetActive(false);
                        ans48.SetActive(false);
                        ans49.SetActive(true);
                        ans50.SetActive(true);
                        ans51.SetActive(true);
                        ans52.SetActive(true);
                        /*ans_set5 = true;
                        startTime = Time.time;*/
                        randomizeAnswers(ans49, ans50, ans51, ans52);
                        audioSource.Stop();
                        audioSource.PlayOneShot(Lipo5, .7f);
                    }
                    prog5.SetActive(true);
                }
                if (counter == 6) // move to next board. Sets start2 active (middle board)
                {
                    Next.transform.position -= temp;
                    if (questionSet == 1)
                    {
                        ans16.SetActive(false);
                        ans17.SetActive(false);
                        ans18.SetActive(false);
                        ans19.SetActive(false);
                        mixture.SetActive(true);
                        nanoMat.SetActive(true);
                        audioSource.Stop();
                        audioSource.PlayOneShot(NanoTransition1, .7f);
                    }
                    else
                    {
                        ans49.SetActive(false);
                        ans50.SetActive(false);
                        ans51.SetActive(false);
                        ans52.SetActive(false);
                        grabBeaker.SetActive(true);
                        lipMat.SetActive(true);
                        audioSource.Stop();
                        audioSource.PlayOneShot(LipoTransition2, .7f);

                    }

                    start2.SetActive(true);
                    start2.transform.localPosition = new Vector3(start2.transform.localPosition.x, -10f, start2.transform.localPosition.z);
                    /*ans20.SetActive(true);
                    ans21.SetActive(true);
                    ans22.SetActive(true);
                    ans23.SetActive(true);*/
                }

                if (pressed == true)
                {
                    
                }
            }

            // Used for the middle board. 
            // For nanoparticle, it changes from question 6 in the middle, to question 7 on the 3rd board.
            // For liposome, it changes from question 6 in the middle, to question 7 also in the middle.
            if (CompareTag("Next2"))
            {
                // Changes question text displayed on the board
                if (questionSet == 1)
                {
                    text.text = questionsNano1[++i];
                }
                else
                {
                    text.text = questionsLip[++i];
                }

                ++z;
                Vector3 temp = new Vector3(7.0f, 14.0f, 0);
                //Vector3 temp = new Vector3(0, 0, 7.0f);

                
                pressed = false;
                counter++;
                Debug.Log("Counter = " + counter);
                if (counter == 7) // Question 6
                {
                    if (questionSet == 1)
                    {
                        // removes question 6 for nanoparticle and sets start3 active on 3rd board
                        Next2.transform.position -= temp;
                        start3.SetActive(true);
                        start3.transform.localPosition = new Vector3(start3.transform.localPosition.x, -10f, start3.transform.localPosition.z);
                        grabFlaskNano.SetActive(true);
                        rotFlaskNano.SetActive(false);
                        waterNano.SetActive(false);
                        soluteNano.SetActive(false);
                        nanoDroplet.SetActive(false);
                        ans20.SetActive(false);
                        ans21.SetActive(false);
                        ans22.SetActive(false);
                        ans23check.SetActive(false);
                        arrow.SetActive(false);
                        rotationArrow.SetActive(false);
                        label_arrows.SetActive(false);
                        diagram.SetActive(false);
                        start2.GetComponent<AudioSource>().Stop();
                        audioSource.PlayOneShot(NanoTransition6, .7f);
                    }
                    else
                    {
                        Next2.transform.position -= temp;

                        // question 7 Liposome only (middle)

                        /*ans50.SetActive(true);
                        ans51.SetActive(true);
                        ans52.SetActive(true);*/
                        /*ans_set7 = true;
                        startTime = Time.time;*/
                        correct_once_the.GetComponent<AudioSource>().Stop();
                        audioSource.PlayOneShot(LipoTransition3, .7f);
                        hydra_arrow.SetActive(true);
                        hydra_flask_placement.SetActive(true);
                        //audioSource.PlayOneShot(Lipo7, .7f);
                    }


                    //diagram.SetActive(false);

                    //grabFlask.SetActive(true);

                    /*ans24.SetActive(true);
                    ans25.SetActive(true);
                    ans26.SetActive(true);
                    ans27.SetActive(true);*/

                }
                if (questionSet != 1) // Liposome only
                {
                    Next2.transform.position -= temp;
                    // Removes question 7 and sets start3 active on 3rd board
                    if (counter == 8)
                    {
                        
                        ans50.SetActive(true);
                        ans51.SetActive(true);
                        ans52.SetActive(true);
                        /*ans_set8 = true;
                        startTime = Time.time;*/
                        audioSource.PlayOneShot(Lipo7, .7f);
                    }
                    if (counter == 9)
                    {
                        ans50.SetActive(false);
                        ans51.SetActive(false);
                        ans52.SetActive(false);
                        start3.SetActive(true);
                        start3.transform.localPosition = new Vector3(start3.transform.localPosition.x, -10f, start3.transform.localPosition.z);
                        //hydra_arrow.SetActive(true);

                        //ans_set9 = true;
                        //startTime = Time.time;

                        audioSource.Stop();
                        audioSource.PlayOneShot(LipoTransition4, .7f);

                        hydra_flask_temp.SetActive(false);
                        hydra_grabFlask.SetActive(true);
                        extrude_arrow1.SetActive(true);
                        extrude_flask_placement.SetActive(true);
                    }
                }
                /*if (counter == 7) // question 8 PLGA NA
                {
                    ans24.SetActive(false);
                    ans25.SetActive(false);
                    ans26.SetActive(false);
                    ans27.SetActive(false);
                    ans28.SetActive(true);
                    ans29.SetActive(true);
                    ans30.SetActive(true);
                    ans31.SetActive(true);
                }
                if (counter == 8) // question 8 PLGA NA
                {
                    ans28.SetActive(false);
                    ans29.SetActive(false);
                    ans30.SetActive(false);
                    ans31.SetActive(false);
                    ans32.SetActive(true);
                    ans33.SetActive(true);
                    ans34.SetActive(true);
                    ans35.SetActive(true);

                }*/
                prog6.SetActive(true);
            }

            if (CompareTag("Next3"))
            {

                if (questionSet == 1)
                {
                    // Changes question text from question 7 to 8, and then 8 to 9 (nanoparticle)
                    text.text = questionsNano1[++i];
                }
                else
                {
                    // Changes question text from question 8 to 9 (liposome)
                    text.text = questionsLip[++i];
                }

                ++z;
                //Vector3 temp = new Vector3(7.0f, 0, 0);
                Vector3 temp = new Vector3(0, -14f, 7.0f);
                if (pressed == true)
                {
                    Next3.transform.position += temp;
                    pressed = false;
                    counter++;
                    Debug.Log("Counter = " + counter);
                    /*if (questionSet == 1)
                    {
                        if (counter == 7) // question 8 PLGA NA
                        {
                            ans24.SetActive(false);
                            ans25.SetActive(false);
                            ans26.SetActive(false);
                            ans27.SetActive(false);
                            ans28.SetActive(true);
                            ans29.SetActive(true);
                            //ans30.SetActive(true);
                            //ans31.SetActive(true);
                        }
                        if (counter ==)
                    } else
                    {
                        if (counter == 8) // question 9 Liposome
                        {
                            ans53.SetActive(false);
                            ans54.SetActive(false);
                            ans55.SetActive(false);
                            ans56.SetActive(false);
                            ans57.SetActive(true);
                            ans58.SetActive(true);
                        }
                    }*/

                    if (counter == 8) // Question 8
                    {
                        if (questionSet == 1) // Nanoparticle only
                        {
                            ans24.SetActive(false);
                            ans25.SetActive(false);
                            ans26.SetActive(true);
                            ans27.SetActive(true);
                            ans28.SetActive(true);
                            /*ans_set9 = true;
                            startTime = Time.time;*/
                            randomizeAnswers(ans26, ans27, ans28);
                            //ans29.SetActive(true);
                            start3.GetComponent<AudioSource>().Stop();
                            audioSource.PlayOneShot(Nano8, .7f);
                        }
                        prog7.SetActive(true);
                    }
                    if (counter == 9) // Question 9
                    {
                        if (questionSet == 1) // nanoparticle only
                        {
                            ans26.SetActive(false);
                            ans27.SetActive(false);
                            ans28.SetActive(false);
                            ans29.SetActive(true);
                            ans30.SetActive(true);
                            ans31.SetActive(true);
                            /*ans_set10 = true;
                            startTime = Time.time;*/
                            randomizeAnswers(ans29, ans30, ans31);
                            audioSource.Stop();
                            audioSource.PlayOneShot(Nano9, .7f);
                        }
                        /*else // liposome
                        {
                            ans56.SetActive(false);
                            ans57.SetActive(false);
                            ans58.SetActive(true);
                            ans59.SetActive(true);
                            ans60.SetActive(true);
                            start3.GetComponent<AudioSource>().Stop();
                            audioSource.PlayOneShot(Lipo9, .7f);
                        }*/
                        prog8.SetActive(true);
                    }
                    if (counter == 10) 
                    {
                        if (questionSet == 1) // nanoparticle summary text
                        {
                            ans29.SetActive(false);
                            ans30.SetActive(false);
                            ans31.SetActive(false);
                            audioSource.Stop();
                            audioSource.PlayOneShot(NanoSummary, .7f);

                        }
                        if (questionSet == 2) // Liposome final question
                        {
                            ans56.SetActive(false);
                            ans57.SetActive(false);
                            ans58.SetActive(true);
                            ans59.SetActive(true);
                            ans60.SetActive(true);
                            /*ans_set10 = true;
                            startTime = Time.time;*/
                            randomizeAnswers(ans58, ans59, ans60);
                            start3.GetComponent<AudioSource>().Stop();
                            audioSource.PlayOneShot(Lipo9, .7f);
                        }
                        prog9.SetActive(true);
                    }
                    if (counter == 11)  // Liposome summary text
                    {
                        ans58.SetActive(false);
                        ans59.SetActive(false);
                        ans60.SetActive(false);
                        audioSource.Stop();
                        audioSource.PlayOneShot(LipoSummary, .7f);
                        prog9.SetActive(true);
                    }
                    /*if (counter == 8) // question 8 PLGA NA
                    {
                        ans28.SetActive(false);
                        ans29.SetActive(false);
                        ans30.SetActive(false);
                        ans31.SetActive(false);
                        ans32.SetActive(true);
                        ans33.SetActive(true);
                        ans34.SetActive(true);
                        ans35.SetActive(true);

                    }*/
                }
            }

            if (CompareTag("ans0") || CompareTag("ans1") || CompareTag("ans2") || CompareTag("ans3"))
            {

                if (pressed == false)
                {
                    //text.text = feedback1[i];
                    //Vector3 temp = new Vector3(7.0f, 0, 0);

                    /*Vector3 temp = new Vector3(0, 14.0f, 7.0f);
                    Vector3 temp2 = new Vector3(7.0f, 14.0f, 0);
                    Vector3 temp3 = new Vector3(0, 14.0f, -7.0f);*/

                    //pressed = true;
                    //nanoparticle.GetComponent<MeshRenderer>().material = material1;
                    if (counter == 0) // question 1
                    {
                        if (questionSet == 1)
                        {
                            if (CompareTag("ans2"))
                            {
                                text.text = feedback1[i];
                                q1_key.SetActive(false);
                                ans_set1 = true;
                                startTime = Time.time;
                                //Next.transform.position += temp;
                                pressed = true;
                                start.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(NanoCorrect1, .7f);
                                Debug.Log("Is thisa wokring????");
                                Debug.Log(Q1);
                                Q1 += 1;
                                //Send();

                            }
                            else
                            {
                                text.text = feedback2[i];
                                Q1 += 1;
                            }
                        }
                        else
                        {
                            if (CompareTag("ans0"))
                            {
                                text.text = feedback3[i];
                                q1_key.SetActive(false);
                                ans_set1 = true;
                                startTime = Time.time;
                                //Next.transform.position += temp;
                                pressed = true;
                                start.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(LipoCorrect1, .7f);
                                Q1 += 1;
                                //Send();
                            }
                            else
                            {
                                text.text = feedback4[i];
                                Q1 += 1;
                            }
                        }

                    }
                    else if (counter == 2) // question 2
                    {
                        if (questionSet == 1)
                        {
                            if (CompareTag("ans0"))
                            {
                                text.text = feedback1[i];
                                ans_set2 = true;
                                startTime = Time.time;
                                //Next.transform.position += temp;
                                pressed = true;
                                Next.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(NanoCorrect2, .7f);
                                Q2 += 1;
                                //Send();
                            }
                            else
                            {
                                text.text = feedback2[i];
                                Q2 += 1;
                            }
                        }
                        else
                        {
                            if (CompareTag("ans2"))
                            {
                                text.text = feedback3[i];
                                ans_set2 = true;
                                startTime = Time.time;
                                //Next.transform.position += temp;
                                pressed = true;
                                Next.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(LipoCorrect2, .7f);
                                Q2 += 1;
                                //Send();
                            }
                            else
                            {
                                text.text = feedback4[i];
                                Q2 += 1;
                            }
                        }

                    }
                    else if (counter == 3) // question 3
                    {
                        if (questionSet == 1)
                        {
                            if (CompareTag("ans1"))
                            {
                                text.text = feedback1[i];
                                ans_set3 = true;
                                startTime = Time.time;
                                //Next.transform.position += temp;
                                pressed = true;
                                Next.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(NanoCorrect3, .7f);
                                Q3 += 1;
                                //Send();
                            }
                            else
                            {
                                text.text = feedback2[i];
                                Q3 += 1;
                            }
                        }
                        else
                        {
                            if (CompareTag("ans3"))
                            {
                                text.text = feedback3[i];
                                //q4_key.SetActive(false);
                                ans_set3 = true;
                                startTime = Time.time;
                                //Next.transform.position += temp;
                                pressed = true;
                                Next.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(LipoCorrect3, .7f);
                                Q3 += 1;
                                //Send();
                            }
                            else
                            {
                                text.text = feedback4[i];
                                Q3 += 1;
                            }
                        }

                    }
                    else if (counter == 4) // question 4
                    {
                        if (questionSet == 1)
                        {
                            if (CompareTag("ans0"))
                            {
                                text.text = feedback1[i];
                                q4_key.SetActive(false);
                                ans_set4 = true;
                                startTime = Time.time;
                                //Next.transform.position += temp;
                                pressed = true;
                                Next.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(NanoCorrect4, .7f);
                                Q4 += 1;
                                //Send();
                            }
                            else
                            {
                                text.text = feedback2[i];
                                Q4 += 1;
                            }
                        }
                        else
                        {
                            if (CompareTag("ans1"))
                            {
                                text.text = feedback3[i];
                                ans_set4 = true;
                                startTime = Time.time;
                                //Next.transform.position += temp;
                                pressed = true;
                                Next.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(LipoCorrect4, .7f);
                                Q4 += 1;
                                //Send();
                            }
                            else
                            {
                                text.text = feedback4[i];
                                Q4 += 1;
                            }
                        }

                    }
                    else if (counter == 5) // question 5
                    {
                        if (questionSet == 1)
                        {
                            if (CompareTag("ans3"))
                            {
                                text.text = feedback1[i];
                                ans_set5 = true;
                                startTime = Time.time;
                                //Next.transform.position += temp;
                                pressed = true;
                                Next.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(NanoCorrect5, .7f);
                                Q5 += 1;
                                //Send();

                            }
                            else
                            {
                                text.text = feedback2[i];
                                Q5 += 1;
                            }
                        }
                        else
                        {
                            if (CompareTag("ans1"))
                            {
                                text.text = feedback3[i];
                                ans_set5 = true;
                                startTime = Time.time;
                                //Next.transform.position += temp;
                                pressed = true;
                                Next.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(LipoCorrect5, .7f);
                                Q5 += 1;
                                //Send();
                            }
                            else
                            {
                                text.text = feedback4[i];
                                Q5 += 1;
                            }
                        }

                    }
                    else if (counter == 6) // Question 6
                    {
                        if (CompareTag("ans3") && correctEvap.activeInHierarchy && correctCon.activeInHierarchy)
                        {
                            if (questionSet == 1)
                            {
                                text.text = feedback1[z];
                                ans_set6 = true;
                                startTime = Time.time;
                                //Next2.transform.position += temp2;
                                start2.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(NanoCorrect6, .7f);
                                Q6 += 1;
                                //Send();
                            } else
                            {
                                start2.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(LipoCorrect6, .7f);
                                text.text = feedback3[z];
                                Q6 += 1;
                                //Send();
                                //hydra_arrow.SetActive(true);
                                //hydra_flask_placement.SetActive(true);
                                ans20.SetActive(false);
                                ans21.SetActive(false);
                                ans22.SetActive(false);
                                soluteLipid.SetActive(false);
                                lipDroplet.SetActive(false);
                                arrow.SetActive(false);
                                rotationArrow.SetActive(false);
                                label_arrows.SetActive(false);
                                grabFlaskLip.SetActive(true);
                                rotFlaskLip.SetActive(false);
                                this.gameObject.transform.localPosition = new Vector3(-3, -10, 12); // Check Answer Button
                                ans_set6 = true;
                                startTime = Time.time;
                                //Next2.transform.position += temp2;
                                diagram.SetActive(false);
                            }
                            
                            
                            pressed = true;
                        }
                        else
                        {
                            if (questionSet == 1)
                            {
                                Q6 += 1;
                                text.text = feedback2[z];
                            } else
                            {
                                Q6 += 1;
                                text.text = feedback4[z];
                            }

                        }
                    }
                    else if (counter == 7) // Question 7 Nanoparticle only
                    {
                        if (questionSet == 1)
                        {
                            if (CompareTag("ans0"))
                            {
                                text.text = feedback1[z];
                                // For the Nanoparticle questions, question 7 is posed on the right blackboard. Therefore, it uses Next3 and temp3.
                                ans_set7 = true;
                                startTime = Time.time;
                                //Next3.transform.position += temp3;
                                pressed = true;
                                start3.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(NanoCorrect7, .7f);
                                Q7 += 1;
                                //Send();
                            }
                            else
                            {
                                Q7 += 1;
                                text.text = feedback2[z];
                            }
                        }
                        
                        /*else
                        {
                            if (CompareTag("ans1"))
                            {
                                text.text = feedback3[z];
                                // For the liposome questions, question 7 is posed on the middle blackboard. Therefore, it uses Next2 and temp2.
                                Next2.transform.position += temp2;
                                pressed = true;
                            }
                            else
                            {
                                text.text = feedback4[z];
                            }
                        }*/

                    }
                    else if (counter == 8) // Question 8 for nano, question 7 for liposome
                    {
                        if (questionSet == 1)
                        {
                            if (CompareTag("ans2"))
                            {
                                text.text = feedback1[z];
                                ans_set8 = true;
                                startTime = Time.time;
                                //Next3.transform.position += temp3;
                                pressed = true;
                                Next3.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(NanoCorrect8, .7f);
                                Q8 += 1;
                                //Send();
                            }
                            else
                            {
                                Q8 += 1;
                                text.text = feedback2[z];
                            }
                        }
                        else
                        {
                            if (CompareTag("ans1"))
                            {
                                text.text = feedback3[z];
                                // For the liposome questions, question 7 is posed on the middle blackboard. Therefore, it uses Next2 and temp2.
                                Debug.Log("ya yeet");
                                ans_set8 = true;
                                startTime = Time.time;
                                //Next2.transform.position += temp2;
                                Next2.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(LipoCorrect7, .7f);
                                pressed = true;
                                Q7 += 1;
                                //Send();
                            }
                            else
                            {
                                Q7 += 1;
                                text.text = feedback4[z];
                            }
                        }
                        /*else
                        {
                            if (CompareTag("ans0"))
                            {
                                text.text = feedback3[z];
                                Next3.transform.position += temp3;
                                pressed = true;
                            }
                            else
                            {
                                text.text = feedback4[z];
                            }
                        }*/

                    }
                    else if (counter == 9) // Question 9 for nano, question 8 for liposome
                    {
                        if (questionSet == 1)
                        {
                            if (CompareTag("ans0"))
                            {
                                text.text = feedback1[z];
                                ans_set9 = true;
                                startTime = Time.time;
                                //Next3.transform.position += temp3;
                                pressed = true;
                                Next3.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(NanoCorrect9, .7f);
                                Q9 += 1;
                                //Send();
                            }
                            else
                            {
                                Q9 += 1;
                                text.text = feedback2[z];
                            }
                        }
                        else
                        {
                            if (CompareTag("ans0"))
                            {
                                text.text = feedback3[z];
                                ans_set9 = true;
                                startTime = Time.time;
                                //Next3.transform.position += temp3;
                                start3.GetComponent<AudioSource>().Stop();
                                audioSource.PlayOneShot(LipoCorrect8, .7f);
                                pressed = true;
                                Q8 += 1;
                                //Send();
                            }
                            else
                            {
                                Q8 += 1;
                                text.text = feedback4[z];
                            }
                        }
                        /*else
                        {
                            if (CompareTag("ans2"))
                            {
                                text.text = feedback3[z];
                                //Next3.transform.position += temp3;
                                pressed = true;
                            }
                            else
                            {
                                text.text = feedback4[z];
                            }
                        }*/
                    }
                    else if (counter == 10) //Question 9 Liposome only
                    {
                        if (CompareTag("ans2"))
                        {
                            text.text = feedback3[z];
                            ans_set10 = true;
                            startTime = Time.time;
                            //Next3.transform.position += temp3;
                            pressed = true;
                            Next3.GetComponent<AudioSource>().Stop();
                            audioSource.PlayOneShot(LipoCorrect9, .7f);
                            Q9 += 1;
                            //Send();
                        }
                        else
                        {
                            Q9 += 1;
                            text.text = feedback4[z];
                        }
                    }
                }
            }
            /*if (CompareTag("ans1"))
            {
                if (pressed == false)
                {
                    text.text = feedback1[i];
                    Vector3 temp = new Vector3(7.0f, 0, 0);
                    Next.transform.position += temp;
                    pressed = true;
                    if (CompareTag("ans1"))
                    {

                    }
                }
            }*/
            /*if (CompareTag("ans2"))
            {
                
                if (pressed == false)
                {
                    text.text = feedback2[i];
                    Vector3 temp = new Vector3(7.0f, 0, 0);
                    Next.transform.position += temp;
                    pressed = true;
                }
            }*/
            if (CompareTag("LeftExtrude"))
            {
                if (extrude.GetBool("extrudeLeft") == false)
                {
                    extrude.SetBool("stopper", false);
                    extrude.SetBool("extrudeLeft", true);
                    extrude.SetBool("extrudeRight", false);
                    
                }
            }
            if (CompareTag("RightExtrude"))
            {
                if (extrude.GetBool("extrudeRight") == false)
                {
                    extrude.SetBool("stopper", true);
                    extrude.SetBool("extrudeRight", true);
                    extrude.SetBool("extrudeLeft", false);
                    
                }
            }
        }


        //-------------------------------------------------
        // Called every Update() while this GameObject is attached to the hand
        //-------------------------------------------------
        private void HandAttachedUpdate(Hand hand)
        {
            generalText.text = string.Format("Attached: {0} :: Time: {1:F2}", hand.name, (Time.time - attachTime));
        }

        private bool lastHovering = false;

        public object RandomSet { get; private set; }

        static float startTime;
        static bool beginTimer = false;
        static bool beginTeleport = false;

        // Used to move the next buttons in and out of sight when answering questions
        Vector3 temp = new Vector3(0, 14.0f, 7.0f);
        Vector3 temp2 = new Vector3(7.0f, 14.0f, 0);
        Vector3 temp3 = new Vector3(0, 14.0f, -7.0f);

        private void Update()
        {
            timer = Time.time;
            //timer = Time.time / 60.0f;

            if (ans_set1)
            {
                //Debug.Log("bruh moment");
                
                if (questionSet == 1)
                {
                    
                    if (Time.time - startTime > 5.4)
                    {
                        /*ans0.SetActive(true);
                        ans1.SetActive(true);
                        ans2.SetActive(true);
                        ans3.SetActive(true);*/
                        Next.transform.position += temp;
                        ans_set1 = false;
                    }
                    
                } else
                {
                    if (Time.time - startTime > 4)
                    {
                        /*ans33.SetActive(true);
                        ans34.SetActive(true);
                        ans35.SetActive(true);
                        ans36.SetActive(true);*/
                        Next.transform.position += temp;
                        ans_set1 = false;
                    }
                }
            }

            if (ans_set2)
            {
                //Debug.Log("bruh moment");

                if (questionSet == 1)
                {
                    
                    if (Time.time - startTime > 6.5)
                    {
                        /*ans4.SetActive(true);
                        ans5.SetActive(true);
                        ans6.SetActive(true);
                        ans7.SetActive(true);*/
                        Next.transform.position += temp;
                        ans_set2 = false;
                    }
                    
                } else
                {
                    if (Time.time - startTime > 6.3)
                    {
                        /*ans37.SetActive(true);
                        ans38.SetActive(true);
                        ans39.SetActive(true);
                        ans40.SetActive(true);*/
                        Next.transform.position += temp;
                        ans_set2 = false;
                    }
                }
            }

            if (ans_set3)
            {
                //Debug.Log("bruh moment");

                if (questionSet == 1)
                {
                    
                    if (Time.time - startTime > 7.3)
                    {
                        /*ans8.SetActive(true);
                        ans9.SetActive(true);
                        ans10.SetActive(true);
                        ans11.SetActive(true);*/
                        Next.transform.position += temp;
                        ans_set3 = false;
                    }

                } else
                {
                    if (Time.time - startTime > 5)
                    {
                        /*ans41.SetActive(true);
                        ans42.SetActive(true);
                        ans43.SetActive(true);
                        ans44.SetActive(true);*/
                        Next.transform.position += temp;
                        ans_set3 = false;
                    }
                }
                
            }

            if (ans_set4)
            {
                //Debug.Log("bruh moment");

                if (questionSet == 1)
                {
                    
                    if (Time.time - startTime > 6.6)
                    {
                        /*ans12.SetActive(true);
                        ans13.SetActive(true);
                        ans14.SetActive(true);
                        ans15.SetActive(true);*/
                        Next.transform.position += temp;
                        ans_set4 = false;
                    }
                    
                } else
                {
                    if (Time.time - startTime > 4.7)
                    {
                        /*ans45.SetActive(true);
                        ans46.SetActive(true);
                        ans47.SetActive(true);
                        ans48.SetActive(true);*/
                        Next.transform.position += temp;
                        ans_set4 = false;
                    }
                }
            }

            if (ans_set5)
            {
                //Debug.Log("bruh moment");

                if (questionSet == 1)
                {
                    
                    if (Time.time - startTime > 5)
                    {
                        /*ans16.SetActive(true);
                        ans17.SetActive(true);
                        ans18.SetActive(true);
                        ans19.SetActive(true);*/
                        Next.transform.position += temp;
                        ans_set5 = false;
                    }
                    
                } else
                {
                    if (Time.time - startTime > 5)
                    {
                        /*ans49.SetActive(true);
                        ans50.SetActive(true);
                        ans51.SetActive(true);
                        ans52.SetActive(true);*/
                        Next.transform.position += temp;
                        ans_set5 = false;
                    }
                }
            }

            if (ans_set6)
            {
                //Debug.Log("bruh moment");

                if (Time.time - startTime > 8.8)
                {
                    
                    if (questionSet == 1)
                    {
                        Next2.transform.position += temp2;
                        ans_set6 = false;
                    }
                    else
                    {
                        Next2.transform.position += temp2;
                        ans_set6 = false;
                    }
                }
            }

            //Nanoparticle only
            if (ans_set7)
            {
                if (Time.time - startTime > 6.7)
                {
                    /*ans50.SetActive(true);
                    ans51.SetActive(true);
                    ans52.SetActive(true);*/
                    Next3.transform.position += temp3;
                    ans_set7 = false;
                }
            }

            // Hydration Step Controller Script (Location in game objects: Hydration and Extrusion ---> Hydration Step)
            // After triggering hydration step animation, the Hydration Step Controller script moves next button back into view to proceed

            if (ans_set8)
            {
                //Debug.Log("bruh moment");

                if (questionSet == 1)
                {
                    
                    if (Time.time - startTime > 10)
                    {
                        /*ans24.SetActive(true);
                        ans25.SetActive(true);*/
                        Next3.transform.position += temp3;
                        ans_set8 = false;
                    }
                    
                } else
                {
                    if (Time.time - startTime > 5)
                    {
                        Debug.Log("ans_set8");
                        /*ans50.SetActive(true);
                        ans51.SetActive(true);
                        ans52.SetActive(true);*/
                        Next2.transform.position += temp2;
                        ans_set8 = false;
                    }
                }
            }

            if (ans_set9)
            {
                //Debug.Log("bruh moment");

                if (questionSet == 1)
                {
                    
                    if (Time.time - startTime > 6.5)
                    {
                        /*ans26.SetActive(true);
                        ans27.SetActive(true);
                        ans28.SetActive(true);*/
                        Next3.transform.position += temp3;
                        ans_set9 = false;
                    }
                    
                } else
                {
                    if (Time.time - startTime > 6.6)
                    {
                        /*ans50.SetActive(true);
                        ans51.SetActive(true);
                        ans52.SetActive(true);*/
                        /*ans56.SetActive(true);
                        ans57.SetActive(true);*/
                        Next3.transform.position += temp3;
                        ans_set9 = false;
                    }
                }
            }

            if (ans_set10)
            {
                //Debug.Log("bruh moment");

                if (questionSet == 1)
                {
                    // Not being used currently
                    /*if (Time.time - startTime > 3.5)
                    {
                        Debug.Log("what???");
                        //ans29.SetActive(true);
                        //ans30.SetActive(true);
                        //ans31.SetActive(true);
                        Next3.transform.position += temp3;
                        ans_set10 = false;
                    }*/
                } else
                {
                    if (Time.time - startTime > 8.6)
                    {
                        /*ans50.SetActive(true);
                        ans51.SetActive(true);
                        ans52.SetActive(true);*/
                        /*ans58.SetActive(true);
                        ans59.SetActive(true);
                        ans60.SetActive(true);*/
                        Next3.transform.position += temp3;
                        ans_set10 = false;
                    }
                }
            }


            //Debug.Log("This is updating");
            if (counter == 10 && questionSet == 1 && beginTimer == false) // Nano particle teleport
            {
                startTime = Time.time;
                beginTimer = true;
                beginTeleport = true;
            }

            if (counter == 11 && questionSet == 2 && beginTimer == false)
            {
                startTime = Time.time;
                beginTimer = true;
                beginTeleport = true;
            }

            if (beginTeleport == true)
            {
                if (Time.time - startTime > 10)
                {
                    if (questionSet == 1 && beginTeleport == true)
                    {
                        //-0.071, 0, -11.2
                        nanoSummaryRoom.SetActive(true);
                        playerOne.transform.localPosition = new Vector3(-0.071f, 0f, -11.2f);
                        playerOne.transform.localRotation = Quaternion.Euler(0, -90, 0);
                        beginTeleport = false;
                    }
                    if (questionSet == 2 && beginTeleport == true)
                    {
                        //-0.071, 0, 11.2
                        lipoSummaryRoom.SetActive(true);
                        playerOne.transform.localPosition = new Vector3(-0.071f, 0f, 11.2f);
                        playerOne.transform.localRotation = Quaternion.Euler(0, -90, 0);
                        beginTeleport = false;
                    }
                    beginTeleport = false;
                }

                /*if (interactable.isHovering != lastHovering) //save on the .tostrings a bit
                {
                    //hoveringText.text = string.Format("Hovering: {0}", interactable.isHovering);
                    //lastHovering = interactable.isHovering;
                }*/
            }
        }


        //-------------------------------------------------
        // Called when this attached GameObject becomes the primary attached object
        //-------------------------------------------------
        private void OnHandFocusAcquired(Hand hand)
        {
        }


        //-------------------------------------------------
        // Called when another attached GameObject becomes the primary attached object
        //-------------------------------------------------
        private void OnHandFocusLost(Hand hand)
        {
        }

        /////////////////////////
        /// Google Forms stuff
        ///////////////////////
        [SerializeField]
        private string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLSctM53YVz30c_8PhvZhcKoGgcbXguXAoPZKCKXlOmGSGFSi8w/formResponse";
        [SerializeField]
        private string BASE_URL2 = "https://docs.google.com/forms/u/4/d/e/1FAIpQLScMxq3HsDFXO43UbA7WqD31BPK69oZZODpVcMYh-8qHuul0zw/formResponse";
        private string username = "Testing";
        private string moduleName = "";
        private static int Q1 = 0;
        private static int Q2 = 0;
        private static int Q3 = 0;
        private static int Q4 = 0;
        private static int Q5 = 0;
        private static int Q6 = 0;
        private static int Q7 = 0;
        private static int Q8 = 0;
        private static int Q9 = 0;
        private static int reviewAttempts = 0;
        private static float timer = 0;
        private float minutes;
        private float seconds;
        
        // Search for FB_PUBLIC_LOAD_DATA_ in form page source to get entry numbers

        IEnumerator Post(string name,string ID, string module, string q1, string q2, string q3, string q4, string q5, string q6, string q7, string q8, string q9, string reviewAttempts, string time)
        {
            WWWForm form = new WWWForm();
            form.AddField("entry.366340186", name);
            form.AddField("entry.942251463", ID);
            form.AddField("entry.361052416", module);
            form.AddField("entry.883737994", q1);
            form.AddField("entry.296446737", q2);
            form.AddField("entry.1935886774", q3);
            form.AddField("entry.481566611", q4);
            form.AddField("entry.761130099", q5);
            form.AddField("entry.834776016", q6);
            form.AddField("entry.2049269877", q7);
            form.AddField("entry.2019657938", q8);
            form.AddField("entry.1297907797", q9);
            form.AddField("entry.37393190", reviewAttempts);
            form.AddField("entry.1943262967", time);

            byte[] rawData = form.data;
            WWW www = new WWW(BASE_URL, rawData);
            yield return www;
        }

        IEnumerator Post2(string username, string total, string time)
        {
            WWWForm form = new WWWForm();
            
            form.AddField("entry.385264777", username);
            form.AddField("entry.1761851046", total);
            form.AddField("entry.1111035753", time);

            byte[] rawData = form.data;
            WWW www = new WWW(BASE_URL2, rawData);
            yield return www;
        }


        public void Send()
        {
            if (questionSet == 1)
            {
                moduleName = "Nanoparticles";
            }
            else
            {
                moduleName = "Liposomes";
            }

            username = studentName;
            string ID = studentID;
            string q1 = Q1.ToString();
            string q2 = Q2.ToString();
            string q3 = Q3.ToString();
            string q4 = Q4.ToString();
            string q5 = Q5.ToString();
            string q6 = Q6.ToString();
            string q7 = Q7.ToString();
            string q8 = Q8.ToString();
            string q9 = Q9.ToString();
            string tries = reviewAttempts.ToString();

            minutes = (float)Math.Floor(timer / 60);
            seconds = (float)Math.Round(timer % 60, 2);
            string time = minutes.ToString() + "m " + seconds.ToString() + "s";
            //string time = timer.ToString("F2");

            StartCoroutine(Post(username, ID, moduleName, q1, q2, q3, q4, q5, q6, q7, q8, q9, tries, time));

            string username1 = studentName;
            string totalScore = (Q1 + Q2 + Q3 + Q4 + Q5 + Q6 + Q7 + Q8 + Q9 + reviewAttempts).ToString();
            Debug.Log(totalScore);
            Debug.Log(username);
            Debug.Log(ID);
            StartCoroutine(Post2(username1, totalScore, time));

        }

    }
}
