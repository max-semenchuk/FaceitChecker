using System;

namespace FaceitChecker.Models;

public class FaceitPlayerResponse
{

    public string Username { get; set; } = string.Empty;

    public float Rating { get; set; }

    public DateOnly RegistrationDate { get; set; }

    public int Elo { get; set; }
}
