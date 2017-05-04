

using System;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC_Application.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }

    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {
    }
}