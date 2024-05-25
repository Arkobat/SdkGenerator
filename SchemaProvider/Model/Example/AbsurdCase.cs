// ReSharper disable ClassNeverInstantiated.Global

namespace SchemaExtractor.Model.Example;

public class PersonDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public required AddressDto Address { get; set; }
    public HobbyDto? Hobbies { get; set; }
    public required JobDto Job { get; set; }
    public CalendarDto? Calendar { get; set; }
    public PhoneDto? Phones { get; set; }
    public EmailDto? Emails { get; set; }
    public VehicleDto? Vehicles { get; set; }
    public FriendDto? Friends { get; set; }
    public SubscriptionDto? Subscriptions { get; set; }
    public MeetingDto? Meetings { get; set; }
    public PaymentDto? Payments { get; set; }
    public BankAccountDto? BankAccounts { get; set; }
    public InsuranceDto? Insurances { get; set; }
    public TravelPlanDto? TravelPlans { get; set; }
    public EducationDto? Education { get; set; }
    public CaseDto? Cases { get; set; }
}

public class AddressDto
{
    public int Id { get; set; }
    public required string Street { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string ZipCode { get; set; }
    public required CountryDto Country { get; set; }
    public PersonDto? Residents { get; set; }
    public BusinessDto? Businesses { get; set; }
}

public class HobbyDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public PersonDto? Participants { get; set; }
    public HobbyEquipmentDto? Equipments { get; set; }
}

public class JobDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required CompanyDto Company { get; set; }
    public double Salary { get; set; }
    public PersonDto? Employees { get; set; }
    public DepartmentDto? Departments { get; set; }
}

public class CompanyDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required AddressDto Address { get; set; }
    public JobDto? Jobs { get; set; }
    public PersonDto? Employees { get; set; }
    public ProjectDto? Projects { get; set; }
}

public class CountryDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Code { get; set; }
    public AddressDto? Addresses { get; set; }
    public SchoolDto? Schools { get; set; }
    public HospitalDto? Hospitals { get; set; }
    public PersonDto? Citizens { get; set; }
}

public class VehicleDto
{
    public int Id { get; set; }
    public required string Make { get; set; }
    public required string Model { get; set; }
    public int Year { get; set; }
    public required PersonDto Owner { get; set; }
    public ServiceRecordDto? ServiceRecords { get; set; }
}

public class PhoneDto
{
    public int Id { get; set; }
    public required string Number { get; set; }
    public required PersonDto Owner { get; set; }
}

public class EmailDto
{
    public int Id { get; set; }
    public required string EmailAddress { get; set; }
    public required PersonDto Owner { get; set; }
}

public class ProjectDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public PersonDto? TeamMembers { get; set; }
    public required CompanyDto Company { get; set; }
    public TaskDto? Tasks { get; set; }
}

public class TaskDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required PersonDto AssignedTo { get; set; }
    public required ProjectDto Project { get; set; }
}

public class DepartmentDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required CompanyDto Company { get; set; }
    public JobDto? Jobs { get; set; }
    public PersonDto? Employees { get; set; }
    public ForumDto? InternalForum { get; set; }
}

public class EducationDto
{
    public int Id { get; set; }
    public required string Degree { get; set; }
    public required string Institution { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public required SkillDto Skills { get; set; }
    public required LanguageDto Languages { get; set; }
}

public class SkillDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Proficiency { get; set; }
    public CertificationDto? Certifications { get; set; }
    public ExperienceDto? Experience { get; set; }
}

public class CertificationDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Issuer { get; set; }
    public DateTime DateIssued { get; set; }
    public DateTime? DateExpiry { get; set; }
    public required PersonDto Person { get; set; }
}

public class LanguageDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Proficiency { get; set; }
    public PersonDto? People { get; set; }
}

public class ExperienceDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Company { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public required PersonDto Person { get; set; }
}

public class MeetingDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public PersonDto? Participants { get; set; }
    public required AddressDto Location { get; set; }
    public required AppointmentDto Appointment { get; set; }
}

public class CalendarDto
{
    public int Id { get; set; }
    public required PersonDto Owner { get; set; }
    public MeetingDto? Meetings { get; set; }
    public EventDto? Events { get; set; }
}

public class EventDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public DateTime Date { get; set; }
    public PersonDto? Attendees { get; set; }
    public required AddressDto Location { get; set; }
    public required EventRegistrationDto Registration { get; set; }
}

public class ReviewDto
{
    public int Id { get; set; }
    public required string Content { get; set; }
    public int Rating { get; set; }
    public required PersonDto Reviewer { get; set; }
    public required ProductDto Product { get; set; }
}

