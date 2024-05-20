# EmployeeRegister
  
## Bakgrund
Ett litet företag i restaurangbranschen kontaktar dig för att utveckla ett litet 
personalregister. De har endast två krav:  

* Registret skall kunna ta emot och lagra anställda med namn och lön. (via inmatning  i konsolen, inget krav på persistent lagring)
* Programmet skall kunna skriva ut registret i en konsol.  

### Uppgift 1
Vilka klasser bör ingå i programmet?  
```
En Employee klass, som representerar en person.  
En EmployeeRegister klass, som representerar själva programmets funktionalitet och dess metoder.  
En klass eller annan kod för att köra programmet, i detta fall en klass som innehåller mainmetod och menyval och inputs från användare.  
```

### Uppgift 2
Vilka attribut och metoder bör ingå i dessa klasser?  
```
Employee.cs bör innehålla personliga egenskaper så som Namn och Lön och går att bygga på med mer information om den specifika personen.  
EmployeeRegister.cs bör innehålla en funktion för att lägga till Employees till en lista (men även ta bort, editera, flytta i framtiden). Klassen bör också ha en funktion som skriver den aktuella listan och andra hjälpmetoder på begäran.  
MainProgram.cs behöver kod för att styra programmet på önskvärt sätt. T.ex. ta in värden från användare om en ny anställd, visa listan med alla anställda och liknade. Denna klass kan också vara någon form av GUI.  
```

### Uppgift 3
Skriv programmet  
* Försök göra programmet så robust och framtidssäkert som möjligt!  
* Bonus för att implementera test! (men inte på bekostnad av att den andra koden blir lidande)  