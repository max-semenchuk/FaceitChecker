using System;

namespace FaceitChecker.Models.Domain
{
    public class Player
    {
        public string player_id { get; set; }

        public string Nickname { get; set; } = string.Empty;

        public float Rating { get; set; }

        public DateOnly RegistrationDate { get; set; }

        public object Games { get; set; }

        public int Elo { get; set; }

        public string Avatar { get; set; }

        public string Player_url { get; set; }

        public string steam_nickname { get; set; }
    }
}
