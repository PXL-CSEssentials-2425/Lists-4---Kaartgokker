# Oefening 4: KaartGokker

Maak een programma waarin je kan raden wat de kleur is van de volgende
getrokken kaart. In het programma wordt er een 52 kaartendek
gesimuleerd. Met andere woorden: kaarten die getrokken worden verlaten
het dek.

**Applicatie layout:**

-   In de layout wordt er een Grid gebruikt om de besturingselementen in
    3 kolommen op te delen

-   In de linkerkolom is er een StackPanel gebruikt voor het kaart-kies
    menu met een ComboBox in

-   In de rechterkolom is er een StackPanel gebruikt met een ListBox in

![Afbeelding met tekst, schermopname, software, Webpagina Automatisch
gegenereerde
beschrijving](./media/image1.png)

**Applicatie functionaliteit:**

-   Als speler kan je een kleur kiezen uit een dropdown menu (ComboBox)

-   Als speler kan ik manueel een inzet in typen

-   Indien de inzet ongeldig is, dan wordt de speler hiervan verwittigd.
    De inzet is ongeldig wanneer het bedrag te hoog is of niet numeriek

-   Als speler kan je op de "Trek kaart"-knop klikken om een kaart te
    trekken uit een deck. Indien de kleur van de kaart correct gegokt
    is, dan krijgt de speler zijn of haar ingezette bedrag dubbel terug

-   Als speler zie ik mijn huidig totaal. Dit is het totale bedrag dat
    de speler bezit en kan inzetten voor een gok

-   De speler start met een bedrag van 1000

-   Als speler zie ik de geschiedenis van mijn vorige gokken. De
    geschiedenis bevat de naam van de getrokken kaart en de hoeveelheid
    winst of verlies van die ronde

-   Een virtueel deck wordt in de achtergrond gesimuleerd. Elke
    getrokken kaart wordt uit het deck verwijdert en toegevoegd aan de
    geschiedenis met het gemaakte verschil in punten
