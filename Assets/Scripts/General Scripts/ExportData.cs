using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEditor;
using System.Text;
using UnityEngine.UI;

public class ExportData : MonoBehaviour {

    private static List<string[]> rowData = new List<string[]>();
    

    public static void Save(int timesGrabbed/*int[] itemsQuantity, string[] itemsName, float[]itemsPrice, float time, float tutorialTime, string donated, string origin, string destination*/)
    {
        //Debug.Log("HELLO EXPORT");
        /*Debug.Log("SAVE: " + tutorialTime);

        // Creating First row of titles manually..
        string[] rowDataTemp = new string[10];
        rowDataTemp[0] = "Date";
        rowDataTemp[1] = "Tutorial Time Spent";
        rowDataTemp[2] = "Time Spent";
        rowDataTemp[3] = "Quantity";
        rowDataTemp[4] = "Items";
        rowDataTemp[5] = "Price";
        rowDataTemp[6] = "Origin";
        rowDataTemp[7] = "Destination";
        rowDataTemp[8] = "Shipping Cost";
        rowDataTemp[9] = "Final Decision";
        rowData.Add(rowDataTemp);*/

        string[] rowDataTemp = new string[1];
        rowDataTemp[0] = "Times Grabbed";
        rowData.Add(rowDataTemp);
        Debug.Log(timesGrabbed);

        // You can add up the values in as many cells as you want.
        // Creates 4 cells
        for (int i = 0; i < 4; i++)
        {
            /*rowDataTemp = new string[10];
            rowDataTemp[0] = "" + System.DateTime.Now.ToString("MM/dd/yy//hh:mm"); 
            rowDataTemp[1] = "" + tutorialTime.ToString("f2");
            rowDataTemp[2] = "" + time.ToString("f2");
            rowDataTemp[3] = "" + itemsQuantity[i];
            rowDataTemp[4] = "" + itemsName[i];
            rowDataTemp[5] = "$" + itemsPrice[i];
            rowDataTemp[6] = "" + origin;
            rowDataTemp[7] = "" + destination;
            rowDataTemp[8] = "$" + 50;
            rowDataTemp[9] = donated;
            rowData.Add(rowDataTemp);*/
            rowDataTemp = new string[1];
            rowDataTemp[0] = "" + timesGrabbed;
            rowData.Add(rowDataTemp);
        }

        string[][] output = new string[rowData.Count][];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = rowData[i];
        }

        int length = output.GetLength(0);
        string delimiter = ",";

        StringBuilder sb = new StringBuilder();

        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));


        string filePath = getPath();
       
        //StreamWriter outStream = System.IO.File.CreateText(filePath);
        StreamWriter outStream = new StreamWriter(filePath, true); ;
        
        outStream.WriteLine(sb);
        
        outStream.Close();
        
    }

    // Following method is used to retrive the relative path as device platform
    private static string getPath()
    {
    #if UNITY_STANDALONE_WIN || UNITY_EDITOR
        try
        {
            if (!Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\NanotechData\\"))
            {
                Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\NanotechData\\");
            }

        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        return System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\NanotechData\\" + "test.csv";
    #endif

    }
}