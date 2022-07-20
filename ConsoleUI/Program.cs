using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach(var user in userManager.GetAll())
            {
                Console.WriteLine("ID: " + user.ID +" User Name: "+user.FirstName+user.LastName+" User Identity Number: "+user.IdentityNumber+
                    " User Email: "+user.Email);
            }

            BidManager bidManager = new BidManager(new EfBidDal());
            foreach (var bid in bidManager.GetAll())
            {
                Console.WriteLine("\n BidID: "+bid.BidID+" Bid User id: "+bid.UserID+ " Bid Tender Id: "+bid.TenderID+
                    " Bid date: "+bid.BidDate+" Price: "+bid.BidPrice);
            }

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine("\n Category Id: "+category.CategoryID +" Category Title: "+category.CategoryTitle);
            }
        }
    }
}
