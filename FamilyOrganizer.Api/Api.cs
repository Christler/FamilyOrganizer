namespace FamilyOrganizer.Api
{
    public static class Api
    {
        public static void ConfigureApi(this WebApplication app)
        {
            //Family Endpoints
            app.MapPost("/Family", InsertFamily);
            app.MapGet("/Family/{id}/Users", GetFamilyMembers);
            app.MapGet("/Family/{id}/Chores", GetFamilyChores);

            app.MapPost("/User", InsertUser);

            app.MapPost("/Chore", InsertChore);
            app.MapDelete("/Chore/{id}", DeleteChore);
            app.MapPut("/Chore/{choreID}/Assign/{userID}", AssignChoreToUser);
            app.MapPut("/Chore/Status", ChangeChoreStatus);
        }

        private static async Task<IResult> InsertFamily(FamilyModel family, IFamilyData familyData)
        {
            try
            {
                await familyData.InsertFamily(family);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertUser(UserModel user, IFamilyData familyData)
        {
            try
            {
                await familyData.InsertUser(user);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetFamilyMembers(int id, IFamilyData familyData)
        {
            try
            {
                return Results.Ok(await familyData.GetFamilyMembers(id));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetFamilyChores(int id, IFamilyData familyData)
        {
            try
            {
                return Results.Ok(await familyData.GetFamilyChores(id));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertChore(ChoreModel family, IFamilyData familyData)
        {
            try
            {
                await familyData.InsertChore(family);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> AssignChoreToUser(int choreID, int userID, IFamilyData familyData)
        {
            try
            {
                await familyData.AssignChoreToUser(choreID, userID);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> ChangeChoreStatus(ChoreModel chore, IFamilyData familyData)
        {
            try
            {
                await familyData.UpdateChoreStatus(chore);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteChore(int id, IFamilyData familyData)
        {
            try
            {
                await familyData.DeleteChore(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        //private static async Task<IResult> GetUser(int id, IUserData userData)
        //{
        //    try
        //    {
        //        var result = await userData.GetUserById(id);
        //        if(result == null)
        //        {
        //            return Results.NotFound();
        //        }
        //        return Results.Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Results.Problem(ex.Message);
        //    }
        //}




    }
}
