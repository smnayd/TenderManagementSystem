using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserTest();
            BidTest();
            CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine("\n Category Id: " + category.CategoryID + " Category Title: " + category.CategoryTitle);
            }
        }

        private static void BidTest()
        {
            BidManager bidManager = new BidManager(new EfBidDal());
            foreach (var bid in bidManager.GetAll())
            {
                Console.WriteLine("\n BidID: " + bid.BidID + " Bid User id: " + bid.UserID + " Bid Tender Id: " + bid.TenderID +
                    " Bid date: " + bid.BidDate + " Price: " + bid.BidPrice);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("ID: " + user.ID + " User Name: " + user.FirstName + user.LastName + " User Identity Number: " + user.IdentityNumber +
                    " User Email: " + user.Email);
            }
        }
    }
}
