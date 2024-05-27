using SchemaConsumer.Shared.Model;
using YamlDotNet.Serialization;

namespace DiffChecker.Service;

public static class YamlProvider
{
    public static Dictionary<string, Schema> AllSchemes(IDeserializer deserializer) => deserializer
        .Deserialize<Dictionary<string, ObjectSchema>>(DefaultYaml)
        .ToDictionary(k => k.Key, v => v.Value as Schema);

    private const string DefaultYaml = """
                                       "SchemaExtractor.Model.Example.PersonDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "date"
                                           name: "BirthDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AddressDto"
                                           name: "Address"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.HobbyDto"
                                           name: "Hobbies"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.JobDto"
                                           name: "Job"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CalendarDto"
                                           name: "Calendar"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PhoneDto"
                                           name: "Phones"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.EmailDto"
                                           name: "Emails"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.VehicleDto"
                                           name: "Vehicles"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.FriendDto"
                                           name: "Friends"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.SubscriptionDto"
                                           name: "Subscriptions"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.MeetingDto"
                                           name: "Meetings"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PaymentDto"
                                           name: "Payments"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.BankAccountDto"
                                           name: "BankAccounts"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.InsuranceDto"
                                           name: "Insurances"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.TravelPlanDto"
                                           name: "TravelPlans"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.EducationDto"
                                           name: "Education"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.CaseDto"
                                           name: "Cases"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "PersonDto"
                                       "SchemaExtractor.Model.Example.AddressDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Street"
                                           nullable: false
                                         - type: "string"
                                           name: "City"
                                           nullable: false
                                         - type: "string"
                                           name: "State"
                                           nullable: false
                                         - type: "string"
                                           name: "ZipCode"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CountryDto"
                                           name: "Country"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Residents"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.BusinessDto"
                                           name: "Businesses"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "AddressDto"
                                       "SchemaExtractor.Model.Example.CountryDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "string"
                                           name: "Code"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AddressDto"
                                           name: "Addresses"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.SchoolDto"
                                           name: "Schools"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.HospitalDto"
                                           name: "Hospitals"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Citizens"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "CountryDto"
                                       "SchemaExtractor.Model.Example.SchoolDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AddressDto"
                                           name: "Address"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.EnrollmentDto"
                                           name: "Enrollments"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.CourseDto"
                                           name: "Courses"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "SchoolDto"
                                       "SchemaExtractor.Model.Example.EnrollmentDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Course"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Student"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.SchoolDto"
                                           name: "School"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "EnrollmentDto"
                                       "SchemaExtractor.Model.Example.CourseDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.SchoolDto"
                                           name: "School"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.TranscriptDto"
                                           name: "Transcript"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.EnrollmentDto"
                                           name: "Enrollments"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "CourseDto"
                                       "SchemaExtractor.Model.Example.TranscriptDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Student"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.SchoolDto"
                                           name: "School"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "TranscriptDto"
                                       "SchemaExtractor.Model.Example.HospitalDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AddressDto"
                                           name: "Address"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.DoctorDto"
                                           name: "Doctors"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PatientDto"
                                           name: "Patients"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "HospitalDto"
                                       "SchemaExtractor.Model.Example.DoctorDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.HospitalDto"
                                           name: "Hospital"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "DoctorDto"
                                       "SchemaExtractor.Model.Example.PatientDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.HospitalDto"
                                           name: "Hospital"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.MedicalRecordDto"
                                           name: "MedicalRecords"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "PatientDto"
                                       "SchemaExtractor.Model.Example.MedicalRecordDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Patient"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.DoctorDto"
                                           name: "Doctor"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PrescriptionDto"
                                           name: "Prescriptions"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.InsuranceClaimDto"
                                           name: "InsuranceClaim"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.BenefitDto"
                                           name: "Benefit"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "MedicalRecordDto"
                                       "SchemaExtractor.Model.Example.PrescriptionDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Medication"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.DoctorDto"
                                           name: "Doctor"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Patient"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "PrescriptionDto"
                                       "SchemaExtractor.Model.Example.InsuranceClaimDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "ClaimNumber"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Claimant"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.InsuranceDto"
                                           name: "Insurance"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "InsuranceClaimDto"
                                       "SchemaExtractor.Model.Example.InsuranceDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "PolicyNumber"
                                           nullable: false
                                         - type: "string"
                                           name: "Provider"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Insured"
                                           nullable: false
                                         - type: "double"
                                           name: "CoverageAmount"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PolicyDto"
                                           name: "Policy"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "InsuranceDto"
                                       "SchemaExtractor.Model.Example.PolicyDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "PolicyName"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "PolicyHolder"
                                           nullable: false
                                         - type: "double"
                                           name: "CoverageAmount"
                                           nullable: false
                                         - type: "date"
                                           name: "StartDate"
                                           nullable: false
                                         - type: "date"
                                           name: "EndDate"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.InsuranceDto"
                                           name: "Insurances"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "PolicyDto"
                                       "System.Nullable":
                                         type: "Object"
                                         extends: "System.ValueType"
                                         generics:
                                         - "T"
                                         properties:
                                         - type: "boolean"
                                           name: "HasValue"
                                           nullable: false
                                         - type: "date"
                                           name: "Value"
                                           nullable: false
                                         namespace: "System"
                                         name: "Nullable"
                                       "System.ValueType":
                                         type: "Object"
                                         abstract: true
                                         properties: []
                                         namespace: "System"
                                         name: "ValueType"
                                       "SchemaExtractor.Model.Example.BenefitDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Beneficiary"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.InsuranceDto"
                                           name: "Insurance"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "BenefitDto"
                                       "SchemaExtractor.Model.Example.BusinessDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AddressDto"
                                           name: "Location"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ProductDto"
                                           name: "Products"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Employees"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "BusinessDto"
                                       "SchemaExtractor.Model.Example.ProductDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: true
                                         - type: "double"
                                           name: "Price"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CompanyDto"
                                           name: "Manufacturer"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ReviewDto"
                                           name: "Reviews"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ProductDto"
                                       "SchemaExtractor.Model.Example.CompanyDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AddressDto"
                                           name: "Address"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.JobDto"
                                           name: "Jobs"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Employees"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.ProjectDto"
                                           name: "Projects"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "CompanyDto"
                                       "SchemaExtractor.Model.Example.JobDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Title"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.CompanyDto"
                                           name: "Company"
                                           nullable: false
                                         - type: "double"
                                           name: "Salary"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Employees"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.DepartmentDto"
                                           name: "Departments"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "JobDto"
                                       "SchemaExtractor.Model.Example.DepartmentDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CompanyDto"
                                           name: "Company"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.JobDto"
                                           name: "Jobs"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Employees"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.ForumDto"
                                           name: "InternalForum"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "DepartmentDto"
                                       "SchemaExtractor.Model.Example.ForumDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Title"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ThreadDto"
                                           name: "Threads"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.ActivityLogDto"
                                           name: "ActivityLog"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ForumDto"
                                       "SchemaExtractor.Model.Example.ThreadDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Title"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ForumDto"
                                           name: "Forum"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Creator"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CategoryDto"
                                           name: "Category"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PostDto"
                                           name: "Posts"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ThreadDto"
                                       "SchemaExtractor.Model.Example.CategoryDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ArticleDto"
                                           name: "Articles"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "CategoryDto"
                                       "SchemaExtractor.Model.Example.ArticleDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Title"
                                           nullable: false
                                         - type: "string"
                                           name: "Content"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Author"
                                           nullable: false
                                         - type: "date"
                                           name: "PublishedDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CommentDto"
                                           name: "Comments"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ArticleDto"
                                       "SchemaExtractor.Model.Example.CommentDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Content"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Author"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ArticleDto"
                                           name: "Article"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.TagDto"
                                           name: "Tags"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "CommentDto"
                                       "SchemaExtractor.Model.Example.TagDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ArticleDto"
                                           name: "Articles"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "TagDto"
                                       "SchemaExtractor.Model.Example.PostDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Content"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ThreadDto"
                                           name: "Thread"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Author"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AchievementDto"
                                           name: "Achievement"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "PostDto"
                                       "SchemaExtractor.Model.Example.AchievementDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "date"
                                           name: "DateAchieved"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Person"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "AchievementDto"
                                       "SchemaExtractor.Model.Example.ActivityLogDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Activity"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.NotificationDto"
                                           name: "Notifications"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ActivityLogDto"
                                       "SchemaExtractor.Model.Example.NotificationDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Message"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Recipient"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "NotificationDto"
                                       "SchemaExtractor.Model.Example.ProjectDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "TeamMembers"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.CompanyDto"
                                           name: "Company"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.TaskDto"
                                           name: "Tasks"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ProjectDto"
                                       "SchemaExtractor.Model.Example.TaskDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Title"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "AssignedTo"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ProjectDto"
                                           name: "Project"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "TaskDto"
                                       "SchemaExtractor.Model.Example.ReviewDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Content"
                                           nullable: false
                                         - type: "int32"
                                           name: "Rating"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Reviewer"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ProductDto"
                                           name: "Product"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ReviewDto"
                                       "SchemaExtractor.Model.Example.HobbyDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Participants"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.HobbyEquipmentDto"
                                           name: "Equipments"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "HobbyDto"
                                       "SchemaExtractor.Model.Example.HobbyEquipmentDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.HobbyDto"
                                           name: "Hobby"
                                           nullable: false
                                         - type: "double"
                                           name: "Price"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "HobbyEquipmentDto"
                                       "SchemaExtractor.Model.Example.CalendarDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Owner"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.MeetingDto"
                                           name: "Meetings"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.EventDto"
                                           name: "Events"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "CalendarDto"
                                       "SchemaExtractor.Model.Example.MeetingDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Title"
                                           nullable: false
                                         - type: "date"
                                           name: "StartTime"
                                           nullable: false
                                         - type: "date"
                                           name: "EndTime"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Participants"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.AddressDto"
                                           name: "Location"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AppointmentDto"
                                           name: "Appointment"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "MeetingDto"
                                       "SchemaExtractor.Model.Example.AppointmentDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "date"
                                           name: "AppointmentDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Person"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "AppointmentDto"
                                       "SchemaExtractor.Model.Example.EventDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Attendees"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.AddressDto"
                                           name: "Location"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.EventRegistrationDto"
                                           name: "Registration"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "EventDto"
                                       "SchemaExtractor.Model.Example.EventRegistrationDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.EventDto"
                                           name: "Event"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Participant"
                                           nullable: false
                                         - type: "date"
                                           name: "RegistrationDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.WorkshopDto"
                                           name: "Workshop"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "EventRegistrationDto"
                                       "SchemaExtractor.Model.Example.WorkshopDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "WorkshopName"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AddressDto"
                                           name: "Location"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.SessionDto"
                                           name: "Session"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "WorkshopDto"
                                       "SchemaExtractor.Model.Example.SessionDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "SessionName"
                                           nullable: false
                                         - type: "date"
                                           name: "StartTime"
                                           nullable: false
                                         - type: "date"
                                           name: "EndTime"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.WorkshopDto"
                                           name: "Workshop"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.FeedbackDto"
                                           name: "Feedback"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "SessionDto"
                                       "SchemaExtractor.Model.Example.FeedbackDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Content"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Author"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.SurveyDto"
                                           name: "Survey"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "FeedbackDto"
                                       "SchemaExtractor.Model.Example.SurveyDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Title"
                                           nullable: false
                                         - type: "date"
                                           name: "CreatedDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Creator"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.QuestionDto"
                                           name: "Questions"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PollDto"
                                           name: "Polls"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "SurveyDto"
                                       "SchemaExtractor.Model.Example.QuestionDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Text"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AnswerDto"
                                           name: "Answers"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "QuestionDto"
                                       "SchemaExtractor.Model.Example.AnswerDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Response"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.QuestionDto"
                                           name: "Question"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Respondent"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "AnswerDto"
                                       "SchemaExtractor.Model.Example.PollDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Question"
                                           nullable: false
                                         - type: "date"
                                           name: "CreatedDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.OptionDto"
                                           name: "Options"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Creator"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "PollDto"
                                       "SchemaExtractor.Model.Example.OptionDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Text"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PollDto"
                                           name: "Poll"
                                           nullable: false
                                         - type: "int32"
                                           name: "VoteCount"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "OptionDto"
                                       "SchemaExtractor.Model.Example.PhoneDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Number"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Owner"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "PhoneDto"
                                       "SchemaExtractor.Model.Example.EmailDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "EmailAddress"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Owner"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "EmailDto"
                                       "SchemaExtractor.Model.Example.VehicleDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Make"
                                           nullable: false
                                         - type: "string"
                                           name: "Model"
                                           nullable: false
                                         - type: "int32"
                                           name: "Year"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Owner"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ServiceRecordDto"
                                           name: "ServiceRecords"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "VehicleDto"
                                       "SchemaExtractor.Model.Example.ServiceRecordDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "date"
                                           name: "ServiceDate"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.VehicleDto"
                                           name: "Vehicle"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ServiceRecordDto"
                                       "SchemaExtractor.Model.Example.FriendDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ContactDto"
                                           name: "Friend"
                                           nullable: false
                                         - type: "date"
                                           name: "FriendshipDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.MessageDto"
                                           name: "Messages"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "FriendDto"
                                       "SchemaExtractor.Model.Example.ContactDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "string"
                                           name: "PhoneNumber"
                                           nullable: false
                                         - type: "string"
                                           name: "Email"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Owner"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ContactDto"
                                       "SchemaExtractor.Model.Example.MessageDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Content"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Sender"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Recipient"
                                           nullable: false
                                         - type: "date"
                                           name: "Timestamp"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "MessageDto"
                                       "SchemaExtractor.Model.Example.SubscriptionDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "ServiceName"
                                           nullable: false
                                         - type: "date"
                                           name: "StartDate"
                                           nullable: false
                                         - type: "date"
                                           name: "EndDate"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Subscriber"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "SubscriptionDto"
                                       "SchemaExtractor.Model.Example.PaymentDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "double"
                                           name: "Amount"
                                           nullable: false
                                         - type: "date"
                                           name: "PaymentDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.InvoiceDto"
                                           name: "Invoice"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Payer"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "PaymentDto"
                                       "SchemaExtractor.Model.Example.InvoiceDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "date"
                                           name: "InvoiceDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.OrderDto"
                                           name: "Order"
                                           nullable: false
                                         - type: "double"
                                           name: "Amount"
                                           nullable: false
                                         - type: "date"
                                           name: "DueDate"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "InvoiceDto"
                                       "SchemaExtractor.Model.Example.OrderDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "date"
                                           name: "OrderDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Customer"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ProductDto"
                                           name: "Products"
                                           nullable: true
                                         - type: "double"
                                           name: "TotalAmount"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.InvoiceDto"
                                           name: "Invoice"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "OrderDto"
                                       "SchemaExtractor.Model.Example.BankAccountDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "AccountNumber"
                                           nullable: false
                                         - type: "double"
                                           name: "Balance"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Owner"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.TransactionDto"
                                           name: "Transactions"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "BankAccountDto"
                                       "SchemaExtractor.Model.Example.TransactionDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "double"
                                           name: "Amount"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.BankAccountDto"
                                           name: "FromAccount"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.BankAccountDto"
                                           name: "ToAccount"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "TransactionDto"
                                       "SchemaExtractor.Model.Example.TravelPlanDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Destination"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Traveler"
                                           nullable: false
                                         - type: "date"
                                           name: "StartDate"
                                           nullable: false
                                         - type: "date"
                                           name: "EndDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AccommodationDto"
                                           name: "Accommodations"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PassportDto"
                                           name: "PassportDto"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.HabitDto"
                                           name: "TravelHabits"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "TravelPlanDto"
                                       "SchemaExtractor.Model.Example.AccommodationDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "HotelName"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.AddressDto"
                                           name: "Location"
                                           nullable: false
                                         - type: "date"
                                           name: "CheckInDate"
                                           nullable: false
                                         - type: "date"
                                           name: "CheckOutDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Guest"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "AccommodationDto"
                                       "SchemaExtractor.Model.Example.PassportDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "PassportNumber"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Holder"
                                           nullable: false
                                         - type: "date"
                                           name: "IssueDate"
                                           nullable: false
                                         - type: "date"
                                           name: "ExpiryDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.VisaDto"
                                           name: "Visa"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "PassportDto"
                                       "SchemaExtractor.Model.Example.VisaDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "VisaType"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CountryDto"
                                           name: "IssuedBy"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Holder"
                                           nullable: false
                                         - type: "date"
                                           name: "IssueDate"
                                           nullable: false
                                         - type: "date"
                                           name: "ExpiryDate"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "VisaDto"
                                       "SchemaExtractor.Model.Example.HabitDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "HabitName"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.GoalDto"
                                           name: "Goal"
                                           nullable: false
                                         - type: "date"
                                           name: "StartDate"
                                           nullable: false
                                         - type: "date"
                                           name: "EndDate"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.RoutineDto"
                                           name: "RoutineDto"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "HabitDto"
                                       "SchemaExtractor.Model.Example.GoalDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: false
                                         - type: "date"
                                           name: "TargetDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ReminderDto"
                                           name: "Reminder"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "GoalDto"
                                       "SchemaExtractor.Model.Example.ReminderDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Message"
                                           nullable: false
                                         - type: "date"
                                           name: "RemindAt"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Person"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ReminderDto"
                                       "SchemaExtractor.Model.Example.RoutineDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "RoutineName"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Person"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.HabitDto"
                                           name: "Habits"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "RoutineDto"
                                       "SchemaExtractor.Model.Example.EducationDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Degree"
                                           nullable: false
                                         - type: "string"
                                           name: "Institution"
                                           nullable: false
                                         - type: "date"
                                           name: "StartDate"
                                           nullable: false
                                         - type: "date"
                                           name: "EndDate"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.SkillDto"
                                           name: "Skills"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.LanguageDto"
                                           name: "Languages"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "EducationDto"
                                       "SchemaExtractor.Model.Example.SkillDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "string"
                                           name: "Proficiency"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.CertificationDto"
                                           name: "Certifications"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.ExperienceDto"
                                           name: "Experience"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "SkillDto"
                                       "SchemaExtractor.Model.Example.CertificationDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "string"
                                           name: "Issuer"
                                           nullable: false
                                         - type: "date"
                                           name: "DateIssued"
                                           nullable: false
                                         - type: "date"
                                           name: "DateExpiry"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Person"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "CertificationDto"
                                       "SchemaExtractor.Model.Example.ExperienceDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Title"
                                           nullable: false
                                         - type: "string"
                                           name: "Company"
                                           nullable: false
                                         - type: "date"
                                           name: "StartDate"
                                           nullable: false
                                         - type: "date"
                                           name: "EndDate"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Person"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ExperienceDto"
                                       "SchemaExtractor.Model.Example.LanguageDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Name"
                                           nullable: false
                                         - type: "string"
                                           name: "Proficiency"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "People"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "LanguageDto"
                                       "SchemaExtractor.Model.Example.CaseDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "CaseNumber"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ReportDto"
                                           name: "Report"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: false
                                         - type: "date"
                                           name: "DateOpened"
                                           nullable: false
                                         - type: "date"
                                           name: "DateClosed"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.EvidenceDto"
                                           name: "Evidence"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.WitnessDto"
                                           name: "Witnesses"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.JurorDto"
                                           name: "Juror"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.SentenceDto"
                                           name: "Sentence"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.AppealDto"
                                           name: "Appeal"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.FileDto"
                                           name: "Files"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "CaseDto"
                                       "SchemaExtractor.Model.Example.ReportDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Title"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.ComplaintDto"
                                           name: "Complaint"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Author"
                                           nullable: false
                                         - type: "string"
                                           name: "Summary"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.RewardDto"
                                           name: "Reward"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ReportDto"
                                       "SchemaExtractor.Model.Example.ComplaintDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Complainant"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "ComplaintDto"
                                       "SchemaExtractor.Model.Example.RewardDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Person"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "RewardDto"
                                       "SchemaExtractor.Model.Example.EvidenceDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CaseDto"
                                           name: "Case"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "CollectedBy"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "EvidenceDto"
                                       "SchemaExtractor.Model.Example.WitnessDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Person"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CaseDto"
                                           name: "Case"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.TestimonyDto"
                                           name: "Testimony"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "WitnessDto"
                                       "SchemaExtractor.Model.Example.TestimonyDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Witness"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CaseDto"
                                           name: "Case"
                                           nullable: false
                                         - type: "string"
                                           name: "Statement"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "TestimonyDto"
                                       "SchemaExtractor.Model.Example.JurorDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Person"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CaseDto"
                                           name: "Case"
                                           nullable: false
                                         - type: "string"
                                           name: "Verdict"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "JurorDto"
                                       "SchemaExtractor.Model.Example.SentenceDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Description"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CaseDto"
                                           name: "Case"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.SettlementDto"
                                           name: "Settlement"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.FineDto"
                                           name: "Fine"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "SentenceDto"
                                       "SchemaExtractor.Model.Example.SettlementDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Terms"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CaseDto"
                                           name: "Case"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "SettlingParty"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "SettlementDto"
                                       "SchemaExtractor.Model.Example.FineDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Reason"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "double"
                                           name: "Amount"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Person"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "FineDto"
                                       "SchemaExtractor.Model.Example.AppealDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Reason"
                                           nullable: false
                                         - type: "date"
                                           name: "Date"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.CaseDto"
                                           name: "Case"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Appellant"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "AppealDto"
                                       "SchemaExtractor.Model.Example.FileDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "FileName"
                                           nullable: false
                                         - type: "string"
                                           name: "FilePath"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.FolderDto"
                                           name: "FolderDto"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.DocumentDto"
                                           name: "Document"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "FileDto"
                                       "SchemaExtractor.Model.Example.FolderDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "FolderName"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.FileDto"
                                           name: "Files"
                                           nullable: true
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Owner"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "FolderDto"
                                       "SchemaExtractor.Model.Example.DocumentDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "DocumentName"
                                           nullable: false
                                         - type: "string"
                                           name: "DocumentPath"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.NoteDto"
                                           name: "Note"
                                           nullable: true
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "DocumentDto"
                                       "SchemaExtractor.Model.Example.NoteDto":
                                         type: "Object"
                                         properties:
                                         - type: "int32"
                                           name: "Id"
                                           nullable: false
                                         - type: "string"
                                           name: "Content"
                                           nullable: false
                                         - type: "date"
                                           name: "CreatedAt"
                                           nullable: false
                                         - type: "SchemaExtractor.Model.Example.PersonDto"
                                           name: "Author"
                                           nullable: false
                                         namespace: "SchemaExtractor.Model.Example"
                                         name: "NoteDto"

                                       """;
}