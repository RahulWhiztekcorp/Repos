using Dapper;
using DapperCoreAPI.Dapper.Interface;
using DapperCoreAPI.Models;
using DapperCoreAPI.Repository.Interface;
using System.Data;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DapperCoreAPI.Repository.Implimentaions
{
    public class BranchRepository : IBranchRepository
    {
        private readonly IDapperContext _context;
        public BranchRepository(IDapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Branch>> GetAllAsync()
        {
            var query = "SELECT * FROM " + typeof(Branch).Name;
            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<Branch>(query);
                return result.ToList();
            }
        }
        public async Task<Branch> GetByIdAsync(Int64 id)
        {
            var query = "SELECT * FROM " + typeof(Branch).Name + " WHERE Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QuerySingleOrDefaultAsync<Branch>(query, new { id });
                return result;
            }
        }
        public async Task Create(Branch _Branch)
        {
            var query = "INSERT INTO " + typeof(Branch).Name + " (Name, Description, CreatedDate,UpdatedDate) VALUES (@Name, @Description, @CreatedDate, @UpdatedDate)";
            var parameters = new DynamicParameters();
            parameters.Add("Name", _Branch.Name, DbType.String);
            parameters.Add("Description", _Branch.Description, DbType.String);
            parameters.Add("CreatedDate", _Branch.CreatedDate, DbType.DateTime);
            parameters.Add("UpdatedDate", _Branch.UpdatedDate, DbType.DateTime);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async Task Update(Branch _Branch)
        {
            var query = "UPDATE " + typeof(Branch).Name + " SET Name = @Name, Description = @Description, UpdatedDate = @UpdatedDate WHERE Id = @Id";
            var parameters = new DynamicParameters();
            parameters.Add("Id", _Branch.Id, DbType.Int64);
            parameters.Add("Name", _Branch.Name, DbType.String);
            parameters.Add("Description", _Branch.Description, DbType.String);
            parameters.Add("UpdatedDate", _Branch.UpdatedDate, DbType.DateTime);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async Task Delete(Int64 id)
        {
            var query = "DELETE FROM " + typeof(Branch).Name + " WHERE Id = @Id";
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, new { id });
            }
        }
    }


public static class BranchEndpoints
{
	public static void MapBranchEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Branch").WithTags(nameof(Branch));

        group.MapGet("/", () =>
        {
            return new [] { new Branch() };
        })
        .WithName("GetAllBranches")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new Branch { ID = id };
        })
        .WithName("GetBranchById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, Branch input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateBranch")
        .WithOpenApi();

        group.MapPost("/", (Branch model) =>
        {
            //return TypedResults.Created($"/api/Branches/{model.ID}", model);
        })
        .WithName("CreateBranch")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new Branch { ID = id });
        })
        .WithName("DeleteBranch")
        .WithOpenApi();
    }
}}
