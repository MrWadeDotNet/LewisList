using LewisList.Models;
using LewisList.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LewisList.Controllers
{
    public class PostController : AppController
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext();

        // GET: Post
        public ActionResult Index(int? Id)
        {          
            PostViewModel vm = new PostViewModel();
                      
            vm.Posts = dbContext.Posts;
            // ViewBag.DisplayPosts= vm.Posts;
            ViewBag.Category = dbContext.Categories;

            vm.Categories = dbContext.Categories.ToList();


            if (Id != null)
            {
                
                ViewBag.MessageId = Id.Value;
            }

            return View(vm);
        }
        public ActionResult Browse (int? Id = 0)
        {

            PostViewModel vm = new PostViewModel();
                        
            vm.Posts = dbContext.Posts.Where(p => p.Category == Id);

           return View(vm);
        }

        public ActionResult View(int? Id = 0)
        {
            if (Id == 0)
            {
                return Redirect("/Post");
            }
            else
            {
                PostViewModel vm = new PostViewModel();
                int? pageId = Id;

                vm.Posts = dbContext.Posts.Where(p => p.PostId == pageId);
                vm.Categories = dbContext.Categories.Where(c => c.CategoryId == pageId).ToList();

               return View(vm);
            }
             
        }

        public ActionResult Create()
        {
            PostViewModel vm = new PostViewModel();


            var categories = dbContext.Categories.ToList();
            /*     var categories = new Category
                 {
                     Categories = dbContext.Categories.ToList()
                 };
                 */
            ViewBag.ProjectData = categories;

            return View(vm);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(PostViewModel viewModel, int categoryId)
        {
            var username = User.Identity.Name;
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            int postId = 0;
            var currentUser = manager.FindById(User.Identity.GetUserId());

            var userTelephone = currentUser.PhoneNumber;
            var userPostalCode = currentUser.ZipCode;    
             
            
            Post newPost = new Post();
            if (viewModel.Post.Subject != string.Empty && viewModel.Post.Description != string.Empty)
            {
                newPost.CreatedOn = DateTime.Now;
                newPost.Subject = viewModel.Post.Subject;
                newPost.Description = viewModel.Post.Description;
                newPost.Category = categoryId;
                newPost.PostalCode = userPostalCode;
                newPost.Telephone = userTelephone;
                newPost.Price = viewModel.Post.Price;
                newPost.Author = username;

                dbContext.Posts.Add(newPost);
                dbContext.SaveChanges();
                postId = newPost.PostId;
            }

            return RedirectToAction("Index", "Home", new { Id = postId });

        }


    }
}
