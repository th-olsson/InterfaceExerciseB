# Övning 8 - Interface
## A)
- [x] Gör två klasser som heter program1 och en som heter program 2.
- [x] Den ena klassen ska ha en metod run() med returtyp void.
- [x] Den andra klassen ska ha en metod Go() också med returtyp void.
- [x] I metoderna skriver du ut ”Nu kör vi program 1” respektive ”nu kör vi
program 2”.
- [x] Skapa objekt för båda klasserna i main() och anropa metoderna.
- [x] Kommentera sedan bort anropet till metoderna och metoderna i klasserna.
- [x] Gör ett interface som har en metod start().
Implementera (använd) interfacet på båda klasserna.
- [x] Gör så att kontraktet för interfacet blir uppfyllt.
- [x] Vad är fördelen med interfacet jämfört med hur det var från början?
	- Svar: Delat metodnamn och ser till att programmen följer kontraktet
- [x] Skapa sedan ytterligare ett interface och lägg detta till första klassen. Lägg
till valfri metod och se till att alla kontrakt uppfylls.

## B)
- [ ] Gör två interface med samma metod run(). Den ena metoden ska ha
returtyp void och den andra int.
- [ ] Gör en klass som uppfyller båda kontrakten med två metoder med samma
namn.
- [ ] Den ena ska ha returtyp void och den andra int. Den som har int ska
returnera en sjua. I varje metod skriver du ut vilken metod som körs.
- [ ] Skapa en instans (objekt) av klassen och anropa båda metoderna. 