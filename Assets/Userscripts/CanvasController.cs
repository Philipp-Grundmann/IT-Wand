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
        buttonContents = new CanvasContent[100]; // Größe des Speicherarrays
    
        buttonContents[0] = new CanvasContent
        {
            Description = "Gerät: PROmesh B8 Compact\r\nEinbauort: Anlage: xy\r\nSchaltschrank: za\r\nIP-Adresse: 10.0.10.1",
            Information = "Beschreibung: Dieser Switch verbindet SPS mit dem Cobot, der Endmontage.\r\nDer PROmesh B8 Compact bringt mit seinem kompakten Format neue Möglichkeiten für die Installation von Managed Switches. Er ist ideal für Orte mit wenig Platz und verbindet fortschrittliche Technologie mit einer platzsparenden Lösung.\r\nEingebaut am: 29.12.2024\r\nLetzte Wartung: 06.12.2024\r\nNächste Wartung: 08.12.2024.",
            Image = Resources.Load<Texture2D>("Assets/Switch.png")
        };
    
        buttonContents[1] = new CanvasContent
        {
            Description = "Gerät: Printserver\r\nEinbauort: Serverraum 1\r\nGebäude: 3, Ebene 1\r\nIP-Adresse: 10.0.10.5",
            Information = "Über diesen Server werden alle Drucker der Firma an die Assets verteilt. \r\nEin Print-Server ist eine zentrale Schnittstelle, die Druckaufträge von mehreren Geräten an einen oder mehrere Drucker im Netzwerk weiterleitet und verwaltet.",
            Image = Resources.Load<Texture2D>("Assets/Printserver.png")
        };
    
        buttonContents[2] = new CanvasContent
        {
            Description = "Gerät: Jump-Server\r\nEinbauort: \r\nGebäude: \r\nIP-Adresse: ",
            Information = "Ein Jump-Server (auch Jump-Host) ist ein speziell abgesichertes System, das als Zwischenstation dient, um den Zugriff auf Server in einem geschützten Netzwerk zu ermöglichen.",
            Image = Resources.Load<Texture2D>("Assets/Jump-Server.png")
        };
    
        buttonContents[3] = new CanvasContent
        {
            Description = "Gerät: Mail-Server\r\nEinbauort: \r\nGebäude: \r\nIP-Adresse: ",
            Information = "Ein Mail-Server ist ein System, das E-Mails sendet, empfängt und speichert. Er nutzt Protokolle wie SMTP (Senden), IMAP oder POP3 (Empfangen), um den E-Mail-Verkehr zwischen Sendern, Empfängern und deren Clients zu ermöglichen.",
            Image = Resources.Load<Texture2D>("Assets/Mail-Server.png")
        };
    
        buttonContents[4] = new CanvasContent
        {
            Description = "Gerät: DNS-Server\r\nEinbauort: \r\nGebäude: \r\nIP-Adresse:",
            Information = "Ein DNS-Server übersetzt Domainnamen (z. B. www.beispiel.de) in IP-Adressen und umgekehrt, sodass Computer im Netzwerk Websites und Dienste finden können.",
            Image = Resources.Load<Texture2D>("Assets/DNS-Server.png")
        };
    
        buttonContents[5] = new CanvasContent
        {
            Description = "Gerät: File-Storage\r\nEinbauort: \r\nGebäude: \r\nIP-Adresse:",
            Information = "Ein File-Storage ist ein Speicher, der Daten in einem hierarchischen Dateisystem organisiert. Benutzer können Dateien speichern, abrufen und verwalten, ähnlich wie auf einer lokalen Festplatte.",
            Image = Resources.Load<Texture2D>("Assets/File-Storage.png")
        };
    
        buttonContents[6] = new CanvasContent
        {
            Description = "Gerät: Datenbankserver\r\nEinbauort: \r\nGebäude: \r\nIP-Adresse: ",
            Information = "Ein Datenbankserver hostet Datenbanken und verarbeitet Anfragen zur Datenverarbeitung und -abfrage von Clients über ein Netzwerk.",
            Image = Resources.Load<Texture2D>("Assets/Datenbankserver.png")
        };
    
        buttonContents[7] = new CanvasContent
        {
            Description = "Gerät: Firewall\r\nEinbauort: \r\nGebäude: \r\nIP-Adresse: ",
            Information = "Eine Firewall schützt Netzwerke vor unautorisiertem Zugriff, indem sie den ein- und ausgehenden Datenverkehr überwacht, filtert und kontrolliert.",
            Image = Resources.Load<Texture2D>("Assets/Firewall.png")
        };
    
        buttonContents[8] = new CanvasContent
        {
            Description = "Gerät: Webserver\r\nEinbauort: Rechenzentrum\r\nGebäude: Serverraum 2\r\nIP-Adresse: 10.0.10.20",
            Information = "Ein Webserver stellt Webseiten und Webanwendungen bereit, indem er HTTP- oder HTTPS-Anfragen verarbeitet und Inhalte an Clients wie Browser ausliefert.",
            Image = Resources.Load<Texture2D>("Assets/Web-server.png")
        };
    
        buttonContents[9] = new CanvasContent
        {
            Description = "Gerät: NTP-Server\r\nEinbauort: Rechenzentrum\r\nGebäude: Serverraum 3\r\nIP-Adresse: 10.0.10.30",
            Information = "Ein NTP-Server (Network Time Protocol) synchronisiert die Zeit aller Netzwerkgeräte und sorgt für eine genaue Zeiteinhaltung in Systemen.",
            Image = Resources.Load<Texture2D>("Assets/NTP-Server.png")
        };
    
        buttonContents[10] = new CanvasContent
        {
            Description = "Gerät: ERP-Server\r\nEinbauort: Rechenzentrum\r\nGebäude: Serverraum 1\r\nIP-Adresse: 10.0.10.40",
            Information = "Ein ERP-Server hostet Unternehmenssoftware für Geschäftsprozesse wie Buchhaltung, Personalverwaltung und Logistik.",
            Image = Resources.Load<Texture2D>("Assets/ERP-Server.png")
        };
    
        buttonContents[11] = new CanvasContent
        {
            Description = "Gerät: Workstation\r\nEinbauort: Büro\r\nGebäude: Hauptgebäude, 2. Etage\r\nIP-Adresse: 10.0.10.50",
            Information = "Eine Workstation ist ein leistungsstarker Computer für anspruchsvolle Anwendungen wie CAD, Simulationen oder Softwareentwicklung.",
            Image = Resources.Load<Texture2D>("Assets/Workstation.png")
        };
    
        buttonContents[12] = new CanvasContent
        {
            Description = "Gerät: Access Point\r\nEinbauort: Lagerhalle\r\nGebäude: B1\r\nIP-Adresse: 10.0.10.60",
            Information = "Ein Access Point erweitert ein WLAN-Netzwerk, indem er drahtlose Geräte mit einem kabelgebundenen Netzwerk verbindet.",
            Image = Resources.Load<Texture2D>("Assets/Access-Point.png")
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
