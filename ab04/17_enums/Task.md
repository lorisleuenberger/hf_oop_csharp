## Aufgabe 17 (2 Punkte)
Erstellen Sie ein enum Modus mit den Werten:
› Heizen
› Off
› Kuehlen
Erstellen Sie eine Klasse Klimaanlage, die folgende Eigenschaften hat:
› AktuelleTemperatur (double) – die gemessene Raumtemperatur
› ZielTemperatur (double) – die gewünschte Soll-Temperatur
› Modus (vom Typ Modus) – der aktuelle Betriebsmodus
Beim Setzen der Zieltemperatur soll sofort in den richtigen Modus geschaltet werden:
› Ist die aktuelle Temperatur unter der Zieltemperatur → Heizen
› Ist die aktuelle Temperatur gleich der Zieltemperatur → Off
› Ist die aktuelle Temperatur über der Zieltemperatur → Kuehlen
Implementieren Sie eine Methode StatusAnzeigen(), die die aktuelle Temperatur, die
Zieltemperatur und den Modus auf der Konsole ausgibt.