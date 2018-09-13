using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment29thAugust.Models;
using Assignment29thAugust.Data;

namespace Assignment29thAugust.Controllers
{
    public class HomeController : Controller
    {
        List<TransactionViewModel> transactionData = TransactionData.GetTransaction();
        List<StudentViewModel> studentData = StudentData.GetStudent();
        public IActionResult Index()
        {
            
            
            List<StudentJoinedData> studentJointList = (from stdntData in studentData
                                                     join stdntTrans in transactionData
                                                     on stdntData.StudentId equals stdntTrans.StudentId
                                                        select new StudentJoinedData
                                                        {
                                                            StudentId = stdntData.StudentId,
                                                            StudentName = stdntData.StudentName,
                                                            StudentClass = stdntData.StudentClass,
                                                            StudentAge = stdntData.StudentAge,
                                                            StudentFees = stdntTrans.StudentFees,
                                                            Date = stdntTrans.Date
                                                        }
                                                    ).ToList();    //to convert the selected data into list
            //JointViewList recieveViewData = new JointViewList();
            //recieveViewData.StudentAllRecords = studentJointList;
            return View(studentJointList);
            //var model = StudentData.GetStudent();
            //return View(model);
        }

        public IActionResult SearchByName(Student student)
        {
            if (student.name != null)
            {
                var model = StudentData.GetStudentByName(student.name);
                if (model != null)
                {
                    return PartialView("_SingleStudentDetailPartial", model);
                }
            }
            return NotFound();
        }

        public IActionResult Search(SearchFilter searchFilter)
        {

            if (searchFilter.searchBy == "StudentName")
            {
                if (!string.IsNullOrWhiteSpace(searchFilter.text))
                {
                    var model = StudentData.GetStudentByName(searchFilter.text);

                    List<StudentViewModel> myModel = null;
                    if (searchFilter.sortBy != null)
                    {
                        myModel = sortMe(searchFilter.sortBy, model);
                    }
                    else
                    {
                        myModel = model;
                    }
                    if (myModel != null)
                    {
                        List<StudentJoinedData> myModel1 = getFilteredRange(myModel, searchFilter.minRange, searchFilter.maxRange);
                        return PartialView("_StudentDetails", myModel1);

                    }
                }
                else
                {
                    List<StudentJoinedData> myModel1 = getFilteredRange(studentData, searchFilter.minRange, searchFilter.maxRange);
                    return PartialView("_StudentDetails", myModel1);
                }
                
                
            }
            else if(searchFilter.searchBy == "StudentID")
            {
                if (!string.IsNullOrWhiteSpace(searchFilter.text))
                {
                    var model = StudentData.GetStudentById(Convert.ToInt32(searchFilter.text));

                    List<StudentViewModel> myModel = null;
                    if (searchFilter.sortBy != null)
                    {
                        myModel = sortMe(searchFilter.sortBy, model);
                    }
                    else
                    {
                        myModel = model;
                    }
                    if (myModel != null)
                    {
                        List<StudentJoinedData> myModel1 = getFilteredRange(myModel, searchFilter.minRange, searchFilter.maxRange);
                        return PartialView("_StudentDetails", myModel1);
                    }
                }
                else
                {
                    List<StudentJoinedData> myModel1 = getFilteredRange(studentData, searchFilter.minRange, searchFilter.maxRange);
                    return PartialView("_StudentDetails", myModel1);
                }
            }
            else if (searchFilter.searchBy == "StudentAge")
            {
                if (!string.IsNullOrWhiteSpace(searchFilter.text))
                {
                    var model = StudentData.GetStudentByAge(Convert.ToInt32(searchFilter.text));
                    List<StudentViewModel> myModel = null;
                    if (searchFilter.sortBy != null)
                    {
                        myModel = sortMe(searchFilter.sortBy, model);
                    }
                    else
                    {
                        myModel = model;
                    }
                    if (myModel != null)
                    {
                        List<StudentJoinedData> myModel1 = getFilteredRange(myModel, searchFilter.minRange, searchFilter.maxRange);
                        return PartialView("_StudentDetails", myModel1);
                    }
                }
                else
                {
                    List<StudentJoinedData> myModel1 = getFilteredRange(studentData, searchFilter.minRange, searchFilter.maxRange);
                    return PartialView("_StudentDetails", myModel1);
                }
            }
            else if (searchFilter.searchBy == "StudentClass")
            {
                if (!string.IsNullOrWhiteSpace(searchFilter.text))
                {
                    var model = StudentData.GetStudentByClass(Convert.ToInt32(searchFilter.text));
                    List<StudentViewModel> myModel = null;
                    if (searchFilter.sortBy != null)
                    {
                        myModel = sortMe(searchFilter.sortBy, model);
                    }
                    else
                    {
                        myModel = model;
                    }
                    if (myModel != null)
                    {
                        List<StudentJoinedData> myModel1 = getFilteredRange(myModel, searchFilter.minRange, searchFilter.maxRange);
                        return PartialView("_StudentDetails", myModel1);
                    }
                }
                else
                {
                    List<StudentJoinedData> myModel1 = getFilteredRange(studentData, searchFilter.minRange, searchFilter.maxRange);
                    return PartialView("_StudentDetails", myModel1);
                }
            }
            else
            {
                List<StudentJoinedData> myModel1 = getFilteredRange(studentData, searchFilter.minRange, searchFilter.maxRange);
                return PartialView("_StudentDetails", myModel1);
            }


            return NotFound();
        }

        public List<StudentViewModel> sortMe(string sortyBy, List<StudentViewModel> studentData)
        {
            if(sortyBy == "StudentID")
            {
                return studentData.OrderBy(x => x.StudentId).ToList(); // for order by ascending
                //return studentData.OrderByDescending(x => x.StudentId).ToList(); // For order by descending
            }
            else if (sortyBy == "StudentName")
            {
                return studentData.OrderBy(x => x.StudentName).ToList();
            }
            else if (sortyBy == "StudentClass")
            {
                return studentData.OrderBy(x => x.StudentClass).ToList();
            }
            else if (sortyBy == "StudentAge")
            {
                return studentData.OrderBy(x => x.StudentAge).ToList();
            }
            return null;
        }




        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public List<StudentJoinedData> getFilteredRange(List<StudentViewModel> model, double minRange, double maxRange)
        {
            List<StudentJoinedData> studentJointList1 = (from stdntData in model
                                                         join stdntTrans in transactionData
                                                        on stdntData.StudentId equals stdntTrans.StudentId
                                                         select new StudentJoinedData
                                                         {
                                                             StudentId = stdntData.StudentId,
                                                             StudentName = stdntData.StudentName,
                                                             StudentClass = stdntData.StudentClass,
                                                             StudentAge = stdntData.StudentAge,
                                                             StudentFees = stdntTrans.StudentFees,
                                                             Date = stdntTrans.Date
                                                         }
                                                     ).ToList();

            List<StudentJoinedData> studentJointEAddList = new List<StudentJoinedData>();

            if (minRange > 0 && maxRange > 0)
            {
               foreach(var item in studentJointList1)
                {
                    if (item.StudentFees >= minRange && item.StudentFees <= maxRange)
                    {
                        studentJointEAddList.Add(item);
                        //return studentJointList1;
                    }
                }
                return studentJointEAddList;
            }

            return studentJointList1;


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
