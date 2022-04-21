using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VocabularyProject.Models;

namespace VocabularyProject.Controllers
{
    public class WordDefinitionController : Controller
    {
        IWordDefinitionRepository _repository;
        ILanguageRepository _langRepository;

        public WordDefinitionController(IWordDefinitionRepository repository, ILanguageRepository langRepository)
        {
            _repository = repository;
            _langRepository = langRepository;
        }
        // GET: WordDefinitionController
        public ActionResult Index()
        {
            List<WordDefinitionViewModel> model = new List<WordDefinitionViewModel>();
            List<WordDefinition> liste = _repository.List();

            foreach (WordDefinition item in liste)
            {
                WordDefinitionViewModel wdvm = new WordDefinitionViewModel()
                {
                    Id = item.Id,
                    Word = item.Word,
                    LangId = item.LangId,
                    LangText = item.Lang.Code,
                };


                model.Add(wdvm);
            }
            return View(model);
        }

        // GET: WordDefinitionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WordDefinitionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WordDefinitionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WordDefinitionController/Edit/5
        public ActionResult Edit(int? id)
        {
            WordDefinitionViewModel model = new WordDefinitionViewModel();
            if (id.HasValue && id > 0)
            {
                WordDefinition wdefinition = _repository.GetById(id.Value);
                model.Id = wdefinition.Id;
                model.Word = wdefinition.Word;
                model.LangId = wdefinition.LangId;
            }
            return View(model);
        }

        // POST: WordDefinitionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WordDefinitionViewModel model)
        {
            WordDefinition entity = new WordDefinition()
            {

                Id = model.Id,
                Word = model.Word,
                LangId = model.LangId,
            };
            if (entity.Id > 0)
            {
                _repository.Update(entity);
            }
            else
            {
                _repository.Add(entity);
            }
            return RedirectToAction("Index");
        }

        // GET: WordDefinitionController/Delete/5
        public ActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        // POST: WordDefinitionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
