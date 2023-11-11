class UserManager
{
    private List<User> users;

    public UserManager()
    {
        users = new List<User>();
    }

    public void AddUser(User user)
    {
        users.Add(user);
        Console.WriteLine("User added successfully!");
    }

    public void DisplayAllUsers()
    {
        if (users.Count == 0)
        {
            Console.WriteLine("No users added yet. Add a user first.");
            return;
        }

        Console.WriteLine("User List:");

        foreach (var user in users)
        {
            user.DisplayUserInfo();
        }
    }
}