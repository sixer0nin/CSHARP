using System.Transactions;

string[] guestList = ["Rebecca", "Nadia", "Noor", "Jonte"];
string[] rsvps = new string[10];
int count = 0;

System.Console.WriteLine("Enter Name:");
string? name = Console.ReadLine();

System.Console.WriteLine("Enter party size");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Allerfies to be noted:");
string? allergic = Console.ReadLine();

if (name != null && allergic != null)
{

    RSVP(name, size, allergic, true);

    ShowRSVPs();

    void RSVP(string name, int partySize, string allergies, bool inviteOnly)
    {
        if (inviteOnly)
        {
            //searvh guestlist before adding rsvp
            bool found = false;
            foreach (string guest in guestList)
            {
                if (guest.Equals(name))
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                System.Console.WriteLine($"Sorry, {name} is not on the guest list.");
                return;
            }
        }

        rsvps[count] = $"Name: {name} \tParty Size: {partySize} \tAllergies: {allergies}";
        count++;
    }

    void ShowRSVPs()
    {
        System.Console.WriteLine("\nTotal RSVPs:");
        for (int i = 0; i < count; i++)
        {
            System.Console.WriteLine(rsvps[i]);
        }
    }
}