// <auto-generated>
// ReSharper disable All

using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;
using System.Threading.Tasks;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // Instructor
    public class Instructor
    {
        public int InstructorId { get; set; } // InstructorID (Primary key)
        public string LastName { get; set; } // LastName
        public string FirstName { get; set; } // FirstName
        public DateTime HireDate { get; set; } // HireDate
        public string FullName { get; private set; } // FullName

        // Reverse navigation

        /// <summary>
        /// Child CourseInstructors where [CourseInstructor].[InstructorID] point to this entity (FK_dbo.CourseInstructor_dbo.Instructor_InstructorID)
        /// </summary>
        public ICollection<CourseInstructor> CourseInstructors { get; set; } // CourseInstructor.FK_dbo.CourseInstructor_dbo.Instructor_InstructorID
        
        [NotMapped]
        public List<Course> Courses
        {
            get
            {
                return CourseInstructors.Select(i => i.Course).ToList();
            }
        }
        /// <summary>
        /// Parent (One-to-One) Instructor pointed by [OfficeAssignment].[InstructorID] (FK_dbo.OfficeAssignment_dbo.Instructor_InstructorID)
        /// </summary>
        public OfficeAssignment OfficeAssignment { get; set; } // OfficeAssignment.FK_dbo.OfficeAssignment_dbo.Instructor_InstructorID

        public Instructor()
        {
            CourseInstructors = new List<CourseInstructor>();
        }
    }

}
// </auto-generated>