public class ProductDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public required CompanyDto Manufacturer { get; set; }
    public ReviewDto? Reviews { get; set; }
}

public class OrderDto
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public required PersonDto Customer { get; set; }
    public ProductDto? Products { get; set; }
    public double TotalAmount { get; set; }
    public InvoiceDto? Invoice { get; set; }
}

public class InvoiceDto
{
    public int Id { get; set; }
    public DateTime InvoiceDate { get; set; }
    public required OrderDto Order { get; set; }
    public double Amount { get; set; }
    public DateTime DueDate { get; set; }
}

public class PaymentDto
{
    public int Id { get; set; }
    public double Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public required InvoiceDto Invoice { get; set; }
    public required PersonDto Payer { get; set; }
}

public class BankAccountDto
{
    public int Id { get; set; }
    public required string AccountNumber { get; set; }
    public double Balance { get; set; }
    public required PersonDto Owner { get; set; }
    public TransactionDto? Transactions { get; set; }
}

public class TransactionDto
{
    public int Id { get; set; }
    public double Amount { get; set; }
    public DateTime Date { get; set; }
    public required BankAccountDto FromAccount { get; set; }
    public required BankAccountDto ToAccount { get; set; }
}

public class InsuranceDto
{
    public int Id { get; set; }
    public required string PolicyNumber { get; set; }
    public required string Provider { get; set; }
    public required PersonDto Insured { get; set; }
    public double CoverageAmount { get; set; }
    public required PolicyDto Policy { get; set; }
}

public class PolicyDto
{
    public int Id { get; set; }
    public required string PolicyName { get; set; }
    public required PersonDto PolicyHolder { get; set; }
    public double CoverageAmount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public InsuranceDto? Insurances { get; set; }
}

public class ServiceRecordDto
{
    public int Id { get; set; }
    public required DateTime ServiceDate { get; set; }
    public required string Description { get; set; }
    public required VehicleDto Vehicle { get; set; }
}

public class HobbyEquipmentDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required HobbyDto Hobby { get; set; }
    public double Price { get; set; }
}

public class FriendDto
{
    public int Id { get; set; }
    public required ContactDto Friend { get; set; }
    public DateTime FriendshipDate { get; set; }
    public MessageDto? Messages { get; set; }
}

public class SubscriptionDto
{
    public int Id { get; set; }
    public required string ServiceName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public required PersonDto Subscriber { get; set; }
}

public class BusinessDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required AddressDto Location { get; set; }
    public ProductDto? Products { get; set; }
    public PersonDto? Employees { get; set; }
}

public class ContactDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Email { get; set; }
    public required PersonDto Owner { get; set; }
}

public class MessageDto
{
    public int Id { get; set; }
    public required string Content { get; set; }
    public required PersonDto Sender { get; set; }
    public required PersonDto Recipient { get; set; }
    public DateTime Timestamp { get; set; }
}

public class AppointmentDto
{
    public int Id { get; set; }
    public required DateTime AppointmentDate { get; set; }
    public required PersonDto Person { get; set; }
    public required string Description { get; set; }
}

public class FileDto
{
    public int Id { get; set; }
    public required string FileName { get; set; }
    public required string FilePath { get; set; }
    public required FolderDto FolderDto { get; set; }
    public required DocumentDto Document { get; set; }
}

public class FolderDto
{
    public int Id { get; set; }
    public required string FolderName { get; set; }
    public FileDto? Files { get; set; }
    public required PersonDto Owner { get; set; }
}

public class DocumentDto
{
    public int Id { get; set; }
    public required string DocumentName { get; set; }
    public required string DocumentPath { get; set; }
    public NoteDto? Note { get; set; }
}

public class NoteDto
{
    public int Id { get; set; }
    public required string Content { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required PersonDto Author { get; set; }
}

public class ReminderDto
{
    public int Id { get; set; }
    public required string Message { get; set; }
    public required DateTime RemindAt { get; set; }
    public required PersonDto Person { get; set; }
}

public class GoalDto
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public required DateTime TargetDate { get; set; }
    public required ReminderDto Reminder { get; set; }
}

public class HabitDto
{
    public int Id { get; set; }
    public required string HabitName { get; set; }
    public required GoalDto Goal { get; set; }
    public required DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public RoutineDto? RoutineDto { get; set; }
}

public class RoutineDto
{
    public int Id { get; set; }
    public required string RoutineName { get; set; }
    public required PersonDto Person { get; set; }
    public HabitDto? Habits { get; set; }
}

