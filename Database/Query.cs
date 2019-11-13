using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace Database
{
    public class Query
    {
        private string ConnectionString = ActiveConnection.ConnectionString;

        public int TimeOut = 30 * 60;

        public async Task<DatabaseResult<T>> Select<T>(string query, object parameters)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    await db.OpenAsync();
                    return new DatabaseResult<T>() { Result = await db.QueryAsync<T>(query, parameters, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseResult<T>() { ErrorMessage = error.ToString(), HasError = true };
            }
        }
        
        public async Task<DatabaseResult<T>> Select<T>(string query)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    await db.OpenAsync();
                    return new DatabaseResult<T>() { Result = await db.QueryAsync<T>(query, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseResult<T>() { ErrorMessage = error.ToString(), HasError = true };
            }
        }

     
        public async Task<DatabaseSingleResult<T>> SelectSingle<T>(string query, object parameters)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    await db.OpenAsync();
                    return new DatabaseSingleResult<T>() { Result = await db.QuerySingleOrDefaultAsync<T>(query, parameters, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseSingleResult<T>() { ErrorMessage = error.ToString(), HasError = true };
            }
        }

        public async Task<DatabaseSingleResult<T>> SelectSingle<T>(string query)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    await db.OpenAsync();
                    return new DatabaseSingleResult<T>() { Result = await db.QuerySingleOrDefaultAsync<T>(query, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseSingleResult<T>() { ErrorMessage = error.ToString(), HasError = true };
            }
        }

        public async Task<DatabaseExecuteResult> Execute(string query, object parameters)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    await db.OpenAsync();
                    return new DatabaseExecuteResult() { Count = await db.ExecuteAsync(query, parameters, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseExecuteResult() { ErrorMessage = error.ToString(), HasError = true };
            }
        }

        public async Task<DatabaseExecuteResult> Execute(string query, DynamicParameters parameters)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    await db.OpenAsync();
                    return new DatabaseExecuteResult() { Count = await db.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseExecuteResult() { ErrorMessage = error.ToString(), HasError = true };
            }
        }

        public async Task<DatabaseExecuteResult> Execute(string query)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    await db.OpenAsync();
                    return new DatabaseExecuteResult() { Count = await db.ExecuteAsync(query, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseExecuteResult() { ErrorMessage = error.ToString(), HasError = true };
            }
        }

        public DatabaseSingleResult<T> SelectSingleSync<T>(string query, object parameters)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    db.OpenAsync();
                    return new DatabaseSingleResult<T>() { Result = db.QuerySingleOrDefault<T>(query, parameters, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseSingleResult<T>() { ErrorMessage = error.ToString(), HasError = true };
            }
        }

        public async Task<DatabaseExecuteResult> Execute<T>(string query, List<T> list)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    await db.OpenAsync();
                    return new DatabaseExecuteResult() { Count = await db.ExecuteAsync(query, list) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseExecuteResult() { ErrorMessage = error.ToString(), HasError = true };
            }
        }
        public DatabaseExecuteResult ExecuteSync<T>(string query, List<T> list)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    db.Open();
                    return new DatabaseExecuteResult() { Count = db.Execute(query, list) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseExecuteResult() { ErrorMessage = error.ToString(), HasError = true };
            }
        }

        public DatabaseResult<T> SelectSync<T>(string query, object parameters)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    db.Open();
                    return new DatabaseResult<T>() { Result = db.Query<T>(query, parameters, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseResult<T>() { ErrorMessage = error.ToString(), HasError = true };
            }
        }

        public async Task<DatabaseResult<T>> Select<T>(string query, DynamicParameters parameters)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    await db.OpenAsync();

                    return new DatabaseResult<T>() { Result = await db.QueryAsync<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseResult<T>() { ErrorMessage = error.ToString(), HasError = true };
            }
        }
        public async Task<DatabaseExecuteResult> ExecuteAsync<T>(string query, List<T> list)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    await db.OpenAsync();
                    return new DatabaseExecuteResult() { Count = await db.ExecuteAsync(query, list) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseExecuteResult() { ErrorMessage = error.ToString(), HasError = true };
            }
        }
        public DatabaseExecuteResult ExecuteSync(string query, DynamicParameters parameters)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    db.OpenAsync();
                    return new DatabaseExecuteResult() { Count = db.Execute(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseExecuteResult() { ErrorMessage = error.ToString(), HasError = true };
            }
        }
        public DatabaseExecuteResult ExecuteSync(string query, object parameters)
        {
            try
            {
                using (var db = new SqlConnection(ConnectionString))
                {
                    db.OpenAsync();
                    return new DatabaseExecuteResult() { Count = db.Execute(query, parameters, commandTimeout: TimeOut) };
                }
            }
            catch (Exception error)
            {
                return new DatabaseExecuteResult() { ErrorMessage = error.ToString(), HasError = true };
            }
        }
    }
}