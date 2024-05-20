# EmployeeRegister
  
## Bakgrund
Ett litet f�retag i restaurangbranschen kontaktar dig f�r att utveckla ett litet 
personalregister. De har endast tv� krav:  

* Registret skall kunna ta emot och lagra anst�llda med namn och l�n. (via inmatning  i konsolen, inget krav p� persistent lagring)
* Programmet skall kunna skriva ut registret i en konsol.  

### Uppgift 1
Vilka klasser b�r ing� i programmet?  
```
En Employee klass, som representerar en person.  
En EmployeeRegister klass, som representerar sj�lva programmets funktionalitet och dess metoder.  
En klass eller annan kod f�r att k�ra programmet, i detta fall en klass som inneh�ller mainmetod och menyval och inputs fr�n anv�ndare.  
```

### Uppgift 2
Vilka attribut och metoder b�r ing� i dessa klasser?  
```
Employee.cs b�r inneh�lla personliga egenskaper s� som Namn och L�n och g�r att bygga p� med mer information om den specifika personen.  
EmployeeRegister.cs b�r inneh�lla en funktion f�r att l�gga till Employees till en lista (men �ven ta bort, editera, flytta i framtiden). Klassen b�r ocks� ha en funktion som skriver den aktuella listan och andra hj�lpmetoder p� beg�ran.  
MainProgram.cs beh�ver kod f�r att styra programmet p� �nskv�rt s�tt. T.ex. ta in v�rden fr�n anv�ndare om en ny anst�lld, visa listan med alla anst�llda och liknade. Denna klass kan ocks� vara n�gon form av GUI.  
```

### Uppgift 3
Skriv programmet  
* F�rs�k g�ra programmet s� robust och framtidss�kert som m�jligt!  
* Bonus f�r att implementera test! (men inte p� bekostnad av att den andra koden blir lidande)  