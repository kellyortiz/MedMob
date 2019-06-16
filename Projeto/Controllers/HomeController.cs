using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto.Entidades;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class HomeController : Controller
    {
        private Contexto _contexto= new Contexto();

        // action Index
        public IActionResult Index()
        {
            return View();
        }

        // action About
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // action Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        // recebe os dados na view Create
        public async Task<IActionResult> Create([Bind("Id,Rg,NomeCompleto,NomeConvenio,NumeroConvenio,DoencaCronica,TipoSanguineo,DataNascimento,Endereco,Numero,Cidade,UF,Pais,Telefone,NomePai,NomeMae")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                // consulta paciente pelo Rg
                var consultaPaciente = _contexto.Pacientes.Where(x => x.Rg == paciente.Rg).FirstOrDefault();
                // se o paciente não exite
                if (consultaPaciente == null)
                {
                    // adiciona paciente na tabela
                    _contexto.Add(paciente);
                    await _contexto.SaveChangesAsync();
                    // retorna view Index com a mensagem "Paciente cadastrado com sucesso"
                    ViewBag.Texto = "Paciente cadastrado com sucesso";
                    return View("Index");
                }
                // se o paciente já existe
                else
                {
                    // retorna a view Index com a mensagem "Paciente já possui um cadastro"
                    ViewBag.Texto = "Paciente já possui um cadastro";
                    return View("Index");

                }
            }
            return View(paciente);
        }

       
        public IActionResult Edit(int id)
        {
            ViewData["PacienteId"] = new SelectList(_contexto.Pacientes, "Id", "NomeCompleto", id);
            HttpContext.Session.SetString("Paciente", id.ToString());
            ViewBag.Teste = id;
            return View();
        }
        

        // action Edit

        [HttpPost]
        [ValidateAntiForgeryToken]
        // passa como parâmetro alergia do tipo Alergia com os atributos fornecidos por view
        public async Task<IActionResult> Edit([Bind("PacienteId,NomeMedicamento")] Alergia alergia)
        {
            if (ModelState.IsValid)
            {
                alergia.PacienteId = Convert.ToInt32(HttpContext.Session.GetString("Paciente"));
                // adiciona alergia à tabela Alergia
                _contexto.Add(alergia);
                await _contexto.SaveChangesAsync();
                // retorna à view Index
                return RedirectToAction(nameof(Index));
            }
            ViewData["PacienteId"] = new SelectList(_contexto.Pacientes, "Id", "Cidade", alergia.PacienteId);
            return View(alergia);
        }

        //action Detail
        [HttpPost]
        public IActionResult Detail([FromForm] HomeViewModel viewModel)
        {
            // consulta Rg fornecido na viewModel (tela de inicio)
            var paciente = _contexto.Pacientes.AsQueryable().Where(x => x.Rg == viewModel.Rg)
                .Include(x => x.Alergias).FirstOrDefault();

            // se o paciente existe, cria-se uma instância da FichaMedicaViewModel com os dados do paciente
            if (paciente != null)
            {
                var model = new FichaMedicaViewModel()
                {
                    Id = paciente.Id,
                    Alergias = paciente.Alergias,
                    DataNascimento = paciente.DataNascimento,
                    DoencaCronica = paciente.DoencaCronica,
                    Cidade = paciente.Cidade,
                    NomeCompleto = paciente.NomeCompleto,
                    NomeConvenio = paciente.NomeConvenio,
                    Endereco = paciente.Endereco,
                    NomeMae = paciente.NomeMae,
                    NomePai = paciente.NomePai,
                    Pais = paciente.Pais,
                    UF = paciente.UF,
                    NumeroConvenio = paciente.NumeroConvenio,
                    Numero = paciente.Numero,
                    Telefone = paciente.Telefone,
                    Rg = paciente.Rg,
                    TipoSanguineo = paciente.TipoSanguineo
                };

                // retorna a view Detail
                return View(model);

            }

            // se o paciente não for encontrado, retorna a view Index, com a mensagem "Paciente não existe"
            ViewBag.Texto = "Paciente não existe";
            return View("Index");
        }

    } 
}
