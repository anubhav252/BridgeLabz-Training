using System;

namespace SocialMediaFriendConnections
{
   class FriendNode
   {
       public int FriendId;
       public FriendNode Next;

       public FriendNode(int id)
       {
           FriendId = id;
           Next = null;
       }
   }

   class UserNode
   {
       public int UserId;
       public string Name;
       public int Age;
       public FriendNode Friends;
       public UserNode Next;

       public UserNode(int id, string name, int age)
       {
           UserId = id;
           Name = name;
           Age = age;
           Friends = null;
           Next = null;
       }
   }

   class SocialMediaUtility
   {
       private UserNode head;

       public void AddUser(int id, string name, int age)
       {
           UserNode newUser = new UserNode(id, name, age);
           newUser.Next = head;
           head = newUser;
       }

       private UserNode FindUserById(int id)
       {
           UserNode temp = head;
           while (temp != null)
           {
               if (temp.UserId == id)
                   return temp;
               temp = temp.Next;
           }
           return null;
       }

       public void SearchUserById(int id)
       {
           UserNode user = FindUserById(id);
           if (user != null)
               DisplayUser(user);
           else
               Console.WriteLine("User not found");
       }

       public void SearchUserByName(string name)
       {
           UserNode temp = head;
           bool found = false;

           while (temp != null)
           {
               if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
               {
                   DisplayUser(temp);
                   found = true;
               }
               temp = temp.Next;
           }

           if (!found)
               Console.WriteLine("User not found");
       }

       public void AddFriendConnection(int userId1, int userId2)
       {
           UserNode user1 = FindUserById(userId1);
           UserNode user2 = FindUserById(userId2);

           if (user1 == null || user2 == null)
           {
               Console.WriteLine("One or both users not found");
               return;
           }

           AddFriend(user1, userId2);
           AddFriend(user2, userId1);

           Console.WriteLine("Friend connection added");
       }

       private void AddFriend(UserNode user, int friendId)
       {
           FriendNode newFriend = new FriendNode(friendId);
           newFriend.Next = user.Friends;
           user.Friends = newFriend;
       }

       public void RemoveFriendConnection(int userId1, int userId2)
       {
           UserNode user1 = FindUserById(userId1);
           UserNode user2 = FindUserById(userId2);

           if (user1 == null || user2 == null)
           {
               Console.WriteLine("One or both users not found");
               return;
           }

           RemoveFriend(user1, userId2);
           RemoveFriend(user2, userId1);

           Console.WriteLine("Friend connection removed");
       }

       private void RemoveFriend(UserNode user, int friendId)
       {
           FriendNode temp = user.Friends;
           FriendNode prev = null;

           while (temp != null)
           {
               if (temp.FriendId == friendId)
               {
                   if (prev == null)
                       user.Friends = temp.Next;
                   else
                       prev.Next = temp.Next;
                   return;
               }
               prev = temp;
               temp = temp.Next;
           }
       }

       public void DisplayFriends(int userId)
       {
           UserNode user = FindUserById(userId);
           if (user == null)
           {
               Console.WriteLine("User not found");
               return;
           }

           Console.Write("Friends of " + user.Name + ": ");
           FriendNode temp = user.Friends;

           if (temp == null)
           {
               Console.WriteLine("No friends");
               return;
           }

           while (temp != null)
           {
               Console.Write(temp.FriendId + " ");
               temp = temp.Next;
           }
           Console.WriteLine();
       }

       public void FindMutualFriends(int userId1, int userId2)
       {
           UserNode user1 = FindUserById(userId1);
           UserNode user2 = FindUserById(userId2);

           if (user1 == null || user2 == null)
           {
               Console.WriteLine("One or both users not found");
               return;
           }

           Console.Write("Mutual Friends: ");
           FriendNode f1 = user1.Friends;
           bool found = false;

           while (f1 != null)
           {
               FriendNode f2 = user2.Friends;
               while (f2 != null)
               {
                   if (f1.FriendId == f2.FriendId)
                   {
                       Console.Write(f1.FriendId + " ");
                       found = true;
                   }
                   f2 = f2.Next;
               }
               f1 = f1.Next;
           }

           if (!found)
               Console.Write("None");

           Console.WriteLine();
       }

       public void CountFriends()
       {
           UserNode temp = head;

           while (temp != null)
           {
               int count = 0;
               FriendNode f = temp.Friends;

               while (f != null)
               {
                   count++;
                   f = f.Next;
               }

               Console.WriteLine(temp.Name + " has " + count + " friends");
               temp = temp.Next;
           }
       }

       private void DisplayUser(UserNode user)
       {
           Console.WriteLine("User ID: " + user.UserId +", Name: " + user.Name +", Age: " + user.Age);
       }
   }

   class Program
   {
       static void Main(string[] args)
       {
           SocialMediaUtility socialMedia = new SocialMediaUtility();

           socialMedia.AddUser(1, "Alice", 22);
           socialMedia.AddUser(2, "Bob", 24);
           socialMedia.AddUser(3, "Charlie", 23);
           socialMedia.AddUser(4, "Diana", 21);

           socialMedia.AddFriendConnection(1, 2);
           socialMedia.AddFriendConnection(1, 3);
           socialMedia.AddFriendConnection(2, 3);
           socialMedia.AddFriendConnection(2, 4);

           Console.WriteLine("\nFriends List:");
           socialMedia.DisplayFriends(1);

           Console.WriteLine("\nMutual Friends between 1 and 2:");
           socialMedia.FindMutualFriends(1, 2);

           Console.WriteLine("\nSearch User by Name:");
           socialMedia.SearchUserByName("Charlie");

           Console.WriteLine("\nFriend Count:");
           socialMedia.CountFriends();

           Console.WriteLine("\nRemove Friend Connection:");
           socialMedia.RemoveFriendConnection(1, 2);
           socialMedia.DisplayFriends(1);
       }
   }
}
