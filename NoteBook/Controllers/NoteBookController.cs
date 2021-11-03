using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text;


namespace NoteBook.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NoteBookController : ControllerBase
    {
        NoteBook noteBook = new NoteBook();
        [HttpGet]
        public string[] GetAllNotes()
        {
            return noteBook.GetAllNotes();
        }
        [HttpPost]
        public void TakeNote(string note)
        {
            noteBook.TakeNote(note);
        }
    }
}
