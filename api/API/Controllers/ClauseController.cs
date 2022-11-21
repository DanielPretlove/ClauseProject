using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    public class ClauseController : BaseApiController
    {
        private readonly IClauseRepository _clauserepository;

        public ClauseController(IClauseRepository clauseRepository)
        {
            _clauserepository = clauseRepository;
        }

        [HttpGet("clauseText")]
        public async Task<ActionResult<ClauseText>> GetAllClauseText()
        {
            var result = await _clauserepository.ShowAllClauses();
            return Ok(result);
        }

        [HttpGet("clauseLeft")]
        public async Task<ActionResult<ClauseLeft>> GetAllClauseLefts()
        {
            var result = await _clauserepository.ShowAllLeftClause();
            return Ok(result);
        }

        [HttpGet("clauseRight")]
        public async Task<ActionResult<ClauseRight>> GetAllClauseRights()
        {
            var result = await _clauserepository.ShowAllRightClause();
            return Ok(result);
        }

        [HttpPost("clauseLeft")]
        public async Task<ActionResult<ClauseLeft>> AddLeftClause(ClauseLeft clauseLeft)
        {
            return await _clauserepository.AddLeftClause(clauseLeft);
        }

        [HttpPost("clauseRight")]
        public async Task<ActionResult<ClauseRight>> AddRightClause(ClauseRight clauseRight)
        {
            return await _clauserepository.AddRightClause(clauseRight);
        }


        [HttpGet("clauseLeft/{id:int}")]
        public async Task<ActionResult<ClauseLeft>> GetClauseLeftById(int id)
        {
            var result = await _clauserepository.GetLeftClauseById(id);

            if(result == null)
            {
                return NotFound();
            }

            return result;
        }


        [HttpGet("clauseText/{clauseName}")]
        public async Task<ActionResult<ClauseText>> GetClauseTextByClauseName(string clauseName)
        {
            var result = await _clauserepository.GetClauseTextByClauseName(clauseName);

            if(result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpDelete("clauseLeft/{clause}")]
        public async Task<ActionResult<ClauseLeft>> DeleteLeftClause(string Clause)
        {
            try
            {

                return await _clauserepository.DeleteLeftClauseByClause(Clause);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("clauseRight/{ClauseId:int}")]
        public async Task<ActionResult<ClauseRight>> GetClauseRightById(int id)
        {
            var result = await _clauserepository.GetRightClauseById(id);

            if(result == null)
            {
                return NotFound();
            }

            return result;
        }


        [HttpDelete("clauseRight/{clause}")]
        public async Task<ActionResult<ClauseRight>> DeleteRightClause(string Clause)
        {
             try
            {
                return await _clauserepository.DeleteRightClauseByClause(Clause);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }           
        }


        [HttpPost("clauseText")]
        public async Task<ActionResult<ClauseText>> AddClauseRightToClauseText(ClauseText clauseText)
        {
            return  await _clauserepository.AddClauseText(clauseText);
        }


        [HttpGet("initializer")]
        public async Task Initializer()
        {
            await _clauserepository.StoredProcedure();
        }

    }
}