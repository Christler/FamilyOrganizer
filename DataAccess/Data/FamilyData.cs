using DataAccess.DbAcces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class FamilyData : IFamilyData
    {
        private readonly ISqlDataAccess _db;
        public FamilyData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task InsertFamily(FamilyModel family)
        {
            return _db.SaveData(
                storedProcedure: "dbo.spAddFamily",
                new
                {
                    family.Name
                });
        }

        public Task InsertUser(UserModel user)
        {
            return _db.SaveData(
                storedProcedure: "dbo.spAddUser",
                new
                {
                    user.Username,
                    user.IsParent,
                    user.FamilyID
                });
        }

        public Task<IEnumerable<UserModel>> GetFamilyMembers(int id)
        {
            return _db.LoadData<UserModel, dynamic>(storedProcedure: "dbo.spGetUsersByFamily", new { FamilyID = id });
        }

        public Task InsertChore(ChoreModel chore)
        {
            return _db.SaveData(
                storedProcedure: "dbo.spAddChore",
                new
                {
                    chore.Name,
                    chore.FamilyID,
                    chore.AssignedToUserID
                });
        }

        public Task<IEnumerable<ChoreModel>> GetFamilyChores(int id)
        {
            return _db.LoadData<ChoreModel, dynamic>(storedProcedure: "dbo.spGetChoresByFamily", new { FamilyID = id });
        }

        public Task AssignChoreToUser(int choreID, int userID)
        {
            return _db.SaveData(
                storedProcedure: "dbo.spAssignChoreToUser",
                new 
                {
                    ChoreID = choreID,
                    UserID = userID
                });
        }

        public Task UpdateChoreStatus(ChoreModel chore)
        {
            string status = chore.Status == "Todo" ? "Done" : "Todo";
            return _db.SaveData(
                storedProcedure: "dbo.spUpdateChoreStatus",
                new
                {
                    ChoreID = chore.ID,
                    Status = status
                });
        }

        public Task DeleteChore(int id)
        {
            return _db.SaveData(
                storedProcedure: "dbo.spDeleteChore",
                new { ChoreID = id });
        }
    }
}
