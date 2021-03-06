public static async Task<string> CreateNewGame()
    {
        string newObjectId = null;

        ParseObject myGame = new ParseObject("Games");
        myGame["score"] = 223;
        myGame["playerName"] = "Michael";

        await myGame.SaveAsync().ContinueWith(
              t =>
              {
                  newObjectId = myGame.ObjectId;
              });

        return newObjectId;
    }

---------------------------------------------------------
string result = null;
var dataset = new object();

try
{
    var db = new ParseObject("project");
    db["guid"] = Guid.NewGuid().ToString();
    db["first_name"] = "FirstName";
    db["last_name"] = "LastName";
    db["dob"] = DateTime.UtcNow.AddDays(new Random().Next(90));

    await db.SaveAsync().ContinueWith(
          t =>{
                dataset = db;
              });
}
catch (Exception exception)
{
    throw new Exception(exception.Message);
}

var lk = dataset;

return result;
