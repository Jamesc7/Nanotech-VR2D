using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
#pragma warning disable 649

[CustomEditor(typeof(MyScriptableObjectScript))]
public class scoreboardData : Editor
{
    private UnityWebRequest _webRequest;

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("Update from GDrive"))
        {
            _webRequest = UnityWebRequest.Get("https://script.google.com/macros/s/AKfycbzi4BDE8bfH6gQB9TUCMth8mZUNpf8GFQdLrCtjaqrUv2RD7cXZ8TUiXoIhzI0DJ7YQmA/exec");
            _webRequest.SendWebRequest();

            EditorApplication.update += CheckForImportRequestEnd; // the only way to wait for a process to finish is with this
        }
    }

    private class GDocResponse // this class is used to parse the JSON
    {
        public int[] result;
    }

    public void CheckForImportRequestEnd()
    {
        if (_webRequest != null && _webRequest.isDone)
        {
            var result = JsonUtility.FromJson<GDocResponse>(_webRequest.downloadHandler.text);
            MyScriptableObjectScript myTarget = (MyScriptableObjectScript)target;
            myTarget.Value = result.result;
            EditorApplication.update -= CheckForImportRequestEnd;
            Repaint();
        }
    }
}