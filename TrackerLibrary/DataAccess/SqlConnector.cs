﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db_name = "Tournaments";
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db_name)))
            {
               
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;

            }
        }

        /// <summary>
        /// Saves a new prize to the database 
        /// </summary>
        /// <param name="model">the prize information in the PrizeModel Class/Object</param>
        /// <returns>The prize info, including its unique id</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db_name)))
            {
             //   @PlaceNumber int,
             //   @PlaceName nvarchar(50),
	            //@PrizeAmount money,
             //   @PrizePercentage float,
             //   @id int = 0 output
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType:DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            
            }
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db_name)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");
                foreach (PersonModel TeamMember in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", TeamMember.Id);
                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }

                return model;
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output; 
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db_name)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").AsList();
            }
            return output;
        }

        public List<TeamModel> GetTeam_ALL()
        {
            List<TeamModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db_name)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").AsList();
                foreach (TeamModel team in output)
                {

                    var TeamIdParameter = new DynamicParameters();
                    TeamIdParameter.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeamId", TeamIdParameter, commandType: CommandType.StoredProcedure).AsList();
                }
            }
            return output;
        }
    }
}
