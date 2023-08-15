using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using C_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace C_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger,MyContext context)
        {
            _logger = logger;
            _context = context;
        }//adding some very inportant stuff

        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            ViewBag.hidden = true;
            return View();
        }

        //route to register a new user
        [HttpPost("create/user")]
        public IActionResult createUser(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(l => l.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId );
                return RedirectToAction("Dashboard");
            } else{
                ViewBag.hidden = true;
                return View("Index");
            }
            
        }

        //User to log in if you already have an account by comparing entry to what is in the database
        [HttpPost("login/user")]
        public IActionResult LoginUser(UserLogin loginUser)
        {
            if(ModelState.IsValid)
            {
                //find the user based on the email and return error if they are not in the data base
                User userInDb = _context.Users.FirstOrDefault(l => l.Email == loginUser.LoginEmail);
                if(userInDb == null)
                {
                    
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                //compare the passwords
                PasswordHasher<UserLogin> Hasher = new PasswordHasher<UserLogin>();
                var result = Hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LoginPassword);
                if(result == 0 )
                {
                    //means that the passwords did not match
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
            HttpContext.Session.SetInt32("UserId", userInDb.UserId );
            return RedirectToAction("Dashboard");
            } else {
                ViewBag.hidden = true;
                return View("Index");
            }
        }
        //http get for dashboard/home that will show the logged in user profile
        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.LoggedUser = _context.Users.FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
            ViewBag.AllPost = _context.UserPosts.OrderByDescending(l => l.CreatedAt).Include(l => l.PostedBY).ToList();
            return View("Dashboard");
        }

        // Create a post and add it to the database
        [HttpGet("CreatePost")]
        public IActionResult CreatePost()
        {
            ViewBag.LoggedUser = _context.Users.FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
            return View("CreatePost");
        }

        [HttpPost("ProcessCreatePost")]
        public IActionResult ProcessCreatePost(UserPost newUserPost)
        {
            if(ModelState.IsValid)
            {
                _context.UserPosts.Add(newUserPost);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            } else {
                ViewBag.LoggedUser = _context.Users.FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
                return View("CreatePost");
            }
        }

        // updated the database with profile pick that the User chooses from google 
        [HttpGet("AddProfilePic")]
        public IActionResult AddProfilePic()
        {
            ViewBag.LoggedUser = _context.Users.FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
            return View("AddProfilePic");
        }

        [HttpPost("ProcessAddProfilePic")]
        public IActionResult ProcessAddProfilePic(Photo newPhoto)
        {
            if(ModelState.IsValid)
            {
                User oldUser = _context.Users.FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
                oldUser.Photo = newPhoto.ProfilePic;
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            } else {
                ViewBag.LoggedUser = _context.Users.FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
                return View("AddProfilePic");
            }
        }
        //used to view one user and their post. Will also have the option to friend them.
        [HttpGet("ViewLoggedUser/{uId}")]
        public IActionResult ViewOneUser()
        {
            ViewBag.LoggedUser = _context.Users.FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
            ViewBag.AllPost = _context.UserPosts.OrderBy(l => l.CreatedAt).Include(l => l.PostedBY).Where(l => l.PostedBY.UserId == (int) HttpContext.Session.GetInt32("UserId")).ToList();
            return View("ViewLoggedUser");
        }

        // Delete a post
        [HttpGet("DeletePost/{upId}")]
        public IActionResult Delete(int upId)
        {
            UserPost UserPostToRemove = _context.UserPosts.SingleOrDefault(l => l.UserPostId == upId);
            _context.UserPosts.Remove(UserPostToRemove);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        //Page to view all users
        [HttpGet("ViewAllUsers")]
        public IActionResult ViewAllUsers()
        {
            ViewBag.AllUsers = _context.Users.ToList();
            return View("ViewAllUsers");
        }

        //Page to view one selected users profile
        [HttpGet("ViewOneUser/{uId}")]
        public IActionResult ViewOneUser(int uId)
        {
            ViewBag.LoggedUser = _context.Users.FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
            ViewBag.UserFriendList = _context.Users.Include(l => l.Friend).ThenInclude(l => l.Friend).FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
            ViewBag.AllPost = _context.UserPosts.OrderByDescending(l => l.CreatedAt).Include(l => l.PostedBY).Where(l => l.PostedBY.UserId == uId).ToList();
            ViewBag.OneUser = _context.Users.FirstOrDefault(l => l.UserId == uId);
            return View("ViewOneUser");
        }

        // Add a friend
        [HttpGet("AddFriend/{uId}")]
        public IActionResult AddFriend(int uId)
        {
            FriendList newFriend = new FriendList();
            newFriend.FriendId = uId;
            newFriend.UserId = (int) HttpContext.Session.GetInt32("UserId");
            _context.FriendLists.Add(newFriend);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        //view Logged in users friend list
        [HttpGet("ViewFriends")]
        public IActionResult ViewFriends()
        {
            ViewBag.LoggedUser = _context.Users.FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
            ViewBag.UserFriendList = _context.Users.Include(l => l.Friend).ThenInclude(l => l.Friend).FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
            return View("ViewFriends");
        }

        //View a list of your friend's friendlist
        [HttpGet("ViewUsersFriends/{uId}")]
        public IActionResult ViewUsersFriends(int uId)
        {
            ViewBag.OneUser = _context.Users.FirstOrDefault(l => l.UserId == uId);
            ViewBag.FriendFriendlist = _context.Users.Include(l => l.Users).ThenInclude(l => l.Users).FirstOrDefault(l => l.UserId == uId);
            return View("ViewUsersFriendlist");
        }

        //Direct Messege stuff i will do later maybe.
        [HttpGet("ViewDirectMesseges")]
        public IActionResult DirectMesseges()
        {
            return View("DirectMesseges");
        }

        //Unfriend Someone
        [HttpGet("RemoveFriend/{uId}")]
        public IActionResult RemoveFriend(int uId)
        {
            FriendList FriendToRemove = _context.FriendLists.SingleOrDefault(l => l.FriendId == uId);
            _context.FriendLists.Remove(FriendToRemove);
            _context.SaveChanges();
            return RedirectToAction("ViewFriends");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
