# Überblick
TradsApp ist eine Windows Forms-Anwendung, die entwickelt wurde, um den Handel von Wertpapieren zu bearbeiten und Trades und Kursdaten zu einem Wertpapier zu zeigen. 
# Installation und Initialisierung der Datenbank
Um die Datenbank für die App zu initialisieren, folge diesen Schritten:
1. Stelle sicher, dass du Sql Express installiert hast und der Dienst ausgeführt wird.
2. Navigiere zum Ordner "TradesApp\Sqls" in dem TradeApp-Verzeichnis.
3. Öffne die Datei "CreateDb.sql" mit einem SQL-Management-Tool deiner Wahl (z.B. SQL Server Management Studio).
4. Führe den Inhalt der Datei aus, um die Datenbankstruktur und erforderlichen Tabellen zu erstellen. Stelle sicher, dass du die Ausführung mit den entsprechenden Berechtigungen durchführst.
5. Öffne die Datei "App.config" im Verzeichnis "TradesApp".
6. Suche nach dem Abschnitt <connectionStrings> in der Datei.
7. Passe den Wert "Server" im connectionString-Attributs vom <add>-Element an, um die Datenbankverbindung anzugeben. 
# Abhängigkeiten
Die App verwendet folgende Bibliotheken und Frameworks:
1. Dependency Injection für die Verwaltung von Abhängigkeiten
2. Entity Framework Core für den Zugriff auf die Datenbank (Sql Express)
3. WinForms.DataVisualization für die grafische Darstellung von Handelsdaten
4. Selenium für das Laden von Daten aus Webseiten, erfordert die Unterstützung von Chrome
# Sicherheitskonzept
## Authentifizierung und Autorisierung auf Datenbankebene
Jeder Benutzer authentifiziert sich mit einem eindeutigen Benutzernamen und Passwort, um auf die Datenbank zuzugreifen. Und die App verwendet die selbe Benutzername und Passwort für die Anmeldung.
## Benutzergruppen
Unterschiedliche Benutzergruppen definieren unterschiedliche Zugriffsrechte. Jede Gruppe hat spezifische Berechtigungen, um auf bestimmte Tabellen zuzugreifen.
# Abstractionierung, Komponentisierung und Dependency Injection für UI-Komponenten
## Abstrakte Klasse definieren
In der App werden die abstrakte Basisklassen für jede Art von UI-Komponente (z.B. Menuitem, Detailview) definiert,  um eine einheitliche Benutzeroberfläche und eine konsistente Verwendung zu gewährleisten. 
## Komponentenbasierte Entwicklung
Jede UI-Komponente als eigenständige Einheit wird entwicklet, die unabhängig von anderen Komponenten funktionieren kann. Verwende Konzepte wie User Controls, um die Komponenten logisch zu strukturieren und zu kapseln.
## Dependency Injection für UI-Komponenten
Dependency Injection wird verwendet, um die Abhängigkeiten zwischen verschiedenen UI-Komponenten zu verwalten und die Komponenten flexibel zu gestalten. Dadurch können Komponenten leicht ausgetauscht oder wiederverwendet werden, ohne dass Änderungen an anderen Teilen der Anwendung erforderlich sind.