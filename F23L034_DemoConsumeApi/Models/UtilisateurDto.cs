using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L034_DemoConsumeApi.Models
{
    public class Utilisateur
    {
        public int Id { get; init; }
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public string Email { get; init; }
        public string Token { get; init; }

        public Utilisateur(int id, string nom, string prenom, string email, string token)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Token = token;
        }
    }
}
