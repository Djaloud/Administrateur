using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using Professeurs.Models;
using Professeurs.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly myDataContext md;


        public HomeController(ILogger<HomeController> logger,myDataContext md)
        {
            _logger = logger;
            this.md = md;
        }
        [HttpGet]
        public IActionResult AddProf(long? id)
        {
            ProfesseurViewModelcs model = new ProfesseurViewModelcs();
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<List<Professeur>> Import(IFormFile file)
        {
            var list = new List<Professeur>();
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowcount = worksheet.Dimension.Rows;
                    for(int row = 2; row <= rowcount; row++)
                    {
                        md.Add(new Professeur()
                        {
                            nom_prof = worksheet.Cells[row, 2].Value.ToString().Trim(),
                            prenom_prof = worksheet.Cells[row, 3].Value.ToString().Trim(),
                            tel = worksheet.Cells[row, 4].Value.ToString().Trim(),
                            email = worksheet.Cells[row, 5].Value.ToString().Trim(),
                            adresse = worksheet.Cells[row, 6].Value.ToString().Trim()
                        });
                    }
                    md.SaveChanges();
                }
            }
            return null;
        }

        public async Task<List<Etudiant>> Imports(IFormFile file)
        {
            var listP = new List<Etudiant>();
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowcount = worksheet.Dimension.Rows;
                    for (int row = 2; row <= rowcount; row++)
                    {
                        md.Add(new Etudiant()
                        {
                            nom = worksheet.Cells[row, 2].Value.ToString().Trim(),
                            prenom = worksheet.Cells[row, 3].Value.ToString().Trim(),
                            tel = worksheet.Cells[row, 4].Value.ToString().Trim(),
                            email = worksheet.Cells[row, 5].Value.ToString().Trim(),
                            adresse = worksheet.Cells[row, 6].Value.ToString().Trim(),
                            massar = worksheet.Cells[row, 7].Value.ToString().Trim(),
                            cin = worksheet.Cells[row, 8].Value.ToString().Trim(),
                            lastname_fr = worksheet.Cells[row, 9].Value.ToString().Trim(),
                            lastname_ar = worksheet.Cells[row, 10].Value.ToString().Trim(),
                            firstname_fr = worksheet.Cells[row, 11].Value.ToString().Trim(),
                            firstname_ar = worksheet.Cells[row, 12].Value.ToString().Trim(),
                            ddn = worksheet.Cells[row, 13].Value.ToString().Trim(),
                            ldn = worksheet.Cells[row, 14].Value.ToString().Trim(),
                            natio = worksheet.Cells[row, 15].Value.ToString().Trim(),
                            phone = worksheet.Cells[row, 16].Value.ToString().Trim(),
                            father_name = worksheet.Cells[row, 17].Value.ToString().Trim(),
                            father_job = worksheet.Cells[row, 18].Value.ToString().Trim(),
                            mother_name = worksheet.Cells[row, 19].Value.ToString().Trim(),
                            mother_job = worksheet.Cells[row, 20].Value.ToString().Trim(),
                            parents_adress = worksheet.Cells[row, 21].Value.ToString().Trim(),
                            parents_phone = worksheet.Cells[row, 22].Value.ToString().Trim(),
                            annee = worksheet.Cells[row, 23].Value.ToString().Trim(),
                            filiere = worksheet.Cells[row, 24].Value.ToString().Trim(),
                            type_bac = worksheet.Cells[row, 25].Value.ToString().Trim(),
                            mention_bac = worksheet.Cells[row, 26].Value.ToString().Trim(),
                            annee_bac = worksheet.Cells[row, 27].Value.ToString().Trim(),
                            lycee = worksheet.Cells[row, 28].Value.ToString().Trim(),
                            delegation = worksheet.Cells[row, 29].Value.ToString().Trim(),
                            academie = worksheet.Cells[row, 30].Value.ToString().Trim(),
                            diplome = worksheet.Cells[row, 31].Value.ToString().Trim(),
                            ecole = worksheet.Cells[row, 32].Value.ToString().Trim(),
                            ville_diplome = worksheet.Cells[row, 33].Value.ToString().Trim(),
                            validated = Convert.ToInt32(worksheet.Cells[row, 34].Value.ToString().Trim()),
                            picture = worksheet.Cells[row, 35].Value.ToString().Trim(),
                            password = worksheet.Cells[row, 36].Value.ToString().Trim(),
                            code_promo = Convert.ToInt32(worksheet.Cells[row, 37].Value.ToString().Trim()),
                            sexe = worksheet.Cells[row, 38].Value.ToString().Trim()

                        });
                    }
                    md.SaveChanges();
                }
            }
            return null;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Trombinoscope()
        {

            var etuds = (from p in md.etudiants select p).ToList();
            List<Etudiant> etus = etuds;
            ViewData["etudiants"] = etus;
            return View();
        }

        public IActionResult TrombiProf()
        {
            var profs = (from p in md.professeurs select p).ToList();
            List<Professeur> prof = profs;

            ViewData["professeur"] = prof;
            return View(prof);
        }

        public IActionResult AddProf()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProf(String id_prof, String nom_prof, String prenom_prof, String tel_prof, String email_prof, String adresse_prof)
        {
            Professeur pr = new Professeur()
            {
                //id_professeur=id_prof,
                nom_prof = nom_prof,
                prenom_prof = prenom_prof,
                tel = tel_prof,
                email = email_prof,
                adresse = adresse_prof

            };

            md.Add(pr);
            md.SaveChanges();
            return View("AddProf");
        }
        public IActionResult AddEtudiant()
        {
            return View();
        }
            [HttpPost]
        public IActionResult AddEtudiant(String apogee, String nom, String prenom, String tel, String email, String adresse, String massar, String cin)
        {
            Etudiant etu = new Etudiant()
            {
                //id_professeur=id_prof,
                nom = nom,
                prenom = prenom,
                tel = tel,
                email = email,
                adresse = adresse,
                massar = massar,
                cin = cin,
            };

            md.Add(etu);
            md.SaveChanges();
            return View("AddEtudiant");
        }

        public IActionResult Create()
        {
            return View();
        }

        
    }
}



