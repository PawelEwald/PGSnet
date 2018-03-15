using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;


namespace Pgs.Kanban.Domain.Services
{
    public class BoardController : Controller
    {
        private readonly BoardService _boardService;


        public BoardController()
        {
            _boardService = new BoardService();
        }
        [httpGet]
        public IActionResult GetBoard()
        {
            var response = _boardService.getBoard();
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }


    }
}
