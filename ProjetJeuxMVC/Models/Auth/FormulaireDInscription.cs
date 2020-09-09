using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetJeuxMVC.Models.Auth
{
    public class FormulaireDInscription
    {
        [Required]
        [StringLength(255, MinimumLength = 5)]
        [DisplayName("Nom d'Utilisateur: ")]
        public string NomUtilisateur { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(320, MinimumLength = 5)]
        [DisplayName("Email: ")]

        public string Email { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 2)]
        [DisplayName("Nom: ")]
        public string Nom { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 2)]
        [DisplayName("Prenom: ")]
        public string Prenom { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 8)]
        [DisplayName("Mot de passe: ")]
        public string Passwd { get; set; }
    }
}