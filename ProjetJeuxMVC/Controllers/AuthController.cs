using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetJeuxMVC.Models.Auth;
using ProjetJeuxMVC.Models;
using ProjetJeuxMVC.Mapper;
using ProjetJeuxMVC.Infrastructures;
using ProjetJeuxMVC.Infrastructures.Services;

namespace ProjetJeuxMVC.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;
        public AuthController()
        {
            _authService = new AuthService();
        }
        // GET: Auth
        public ActionResult Index()
        {
            return RedirectToAction(nameof(Login));
        }
        
        [HttpGet]
        public ActionResult Login()
        {
            FormulaireDeLogin form = new FormulaireDeLogin();
            return View(form);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormulaireDeLogin form)
        {
            if (ModelState.IsValid)
            {
                Utilisateur utilisateur = new Utilisateur { NomUtilisateur = form.Login, Password = form.Password };
                
                utilisateur = _authService.Login(utilisateur);
                if (!(utilisateur is null))
                {
                    UtilisateurSession.utilisateur = utilisateur;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(form);
        }

        [HttpGet]
        public ActionResult Inscription()
        {
            return View(new FormulaireDInscription());
        }

        [HttpPost]
        public ActionResult Inscription(FormulaireDInscription form)
        {

            if (ModelState.IsValid)
            {
                _authService.Register(new Utilisateur
                {
                    Nom = form.Nom,
                    Prenom = form.Prenom,
                    Email = form.Email,
                    NomUtilisateur = form.NomUtilisateur,
                    Password = form.Passwd
                });

                return RedirectToAction(nameof(Index));
            }

            return View(form);
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}
