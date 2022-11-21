using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IClauseRepository
    {
        Task<IEnumerable<ClauseText>> ShowAllClauses();
        Task<IEnumerable<ClauseLeft>> ShowAllLeftClause();
        Task<IEnumerable<ClauseRight>> ShowAllRightClause();
        Task<ClauseLeft> AddLeftClause(ClauseLeft clauseLeft);
        Task<ClauseRight> AddRightClause(ClauseRight clauseRight);
        Task<ClauseLeft> GetLeftClauseById(int id);
        Task<ClauseLeft> DeleteLeftClauseByClause(string Clause);
        Task<ClauseRight> GetRightClauseById(int id);
        Task<ClauseRight> DeleteRightClauseByClause(string Clause);   
        Task<ClauseText> AddClauseText(ClauseText clauseText);  
        Task<ClauseText> GetClauseTextByClauseName(string ClauseName);
        Task StoredProcedure();
    }
}