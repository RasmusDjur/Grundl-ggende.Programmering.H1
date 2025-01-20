using System;

class Opgave19
{
    public static void Kør()
    {
        Console.Clear();
        Console.WriteLine("Hvad er Versionsstyring? \n Versionsstyring handler om at holde styr på ændringer i filer, så du kan:\n Sporing af ændringer: Hver gang du opdaterer en fil eller et projekt, gemmes ændringerne, og du kan altid gå tilbage til en tidligere version af filen.\n Samarbejde: Flere udviklere kan arbejde på de samme filer samtidig uden at overskrive hinandens arbejde.\n Sikkerhed: Du kan gemme versioner af dit projekt, så du aldrig mister data. Hvis noget går galt, kan du rulle tilbage til en tidligere version.\n Brug af grene: Du kan arbejde på nye funktioner i separate grene (branches) uden at påvirke den primære kodebase.");
        Console.WriteLine();
        Console.WriteLine("Praktisk Brug af Versionsstyring med GitHub Desktop \n Opret Repository: Opret et repository på GitHub og klon det til din computer via GitHub Desktop. \n Arbejd på Filer: Lav ændringer eller tilføj filer til dit projekt lokalt. \n Commit Ændringer: Når du har lavet ændringer, skriv en commit-besked og klik Commit to main for at gemme ændringerne lokalt. \n Push Ændringer: Klik på Push origin for at sende dine ændringer til GitHub. \n Pull Ændringer: Klik på Fetch og Pull for at hente ændringer fra GitHub, hvis andre har opdateret projektet. \n Brug Branches: Opret en ny branch for at arbejde på separate funktioner uden at ændre hovedprojektet. Når du er færdig, kan du merge branchene.");
        
        // Afslut programmet
        Console.ReadKey();
    }
}