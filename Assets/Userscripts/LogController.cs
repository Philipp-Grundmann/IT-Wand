using UnityEngine;
using TMPro; // Für TextMeshPro
using System.IO; // Für Dateioperationen
using System.Threading.Tasks;
using UnityEngine.Networking;
public class LogReader : MonoBehaviour
{
    public TMP_Text logTextField; // Referenz zum TextMeshPro-Textfeld
    public string logFilePath; // Pfad zur Log-Datei relativ zu Resources

    private void LoadLog()
    {
        // Ressourcenpfad korrekt formatieren
        //string fullPath = Path.Combine(Application.streamingAssetsPath, logFilePath);
        string fullPath = System.IO.Path.Combine(Application.streamingAssetsPath, "filetoload.txt");
        Debug.Log(fullPath);
        Debug.Log(Application.streamingAssetsPath);

        // Prüfen, ob die Datei existiert
        if (File.Exists(fullPath))
        {
            // Log-Datei lesen
            string logContent = File.ReadAllText(fullPath);

            // Log-Inhalt im Textfeld anzeigen
            if (logTextField != null)
            {
                logTextField.text = logContent;
            }
            else
            {
                Debug.LogError("Textfeld für das Log fehlt! Bitte verknüpfen.");
            }
        }
        else
        {
            Debug.LogError($"Log-Datei nicht gefunden: {fullPath}");
        }
    }

    void Start(){
        ReadLog();
        LoadLogAndroid();
    }
    public void ReadLog()
    {
        // Log-Daten laden und anzeigen
        LoadLog();
    }


    
    async void LoadLogAndroid()
    {
        string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "Test-Log.txt");

        UnityWebRequest request = UnityWebRequest.Get(filePath);
        UnityWebRequestAsyncOperation operation = request.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log(request.downloadHandler.text);
            logTextField.text = request.downloadHandler.text;
        }
        else
        {
            Debug.LogError("Cannot load file at " + filePath);
        }
    }
}