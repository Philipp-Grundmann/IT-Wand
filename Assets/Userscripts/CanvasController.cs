using UnityEngine;
using UnityEngine.UI; // Für UI-Elemente
using TMPro; // Falls du TextMeshPro verwendest

public class CanvasController : MonoBehaviour
{
    // Referenzen zu den UI-Elementen
    public TMP_Text Description;   // Textfeld für den Titel
    public TMP_Text Information;  // Textfeld für die Beschreibung
    public RawImage Picture;                // Bildfeld

    // Texte und Bilder für die Buttons
    [System.Serializable]
    public class CanvasContent
    {   
        public string Description;      // Der Titeltext
        public string Information;      // Der Beschreibungstext
        public Texture2D Image;         // Das Bild
    }

    public CanvasContent[] buttonContents; // Array für verschiedene Inhalte

    private void Start()
    {
        
        buttonContents = new CanvasContent[100]; //Göße des Speicherarrays

        buttonContents[0] = new CanvasContent
        {
            Description = "Gerät: PROmesh B8 Compact\r\nEinbauort: Anlage: xy\r\nSchaltschrank: za\r\nIP-Adresse: 10.0.10.1",
            Information = "Beschreibung: Dieser Switch verbindet SPS mit dem Cobot, der Endmontage.\r\nDer PROmesh B8 Compact bringt mit seinem kompakten Format neue Möglichkeiten für die Installation von Managed Switches. Er ist ideal für Orte mit wenig Platz und verbindet fortschrittliche Technologie mit einer platzsparenden Lösung.\r\nEingebaut am: 29.12.2024\r\nLetzte Wartung: 06.12.2024\r\nNächste Wartung: 08.12.2024.",
            Image = Resources.Load<Texture2D>("Assets/Web-server.png")
        };

        buttonContents[1] = new CanvasContent
        {
            Description = "Gerät: Printserver\r\nEinbauort: Serverraum 1\r\nGebäude: 3, Ebene 1\r\nIP-Adresse: 10.0.10.5",
            Information = "Über diesen Server werden alle Drucker der Firma an die Assets verteilt. \r\n Ein Print-Server ist eine zentrale Schnittstelle, die Druckaufträge von mehreren Geräten an einen oder mehrere Drucker im Netzwerk weiterleitet und verwaltet. Er optimiert den Druckprozess durch Warteschlangenmanagement, Zugriffskontrolle und Treiberbereitstellung. Dies erleichtert die effiziente und sichere Nutzung von Druckressourcen in Unternehmen oder Netzwerken.",
            Image = Resources.Load<Texture2D>("Images/Image2")
        };

        buttonContents[2] = new CanvasContent
        {
            Description = "Gerät: Jump-Server       \r\nEinbauort:      \r\nGebäude:        \r\nIP-Adresse: ",
            Information = "Ein Jump-Server (auch Jump-Host) ist ein speziell abgesichertes System, das als Zwischenstation dient, um den Zugriff auf Server in einem geschützten Netzwerk zu ermöglichen.",
            Image = Resources.Load<Texture2D>("Images/Image2")
        };

        buttonContents[3] = new CanvasContent
        {
            Description = "Gerät: Mail-Server      \r\nEinbauort:      \r\nGebäude:        \r\nIP-Adresse: ",
            Information = "Ein Mail-Server ist ein System, das E-Mails sendet, empfängt und speichert. Er nutzt Protokolle wie SMTP (Senden), IMAP oder POP3 (Empfangen), um den E-Mail-Verkehr zwischen Sendern, Empfängern und deren Clients zu ermöglichen.",
            Image = Resources.Load<Texture2D>("Images/Image2")
        };

        buttonContents[4] = new CanvasContent
        {
            Description = "Gerät: DNS-Server       \r\nEinbauort:      \r\nGebäude:        \r\nIP-Adresse:",
            Information = "Ein DNS-Server übersetzt Domainnamen (z. B. www.beispiel.de) in IP-Adressen und umgekehrt, sodass Computer im Netzwerk Websites und Dienste finden können. Er ist essenziell für die Navigation im Internet.",
            Image = Resources.Load<Texture2D>("Images/Image2")
        };

        buttonContents[5] = new CanvasContent
        {
            Description = "Gerät: File-Storage       \r\nEinbauort:      \r\nGebäude:        \r\nIP-Adresse:",
            Information = "Ein File-Storage ist ein Speicher, der Daten in einem hierarchischen Dateisystem organisiert. Benutzer können Dateien speichern, abrufen und verwalten, ähnlich wie auf einer lokalen Festplatte, jedoch oft über ein Netzwerk zugänglich.",
            Image = Resources.Load<Texture2D>("Images/Image2")
        };

        buttonContents[6] = new CanvasContent
        {
            Description = "Gerät: Datenbankserver      \r\nEinbauort:      \r\nGebäude:        \r\nIP-Adresse: ",
            Information = "Ein Datenbankserver ist ein System, das Datenbanken hostet und Anfragen zur Datenverarbeitung und -abfrage von Clients über eine Netzwerkschnittstelle verarbeitet. Er ermöglicht die zentrale Verwaltung und effiziente Nutzung von Daten.",
            Image = Resources.Load<Texture2D>("Images/Image2")
        };

        buttonContents[7] = new CanvasContent
        {
            Description = "Gerät: Firewall      \r\nEinbauort:      \r\nGebäude:        \r\nIP-Adresse: ",
            Information = "Eine Firewall ist ein Sicherheitssystem, das den ein- und ausgehenden Datenverkehr zwischen Netzwerken überwacht, filtert und kontrolliert. Sie schützt vor unautorisiertem Zugriff, Malware und Cyberangriffen, indem sie Datenpakete anhand festgelegter Regeln prüft. Es gibt verschiedene Typen, wie Hardware-, Software- und cloudbasierte Firewalls, die sowohl Netzwerke als auch einzelne Geräte absichern können.",
            Image = Resources.Load<Texture2D>("Images/Image2")
        };
        buttonContents[8] = new CanvasContent
        {
            Description = "Gerät:       \r\nEinbauort:      \r\nGebäude:        \r\nIP-Adresse: ",
            Information = "",
            Image = Resources.Load<Texture2D>("Images/Image2")
        };
        
    }

    // Methode, die von Buttons aufgerufen wird
    public void UpdateCanvas(int contentIndex)
    {
        Description.text = buttonContents[contentIndex].Description;
        Information.text = buttonContents[contentIndex].Information;
        if (contentIndex >= 0 && contentIndex < buttonContents.Length)
        {
            // Textfelder befüllen
            Description.text = buttonContents[contentIndex].Description;
            Information.text = buttonContents[contentIndex].Information;
            
            // Bild befüllen
            if (Picture != null)
            {
                Picture.texture = buttonContents[contentIndex].Image;
            }
            
        }
        else
        {
            Debug.LogWarning("Content Index außerhalb des Bereichs!");
        }
    }
}
