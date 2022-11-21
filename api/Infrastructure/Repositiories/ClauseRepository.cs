

using Domain.Entities;
using Domain.Interface;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositiories
{
    public class ClauseRepository : IClauseRepository
    {
        private readonly DataContext _context;
        
        public ClauseRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ClauseText>> ShowAllClauses()
        {
            return await _context.clauseTexts.ToListAsync(); 
        }

        public async Task<IEnumerable<ClauseLeft>> ShowAllLeftClause()
        {
            return await _context.clauseLefts.ToListAsync();
        }

        public async Task<IEnumerable<ClauseRight>> ShowAllRightClause()
        {
            return await _context.clauseRights.ToListAsync();
        }



        public async Task<ClauseLeft> AddLeftClause(ClauseLeft clauseLeft)
        {
            var result = await _context.clauseLefts.AddAsync(clauseLeft);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<ClauseRight> AddRightClause(ClauseRight clauseRight)
        {
            var result = await _context.clauseRights.AddAsync(clauseRight);
            await _context.SaveChangesAsync();
            return result.Entity;
        }


        public async Task<ClauseLeft> GetLeftClauseById(int id)
        {
            return await _context.clauseLefts.FindAsync(id);
        }

        public async Task<ClauseLeft> DeleteLeftClauseByClause(string Clause)
        {
            var result = await _context.clauseLefts.FirstOrDefaultAsync(x => x.Clause == Clause);

            if(result != null)
            {
                _context.clauseLefts.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<ClauseText> GetClauseTextByClauseName(string ClauseName)
        {
            var result = await _context.clauseTexts.FirstOrDefaultAsync(x => x.ClauseName == ClauseName);

            if(result != null)
            {
                _context.clauseTexts.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<ClauseRight> GetRightClauseById(int id)
        {
            return await _context.clauseRights.FindAsync(id);
        }

        public async Task<ClauseRight> DeleteRightClauseByClause(string Clause)
        {
            var result = await _context.clauseRights.FirstOrDefaultAsync(x => x.Clause == Clause);

            if (result != null)
            {
                _context.clauseRights.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }



        public async Task<ClauseText> AddClauseText(ClauseText clauseText)
        {
            var result = await _context.clauseTexts.AddAsync(clauseText);
            await _context.SaveChangesAsync();
            return result.Entity;
        }


        public async Task StoredProcedure()
        {
            await _context.Database.ExecuteSqlRawAsync("EXEC [dbo].[Initializer]");
        }

    

        // Remove data from Clause Text and Clause Right on Reset
    }
}