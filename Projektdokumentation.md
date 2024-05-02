# Projekt-Dokumentation


Gruppe: Müllabfuhr (Ben säubert das Fricktal)
Mitglieder: Ben Linus Müller, Janick Thomas Hurschler

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  |  |  |


## 1 Informieren

### 1.1 Ihr Projekt

Unser Projekt ist eine Konsolenapplikation, in der man die Casinospiele "Slotmaschine" und "Craps" spielen kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1 | muss | funktional | Als Spieler möchte ich die Slotmaschine bedienen können, um zu spielen. |
|2|muss|Qualität|Als Spieler möchte ich die Regeln des Craps-Spiels verstehen, um erfolgreich zu spielen.|
|3|muss|funktional|Als Spieler möchte ich meinen Einsatz platzieren können, um am Craps-Spiel teilzunehmen.|
|4|muss|Qualität|Als Spieler möchte ich das Ergebnis meines Craps-Wurfs sehen, um zu wissen, ob ich gewonnen oder verloren habe.|
|5|kann|Qualität|Als Spieler möchte ich meine Spielhistorie einsehen können, um meine Fortschritte zu verfolgen.|
|6|kann|Qualität|Als Spieler möchte ich mein Guthaben verwalten können, um mein Spielerlebnis zu kontrollieren.|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|1.1|Die Slotmaschine ist spielbereit und zeigt den aktuellen Kontostand des Spielers an.|Der Spieler gibt den Befehl ein, um die Walzen zu drehen (z.B. "spin").|Die Konsolenanwendung zeigt eine zufällige Kombination von Symbolen. Das Ergebnis des Spiels (Gewinn oder Verlust) wird angezeigt und der Kontostand des Spielers wird aktualisiert.|
|2.1|Das Craps-Spiel ist bereit für Einsätze und zeigt den aktuellen Kontostand des Spielers an.|Der Spieler gibt den Befehl ein, um einen Einsatz zu platzieren (z.B. "bet 10").|Die Konsolenanwendung bestätigt den Einsatz und zeigt den neuen Kontostand des Spielers an.|
|3.1|Der Spieler hat bereits einen Einsatz platziert und das Craps-Spiel ist bereit für den Wurf.|Der Spieler gibt den Befehl ein, um zu würfeln (z.B. "roll").|Die Konsolenanwendung zeigt das Ergebnis des Wurfs an und aktualisiert den Kontostand des Spielers entsprechend, abhängig davon, ob der Spieler gewonnen oder verloren hat.|
|4.1|Der Spieler möchte seine Spielhistorie überprüfen.|Der Spieler gibt den Befehl ein, um die Spielhistorie anzuzeigen (z.B. "history").|Die Konsolenanwendung zeigt eine Liste vergangener Spiele an, einschließlich der Ergebnisse jedes Spiels (Gewinn oder Verlust).|
|5.1|Der Spieler möchte sein aktuelles Guthaben überprüfen und gegebenenfalls Einzahlungen oder Auszahlungen vornehmen.|er Spieler gibt den Befehl ein, um sein Guthaben anzuzeigen (z.B. "balance") oder eine Einzahlung/Auszahlung vorzunehmen.| Die Konsolenanwendung zeigt den aktuellen Kontostand des Spielers an und führt gegebenenfalls die entsprechenden Transaktionen durch.|




### 1.4 Diagramme


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A|02.05. | Ben| Implementierung der Benutzerinteraktion für die Slotmaschine.|2*45min |
|2.A|02.05.|Janick|Implementierung der Funktionen und Anleitung des Craps-Spiel.|2*45min|
|3.A|02.05|Janick|Implementierung der Benutzerinteraktionen für das Craps-Spiel.|2*45min|
|4.A|02.05|Ben|Implementierung des Benutzer-Infoboard für Kontostand etc.|2*45min|
|5.A|02.05|Ben|Implementierung der Spielhistorie.|2*45min|
|6.A|02.05|Janick|Implementierung der Bearbeitung der Guthabensverwaltung|1*45min|

Total: 9*45min 

## 3 Entscheiden



## 4 Realisieren

| AP-№ |Datum     | Zuständig  | geplante Zeit | tatsächliche Zeit |
|------|------------|------------|---------------|-------------------|
|  |  |  |  |  |





## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
|  |  |  |  |

### Fazit und Bemerkungen


