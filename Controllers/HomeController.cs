using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index(int? id = 1)
        {
            MergeClass mrgClass = new MergeClass();
            mrgClass.categoryName = Generic_Class.GetAllData<string>("Categories").ToList();
            mrgClass.mainList = Generic_Class.GetAllData<Post>("AllData");
            return View(mrgClass);
        }

        [HttpGet]
        public ActionResult AddOrEdit(int? id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);
                return View(Generic_Class.GetAllData<Post>("PostListID",param).FirstOrDefault<Post>());
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(Post postInformation)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ID", postInformation.ID);
            param.Add("@title", postInformation.Title);
            param.Add("@content", postInformation.Content);
            param.Add("@short_content", postInformation.Short_Content); 
            param.Add("@category_name", postInformation.Category_Name);
            
            param.Add("@create_time", DateTime.Now);
            param.Add("@update_time", DateTime.Now);
            Generic_Class.ExecuteCommand("PostAddOrEdit",param);
            return RedirectToAction("Index");
        }

        
        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", id);
            Generic_Class.ExecuteCommand("PostDeleteID", param);
            return RedirectToAction("Index");
        }

        public ActionResult CategoryPost(string CategoryName)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@category_name", CategoryName);
            return View(Generic_Class.GetAllData<Post>("Category_Post",param));
        }

        public ActionResult DetailPage(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", id);
            MergeClass mrgClass = new MergeClass();
            mrgClass.categoryName = Generic_Class.GetAllData<string>("Categories").ToList();
            mrgClass.mainList = Generic_Class.GetAllData<Post>("PostListID", param).ToList();
            
            return View(mrgClass);
        }
    }
}