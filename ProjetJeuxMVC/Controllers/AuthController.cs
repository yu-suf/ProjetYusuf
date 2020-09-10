using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetJeuxMVC.Models.Auth;
using ProjetJeuxMVC.Models;
using ProjetJeuxMVC.Infrastructures;
using Jeux.DAL.Global.Repositories;
using Jeux.DAL.Global.Models;

namespace ProjetJeuxMVC.Controllers
{
    public class AuthController : Controller
    {
        
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
                LoginInfo loginInfo = new LoginInfo { NomUtilisateur = form.Login, Password = form.Password };
                UtilisateurRepository service = new UtilisateurRepository();
                Utilisateur utilisateur = service.Check(loginInfo);
                if (User is null)
                {
                    ModelState.AddModelError("", "Mauvais Login ou Mot de passe");
                    return View(form);
                }
                else
                {
                    UtilisateurSession.utilisateur = utilisateur;
                    
                }
                return RedirectToAction("Index", "Home");
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
                Utilisateur utilisateur = new Utilisateur()
                {
                    NomUtilisateur = form.NomUtilisateur,
                    Nom = form.Nom,
                    Prenom = form.Prenom,
                    Email = form.Email,
                    Passwd = form.Passwd
                };
                UtilisateurRepository repo = new UtilisateurRepository();
                repo.Insert(utilisateur);
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
