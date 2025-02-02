using UnityEngine;

public class ShowObjectOnButtonClick : MonoBehaviour
{
    [Header("Object to Show")]
    [Tooltip("Das Objekt, das angezeigt werden soll.")]
    public GameObject objectToShow;

    public void OnButtonClicked() // MUSS public sein
    {
        if (objectToShow != null)
        {
            // Objekt anzeigen oder toggeln
            objectToShow.SetActive(!objectToShow.activeSelf);
        }
    }
}
