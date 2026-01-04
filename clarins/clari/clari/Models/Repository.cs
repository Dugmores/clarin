

using System;

namespace clari.Models;

public static class Repository
{
    private static List<GuestResponse> responses = new();

    public static IEnumerable<GuestResponse> Responses => responses;
    public static void AddReponse (GuestResponse reponse)
    {
        Console.WriteLine(reponse);
        responses.Add(reponse);
    }
}