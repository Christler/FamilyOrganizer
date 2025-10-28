using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IFamilyData
    {
        Task InsertFamily(FamilyModel family);
        Task InsertUser(UserModel user);
        Task<IEnumerable<UserModel>> GetFamilyMembers(int id);
        Task InsertChore(ChoreModel chore);
        Task<IEnumerable<ChoreModel>> GetFamilyChores(int id);
        Task AssignChoreToUser(int choreID, int userID);
        Task UpdateChoreStatus(ChoreModel model);
        Task DeleteChore(int id);
    }
}