public class TravelPlanDto
{
    public int Id { get; set; }
    public required string Destination { get; set; }
    public required PersonDto Traveler { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public AccommodationDto? Accommodations { get; set; }
    public required PassportDto PassportDto { get; set; }
    public HabitDto? TravelHabits { get; set; }
}

public class AccommodationDto
{
    public int Id { get; set; }
    public required string HotelName { get; set; }
    public required AddressDto Location { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public required PersonDto Guest { get; set; }
}

public class PassportDto
{
    public int Id { get; set; }
    public required string PassportNumber { get; set; }
    public required PersonDto Holder { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public VisaDto? Visa { get; set; }
}

public class VisaDto
{
    public int Id { get; set; }
    public required string VisaType { get; set; }
    public required CountryDto IssuedBy { get; set; }
    public required PersonDto Holder { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpiryDate { get; set; }
}

public class EventRegistrationDto
{
    public int Id { get; set; }
    public required EventDto Event { get; set; }
    public required PersonDto Participant { get; set; }
    public DateTime RegistrationDate { get; set; }
    public WorkshopDto? Workshop { get; set; }
}

public class WorkshopDto
{
    public int Id { get; set; }
    public required string WorkshopName { get; set; }
    public required DateTime Date { get; set; }
    public required AddressDto Location { get; set; }
    public SessionDto? Session { get; set; }
}

public class SessionDto
{
    public int Id { get; set; }
    public required string SessionName { get; set; }
    public required DateTime StartTime { get; set; }
    public required DateTime EndTime { get; set; }
    public required WorkshopDto Workshop { get; set; }
    public FeedbackDto? Feedback { get; set; }
}

public class FeedbackDto
{
    public int Id { get; set; }
    public required string Content { get; set; }
    public required DateTime Date { get; set; }
    public required PersonDto Author { get; set; }
    public required SurveyDto Survey { get; set; }
}

public class SurveyDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required DateTime CreatedDate { get; set; }
    public required PersonDto Creator { get; set; }
    public QuestionDto? Questions { get; set; }
    public PollDto? Polls { get; set; }
}

public class QuestionDto
{
    public int Id { get; set; }
    public required string Text { get; set; }
    public AnswerDto? Answers { get; set; }
}

public class AnswerDto
{
    public int Id { get; set; }
    public required string Response { get; set; }
    public required QuestionDto Question { get; set; }
    public required PersonDto Respondent { get; set; }
}

public class PollDto
{
    public int Id { get; set; }
    public required string Question { get; set; }
    public required DateTime CreatedDate { get; set; }
    public OptionDto? Options { get; set; }
    public required PersonDto Creator { get; set; }
}

public class OptionDto
{
    public int Id { get; set; }
    public required string Text { get; set; }
    public required PollDto Poll { get; set; }
    public int VoteCount { get; set; }
}

public class ArticleDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public required PersonDto Author { get; set; }
    public DateTime PublishedDate { get; set; }
    public CommentDto? Comments { get; set; }
}

public class CommentDto
{
    public int Id { get; set; }
    public required string Content { get; set; }
    public required DateTime Date { get; set; }
    public required PersonDto Author { get; set; }
    public required ArticleDto Article { get; set; }
    public TagDto? Tags { get; set; }
}

public class TagDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ArticleDto? Articles { get; set; }
}

public class ForumDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public ThreadDto? Threads { get; set; }
    public required ActivityLogDto ActivityLog { get; set; }
}

public class ThreadDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required ForumDto Forum { get; set; }
    public required PersonDto Creator { get; set; }
    public required CategoryDto Category { get; set; }
    public PostDto? Posts { get; set; }
}

public class CategoryDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ArticleDto? Articles { get; set; }
}

public class PostDto
{
    public int Id { get; set; }
    public required string Content { get; set; }
    public required DateTime Date { get; set; }
    public required ThreadDto Thread { get; set; }
    public required PersonDto Author { get; set; }
    public AchievementDto? Achievement { get; set; }
}

public class NotificationDto
{
    public int Id { get; set; }
    public required string Message { get; set; }
    public required DateTime Date { get; set; }
    public required PersonDto Recipient { get; set; }
}

public class ActivityLogDto
{
    public int Id { get; set; }
    public required string Activity { get; set; }
    public required DateTime Date { get; set; }
    public required NotificationDto Notifications { get; set; }
}

public class AchievementDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required DateTime DateAchieved { get; set; }
    public required PersonDto Person { get; set; }
}

public class RewardDto
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public required DateTime Date { get; set; }
    public required PersonDto Person { get; set; }
}

public class FineDto
{
    public int Id { get; set; }
    public required string Reason { get; set; }
    public required DateTime Date { get; set; }
    public double Amount { get; set; }
    public required PersonDto Person { get; set; }
}

