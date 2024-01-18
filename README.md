# oop
oop C# module course &amp; training repo 
## how to klasse hinzufügen
Project > add class/ add existing Item (or copy it into Project Folder) oder in AB5 gut Dokumentiert 
## how to nuget packet hinzufügen
Project > manage nuget Packages... > Zahnrad > + > Source: ... > Select Folder > Done

## Getter & Setter
Eine Zugriffsfunktion, auch Zugriffsmethode, Akzessor oder im Programmiererjargon getter und setter genannt, ist in der objektorientierten Programmierung eine spezielle Methode, die eine einzelne Eigenschaft (Attribut) eines Objekts abfragt oder ändert. Zugriffsfunktionen sind Teil der öffentlichen Schnittstelle eines Objekts und verbergen Implementierungsdetails dieses Objekts. Dadurch kann die Implementierung eines Objekts geändert werden, ohne seine öffentliche Schnittstelle zu ändern.

### Abfragemethoden (Getter)
Eine Zugriffsmethode, die eine Eigenschaft eines Objekts abfragt, heißt auch Abfragemethode oder Getter (von englisch to get – etwas holen). Die Eigenschaft kann entweder direkt aus einem Objektattribut entnommen, das dann normalerweise eine geringere Sichtbarkeit hat, oder im Moment des Aufrufs berechnet werden. Für den Aufrufer ist das nicht erkennbar, dadurch wird die Kapselung sichergestellt.

In einigen Programmiersprachen ist es üblich, die Namen aller Abfragemethoden mit get beginnen zu lassen. So könnte z. B. eine Methode, die den Namen einer Person abfragt, getName heißen. Alternativ können Methoden, welche Boolesche Werte abfragen, mit is (z. B. isMarried) oder has (z. B. hasChild) beginnen.

In anderen Programmiersprachen ist dies unüblich und die Methode hieße einfach name, da bereits der Funktionsaufruf als solcher ein Holen in sich hat.

### Änderungsmethoden (Setter)
Eine Zugriffsmethode, die ein Objektattribut ändert, heißt auch Änderungsmethode oder Setter (von englisch to set – etwas einstellen, setzen). Ein Vorteil der Änderungsmethode besteht darin, dass sie vor der Änderung den Wert auf Gültigkeit prüfen kann. So könnte beispielsweise in einem Objekt, das eine Person darstellt, die Funktion zum Setzen des Namens sicherstellen, dass als Name kein leerer Text übergeben wird. Falls ein ungültiger Wert übergeben wird, besteht eine mögliche Reaktion im Auslösen einer Ausnahmeroutine, wodurch der normale Programmablauf unterbrochen und ein Fehler signalisiert wird.

Ein weiterer Vorteil der Änderungsmethode besteht darin, dass sie eventuelle Beobachter (im Sinne des gleichnamigen Entwurfsmusters) über die Änderung des Objektzustands informieren kann. Dies wird beispielsweise in Model-View-Controller-Architekturen benutzt, um eine Sicht (View, z. B. ein Bildschirmformular) zu aktualisieren, wenn der Inhalt des zugrundeliegenden Modells (Model, z. B. ein Datensatz in einer Datenbanktabelle) geändert wurde.

In einigen Programmiersprachen ist es üblich, die Namen aller Änderungsmethoden mit set beginnen zu lassen. So könnte z. B. eine Methode, die den Namen einer Person ändert, setName heißen. In anderen Programmiersprachen ist dieses Präfix unüblich und die Methode hieße einfach name, da bereits der parametrisierte Funktions-/Prozeduraufruf als solcher eine setzende Methode impliziert.