public class ComplaintDto
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public required DateTime Date { get; set; }
    public required PersonDto Complainant { get; set; }
}

public class ReportDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required ComplaintDto Complaint { get; set; }
    public required DateTime Date { get; set; }
    public required PersonDto Author { get; set; }
    public string? Summary { get; set; }
    public RewardDto? Reward { get; set; }
}

public class CaseDto
{
    public int Id { get; set; }
    public required string CaseNumber { get; set; }
    public required ReportDto Report { get; set; }
    public required string Description { get; set; }
    public required DateTime DateOpened { get; set; }
    public DateTime? DateClosed { get; set; }
    public required EvidenceDto Evidence { get; set; }
    public required WitnessDto Witnesses { get; set; }
    public required JurorDto Juror { get; set; }
    public SentenceDto? Sentence { get; set; }
    public AppealDto? Appeal { get; set; }
    public  required FileDto Files { get; set; }
}

public class EvidenceDto
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public required DateTime Date { get; set; }
    public required CaseDto Case { get; set; }
    public required PersonDto CollectedBy { get; set; }
}

public class WitnessDto
{
    public int Id { get; set; }
    public required PersonDto Person { get; set; }
    public required CaseDto Case { get; set; }
    public required TestimonyDto Testimony { get; set; }
    public DateTime Date { get; set; }
}

public class TestimonyDto
{
    public int Id { get; set; }
    public required PersonDto Witness { get; set; }
    public required CaseDto Case { get; set; }
    public required string Statement { get; set; }
    public DateTime Date { get; set; }
}

public class JurorDto
{
    public int Id { get; set; }
    public required PersonDto Person { get; set; }
    public required CaseDto Case { get; set; }
    public required string Verdict { get; set; }
    public DateTime Date { get; set; }
}

public class SentenceDto
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public required DateTime Date { get; set; }
    public required CaseDto Case { get; set; }
    public SettlementDto? Settlement { get; set; }
    public FineDto? Fine { get; set; }
}

public class AppealDto
{
    public int Id { get; set; }
    public required string Reason { get; set; }
    public required DateTime Date { get; set; }
    public required CaseDto Case { get; set; }
    public required PersonDto Appellant { get; set; }
}

public class SettlementDto
{
    public int Id { get; set; }
    public required string Terms { get; set; }
    public required DateTime Date { get; set; }
    public required CaseDto Case { get; set; }
    public required PersonDto SettlingParty { get; set; }
}

public class MedicalRecordDto
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public required DateTime Date { get; set; }
    public required PersonDto Patient { get; set; }
    public required DoctorDto Doctor { get; set; }
    public PrescriptionDto? Prescriptions { get; set; }
    public InsuranceClaimDto? InsuranceClaim { get; set; }
    public BenefitDto? Benefit { get; set; }
}

public class DoctorDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required HospitalDto Hospital { get; set; }
}

public class HospitalDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required AddressDto Address { get; set; }
    public DoctorDto? Doctors { get; set; }
    public PatientDto? Patients { get; set; }
}

public class PatientDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required HospitalDto Hospital { get; set; }
    public MedicalRecordDto? MedicalRecords { get; set; }
}

public class PrescriptionDto
{
    public int Id { get; set; }
    public required string Medication { get; set; }
    public required DateTime Date { get; set; }
    public required DoctorDto Doctor { get; set; }
    public required PersonDto Patient { get; set; }
}

public class InsuranceClaimDto
{
    public int Id { get; set; }
    public required string ClaimNumber { get; set; }
    public required DateTime Date { get; set; }
    public required PersonDto Claimant { get; set; }
    public required InsuranceDto Insurance { get; set; }
}

public class BenefitDto
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public required PersonDto Beneficiary { get; set; }
    public required InsuranceDto Insurance { get; set; }
}

public class EnrollmentDto
{
    public int Id { get; set; }
    public required string Course { get; set; }
    public required DateTime Date { get; set; }
    public required PersonDto Student { get; set; }
    public required SchoolDto School { get; set; }
}

public class SchoolDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required AddressDto Address { get; set; }
    public EnrollmentDto? Enrollments { get; set; }
    public CourseDto? Courses { get; set; }
}

public class CourseDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required SchoolDto School { get; set; }
    public required TranscriptDto Transcript { get; set; }
    public EnrollmentDto? Enrollments { get; set; }
}

public class TranscriptDto
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public required DateTime Date { get; set; }
    public required PersonDto Student { get; set; }
    public required SchoolDto School { get; set; }
}